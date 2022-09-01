using System;
using System.Collections.Generic;
using System.Linq;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes;
using cwkGestao.Negocio;
using Aplicacao.Base;
using System.Windows.Forms;
using Aplicacao.Util;
using System.IO;
using System.Xml.Linq;
using Aplicacao.Util.Telas;
using System.Drawing;
using Aplicacao.Modulos.Cadastro;
using System.Threading.Tasks;
using cwkGestao.Modelo.Util;

namespace Aplicacao
{
    public partial class FormPessoa : IntermediariasTela.FormManutPessoaIntermediaria
    {
        private PessoaEndereco _pessoaEnderecoPrincipal;
        private PessoaTelefone _pessoaTelefonePrincipal;
        private bool PDV = false;
        Configuracao conf;
        private IList<LogAlteracaoParticipante> logAlteracoesParticipante { get; set; }
        public String TipoPessoa { get; set; }

        private bool carregouTela;

        #region Construtores
        public FormPessoa()
        {
            logAlteracoesParticipante = new List<LogAlteracaoParticipante>();
        }

        public FormPessoa(bool VemDoPDV)
        {
            PDV = VemDoPDV;
            logAlteracoesParticipante = new List<LogAlteracaoParticipante>();
        }

        public FormPessoa(string tipoPessoa)
        {
            this.TipoPessoa = tipoPessoa;
        }

        public FormPessoa(Pessoa pessoa)
        {
            logAlteracoesParticipante = new List<LogAlteracaoParticipante>();
            Selecionado = pessoa;

            ObjetoPraTela(tpPrincipal);
            txt2CNPJ_CPF.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(PessoaController.ValidaCpf);
            txtEscritorioCNPJ.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(PessoaController.ValidaCnpj);
        }
        #endregion

        #region Metodos

        private void CarregaEnderecoPrincipal()
        {
            PessoaEndereco pep = Selecionado.PessoaEnderecos.FirstOrDefault(pof => pof.BPrincipal);
            PessoaTelefone ptp = Selecionado.PessoaTelefones.FirstOrDefault(pof => pof.BPrincipal);
            if (pep != null)
            {
                txtEndereco.Text = pep.Endereco;
                txtNumero.Text = pep.Numero;
                txtBairro.Text = pep.Bairro;
                txtComplemento.Text = pep.Complemento;
                txtCEP.Text = pep.CEP;

                if (pep.Cidade != null)
                {
                    lkpCidade.EditValue = pep.Cidade;

                    if (pep.Cidade.UF.Sigla == "EX")
                    {
                        Selecionado.CNPJ_CPF = null;
                        ValidaCNPJExterior();
                    }
                }

                chbBEntrega.Checked = pep.BEntrega;
                chbBCobranca.Checked = pep.BCobranca;
                chbRemetenteDestinatario.Checked = pep.RemetenteDestinatario;
            }
            if (ptp != null)
            {
                txtTelefone.Text = ptp.Numero;
                txtContato.Text = ptp.Contato;

            }
        }

        private string ValidaCnpjComCidade(object conteudo)
        {
            Cidade sel = (Cidade)lkpCidade.Selecionado;
            if (sel != null && sel.IBGE == "9999999") return "";

            return PessoaController.ValidaCnpj(conteudo);
        }

        private void DiscriminaTabs()
        {
            conf = ConfiguracaoController.Instancia.GetConfiguracao();
            bool bMagento = conf.ReducaoMagento == 1 ? true : false;

            chbBCliente.Checked = true;
            chbBVendedor.Checked = true;
            chbBFuncionario.Checked = true;

            if (!bMagento)
                tabMagento.PageVisible = false;
            else
            {
                tabMagento.Tag = Selecionado;
                IncluirValidacoesMagento();
            }

            tpPrincipal.Tag = Selecionado;

            pnlOpcoesPessoa.Tag = Selecionado;
            tpTipoPessoa.Tag = Selecionado;
            tabDados.Tag = Selecionado;

            tabPessoa.Tag = Selecionado;
            tabOperadora.Tag = Selecionado;

            tabCliente.Tag = Selecionado.PessoaClientes != null && Selecionado.PessoaClientes.Count == 0 ? new PessoaCliente() { Pessoa = Selecionado } : Selecionado.PessoaClientes[0];
            tabFuncionario.Tag = Selecionado.PessoaFuncionarios != null && Selecionado.PessoaFuncionarios.Count == 0 ? new PessoaFuncionario() { Pessoa = Selecionado } : Selecionado.PessoaFuncionarios[0];
            tabVendedor.Tag = tabComissao.Tag = Selecionado.PessoaVendedores != null && Selecionado.PessoaVendedores.Count == 0 ? new PessoaVendedor() { Pessoa = Selecionado } : Selecionado.PessoaVendedores[0];

            if (Selecionado.PessoaContabilistas == null)
                Selecionado.PessoaContabilistas = new List<PessoaContabilista>();
            tabContabilista.Tag = Selecionado.PessoaContabilistas != null && Selecionado.PessoaContabilistas.Count == 0 ? new PessoaContabilista { Pessoa = Selecionado } : Selecionado.PessoaContabilistas[0];

            tabEnd.Tag = Selecionado;
            tabTel.Tag = Selecionado;
            tabAvisos.Tag = Selecionado;
            tabEmail.Tag = Selecionado;
            tabTransportadora.Tag = Selecionado;
            tabAtendimento.Tag = Selecionado;
            tabRota.Tag = Selecionado;

            if (conf.UtilizaAtendimento)
            {
                TabControl1.TabPages.Add(tabAtendimento);
            }
            else
            {
                TabControl1.TabPages.Remove(tabAtendimento);
            }

            ValidaTabRevenda();

            lkpCidade.Exemplo = new Cidade() { UF = new UF { Pais = new Pais() } };
            lkpCidade.Sessao = cwkGestao.Negocio.CidadeController.Instancia.getSession();

            lkpTabelaPreco.Exemplo = new TabelaPreco();
            lkpTabelaPreco.Sessao = cwkGestao.Negocio.TabelaPrecoController.Instancia.getSession();

            lkpCondicao.Exemplo = new Condicao();
            lkpCondicao.Sessao = cwkGestao.Negocio.CondicaoController.Instancia.getSession();

            lkpVendedor.Exemplo = new Pessoa() { BVendedor = true };
            lkpVendedor.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();

            lkpCwUsuario.Exemplo = new cwkGestao.Modelo.Cw_usuario();
            lkpCwUsuario.Sessao = cwkGestao.Negocio.Cw_usuarioController.Instancia.getSession();

            lkpCondicao.EditValue = null;
            lkpTabelaPreco.EditValue = null;
            lkpVendedor.EditValue = null;
            lkpCwUsuario.EditValue = null;

            xtraTabPage1.Visible = true;
        }

        private void IncluirValidacoesMagento()
        {
            txtEndereco.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            txtNumero.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            txtEndereco.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
        }

