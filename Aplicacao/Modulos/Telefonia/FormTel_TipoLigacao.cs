using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormTel_TipoLigacao : Aplicacao.IntermediariasTela.FormManutTel_TipoLigacao
    {
        public FormTel_TipoLigacao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            object[] parms = new[] { new Tel_TipoLigacaoPreco() { TipoLigacao = Selecionado } };
            Type formType = typeof(FormTel_TipoLigacaoPreco);
            
            //FormTel_TipoLigacaoPreco form = new FormTel_TipoLigacaoPreco() { Selecionado = new Tel_TipoLigacaoPreco() { TipoLigacao = Selecionado } };

            btIncluirPreco.SubFormType = btAlterarPreco.SubFormType = btExcluirPreco.SubFormType = btConsultarPreco.SubFormType = formType;
            btIncluirPreco.SubFormTypeParams = btAlterarPreco.SubFormTypeParams = btExcluirPreco.SubFormTypeParams = btConsultarPreco.SubFormTypeParams = parms;

            //btIncluirPreco.SubForm = form;
            //btAlterarPreco.SubForm = form;
            //btExcluirPreco.SubForm = form;
            //btConsultarPreco.SubForm = form;
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            TelaProObjeto(tcPrincipal);
            base.btSubRegistro_Click(sender, e);
        }
    }
}
