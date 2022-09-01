using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Linq;
using Cwork.Utilitarios.Componentes;

namespace Aplicacao
{
    public partial class FormManutClienteRevenda : Aplicacao.Base.ManutBase
    {
        private Modelo.Cidade objCidade = new Modelo.Cidade();
        private ClienteRevendaController clienteRevendaController = ClienteRevendaController.Instancia;
        private CidadeController cidadeController = CidadeController.Instancia;
        private cwkGestao.Modelo.ClienteRevenda objClienteRevenda;
        private cwkGestao.Modelo.ClienteRevenda clienteRevendaPai;
        private bool Filial = false;
        private int IDPessoa = 0;
        public int? IDCliente { get; set; }

        public FormManutClienteRevenda(int pIDPessoa, cwkGestao.Modelo.ClienteRevenda pClienteRevendaPai)
        {
            InitializeComponent();

            rgTipoEmpresa.EditValue = true;
            rgTipoLicenca.EditValue = 1;

            if (pClienteRevendaPai != null)
            {
                clienteRevendaPai = pClienteRevendaPai;
                Filial = true;
                rgTipoEmpresa.EditValue = false;
                rgTipoLicenca.SelectedIndex = Convert.ToInt16(pClienteRevendaPai.TipoLicenca);
                rgTipoLicenca.Enabled = false;
                rgTipoEmpresa.Enabled = false;

                TabControl1.TabPages.Remove(tabFiliais);
            }
            else
                IDPessoa = pIDPessoa;
            cbCidade.Properties.DataSource = (from c in cidadeController.GetAll()
                                              select new
                                              {
                                                  ID = c.ID,
                                                  Nome = c.Nome,
                                                  Estado = c.UF.Sigla,
                                              }).ToList();
        }

        public void Copia(cwkGestao.Modelo.ClienteRevenda origem, cwkGestao.Modelo.ClienteRevenda destino)
        {
            destino.IdFirebird = origem.IdFirebird;
            destino.Nome = origem.Nome;
            destino.Tipo = origem.Tipo;
            destino.PontoVirtual = origem.PontoVirtual;
            destino.Endereco = origem.Endereco;
            destino.Numero = origem.Numero;
            destino.Bairro = origem.Bairro;
            destino.Complemento = origem.Complemento;
            destino.IDCidade = origem.IDCidade;
            destino.Cep = origem.Cep;
            destino.Cnpj = origem.Cnpj;
            destino.Inscricao = origem.Inscricao;
            destino.Cpf = origem.Cpf;
            destino.Cei = origem.Cei;
            destino.Telefone = origem.Telefone;
            destino.Fax = origem.Fax;
            destino.Celular = origem.Celular;
            destino.Contato = origem.Contato;
            destino.Responsavel = origem.Responsavel;
            destino.Chave = origem.Chave;
            destino.BdAlterado = origem.BdAlterado;
            destino.IdentificacaoHD = origem.IdentificacaoHD;
            destino.Http = origem.Http;
            destino.Email = origem.Email;
            destino.TipoLicenca = origem.TipoLicenca;
            destino.Quantidade = origem.Quantidade;
            destino.Principal = origem.Principal;
            destino.Codigo = origem.Codigo;
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objClienteRevenda = new cwkGestao.Modelo.ClienteRevenda();
                    try { objClienteRevenda.Codigo = clienteRevendaPai.Filiais.Max(c => c.Codigo) + 1; }
                    catch { objClienteRevenda.Codigo = 1; }
                    objClienteRevenda.Filiais = new List<cwkGestao.Modelo.ClienteRevenda>();
                    if (!Filial)
                        objClienteRevenda.IDPessoa = IDPessoa;
                    break;
                default:
                    if (Filial)
                    {
                        objClienteRevenda = clienteRevendaPai.Filiais.Where(l => l.Codigo == cwID).First();
                    }
                    else
                        objClienteRevenda = clienteRevendaController.LoadObjectById(cwID);

                    txtIdFirebird.EditValue = objClienteRevenda.IdFirebird;
                    txtNome.EditValue = objClienteRevenda.Nome;
                    rgTipoEmpresa.EditValue = objClienteRevenda.Tipo;
                    chbBPontoVirtual.Checked = Convert.ToBoolean(objClienteRevenda.PontoVirtual);
                    txtEndereco.EditValue = objClienteRevenda.Endereco;
                    txtNumero.EditValue = objClienteRevenda.Numero;
                    txtBairro.EditValue = objClienteRevenda.Bairro;
                    txtComplemento.EditValue = objClienteRevenda.Complemento;
                    cbCidade.EditValue = objClienteRevenda.IDCidade;
                    txtCep.EditValue = objClienteRevenda.Cep;
                    txtCnpj.EditValue = objClienteRevenda.Cnpj;
                    txtInscricao.EditValue = objClienteRevenda.Inscricao;
                    txtCpf.EditValue = objClienteRevenda.Cpf;
                    txtCei.EditValue = objClienteRevenda.Cei;
                    txtTelefone.EditValue = objClienteRevenda.Telefone;
                    txtFax.EditValue = objClienteRevenda.Fax;
                    txtCelular.EditValue = objClienteRevenda.Celular;
                    txtContato.EditValue = objClienteRevenda.Contato;
                    txtResponsavel.EditValue = objClienteRevenda.Responsavel;
                    txtChave.EditValue = objClienteRevenda.Chave;
                    chbBdAlterado.Checked = Convert.ToBoolean(objClienteRevenda.BdAlterado);
                    txtIdHD.EditValue = objClienteRevenda.IdentificacaoHD;
                    txtHttp.EditValue = objClienteRevenda.Http;
                    txtEmail.EditValue = objClienteRevenda.Email;
                    rgTipoLicenca.SelectedIndex = Convert.ToInt32(objClienteRevenda.TipoLicenca);
                    txtQuantidade.EditValue = objClienteRevenda.Quantidade;

                    AtualizaGridFiliais();
                    break;
            }