        private string MensagemNome_CNPJExistente()
        {
            return "Já existe uma pessoa cadastrada com o nome '" + Selecionado.Nome + "' e o CPF/CNPJ '" + Selecionado.CNPJ_CPF + "'. Verfique.";
        }

        private void TrataTelefonePrincipal()
        {
            _pessoaTelefonePrincipal.Pessoa = Selecionado;
            _pessoaTelefonePrincipal.Numero = txtTelefone.Text;
            _pessoaTelefonePrincipal.Contato = txtContato.Text;
            _pessoaTelefonePrincipal.BPrincipal = true;
            _pessoaTelefonePrincipal.Sequencia = 1;
            if (!Selecionado.PessoaTelefones.Contains(_pessoaTelefonePrincipal))
                Selecionado.PessoaTelefones.Add(_pessoaTelefonePrincipal);
        }

        private void TrataEnderecoPrincipal()
        {
            _pessoaEnderecoPrincipal.Pessoa = Selecionado;
            _pessoaEnderecoPrincipal.Bairro = txtBairro.Text;
            _pessoaEnderecoPrincipal.Endereco = txtEndereco.Text;
            _pessoaEnderecoPrincipal.Numero = txtNumero.Text;
            _pessoaEnderecoPrincipal.Complemento = txtComplemento.Text;
            _pessoaEnderecoPrincipal.Contato = txtContato.Text;
            _pessoaEnderecoPrincipal.Cidade = (Cidade)lkpCidade.Selecionado;
            _pessoaEnderecoPrincipal.CEP = txtCEP.Text;
            _pessoaEnderecoPrincipal.BEntrega = chbBEntrega.Checked;
            _pessoaEnderecoPrincipal.BCobranca = chbBCobranca.Checked;
            _pessoaEnderecoPrincipal.RemetenteDestinatario = chbRemetenteDestinatario.Checked;
            _pessoaEnderecoPrincipal.BPrincipal = true;
            _pessoaEnderecoPrincipal.Sequencia = 1;
            if (!Selecionado.PessoaEnderecos.Contains(_pessoaEnderecoPrincipal))
                Selecionado.PessoaEnderecos.Add(_pessoaEnderecoPrincipal);
        }

        #region Overrides

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkbVendedor.Click += new EventHandler(lkbVendedor_Click);
            lkpVendedor.CamposRestricoesAND = new List<string>() { "bvendedor" };

            DiscriminaTabs();

            lkbServicoAtendimento.SubFormType = typeof(FormServico);
            lkpServicoAtendimento.Exemplo = new Servico();
            lkpServicoAtendimento.CamposRestricoesAND = new List<string>();

            _pessoaEnderecoPrincipal = null;
            _pessoaTelefonePrincipal = null;
            //Inicia botoes PessoaEndereco

            object[] parmsEndereco = new[] { new PessoaEndereco() { Pessoa = Selecionado } };
            Type formPessoaEnderecoType = typeof(FormPessoaEndereco);
            btIncluirEndereco.SubFormType = btAlterarEndereco.SubFormType = btExcluirEndereco.SubFormType = btConsultarEndereco.SubFormType = formPessoaEnderecoType;
            btIncluirEndereco.SubFormTypeParams = btAlterarEndereco.SubFormTypeParams = btExcluirEndereco.SubFormTypeParams = btConsultarEndereco.SubFormTypeParams = parmsEndereco;

            //Inicia botoes PessoaTelefone
            object[] parmsTelefone = new object[] { new PessoaTelefone() { Pessoa = Selecionado } };
            Type formPessoaTelefoneType = typeof(FormPessoaTelefone);
            btIncluirTelefone.SubFormType = btAlterarTelefone.SubFormType = btExcluirTelefone.SubFormType = btConsultarTelefone.SubFormType = formPessoaTelefoneType;
            btIncluirTelefone.SubFormTypeParams = btAlterarTelefone.SubFormTypeParams = btExcluirTelefone.SubFormTypeParams = btConsultarTelefone.SubFormTypeParams = parmsTelefone;

            //Inicia botoes PessoaEmail
            object[] parmsEmail = new object[] { new PessoaEmail() { Pessoa = Selecionado } };
            Type formPessoaEmailType = typeof(FormPessoaEmail);
            btIncluirEmail.SubFormType = btAlterarEmail.SubFormType = btExcluirEmail.SubFormType = btConsultarEmail.SubFormType = formPessoaEmailType;
            btIncluirEmail.SubFormTypeParams = btAlterarEmail.SubFormTypeParams = btExcluirEmail.SubFormTypeParams = btConsultarEmail.SubFormTypeParams = parmsEmail;

            //Inicia botoes PessoaAviso
            object[] parmsAviso = new object[] { new PessoaAviso() { Pessoa = Selecionado } };
            Type formPessoaAvisoType = typeof(FormPessoaAviso);
            btIncluirAviso.SubFormType = btAlterarAviso.SubFormType = btExcluirAviso.SubFormType = btConsultarAviso.SubFormType = formPessoaAvisoType;
            btIncluirAviso.SubFormTypeParams = btAlterarAviso.SubFormTypeParams = btExcluirAviso.SubFormTypeParams = btConsultarAviso.SubFormTypeParams = parmsAviso;

            //Inicia botoes PessoaTipoServicoTransporte
            Type fptst = typeof(FormPessoaTipoServicoTransporte);
            btIncluirTipoServicoTransporte.SubFormType = btAlterarTipoServicoTransporte.SubFormType = btConsultarTipoServicoTransporte.SubFormType = btExcluirTipoServicoTransporte.SubFormType = fptst;

            Selecionado.PessoaVendedores = Selecionado.PessoaVendedores == null ? new List<PessoaVendedor>() : Selecionado.PessoaVendedores;
            if (Selecionado.PessoaVendedores.Count == 0)
            {
                Selecionado.PessoaVendedores.Add(new PessoaVendedor());
            }

            Type tipoComissao = typeof(FormComissao);
            btIncluirComissao.SubFormType = btConsultarComissao.SubFormType = btExcluirComissao.SubFormType = btAlterarComissao.SubFormType = tipoComissao;

            lkbCidade.SubFormType = typeof(FormCidade);
            lkbClassificacao.SubFormType = typeof(FormClassificacao);
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbFilial.SubFormType = typeof(FormFilial);

            lkbTabelaPreco.SubFormType = typeof(FormTabelaPreco);
        }
        protected override bool ValidacoesAdicionais()
        {
            if (chbBTransportadora.Checked && chkbShlTransportadora.Checked && cbTipoPessoa.SelectedItem.ToString() == "Física")
            {
                dxErroProvider.SetError(chkbShlTransportadora, "Para envio à SHL, a Pessoa deve ser do tipo \"Jurídica\". Verifique.");
                TabControl1.SelectedTabPage = tabTransportadora;
            }
            return !dxErroProvider.HasErrors;
        }

