using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Cwork.Utilitarios.Componentes;
using Cwork.Utilitarios.Componentes.Mascaras;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormPessoaEngenheiro : Aplicacao.IntermediariasTela.FormManutPessoaEngenheiro
    {
        private PessoaEndereco pessoaEnderecoPrincipal;
        private PessoaTelefone pessoaTelefonePrincipal;

        public FormPessoaEngenheiro()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            tpEnderecos.Tag = Selecionado.Pessoa;
            //lkbCidade.SubForm = new FormCidade();
            lkbCidade.SubFormType = typeof(FormCidade);
            lkpCidade.Exemplo = new Cidade() { UF = new UF { Pais = new Pais() } };
            lkpCidade.Sessao = cwkGestao.Negocio.CidadeController.Instancia.getSession();
            //btExcluirEndereco.SubForm = btAlterarEndereco.SubForm = btIncluirEndereco.SubForm = btConsultarEndereco.SubForm = new FormPessoaEndereco();
            btExcluirEndereco.SubFormType = btAlterarEndereco.SubFormType = btIncluirEndereco.SubFormType = btConsultarEndereco.SubFormType = typeof(FormPessoaEndereco);
            txtCNPJ_CPF.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(PessoaController.ValidaCpf);
            txtCNPJ_CPF.CwkMascara = Mascara.CPF;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            SetTags();
            if (Operacao == Acao.Incluir)
                Selecionado.Pessoa.Codigo = PessoaController.Instancia.MaxCodigo();
        }

        private void SetTags()
        {
            tpPrincipal.Tag = Selecionado;
            tpEnderecos.Tag = Selecionado.Pessoa;
            gcPessoa.Tag = Selecionado.Pessoa;
        }

        private void CarregarEnderecoETelefone()
        {            
            pessoaEnderecoPrincipal = Selecionado.Pessoa.PessoaEnderecos.FirstOrDefault(pof => pof.BPrincipal);
            pessoaTelefonePrincipal = Selecionado.Pessoa.PessoaTelefones.FirstOrDefault(pof => pof.BPrincipal);
            if (pessoaEnderecoPrincipal != null)
            {
                Selecionado.Pessoa.PessoaEnderecos.Remove(pessoaEnderecoPrincipal);
                txtEndereco.Text = pessoaEnderecoPrincipal.Endereco;
                txtNumero.Text = pessoaEnderecoPrincipal.Numero;
                txtBairro.Text = pessoaEnderecoPrincipal.Bairro;
                txtComplemento.Text = pessoaEnderecoPrincipal.Complemento;
                txtCEP.Text = pessoaEnderecoPrincipal.CEP;
                lkpCidade.EditValue = pessoaEnderecoPrincipal.Cidade;
                chbBEntrega.Checked = pessoaEnderecoPrincipal.BEntrega;
                chbBCobranca.Checked = pessoaEnderecoPrincipal.BCobranca;
            }
            else
                pessoaEnderecoPrincipal = new PessoaEndereco();

            if (pessoaTelefonePrincipal != null)
            {
                Selecionado.Pessoa.PessoaTelefones.Remove(pessoaTelefonePrincipal);
                txtTelefone.Text = pessoaTelefonePrincipal.Numero;
                txtContato.Text = pessoaTelefonePrincipal.Contato;
            }
            else
                pessoaTelefonePrincipal = new PessoaTelefone();
        }

        private void SalvarEnderecoETelefone()
        {
            pessoaTelefonePrincipal.Pessoa = Selecionado.Pessoa;
            pessoaTelefonePrincipal.Numero = txtTelefone.Text;
            pessoaTelefonePrincipal.Contato = txtContato.Text;
            pessoaTelefonePrincipal.BPrincipal = true;
            pessoaTelefonePrincipal.Sequencia = 1;
            if (!Selecionado.Pessoa.PessoaTelefones.Contains(pessoaTelefonePrincipal))
                Selecionado.Pessoa.PessoaTelefones.Add(pessoaTelefonePrincipal);

            pessoaEnderecoPrincipal.Pessoa = Selecionado.Pessoa;
            pessoaEnderecoPrincipal.Bairro = txtBairro.Text;
            pessoaEnderecoPrincipal.Endereco = txtEndereco.Text;
            pessoaEnderecoPrincipal.Numero = txtNumero.Text;
            pessoaEnderecoPrincipal.Complemento = txtComplemento.Text;
            pessoaEnderecoPrincipal.Contato = txtContato.Text;
            pessoaEnderecoPrincipal.Cidade = (Cidade)lkpCidade.Selecionado;
            pessoaEnderecoPrincipal.CEP = txtCEP.Text;
            pessoaEnderecoPrincipal.BEntrega = chbBEntrega.Checked;
            pessoaEnderecoPrincipal.BCobranca = chbBCobranca.Checked;
            pessoaEnderecoPrincipal.BPrincipal = true;
            pessoaEnderecoPrincipal.Sequencia = 1;
            if (!Selecionado.Pessoa.PessoaEnderecos.Contains(pessoaEnderecoPrincipal))
                Selecionado.Pessoa.PessoaEnderecos.Add(pessoaEnderecoPrincipal);
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            if (pai == gcPessoa)
                CarregarEnderecoETelefone();
            return base.ObjetoPraTela(pai);
        }

        protected override void TelaProObjeto(Control pai)
        {
            if (pai == gcPessoa)
                SalvarEnderecoETelefone();
            base.TelaProObjeto(pai);
        }

        protected override void AcoesAntesSalvar()
        {
            SalvarEnderecoETelefone();
        }

        private void sbSelecionarPessoa_Click(object sender, EventArgs e)
        {
            GridGenerica<Pessoa> grid = new GridCliente(cwkGestao.Negocio.PessoaController.Instancia.GetParaCadastroEngenheiro(), new FormPessoa(), false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();
            if (grid.Selecionado != null)
                SetPessoa(grid.Selecionado);
        }

        private void SetPessoa(Pessoa pessoa)
        {
            Selecionado.Pessoa = PessoaController.Instancia.LoadObjectById(pessoa.ID);
            SetTags();
            ObjetoPraTela(tpPrincipal);
            gcPessoaEnderecos.RefreshDataSource();
        }
    }
}