            if (cwAcao == 2)
            {
                rgTipoEmpresa.Enabled = false;
            }

            if (cwAcao != 1)
                rgTipoEmpresa.EditValue = Convert.ToBoolean(objClienteRevenda.Principal);
        }

        public override Dictionary<string, string> Salvar()
        {
            cwkGestao.Modelo.ClienteRevenda antes = new cwkGestao.Modelo.ClienteRevenda();
            Copia(objClienteRevenda, antes);

            objClienteRevenda.IDPessoa = IDCliente;
            objClienteRevenda.IdFirebird = Convert.ToInt32(txtIdFirebird.EditValue);
            objClienteRevenda.Nome = txtNome.Text;
            objClienteRevenda.Tipo = Convert.ToBoolean(rgTipoEmpresa.EditValue);
            objClienteRevenda.PontoVirtual = chbBPontoVirtual.Checked;
            objClienteRevenda.Endereco = txtEndereco.Text;
            objClienteRevenda.Numero = txtNumero.Text;
            objClienteRevenda.Bairro = txtBairro.Text;
            objClienteRevenda.Complemento = txtComplemento.Text;
            objClienteRevenda.IDCidade = Convert.ToInt32(cbCidade.EditValue);
            objClienteRevenda.Cep = txtCep.Text;
            objClienteRevenda.Cnpj = txtCnpj.Text;
            objClienteRevenda.Inscricao = txtInscricao.Text;
            objClienteRevenda.Cpf = txtCpf.Text;
            objClienteRevenda.Cei = txtCei.Text;
            objClienteRevenda.Telefone = txtTelefone.Text;
            objClienteRevenda.Fax = txtFax.Text;
            objClienteRevenda.Celular = txtCelular.Text;
            objClienteRevenda.Contato = txtContato.Text;
            objClienteRevenda.Responsavel = txtResponsavel.Text;
            objClienteRevenda.Chave = txtChave.Text;
            objClienteRevenda.BdAlterado = chbBdAlterado.Checked;
            objClienteRevenda.IdentificacaoHD = txtIdHD.Text;
            objClienteRevenda.Http = txtHttp.Text;
            objClienteRevenda.Email = txtEmail.Text;
            objClienteRevenda.TipoLicenca = Convert.ToInt16(rgTipoLicenca.SelectedIndex);
            objClienteRevenda.Quantidade = Convert.ToInt32(txtQuantidade.EditValue);
            objClienteRevenda.Principal = Convert.ToBoolean(rgTipoEmpresa.EditValue);

            switch (cwAcao)
            {
                case 1:
                    objClienteRevenda.Incdata = DateTime.Now;
                    objClienteRevenda.Incusuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
                case 2:
                    objClienteRevenda.Altdata = DateTime.Now;
                    objClienteRevenda.Altusuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
            }

            Dictionary<string, string> ret = new Dictionary<string, string>();
            try
            {
                if (Filial)
                    ret = clienteRevendaController.Salvar(clienteRevendaPai, objClienteRevenda, (cwkGestao.Modelo.Acao)cwAcao);
                else
                    ret = clienteRevendaController.Salvar(objClienteRevenda, (cwkGestao.Modelo.Acao)cwAcao);
            }
            catch (NHibernate.Exceptions.GenericADOException e)
            {
            }
            if (ret.Count > 0)
                Copia(antes, objClienteRevenda);

            return ret;
        }

