using Aplicacao.Base;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormCadResponsavel : FormManutResponsavel
    {
        private Responsavel Responsavel = null;
        private Acao ac;

        public FormCadResponsavel()
        {
            InitializeComponent();
            Responsavel = new Responsavel();
            ac = Acao.Incluir;
        }

        public FormCadResponsavel(Responsavel _Responsavel, Acao _ac)
        {
            InitializeComponent();
            Responsavel = _Responsavel;
            ac = _ac;
        }

        protected void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Responsavel.Codigo = Convert.ToInt32(txtCodigo.Text);
                Responsavel.Descricao = txtDescricao.Text;
        
                if (string.IsNullOrEmpty(Responsavel.Descricao))
                {
                    MessageBox.Show("A Descrição não pode ser vazia.", "ATENÇÃO");
                    return;
                }
        
                ResponsavelController.Instancia.Salvar(Responsavel, ac);
                Selecionado = Responsavel;
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

        private void FormCadResponsavel_Shown(object sender, EventArgs e)
        {
            if (Responsavel == null)
                Responsavel = new Responsavel();

            if (ac == Acao.Incluir)
                Responsavel.Codigo = ResponsavelController.Instancia.MaxCodigo();
            
            if (ac == Acao.Consultar)
            {
                txtDescricao.Enabled = false;
                sbGravar.Enabled = false;
            }

            PreencherTela();
            txtDescricao.Focus();
        }

        private void PreencherTela()
        {
            txtCodigo.Text = Responsavel.Codigo.ToString();
            txtDescricao.Text = Responsavel.Descricao;
        }

        private void FormCadResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
            {
                this.Close();
            }
        }
    }
}
