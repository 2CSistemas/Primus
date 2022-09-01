using System;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormFabricante : FormManutFabricante
    {
        private Fabricante fabricante = null;
        private Acao ac;

        public FormFabricante()
        {
            InitializeComponent();
            fabricante = new Fabricante();
            ac = Acao.Incluir;
        }

        public FormFabricante(Fabricante _fabricante, Acao _ac)
        {
            InitializeComponent();
            fabricante = _fabricante;
            ac = _ac;
        }

        private void PreencherTela()
        {
            txtCodigo.Text = fabricante.Codigo.ToString();
            txtDescricao.Text = fabricante.Descricao;
        }

        private void FormFabricante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                this.Close();
        }

        private void FormFabricante_Shown(object sender, System.EventArgs e)
        {
            if (fabricante == null)
                fabricante = new Fabricante();

            if (ac == Acao.Incluir)
                fabricante.Codigo = FabricanteController.Instancia.MaxCodigo();

            if (ac == Acao.Consultar)
            {
                txtDescricao.Enabled = false;
                sbGravar.Enabled = false;
            }

            PreencherTela();
            txtDescricao.Focus();
        }

        private void sbCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        protected void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                fabricante.Codigo = Convert.ToInt32(txtCodigo.Text);
                fabricante.Descricao = txtDescricao.Text;

                if (string.IsNullOrEmpty(fabricante.Descricao))
                {
                    MessageBox.Show("A Descrição não pode ser vazia.", "ATENÇÃO");
                    return;
                }

                FabricanteController.Instancia.Salvar(fabricante, ac);
                Selecionado = fabricante;
                Close();
            }
            catch (Exception Ex)
            {
                FormErro Form = new FormErro(Ex);
                Form.ShowDialog(this);
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
