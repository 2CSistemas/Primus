using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormOfd_PropostaPerfuracoes : Aplicacao.IntermediariasTela.FormManutOfd_PropostaPerfuracoesIntermediaria
    {
        public FormOfd_PropostaPerfuracoes()
        {            
        }
        public FormOfd_PropostaPerfuracoes(Ofd_PropostaPerfuracoes perfuracoes)
        {
            Selecionado = perfuracoes;
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir) && Selecionado != null && Selecionado.PropostaRevisao != null)
            {
                if (Selecionado.PropostaRevisao.Perfuracoes.Count > 0)
                    txtSequencia.EditValue = Selecionado.PropostaRevisao.Perfuracoes.Max(c => c.Sequencia) + 1;
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
