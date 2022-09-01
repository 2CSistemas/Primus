using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class CReceberPorCliente : Aplicacao.Relatorios.FormBaseContas
    {
        BLL.Pessoa bllPessoa = new BLL.Pessoa();
        private bool _pedido;

        public CReceberPorCliente()
        {
            InitializeComponent();
            Name = "CReceberPorCliente";

            InicializaCampos();
        }

        public CReceberPorCliente(bool pedido)
        {
            InitializeComponent();
            _pedido = pedido;

            Name = "CReceberPorClientePedido";

            InicializaCampos();
        }

        private void InicializaCampos()
        {
            cbPessoa.Properties.DisplayMember = "Nome";
            cbPessoa.Properties.ValueMember = "ID";
            cbPessoa.EditValue = 0;
            cbPessoa.Enabled = false;
            btAdPessoa.Enabled = false;
        }

        protected override void FormBase_Load(object sender, System.EventArgs e)
        {
            base.FormBase_Load(sender, e);
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Situacao", cbSituacao.Text);
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", "Contas a receber por cliente" + (_pedido ? " - pedido" : ""));
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);

                Relatorio.cwkGestaoDataSet dt = new Relatorio.cwkGestaoDataSet();
                Aplicacao.Base.FormRelatorioBase form;
                if (_pedido)
                {
                    var p_CReceberPedidoTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter();
                    var p_CReceberPedidoListaTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberPedido_ListaTableAdapter();
                    form = new Aplicacao.Base.FormRelatorioBase("rptContasPorClientePedido.rdlc", "cwkGestaoDataSet_p_CReceber", p_CReceberPedidoTableAdapter.GetData("PES", cbSituacao.Text, txtDtInicial.DateTime, txtDtFinal.DateTime, (int)Modelo.TipoDocumentoType.Receber, MontaString(), (int?)cbPessoa.EditValue), "cwkGestaoDataSet_p_CReceberPedido_Lista", p_CReceberPedidoListaTableAdapter.GetData(txtDtInicial.DateTime, txtDtFinal.DateTime, 1), parametros);
                }
                else
                {
                    Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter p_CReceberTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter();
                    form = new Aplicacao.Base.FormRelatorioBase("rptContasPorCliente.rdlc", "cwkGestaoDataSet_p_CReceber", p_CReceberTableAdapter.GetData("PES", cbSituacao.Text, txtDtInicial.DateTime, txtDtFinal.DateTime, (int)Modelo.TipoDocumentoType.Receber, MontaString(), (int?)cbPessoa.EditValue), parametros);
                }
                form.Show();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }

        protected bool ValidaCampos()
        {
            bool ret = true;
            foreach (Control c in tabPage1.Controls)
            {
                errorProvider1.SetError(c, "");
                switch (c.Name)
                {
                    case "cbGrupo":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Escolha um grupo.");
                            ret = false;
                        }
                        break;
                    case "cbSituacao":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Campo não pode ficar em branco.");
                            ret = false;
                        }
                        else
                        {
                            if (!((DevExpress.XtraEditors.ComboBoxEdit)c).Properties.Items.Contains(c.Text))
                            {
                                errorProvider1.SetError(c, "Valor incorreto.");
                                ret = false;
                            }
                        }
                        break;
                    case "txtDtInicial":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data inicial.");
                            ret = false;
                        }
                        break;
                    case "txtDtFinal":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data final.");
                            ret = false;
                        }
                        break;
                }
            }
            return ret;
        }

        /// <summary>
        /// Método que chama o grid para selecionar um elemento
        /// </summary>
        /// <param name="ptitulo">Título do grid</param>
        /// <param name="pCb">combobox que irá chamar o grid</param>
        /// <param name="gl">objeto que irá retornar a lista para preencher o combo</param>
        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, BLL.InterfaceBLL gl)
        {
            Aplicacao.GridPadrao pGp = new Aplicacao.GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo();
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void btAdPessoa_Click(object sender, EventArgs e)
        {
            GridSelecao("Tabela de Cliente", cbPessoa, bllPessoa);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            cbPessoa.Enabled = chbFiltraCli.Checked;
            btAdPessoa.Enabled = chbFiltraCli.Checked;
            if (!chbFiltraCli.Checked)
            {
                cbPessoa.EditValue = 0;
            }
            else
            {
                if (cbPessoa.Properties.DataSource == null)
                {
                    cbPessoa.Properties.DataSource = bllPessoa.getListaCombo();
                    cbPessoa.EditValue = 0;
                }
            }
        }
    }
}
