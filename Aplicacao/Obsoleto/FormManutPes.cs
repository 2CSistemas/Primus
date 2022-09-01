using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Util;
using Modelo;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace Aplicacao
{
    public partial class FormManutPes : Form, Aplicacao.Interfaces.IFormManut<cwkGestao.Modelo.Pessoa>
    {
        #region Variáveis Globais
        private Modelo.DataClassesDataContext db = new DataClassesDataContext();
        private BLL.ProdutoVendedorComissao bllProdutoVendedorComissao;
        private Modelo.Pessoa objPessoa;
        private BLL.Pessoa bllPessoa;
        private Modelo.Endereco enderecoPrincipal;
        private Modelo.Telefone telefonePrincipal;
        private Modelo.Cliente objPessoaCliente;
        private Modelo.Funcionario objPessoaFuncionario;
        private Modelo.Vendedor objPessoaVendedor;
        private Modelo.Cidade objCidade = new Modelo.Cidade();
        private Modelo.Classificacao objClass = new Classificacao();
        private Modelo.Filial objFilial = new Filial();
        private Modelo.Condicao objCondicao = new Condicao();
        private Modelo.TabelaPreco objTabPreco = new TabelaPreco();
        private Modelo.Vendedor objVendedor = new Vendedor();
        public bool bCobranca = false;
        private List<Modelo.Objeto.pxyEmail> ListaEmail { get; set; }
        private List<Modelo.Objeto.pxyProdutoVendedorComissao> ListaComissao { get; set; }
        //Variável da Acao da Tela
        int acao;

        #endregion

        public cwkGestao.Modelo.Pessoa Selecionado { get; set; }
        public cwkGestao.Modelo.Acao Acao { get; set; }

        public FormManutPes(int pAcao, int pID, bool pCliente, bool pFuncionario, bool pVendedor, bool pFornecedor)
        {
            bllProdutoVendedorComissao = new BLL.ProdutoVendedorComissao(db);
            InitializeComponent();
            FazTudo(pAcao, pID, pCliente, pFuncionario, pVendedor, pFornecedor);
        }

        public void FazTudo(int pAcao, int pID, bool pCliente, bool pFuncionario, bool pVendedor, bool pFornecedor)
        {
            if (!pVendedor)
                TabControl1.TabPages.Remove(tabComissao);
            this.acao = pAcao;
            cbCidade.Properties.DataSource = objCidade.getListaCombo(db);
            cbCidade.Properties.DisplayMember = "Nome";
            cbCidade.Properties.ValueMember = "ID";
            cbClassificacao.Properties.DataSource = objClass.getListaCombo(db);
            cbClassificacao.Properties.DisplayMember = "Nome";
            cbClassificacao.Properties.ValueMember = "ID";
            cbFilial.Properties.DataSource = objFilial.getListaCombo(db);
            cbFilial.Properties.DisplayMember = "Nome";
            cbFilial.Properties.ValueMember = "ID";

            cbCondicao.Properties.DataSource = objCondicao.getListaCombo(db);
            cbCondicao.Properties.DisplayMember = "Nome";
            cbCondicao.Properties.ValueMember = "ID";
            cbTabPreco.Properties.DataSource = objTabPreco.getListaCombo(db);
            cbTabPreco.Properties.DisplayMember = "Nome";
            cbTabPreco.Properties.ValueMember = "ID";
            cbVendedor.Properties.DataSource = objVendedor.getListaCombo(db);
            cbVendedor.Properties.DisplayMember = "Nome";
            cbVendedor.Properties.ValueMember = "ID";

            bllPessoa = new BLL.Pessoa(db);

            if (pID != 0)
            {
                objPessoa = (Modelo.Pessoa)bllPessoa.getObjeto(pID);

                //Objeto criado para recuperar o telefone principal
                if ((objPessoa.Telefones.Count > 0) && (objPessoa.Telefones.Where(t => t.bPrincipal == 1).Count() > 0))
                    telefonePrincipal = objPessoa.Telefones.Where(t => t.bPrincipal == 1).Single();
                else
                    telefonePrincipal = new Telefone();

                //Objeto Criado para recuperar o endereço principal
                enderecoPrincipal = objPessoa.GetEnderecoPrincipal();

                #region Carregar dados na tela

                cbTipo.Text = objPessoa.TipoPessoa;

                txtCodigo.Text = objPessoa.Codigo.ToString();
                txtNome.Text = objPessoa.Nome;
                txtWebSite.Text = objPessoa.Http;
                txtEmail1.Text = objPessoa.Email1;
                txtEmail2.Text = objPessoa.Email2;
                txtDtCad.EditValue = objPessoa.DtCadastro;
                cbFilial.EditValue = objPessoa.IDFilial;
                if (objPessoa.IDClassificacao.HasValue)
                    cbClassificacao.EditValue = objPessoa.IDClassificacao;
                txtObs.Text = objPessoa.Observacao;
                if (objPessoa.TipoPessoa == "Física")
                {
                    txtApelido.Text = objPessoa.Apelido;
                    txtCPF.Text = objPessoa.CNPJ_CPF;
                    txtRG.Text = objPessoa.RG;
                    cbSexo.Text = objPessoa.Sexo;
                    cbEstadoCivil.Text = objPessoa.EstadoCivil;
                    txtDtNasc.EditValue = objPessoa.DtNascimento;
                    DesabilitaCampos(0);
                }
                if (objPessoa.TipoPessoa == "Jurídica")
                {
                    txtFantasia.Text = objPessoa.Fantasia;
                    txtInscricao.Text = objPessoa.Inscricao;
                    txtDtFund.EditValue = objPessoa.DtFundacao;
                    txtCNPJ.Text = objPessoa.CNPJ_CPF;
                    DesabilitaCampos(1);
                }

                txtEnd.Text = enderecoPrincipal.Rua;
                txtBairro.Text = enderecoPrincipal.Bairro;
                txtCEP.Text = enderecoPrincipal.CEP;
                cbCidade.EditValue = enderecoPrincipal.IDCidade;
                txtTelPrincipal.Text = enderecoPrincipal.Telefone;
                txtContato.Text = enderecoPrincipal.Contato;
                txtNumero.Text = enderecoPrincipal.Numero;
                txtComplemento.EditValue = enderecoPrincipal.Complemento;
                txtBanco.EditValue = objPessoa.NumeroBanco;
                txtAgencia.EditValue = objPessoa.Agencia;
                txtContaCorrente.EditValue = objPessoa.ContaCorrente;

                if (enderecoPrincipal.bEntrega.Value == 1)
                {
                    chbEntrega.Checked = true;
                }
                if (enderecoPrincipal.bCobranca.Value == 1)
                {
                    chbCobranca.Checked = true;
                }
                txtTelPrincipal.Text = telefonePrincipal.Numero;

                if (objPessoa.bAtivo.Value == 1)
                {
                    chbAtivo.Checked = true;
                }
                if (objPessoa.bFornecedor.Value == 1)
                {
                    chbFornecedor.Checked = true;
                }
                if (objPessoa.bOrgaoPublico.Value == 1)
                {
                    chbOrgao.Checked = true;
                }

                if (objPessoa.bCliente == 1)
                {
                    CarregaDadosCliente();
                    chbCliente.Checked = true;
                    if (objPessoaCliente.Vendedor != null)
                    {
                        cbVendedor.EditValue = objPessoaCliente.Vendedor.IDPessoa;
                    }
                    else
                    {
                        cbVendedor.EditValue = 0;
                    }
                }
                else
                {
                    TabControl1.TabPages.Remove(tabCliente);
                }

                if (objPessoa.bFuncionario == 1)
                {
                    chbFuncionario.Checked = true;
                }
                else
                {
                    TabControl1.TabPages.Remove(tabFuncionario);
                }

                if (objPessoa.bVendedor == 1)
                {
                    chbVendedor.Checked = true;
                }
                else
                {
                    TabControl1.TabPages.Remove(tabVendedor);
                }

                #endregion

                #region Carrega Grids

                CarregaGridEndereco("Rua", 0);
                CarregaGridTelefone("Numero", 0);
                CarregaGridAviso("DtValidade", 0);
                CarregaGridComissao();

                var email = (from e in objPessoa.PessoaEmails
                             select new Modelo.Objeto.pxyEmail
                             {
                                 Descricao = e.Email,
                                 bFinanceiro = e.bFinanceiro,
                                 bAdministrativo = e.bAdministrativo,
                                 bCompra = e.bCompra,
                                 bContato = e.bContato,
                                 bMsn = e.bMsn,
                                 bSugestao = e.bSugestao,
                                 bVenda = e.bVenda,
                                 BNFe = e.BNFe,
                                 ID = e.ID,
                                 IDPessoa = e.IDPessoa
                             }).ToList<Modelo.Objeto.pxyEmail>();

                if (email.Count() > 0)
                {
                    ListaEmail = email;
                    CarregaGridEmail("Descricao", 0);
                }
                else
                {
                    ListaEmail = new List<Modelo.Objeto.pxyEmail>();
                }

                #endregion

                this.Text = "Alterando Pessoa";
                if (acao == 3)
                {
                    db.Pessoas.DeleteOnSubmit(objPessoa);

                    foreach (Control campo in this.Controls) //rotina para desabilitar os campos do form
                    {
                        campo.Enabled = false;
                    }

                    btGravar.Enabled = true;
                    btCancelar.Enabled = true;
                    btAjuda.Enabled = true;

                    this.Text = "Excluindo Pessoa";
                    btGravar.Text = "      &OK";
                }
                else
                {
                    if (acao == 4)
                    {
                        this.Text = "Consultando Pessoa";
                        btGravar.Enabled = false;
                        btGravar.Visible = false;
                    }
                }
            }
            else
            {
                this.Text = "Incluindo Pessoa";

                chbAtivo.Checked = true;

                objPessoa = new Modelo.Pessoa();
                enderecoPrincipal = new Modelo.Endereco();
                telefonePrincipal = new Modelo.Telefone();

                //db.Pessoas.InsertOnSubmit(objPessoa);

                txtCodigo.Text = bllPessoa.RetornaMAXCodigo().ToString();
                txtDtCad.Text = DateTime.Now.ToShortDateString();

                chbFornecedor.Checked = pFornecedor;

                if (!pCliente)
                {
                    TabControl1.TabPages.Remove(tabCliente);
                }
                chbCliente.Checked = pCliente;
                if (!pFuncionario)
                {
                    TabControl1.TabPages.Remove(tabFuncionario);
                }
                chbFuncionario.Checked = pFuncionario;
                if (!pVendedor)
                {
                    TabControl1.TabPages.Remove(tabComissao);
                    TabControl1.TabPages.Remove(tabVendedor);
                }
                chbVendedor.Checked = pVendedor;

                if (chbVendedor.Checked || chbFuncionario.Checked)
                {
                    cbTipo.Text = "Física";
                }

                cbVendedor.EditValue = 0;
                cbCondicao.EditValue = 0;
                cbClassificacao.EditValue = 0;
                cbFilial.EditValue = 0;
                cbTabPreco.EditValue = 0;
                cbCidade.EditValue = 0;

                var fils = db.Filials;
                if (fils.Count() == 1)
                    cbFilial.EditValue = fils.First().ID;
            }
            txtNome.Reset();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if(acao == 1)
                    db.Pessoas.InsertOnSubmit(objPessoa);
                objPessoa.AltData = DateTime.Now;
                objPessoa.AltUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                if (acao != 3)
                {
                    
                    if (!objPessoa.Valida(errorProvider1, this.Controls, true, true, false))
                    {
                        throw new Exception("Verificar anomalias");
                    }

                    objPessoa.Codigo = (int)txtCodigo.Value;

                    objPessoa.TipoPessoa = cbTipo.Text;

                    if (chbAtivo.Checked)
                    {
                        objPessoa.bAtivo = 1;
                    }
                    else
                    {
                        objPessoa.bAtivo = 0;
                    }

                    if (chbFornecedor.Checked)
                    {
                        objPessoa.bFornecedor = 1;
                    }
                    else
                    {
                        objPessoa.bFornecedor = 0;
                    }

                    objPessoa.Nome = txtNome.Text;

                    objPessoa.DtCadastro = txtDtCad.DateTime;

                    if ((int)cbClassificacao.EditValue > 0)
                        objPessoa.Classificacao = (Modelo.Classificacao)objClass.getObjeto(db, (int)cbClassificacao.EditValue);
                    objPessoa.Filial = (Modelo.Filial)objFilial.getObjeto(db, (int)cbFilial.EditValue);
                    objPessoa.Http = txtWebSite.Text;
                    objPessoa.Email1 = txtEmail1.Text;
                    objPessoa.Email2 = txtEmail2.Text;
                    objPessoa.Observacao = txtObs.Text;
                    objPessoa.NumeroBanco = Convert.ToInt16(txtBanco.Value);
                    objPessoa.ContaCorrente = txtContaCorrente.Text;
                    objPessoa.Agencia = txtAgencia.Text;
                    objPessoa.Inscricao = txtInscricao.Text;

                    if (objPessoa.TipoPessoa == "Física")
                    {
                        if (txtDtNasc.DateTime != new DateTime())
                            objPessoa.DtNascimento = txtDtNasc.DateTime;
                        else
                            objPessoa.DtNascimento = null;

                        objPessoa.Apelido = txtApelido.Text;
                        objPessoa.RG = txtRG.Text;
                        objPessoa.Sexo = cbSexo.Text;
                        objPessoa.EstadoCivil = cbEstadoCivil.Text;
                        objPessoa.CNPJ_CPF = txtCPF.Text;
                        objPessoa.bOrgaoPublico = 0;
                    }
                    else
                    {
                        if (chbOrgao.Checked)
                        {
                            objPessoa.bOrgaoPublico = 1;
                        }
                        else
                        {
                            objPessoa.bOrgaoPublico = 0;
                        }
                        objPessoa.Fantasia = txtFantasia.Text;

                        objPessoa.CNPJ_CPF = txtCNPJ.Text;

                        if (txtDtFund.EditValue != String.Empty && txtDtFund.DateTime != new DateTime())
                            objPessoa.DtFundacao = txtDtFund.DateTime;
                    }

                    telefonePrincipal.Numero = txtTelPrincipal.Text;

                    #region Salva endereços principal

                    enderecoPrincipal.Rua = txtEnd.Text;
                    enderecoPrincipal.Bairro = txtBairro.Text;
                    enderecoPrincipal.Cidade = (Modelo.Cidade)objCidade.getObjeto(db, (int)cbCidade.EditValue);
                    enderecoPrincipal.CEP = txtCEP.Text;
                    enderecoPrincipal.Contato = txtContato.Text;
                    enderecoPrincipal.Telefone = txtTelPrincipal.Text;
                    enderecoPrincipal.bAtivo = 1;
                    enderecoPrincipal.Numero = txtNumero.Text;
                    enderecoPrincipal.Sequencia = enderecoPrincipal.RetornaMAXSequencia(objPessoa);
                    enderecoPrincipal.Descricao = txtNome.Text;
                    enderecoPrincipal.Complemento = txtComplemento.Text;

                    if (chbCobranca.Checked)
                    {
                        try
                        {
                            var endCobranca = objPessoa.Enderecos.Where(b => b.bCobranca == 1);

                            foreach (Modelo.Endereco end in endCobranca)
                            {
                                if ((end.bCobranca == 1) && (end.Sequencia != enderecoPrincipal.Sequencia))
                                {
                                    end.bCobranca = 0;
                                }
                            }
                        }
                        finally
                        {
                            enderecoPrincipal.bCobranca = 1;
                        }
                    }
                    else
                    {
                        enderecoPrincipal.bCobranca = 0;
                    }

                    if (chbEntrega.Checked)
                    {
                        enderecoPrincipal.bEntrega = 1;
                    }
                    else
                    {
                        enderecoPrincipal.bEntrega = 0;
                    }

                    #endregion

                    #region Salva dados Cliente

                    if (chbCliente.Checked)
                    {
                        if (((acao == 1) || (objPessoa.bCliente == 0)) && (objPessoa.Clientes.Count == 0))
                        {
                            objPessoaCliente = new Modelo.Cliente();
                            objPessoa.Clientes.Add(objPessoaCliente);
                        }

                        objPessoa.bCliente = 1;

                        if (objPessoaCliente == null)
                        {
                            objPessoaCliente = (from c in objPessoa.Clientes
                                                where c.IDPessoa == objPessoa.ID
                                                select c).Single();
                        }

                        if ((int)cbCondicao.EditValue > 0)
                            objPessoaCliente.Condicao = (Modelo.Condicao)objCondicao.getObjeto(db, (int)cbCondicao.EditValue);
                        if ((int)cbTabPreco.EditValue > 0)
                            objPessoaCliente.TabelaPreco = (Modelo.TabelaPreco)objTabPreco.getObjeto(db, (int)cbTabPreco.EditValue);
                        if ((int)cbVendedor.EditValue > 0)
                            objPessoaCliente.Vendedor = db.Pessoas.Where(v => v.ID == (int)cbVendedor.EditValue).First();
                        objPessoaCliente.NomeConjuge = txtNomeConj.Text;
                        objPessoaCliente.NomeMae = txtNomeMae.Text;
                        objPessoaCliente.NomePai = txtNomePai.Text;

                        if (String.IsNullOrEmpty(txtLimite.Text))
                        {
                            objPessoaCliente.LimiteCredito = 0;
                        }
                        else
                        {
                            objPessoaCliente.LimiteCredito = Decimal.Parse(txtLimite.Text);
                        }

                        if (chbBloquearCondicao.Checked)
                        {
                            objPessoaCliente.bBloqueiaCondicao = 1;
                        }
                        else
                        {
                            objPessoaCliente.bBloqueiaCondicao = 0;
                        }

                        if (chbBloquearTabPreco.Checked)
                        {
                            objPessoaCliente.bBloqueiaTabelaPreco = 1;
                        }
                        else
                        {
                            objPessoaCliente.bBloqueiaTabelaPreco = 0;
                        }

                        if (chbContribuinte.Checked)
                        {
                            objPessoaCliente.bContribuinte = 1;
                        }
                        else
                        {
                            objPessoaCliente.bContribuinte = 0;
                        }
                    }
                    else
                    {
                        objPessoa.bCliente = 0;
                    }

                    #endregion

                    if (chbFuncionario.Checked)
                    {
                        if (((acao == 1) || (objPessoa.bFuncionario == 0)) && (objPessoa.Funcionarios.Count == 0))
                        {
                            objPessoaFuncionario = new Modelo.Funcionario();
                            objPessoa.Funcionarios.Add(objPessoaFuncionario);
                        }
                        else
                        {
                            objPessoaFuncionario = objPessoa.Funcionarios.Where(f => f.IDPessoa == objPessoa.ID).Single();
                        }
                        objPessoaFuncionario.NumCarteiraTrab = txtCarteiraDeTrabalho.Text;
                        objPessoa.bFuncionario = 1;
                    }
                    else
                    {
                        objPessoa.bFuncionario = 0;
                    }

                    if (chbVendedor.Checked)
                    {
                        if (((acao == 1) || (objPessoa.bVendedor == 0)) && (db.Vendedors.Where(v => v.IDPessoa == objPessoa.ID).Count() == 0))
                        {
                            db.Vendedors.InsertOnSubmit(objPessoaVendedor);
                        }
                        else
                        {
                            objPessoaVendedor = db.Vendedors.Where(v => v.IDPessoa == objPessoa.ID).Single();
                        }
                        objPessoaVendedor.ComissaoVendedor = txtComissao.Value;
                        objPessoaVendedor.Senha = (string)txtSenha.EditValue;
                        objPessoa.bVendedor = 1;
                    }
                    else
                    {
                        objPessoa.bVendedor = 0;
                        if (objPessoaVendedor != null && objPessoaVendedor.ID == 0)
                            objPessoaVendedor.Pessoa = null;
                    }

                    if (acao == 1)
                    {
                        objPessoa.IncUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                        objPessoa.IncData = DateTime.Now;
                        objPessoa.bClienteRevenda = 0;
                        objPessoa.bFuncionarioCliente = 0;
                        objPessoa.bRevenda = 0;

                        int qEndPrincipal = objPessoa.Enderecos.Where(b => b.bPrincipal == 1).Count();
                        if (qEndPrincipal == 0)
                        {
                            enderecoPrincipal.bPrincipal = 1;
                        }

                        telefonePrincipal.Sequencia = telefonePrincipal.RetornaMAXSequencia(objPessoa);
                        telefonePrincipal.Contato = txtNome.Text;
                        telefonePrincipal.Tipo = "Residencial";

                        int qTelPrincipal = objPessoa.Telefones.Where(b => b.bPrincipal == 1).Count();
                        if (qTelPrincipal == 0)
                        {
                            telefonePrincipal.bPrincipal = 1;
                        }

                        objPessoa.Enderecos.Add(enderecoPrincipal);
                        objPessoa.Telefones.Add(telefonePrincipal);
                    }
                }
                if (ListaEmail == null)
                    ListaEmail = new List<Modelo.Objeto.pxyEmail>();
                foreach (Modelo.Objeto.pxyEmail item in ListaEmail)
                {
                    if (item.ID != 0)
                    {
                        Modelo.PessoaEmail objEmail = (from email in objPessoa.PessoaEmails
                                                       where email.ID == item.ID
                                                       select email).Single();
                        db.PessoaEmails.DeleteOnSubmit(objEmail);
                    }
                }

                objPessoa.PessoaEmails.Clear();
                foreach (Modelo.Objeto.pxyEmail item in ListaEmail)
                {
                    Modelo.PessoaEmail objEmail = new PessoaEmail();
                    objEmail.Email = item.Descricao;
                    objEmail.bAdministrativo = item.bAdministrativo;
                    objEmail.bCompra = item.bCompra;
                    objEmail.bContato = item.bContato;
                    objEmail.bFinanceiro = item.bFinanceiro;
                    objEmail.bMsn = item.bMsn;
                    objEmail.bSugestao = item.bSugestao;
                    objEmail.bVenda = item.bVenda;
                    objEmail.BNFe = item.BNFe;
                    objPessoa.PessoaEmails.Add(objEmail);
                }

                if (objPessoa.bVendedor == 1)
                {
                    foreach (Modelo.Objeto.pxyProdutoVendedorComissao item in ListaComissao)
                    {
                        if (item.ID == 0)
                            db.ProdutoVendedorComissaos.InsertOnSubmit(new ProdutoVendedorComissao()
                            {
                                ComissaoPct = item.Comissao,
                                IDProduto = item.IDProduto,
                                Vendedor = objPessoaVendedor
                            });
                    }
                }

                db.SubmitChanges();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Modelo.MetodosEstaticos.SqlExcecao(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Selecionado = null;
            this.Close();
        }

        #region Métodos auxiliares

        /// <summary>
        /// Método para carregar tela de manutenção para os cadastros de endereços, telefones e avisos.
        /// </summary>
        /// <param name="pAcao">número especifica o tipo de ação a ser executada</param>
        /// <param name="pSeq">número que identifica o registro selecionado</param>
        /// <param name="tipo">número que especifica o tipo de manutenção que será chamada</param>
        public void CarregaManut(int pAcao, int pSeq, int tipo)
        {
            if ((pAcao != 1) && (pSeq == 0))
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
            else
            {
                switch (tipo)
                {
                    case 1:

                        new FormManutEndereco(pAcao, pSeq, db, objPessoa, this).ShowDialog();
                        if (bCobranca)
                        {
                            chbCobranca.Checked = false;
                        }
                        if (pAcao != 4)
                        {
                            if (gvEnderecos.SortedColumns.Count > 0)
                            {
                                CarregaGridEndereco(gvEnderecos.SortedColumns[0].FieldName, gvEnderecos.FocusedRowHandle);
                            }
                            else
                            {
                                CarregaGridEndereco("Rua", 0);
                            }

                        }
                        break;
                    case 2:
                        new FormManutTelefone(pAcao, pSeq, db, objPessoa).ShowDialog();
                        if (pAcao != 4)
                        {
                            if (gvTelefones.SortedColumns.Count > 0)
                            {
                                CarregaGridTelefone(gvTelefones.SortedColumns[0].FieldName, gvTelefones.FocusedRowHandle);
                            }
                            else
                            {
                                CarregaGridTelefone("Numero", 0);
                            }

                        }
                        break;
                    case 3:
                        new FormManutPessoaAviso(pAcao, pSeq, db, objPessoa).ShowDialog();
                        if (pAcao != 4)
                        {
                            if (gvAvisos.SortedColumns.Count > 0)
                            {
                                CarregaGridAviso(gvAvisos.SortedColumns[0].FieldName, gvAvisos.FocusedRowHandle);
                            }
                            else
                            {
                                CarregaGridAviso("DtValidade", 0);
                            }

                        }
                        break;
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>número que identifica o registro selecionado na tabela</returns>
        public Int32 EnderecoSelecionado()
        {
            Int32 seq;
            try
            {
                seq = (int)gvEnderecos.GetFocusedRowCellValue("Sequencia");
            }
            catch (Exception)
            {
                seq = 0;
            }
            return seq;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>número que identifica o registro selecionado na tabela</returns>
        public int TelefoneSelecionado()
        {
            Int32 seq;
            try
            {
                seq = (int)gvTelefones.GetFocusedRowCellValue("Sequencia");
            }
            catch (Exception)
            {
                seq = 0;
            }
            return seq;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>número que identifica o registro selecionado na tabela</returns>
        public int AvisoSelecionado()
        {
            Int32 seq;
            try
            {
                seq = (int)gvAvisos.GetFocusedRowCellValue("Sequencia");
            }
            catch (Exception)
            {
                seq = 0;
            }
            return seq;
        }

        /// <summary>
        /// Método para desabilitar determinados campos, que são escolhidos de acordo com o tipo de pessoa: Física ou Jurídica.
        /// </summary>
        /// <param name="x">Parâmetro que recebe o tipo de pessoa: 0 = Física e 1 = Jurídica</param>
        public void DesabilitaCampos(int x)
        {
            switch (x)
            {
                case 0:
                    chbOrgao.Enabled = false;
                    txtFantasia.Enabled = false;
                    //txtInscricao.Enabled = false;
                    txtCNPJ.Enabled = false;
                    txtDtFund.Enabled = false;
                    HabilitaCampos(0);
                    break;
                case 1:
                    txtApelido.Enabled = false;
                    txtRG.Enabled = false;
                    cbSexo.Enabled = false;
                    cbEstadoCivil.Enabled = false;
                    txtDtNasc.Enabled = false;
                    txtCPF.Enabled = false;
                    HabilitaCampos(1);
                    break;
            }

            errorProvider1.Clear();
        }

        /// <summary>
        /// Método para habilitar determinados campos, que são escolhidos de acordo com o tipo de pessoa: Física ou Jurídica.
        /// </summary>
        /// <param name="x">Parâmetro que recebe o tipo de pessoa: 0 = Física e 1 = Jurídica</param>
        public void HabilitaCampos(int x)
        {
            switch (x)
            {
                case 0:
                    txtApelido.Enabled = true;
                    txtRG.Enabled = true;
                    cbSexo.Enabled = true;
                    cbEstadoCivil.Enabled = true;
                    txtDtNasc.Enabled = true;
                    txtCPF.Enabled = true;
                    break;
                case 1:
                    chbOrgao.Enabled = true;
                    txtFantasia.Enabled = true;
                    txtInscricao.Enabled = true;
                    txtCNPJ.Enabled = true;
                    txtDtFund.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// Método para atualizar o grid de endereços
        /// </summary>
        /// <param name="pSort">Coluna base para ordenação</param>
        /// <param name="posicao">posição da seleção no grid</param>
        public void CarregaGridEndereco(string pSort, int posicao)
        {
            var end = from e in objPessoa.Enderecos
                      join c in db.Cidades on e.IDCidade equals c.ID
                      where e.bPrincipal == 0
                      select new
                      {
                          Rua = e.Rua,
                          Bairro = e.Bairro,
                          Cidade = c.Nome,
                          Sequencia = e.Sequencia,
                          ID = e.ID
                      };

            gcEnderecos.DataSource = end.ToList();
            gvEnderecos.BestFitColumns();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvEnderecos.SortInfo.Clear();
            gvEnderecos.SortInfo.ClearSorting();
            gvEnderecos.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvEnderecos.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvEnderecos.RowCount - 1)
                {
                    posicao = gvEnderecos.RowCount - 1;
                }
                gvEnderecos.SelectRow(posicao);
                gvEnderecos.FocusedRowHandle = posicao;
            }
            else
            {
                gvEnderecos.ClearSelection();
                gvEnderecos.SelectRow(0);
                gvEnderecos.FocusedRowHandle = 0;
            }
        }

        private void CarregaGridComissao()
        {
            if (objPessoaVendedor != null && objPessoaVendedor.ID > 0 && ListaComissao == null)
                ListaComissao = bllProdutoVendedorComissao.getComissoes(objPessoaVendedor.ID);
            else if (ListaComissao == null)
                ListaComissao = new List<Modelo.Objeto.pxyProdutoVendedorComissao>();

            gcComissoes.DataSource = ListaComissao;
            gvComissoes.RefreshData();
        }

        /// <summary>
        /// Método para atualizar o grid de email
        /// </summary>
        /// <param name="pSort">Coluna base para ordenação</param>
        /// <param name="posicao">posição da seleção no grid</param>
        public void CarregaGridEmail(string pSort, int posicao)
        {
            var email = from e in ListaEmail
                        select new
                        {
                            Descricao = e.Descricao,
                            bFinanceiro = (e.bFinanceiro == 1 ? "Sim" : "Não"),
                            bAdministrativo = (e.bAdministrativo == 1 ? "Sim" : "Não"),
                            bCompra = (e.bCompra == 1 ? "Sim" : "Não"),
                            bContato = (e.bContato == 1 ? "Sim" : "Não"),
                            bMsn = (e.bMsn == 1 ? "Sim" : "Não"),
                            bSugestao = (e.bSugestao == 1 ? "Sim" : "Não"),
                            bVenda = (e.bVenda == 1 ? "Sim" : "Não"),
                            BNFe = e.BNFe ? "Sim" : "Não",
                            ID = e.ID
                        };
            if (email.Count() > 0)
            {
                gcEmail.DataSource = email.ToList();
                gvEmail.BestFitColumns();

                //Codigo para posicionar a seleção do grid no registro correto        
                gvEmail.SortInfo.Clear();
                gvEmail.SortInfo.ClearSorting();
                gvEmail.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
                gvEmail.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                if (posicao != 0)
                {
                    if (posicao > gvEmail.RowCount - 1)
                    {
                        posicao = gvEmail.RowCount - 1;
                    }
                    gvEmail.SelectRow(posicao);
                    gvEmail.FocusedRowHandle = posicao;
                }
                else
                {
                    gvEmail.ClearSelection();
                    gvEmail.SelectRow(0);
                    gvEmail.FocusedRowHandle = 0;
                }
            }
            else
            {
                gcEmail.DataSource = null;
            }
        }
        /// <summary>
        /// Método para atualizar o grid de telefones
        /// </summary>
        /// <param name="pSort">Coluna base para ordenação</param>
        /// <param name="posicao">posição da seleção no grid</param>
        public void CarregaGridTelefone(string pSort, int posicao)
        {
            var tel = from t in objPessoa.Telefones
                      where t.bPrincipal == 0
                      select new
                      {
                          Numero = t.Numero,
                          Tipo = t.Tipo,
                          Contato = t.Contato,
                          Sequencia = t.Sequencia,
                          ID = t.ID
                      };

            gcTelefones.DataSource = tel.ToList();

            gvTelefones.BestFitColumns();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvTelefones.SortInfo.Clear();
            gvTelefones.SortInfo.ClearSorting();
            gvTelefones.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvTelefones.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvTelefones.RowCount - 1)
                {
                    posicao = gvTelefones.RowCount - 1;
                }
                gvTelefones.SelectRow(posicao);
                gvTelefones.FocusedRowHandle = posicao;
            }
            else
            {
                gvTelefones.ClearSelection();
                gvTelefones.SelectRow(0);
                gvTelefones.FocusedRowHandle = 0;
            }
        }

        public void CarregaGridAviso(string pSort, int posicao)
        {
            var av = (from a in objPessoa.PessoaAvisos
                      select a);
            gcAvisos.DataSource = av.ToList();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvAvisos.SortInfo.Clear();
            gvAvisos.SortInfo.ClearSorting();
            gvAvisos.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvAvisos.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvAvisos.RowCount - 1)
                {
                    posicao = gvAvisos.RowCount - 1;
                }
                gvAvisos.SelectRow(posicao);
                gvAvisos.FocusedRowHandle = posicao;
            }
            else
            {
                gvAvisos.ClearSelection();
                gvAvisos.SelectRow(0);
                gvAvisos.FocusedRowHandle = 0;
            }
        }

        /// <summary>
        /// Método para carregar na tela os dados de cliente.
        /// </summary>
        public void CarregaDadosCliente()
        {
            objPessoaCliente = objPessoa.Clientes.Where(e => e.IDPessoa == objPessoa.ID).Single();

            if (objPessoaCliente.bContribuinte.Value == 1)
            {
                chbContribuinte.Checked = true;
            }
            if (objPessoaCliente.bBloqueiaCondicao.Value == 1)
            {
                chbBloquearCondicao.Checked = true;
            }
            if (objPessoaCliente.bBloqueiaTabelaPreco.Value == 1)
            {
                chbBloquearTabPreco.Checked = true;
            }
            if (objPessoaCliente.IDCondicao.HasValue)
                cbCondicao.EditValue = objPessoaCliente.IDCondicao;
            if (objPessoaCliente.IDTabelaPreco.HasValue)
                cbTabPreco.EditValue = objPessoaCliente.IDTabelaPreco;
            if (objPessoaCliente.IDVendedor.HasValue)
                cbVendedor.EditValue = objPessoaCliente.IDVendedor;
            txtNomeConj.Text = objPessoaCliente.NomeConjuge;
            txtNomeMae.Text = objPessoaCliente.NomeMae;
            txtNomePai.Text = objPessoaCliente.NomePai;
            txtLimite.Text = objPessoaCliente.LimiteCredito.ToString();
            if (objPessoaCliente.bContribuinte.Value == 1)
            {
                chbContribuinte.Checked = true;
            }
        }

        public void CarregaDadosFuncionario()
        {
            objPessoaFuncionario = objPessoa.Funcionarios.Where(p => p.IDPessoa == objPessoa.ID).Single();
            txtCarteiraDeTrabalho.Text = objPessoaFuncionario.NumCarteiraTrab;
        }

        public void CarregaDadosVendedor()
        {
            objPessoaVendedor = (from vend in db.Vendedors
                                 where vend.IDPessoa == objPessoa.ID
                                 select vend).Single();
            txtComissao.Value = objPessoaVendedor.ComissaoVendedor.Value;
            txtSenha.EditValue = objPessoaVendedor.Senha;
            ListaComissao = null;
        }

        /// <summary>
        /// Método que chama o grid para selecionar um elemento
        /// </summary>
        /// <param name="ptitulo">Título do grid</param>
        /// <param name="pCb">combobox que irá chamar o grid</param>
        /// <param name="gl">objeto que irá retornar a lista para preencher o combo</param>
        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        /// <summary>
        /// Método que valida todos os controles de um conjunto de controles
        /// </summary>
        /// <param name="bControls">conjunto de controles</param>
        public void validaTudo(Control.ControlCollection bControls)
        {
            string bErrorText = "";
            foreach (Control ctrl in bControls)
            {
                ctrl.Refresh();
                if ((ctrl is GroupBox) || (ctrl is TabControl) || (ctrl is TabPage))
                {
                    validaTudo(ctrl.Controls);
                }
                else
                {
                    if (errorProvider1.GetError(ctrl) != "")
                    {
                        bErrorText = errorProvider1.GetError(ctrl);
                        ctrl.Focus();
                        throw new Exception(bErrorText);
                    }
                }
            }
        }

        #endregion

        #region Validações

        public bool validateCbTipoPessoa()
        {
            bool bStatus = true;
            if (cbTipo.Properties.Items.Contains(cbTipo.Text))
            {
                errorProvider1.SetError(cbTipo, "");
            }
            else
            {
                errorProvider1.SetError(cbTipo, "Selecione um tipo da lista.");
                bStatus = false;
            }
            return bStatus;
        }

        public bool validateTxtNome()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Preencha o nome.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(txtNome, "");
            }
            return bStatus;
        }

        public bool validateCbSexo()
        {
            bool bStatus = true;
            if (cbSexo.Properties.Items.Contains(cbSexo.Text))
            {
                errorProvider1.SetError(cbSexo, "");
            }
            else
            {
                errorProvider1.SetError(cbSexo, "Selecione o sexo.");
                bStatus = false;
            }
            return bStatus;
        }

        public bool validateCbEstadoCivil()
        {
            bool bStatus = true;
            if (cbEstadoCivil.Properties.Items.Contains(cbEstadoCivil.Text))
            {
                errorProvider1.SetError(cbEstadoCivil, "");
            }
            else
            {
                errorProvider1.SetError(cbEstadoCivil, "Selecione um estado civil da lista.");
                bStatus = false;
            }
            return bStatus;
        }

        public bool validateTxtLimite()
        {
            bool bStatus = true;
            if (Modelo.MetodosEstaticos.ValidaDecimal(txtLimite.Text))
            {
                errorProvider1.SetError(txtLimite, "");
            }
            else
            {
                errorProvider1.SetError(txtLimite, "Valor incorreto.");
                bStatus = false;
            }
            return bStatus;
        }

        #endregion

        #region Eventos Validating

        private void cbTipo_Validating(object sender, CancelEventArgs e)
        {
            validateCbTipoPessoa();
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            validateTxtNome();
        }

        private void cbSexo_Validating(object sender, CancelEventArgs e)
        {
            validateCbSexo();
        }

        private void cbEstadoCivil_Validating(object sender, CancelEventArgs e)
        {
            validateCbEstadoCivil();
        }

        private void txtLimiteCred_Validating(object sender, CancelEventArgs e)
        {
            validateTxtLimite();
        }

        #endregion

        #region Add Buttons

        private void btAdCidade_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Cidade CidadeSelecionada = null;
            int id = (int)cbCidade.EditValue;
            if (id > 0)
                CidadeSelecionada = cwkGestao.Negocio.CidadeController.Instancia.LoadObjectById(id);
            GridGenerica<cwkGestao.Modelo.Cidade> grid = new GridGenerica<cwkGestao.Modelo.Cidade>(cwkGestao.Negocio.CidadeController.Instancia.GetAll(), new FormCidade(), CidadeSelecionada, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    cbCidade.Properties.DataSource = objCidade.getListaCombo(db);
                    cbCidade.EditValue = grid.Selecionado.ID;
                }
            }
        }

        private void btAdClassificacao_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Classificacao classificacaoSelecionada = null;
            int id = (int)cbClassificacao.EditValue;
            if (id > 0)
                classificacaoSelecionada = cwkGestao.Negocio.ClassificacaoController.Instancia.LoadObjectById(id);
            GridGenerica<cwkGestao.Modelo.Classificacao> grid = new GridGenerica<cwkGestao.Modelo.Classificacao>(cwkGestao.Negocio.ClassificacaoController.Instancia.GetAll(), new FormClassificacao(), classificacaoSelecionada, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    cbClassificacao.Properties.DataSource = objClass.getListaCombo(db);
                    cbClassificacao.EditValue = grid.Selecionado.ID;
                }
            }
        }

        private void btAdFilial_Click(object sender, EventArgs e)
        {
            LookupUtil.GridComboLookup(cbFilial, new FormFilial());
            cbFilial.Properties.DataSource = objFilial.getListaCombo(db);
        }

        private void btAdCondicao_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Condicao condicaoSelecionado = null;
            if ((int)cbCondicao.EditValue > 0)
                condicaoSelecionado = cwkGestao.Negocio.CondicaoController.Instancia.LoadObjectById((int)cbCondicao.EditValue);

            GridGenerica<cwkGestao.Modelo.Condicao> grid = new GridGenerica<cwkGestao.Modelo.Condicao>(cwkGestao.Negocio.CondicaoController.Instancia.GetAll(), new FormCondicao(), condicaoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    cbCondicao.EditValue = grid.Selecionado.ID;
                    cbCondicao.Properties.DataSource = objCondicao.getListaCombo(db);
                }
            }
            cbCondicao.Focus();
        }

        private void btAdTabPreco_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.TabelaPreco tabelaPrecoSelecionado = null;
            if ((int)cbTabPreco.EditValue > 0)
                tabelaPrecoSelecionado = cwkGestao.Negocio.TabelaPrecoController.Instancia.LoadObjectById((int)cbTabPreco.EditValue);

            GridGenerica<cwkGestao.Modelo.TabelaPreco> grid = new GridGenerica<cwkGestao.Modelo.TabelaPreco>(cwkGestao.Negocio.TabelaPrecoController.Instancia.GetAll(), new FormTabelaPreco(), tabelaPrecoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    cbTabPreco.EditValue = grid.Selecionado.ID;
                    cbTabPreco.Properties.DataSource = objTabPreco.getListaCombo(db);
                }
            }
            cbTabPreco.Focus();
        }

        private void btAdVendedor_Click(object sender, EventArgs e)
        {
            GridSelecao("Tabela de Vendedor", cbVendedor, objVendedor);
        }

        #endregion

        #region Outros Eventos

        private void FormManutPes_KeyDown(object sender, KeyEventArgs e)
        {
            //    switch (e.KeyCode)
            //    {
            //        case Keys.F9:
            //            if (acao != 4)
            //            {
            //                btGravar_Click(sender, e);
            //            }
            //            break;
            //        case Keys.Escape:
            //            btCancelar_Click(sender, e);
            //            break;
            //    }

        }

        private void FormManutPes_Load(object sender, EventArgs e)
        {
            if (acao == 1)
            {
                cbTipo.SelectedIndex = 0;
                DesabilitaCampos(0);
            }

            if (chbEntrega.Checked)
            {
                txtTelEntrega.Enabled = true;
                txtContato.Enabled = true;
            }
            else
            {
                txtTelEntrega.Enabled = false;
                txtContato.Enabled = false;
            }
        }

        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCliente.Checked)
            {
                TabControl1.TabPages.Insert(TabControl1.TabPages.Count, tabCliente);
                if (objPessoa.Clientes.Count == 1)
                {
                    CarregaDadosCliente();
                }
                else
                {
                    cbCondicao.EditValue = 0;
                    cbTabPreco.EditValue = 0;
                    cbVendedor.EditValue = 0;
                }
            }
            else
            {
                TabControl1.TabPages.Remove(tabCliente);
                errorProvider1.SetError(txtLimite, "");
                errorProvider1.SetError(cbVendedor, "");
                errorProvider1.SetError(cbTabPreco, "");
                errorProvider1.SetError(cbCondicao, "");
            }
        }

        private void chbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFuncionario.Checked)
            {
                TabControl1.TabPages.Insert(TabControl1.TabPages.Count, tabFuncionario);
                if (objPessoa.Funcionarios.Count == 1)
                {
                    CarregaDadosFuncionario();
                }
            }
            else
            {
                TabControl1.TabPages.Remove(tabFuncionario);
                errorProvider1.SetError(txtCarteiraDeTrabalho, "");
            }
        }

        private void chbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVendedor.Checked)
            {
                TabControl1.TabPages.Insert(TabControl1.TabPages.Count, tabVendedor);
                TabControl1.TabPages.Insert(TabControl1.TabPages.Count, tabComissao);
                int count = db.Vendedors.Where(v => v.IDPessoa == objPessoa.ID).Count();
                if (count == 1)
                {
                    CarregaDadosVendedor();
                }
                else
                {
                    objPessoaVendedor = new Vendedor();
                    objPessoaVendedor.Pessoa = objPessoa;
                }
                CarregaGridComissao();
            }
            else
            {
                TabControl1.TabPages.Remove(tabVendedor);
                TabControl1.TabPages.Remove(tabComissao);
                errorProvider1.SetError(txtComissao, "");
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Física")
            {
                DesabilitaCampos(0);
            }
            else
            {
                if (cbTipo.Text == "Jurídica")
                {
                    DesabilitaCampos(1);
                }
            }

        }

        private void chbEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEntrega.Checked)
            {
                txtTelEntrega.Enabled = true;
                txtContato.Enabled = true;
            }
            else
            {
                txtTelEntrega.Enabled = false;
                txtContato.Enabled = false;
            }
        }

        #endregion

        #region Eventos GridAvisos

        private void btIncluirAviso_Click(object sender, EventArgs e)
        {
            CarregaManut(1, 0, 3);
        }

        private void btAlterarAviso_Click(object sender, EventArgs e)
        {
            CarregaManut(2, AvisoSelecionado(), 3);
        }

        private void btExcluirAviso_Click(object sender, EventArgs e)
        {
            CarregaManut(3, AvisoSelecionado(), 3);
        }

        private void btConsultarAviso_Click(object sender, EventArgs e)
        {
            CarregaManut(4, AvisoSelecionado(), 3);
        }

        private void gcAviso_DoubleClick(object sender, EventArgs e)
        {
            CarregaManut(2, AvisoSelecionado(), 3);
        }

        private void gcAviso_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CarregaManut(2, AvisoSelecionado(), 3);
                    break;
            }
        }

        #endregion

        #region Eventos GridEndereços
        private void btIncluirEnd_Click(object sender, EventArgs e)
        {
            CarregaManut(1, 0, 1);
        }

        private void btAlterarEnd_Click(object sender, EventArgs e)
        {
            CarregaManut(2, EnderecoSelecionado(), 1);
        }

        private void btExcluirEnd_Click(object sender, EventArgs e)
        {
            CarregaManut(3, EnderecoSelecionado(), 1);
        }

        private void btConsultarEnd_Click(object sender, EventArgs e)
        {
            CarregaManut(4, EnderecoSelecionado(), 1);
        }

        private void gcEnderecos_DoubleClick(object sender, EventArgs e)
        {
            CarregaManut(2, EnderecoSelecionado(), 1);
        }

        private void gcEnderecos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CarregaManut(2, EnderecoSelecionado(), 1);
                    break;
            }
        }

        #endregion

        #region Eventos GridTelefones
        private void IncluirTel_Click(object sender, EventArgs e)
        {
            CarregaManut(1, 0, 2);
        }

        private void AlterarTel_Click(object sender, EventArgs e)
        {
            CarregaManut(2, TelefoneSelecionado(), 2);
        }

        private void ExcluirTel_Click(object sender, EventArgs e)
        {
            CarregaManut(3, TelefoneSelecionado(), 2);
        }

        private void ConsultarTel_Click(object sender, EventArgs e)
        {
            CarregaManut(4, TelefoneSelecionado(), 2);
        }

        private void gcTelefones_DoubleClick(object sender, EventArgs e)
        {
            CarregaManut(2, TelefoneSelecionado(), 2);
        }

        private void gcTelefones_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CarregaManut(2, TelefoneSelecionado(), 2);
                    break;
            }
        }

        #endregion

        private void cbCidade_Leave(object sender, EventArgs e)
        {
            if ((int)cbCidade.EditValue > 0)
            {
                objCidade = (Modelo.Cidade)objCidade.getObjeto(db, (int)cbCidade.EditValue);
                if (objCidade.IBGE == "9999999")
                {
                    if (cbTipo.Text == "Física")
                    {
                        txtCPF.Enabled = false;
                    }
                    else
                    {
                        if (cbTipo.Text == "Jurídica")
                        {
                            txtCNPJ.Enabled = false;
                        }
                    }
                }
                else
                {
                    if (cbTipo.Text == "Física")
                    {
                        DesabilitaCampos(0);
                    }
                    else
                    {
                        if (cbTipo.Text == "Jurídica")
                        {
                            DesabilitaCampos(1);
                        }
                    }
                }
            }
        }

        private void sbIncluirEmail_Click(object sender, EventArgs e)
        {
            FormManutEmail form = new FormManutEmail(ListaEmail, "", 1);
            form.ShowDialog();
            ListaEmail = form.ListaEmail;
            CarregaGridEmail("Descricao", 0);
        }

        private void sbExcluirEmail_Click(object sender, EventArgs e)
        {
            if (EmailSelecionado() != "Nenhum Registro Selecionado.")
            {
                FormManutEmail form = new FormManutEmail(ListaEmail, EmailSelecionado(), 3);
                form.ShowDialog();
                ListaEmail = form.ListaEmail;
                CarregaGridEmail("Descricao", 0);
            }
        }

        private string EmailSelecionado()
        {
            try
            {
                if (gvEmail.GetFocusedRowCellValue("Descricao") != null)
                    return gvEmail.GetFocusedRowCellValue("Descricao").ToString();
                else
                    throw new Exception("Nenhum Registro Selecionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ex.Message;
            }
        }

        private Modelo.Objeto.pxyProdutoVendedorComissao ComissaoSelecionada()
        {
            if (gvComissoes.GetFocusedRow() != null)
                return (Modelo.Objeto.pxyProdutoVendedorComissao)gvComissoes.GetFocusedRow();
            else
                return null;
            //if (gvComissoes.GetFocusedRow() != null)
            //    return Convert.ToInt32(gvComissoes.GetFocusedRowCellValue("ID").ToString());
            //else
            //    return -1;


        }

        private void sbAlterarEmail_Click(object sender, EventArgs e)
        {
            if (EmailSelecionado() != "Nenhum Registro Selecionado.")
            {
                FormManutEmail form = new FormManutEmail(ListaEmail, EmailSelecionado(), 2);
                form.ShowDialog();
                ListaEmail = form.ListaEmail;
                CarregaGridEmail("Descricao", 0);
            }
        }

        private void sbConsultarEmail_Click(object sender, EventArgs e)
        {
            if (EmailSelecionado() != "Nenhum Registro Selecionado.")
            {
                FormManutEmail form = new FormManutEmail(ListaEmail, EmailSelecionado(), 0);
                form.ShowDialog();
            }
        }

        private void gcEmail_DoubleClick(object sender, EventArgs e)
        {
            if (EmailSelecionado() != "Nenhum Registro Selecionado.")
            {
                FormManutEmail form = new FormManutEmail(ListaEmail, EmailSelecionado(), 2);
                form.ShowDialog();
                ListaEmail = form.ListaEmail;
                CarregaGridEmail("Descricao", 0);
            }
        }

        private void sbIncluirComissao_Click(object sender, EventArgs e)
        {
            FormManutProdutoVendedorComissao form = new FormManutProdutoVendedorComissao(objPessoaVendedor, db, txtNome.Text);
            form.ShowDialog();
            if (form.confirma)
            {
                ListaComissao.Add(new Modelo.Objeto.pxyProdutoVendedorComissao()
                {
                    Comissao = form.produtoVendedorComissao.ComissaoPct,
                    Descricao = form.produto.Nome,
                    ID = form.produtoVendedorComissao.ID,
                    IDProduto = form.produtoVendedorComissao.IDProduto,
                    IDVendedor = form.produtoVendedorComissao.IDVendedor
                });
            }
            CarregaGridComissao();
        }

        private void sbExcluirComissao_Click(object sender, EventArgs e)
        {

            if (ComissaoSelecionada() != null)
            {
                ProdutoVendedorComissao pvc;
                if (ComissaoSelecionada().ID > 0)
                    pvc = (ProdutoVendedorComissao)bllProdutoVendedorComissao.getObjeto(ComissaoSelecionada().ID);
                else
                    pvc = new ProdutoVendedorComissao()
                    {
                        ComissaoPct = ComissaoSelecionada().Comissao,
                        IDProduto = ComissaoSelecionada().IDProduto,
                        IDVendedor = ComissaoSelecionada().IDVendedor
                    };
                int selectedRow = gvComissoes.GetSelectedRows()[0];
                FormManutProdutoVendedorComissao form = new FormManutProdutoVendedorComissao(objPessoaVendedor, pvc, db, 3, txtNome.Text);
                form.ShowDialog();
                if (form.confirma)
                {
                    ListaComissao.RemoveAt(selectedRow);
                    if (pvc.ID > 0)
                        db.ProdutoVendedorComissaos.DeleteOnSubmit(pvc);
                    CarregaGridComissao();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void sbConsultarComissao_Click(object sender, EventArgs e)
        {
            if (ComissaoSelecionada() != null)
            {
                ProdutoVendedorComissao pvc;
                if (ComissaoSelecionada().ID > 0)
                    pvc = (ProdutoVendedorComissao)bllProdutoVendedorComissao.getObjeto(ComissaoSelecionada().ID);
                else
                    pvc = new ProdutoVendedorComissao()
                    {
                        ComissaoPct = ComissaoSelecionada().Comissao,
                        IDProduto = ComissaoSelecionada().IDProduto,
                        IDVendedor = ComissaoSelecionada().IDVendedor,
                    };
                FormManutProdutoVendedorComissao form = new FormManutProdutoVendedorComissao(objPessoaVendedor, pvc, db, 0, txtNome.Text);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void sbAlterarComissao_Click(object sender, EventArgs e)
        {
            if (ComissaoSelecionada() != null)
            {
                ProdutoVendedorComissao pvc;
                if (ComissaoSelecionada().ID > 0)
                    pvc = (ProdutoVendedorComissao)bllProdutoVendedorComissao.getObjeto(ComissaoSelecionada().ID);
                else
                    pvc = new ProdutoVendedorComissao()
                    {
                        ComissaoPct = ComissaoSelecionada().Comissao,
                        IDProduto = ComissaoSelecionada().IDProduto,
                        IDVendedor = ComissaoSelecionada().IDVendedor,
                    };
                int selectedIndex = gvComissoes.GetSelectedRows()[0];
                FormManutProdutoVendedorComissao form = new FormManutProdutoVendedorComissao(objPessoaVendedor, pvc, db, 2, txtNome.Text);
                form.ShowDialog();
                if (form.confirma)
                {
                    ListaComissao[selectedIndex].Comissao = form.produtoVendedorComissao.ComissaoPct;
                    ListaComissao[selectedIndex].Descricao = form.produto.Nome;
                    ListaComissao[selectedIndex].IDProduto = form.produto.ID;
                    ListaComissao[selectedIndex].TipoComissao = form.produtoVendedorComissao.TipoComissao;

                    CarregaGridComissao();
                }

            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void gcComissoes_DoubleClick(object sender, EventArgs e)
        {
            sbAlterarComissao_Click(null, null);
        }



        private void txtComissao_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtComissao.EditValue) > 100)
            {
                txtComissao.EditValue = 100.00;
            }
        }





        #region IFormManut<Pessoa> Members

        cwkGestao.Modelo.Pessoa Aplicacao.Interfaces.IFormManut<cwkGestao.Modelo.Pessoa>.Selecionado
        {
            get
            {
                return Selecionado;
            }
            set
            {
                Selecionado = value;
                if (value.ID > 0)
                {
                    FazTudo(2, value.ID, value.BCliente, value.BFuncionario, value.BVendedor, value.BFornecedor);
                }
                else if (value.ID == 0)
                {
                    FazTudo(2, value.ID, true, false, false, false);
                }
                else
                {
                    FazTudo(1, 0, true, false, false, false);
                }
            }
        }

        cwkGestao.Modelo.Acao Aplicacao.Interfaces.IFormManut<cwkGestao.Modelo.Pessoa>.Operacao
        {
            get
            {
                return Acao;
            }
            set
            {
                Acao = value;
                SetModoBotoes(value);
                int op = 0;
                switch (value)
                {
                    case cwkGestao.Modelo.Acao.Incluir:
                        SetEnabledInAllControls(this, true);
                        ClearTextInAllControls(this);
                        op = 1;
                        break;
                    case cwkGestao.Modelo.Acao.Alterar:
                        SetEnabledInAllControls(this, true);
                        op = 2;
                        break;
                    case cwkGestao.Modelo.Acao.Excluir:
                        SetEnabledInAllControls(this, false);
                        op = 3;
                        break;
                    case cwkGestao.Modelo.Acao.Consultar:
                        SetEnabledInAllControls(this, false);
                        op = 4;
                        break;
                }
                acao = op;
                if (Selecionado.ID > 0)
                {
                    FazTudo(op, Selecionado.ID, Selecionado.BCliente, Selecionado.BFuncionario, Selecionado.BVendedor, Selecionado.BFornecedor);
                }
                else if (Selecionado.ID == 0)
                {
                    FazTudo(op, Selecionado.ID, true, false, false, false);
                }
                else
                {
                    FazTudo(op, 0, true, false, false, false);
                }
            }
        }

        #endregion

        private void SetEnabledInAllControls(Control pai, bool enabled)
        {
            foreach (Control item in pai.Controls)
            {
                if (item.GetType().IsSubclassOf(typeof(DevExpress.XtraEditors.BaseEdit)))
                {
                    item.Enabled = enabled;
                }
                if (item.HasChildren)
                    SetEnabledInAllControls(item, enabled);
            }
        }

        private void ClearTextInAllControls(Control pai)
        {
            foreach (Control item in pai.Controls)
            {
                if (item.GetType().Equals(typeof(DevExpress.XtraEditors.TextEdit)))
                {
                    item.GetType().GetProperty("Text").SetValue(item, "", null);
                }
                else if (item.GetType().Equals(typeof(DevExpress.XtraEditors.DateEdit)))
                {
                    item.GetType().GetProperty("DateTime").SetValue(item, null, null);
                }
                else if (item.GetType().Equals(typeof(DevExpress.XtraEditors.ComboBoxEdit)))
                {
                    item.GetType().GetProperty("SelectedIndex").SetValue(item,0, null);
                }
                else if (item.HasChildren)
                    ClearTextInAllControls(item);
            }
        }

        private void SetModoBotoes(cwkGestao.Modelo.Acao acao)
        {
            btGravar.Text = "Gravar";
            switch (acao)
            {
                case cwkGestao.Modelo.Acao.Alterar:
                    btGravar.Visible = btGravar.Enabled = true;
                    break;
                case cwkGestao.Modelo.Acao.Consultar:
                    btGravar.Visible = btGravar.Enabled = false;
                    break;
                case cwkGestao.Modelo.Acao.Excluir:
                    btGravar.Text = "Excluir";
                    btGravar.Visible = btGravar.Enabled = true;
                    break;
                case cwkGestao.Modelo.Acao.Incluir:
                    btGravar.Visible = btGravar.Enabled = true;
                    break;

            }
        }
    }
}