        protected override void OK()
        {
            bool bTipoPessoaFisica = cbTipoPessoa.SelectedIndex == 0 ? true : false;

            if ((lkpCidade.Selecionado as Cidade)?.UF?.Sigla == "EX")
                txtCNPJ_CPF.CwkValidacao = null;

            if (ValidarFormulario())
            {
                try
                {
                    switch (cbTipoPessoa.SelectedIndex)
                    {
                        case 0: // Física
                        case 1: // Jurídica

                            Selecionado.BDelivery = CKB_Delivery.Checked;
                            Selecionado.BEntregador = CKB_Entregador.Checked;
                            Selecionado.NaoUtilizaLimite = chbNaoUtilizaLimite.Checked;

                            if (ValidaCampoContato() && ValidaInativacao() && ValidaCPFCNPJ(bTipoPessoaFisica))
                            {
                                GravarLogAlteracoesParticipante();
                                TelaProObjeto(tpPrincipal);

                                Selecionado.TipoPessoa = cbTipoPessoa.Text;
                                Selecionado.bFaturarPorPadrao = chbBFaturarPorPadrao.Checked;
                                if (chbBTransportadora.Checked == true)
                                    Selecionado.bCorreio = chbBCorreio.Checked;

                                if (chbContabilista.Checked == true)
                                {
                                    Selecionado.bContabilista = true;
                                    CarregaObjetoPessoaContabilista();
                                }
                                Selecionado.bContabilista = (bool)chbContabilista.EditValue;
                                Selecionado.bConsumidorFinal = (bool)chbConsumidorFinal.EditValue;

                                int diapadraoleituraSelecionado;
                                Int32.TryParse(txtDiaPadraoLeitura.Text, out diapadraoleituraSelecionado);
                                Selecionado.DiasPadraoLeitura = diapadraoleituraSelecionado;

                                Selecionado.SenhaRevenda = global::Modelo.Criptografia.Criptografar(Convert.ToString(txtSenhaRevenda.Text));

                                TrataEnderecoPrincipal();
                                TrataTelefonePrincipal();

                                if (chbSTRevenda.Checked)
                                    Selecionado.bSTRevenda = true;
                                else
                                    Selecionado.bSTRevenda = false;

                                if (TabControl1.Controls.Contains(tabCliente) && !Selecionado.PessoaClientes.Contains((PessoaCliente)tabCliente.Tag))
                                    Selecionado.PessoaClientes.Add((PessoaCliente)tabCliente.Tag);

                                if (TabControl1.Controls.Contains(tabFuncionario) && !Selecionado.PessoaFuncionarios.Contains((PessoaFuncionario)tabFuncionario.Tag))
                                    Selecionado.PessoaFuncionarios.Add((PessoaFuncionario)tabFuncionario.Tag);

                                if (TabControl1.Controls.Contains(tabVendedor) && !Selecionado.PessoaVendedores.Contains((PessoaVendedor)tabVendedor.Tag))
                                    Selecionado.PessoaVendedores.Add((PessoaVendedor)tabVendedor.Tag);

                                if (TabControl1.Controls.Contains(tabContabilista) && !Selecionado.PessoaContabilistas.Contains((PessoaContabilista)tabContabilista.Tag))
                                    Selecionado.PessoaContabilistas.Add((PessoaContabilista)tabContabilista.Tag);

                                if (Operacao < Acao.Consultar)
                                {
                                    AcoesAntesSalvar();
                                    controller.Salvar(Selecionado, Operacao);
                                    AcoesDepoisSalvar();
                                }
                                this.Close();
                            }
                            break;
                        case 2: //Operadora
                            if (ValidaDiasVencimentoCartao())
                            {
                                TelaProObjeto(tpPrincipal);

                                Selecionado.PessoaAvisos = new List<PessoaAviso>();
                                Selecionado.PessoaClientes = new List<PessoaCliente>();
                                Selecionado.PessoaEmails = new List<PessoaEmail>();
                                Selecionado.PessoaEnderecos = new List<PessoaEndereco>();
                                Selecionado.PessoaFuncionarios = new List<PessoaFuncionario>();
                                Selecionado.PessoaSocios = new List<PessoaSocio>();
                                Selecionado.PessoaTelefones = new List<PessoaTelefone>();
                                Selecionado.PessoaVendedores = new List<PessoaVendedor>();
                                Selecionado.ClientesRevenda = new List<ClienteRevenda>();

                                Selecionado.TipoPessoa = "Operadora";

                                if (Operacao < Acao.Consultar)
                                {
                                    AcoesAntesSalvar();
                                    controller.Salvar(Selecionado, Operacao);
                                    AcoesDepoisSalvar();
                                }
                                this.Close();
                            }
                            break;
                    }
                    SalvarArquivos();
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null && ex.InnerException.Message.Contains("IX_Pessoa_CNPJ_CPF"))
                        new FormErro(new Exception(MensagemNome_CNPJExistente())).ShowDialog();
                    else
                        new FormErro(ex).ShowDialog();
                }
            }
        }

        private Boolean ValidaDiasVencimentoCartao()
        {
            if (String.IsNullOrEmpty(txtDiaVencimentoCartao.Text) || txtDiaVencimentoCartao.Text == "0")
            {
                dxErroProvider.SetError(txtDiaVencimentoCartao, "O dia do vencimento do cartão devem ser maior que 0");
            }

            return !dxErroProvider.HasErrors;
        }

        private bool ValidaCPFCNPJ(bool bTipoPessoaFisica)
        {
            if ((lkpCidade.Selecionado as Cidade)?.UF?.Sigla == "EX")
                return true;

            String chaveBusca = String.Empty;
            if (chbBAtivo.Checked)
            {
                if (bTipoPessoaFisica)
                    chaveBusca = txt2CNPJ_CPF.Text;
                else
                    chaveBusca = txtCNPJ_CPF.Text;

                IList<Pessoa> listaPessoasComCPFCNPJ = new List<Pessoa>();
                listaPessoasComCPFCNPJ = PessoaController.Instancia.GetAtivosByCPFeCNPJ(chaveBusca, true);

                //retira a propria pessoa da comparação, tornando qualquer registro encontrado um problema.
                listaPessoasComCPFCNPJ = listaPessoasComCPFCNPJ.Where(s => s.ID != Selecionado.ID && s.CNPJ_CPF != "00.000.000/0000-00"
                && s.CNPJ_CPF != "000.000.000-00").ToList();

                if (listaPessoasComCPFCNPJ.Count > 0)
                {
                    if (bTipoPessoaFisica)
                        dxErroProvider.SetError(txt2CNPJ_CPF, "Este CPF já está associado com outra Pessoa");
                    else
                        dxErroProvider.SetError(txtCNPJ_CPF, "Este CNPJ já está associado com outra Pessoa");
                }
            }

            return !dxErroProvider.HasErrors;
        }

        private bool ValidaCampoContato()
        {
            Selecionado.bShlTransportadora = chkbShlTransportadora.Checked && chbBTransportadora.Checked;
            string caminho = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            caminho = Path.Combine(caminho, "ConfiguracaoCwork.xml");

            bool Flag = true;

            if (Selecionado.bShlTransportadora && Convert.ToInt32(XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL").Value) == 1)
            {
                if (String.IsNullOrEmpty(txtContato.Text.Trim()))
                {
                    dxErroProvider.SetError(txtContato, "Campo Obrigatório para envio para o SHL");
                    Flag = false;
                }
            }
            return Flag;
        }

        private void ValidaCNPJExterior()
        {
            if (((Cidade)lkpCidade.Selecionado).UF.Sigla == "EX")
            {
                txtCNPJ_CPF.Enabled = false;
                txt2CNPJ_CPF.Enabled = false;

                txt2CNPJ_CPF.Text = null;
                txtCNPJ_CPF.Text = null;
                return;
            }
            HabilitarDesabilitarCnpjCpf();
        }

        private void HabilitarDesabilitarCnpjCpf()
        {
            if (cbTipoPessoa.SelectedIndex == 1)
            {
                txt2CNPJ_CPF.Text = "";
                txtCNPJ_CPF.Enabled = true;
                txt2CNPJ_CPF.Enabled = false;
            }
            else
            {
                txtCNPJ_CPF.Text = "";
                txt2CNPJ_CPF.Enabled = true;
                txtCNPJ_CPF.Enabled = false;
            }
        }

        protected override void SetarMascaras()
        {
        }

        #endregion

        #endregion

        #region Eventos

        void lkbVendedor_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookupPessoa(lkpVendedor, PessoaController.Instancia.GetAllVendedores(), "Vendedor", typeof(FormPessoa));
        }

        private void cbTipoPessoa_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTipoPessoa.EditValue != null)
            {
                DefinirValidacaoCNPJCPF();

                switch (cbTipoPessoa.SelectedIndex)
                {
                    case 0: //Fisica
                        tpTipoPessoa.TabPages.Remove(tabOperadora);
                        tpTipoPessoa.TabPages.Add(tabPessoa);
                        CRUDUtil.LiberaBloqueiaCampos(pnlOpcoesPessoa, true);

                        txtApelido.Enabled = true;
                        cbSexo.Enabled = true;
                        txtRG.Enabled = true;
                        txtDtNascimento.Enabled = true;
                        cbEstadoCivil.Enabled = true;
                        txtFantasia.Enabled = false;
                        txt2CNPJ_CPF.Enabled = true;
                        txtCNPJ_CPF.Enabled = false;
                        txtDtFundacao.Enabled = false;

                        txtCNPJ_CPF.Text = "";
                        txtFantasia.Text = "";
                        break;
                    case 1: //Juridica
                        tpTipoPessoa.TabPages.Remove(tabOperadora);
                        tpTipoPessoa.TabPages.Add(tabPessoa);
                        CRUDUtil.LiberaBloqueiaCampos(pnlOpcoesPessoa, true);

                        txtApelido.Enabled = false;
                        cbSexo.Enabled = false;
                        txtRG.Enabled = false;
                        txtCNPJ_CPF.Enabled = true;
                        txtDtNascimento.Enabled = false;
                        cbEstadoCivil.Enabled = false;
                        txtFantasia.Enabled = true;
                        txtDtFundacao.Enabled = true;
                        txt2CNPJ_CPF.Enabled = false;
                        txtInscricao.Enabled = true;

                        txtDtNascimento.EditValue = null;
                        txtApelido.Text = "";
                        txtRG.Text = "";
                        txt2CNPJ_CPF.Text = "";
                        break;
                    case 2:
                        tpTipoPessoa.TabPages.Remove(tabPessoa);
                        tpTipoPessoa.TabPages.Add(tabOperadora);
                        CRUDUtil.LiberaBloqueiaCampos(pnlOpcoesPessoa, false);

                        chbBAtivo.Enabled = true;
                        chbBAtivo.Properties.ReadOnly = false;

                        break;
                }
            }
        }

        private void DefinirValidacaoCNPJCPF()
        {
            if (chbBTransportadora.Checked || cbTipoPessoa.SelectedIndex == 0)
                txtCNPJ_CPF.CwkFuncaoValidacao = null;
            else if (cbTipoPessoa.SelectedIndex == 1)
                txtCNPJ_CPF.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(PessoaController.ValidaCnpj);
            if (!chbContabilista.Checked)
                txtEscritorioCNPJ.CwkFuncaoValidacao = null;
            else
                txtEscritorioCNPJ.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(ValidaCnpjComCidade);
            if (chbBTransportadora.Checked || cbTipoPessoa.SelectedIndex == 1)
                txt2CNPJ_CPF.CwkFuncaoValidacao = null;
            else if (cbTipoPessoa.SelectedIndex == 0)
                txt2CNPJ_CPF.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(PessoaController.ValidaCpf);
        }

        protected override void OnShown(EventArgs e)
        {
            CarregaTelaPessoaContabilista();

            base.OnShown(e);

            HabilitarDesabilitarCnpjCpf();

            CarregaEnderecoPrincipal();
            chbBFaturarPorPadrao.Checked = Selecionado.bFaturarPorPadrao;

            CKB_Delivery.Checked = Selecionado.BDelivery;
            CKB_Entregador.Checked = Selecionado.BEntregador;
            chbNaoUtilizaLimite.Checked = Selecionado.NaoUtilizaLimite;
            try
            {
                _pessoaEnderecoPrincipal = Selecionado.PessoaEnderecos.First(end => end.BPrincipal) ?? new PessoaEndereco();
                Selecionado.PessoaEnderecos.Remove(_pessoaEnderecoPrincipal);
            }
            catch
            {
                _pessoaEnderecoPrincipal = new PessoaEndereco();
            }
            try
            {
                _pessoaTelefonePrincipal = Selecionado.PessoaTelefones.First(te => te.BPrincipal) ?? new PessoaTelefone();
                Selecionado.PessoaTelefones.Remove(_pessoaTelefonePrincipal);
            }
            catch
            {
                _pessoaTelefonePrincipal = new PessoaTelefone();
            }
            gcPessoaEnderecos.RefreshDataSource();
            gvPessoaEnderecos.RefreshData();

            if (Operacao == Acao.Incluir)
            {
                txtDtCadastro.EditValue = DateTime.Now.Date;
                chbBAtivo.Checked = true;

                switch (TipoPessoa)
                {
                    case "Cliente":
                        chbBCliente.Checked = true;
                        break;
                    case "Fornecedor":
                        chbBFornecedor.Checked = true;
                        break;
                    case "Funcionários":
                        chbBFuncionario.Checked = true;
                        break;
                    case "Vendedor":
                        chbBVendedor.Checked = true;
                        break;
                    case "Transportadora":
                        chbBTransportadora.Checked = true;
                        break;
                    case "Contabilista":
                        chbContabilista.Checked = true;
                        break;
                }

                chbRemetenteDestinatario.Checked = true;
                chbBEntrega.Checked = true;
            }

            if (Selecionado?.ID == 0)
            {
                txtLimiteCredito.EditValue = Convert.ToDecimal(0.00);
            }

            CarregarConfiguracaoCidadePDV();
            CarregarServicoResponsavel();
            TabControl1.SelectedTabPage = tabDados;

            if (!string.IsNullOrEmpty(Selecionado.CaminhoFoto))
            {
                txtCaminhoFoto.Text = Selecionado.CaminhoFoto;
                pictureBox1.Image = File.Exists(Selecionado.CaminhoFoto) ? new Bitmap(Selecionado.CaminhoFoto) : null;
            }
            else
            {
                txtCaminhoFoto.Text = string.Empty;
                pictureBox1.Image = null;
            }
        }

        private void CarregarConfiguracaoCidadePDV()
        {
            if (PDV)
            {
                int? IDCidadePadrao = ConfiguracaoController.Instancia.GetConfiguracao().IDCidadePadraoNFCe;
                if (IDCidadePadrao.HasValue && IDCidadePadrao.Value != 0 && lkpCidade.Selecionado == null)
                    lkpCidade.Localizar(IDCidadePadrao.Value);
            }
        }

        private void CarregaTelaPessoaContabilista()
        {
            PessoaContabilista contabilista = PessoaContabilistaController.Instancia.GetPessoaContabilistaPorIDPessoa(Selecionado.ID);
            if (contabilista != null)
            {
                txtEscritorioCNPJ.Text = contabilista.CNPJEscritorio;
                lkpCRC.EditValue = contabilista.CRC;
            }
            else
            {
                txtEscritorioCNPJ.Text = null;
                lkpCRC.EditValue = null;
            }
        }

        private void CarregaObjetoPessoaContabilista()
        {
            Selecionado.PessoaContabilistas[0].CNPJEscritorio = txtEscritorioCNPJ.Text;
            Selecionado.PessoaContabilistas[0].CRC = (string)lkpCRC.EditValue;
        }

        private void FormPessoa_Shown(object sender, EventArgs e)
        {
            chkbShlTransportadora.EditValue = Selecionado.bShlTransportadora;
            chbContabilista.EditValue = Selecionado.bContabilista;
            chbConsumidorFinal.EditValue = Selecionado.bConsumidorFinal;

            txtDiaPadraoLeitura.Text = Convert.ToString(Selecionado.DiasPadraoLeitura);
            txtSenhaRevenda.Text = Selecionado.SenhaRevenda;

            if (Selecionado.bSTRevenda)
                chbSTRevenda.Checked = true;
            else
                chbSTRevenda.Checked = false;

            carregouTela = true;

            if (Selecionado?.ID == 0)
            {
                cbTipoPessoa.Text = "Jurídica";
                txtCNPJ_CPF.Focus();
                chbBContribuinte.Checked = false;
            }

            ApresentarLimites();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            base.sbGravar_Click(sender, e);
        }

        private void lkpCidade_Leave(object sender, EventArgs e)
        {
            if (lkpCidade.Selecionado != null)
            {
                ValidaCNPJExterior();
            }
        }
        #endregion

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            cbTipoPessoa.SelectedIndex = Selecionado.TipoPessoa == null ? -1 :
                Selecionado.TipoPessoa.Equals("Física") ? 0 :
                Selecionado.TipoPessoa.Equals("Jurídica") ? 1 :
                2;

            if (chbBTransportadora.Checked == true)
                chbBCorreio.Checked = Selecionado.bCorreio;

            DiscriminaTabs();
            if (chbBTransportadora.Checked)
            {
                SHLUtil.HabilitarCamposSHL(chkbShlTransportadora);
                chkbShlTransportadora.EditValue = Selecionado.bShlTransportadora;
            }
        }
        protected override void AcoesDepoisSalvar()
        {
            txtEscritorioCNPJ.Text = null;
            lkpCRC.EditValue = null;
            if (Selecionado != null)
            {
                Selecionado.bShlTransportadora = chkbShlTransportadora.Checked && chbBTransportadora.Checked;
                string caminho = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                caminho = Path.Combine(caminho, "ConfiguracaoCwork.xml");
                if (Selecionado.bShlTransportadora && Convert.ToInt32(XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL").Value) == 1)
                {
                    try
                    {
                        SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                        if (conf != null)
                        {

                            if (Selecionado.CodShl > 0 && Selecionado.TiposServicosTransporte != null)
                            {
                                foreach (PessoaTipoServicoTransporte item in Selecionado.TiposServicosTransporte)
                                {
                                    if (item.CodShl == 0)
                                    {
                                        string ret = cwkGestao.Integracao.SHL
                                                        .Util.CadastraServicoTransporte(
                                                            conf.ChaveSHL,
                                                            conf.InterfaceSHL,
                                                            Selecionado.CNPJ_CPF,
                                                            item.ID.ToString(),
                                                            item.TipoServicoTransporte.Descricao,
                                                            item.CodContrato == null ? "" : item.CodContrato);
                                        try
                                        {
                                            int codigoshl = Convert.ToInt32(ret);
                                            item.CodShl = codigoshl;
                                            PessoaTipoServicoTransporteController.Instancia.Salvar(item, Acao.Alterar);
                                        }
                                        catch (Exception a)
                                        {
                                            item.CodShl = 0;
                                            throw a;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            base.AcoesDepoisSalvar();
        }
        protected override void AcoesAntesSalvar()
        {
            Selecionado.bShlTransportadora = chkbShlTransportadora.Checked && chbBTransportadora.Checked;
            string caminho = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            caminho = Path.Combine(caminho, "ConfiguracaoCwork.xml");

            if (Selecionado.bShlTransportadora && Convert.ToInt32(XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL").Value) == 1)
            {
                try
                {
                    SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                    if (conf != null)
                    {
                        if (String.IsNullOrEmpty(conf.ChaveSHL))
                        {
                            MessageBox.Show("A configuração de utilização do sistema SHL está habilitada porém não há chave ou interface para comunicação. Verifique.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Selecionado.bShlTransportadora = false;
                            chkbShlTransportadora.Checked = false;
                            return;
                        }
                        if (Selecionado.CodShl == 0)
                        {
                            string retorno = cwkGestao.Integracao.SHL.Util.CadastraFornecedor(
                                            conf.ChaveSHL,
                                            conf.InterfaceSHL,
                                            Selecionado.Fantasia,
                                            Selecionado.Nome,
                                            Selecionado.EnderecoPrincipal().Endereco,
                                            Selecionado.EnderecoPrincipal().Numero,
                                            Selecionado.EnderecoPrincipal().Bairro,
                                            Selecionado.EnderecoPrincipal().Complemento,
                                            Selecionado.EnderecoPrincipal().CEP,
                                            Selecionado.EnderecoPrincipal().Cidade.Nome,
                                            Selecionado.EnderecoPrincipal().Cidade.UF.Sigla,
                                            Selecionado.EnderecoPrincipal().Cidade.UF.Pais.Nome,
                                            String.IsNullOrEmpty(Selecionado.TelefonePrincipal) ? "" : Selecionado.TelefonePrincipal,
                                            Selecionado.CNPJ_CPF.ToString(),
                                            String.IsNullOrEmpty(Selecionado.Inscricao) ? "" : Selecionado.Inscricao);
                            try
                            {
                                int codigoshl = Convert.ToInt32(retorno);
                                Selecionado.CodShl = codigoshl;
                            }
                            catch (Exception a)
                            {
                                Selecionado.bShlTransportadora = false;
                                chkbShlTransportadora.Checked = false;
                                Selecionado.CodShl = 0;
                                throw new Exception(retorno, a);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("SHL não configurado nesta instância", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception b)
                {
                    MessageBox.Show("Erro ao comunicar com o Webservice SHL: \r\n" +
                        b.Message + "\r\n\r\n" + b.InnerException.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            base.AcoesAntesSalvar();
        }
        private void GravarLogAlteracoesParticipante()
        {
            logAlteracoesParticipante = new List<LogAlteracaoParticipante>();
            LogAlteracaoParticipante logAlteracao;
            Pessoa p = PessoaController.Instancia.LoadObjectById(Selecionado.ID);
            if (p != null)
            {
                if (Convert.ToString(txtCodigo.EditValue) != Convert.ToString(p.Codigo))
                {
                    logAlteracao = new LogAlteracaoParticipante();
                    logAlteracao = this.PreenchelogAlteracao("COD_PART", 2, Convert.ToString(p.Codigo));
                    logAlteracoesParticipante.Add(logAlteracao);
                }

                if (Convert.ToString(txtNome.EditValue) != p.Nome)
                {
                    logAlteracao = new LogAlteracaoParticipante();
                    logAlteracao = this.PreenchelogAlteracao("NOME", 3, p.Nome);
                    logAlteracoesParticipante.Add(logAlteracao);
                }

                if (Convert.ToString(txtCNPJ_CPF.EditValue) != p.CNPJ_CPF)
                {
                    if (p.TipoPessoa == "Física")
                    {
                        logAlteracao = new LogAlteracaoParticipante();
                        logAlteracao = this.PreenchelogAlteracao("CPF", 6, p.CNPJ_CPF);
                        logAlteracoesParticipante.Add(logAlteracao);

                    }
                    else
                    {
                        logAlteracao = new LogAlteracaoParticipante();
                        logAlteracao = this.PreenchelogAlteracao("CNPJ", 5, p.CNPJ_CPF);
                        logAlteracoesParticipante.Add(logAlteracao);
                    }
                }
                if (p.PessoaEnderecos != null && p.PessoaEnderecos.Count() > 0)
                {
                    if (((Cidade)lkpCidade.Selecionado).IBGE != (p.PessoaEnderecos.FirstOrDefault().Cidade).IBGE)
                    {
                        if (((Cidade)lkpCidade.Selecionado).UF.Pais.IBGE !=
                            (p.PessoaEnderecos.FirstOrDefault().Cidade).UF.Pais.IBGE)
                        {
                            logAlteracao = new LogAlteracaoParticipante();
                            logAlteracao = this.PreenchelogAlteracao("COD_PAIS", 4, p.PessoaEnderecos.FirstOrDefault().Cidade.UF.Pais.IBGE);
                            logAlteracoesParticipante.Add(logAlteracao);
                        }
                        logAlteracao = new LogAlteracaoParticipante();
                        logAlteracao = this.PreenchelogAlteracao("COD_MUN", 8, p.PessoaEnderecos.FirstOrDefault().Cidade.IBGE);
                        logAlteracoesParticipante.Add(logAlteracao);
                    }
                }

                if (Convert.ToString(txtEndereco.EditValue) != p.Endereco)
                {
                    logAlteracao = new LogAlteracaoParticipante();
                    logAlteracao = this.PreenchelogAlteracao("END", 10, p.Endereco);
                    logAlteracoesParticipante.Add(logAlteracao);
                }

                if (Convert.ToString(txtNumero.EditValue) != p.Numero)
                {
                    logAlteracao = new LogAlteracaoParticipante();
                    logAlteracao = this.PreenchelogAlteracao("NUM", 11, p.Numero);
                    logAlteracoesParticipante.Add(logAlteracao);
                }

                if (Convert.ToString(txtComplemento.EditValue) != p.Complemento)
                {
                    logAlteracao = new LogAlteracaoParticipante();
                    logAlteracao = this.PreenchelogAlteracao("COMPL", 12, p.Complemento);
                    logAlteracoesParticipante.Add(logAlteracao);
                }

                if (Convert.ToString(txtBairro.EditValue) != p.Bairro)
                {
                    logAlteracao = new LogAlteracaoParticipante();
                    logAlteracao = this.PreenchelogAlteracao("BAIRRO", 13, p.Bairro);
                    logAlteracoesParticipante.Add(logAlteracao);
                }
            }

            foreach (var log in logAlteracoesParticipante)
            {
                LogAlteracaoParticipanteController.Instancia.Salvar(log, Acao.Incluir);
            }
        }
        private LogAlteracaoParticipante PreenchelogAlteracao(string nomeCampoAlterado, int numCampoAlterado, string conteudoAnterior)
        {
            LogAlteracaoParticipante logAlteracao = new LogAlteracaoParticipante();
            logAlteracao.Pessoa = Selecionado;
            logAlteracao.NomeCampoAlterado = nomeCampoAlterado;
            logAlteracao.NumeroCampoAlterado = numCampoAlterado;
            logAlteracao.ConteudoAnterior = conteudoAnterior;
            logAlteracao.DataAlteracao = DateTime.Now;
            return logAlteracao;
        }
        private void txtCEP_Leave(object sender, EventArgs e)
        {

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

        private void FormPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            carregouTela = false;
        }

        private void gvProdutoVendedorComissoes_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }

        private void gvTiposServicosTransporte_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }

        private void chbBAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (carregouTela)
            {
                ValidaInativacao();
            }
        }

        private bool ValidaInativacao()
        {
            bool retorno = true;
            string motivo = null;
            if (!chbBAtivo.Checked && String.IsNullOrEmpty(Selecionado.MotivoInativacao))
            {
                if (FormInputBox.InputBox("Motivo para inativar o cliente", "Motivo", ref motivo, null) == DialogResult.OK)
                {
                    Selecionado.DataInativacao = DateTime.Now;
                    Selecionado.MotivoInativacao = motivo;
                }
                retorno = false;
            }
            else
            {
                if (chbBAtivo.Checked)
                {
                    Selecionado.DataInativacao = null;
                    Selecionado.MotivoInativacao = motivo;
                }
            }
            return retorno;
        }

        private void chbBCliente_CheckedChanged(object sender, EventArgs e)
        {
            VerificaClienteConsumidorFinal();
        }

        private void VerificaClienteConsumidorFinal()
        {
            if (chbBCliente.Checked)
            {
                chbConsumidorFinal.Enabled = chbConsumidorFinal.Visible = true;
                TabControl1.TabPages.Add(tabCliente);
                TabControl1.TabPages.Add(tabAtendimento);
                TabControl1.TabPages.Add(tabRota);
            }
            else
            {
                chbConsumidorFinal.Enabled = chbConsumidorFinal.Visible = chbConsumidorFinal.Checked = false;
                TabControl1.TabPages.Remove(tabCliente);
                TabControl1.TabPages.Remove(tabAtendimento);
                TabControl1.TabPages.Remove(tabRota);
            }
        }

        private void chbBFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBFuncionario.Checked)
            {
                lkpCwUsuario.Visible = lkbCwUsuario.Visible = lblCwUsuario.Visible = conf.CarregarVendedor;

                if (Selecionado.PessoaFuncionarios.Count > 0 && Selecionado.PessoaFuncionarios.FirstOrDefault().CwUsuario != null)
                    lkpCwUsuario.Localizar(Selecionado.PessoaFuncionarios.FirstOrDefault().CwUsuario.ID);

                TabControl1.TabPages.Add(tabFuncionario);
            }

            else
                TabControl1.TabPages.Remove(tabFuncionario);
        }

        private void chbBVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBVendedor.Checked)
            {
                TabControl1.TabPages.Add(tabVendedor);
                TabControl1.TabPages.Add(tabComissao);
                if (Selecionado.PessoaVendedores.Count == 0)
                    Selecionado.PessoaVendedores.Add(new PessoaVendedor() { Pessoa = Selecionado });

                gcProdutoVendedorComissoes.DataSource = Selecionado.PessoaVendedores.First().ProdutoVendedorComissoes;
            }
            else
            {
                TabControl1.TabPages.Remove(tabVendedor);
                TabControl1.TabPages.Remove(tabComissao);
            }
        }

        private void chbBTransportadora_CheckedChanged(object sender, EventArgs e)
        {
            if (lkpCidade.Selecionado != null)
            {
                if (((Cidade)lkpCidade.Selecionado).UF.Sigla != "EX")
                    DefinirValidacaoCNPJCPF();
            }

            if (chbBTransportadora.Checked)
            {
                TabControl1.TabPages.Add(tabTransportadora);
                chkbShlTransportadora.Visible = true;
                chkbShlTransportadora.EditValue = false;
                gcTiposServicosTransporte.DataSource = PessoaTipoServicoTransporteController.Instancia.GetAllServicosPorPessoa(Selecionado.ID);
            }
            else
            {
                TabControl1.TabPages.Remove(tabTransportadora);
                chkbShlTransportadora.Visible = false;
                chkbShlTransportadora.EditValue = false;
                gcTiposServicosTransporte.DataSource = null;
            }
        }

        private void chbSTRevenda_CheckedChanged(object sender, EventArgs e)
        {
            ValidaTabRevenda();
        }

        private void ValidaTabRevenda()
        {
            if (chbSTRevenda.Checked == true)
            {
                TabControl1.TabPages.Add(tabRevenda);
                txtSenhaRevenda.Enabled = txtSenhaRevenda.Visible = true;
            }
            else
            {
                TabControl1.TabPages.Remove(tabRevenda);
                txtSenhaRevenda.Enabled = txtSenhaRevenda.Visible = false;
                txtSenhaRevenda.Text = string.Empty;
            }
        }

        private void chbContabilista_CheckedChanged(object sender, EventArgs e)
        {
            if (chbContabilista.Checked)
            {
                TabControl1.TabPages.Add(tabContabilista);
                if (Selecionado.PessoaContabilistas.Count == 0)
                    Selecionado.PessoaContabilistas.Add(new PessoaContabilista() { Pessoa = Selecionado });
            }
            else
            {
                TabControl1.TabPages.Remove(tabContabilista);
                if (Selecionado.PessoaContabilistas.Count > 0)
                {
                    for (int i = 0; i < Selecionado.PessoaContabilistas.Count; i++)
                    {
                        Selecionado.PessoaContabilistas.RemoveAt(i);
                    }
                }
            }
        }

        private void lkbUsuario_Click(object sender, EventArgs e)
        {
            IList<cwkGestao.Modelo.Cw_usuario> usuarios = Aplicacao.Relatorios.Extensions.ConvertTo<cwkGestao.Modelo.Cw_usuario>(cwkControleUsuario.Facade.GetAllUsuarios());

            GridUsuarios grid = new GridUsuarios(usuarios);

            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpCwUsuario.Localizar(grid.Selecionado.ID);
            }
            lkpCwUsuario.Focus();
        }

        private void lkpCwUsuario_Leave(object sender, EventArgs e)
        {
            var cw = (Cw_usuario)lkpCwUsuario.Selecionado;

            if (cw != null)
            {
                var funcionario = PessoaFuncionarioController.Instancia.GetVendedorAssociadoComUsuarioLogado(cw.Login);

                if (funcionario != null && funcionario.ID != Selecionado.ID)
                {
                    lkpCwUsuario.EditValue = null;
                    MessageBox.Show("Este Usuário já está associado com o Funcionário " + funcionario.Pessoa.Nome, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void lkbCwUsuario_Click(object sender, EventArgs e)
        {
            IList<cwkGestao.Modelo.Cw_usuario> usuarios = Aplicacao.Relatorios.Extensions.ConvertTo<cwkGestao.Modelo.Cw_usuario>(cwkControleUsuario.Facade.GetAllUsuarios());

            GridUsuarios grid = new GridUsuarios(usuarios);

            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpCwUsuario.Localizar(grid.Selecionado.ID);
            }
            lkpCwUsuario.Focus();
        }

        private void SbGravar_Click_1(object sender, EventArgs e)
        {

        }
        public static string FormatCNPJ(string CNPJ)
        {
            return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
        }


        private void btnConsultarCnpj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCNPJ_CPF.Text))
            {
                MessageBox.Show("Preencha o CNPJ e tente novamente.", "Consulta CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(() =>
            {
                //var receita = new ReceitaFederal(); //- Alterado 29/06/2022 para Buscar CNPJ e Inscrição Estadual pelo CnpjWs.
                var receita = new CnpjWs();
                var empresa = receita.Consultar(txtCNPJ_CPF.Text.TrimCk().OnlyNumbers());
                if (!receita.Valido)
                {
                    Invoke((MethodInvoker)(() => { MessageBox.Show(receita.MensagemRetorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); }));
                    return;
                }

                Invoke((MethodInvoker)(() =>
                {
                    var resultado = PessoaController.Instancia.GetByCPFeCNPJ(empresa.Cnpj);
                    if (resultado)
                    {

                        if (DialogResult.No == MessageBox.Show("CNPJ já vinculado a uma Pessoa.\n Deseja atualizar as informações cadastrais", "Consulta CNPJ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            return;

                        }
                    }

                    if (MessageBox.Show(receita.MensagemRetorno, "Consulta CNPJ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                    txtNome.EditValue = empresa.RazaoSocial;
                    txtCNPJ_CPF.EditValue = FormatCNPJ(empresa.Cnpj);
                    txtFantasia.EditValue = empresa.NomeFantasia;
                    txtEndereco.EditValue = empresa.Logradouro;
                    txtNumero.EditValue = empresa.Numero;
                    txtComplemento.EditValue = empresa.Complemento;
                    txtCEP.EditValue = empresa.Cep;
                    txtBairro.EditValue = empresa.Bairro;
                    txtTelefone.EditValue = empresa.Telefone;
                    txtInscricao.EditValue = empresa.Inscricao;

                    var cidade = CidadeController.Instancia.GetByLikeName(empresa.Cidade, empresa.Uf);

                    lkpCidade.EditValue = cidade;

                    if (empresa.Inscricao != string.Empty)
                    {
                        chbBContribuinte.Checked = true;
                    }
                    else
                    {
                        chbBContribuinte.Checked = false;
                    }
                }));
            });
        }

        private void btnConsultarCep_Click(object sender, EventArgs e)
        {
            var pessoa = PessoaController.Instancia.LoadObjectById(Selecionado.ID);
            if (pessoa != null)
            {
                if (pessoa.PessoaEnderecos.Count > 0)
                    if (pessoa.PessoaEnderecos.FirstOrDefault().CEP != txtCEP.Text)
                        BuscaInformacoesEnderecos();
                    else
                        BuscaInformacoesEnderecos();
            }
            else
            {
                BuscaInformacoesEnderecos();
            }
        }

        private IList<PessoaResponsavelServico> ListaResponsavelServico { get; set; }
        private void CarregarServicoResponsavel(bool Carregar = true)
        {
            if (Carregar)
            {
                ListaResponsavelServico = PessoaResponsavelServicoController.Instancia.GetAll();

                foreach (var Resp in ListaResponsavelServico)
                {
                    if (Resp.IDServico.HasValue)
                        Resp.Servico = ServicoResponsavelController.Instancia.LoadObjectById(Resp.IDServico.Value).Descricao;

                    if (Resp.IDResponsavel.HasValue)
                        Resp.Responsavel = ResponsavelController.Instancia.LoadObjectById(Resp.IDResponsavel.Value).Descricao;
                }
            }

            gcResponsavelServico.DataSource = ListaResponsavelServico.Where(o => o.IDPessoa == Selecionado.ID && !o.Removido).ToList();
            gcResponsavelServico.RefreshDataSource();
            gcResponsavelServico.Refresh();

            gvResponsavelServico.MoveLastVisible();

            int value = gridView1.RowCount - 1;
            gvResponsavelServico.TopRowIndex = value;
            gvResponsavelServico.FocusedRowHandle = value;
        }



        private void btIncluirServico_Click(object sender, EventArgs e)
        {
            PessoaResponsavelServico ResponsavelServico = new PessoaResponsavelServico
            {
                Novo = true,
                IDPessoa = Selecionado.ID
            };

            FormPessoaResponsavelServico f = new FormPessoaResponsavelServico(ResponsavelServico, Acao.Incluir);
            f.ShowDialog(this);

            if (f.Salvou)
            {
                ListaResponsavelServico.Add(ResponsavelServico);
                CarregarServicoResponsavel(false);
            }
        }

        private void btAlterarServico_Click(object sender, EventArgs e)
        {
            PessoaResponsavelServico ResponsavelServico = gvResponsavelServico.GetFocusedRow() as PessoaResponsavelServico;
            FormPessoaResponsavelServico f = new FormPessoaResponsavelServico(ResponsavelServico, Acao.Alterar);
            f.ShowDialog(this);
            if (f.Salvou)
            {
                ResponsavelServico.Editado = true;
                ResponsavelServico.IDPessoa = Selecionado.ID;
                CarregarServicoResponsavel(false);
            }
        }

        private void btExcluirServico_Click(object sender, EventArgs e)
        {
            PessoaResponsavelServico ResponsavelServico = gvResponsavelServico.GetFocusedRow() as PessoaResponsavelServico;
            if (MessageBox.Show("Deseja remover o Responsável/Serviço?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResponsavelServico.Removido = true;
                CarregarServicoResponsavel(false);
            }
        }

        private void SalvarArquivos()
        {
            foreach (PessoaResponsavelServico Responsavel in ListaResponsavelServico)
            {
                Responsavel.IDPessoa = Selecionado.ID;
                if (Responsavel.Novo)
                    PessoaResponsavelServicoController.Instancia.Salvar(Responsavel, Acao.Incluir);

                if (Responsavel.Editado)
                    PessoaResponsavelServicoController.Instancia.Salvar(Responsavel, Acao.Alterar);

                if (Responsavel.Removido)
                    PessoaResponsavelServicoController.Instancia.Salvar(Responsavel, Acao.Excluir);
            }
        }

        private void ApresentarLimites()
        {
            txtLimiteDocumentos.EditValue = Convert.ToDecimal(0.01);
            txtLimitePedidos.EditValue = Convert.ToDecimal(0.01);

            decimal LimiteDocumentos = DocumentoController.Instancia.GetValorSaldoAllAbertosPorCliente(Selecionado);
            decimal LimitePedidos = PedidoController.Instancia.GetValorTotalPedidosAbertosLimiteCredito(Selecionado);

            txtLimiteDocumentos.EditValue = LimiteDocumentos;
            txtLimitePedidos.EditValue = LimitePedidos;

            txtLimiteDisponivel.EditValue = Convert.ToDecimal(txtLimiteCredito.EditValue) - (LimiteDocumentos + LimitePedidos);
        }

        private void btnSelecionaFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Selecionado.CaminhoFoto = openFileDialog1.FileName;
                txtCaminhoFoto.Text = Selecionado.CaminhoFoto;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnCapturaFoto_Click(object sender, EventArgs e)
        {
            using (var form = new FormCapturaFoto())
            {
                form.NomeSubPastaSalvar = "Pessoa";
                var nomeArquivo = $"ImagemPessoa_{Selecionado.Codigo}{DateTime.Now.Minute:00}{DateTime.Now.Second:00}";
                var caminho = form.ShowDialog(nomeArquivo);

                Selecionado.CaminhoFoto = caminho;
                txtCaminhoFoto.Text = caminho;
                pictureBox1.Image = new Bitmap(caminho);
            }
        }
    }
}
