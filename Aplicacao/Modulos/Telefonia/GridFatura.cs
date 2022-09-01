using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class GridFatura : Aplicacao.IntermediariasTela.GridFaturaIntermediaria
    {
        public GridFatura(IList<Tel_Fatura> lista, Type formManut, params object[] parametros)
            : base(lista, false, formManut) { }

        public GridFatura(IList<Tel_Fatura> lista, Tel_Fatura selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros) { }

        public GridFatura() { }

        protected override void Alterar()
        {
            if (GetRegistroSelecionado().Documento == null)
                base.Alterar();
            else
                MessageBox.Show("Esta fatura já possui boleto, operação não permitida.", "Faturar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void Excluir()
        {
            if (GetRegistroSelecionado().Documento == null)
                base.Excluir();
            else
                MessageBox.Show("Esta fatura já possui boleto, operação não permitida.", "Faturar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void GridGenerica_Shown(object sender, EventArgs e)
        {
            base.GridGenerica_Shown(sender, e);
        }       
    }
}
