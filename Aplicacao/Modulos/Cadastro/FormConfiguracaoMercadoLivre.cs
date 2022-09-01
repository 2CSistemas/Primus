using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Aplicacao.Base;
using cwkGestao.Negocio;
using Modelo;
using cwkGestao.Modelo;
using cwkGestao.Integracao.MercadoLivre;
using cwkGestao.Integracao.MercadoLivre.WebService;
using cwkGestao.Integracao.MercadoLivre.Negocio;
using Aplicacao.Modulos.MercadoLivre;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormConfiguracaoMercadoLivre : Base.ManutBase 
    {
        public int idConfig = 0;
        public FormConfiguracaoMercadoLivre()
        {
            InitializeComponent();
            AtribuirExemplos();
            lkpFilial.Focus();
        }

        public void AtribuirExemplos()
        {
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();
            lkpFilial.Exemplo = new cwkGestao.Modelo.Filial();
            lkpFornecedor.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();
            lkpFornecedor.Exemplo = new cwkGestao.Modelo.Pessoa();
            lkpCondicao.Sessao = cwkGestao.Negocio.CondicaoController.Instancia.getSession();
            lkpCondicao.Exemplo = new cwkGestao.Modelo.Condicao();
            lkpLocalEstoque.Sessao = cwkGestao.Negocio.LocalEstoqueController.Instancia.getSession();
            lkpLocalEstoque.Exemplo = new cwkGestao.Modelo.LocalEstoque();
            lkpTabelaPreco.Sessao = cwkGestao.Negocio.TabelaPrecoController.Instancia.getSession();
            lkpTabelaPreco.Exemplo = new cwkGestao.Modelo.TabelaPreco();
            lkpTipoOrcamento.Sessao = cwkGestao.Negocio.TipoPedidoController.Instancia.getSession();
            lkpTipoOrcamento.Exemplo = new cwkGestao.Modelo.TipoPedido();
            lkpVendedor.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();
            lkpVendedor.Exemplo = new cwkGestao.Modelo.Pessoa();
        }

        private void lkbFilial_Click_1(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Filial> grid = new GridGenerica<cwkGestao.Modelo.Filial>(FilialController.Instancia.GetAll(), new FormFilial(),
               (cwkGestao.Modelo.Filial)lkpFilial.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpFilial.EditValue = grid.Selecionado;
        }

        private void lkbTabelaPreco_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.TabelaPreco> grid = new GridGenerica<cwkGestao.Modelo.TabelaPreco>(TabelaPrecoController.Instancia.GetAll(), new FormTabelaPreco(),
                           (cwkGestao.Modelo.TabelaPreco)lkpTabelaPreco.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpTabelaPreco.EditValue = grid.Selecionado;
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Condicao> grid = new GridGenerica<cwkGestao.Modelo.Condicao>(CondicaoController.Instancia.GetAll(), new FormCondicao(),
                              (cwkGestao.Modelo.Condicao)lkpCondicao.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpCondicao.Localizar(grid.Selecionado.ID);
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAll(),
                           (cwkGestao.Modelo.Pessoa)lkpVendedor.Selecionado, null, false, null, null, null, typeof(FormPessoa));
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpVendedor.EditValue = grid.Selecionado;
        }

        private void lkbTipoOrcamento_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.TipoPedido> grid = new GridGenerica<cwkGestao.Modelo.TipoPedido>(TipoPedidoController.Instancia.GetAll(), new FormTipoPedido(),
                           (cwkGestao.Modelo.TipoPedido)lkpTipoOrcamento.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpTipoOrcamento.EditValue = grid.Selecionado;
        }

        private void lkbLocalEstoque_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.LocalEstoque> grid = new GridGenerica<cwkGestao.Modelo.LocalEstoque>(LocalEstoqueController.Instancia.GetAll(), new FormLocalEstoque(),
                           (cwkGestao.Modelo.LocalEstoque)lkpLocalEstoque.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpLocalEstoque.EditValue = grid.Selecionado;
        }

        private void lkbFornecedor_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAll(),
                           (cwkGestao.Modelo.Pessoa)lkpFornecedor.Selecionado, null, false, null, null, null, typeof(FormPessoa));
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpVendedor.EditValue = grid.Selecionado;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                bool existeConfiguracao = VerificaExistenciaConfiguracao();
                MercadoLivreConfiguracao obj = new MercadoLivreConfiguracao();
                if (existeConfiguracao == false)
                {
                    CarregarObjeto(obj);
                    MercadoLivreConfiguracaoController.Instancia.Salvar(obj, Acao.Incluir);
                }
                else
                {
                    MercadoLivreConfiguracao mercadoLivreConfiguracao = MercadoLivreConfiguracaoController.Instancia.GetAll()[0];
                    CarregarObjeto(obj);
                    obj.ID = idConfig;
                    obj.Token = mercadoLivreConfiguracao.Token;
                    obj.RefreshToken = mercadoLivreConfiguracao.RefreshToken;
                    MercadoLivreConfiguracaoController.Instancia.Salvar(obj, Acao.Alterar);
                }
                this.Close(); 
            }
        }

        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();
            if (txtChaveSecreta.EditValue == null)
                dxErroProvider.SetError(txtChaveSecreta, "Campo obrigatório");
            if (txtIdAplicacao.EditValue == null)
                dxErroProvider.SetError(txtIdAplicacao, "Campo obrigatório");
            if (lkpCondicao.Selecionado == null)
                dxErroProvider.SetError(lkpCondicao, "Campo obrigatório");
            if (lkpFilial.Selecionado == null)
                dxErroProvider.SetError(lkpFilial, "Campo obrigatório");
            if (lkpFornecedor.Selecionado == null)
                dxErroProvider.SetError(lkpFornecedor, "Campo obrigatório");
            if (lkpLocalEstoque.Selecionado == null)
                dxErroProvider.SetError(lkpLocalEstoque, "Campo obrigatório");
            if (lkpTabelaPreco.Selecionado == null)
                dxErroProvider.SetError(lkpTabelaPreco, "Campo obrigatório");
            if (lkpTipoOrcamento.Selecionado == null)
                dxErroProvider.SetError(lkpTipoOrcamento, "Campo obrigatório");
            if (lkpVendedor.Selecionado == null)
                dxErroProvider.SetError(lkpVendedor, "Campo obrigatório");
            if (txtUrl.Text == null)
                dxErroProvider.SetError(txtUrl, "Campo obrigatório");
            if (txtTempSinc.Text == null)
                dxErroProvider.SetError(txtTempSinc, "Campo obrigatório");
            if (txtDtInicio.Text == null)
                dxErroProvider.SetError(txtDtInicio, "Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        private void CarregarObjeto(MercadoLivreConfiguracao obj)
        {
            obj.Aplicacao = long.Parse(txtIdAplicacao.Text);
            obj.ChaveSecreta = txtChaveSecreta.Text;
            obj.Condicao = (cwkGestao.Modelo.Condicao)lkpCondicao.Selecionado;
            obj.Filial = (cwkGestao.Modelo.Filial)lkpFilial.Selecionado;
            obj.Fornecedor = (cwkGestao.Modelo.Pessoa)lkpFornecedor.Selecionado;
            obj.Vendedor = (cwkGestao.Modelo.Pessoa)lkpVendedor.Selecionado;
            obj.TabelaPreco = (cwkGestao.Modelo.TabelaPreco)lkpTabelaPreco.Selecionado;
            obj.LocalEstoque = (cwkGestao.Modelo.LocalEstoque)lkpLocalEstoque.Selecionado;
            obj.TipoOrcamento = (cwkGestao.Modelo.TipoPedido)lkpTipoOrcamento.Selecionado;
            obj.URL = txtUrl.Text;
            obj.TempoSinc = Int32.Parse(txtTempSinc.Text)*1000;
            obj.DtInicioImportacao = (DateTime)txtDtInicio.EditValue;
        }

        private bool VerificaExistenciaConfiguracao()
        {
            var config = MercadoLivreConfiguracaoController.Instancia.GetAll();
            if (config.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void FormConfiguracaoMercadoLivre_Load(object sender, EventArgs e)
        {
            bool existeConfiguracao = VerificaExistenciaConfiguracao();
            IList<MercadoLivreConfiguracao> mercadoLivreConfiguracao = MercadoLivreConfiguracaoController.Instancia.GetAll();

            if (existeConfiguracao == true)
	        {
                idConfig = mercadoLivreConfiguracao[0].ID;
        		txtIdAplicacao.Text = mercadoLivreConfiguracao[0].Aplicacao.ToString();
                txtChaveSecreta.Text = mercadoLivreConfiguracao[0].ChaveSecreta;
                lkpCondicao.EditValue = CondicaoController.Instancia.LoadObjectById(mercadoLivreConfiguracao[0].Condicao.ID);
                lkpFilial.EditValue = FilialController.Instancia.LoadObjectById(mercadoLivreConfiguracao[0].Filial.ID);
                lkpFornecedor.EditValue = PessoaController.Instancia.LoadObjectById(mercadoLivreConfiguracao[0].Fornecedor.ID);
                lkpVendedor.EditValue = PessoaController.Instancia.LoadObjectById(mercadoLivreConfiguracao[0].Vendedor.ID);
                lkpTabelaPreco.EditValue = TabelaPrecoController.Instancia.LoadObjectById(mercadoLivreConfiguracao[0].TabelaPreco.ID);
                lkpLocalEstoque.EditValue = LocalEstoqueController.Instancia.LoadObjectById(mercadoLivreConfiguracao[0].LocalEstoque.ID);
                lkpTipoOrcamento.EditValue = TipoPedidoController.Instancia.LoadObjectById(mercadoLivreConfiguracao[0].TipoOrcamento.ID);
                txtUrl.Text = mercadoLivreConfiguracao[0].URL;
                txtTempSinc.Text = (mercadoLivreConfiguracao[0].TempoSinc/1000).ToString();
                txtDtInicio.EditValue = mercadoLivreConfiguracao[0].DtInicioImportacao;
	        }
         
        }

        private void btBaixarPedidos_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {         
                var conf = MercadoLivreConfiguracaoController.Instancia.GetAll()[0];
                ImportadorPedidos importar = new ImportadorPedidos();
                CarregarObjeto(conf);
                MercadoLivreConfiguracaoController.Instancia.Salvar(conf, Acao.Alterar);

                if (conf.RefreshToken == null || conf.RefreshToken == "")
                {
                    var form = new FormCarregarToken();
                    form.Show();
                }
                else
                    try
                    {
                        importar.ImportarPedidosMercadoLivre();
                        MessageBox.Show("Pedidos importados com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Error validating grant"))
                        {
                            var form = new FormCarregarToken();
                            form.ShowDialog();
                            try
                            {
                                importar.ImportarPedidosMercadoLivre();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Erro na autenticação com o Mercado Livre. Verifique se o servidor está disponível e tente novamente! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Erro com a sincronização. " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
            }
        }
    }
}