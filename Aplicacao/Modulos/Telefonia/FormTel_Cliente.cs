using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes;
using Cwork.Utilitarios.Componentes.Mascaras;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormTel_Cliente : Aplicacao.IntermediariasTela.FormManutTel_Cliente
    {
        private PessoaEndereco pessoaEnderecoPrincipal;
        private PessoaTelefone pessoaTelefonePrincipal;

        public FormTel_Cliente()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            chkBAtivo.Checked = Selecionado.Pessoa.BAtivo;
            tpTelefones.Tag = Selecionado;
            tpPrecos.Tag = Selecionado;
            tpServicos.Tag = Selecionado;
            tpEnderecos.Tag = Selecionado.Pessoa;
            tpObservacao.Tag = Selecionado.Pessoa;
            tpEmails.Tag = Selecionado.Pessoa;
            lkbCidade.SubFormType = typeof(FormCidade);
            lkpCidade.Exemplo = new Cidade() { UF = new UF { Pais = new Pais() } };
            lkpCidade.Sessao = cwkGestao.Negocio.CidadeController.Instancia.getSession();

            lkbCidadeProp.SubFormType = typeof(FormCidade);
            lkpCidadeProp.Exemplo = new Cidade() { UF = new UF { Pais = new Pais() } };
            lkpCidadeProp.Sessao = cwkGestao.Negocio.CidadeController.Instancia.getSession();
            lkbAcrescimo.SubFormType = typeof(FormAcrescimo);
            lkbGrupoCliente.SubFormType = typeof(FormGrupoCliente);
            btExcluirPreco.SubFormType = btAlterarPreco.SubFormType = btIncluirPreco.SubFormType = btConsultarPreco.SubFormType = typeof(FormTel_ClientePreco);
            btExcluirTel.SubFormType = btAlterarTel.SubFormType = btIncluirTel.SubFormType = btConsultarTel.SubFormType = typeof(FormTel_ClienteTelefone);
            btExcluirEndereco.SubFormType = btAlterarEndereco.SubFormType = btIncluirEndereco.SubFormType = btConsultarEndereco.SubFormType = typeof(FormPessoaEndereco);
            btExcluirServico.SubFormType = btAlterarServico.SubFormType = btIncluirServico.SubFormType = btConsultarServico.SubFormType = typeof(FormTel_ClienteServico);
            btExcluirEmail.SubFormType = btAlterarEmail.SubFormType = btIncluirEmail.SubFormType = btConsultarEmail.SubFormType = typeof(FormPessoaEmail);

            lkbCidade.SubFormType = typeof(FormCidade);
            lkpCidade.Exemplo = new Cidade() { UF = new UF { Pais = new Pais() } };
            lkpCidade.Sessao = cwkGestao.Negocio.CidadeController.Instancia.getSession();

            //lkbCidadeProp.SubForm = new FormCidade();
            //lkbAcrescimo.SubForm = new FormAcrescimo();
            //lkbGrupoCliente.SubForm = new FormGrupoCliente();
            //btExcluirPreco.SubForm = btAlterarPreco.SubForm = btIncluirPreco.SubForm = btConsultarPreco.SubForm = new FormTel_ClientePreco();
            //btExcluirTel.SubForm = btAlterarTel.SubForm = btIncluirTel.SubForm = btConsultarTel.SubForm = new FormTel_ClienteTelefone();
            //btExcluirEndereco.SubForm = btAlterarEndereco.SubForm = btIncluirEndereco.SubForm = btConsultarEndereco.SubForm = new FormPessoaEndereco();
            //btExcluirServico.SubForm = btAlterarServico.SubForm = btIncluirServico.SubForm = btConsultarServico.SubForm = new FormTel_ClienteServico();
            //btExcluirEmail.SubForm = btAlterarEmail.SubForm = btIncluirEmail.SubForm = btConsultarEmail.SubForm = new FormPessoaEmail();
            //lkbCidade.SubForm = new FormCidade();

            lkpGrupoCliente.OnIDChanged += lkpGrupoCliente_IDChanged;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            tpPrincipal.Tag = Selecionado;
            tpTelefones.Tag = Selecionado;
            tpServicos.Tag = Selecionado;
            tpPrecos.Tag = Selecionado;
            tpEnderecos.Tag = Selecionado.Pessoa;
            gcPessoa.Tag = Selecionado.Pessoa;
            tpObservacao.Tag = Selecionado.Pessoa;
            tpEmails.Tag = Selecionado.Pessoa;

            if (Operacao == Acao.Incluir)
                Selecionado.Pessoa.Codigo = PessoaController.Instancia.MaxCodigo();
        }

        private void HabilitarTelefones(bool habilitar)
        {
            btConsultarTel.Enabled = habilitar;
            btIncluirTel.Enabled = habilitar;
            btAlterarTel.Enabled = habilitar;
            btExcluirTel.Enabled = habilitar;
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
                SetTelPilotoNaTela();
                txtContato.Text = pessoaTelefonePrincipal.Contato;
            }
            else
                pessoaTelefonePrincipal = new PessoaTelefone();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            var retorno = base.ObjetoPraTela(pai);
            if (pai == gcPessoa) {
                CarregarEnderecoETelefone();
            }
            return retorno;
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
            if (Selecionado.Pessoa.TipoPessoa == "1")
            {
                Selecionado.BairroProp = txtBairroProp.Text;
                Selecionado.CidadeProp = (Cidade)lkpCidadeProp.Selecionado;
                Selecionado.ComplementoProp = txtComplementoProp.Text;
                Selecionado.CpfProp = txtCpfProp.Text;
                Selecionado.DtNascimentoProp = (DateTime)txtDtNascimentoProp.EditValue;
                Selecionado.EnderecoProp = txtEnderecoProp.Text;
                Selecionado.NomeProp = txtNomeProp.Text;
                Selecionado.NumeroEnderecoProp = Convert.ToInt32(txtNumeroEnderecoProp.EditValue ?? "0");
                Selecionado.TelefoneProp = txtTelefoneProp.Text;
                Selecionado.CalculaTotalMinutos = chkCalculaTotalMinutos.Checked;
            }
            if (!chkBAtivo.Checked && Selecionado.Telefones.Where(t => t.DataDesligamento == null).Count() > 0)
            {
                DesativarTelefones();
            }

        }

        private void DesativarTelefones()
        {
            if (EhParaDesativar())
            {
                var form = new FormInformarDadosDesativarTelefones(Selecionado);
                form.ShowDialog();
            }
        }

        private bool EhParaDesativar()
        {
            return MessageBox.Show("Deseja desativar todos os telefones desse cliente?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
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

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidacaoFisicoJuridica();
        }

        private void ValidacaoFisicoJuridica()
        {
            switch (cbTipoPessoa.SelectedIndex)
            {
                case 1: txtCNPJ_CPF.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(ValidaCnpjComCidade);
                        txtCNPJ_CPF.CwkMascara = Mascara.CNPJ;
                        txtDtNascimento.Enabled = false;
                        Proprietario.PageVisible = true;
                        txtCpfProp.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
                        txtNomeProp.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
                        txtDtNascimentoProp.EditValue = DateTime.Now;
                    break;
                case 0: txtCNPJ_CPF.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(PessoaController.ValidaCpf);
                        txtCNPJ_CPF.CwkMascara = Mascara.CPF;
                        txtDtNascimento.Enabled = true;
                        Proprietario.PageVisible = false;
                        txtCpfProp.CwkValidacao = null;
                        txtNomeProp.CwkValidacao = null;
                    break;
                default:
                    break;
            }
            
        }

        private string ValidaCnpjComCidade(object conteudo)
        {
            Cidade sel = (Cidade)lkpCidade.Selecionado;
            if (sel != null && sel.IBGE == "9999999") return "";

            return PessoaController.ValidaCnpj(conteudo);
        }

        private void AlteraDadosCliente()
        {
            Selecionado.GrupoCliente = (Tel_GrupoCliente)lkpGrupoCliente.Selecionado;
            HabilitarTelefones(true);

            txtEndereco.EditValue = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).Endereco;
            txtNumero.EditValue = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).Numero;
            txtBairro.EditValue = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).Bairro;
            txtComplemento.EditValue = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).Complemento;
            txtCEP.EditValue = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).CEP;
            lkpCidade.EditValue = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).Cidade;
        }

        private void lkpGrupoCliente_Leave(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
                if (lkpGrupoCliente.Selecionado != null)
                    AlteraDadosCliente();
        }

        private void FormTel_Cliente_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
            {
                chkCalculaTotalMinutos.Checked = true;
                HabilitarTelefones(false);
                txtCodigo.Text = Selecionado.Pessoa.Codigo.ToString();
            }

            if (Selecionado.Pessoa.TipoPessoa == "1")
            {
                txtBairroProp.Text = Selecionado.BairroProp;
                lkpCidadeProp.EditValue = Selecionado.CidadeProp;
                txtComplementoProp.Text = Selecionado.ComplementoProp;
                txtCpfProp.Text = Selecionado.CpfProp;
                txtDtNascimentoProp.EditValue = Selecionado.DtNascimentoProp;
                txtNomeProp.Text = Selecionado.NomeProp;
                txtNumeroEnderecoProp.Text = Selecionado.NumeroEnderecoProp.ToString();
                txtTelefoneProp.Text = Selecionado.TelefoneProp;
                txtEnderecoProp.Text = Selecionado.EnderecoProp;
                chkCalculaTotalMinutos.Checked = Selecionado.CalculaTotalMinutos;
            }
            ValidacaoFisicoJuridica();
        }

        private void lkpGrupoCliente_IDChanged(object sender, EventArgs e)
        {
            AlteraDadosCliente();
        }
        private void SetTelPilotoNaTela()
        {
            var TelefonePiloto = ((IList<Tel_ClienteTelefone>)btIncluirTel.GridControl.DataSource).Where(t => t.BAgrupador).FirstOrDefault();

            if (TelefonePiloto != null)
            {
                txtTelefone.EditValue = TelefonePiloto.GrupoClienteTelefone.Telefone;
            }
            else
            {
                txtTelefone.EditValue = String.Empty;
            }
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            base.btSubRegistro_Click(sender, e);

            if (((Cwork.Utilitarios.Componentes.DevButton)sender).GridControl.Name == "gcTelefones")
            {
                SetTelPilotoNaTela();
            }
        }
    }
}
