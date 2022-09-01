using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System.Xml.Linq;

namespace Aplicacao.Relatorios
{
    public partial class OrdemProducaoFiltro : Aplicacao.Relatorios.Base.FormBase
    {
        protected IList<cwkGestao.Modelo.Filial> listaFiliais = new List<cwkGestao.Modelo.Filial>();

        public OrdemProducaoFiltro()
        {
            InitializeComponent();
        }

        private void chbClassificacao_CheckedChanged(object sender, EventArgs e)
        {
            cbClassificacaoOrdemProducao.Enabled = !chbClassificacao.Checked;
            btnClassificacao.Enabled = !chbClassificacao.Checked;
            cbClassificacaoOrdemProducao.EditValue = null;

        }

        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            cbCliente.Enabled = !chbCliente.Checked;
            btnCliente.Enabled = !chbCliente.Checked;
            cbCliente.EditValue = null;
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();

            cbClassificacaoOrdemProducao.Sessao = ClassificacaoOrdemProducaoController.Instancia.getSession();
            cbClassificacaoOrdemProducao.Exemplo = new cwkGestao.Modelo.ClassificacaoOrdemProducao();

            cbCliente.Sessao = PessoaController.Instancia.getSession();
            cbCliente.Exemplo = new cwkGestao.Modelo.Pessoa() { BCliente = true };
            cbCliente.CamposRestricoesAND = new List<String>() { "bCliente" };
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = listaFiliais = FilialController.Instancia.GetEmpresasDoGrupo((int)cbGrupo.EditValue);
        }

        private void btnClassificacao_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.ClassificacaoOrdemProducao> grid = new GridGenerica<cwkGestao.Modelo.ClassificacaoOrdemProducao>(cwkGestao.Negocio.ClassificacaoOrdemProducaoController.Instancia.GetAll(), new FormClassificacaoOrdemProducao(), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            cbClassificacaoOrdemProducao.EditValue = grid.Selecionado;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(cwkGestao.Negocio.PessoaController.Instancia.GetAllClientes(), new FormPessoa(), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            cbCliente.EditValue = grid.Selecionado;
        }

        protected override bool GerarRelatorio()
        {
            if (CamposValidos())
            {
                Aplicacao.Base.FormRelatorioBase form;
                string relatorio = null, tipo = null;
                if (radioGroup1.SelectedIndex == 0)
                {
                    relatorio = "rptOrdemProducaoPorClassificacao.rdlc";
                    tipo = "Ordem de Serviço Por Classificação";
                }
                else if (radioGroup1.SelectedIndex == 1)
                {
                    relatorio = "rptOrdemProducaoPorCliente.rdlc";
                    tipo = "Ordem de Serviço Por Cliente";
                }
                else
                {
                    relatorio = "rptOrdemProducaoPorData.rdlc";
                    tipo = "Ordem de Serviço Por Data";

                }
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", tipo);
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.DateTime.ToString());
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                Relatorio.dsImpressaoOrdemServicoTableAdapters.RelOrdemProducaoTableAdapter rel = new Relatorio.dsImpressaoOrdemServicoTableAdapters.RelOrdemProducaoTableAdapter();

                if (cbClassificacaoOrdemProducao.EditValue != null && cbCliente.EditValue != null)
                    form = new Aplicacao.Base.FormRelatorioBase(relatorio, "dsImpressaoOrdemServico_RelOrdemProducao", rel.GetData((int)cbClassificacaoOrdemProducao.ID, txtDataInicial.DateTime, txtDataFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), 1, (int)cbCliente.ID, MontaStringEmpresas()), parametros);
                else if (cbClassificacaoOrdemProducao.EditValue != null && cbCliente.EditValue == null)
                    form = new Aplicacao.Base.FormRelatorioBase(relatorio, "dsImpressaoOrdemServico_RelOrdemProducao", rel.GetData((int)cbClassificacaoOrdemProducao.ID, txtDataInicial.DateTime, txtDataFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), 2, 0, MontaStringEmpresas()), parametros);
                else if (cbCliente.EditValue != null && cbClassificacaoOrdemProducao.EditValue == null)
                    form = new Aplicacao.Base.FormRelatorioBase(relatorio, "dsImpressaoOrdemServico_RelOrdemProducao", rel.GetData(0, txtDataInicial.DateTime, txtDataFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), 3, (int)cbCliente.ID, MontaStringEmpresas()), parametros);
                else
                    form = new Aplicacao.Base.FormRelatorioBase(relatorio, "dsImpressaoOrdemServico_RelOrdemProducao", rel.GetData(0, txtDataInicial.DateTime, txtDataFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), 0, 0, MontaStringEmpresas()), parametros);
                form.Show();
                return true;
            }
            return false;
        }

        private bool CamposValidos()
        {
            bool ret = true;
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("Preencha os campos corretamente:");
            if ((txtDataFinal.EditValue == null || txtDataInicial.EditValue == null)
                || (txtDataInicial.DateTime == new DateTime() || txtDataFinal.DateTime == new DateTime()))
            {
                ret = false;
                msg.AppendLine("Período: Preencha as datas inicial e final corretamente.");
                dxErroProvider.SetError(txtDataInicial, "Campo obrigatório.");
            }
            else
            {
                if (txtDataInicial.DateTime > txtDataFinal.DateTime)
                {
                    ret = false;
                    msg.AppendLine("Data inicial maior que a data final.");
                    dxErroProvider.SetError(txtDataInicial, "Campo obrigatório");
                }
            }

            if (!chbClassificacao.Checked && (cbClassificacaoOrdemProducao.EditValue == null || (int)cbClassificacaoOrdemProducao.ID == 0))
            {
                ret = false;
                msg.AppendLine("Classificação: Selecione a classificação.");
                dxErroProvider.SetError(cbClassificacaoOrdemProducao, "Campo obrigatório.");
            }
            else
                dxErroProvider.SetError(cbClassificacaoOrdemProducao, "");

            if (!chbCliente.Checked && (cbCliente.EditValue == null || (int)cbCliente.ID == 0))
            {
                ret = false;
                msg.AppendLine("Cliente: Selecione o cliente.");
                dxErroProvider.SetError(cbCliente, "");
            }
            else
                dxErroProvider.SetError(cbCliente, "");

            if (cbGrupo.EditValue == null || cbGrupo.EditValue.ToString() == "")
            {
                ret = false;
                msg.AppendLine("Grupo: Selecione o grupo.");
                dxErroProvider.SetError(cbGrupo, "Campo obrigatório.");
            }
            else
                dxErroProvider.SetError(cbGrupo, "");

            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                msg.AppendLine("Empresas: Selecione pelo menos uma empresa.");
                ret =false;
            }

            if (!ret)
                MessageBox.Show(msg.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return ret;
        }

        protected string MontaStringEmpresas()
        {
            XElement empresas = new XElement("Empresas");
            int[] selectedRowHandles = gvPrincipal.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                XElement empresa = new XElement("Empresa");
                empresa.SetAttributeValue("id", ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(selectedRowHandles[i])).ID);
                empresas.Add(empresa);
            }
            return empresas.ToString();
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
    }
}