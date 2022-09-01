using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormOfd_PropostaMedicaoPerfuracao : Aplicacao.IntermediariasTela.FormManutOfd_PropostaMedicaoPerfuracaoIntermediaria
    {
        public FormOfd_PropostaMedicaoPerfuracao()
        {            
        }

        public FormOfd_PropostaMedicaoPerfuracao(Ofd_PropostaMedicaoPerfuracao propostaPerfuracao)
        {
            Selecionado = propostaPerfuracao;
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir) && Selecionado != null && Selecionado.PropostaMedicao != null)
            {
                if (Selecionado.PropostaMedicao.Perfuracoes.Count > 0)
                    txtSequencia.EditValue = Selecionado.PropostaMedicao.Perfuracoes.Max(c => c.Sequencia) + 1;
                else
                    txtSequencia.EditValue = 1;
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            TelaProObjeto(tpPrincipal);
            txtTotal.EditValue = Selecionado.Total;
        }
    }
}