        private bool ValidacaoCNPJCPF()
        {
            if (!String.IsNullOrEmpty(txtCnpj.Text))
            {
                string erro = "";
                if (!PessoaController.ValidarCNPJ(txtCnpj.Text,out erro))
	            {
            		 dxErroProvider.SetError(txtCnpj, erro);
	            }
            }

            if (!String.IsNullOrEmpty(txtCpf.Text))
            {
                string erro = "";
                if (!PessoaController.ValidarCPF(txtCpf.Text,out erro))
	            {
            		 dxErroProvider.SetError(txtCpf, erro);
	            }
            }
            return !dxErroProvider.HasErrors;
        }

        private void AtualizaGridFiliais()
        {
            if (objClienteRevenda.Principal.HasValue && objClienteRevenda.Principal.Value == false)
            {
                TabControl1.TabPages.Remove(tabFiliais);
            }
            else
            {
                gcFiliais.DataSource = null;
                gcFiliais.DataSource = objClienteRevenda.Filiais;
                gvFiliais.RefreshData();
            }
        }

        private void CarregaFormularioFilial(int pAcao, int pIndice)
        {
            if (pAcao != 1 && pIndice == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
            else
            {
                objClienteRevenda.TipoLicenca = Convert.ToInt16(rgTipoLicenca.EditValue);
                FormManutClienteRevenda form = new FormManutClienteRevenda(objClienteRevenda.IDPessoa.Value, objClienteRevenda);
                form.cwAcao = pAcao;
                form.cwID = pIndice;
                form.cwTabela = "Filial Cliente Revenda";
                form.ShowDialog();

                if (pAcao != 4)
                {
                    AtualizaGridFiliais();
                }
            }
        }

        private Int32 FilialSelecionada()
        {
            Int32 parc;
            try
            {
                parc = (int)gvFiliais.GetFocusedRowCellValue("Codigo");
            }
            catch (Exception)
            {
                parc = 0;
            }
            return parc;
        }

        private void sbConsultarFilial_Click(object sender, EventArgs e)
        {
            CarregaFormularioFilial(4, FilialSelecionada());
        }

        private void sbIncluirFilial_Click(object sender, EventArgs e)
        {
            CarregaFormularioFilial(1, 0);
        }

        private void sbAlterarFilial_Click(object sender, EventArgs e)
        {
            CarregaFormularioFilial(2, FilialSelecionada());
        }

        private void sbExcluirFilial_Click(object sender, EventArgs e)
        {
            CarregaFormularioFilial(3, FilialSelecionada());
        }

        private void gcFiliais_DoubleClick(object sender, EventArgs e)
        {
            if (sbAlterarFilial.Enabled)
                sbAlterarFilial_Click(sender, e);
        }

        private void sbAdCidade_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Cidade CidadeSelecionada = null;

            if (cbCidade.EditValue != null)
            {
                int id = (int)cbCidade.EditValue;
                if (id > 0)
                    CidadeSelecionada = cwkGestao.Negocio.CidadeController.Instancia.LoadObjectById(id);
            }
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
    }
}
