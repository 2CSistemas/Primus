using System;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormOrdemServicoMaquina : Form
    {
        public OrdemServicoMaquina Maquina;
        public Acao acao;
        public bool Salvou;

        public FormOrdemServicoMaquina(OrdemServicoMaquina Maq, Acao a)
        {
            InitializeComponent();
            Maquina = Maq;
            acao = a;

            lkpMaquina.Exemplo = new Maquina();
            lkpMaquina.Sessao = MaquinaController.Instancia.getSession();
            lkbMaquina.SubFormType = typeof(FormMaquina);

            if (Maquina.IdMaquina.HasValue)
                lkpMaquina.Localizar(Maquina.IdMaquina.Value);

            if (a == Acao.Consultar)
            {
                lkpMaquina.Enabled = false;
                lkbMaquina.Enabled = false;
                simpleButton3.Enabled = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lkbMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                GridMaquina grid = new GridMaquina(true, null, this);

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog(this);

                lkpMaquina.EditValue = grid.Selecionado;
            }
            catch (Exception eX)
            {

            }
        }

        public void SelecionarMaquina(Maquina maquina)
        {
            lkpMaquina.EditValue = maquina;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (lkpMaquina.Selecionado == null)
            {
                MessageBox.Show("Informe a Maquina.");
                lkpMaquina.Focus();
                return;
            }

            Maquina.IdMaquina = (lkpMaquina.Selecionado as Maquina).ID;
            Salvou = true;
            Close();
        }
    }
}
