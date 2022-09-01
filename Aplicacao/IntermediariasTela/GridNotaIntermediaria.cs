using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridNotaIntermediaria : GridGenerica<Nota>
    {
        public GridNotaIntermediaria(IList<Nota> lista, IFormManut<Nota> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridNotaIntermediaria(IList<Nota> lista, Nota selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridNotaIntermediaria(IList<Nota> lista, Nota selecionado, bool adicionaFiltroGrid, DateTime? dataInicial, DateTime? dataFinal, Dictionary<string, object> parametros, Type formManut, params object[] parametrosFormFilho)
            : base(lista, selecionado, null, adicionaFiltroGrid, dataInicial, dataFinal, parametros, formManut, parametrosFormFilho)
        {

        }

        public GridNotaIntermediaria() : base() { }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sbIncluir
            // 
            this.sbIncluir.Click += new System.EventHandler(this.sbIncluir_Click_1);
            // 
            // GridNotaIntermediaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Name = "GridNotaIntermediaria";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private void sbIncluir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
