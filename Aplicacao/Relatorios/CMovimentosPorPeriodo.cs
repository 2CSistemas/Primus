using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Relatorio.cwkGestaoDataSetTableAdapters;

namespace Aplicacao.Relatorios
{
    public partial class CMovimentosPorPeriodo : Aplicacao.Relatorios.FormBaseContas
    {
        private Modelo.TipoDocumentoType tipo;
        private bool porPedido;

        public CMovimentosPorPeriodo(Modelo.TipoDocumentoType tipo, bool porPedido)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.porPedido = porPedido;
            if (tipo == Modelo.TipoDocumentoType.Receber)
                this.Text = "Relatório de Movimento por Período a Receber";
            
            else
                this.Text = "Relatório de Movimento por Período a Pagar";

            if (porPedido)
            {
                this.Text += " - Pedido";
            }
            else
            {
                this.Size = new Size(752, 460);
                this.groupControl1.Visible = false;
                this.rgTipoRelatorio.Visible = false;

                this.labelControl4.Location = new Point(1, 335);
                this.cbSituacao.Location = new Point(52, 335);
                this.labelControl5.Location = new Point(463, 335);
                this.txtDtInicial.Location = new Point(509, 335);
                this.labelControl3.Location = new Point(595, 335);
                this.txtDtFinal.Location = new Point(607, 335);

            }
        }

        protected override void FormBase_Load(object sender, System.EventArgs e)
        {
            rgTipoRelatorio.EditValue = 0;

            base.FormBase_Load(sender, e);
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                if (porPedido)
                    GerarMovimentosPorPeriodoPorPedido(GetParametros()).Show();
                else
                    GerarMovimentosPorPeriodo(GetParametros()).Show();
            }
            else
                MessageBox.Show("Preencha os campos corretamente.");
        }

        private Form GerarMovimentosPorPeriodoPorPedido(List<ReportParameter> parametros)
        {
            var dadosMovimentos = GetDadosMovimentos();
            var dadosPedidos = GetDadosPedidos();
            string TipoRel = "";

            switch (rgTipoRelatorio.SelectedIndex)
            {
                case 0:
                    TipoRel = "rptMovimentoPorPeriodoPedido.rdlc";
                    break;
                case 1:
                    TipoRel = "rptMovimentoPorPeriodoPedidoTipoDocumento.rdlc";
                    break;
            }

            var form = new Aplicacao.Base.FormRelatorioBase(TipoRel, "cwkGestaoDataSet_p_MovimentoPorPeriodo"
                                                            , dadosMovimentos, "cwkGestaoDataSet_p_CReceberPedido_Lista", dadosPedidos, parametros);
            return form;
        }

        private Form GerarMovimentosPorPeriodo(List<ReportParameter> parametros)
        {
            var dados = GetDadosMovimentos();
            var form = new Aplicacao.Base.FormRelatorioBase("rptMovimentoPorPeriodo.rdlc", "cwkGestaoDataSet_p_MovimentoPorPeriodo"
                                                            , dados, parametros);
            return form;
        }

        private Relatorio.cwkGestaoDataSet.p_CReceberPedido_ListaDataTable GetDadosPedidos()
        {
            return new p_CReceberPedido_ListaTableAdapter().GetData(txtDtInicial.DateTime, txtDtFinal.DateTime, 2);
        }

        private Relatorio.cwkGestaoDataSet.p_MovimentoPorPeriodoDataTable GetDadosMovimentos()
        {
            return new p_MovimentoPorPeriodoTableAdapter()
                                    .GetData(cbSituacao.SelectedIndex.ToString(), txtDtInicial.DateTime
                                            , txtDtFinal.DateTime.AddDays(1).AddSeconds(-1), (int)tipo, MontaString(), 0);
        }

        private List<ReportParameter> GetParametros()
        {
            string tipostr;
            if (tipo == Modelo.TipoDocumentoType.Receber)
                tipostr = "Receber";
            else
                tipostr = "Pagar";

            if (porPedido)
                tipostr += " - Pedido";

            if (rgTipoRelatorio.SelectedIndex == 1)
                tipostr += "/Tp. Doc.";

            var parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("Titulo", Titulo.ToString()));
            parametros.Add(new ReportParameter("DataInicial", txtDtInicial.DateTime.ToString()));
            parametros.Add(new ReportParameter("DataFinal", txtDtFinal.DateTime.ToString()));
            parametros.Add(new ReportParameter("Situacao", cbSituacao.Text.ToString()));
            parametros.Add(new ReportParameter("Tipo", tipostr));
            return parametros;
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
    }
}
