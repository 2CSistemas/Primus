using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Integracao;

namespace Aplicacao.Modulos.SisECommerceConfiguracaoNMS
{
    public partial class FormSisECommerceConfiguracao : Aplicacao.IntermediariasTela.FormManutSisECommerceConfiguracaoIntermediaria
    {
        public int idConfig = 0;
        public FormSisECommerceConfiguracao()
        {
            this.Text = "Alterando registro de Configuração Sis E-commerce";
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkpFilial.Exemplo = new cwkGestao.Modelo.Filial();
            //lkbFilial.SubForm = new FormFilial();
            lkbFilial.SubFormType = typeof(FormFilial);
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();

            lkpTabelaPreco.Exemplo = new cwkGestao.Modelo.TabelaPreco();
            lkpTabelaPreco.Sessao = cwkGestao.Negocio.TabelaPrecoController.Instancia.getSession();

            lkpCondicao.Exemplo = new cwkGestao.Modelo.Condicao();
            lkpCondicao.Sessao = cwkGestao.Negocio.CondicaoController.Instancia.getSession();

            lkpVendedor.Exemplo = new cwkGestao.Modelo.Pessoa();
            lkpVendedor.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();

            lkpTipoOrcamento.Exemplo = new cwkGestao.Modelo.TipoPedido();
            lkpTipoOrcamento.Sessao = cwkGestao.Negocio.TipoPedidoController.Instancia.getSession();
        }
#region CarregaLKPs

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Filial> grid = new GridGenerica<cwkGestao.Modelo.Filial>(FilialController.Instancia.GetAll(), new FormFilial(),
                (Filial)lkpFilial.Selecionado, false);
                grid.Selecionando = true;
                grid.ShowDialog();
                lkpFilial.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: ", ex);
            }
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Condicao> grid = new GridGenerica<Condicao>(CondicaoController.Instancia.GetAll(), new FormCondicao(),
                (Condicao)lkpCondicao.Selecionado, false);
                grid.Selecionando = true;
                grid.ShowDialog();
                lkpCondicao.Localizar(grid.Selecionado.ID);
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetAllVendedores(), new FormPessoa(),
                (Pessoa)lkpVendedor.Selecionado, false);
                grid.Selecionando = true;
                grid.Text = "Tabela de Vendedores";
                grid.ShowDialog();
                lkpVendedor.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        private void lkbTipoOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<TipoPedido> grid = new GridGenerica<TipoPedido>(TipoPedidoController.Instancia.GetAll(), new FormTipoPedido(),
                (TipoPedido)lkpTipoOrcamento.Selecionado, false);
                grid.Selecionando = true;
                grid.ShowDialog();
                lkpTipoOrcamento.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        private void lkbTabelaPreco_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<TabelaPreco> grid = new GridGenerica<TabelaPreco>(TabelaPrecoController.Instancia.GetAll(), new FormTabelaPreco(),
                (TabelaPreco)lkpTabelaPreco.Selecionado, false);
                grid.Selecionando = true;
                grid.ShowDialog();
                lkpTabelaPreco.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: ", ex);
            }
        }
#endregion

        private void lkbDiretorioSincronismo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Selecione o Diretório de Sincronismo";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDiretorioSincronismo.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void lkbDiretorioPosSincronismo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Selecione o Diretório de Pós Sincronismo";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDiretorioPosSincronismo.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                bool existeConfiguracao = VerificaExistenciaConfiguracao();
                cwkGestao.Modelo.SisECommerceConfiguracao obj = new cwkGestao.Modelo.SisECommerceConfiguracao();
                if (existeConfiguracao == false)
                {
                    CarregarObjeto(obj);
                    SisECommerceConfiguracaoController.Instancia.Salvar(obj, Acao.Incluir);
                }
                else
                {
                    MercadoLivreConfiguracao mercadoLivreConfiguracao = MercadoLivreConfiguracaoController.Instancia.GetAll()[0];
                    CarregarObjeto(obj);
                    obj.ID = idConfig;
                    SisECommerceConfiguracaoController.Instancia.Salvar(obj, Acao.Alterar);
                }
                this.Close();
            }
        }

        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();
            if (txtDiretorioSincronismo.Text == null)
                dxErroProvider.SetError(txtDiretorioSincronismo, "Campo obrigatório");
            if (txtDiretorioPosSincronismo.Text == null)
                dxErroProvider.SetError(txtDiretorioPosSincronismo, "Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        private bool VerificaExistenciaConfiguracao()
        {
            var config = SisECommerceConfiguracaoController.Instancia.GetAll();
            if (config.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CarregarObjeto(cwkGestao.Modelo.SisECommerceConfiguracao obj)
        {
            obj.Condicao = (cwkGestao.Modelo.Condicao)lkpCondicao.Selecionado;
            obj.Filial = (cwkGestao.Modelo.Filial)lkpFilial.Selecionado;
            obj.Vendedor = (cwkGestao.Modelo.Pessoa)lkpVendedor.Selecionado;
            obj.TabelaPreco = (cwkGestao.Modelo.TabelaPreco)lkpTabelaPreco.Selecionado;
            obj.TipoOrcamento = (cwkGestao.Modelo.TipoPedido)lkpTipoOrcamento.Selecionado;
            obj.DirSincronia = txtDiretorioSincronismo.Text;
            obj.DirPosSincronia = txtDiretorioPosSincronismo.Text;
        }

        private void FormSisECommerceConfiguracao_Load(object sender, EventArgs e)
        {
            bool existeConfiguracao = VerificaExistenciaConfiguracao();
            IList<cwkGestao.Modelo.SisECommerceConfiguracao> sisECommerceConfiguracao = SisECommerceConfiguracaoController.Instancia.GetAll();

            if (existeConfiguracao == true)
            {
                idConfig = sisECommerceConfiguracao[0].ID;
                lkpCondicao.EditValue = CondicaoController.Instancia.LoadObjectById(sisECommerceConfiguracao[0].Condicao.ID);
                lkpFilial.EditValue = FilialController.Instancia.LoadObjectById(sisECommerceConfiguracao[0].Filial.ID);
                lkpVendedor.EditValue = PessoaController.Instancia.LoadObjectById(sisECommerceConfiguracao[0].Vendedor.ID);
                lkpTabelaPreco.EditValue = TabelaPrecoController.Instancia.LoadObjectById(sisECommerceConfiguracao[0].TabelaPreco.ID);
                lkpTipoOrcamento.EditValue = TipoPedidoController.Instancia.LoadObjectById(sisECommerceConfiguracao[0].TipoOrcamento.ID);
                txtDiretorioSincronismo.Text = sisECommerceConfiguracao[0].DirSincronia;
                txtDiretorioPosSincronismo.Text = sisECommerceConfiguracao[0].DirPosSincronia;
            }
        }

        private void btBaixarPedidos_Click(object sender, EventArgs e)
        {
            string retornoErro;
            BConfiguraçãoSisECommerce configuracao = new BConfiguraçãoSisECommerce();
            configuracao.Importar(out retornoErro);

            if (retornoErro != "")
                MessageBox.Show("Os pedidos com estes códigos não foram importados", retornoErro);
        }
    }
}
