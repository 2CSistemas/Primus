using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormImei : Aplicacao.IntermediariasTela.FormManutImeiIntermediaria
    {
        private Produto Produto;

        public FormImei(Imei objImei)
        {
            Selecionado = objImei;
        }

        public FormImei()
        {
        }

        public FormImei(NotaItem ni)
        {
            Produto = ni.Produto;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Produto = Produto ?? Selecionado.Produto;
        }
    }
}
