using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Drawing;
using MoreLinq;
using System.Linq;
using Modelo.ModeloProxy;
using System.Data;

namespace Aplicacao.Relatorios
{
    public partial class RelDocumentoAtraso : Aplicacao.Relatorios.Base.FormBase
    {
        private cwkGestao.Negocio.Relatorios.ProdutosEstoque produtoEstoqueController;

        private Int32 IDPessoa { get; set; }

        public RelDocumentoAtraso()
        {
            InitializeComponent();

            lkpPessoa.Sessao = ProdutoController.Instancia.getSession();
            lkpPessoa.Exemplo = new Pessoa { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        private void HabilitaPessoa(bool habilita)
        {
            lkpPessoa.Enabled = habilita;
            lkbPessoa.Enabled = habilita;

            if (!habilita)
            {
                lkpPessoa.EditValue = null;
                IDPessoa = -1;
            }
        }

        protected override bool GerarRelatorio()
        {
            List<int> empresaIds = new List<int>();
            Configuracao config = ConfiguracaoController.Instancia.GetConfiguracao();
            if (!ExistemErros())
            {
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();

                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa", GetEmpresaRelatorio());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.EditValue.ToString().Substring(0, 10));
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.EditValue.ToString().Substring(0, 10));
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("IDPessoa", BuscaIdPessoa());
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("IDsEmpresas", MontaStringEmpresas());

                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);

                nomeRelatorio = @"rptDocumentoAtraso.rdlc";
                dataSet = "DocumentoAtraso_dtDocumentoAtraso";

                Relatorio.cwkGestaoDataSet dt = new Relatorio.cwkGestaoDataSet();
                Relatorio.DocumentoAtrasoTableAdapters.dtDocumentosAtrasoTableAdapter dtDocumentosAtrasoTableAdapter = new Relatorio.DocumentoAtrasoTableAdapters.dtDocumentosAtrasoTableAdapter();
                DataTable dtDocumentosAtrasoDataTable = dtDocumentosAtrasoTableAdapter.GetData(IDPessoa, txtDataInicial.DateTime, txtDataFinal.DateTime, MontaStringEmpresas());

                IList<pxyDocumentoAtraso> lstPxyDocAtraso = Extensions.ConvertTo<pxyDocumentoAtraso>(dtDocumentosAtrasoDataTable);

                foreach (pxyDocumentoAtraso objDocAtraso in lstPxyDocAtraso)
                {
                    List<ReparcelamentoDoc> ReparcelamentoDocs = new List<ReparcelamentoDoc>();
                    List<ReparcelamentoDoc> ReparcelamentoDocsRepositorio = ReparcelamentoDocController.Instancia.LoadByIdDocumento(objDocAtraso.IDDocumento).ToList();
                    ReparcelamentoDocs = RastreiaItensReparcelamento(ref ReparcelamentoDocs, ReparcelamentoDocsRepositorio);
                    objDocAtraso.AtrasoAcumulado = GetAtraso(ReparcelamentoDocs, objDocAtraso);
                    objDocAtraso.DiasAtraso = Math.Max(0, objDocAtraso.DiasAtraso);
                    objDocAtraso.AtrasoTotal = objDocAtraso.DiasAtraso + objDocAtraso.AtrasoAcumulado;
                }
                
                dtDocumentosAtrasoDataTable = Extensions.ToDataTable<pxyDocumentoAtraso>(lstPxyDocAtraso.Where(s => ((s.AtrasoAcumulado > 0) || (s.DiasAtraso > 0))).ToList());
                VisualizarRelatorio(dtDocumentosAtrasoDataTable, parametros);
                return true;
            }
            return false;
        }

        private int GetAtraso(List<ReparcelamentoDoc> reparcelamentoDocs, pxyDocumentoAtraso objDocAtraso)
        {
            int dias;
            try
            {
                DateTime dtDocumento = objDocAtraso.Vencimento;
                DateTime dtMaisAntiga = reparcelamentoDocs.Min(s => s.Documento.DtVencimento);
                dias = dtDocumento.Subtract(Convert.ToDateTime(dtMaisAntiga.ToShortDateString())).Days;
            }
            catch (Exception)
            {
                dias = 0;
            }
            return dias;
        }

