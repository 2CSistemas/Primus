using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using Aplicacao.Modulos.Estoque;
using System.Linq;

namespace Aplicacao
{
    public partial class FormInventario : Aplicacao.IntermediariasTela.FormManutInventarioIntermediaria
    {
        public FormInventario()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            NosGridsPegarColunasDefinidasNaEntidade = false;
            ConfigurarGridProdutos();
            SetarTags();
            cbCodigoProprietario.SelectedIndex = 1;

            lkbFilial.SubFormType = typeof(FormFilial);
        }

        private void SetarTags()
        {
            tpProdutos.Tag = Selecionado;
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            TelaProObjeto(tcPrincipal);
            base.btSubRegistro_Click(sender, e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetarTags();

            if (Operacao == Acao.Incluir)
            {
                txtData.EditValue = System.DateTime.Today;
                cbCodigoProprietario.SelectedIndex = 0;
            }
        }

        private void ConfigurarGridProdutos()
        {
            btIncluir.SubFormType = btAlterar.SubFormType = btExcluir.SubFormType = btConsultar.SubFormType = typeof(FormInventarioProduto);
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            return base.ObjetoPraTela(pai);
        }

        private void gvListaProdutos_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "ProdutoNome")
                {
                    cwkGestao.Modelo.InventarioProduto valor1 = (cwkGestao.Modelo.InventarioProduto)(((IList<cwkGestao.Modelo.InventarioProduto>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex1];
                    cwkGestao.Modelo.InventarioProduto valor2 = (cwkGestao.Modelo.InventarioProduto)(((IList<cwkGestao.Modelo.InventarioProduto>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex2];
                    e.Handled = true;
                    e.Result = valor1.ProdutoNomeOrdenado.CompareTo(valor2.ProdutoNomeOrdenado);
                }
            }
            catch
            {
                e.Result = 0;
            }
        }


 
    }
}
