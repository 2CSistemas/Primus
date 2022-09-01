using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormOfd_PropostaRevisaoPerfuracoes : Aplicacao.IntermediariasTela.FormManutOfd_PropostaRevisaoPerfuracoesIntermediaria
    {
        public FormOfd_PropostaRevisaoPerfuracoes()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            ConfigurarGridPerfuracoes();
		}

        private void ConfigurarGridPerfuracoes()
        {
            object[] parms = new[] { new Ofd_PropostaPerfuracoes() { PropostaRevisao = Selecionado } };
            Type formType = typeof(FormOfd_PropostaPerfuracoes);

            btIncluirPerfuracao.SubFormType = btAlterarPerfuracao.SubFormType = btExcluirPerfuracao.SubFormType = btConsultarPerfuracao.SubFormType = formType;
            btIncluirPerfuracao.SubFormTypeParams = btAlterarPerfuracao.SubFormTypeParams = btExcluirPerfuracao.SubFormTypeParams = btConsultarPerfuracao.SubFormTypeParams = parms;

            //FormOfd_PropostaPerfuracoes form = new FormOfd_PropostaPerfuracoes() { Selecionado = new Ofd_PropostaPerfuracoes() { PropostaRevisao = Selecionado } };
            //btIncluirPerfuracao.SubForm = form;
            //btAlterarPerfuracao.SubForm = form;
            //btExcluirPerfuracao.SubForm = form;
            //btConsultarPerfuracao.SubForm = form;
        }
    }
}
