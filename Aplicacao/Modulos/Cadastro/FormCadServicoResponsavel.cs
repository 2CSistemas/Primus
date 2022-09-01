using Aplicacao.Base;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormCadServicoResponsavel : FormManutServicoResponsavel
    {
        private ServicoResponsavel ServicoResponsavel = null;
        private Acao ac;

        public FormCadServicoResponsavel()
        {
            InitializeComponent();
            ServicoResponsavel = new ServicoResponsavel();
            ac = Acao.Incluir;
        }

        public FormCadServicoResponsavel(ServicoResponsavel _ServicoResponsavel, Acao _ac)
        {
            InitializeComponent();
            ServicoResponsavel = _ServicoResponsavel;
            ac = _ac;
        }

        protected void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicoResponsavel.Codigo = Convert.ToInt32(txtCodigo.Text);
                ServicoResponsavel.Descricao = txtDescricao.Text;
        
                if (string.IsNullOrEmpty(ServicoResponsavel.Descricao))
                {
                    MessageBox.Show("A Descrição não pode ser vazia.", "ATENÇÃO");
                    return;
                }
        
                ServicoResponsavelController.Instancia.Salvar(ServicoResponsavel, ac);
                Selecionado = ServicoResponsavel;
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

        private void FormCadServicoResponsavel_Shown(object sender, EventArgs e)
        {
            if (ServicoResponsavel == null)
                ServicoResponsavel = new ServicoResponsavel();

            if (ac == Acao.Incluir)
                ServicoResponsavel.Codigo = ServicoResponsavelController.Instancia.MaxCodigo();
            
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
            txtCodigo.Text = ServicoResponsavel.Codigo.ToString();
            txtDescricao.Text = ServicoResponsavel.Descricao;
        }

        private void FormCadServicoResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
            {
                this.Close();
            }
        }
    }
}
