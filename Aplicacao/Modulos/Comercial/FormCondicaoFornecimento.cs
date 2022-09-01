using Aplicacao.Base;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormCondicaoFornecimento : FormManutCondicaoFornecimento
    {
        private CondicaoFornecimento condicaoFornecimento = null;
        private Acao ac;
        public FormCondicaoFornecimento(CondicaoFornecimento _condicaoFornecimento, Acao _ac)
        {
            InitializeComponent();
            condicaoFornecimento = _condicaoFornecimento;
            ac = _ac;

            if (condicaoFornecimento == null)
                condicaoFornecimento = new CondicaoFornecimento();
        }

        private void FormCondicaoFornecimento_Shown(object sender, EventArgs e)
        {
            if (ac == Acao.Incluir)
                condicaoFornecimento.Codigo = CondicaoFornecimentoController.Instancia.MaxCodigo();

            PreencherTela();

            if (ac == Acao.Consultar)
            {
                txtDescricao.Enabled = false;
                txtHabilitaCondicao.Enabled = false;

                sbGravar.Enabled = false;
            }

            txtTitulo.Focus();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                condicaoFornecimento.Codigo = Convert.ToInt32(txtCodigo.Text);
                condicaoFornecimento.Descricao = txtDescricao.Text;
                condicaoFornecimento.Titulo = txtTitulo.Text;
                condicaoFornecimento.Habilita = txtHabilitaCondicao.Checked ? 1 : 0;

                if (string.IsNullOrEmpty(condicaoFornecimento.Descricao))
                {
                    MessageBox.Show("A Descrição não pode ser vazia", "ATENÇÃO");
                    return;
                }

                CondicaoFornecimentoController.Instancia.Salvar(condicaoFornecimento, ac);
                Close();
            }
            catch (Exception Ex)
            {
                FormErro Form = new FormErro(Ex);
                Form.ShowDialog(this);
            }

            base.sbGravar_Click(sender, e);
        }

        private void PreencherTela()
        {
            txtCodigo.Text = condicaoFornecimento.Codigo.ToString();
            txtTitulo.Text = condicaoFornecimento.Titulo;
            txtDescricao.Text = condicaoFornecimento.Descricao;
            txtHabilitaCondicao.Checked = condicaoFornecimento.Habilita == 1;
        }
    }
}
