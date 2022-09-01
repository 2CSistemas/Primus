using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Base;

namespace Aplicacao
{
    internal partial class FormNotaParcela : Aplicacao.IntermediariasTela.FormManutNotaParcela
    {
        public FormNotaParcela()
        {
        }

        protected override void InitializeChildComponents()
        {

            InitializeComponent();
            //lkbTipoDocumento.SubForm = new FormTipoDocumento();
            lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);
            //cbFormaPagamento.Properties.Items = ParcelaBase.EnumFormaPagamento;

            cbFormaPagamento.Properties.Items.Clear();

            NotaParcela novo = new NotaParcela();

            foreach (ParcelaBase.EnumFormaPagamento descricaoFormaPagamento in typeof(ParcelaBase.EnumFormaPagamento).GetEnumValues())
            {
                cbFormaPagamento.Properties.Items.Add(novo.DescFormaPagamentoCompleta(descricaoFormaPagamento));
            }
        }

        protected override void OK()
        {
            try
            {
                if (ValidarFormulario())
                {
                    TelaProObjeto(tpPrincipal);
                    Selecionado.BAlterado = true;
                    this.Close();
                }

            }
            catch (Exception exc)
            { new FormErro(exc); }
        }
    }
}
