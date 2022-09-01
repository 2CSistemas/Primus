using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using Cwork.Utilitarios.Componentes;
using DevExpress.Data;

namespace Aplicacao
{
    public partial class FormHistoricoCliente : Form
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();

        Modelo.Cliente objCliente = new Modelo.Cliente();
        Modelo.Filial objEmpresa = new Modelo.Filial();
        Modelo.Acrescimo objAcrescimo = new Modelo.Acrescimo();
        Modelo.Condicao objCondicao = new Modelo.Condicao();
        Modelo.Banco objBanco = new Modelo.Banco();
        Modelo.Portador objPortador = new Modelo.Portador();
        Modelo.Historico objHistorico = new Modelo.Historico();

        BLL.Documento bllDocumento = new BLL.Documento();
        BLL.FinanceiroParcela bllParcela = new BLL.FinanceiroParcela();

        List<Modelo.Objeto.FinanceiroParcela> listaparcelas = new List<Modelo.Objeto.FinanceiroParcela>();

        decimal totalSum;

        public FormHistoricoCliente()
        {
            InitializeComponent();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormExtratoCliente_Load(object sender, EventArgs e)
        {
            //Carrega o combo com os clientes
            cbCliente.Properties.DataSource = objCliente.getListaCombo(db);
            cbCliente.Properties.DisplayMember = "Nome";
            cbCliente.Properties.ValueMember = "ID";
            cbCliente.EditValue = 0;

            //Carrega o combo com as empresas
            cbEmpresa.Properties.DataSource = objEmpresa.getListaCombo(db);
            cbEmpresa.Properties.DisplayMember = "Nome";
            cbEmpresa.Properties.ValueMember = "ID";
            cbEmpresa.EditValue = 0;

            cbPeriodo.SelectedIndex = 3;
        }

        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            gcDocumentos.DataSource = bllDocumento.getHistoricoCliente(db, Modelo.TipoDocumentoType.Receber, (DateTime)dtInicial.EditValue, (DateTime)dtFinal.EditValue, (int)cbCliente.EditValue);

            gvDocumentos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvDocumentos.OptionsView.ShowFooter = true;

            gvDocumentos.Columns["Filial"].Visible = false;
            gvDocumentos.Columns["ID"].Visible = false;
            gvDocumentos.Columns["NomeFantasia"].Visible = false;

            gvDocumentos.Columns["Codigo"].Caption = "Código";
            gvDocumentos.Columns["Codigo"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvDocumentos.Columns["Codigo"].Width = 70;

            gvDocumentos.Columns["Doc"].Caption = "Num.";
            gvDocumentos.Columns["Doc"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvDocumentos.Columns["Doc"].Width = 70;

            gvDocumentos.Columns["TipoDocumento"].Caption = "Tipo";
            gvDocumentos.Columns["TipoDocumento"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvDocumentos.Columns["TipoDocumento"].Width = 70;

            gvDocumentos.Columns["Data"].Caption = "Emissão";
            gvDocumentos.Columns["Data"].Width = 100;
            gvDocumentos.Columns["Data"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gvDocumentos.Columns["Vencimento"].Width = 100;
            gvDocumentos.Columns["Vencimento"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gvDocumentos.Columns["DtPagamento"].Caption = "Pagamento";
            gvDocumentos.Columns["DtPagamento"].Width = 100;
            gvDocumentos.Columns["DtPagamento"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gvDocumentos.Columns["DiasAtraso"].Caption = "Atraso";
            gvDocumentos.Columns["DiasAtraso"].Width = 70;
            gvDocumentos.Columns["DiasAtraso"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvDocumentos.Columns["DiasAtraso"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Average, "{0:N2}");

            gvDocumentos.Columns["Valor"].Caption = "Valor Doc.";
            gvDocumentos.Columns["Valor"].Width = 110;
            gvDocumentos.Columns["Valor"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvDocumentos.Columns["Valor"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvDocumentos.Columns["Valor"].DisplayFormat.FormatString = "C2";
            gvDocumentos.Columns["Valor"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:C2}");

            gvDocumentos.Columns["Saldo"].Caption = "Saldo";
            gvDocumentos.Columns["Saldo"].Width = 110;
            gvDocumentos.Columns["Saldo"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvDocumentos.Columns["Saldo"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvDocumentos.Columns["Saldo"].DisplayFormat.FormatString = "C2";
            gvDocumentos.Columns["Saldo"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:C2}");

            gvDocumentos.Columns["Situação"].Caption = "Situação";
            gvDocumentos.Columns["Situação"].Width = 70;
            gvDocumentos.Columns["Situação"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            //gvDocumentos.SelectAll();
        }

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridComboLookupPessoa(cbCliente, new FormPessoa(), cwkGestao.Negocio.PessoaController.Instancia.GetAll(),"Pessoa");
            cbCliente.Properties.DataSource = objCliente.getListaCombo(db);
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridComboLookup(cbEmpresa, new FormFilial());

            cbEmpresa.Properties.DataSource = objEmpresa.getListaCombo(db);
        }

        void InitStartValue()
        {
            totalSum = 0;
        }

        private void gvDocumentos_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            //if (e.SummaryProcess == CustomSummaryProcess.Start)
            //{
            //    InitStartValue();
            //}
            //if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            //{
            //    if (gvDocumentos.IsRowSelected(e.RowHandle))
            //    {
            //        if (e.IsTotalSummary) totalSum += (decimal)e.FieldValue;
            //    }
            //    if (e.IsTotalSummary)
            //        e.TotalValue = totalSum;
            //}
        }

        private void gvDocumentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gvDocumentos.UpdateSummary();
        }

        private void txtBuscaPessoa_Leave(object sender, EventArgs e)
        {
            if (txtBuscaPessoa.EditValue != null)
            {
                int idPessoa = 0;

                int qtd = objCliente.getQtdPessoa(db, txtBuscaPessoa.EditValue.ToString(), out idPessoa);

                if (qtd > 1)
                {
                    GridPadrao pGp = new GridPadrao("Tabela de PessoasFiltro", true, 0, txtBuscaPessoa.EditValue.ToString());
                    if (cwkControleUsuario.Facade.ControleAcesso(pGp))
                    {
                        //pGp.MdiParent = this;
                        pGp.ShowDialog();
                        if (!String.IsNullOrEmpty(pGp.Retorno))
                        {
                            cbCliente.EditValue = Convert.ToInt32(pGp.Retorno);
                        }
                    }
                }
                else if (qtd == 1)
                {
                    cbCliente.EditValue = idPessoa;
                }

                txtBuscaPessoa.EditValue = "";
            }
        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtInicial.Enabled = false;
            dtFinal.Enabled = false;
            dtFinal.DateTime = DateTime.Today;

            switch (cbPeriodo.SelectedIndex)
            {
                case 0:
                    dtInicial.DateTime = DateTime.Today.AddDays(-5);
                    break;
                case 1:
                    dtInicial.DateTime = DateTime.Today.AddDays(-15);
                    break;
                case 2:
                    dtInicial.DateTime = DateTime.Today.AddDays(-30);
                    break;
                case 3:
                    dtInicial.DateTime = DateTime.Today.AddDays(-60);
                    break;
                case 4:
                    dtInicial.DateTime = DateTime.Today.AddDays(-60);
                    dtInicial.Enabled = true;
                    dtFinal.Enabled = true;
                    break;
                case 5:
                    dtInicial.EditValue = null;
                    dtFinal.EditValue = null;
                    dtInicial.Enabled = false;
                    dtFinal.Enabled = false;
                    break;
            }
        }

        private void FormExtratoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, Text);
                    break;
            }
        }
    }
}
