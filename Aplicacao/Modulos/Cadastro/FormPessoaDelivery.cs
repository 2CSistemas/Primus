using System;
using System.Collections.Generic;
using cwkGestao.Modelo;
using Aplicacao.Base;
using System.Linq;
using cwkGestao.Negocio;
using Cwork.Utilitarios.Componentes;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormPessoaDelivery : IntermediariasTela.FormManutPessoaIntermediaria
    {
        private string TelefoneInformado = null;
        private Acao ACAO = Acao.Alterar;

        #region Construtores
        public FormPessoaDelivery()
        {
        }

        public FormPessoaDelivery(Pessoa Cliente)
        {
            Selecionado = Cliente;;
        }

        public FormPessoaDelivery(string Telefone)
        {
            TelefoneInformado = Telefone;
            Selecionado = new Pessoa { Codigo = PessoaController.Instancia.MaxCodigo() };
            ACAO = Acao.Incluir;
        }

        #endregion

        #region Metodos
        private void DiscriminaTabs()
        {
            tpPrincipal.Tag = Selecionado;

            lkpCidade.Exemplo = new Cidade() { UF = new UF { Pais = new Pais() } };
            lkpCidade.Sessao = cwkGestao.Negocio.CidadeController.Instancia.getSession();
        }

        #region Overrides

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            DiscriminaTabs();

            Selecionado.PessoaVendedores = Selecionado.PessoaVendedores == null ? new List<PessoaVendedor>() : Selecionado.PessoaVendedores;
            if (Selecionado.PessoaVendedores.Count == 0)
            {
                Selecionado.PessoaVendedores.Add(new PessoaVendedor());
            }

            lkbCidade.SubFormType = typeof(FormCidade);
            lkbFilial.SubFormType = typeof(FormFilial);

        }
        protected override bool ValidacoesAdicionais()
        {
            return !dxErroProvider.HasErrors;
        }

        private bool ValidaCPFCNPJ()
        {
            string chaveBusca = txt2CNPJ_CPF.Text;

            IList<Pessoa> listaPessoasComCPFCNPJ = new List<Pessoa>();
            listaPessoasComCPFCNPJ = PessoaController.Instancia.GetAtivosByCPFeCNPJ(chaveBusca, true);

            //retira a propria pessoa da comparação, tornando qualquer registro encontrado um problema.
            listaPessoasComCPFCNPJ = listaPessoasComCPFCNPJ.Where(s => s.ID != Selecionado.ID && s.CNPJ_CPF != "00.000.000/0000-00"
            && s.CNPJ_CPF != "000.000.000-00").ToList();

            if (listaPessoasComCPFCNPJ.Count > 0)
            {
                dxErroProvider.SetError(txt2CNPJ_CPF, "Este CPF já está associado com outra Pessoa!");
                MessageBox.Show("Este CPF já está associado com outra Pessoa", "ATENÇÃO", MessageBoxButtons.OK);
            }

            return !dxErroProvider.HasErrors;
        }

        protected override void OK()
        {
            if (ValidarFormulario() && ValidaCPFCNPJ())
            {
                try
                {
                    Selecionado.BDelivery = true;
                    TelaProObjeto(tpPrincipal);

                    Selecionado.CNPJ_CPF = txt2CNPJ_CPF.Text;
                    Selecionado.TipoPessoa = cbTipoPessoa.Text;
                    Selecionado.bFaturarPorPadrao = false;
                    Selecionado.bSTRevenda = false;
                    Selecionado.bConsumidorFinal = true;
                    Selecionado.BAtivo = true;
                    Selecionado.BCliente = true;

                    Selecionado.DiasPadraoLeitura = 0;
                    Selecionado.SenhaRevenda = null;

                    if (ACAO == Acao.Incluir)
                    {
                        Selecionado.PessoaAvisos = new List<PessoaAviso>();
                        Selecionado.PessoaClientes = new List<PessoaCliente>();
                        Selecionado.PessoaEmails = new List<PessoaEmail>();
                        Selecionado.PessoaFuncionarios = new List<PessoaFuncionario>();
                        Selecionado.PessoaSocios = new List<PessoaSocio>();
                        Selecionado.PessoaVendedores = new List<PessoaVendedor>();
                        Selecionado.ClientesRevenda = new List<ClienteRevenda>();

                        Selecionado.PessoaEnderecos = new List<PessoaEndereco>()
                        {
                            new PessoaEndereco
                            {
                                BAtivo = true,
                                BCobranca = false,
                                BEntrega = true,
                                BPrincipal = true,
                                Bairro = txtBairro.Text,
                                CEP = txtCEP.Text,
                                Cidade = lkpCidade.Selecionado as Cidade,
                                Complemento = txtComplemento.Text,
                                Contato = "",
                                Descricao = txtEndereco.Text,
                                Numero = txtNumero.Text,
                                Endereco = txtEndereco.Text,
                                Pessoa = Selecionado,
                                Sequencia = 1,
                                Telefone = txtTelefone.Text
                            }
                        };
                        Selecionado.PessoaTelefones = new List<PessoaTelefone>()
                        {
                            new PessoaTelefone
                            {
                                BPrincipal = true,
                                Contato = null,
                                Pessoa = Selecionado,
                                Numero = txtTelefone.Text,
                                Sequencia = 1,
                                Tipo = null
                            }
                        };
                    }
                    else
                    {
                        var PessoaEnderecoPrincipal = Selecionado.PessoaEnderecos.First();
                        PessoaEnderecoPrincipal.BAtivo = true;
                        PessoaEnderecoPrincipal.BCobranca = false;
                        PessoaEnderecoPrincipal.BEntrega = true;
                        PessoaEnderecoPrincipal.BPrincipal = true;
                        PessoaEnderecoPrincipal.Bairro = txtBairro.Text;
                        PessoaEnderecoPrincipal.CEP = txtCEP.Text;
                        PessoaEnderecoPrincipal.Cidade = lkpCidade.Selecionado as Cidade;
                        PessoaEnderecoPrincipal.Complemento = txtComplemento.Text;
                        PessoaEnderecoPrincipal.Contato = "";
                        PessoaEnderecoPrincipal.Descricao = txtEndereco.Text;
                        PessoaEnderecoPrincipal.Numero = txtNumero.Text;
                        PessoaEnderecoPrincipal.Endereco = txtEndereco.Text;
                        PessoaEnderecoPrincipal.Pessoa = Selecionado;
                        PessoaEnderecoPrincipal.Sequencia = 1;
                        PessoaEnderecoPrincipal.Telefone = txtTelefone.Text;

                        var PessoaTelefonePrincipal = Selecionado.PessoaTelefones.First();
                        PessoaTelefonePrincipal.BPrincipal = true;
                        PessoaTelefonePrincipal.Contato = null;
                        PessoaTelefonePrincipal.Pessoa = Selecionado;
                        PessoaTelefonePrincipal.Numero = txtTelefone.Text;
                        PessoaTelefonePrincipal.Sequencia = 1;
                        PessoaTelefonePrincipal.Tipo = null;
                    }

                    AcoesAntesSalvar();
                    controller.Salvar(Selecionado, ACAO);
                    AcoesDepoisSalvar();
                    Close();

                }
                catch (Exception ex)
                {
                    new FormErro(ex).ShowDialog();
                }
            }
        }

        protected override void SetarMascaras()
        {
        }

        #endregion

        #endregion

        #region Eventos


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Selecionado != null)
            {
                ObjetoPraTela(tpPrincipal);
                txt2CNPJ_CPF.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(PessoaController.ValidaCpf);

                lkpCidade.EditValue = Selecionado.EnderecoPrincipal()?.Cidade;
                txtTelefone.Text = Selecionado.TelefonePrincipal;

                if (!string.IsNullOrEmpty(TelefoneInformado))
                    txtTelefone.Text = TelefoneInformado;
            }

            int? IDCidadePadrao = ConfiguracaoController.Instancia.GetConfiguracao().IDCidadePadraoNFCe;
            if (IDCidadePadrao.HasValue && IDCidadePadrao.Value != 0)
                lkpCidade.Localizar(IDCidadePadrao.Value);
        }

        private void FormPessoa_Shown(object sender, EventArgs e)
        {
            txtTelefone.EditValue = TelefoneInformado;
            txtTelefone.Text = TelefoneInformado;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            base.sbGravar_Click(sender, e);
        }

        private void lkpCidade_Leave(object sender, EventArgs e)
        {
        }
        #endregion

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            cbTipoPessoa.SelectedIndex = Selecionado.TipoPessoa == null ? -1 :
                Selecionado.TipoPessoa.Equals("Física") ? 0 :
                Selecionado.TipoPessoa.Equals("Jurídica") ? 1 :
                2;
        }
        protected override void AcoesDepoisSalvar()
        {
            base.AcoesDepoisSalvar();
        }
        protected override void AcoesAntesSalvar()
        {
            base.AcoesAntesSalvar();
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            BuscaInformacoesEnderecos();
        }

        private void BuscaInformacoesEnderecos()
        {
            string cepSemTraco = String.Empty;
            string logradouro = String.Empty;
            cepbr_endereco endereco = new cepbr_endereco();
            try
            {
                cepSemTraco = txtCEP.Text.Replace("-", "");
                endereco = cepbr_enderecoController.Instancia.BuscaInfEnderecos(cepSemTraco);
            }
            catch (Exception ex)
            {
                endereco = null;
            }
            if (endereco != null)
            {
                if (endereco.tipo_logradouro != String.Empty)
                    logradouro = endereco.tipo_logradouro + " " + endereco.logradouro;
                else
                    logradouro = endereco.logradouro;

                txtBairro.Text = endereco.cep_bairro.bairro;
                txtEndereco.Text = logradouro;
                txtComplemento.Text = endereco.complemento;
                lkpCidade.Localizar(endereco.cep_cidade.CidadeCwork.ID);
            }
        }
    }
}
