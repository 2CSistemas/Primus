using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Modelo;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormManutPedidoEmpresa : Aplicacao.Base.ManutBase
    {
        private cwkGestao.Modelo.CwkPedido objcwkPedido;
        private cwkGestao.Modelo.CwkPedidoEmpresa objcwkPedidoEmpresa;
        private CwkPedidoEmpresaController cwkPedidoEmpresaController = CwkPedidoEmpresaController.Instancia;
        private ClienteRevendaController clienteRevendaController = ClienteRevendaController.Instancia;
        private short tipo;
        private bool carregou;

        public FormManutPedidoEmpresa(cwkGestao.Modelo.CwkPedido pCwkPedido)
        {
            InitializeComponent();
            objcwkPedido = pCwkPedido;
        }

        public override void CarregaObjeto()
        {
            carregou = false;

            CarregaComboMatriz();

            switch (cwAcao)
            {
                case 1:
                    objcwkPedidoEmpresa = new cwkGestao.Modelo.CwkPedidoEmpresa();
                    txtSequencia.EditValue = cwkPedidoEmpresaController.MaxCodigo(objcwkPedido.CwkPedidoEmpresas);
                    cwkPedidoEmpresaController.GerarNumeroSerie(objcwkPedido, objcwkPedidoEmpresa);
                    txtValorProduto.Value = 0;
                    rgTipoServico.SelectedIndex = -1;
                    break;
                default:
                    objcwkPedidoEmpresa = objcwkPedido.CwkPedidoEmpresas.Where(v => v.Seq == cwID).First();
                    if (objcwkPedidoEmpresa.Produto != null)
                    {
                        rgTipoServico.EditValue = 1;
                        cbIdProduto.EditValue = objcwkPedidoEmpresa.IDProduto;
                    }
                    else if (objcwkPedidoEmpresa.Servico != null)
                    {
                        rgTipoServico.EditValue = 2;
                        cbIdServico.EditValue = objcwkPedidoEmpresa.IDServico;
                    }

                    txtSequencia.EditValue = objcwkPedidoEmpresa.Seq;
                    txtValorProduto.Value = objcwkPedidoEmpresa.ValorProduto.HasValue ? objcwkPedidoEmpresa.ValorProduto.Value : 0;
                    txtObservacao.EditValue = objcwkPedidoEmpresa.Observacao;

                    if (objcwkPedidoEmpresa.ClienteRevenda.Principal.Value == false)
                    {
                        cbIdClienterevenda.EditValue = objcwkPedidoEmpresa.ClienteRevenda.Matriz.ID;
                        cbIdClienteRevendaFilial.EditValue = objcwkPedidoEmpresa.ClienteRevenda.ID;
                    }
                    else
                    {
                        cbIdClienterevenda.EditValue = objcwkPedidoEmpresa.ClienteRevenda.ID;
                    }

                    break;
            }
            
            ucLicencaChave2.Sistema = objcwkPedido.Sistema;
            ucLicencaChave2.Versao = objcwkPedido.Versao;
            ucLicencaChave2.Demonstracao = objcwkPedido.BDemonstracao;
            ucLicencaChave2.ArquivoLicencaSerializado = objcwkPedidoEmpresa.ArquivoLicencaSerializado;
            ucLicencaChave2.NumeroSerie = objcwkPedidoEmpresa.NumeroSerie.ToString();
            if (objcwkPedidoEmpresa.ArquivoLicencaSerializado.Length > 0) //Pra não deixar alterar licença gerada
                ucLicencaChave2.EnableCampos(false);

            carregou = true;
        }

        private void CarregaComboMatriz()
        {
            cbIdClienterevenda.Properties.DataSource = (from c in clienteRevendaController.GetAllByPessoa(objcwkPedido.IDPessoa)
                                                        select new
                                                        {
                                                            id = c.ID,
                                                            codigo = c.Codigo,
                                                            nome = c.Nome,
                                                        }).ToList();
        }

        public override Dictionary<string, string> Salvar()
        {
            cwkGestao.Modelo.CwkPedidoEmpresa clone = new cwkGestao.Modelo.CwkPedidoEmpresa();
            CopiaPropriedades(objcwkPedidoEmpresa, clone);
            objcwkPedidoEmpresa.Seq = Convert.ToInt32(txtSequencia.Value);
            objcwkPedidoEmpresa.Observacao = txtObservacao.Text;
            objcwkPedidoEmpresa.ValorProduto = txtValorProduto.Value;
            objcwkPedidoEmpresa.NumeroSerie = Convert.ToInt32(ucLicencaChave2.NumeroSerie);
            if (rgTipoServico.EditValue != null)
                objcwkPedidoEmpresa.TipoServico = (int)rgTipoServico.EditValue;
            AtribuiClienteRevenda();

            if (objcwkPedidoEmpresa.TipoServico == 1)
            {
                try
                {
                    objcwkPedidoEmpresa.Servico = null;
                    objcwkPedidoEmpresa.Produto = ProdutoController.Instancia.LoadObjectById((int)cbIdProduto.EditValue);
                }
                catch (NullReferenceException)
                {
                    objcwkPedidoEmpresa.Produto = null;
                }
            }
            else if (objcwkPedidoEmpresa.TipoServico == 2)
            {
                try
                {
                    objcwkPedidoEmpresa.Produto = null;
                    objcwkPedidoEmpresa.Servico = ServicoController.Instancia.LoadObjectById((int)cbIdServico.EditValue);
                }
                catch (NullReferenceException)
                {
                    objcwkPedidoEmpresa.Servico = null;
                }
            }


            switch (cwAcao)
            {
                case 1:
                    objcwkPedidoEmpresa.IncData = DateTime.Now.Date;
                    objcwkPedidoEmpresa.IncHora = DateTime.Now;
                    objcwkPedidoEmpresa.IncUsuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
                case 2:
                    objcwkPedidoEmpresa.AltData = DateTime.Now.Date;
                    objcwkPedidoEmpresa.AltHora = DateTime.Now;
                    objcwkPedidoEmpresa.AltUsuario = Modelo.cwkGlobal.objUsuarioLogado.Login;
                    break;
            }
            if(ucLicencaChave2.Visible)
                objcwkPedidoEmpresa.ArquivoLicencaSerializado = ucLicencaChave2.ArquivoLicencaSerializado;
            Dictionary<string, string> ret = cwkPedidoEmpresaController.Salvar(objcwkPedidoEmpresa, (cwkGestao.Modelo.Acao)cwAcao, objcwkPedido);
            if (ret.Count > 0)
                CopiaPropriedades(clone, objcwkPedidoEmpresa);
            return ret;
        }

        private void AtribuiClienteRevenda()
        {
            if (!String.IsNullOrEmpty(cbIdClienterevenda.Text))
            {
                ClienteRevenda matriz = clienteRevendaController.LoadObjectById((int)cbIdClienterevenda.EditValue);
                if (String.IsNullOrEmpty(cbIdClienteRevendaFilial.Text))
                    objcwkPedidoEmpresa.ClienteRevenda = matriz;
                else
                {
                    objcwkPedidoEmpresa.ClienteRevenda = clienteRevendaController.LoadObjectById((int)cbIdClienteRevendaFilial.EditValue);
                    objcwkPedidoEmpresa.ClienteRevenda.Matriz = matriz;
                }
            }
        }

        private void CopiaPropriedades(cwkGestao.Modelo.CwkPedidoEmpresa origem, cwkGestao.Modelo.CwkPedidoEmpresa destino)
        {
            destino.Seq = origem.Seq;
            destino.Observacao = origem.Observacao;
            destino.ContraSenha = origem.ContraSenha;
            destino.IDClienteRevenda = origem.IDClienteRevenda;
            destino.IDServico = origem.IDServico;
            destino.IDProduto = origem.IDProduto;
            destino.InfMaquina = origem.InfMaquina;
            destino.Quantidade = origem.Quantidade;
            destino.Senha = origem.Senha;
            destino.TipoServico = origem.TipoServico;
            destino.ValorProduto = origem.ValorProduto;
            destino.ArquivoLicencaSerializado = origem.ArquivoLicencaSerializado;
        }

        private void AtualizaComboClienteRevenda()
        {
            if (objcwkPedido.IDPessoa > 0)
            {
                cbIdClienterevenda.Enabled = true;
                sbAdClienterevenda.Enabled = true;
                cbIdClienterevenda.Properties.DataSource = (from c in clienteRevendaController.GetAllByPessoa(objcwkPedido.IDPessoa)
                                                            select new
                                                            {
                                                                id = c.ID,
                                                                codigo = c.Codigo,
                                                                nome = c.Nome,
                                                            }).ToList();
            }
        }

        private void AtualizaComboServico()
        {
            using (Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext())
            {
                Modelo.Servico objServico = new Modelo.Servico();
                cbIdServico.Properties.DataSource = objServico.getListaCombo(dc);
            }
        }

        private void AtualizaComboProduto()
        {
            using (Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext())
            {
                BLL.Produto bllProduto = new BLL.Produto(dc);
                cbIdProduto.Properties.DataSource = bllProduto.getLista();
            }
        }

        private void sbAdClienterevenda_Click(object sender, EventArgs e)
        {
            FormGridClienteRevenda pGp = new FormGridClienteRevenda("Tabela de Cliente da Revenda", objcwkPedido.IDPessoa, null, (int?)cbIdClienterevenda.EditValue, true);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                {
                    cbIdClienterevenda.EditValue = int.Parse(pGp.Retorno);
                    AtualizaComboClienteRevenda();
                    ClienteRevenda clienteRevenda = clienteRevendaController.LoadObjectById((int)cbIdClienterevenda.EditValue);
                    AtualizaComboClienteRevendaFilial(clienteRevenda);
                }
            }
            cbIdClienterevenda.Focus();
        }

        private void sbAdServico_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Servico servicoSelecionado = null;
            if (cbIdServico.EditValue != null && (int)cbIdServico.EditValue > 0)
                servicoSelecionado = cwkGestao.Negocio.ServicoController.Instancia.LoadObjectById((int)cbIdServico.EditValue);

            GridGenerica<cwkGestao.Modelo.Servico> grid = new GridGenerica<cwkGestao.Modelo.Servico>(cwkGestao.Negocio.ServicoController.Instancia.GetAll(), new FormServico(), servicoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    cbIdServico.EditValue = grid.Selecionado.ID;
                    AtualizaComboServico();
                }
            }
            cbIdServico.Focus();
        }

        private void sbProduto_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Produto produtoSelecionado = null;
            if (cbIdProduto.EditValue != null)
                produtoSelecionado = cwkGestao.Negocio.ProdutoController.Instancia.LoadObjectById((int)cbIdProduto.EditValue);
            GridProdutoGen grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), produtoSelecionado, true, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    cbIdProduto.EditValue = grid.Selecionado.ID;
                    AtualizaComboProduto();
                }
            }
            cbIdProduto.Focus();
        }

        private void rgTipoServico_EditValueChanged(object sender, EventArgs e)
        {
            tipo = Convert.ToInt16(rgTipoServico.EditValue);
            if (tipo == 1 || tipo == 2)
            {
                if (tipo == 1)
                {
                    cbIdProduto.Enabled = true;
                    sbProduto.Enabled = true;
                    cbIdServico.EditValue = null;
                    cbIdServico.Enabled = false;
                    sbAdServico.Enabled = false;

                    if (cbIdProduto.Properties.DataSource == null)
                        AtualizaComboProduto();
                    if (carregou)
                        cbIdServico.EditValue = null;
                }
                else
                {
                    cbIdProduto.Enabled = false;
                    sbProduto.Enabled = false;
                    cbIdProduto.EditValue = null;
                    cbIdServico.Enabled = true;
                    sbAdServico.Enabled = true;

                    if (cbIdServico.Properties.DataSource == null)
                        AtualizaComboServico();
                }
            }
        }

        private void cbIdServico_EditValueChanged(object sender, EventArgs e)
        {
            if ((int?)cbIdServico.EditValue != null)
            {
                using (Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext())
                {
                    Modelo.Servico objServico = dc.Servicos.Where(s => s.id == (int)cbIdServico.EditValue).First();
                    txtValorProduto.Value = Convert.ToDecimal(objServico.valor);
                }
            }
        }

        private void cbProduto_EditValueChanged(object sender, EventArgs e)
        {
            if ((int?)cbIdProduto.EditValue != null)
            {
                using (Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext())
                {
                    Modelo.Produto objProduto = dc.Produtos.Where(s => s.ID == (int)cbIdProduto.EditValue).First();
                    txtValorProduto.Value = objProduto.PrecoBase.HasValue ? objProduto.PrecoBase.Value : 0;
                }
            }
        }

        private void cbIdClienterevenda_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)cbIdClienterevenda.EditValue != 0)
            {
                ClienteRevenda clienteRevenda = clienteRevendaController.LoadObjectById((int)cbIdClienterevenda.EditValue);
                if (carregou)
                    AtribuiClienteRevenda();
                if (clienteRevenda.Filiais.Count > 0)
                {
                    cbIdClienteRevendaFilial.Enabled = true;
                    sbAdClienteRevendaFilial.Enabled = true;
                    AtualizaComboClienteRevendaFilial(clienteRevenda);
                }
                else
                {
                    cbIdClienteRevendaFilial.Enabled = false;
                    sbAdClienteRevendaFilial.Enabled = false;
                    cbIdClienteRevendaFilial.Properties.DataSource = null;
                }
            }
        }

        private void AtualizaComboClienteRevendaFilial(ClienteRevenda clienteRevenda)
        {
            cbIdClienteRevendaFilial.Properties.DataSource = (from c in clienteRevenda.Filiais
                                                              select new
                                                              {
                                                                  id = c.ID,
                                                                  codigo = c.Codigo,
                                                                  nome = c.Nome,
                                                              }).ToList();
        }

        private void cbIdClienteRevendaFilial_EditValueChanged(object sender, EventArgs e)
        {
            AtribuiClienteRevenda();
            //if (cbIdClienteRevendaFilial.EditValue != null && (int)cbIdClienteRevendaFilial.EditValue != 0)
            //    objcwkPedidoEmpresa.ClienteRevenda = clienteRevendaController.LoadObjectById((int)cbIdClienteRevendaFilial.EditValue);
        }

        private void sbAdClienteRevendaFilial_Click(object sender, EventArgs e)
        {
            FormGridClienteRevenda pGp = new FormGridClienteRevenda("Tabela de Cliente da Revenda", null, (int?)cbIdClienterevenda.EditValue, (int?)cbIdClienteRevendaFilial.EditValue, true);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                {
                    cbIdClienteRevendaFilial.EditValue = int.Parse(pGp.Retorno);
                    //AtualizaComboClienteRevenda();
                    ClienteRevenda clienteRevenda = clienteRevendaController.LoadObjectById((int)cbIdClienterevenda.EditValue);
                    AtualizaComboClienteRevendaFilial(clienteRevenda);
                    cbIdClienteRevendaFilial.EditValue = pGp.Retorno;

                }
            }
            cbIdClienterevenda.Focus();
        }

        private void rgTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (objcwkPedido.Sistema.Codigo == 6)
                    if (rgTipoServico.SelectedIndex == 1)
                    {
                        ucLicencaChave2.Visible = false;
                        this.Size = new Size(688, 311);
                        objcwkPedidoEmpresa.ArquivoLicencaSerializado = "";
                    }
                    else
                    {
                        ucLicencaChave2.Visible = true;
                        this.Size = new Size(688, 620);

                    }
                this.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
