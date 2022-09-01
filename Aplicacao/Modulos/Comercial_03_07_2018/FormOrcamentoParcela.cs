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
    internal partial class FormOrcamentoParcela : Aplicacao.IntermediariasTela.FormManutOrcamentoParcela
    {
        public FormOrcamentoParcela()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbTipoDocumento.SubForm = new FormTipoDocumento();
            lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);
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
