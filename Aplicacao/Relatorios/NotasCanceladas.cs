using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class NotasCanceladas : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        Modelo.TipoNota objTipoNota = new Modelo.TipoNota();
        public NotasCanceladas()
        {
            InitializeComponent();
            cbMovimentacao.Properties.DataSource = objTipoNota.getListaCombo(db);
            Carrega();
            this.Text = "Relatório de Nota Cancelada";
        }

        private void chbMovimentacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMovimentacao.Checked)
            {
                cbMovimentacao.EditValue = 0;
                cbMovimentacao.Enabled = false;
            }
            else
            {
                cbMovimentacao.Enabled = true;
            }
        }

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            Aplicacao.GridPadrao pGp = new Aplicacao.GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getLista(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        protected bool ValidaCampos()
        {
            bool ret = true;
            if (txtDtInicial.DateTime == new DateTime())
            {
                ret = false;
                errorProvider1.SetError(txtDtInicial, "Campo Obrigatório");
            }
            if (cbGrupo.EditValue == null || cbGrupo.EditValue == "")
            {
                ret = false;
                errorProvider1.SetError(cbGrupo, "Campo Obrigatório");
            }
            if (txtDtFinal.DateTime == new DateTime())
            {
                ret = false;
                errorProvider1.SetError(txtDtFinal, "Campo Obrigatório");
            }
            if (txtDtFinal.DateTime < txtDtInicial.DateTime)
            {
                ret = false;
                errorProvider1.SetError(txtDtInicial, "Deve ser menor que a data final");
            }
            if ((cbMovimentacao.EditValue == null && !chbMovimentacao.Checked) || ((int)cbMovimentacao.EditValue == 0 && !chbMovimentacao.Checked))
            {
                ret = false;
                errorProvider1.SetError(chbMovimentacao, "Campo Obrigatório");
            }

            return ret;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            int TipoNota = 0;

            if (cbMovimentacao.EditValue != null && (int)cbMovimentacao.EditValue != 0)
                TipoNota = (int)cbMovimentacao.EditValue;
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                //Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString());
                //Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToString());
                //Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Situacao", "");
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToShortDateString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToShortDateString());
                //Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", "Contas a pagar por fornecedor");
                //parametros.Add(p1);
                //parametros.Add(p2);
                //parametros.Add(p3);
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                //parametros.Add(p5);

                Relatorio.cwkGestaoDataSetTableAdapters.p_Notas_CanceladasTableAdapter p_NotasTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_Notas_CanceladasTableAdapter();
                // inicializar o table adapter aki.
                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptNotasCanceladas.rdlc", "cwkGestaoDataSet_p_Notas_Canceladas", p_NotasTableAdapter.GetData(txtDtInicial.DateTime, txtDtFinal.DateTime, TipoNota.ToString(), MontaString()), parametros);
                form.Show();
                //this.Close();

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected string MontaString()
        {
            StringBuilder str = new StringBuilder("<Elementos>");
            str.Append(MontaStringEmpresas());
            str.Append("</Elementos>");
            return str.ToString();
        }

        private void sbMovimentacao_Click(object sender, EventArgs e)
        {
            //GridSelecao("Tabela de Movimentações", cbMovimentacao, objTipoNota);
            GridGenerica<cwkGestao.Modelo.TipoNota> grid = new GridGenerica<cwkGestao.Modelo.TipoNota>(cwkGestao.Negocio.TipoNotaController.Instancia.GetAll(), new FormTipoNota(), false);
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
                cbMovimentacao.EditValue = grid.Selecionado.ID;
        }
    }
}
