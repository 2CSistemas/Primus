using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.RelatoriosMatriciais;
using DevExpress.XtraGrid;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Estoque
{
    public partial class GridRequisicaoBaixada : Aplicacao.IntermediariasTela.GridNotaIntermediaria
    {
        private InOutType inOut;

        public static GridRequisicaoBaixada Get(InOutType inOut)
        {
            var itens = NotaController.Instancia.GetAllRequisicoesBaixadas(inOut);
            return new GridRequisicaoBaixada(itens, inOut, null, false, typeof(FormNota), new object[] { inOut });
        }

        private GridRequisicaoBaixada(IList<Nota> lista, InOutType inOut, Nota selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            this.inOut = inOut;

            sbIncluir.Enabled = false;
            sbAlterar.Enabled = false;

            ConfigurarTitulo();
        }

        private void ConfigurarTitulo()
        {
            Text = "Tabela de Requisição Baixada ";
            if (inOut == InOutType.Entrada)
                Text += "de Entrada";
            else
                Text += "de Saída";
        }

        protected override void MontarColunas()
        {
            base.MontarColunas();

            RemoverColunasNaoUsadas();
        }

        private void RemoverColunasNaoUsadas()
        {
            var colunaTotalNota = gvPrincipal.Columns.ColumnByFieldName("TotalNota");
            if (colunaTotalNota != null)
                colunaTotalNota.Visible = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.F5:
                    RecarregarGrid();
                    break;
            }
        }

        private void RecarregarGrid()
        {
            gcPrincipal.DataSource = NotaController.Instancia.GetAllRequisicoesBaixadas(inOut);
            gvPrincipal.MoveLastVisible();
        }
    }
}
