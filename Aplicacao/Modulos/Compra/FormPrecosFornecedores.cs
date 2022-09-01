using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Aplicacao
{
    public partial class FormPrecosFornecedores : Aplicacao.IntermediariasTela.FormManutCotacaoIntermediaria
    {
        

        public FormPrecosFornecedores(Cotacao selc)
        {
            Selecionado = selc;
            Selecionado.CotacaoProdutos = Selecionado.CotacaoProdutos.Distinct().ToList();
        }

        protected override void InitializeChildComponents()
        {
            
            InitializeComponent();
            Operacao = Acao.Alterar;
            
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            base.AcoesAntesBase_Load(sender, e);
            CriaColunasFornecedor();

        }

        private void CriaColunasFornecedor()
        {
            for (int i = 3; i < gvCotacaoProdutos.Columns.Count; i++ )
            {
                gvCotacaoProdutos.Columns.RemoveAt(i);
            }
            for (int i = 1; i < 7; i++)
            {
                var coluna = CriaColuna(i);
                if (coluna != null) gvCotacaoProdutos.Columns.Add(coluna);
            }
            gvCotacaoProdutos.Columns["DescricaoProduto"].Width = 180 + 80 * (9 - gvCotacaoProdutos.Columns.Count);
            gvCotacaoProdutos.RefreshData();
            
        }

        private GridColumn CriaColuna(int fornecedorIndex)
        {
            Pessoa fornecedor = PessoaController.Instancia.LoadObjectById(
                    (int) Selecionado.GetType().GetProperty("IDFornecedor_0" + fornecedorIndex).GetValue(Selecionado, null));
            if(fornecedor == null) return null;
            var ret = new GridColumn(){FieldName = "Preco_0" + fornecedorIndex , Caption = fornecedor.Nome, VisibleIndex = 3 + fornecedorIndex, Width = 80} ;
            ret.DisplayFormat.FormatString = "c2";
            ret.DisplayFormat.FormatType = FormatType.Numeric;
            ret.SummaryItem.SummaryType = SummaryItemType.Sum;
            ret.SummaryItem.DisplayFormat = "{0:c2}";
            ret.SummaryItem.FieldName = "PrecoMultiplicado_0" + fornecedorIndex;
            ret.OptionsColumn.AllowSort = DefaultBoolean.False;
            ret.Tag = fornecedorIndex;
            return ret;
        }

       
        private void gvCotacaoProdutos_Click(object sender, EventArgs e)
        {
            Point posicao = gcCotacaoProdutos.PointToClient(MousePosition);
            GridHitInfo info = gvCotacaoProdutos.CalcHitInfo(posicao);
            if (info.HitTest == GridHitTest.Column && info.Column.Tag != null)
            {
                var formDadosFornecedor = new FormDadosFornecedor((int) info.Column.Tag);
                formDadosFornecedor.Selecionado = Selecionado;
                formDadosFornecedor.ShowDialog();
            }
        }

   
        
    }
}
