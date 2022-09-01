using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFollowUp : FormManutFollowUp
    {
        public FollowUp F = null;
        public Acao A = Acao.Consultar;
        public bool Salvou = false;
        public FormFollowUp(FollowUp _F, Acao _A)
        {
            InitializeComponent();
            F = _F;
            A = _A;
        }

        private void PreencherTela()
        {
            txtData.Text = F.Data.ToString();
            txtDescricao.Text = F.Descricao;

            if (A == Acao.Consultar)
            {
                txtDescricao.Enabled = false;
                sbGravar.Enabled = false;
            }
        }

        private void FormFollowUp_Shown(object sender, EventArgs e)
        {
            PreencherTela();
        }

        protected override void Cancelar()
        {
            Close();

            base.Cancelar();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a Descrição.", "MENSAGEM");
                return;
            }

            F.Descricao = txtDescricao.Text;
            Salvou = true;

            base.sbGravar_Click(sender, e);
        }
    }
}