using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using Aplicacao.Modulos.Rel;
using Aplicacao.Util;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Estoque
{
    public partial class GridInventario : Aplicacao.IntermediariasTela.GridInventarioIntermediaria
    {
        public GridInventario(IList<Inventario> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {
            InitializeComponent();
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            FormGerarInventario form = new FormGerarInventario();
            form.ShowDialog();
            lista = InventarioController.Instancia.GetAll();
            gcPrincipal.DataSource = null;
            gcPrincipal.DataSource = lista;
            AtualizarGrid();
            RefreshGrid();
            gvPrincipal.MoveLastVisible();
            gvPrincipal.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("produto");
            dt.Columns.Add("quantidade");
            dt.Columns.Add("valor");
            dt.Columns.Add("total");

            var Inventario = gvPrincipal.GetRegistroSelecionado() as Inventario;
            if (Inventario == null)
            {
                MessageBox.Show("Selecione o Inventário.", "Impressão de Inventário.");
                return;
            }

            var Lista = InventarioProdutoController.Instancia.GetProdutosPorInventario(Inventario.ID);
            foreach (var Item in Lista)
            {
                var row = dt.NewRow();
                row["produto"] = Item.Produto;
                row["quantidade"] = Item.Quantidade;
                row["valor"] = Item.Valor;
                row["total"] = Item.Total;
                dt.Rows.Add(row);
            }

            var NomeEmpresa = FilialController.Instancia.GetFilialPrincipal().Nome;

            var RelatorioInventario = new XtraRelatorioInventario(NomeEmpresa, dt) { ShowPrintMarginsWarning = false };
            var tool = new ReportPrintTool(RelatorioInventario);
            tool.ShowPreview();
        }
    }
}
