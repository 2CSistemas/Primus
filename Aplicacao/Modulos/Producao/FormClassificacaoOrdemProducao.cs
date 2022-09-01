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
    public partial class FormClassificacaoOrdemProducao : Aplicacao.IntermediariasTela.FormManutClassificacaoOrdemProducao
    {
        public FormClassificacaoOrdemProducao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }
        protected override void SetarMascaras()
        {
        }
        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Status = Convert.ToByte(cbStatus.SelectedIndex);
        }
        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }

        private void FormClassificacaoOrdemProducao_Shown(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = Selecionado.Status;
        }
    }
}
