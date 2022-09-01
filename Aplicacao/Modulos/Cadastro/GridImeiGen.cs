using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class GridImeiGen : GridImeiGenIntermediaria
    {
        private Imei imei;

        #region Construtores

        public GridImeiGen(IList<Imei> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : this(lista, null, false, adicionarFiltro, formManut, parametros)
        {

        }

        public GridImeiGen(IList<Imei> lista, Imei selecionado, bool selecionarVarios, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            this.imei = selecionado;
            InitializeComponent();
        }

        #endregion

        protected override void Incluir()
        {
            VerificaForm();
            FormManut.Selecionado = InstanciarNovoSelecionado();
            FormManut.Selecionado.Produto = imei.Produto;
            FormManut.Operacao = cwkGestao.Modelo.Acao.Incluir;
            FormManut.ShowDialog();

            if (FormManut.Selecionado != null)
            {
                lista.Add(FormManut.Selecionado);
                SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(lista.IndexOf(FormManut.Selecionado)));
            }
            AtualizarGrid();
        }

        protected override Imei InstanciarNovoSelecionado()
        {
            return new Imei(Selecionado.Produto);
        }
    }
}
