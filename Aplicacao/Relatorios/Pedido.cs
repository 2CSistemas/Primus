using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class Pedido : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        public Pedido()
        {
            InitializeComponent();
            Carrega();
            rgTipo.SelectedIndex = 0;
        }

        protected string MontaEmpresas()
        {
            string empresas = null;
            for (int i = 0; i < listaEmpresas.Count; i++)
            {
                if (i == listaEmpresas.Count - 1)
                    empresas += listaEmpresas[i].ID;
                else
                    empresas += (listaEmpresas[i].ID + ",");
            }
            return empresas.ToString();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            string relatorio = null;
            List<Modelo.Objeto.pxyRequisicao> lista = new List<Modelo.Objeto.pxyRequisicao>();
            List<Modelo.Objeto.pxyRequisicaoProdutoStatus> listaProduto = new List<Modelo.Objeto.pxyRequisicaoProdutoStatus>();
            Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext ();
            BLL.Pedido bllPedido = new BLL.Pedido(db);
            Relatorio.dsPedido ds = new Relatorio.dsPedido();
            Aplicacao.Base.FormRelatorioBase form;
            base.btOk_Click(sender, e);
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
            parametros.Add(p1);
            switch ((int)rgTipo.EditValue)
            {
                case 0:
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Relatorio", "Relatório de Pedido por Projeto");
                    parametros.Add(p2);
                    relatorio = "rptPedidoPorProjeto.rdlc";
                    lista = bllPedido.GetPedido(MontaEmpresas());
                    foreach (Modelo.Objeto.pxyRequisicao item in lista)
                    {
                        ds.dtPedido.AdddtPedidoRow(item.Cliente, item.CodigoPedido, item.Data, item.Estado, item.Projeto, item.ValorTotal);
                    }                    
                    form = new Aplicacao.Base.FormRelatorioBase(relatorio, "dsPedido_dtPedido", ds.dtPedido, parametros);
                    form.Show();
                    break;
                case 1:
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Relatorio", "Relatório de Pedido por Status");
                    parametros.Add(p3);
                    relatorio = "rptPedidoPorStatus.rdlc";
                    lista = bllPedido.GetPedido(MontaEmpresas());
                    foreach (Modelo.Objeto.pxyRequisicao item in lista)
                    {
                        ds.dtPedido.AdddtPedidoRow(item.Cliente, item.CodigoPedido, item.Data, item.Estado, item.Projeto, item.ValorTotal);
                    }                                       
                    form = new Aplicacao.Base.FormRelatorioBase(relatorio, "dsPedido_dtPedido", ds.dtPedido, parametros);
                    form.Show();
                    break;
                //case 2:
                //    relatorio = "rptPedidoPorStatusProduto.rdlc";
                //    listaProduto = bllPedido.GetRequisicaoProdutoStatus(MontaEmpresas());
                //    foreach (Modelo.Objeto.pxyRequisicaoProdutoStatus item in listaProduto)
                //    {
                //        ds.dtPedidoProduto.AdddtPedidoProdutoRow(item.Cliente, item.CodigoPedido, item.Data, item.Estado, item.Projeto,
                //            item.QuantidadeEntregue, item.QuantidadeNaoEntregue, item.Produto,
                //            item.Quantidade, item.CodigoProduto, item.Unidade, item.Status, item.Fracao);
                //    }                                        
                //    form = new Aplicacao.Base.FormRelatorioBase(relatorio, "dsPedido_dtPedidoProduto", ds.dtPedidoProduto, parametros);
                //    form.ShowDialog();
                //    this.Close();
                //    break;
            }
        }

        protected void PersonalizaGrid()
        {
            gvEmpresas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvEmpresas.OptionsView.ColumnAutoWidth = false;

            gvEmpresas.Columns["CNPJ"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvEmpresas.Columns["CNPJ"].Width = 132;
            gvEmpresas.Columns["CNPJ"].VisibleIndex = 1;
            gvEmpresas.Columns["CNPJ"].Caption = "CNPJ";

            gvEmpresas.Columns["Nome"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            gvEmpresas.Columns["Nome"].Width = 480;
            gvEmpresas.Columns["Nome"].VisibleIndex = 0;
            gvEmpresas.Columns["Nome"].Caption = "Nome";


            gvEmpresas.Columns["Código"].Visible = false;
            gvEmpresas.Columns["ID"].Visible = false;
        }
    }
}
