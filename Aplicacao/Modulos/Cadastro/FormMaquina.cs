using System;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormMaquina : Form
    {
        private Maquina maquina = null;
        private Acao ac;
        
        public FormMaquina()
        {
            InitializeComponent();
            maquina = new Maquina();
            ac = Acao.Incluir;
        }

        public FormMaquina(Maquina _maquina, Acao _ac)
        {
            InitializeComponent();
            maquina = _maquina;
            ac = _ac;
        }

        protected void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                maquina.Codigo = Convert.ToInt32(txtCodigo.Text);
                maquina.Descricao = txtDescricao.Text;
                maquina.IDFabricante = (lkpFabricante.Selecionado as Fabricante)?.ID;

                if (string.IsNullOrEmpty(maquina.Descricao))
                {
                    MessageBox.Show("A Descrição não pode ser vazia.", "ATENÇÃO");
                    return;
                }

                MaquinaController.Instancia.Salvar(maquina, ac);
                //Selecionado = maquina;
                Close();
            }
            catch (Exception Ex)
            {
                FormErro Form = new FormErro(Ex);
                Form.ShowDialog(this);
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMaquina_Shown(object sender, EventArgs e)
        {
            if (maquina == null)
                maquina = new Maquina();

            if (ac == Acao.Incluir)
                maquina.Codigo = MaquinaController.Instancia.MaxCodigo();

            lkpFabricante.Exemplo = new Fabricante();
            lkpFabricante.Sessao = FabricanteController.Instancia.getSession();
            lkbFabricante.SubFormType = typeof(FormFabricante);

            if (ac == Acao.Consultar)
            {
                txtDescricao.Enabled = false;
                lkbFabricante.Enabled = false;
                lkpFabricante.Enabled = false;

                //sbGravar.Enabled = false;
            }

            PreencherTela();
            txtDescricao.Focus();
        }

        private void PreencherTela()
        {
            txtCodigo.Text = maquina.Codigo.ToString();
            txtDescricao.Text = maquina.Descricao;

            if (maquina.IDFabricante.HasValue)
                lkpFabricante.Localizar(maquina.IDFabricante.Value);
        }

        private void lkbFabricante_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Fabricante> grid = new GridGenerica<Fabricante>(FabricanteController.Instancia.GetAll(), new FormFabricante(), (Fabricante)lkpFabricante.Selecionado, false);
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                lkpFabricante.EditValue = grid.Selecionado;
            }
            catch (Exception eX)
            {

            }
        }

        private void FormMaquina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                this.Close();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Hide();//Close();
        }
    }
}
