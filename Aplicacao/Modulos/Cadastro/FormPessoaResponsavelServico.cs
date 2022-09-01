using System;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormPessoaResponsavelServico : Form
    {
        private Acao ac;
        public PessoaResponsavelServico pessoaResponsavelServico = null;

        public bool Salvou = false;

        public FormPessoaResponsavelServico()
        {
            InitializeComponent();
            pessoaResponsavelServico = new PessoaResponsavelServico();
            ac = Acao.Incluir;
        }

        public FormPessoaResponsavelServico(PessoaResponsavelServico _pessoaResponsavelServico, Acao _ac)
        {
            InitializeComponent();
            pessoaResponsavelServico = _pessoaResponsavelServico;
            ac = _ac;
        }

        protected void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((lkpResponsavel.Selecionado as Responsavel) == null)
                {
                    MessageBox.Show("Selecione o Responsável.", "ATENÇÃO");
                    return;
                }

                if ((lkpServico.Selecionado as ServicoResponsavel) == null)
                {
                    MessageBox.Show("Selecione o Serviço.", "ATENÇÃO");
                    return;
                }

                pessoaResponsavelServico.IDResponsavel = (lkpResponsavel.Selecionado as Responsavel)?.ID;
                pessoaResponsavelServico.Responsavel = (lkpResponsavel.Selecionado as Responsavel)?.Descricao;

                pessoaResponsavelServico.IDServico = (lkpServico.Selecionado as ServicoResponsavel)?.ID;
                pessoaResponsavelServico.Servico = (lkpServico.Selecionado as ServicoResponsavel)?.Descricao;

                Salvou = true;
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

        private void FormPessoaResponsavelServico_Shown(object sender, EventArgs e)
        {
            if (pessoaResponsavelServico == null)
                pessoaResponsavelServico = new PessoaResponsavelServico();

            lkpResponsavel.Exemplo = new Responsavel();
            lkpResponsavel.Sessao = ResponsavelController.Instancia.getSession();
            lkbResponsavel.SubFormType = typeof(FormCadResponsavel);

            lkpServico.Exemplo = new ServicoResponsavel();
            lkpServico.Sessao = ServicoResponsavelController.Instancia.getSession();
            lkbServico.SubFormType = typeof(FormCadServicoResponsavel);

            if (ac == Acao.Consultar)
            {
                lkbResponsavel.Enabled = false;
                lkpResponsavel.Enabled = false;

                lkbServico.Enabled = false;
                lkpServico.Enabled = false;

                //sbGravar.Enabled = false;
            }

            PreencherTela();
        }

        private void PreencherTela()
        {
            if (pessoaResponsavelServico.IDResponsavel.HasValue)
                lkpResponsavel.Localizar(pessoaResponsavelServico.IDResponsavel.Value);

            if (pessoaResponsavelServico.IDServico.HasValue)
                lkpServico.Localizar(pessoaResponsavelServico.IDServico.Value);
        }

        private void lkbResponsavel_Click(object sender, EventArgs e)
        {
            GridResponsavel grid = new GridResponsavel(true);
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpResponsavel.EditValue = grid.Selecionado;
        }

        private void FormPessoaResponsavelServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                this.Close();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Hide();//Close();
        }

        private void lkbServico_Click(object sender, EventArgs e)
        {
            GridServicoResponsavel grid = new GridServicoResponsavel(true);
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpServico.EditValue = grid.Selecionado;
        }
    }
}