        private static List<ReparcelamentoDoc> RastreiaItensReparcelamento(ref List<ReparcelamentoDoc> pReparcelamentoDocsNovo, IList<ReparcelamentoDoc> pReparcelamentoDocsAntigo)
        {
            try
            {
                if ((pReparcelamentoDocsAntigo != null) && (pReparcelamentoDocsAntigo.Count > 0))
                {
                    IList<Reparcelamento> ReparcelamentoAntigo = ReparcelamentoController.Instancia.LoadListByIdReparcelamento(pReparcelamentoDocsAntigo.Select(s => s.Reparcelamento.ID).DistinctBy(s => s).ToList());

                    List<ReparcelamentoDoc> ReparcelamentoDocsAntigo = ReparcelamentoAntigo.SelectMany(s => s.ReparcelamentoDocs).ToList();
                    List<int> idsDocumentoAntigo = ReparcelamentoDocsAntigo.Select(s => s.Documento.ID).ToList();

                    ReparcelamentoDocsAntigo.AddRange(ReparcelamentoDocController.Instancia.LoadListByIdDocumento(idsDocumentoAntigo));
                    pReparcelamentoDocsNovo.AddRange(ReparcelamentoDocsAntigo);
                    pReparcelamentoDocsNovo = pReparcelamentoDocsNovo.DistinctBy(s => s.ID).ToList();

                    IList<Reparcelamento> ReparcelamentoNovo = ReparcelamentoController.Instancia.LoadListByIdReparcelamento(pReparcelamentoDocsNovo.Select(s => s.Reparcelamento.ID).DistinctBy(s => s).ToList());
                    List<ReparcelamentoDoc> ReparcelamentoDocNovo = ReparcelamentoNovo.SelectMany(s => s.ReparcelamentoDocs).ToList();
                    List<int> idsDocumentoNovo = ReparcelamentoDocNovo.Select(s => s.Documento.ID).ToList();

                    if (idsDocumentoNovo.DistinctBy(s => s).Except(idsDocumentoAntigo.DistinctBy(s => s)).Count() > 0)
                    {
                        RastreiaItensReparcelamento(ref pReparcelamentoDocsNovo, pReparcelamentoDocsNovo);
                    }
                }
            }
            catch (Exception)
            {
                pReparcelamentoDocsNovo = new List<ReparcelamentoDoc>();
            }
            
            return pReparcelamentoDocsNovo;
        }

        private string BuscaIdPessoa()
        {
            if (lkpPessoa.Enabled && lkbPessoa.Enabled)
            {
                IDPessoa = lkpPessoa.Selecionado == null ? -1 : ((Pessoa)lkpPessoa.Selecionado).ID;
            }

            return IDPessoa.ToString();
        }

        private bool ExistemErros()
        {
            StringBuilder erros = new StringBuilder();
            dxErroProvider.ClearErrors();

            if (cbGrupo.EditValue == null)
            {
                dxErroProvider.SetError(cbGrupo, "Campo obrigatório.");
                erros.AppendLine("Grupo: Selecione um grupo.");
            }
            else if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                erros.AppendLine("Empresas: Selecione pelo menos uma empresa.");
            }
            else
            {
                dxErroProvider.SetError(cbGrupo, "");
            }

            if (txtDataInicial.DateTime == null || txtDataInicial.DateTime == new DateTime())
            {
                dxErroProvider.SetError(txtDataInicial, "Campo obrigatório");
                erros.AppendLine("Data Inicial: Selecione uma Data.");
            }
            else
            {
                dxErroProvider.SetError(txtDataInicial, "");
            }

            if (txtDataFinal.DateTime == null || txtDataFinal.DateTime == new DateTime())
            {
                dxErroProvider.SetError(txtDataFinal, "Campo obrigatório");
                erros.AppendLine("Data Final: Selecione uma Data.");
            }
            else
            {
                if (txtDataFinal.DateTime < txtDataInicial.DateTime)
                {
                    dxErroProvider.SetError(txtDataFinal, "A data final deve ser maior que a inicial.");
                    erros.AppendLine("Datas: A data final deve ser maior que a inicial.");
                }
                else
                {
                    dxErroProvider.SetError(txtDataFinal, "");
                }
            }

            if (!chbClientes.Checked && lkpPessoa.Selecionado == null)
            {
                dxErroProvider.SetError(lkpPessoa, "Campo obrigatório.");
                erros.AppendLine("Cliente: Selecione um Cliente.");
            }

            if (erros.Length > 0)
            {
                MessageBox.Show("Verificar anomalias:" + Environment.NewLine + erros.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void VisualizarRelatorio(DataTable resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }

        protected string MontaStringEmpresas()
        {
            List<Int32> lstIdsEmpresas = new List<Int32>();
            int[] selectedRowHandles = gvPrincipal.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                lstIdsEmpresas.Add(((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(selectedRowHandles[i])).ID);
            }

            return String.Join(",", lstIdsEmpresas);
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            GridCliente grid = new GridCliente(PessoaController.Instancia.GetAllClientes(), null, "Pessoa", false, typeof(FormPessoa));
            grid.Selecionando = true;
            grid.ShowDialog();


            lkpPessoa.EditValue = grid.Selecionado;
        }

        private void chbProduto_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaPessoa(!chbClientes.Checked);
        }

        private void lkpProduto_EnabledChanged(object sender, EventArgs e)
        {
            if (!lkpPessoa.Enabled)
            {
                lkpPessoa.ID = 0;
                lkpPessoa.EditValue = null;
            }
        }

        private void gvPrincipal_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }

        private void RelDocumentoAtraso_Shown(object sender, EventArgs e)
        {
            HabilitaPessoa(!chbClientes.Checked);
        }


    }
}
