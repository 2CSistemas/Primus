using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao
{
    public partial class FormConsultaEstoquePorProduto : Form
    {
        private Produto Selecionado
        {
            get { return (Produto)lkProduto.Selecionado; }
            set { lkProduto.EditValue = value; }
        }

        public FormConsultaEstoquePorProduto(Produto produto)
        {
            InitializeComponent();
            InicializaLookups();
            Selecionado = produto;
        }

        private void InicializaLookups()
        {
            Object sessao = ProdutoController.Instancia.getSession();
            lkProduto.Sessao = sessao;
            lkProduto.Exemplo = new Produto();
            lkProduto.OnIDChanged += new EventHandler(lkProduto_IDChanged);
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            GridGenerica<Produto> grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll(), (cwkGestao.Modelo.Produto)lkProduto.Selecionado, true, false, typeof(FormProduto));
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkProduto.EditValue = grid.Selecionado;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkProduto_IDChanged(object sender, EventArgs e)
        {
            gridListaEstoque.DataSource = null;
            if (Selecionado != null)
            {
                txtBarraFornecedor.Text = Selecionado.BarraFornecedor;
                txtGrupoEstoque.Text = Selecionado.GrupoEstoque.Nome + " | " + Selecionado.GrupoEstoque.Codigo;
                txtNCM.Text = Selecionado.NCM;
                txtUnidade.Text = Selecionado.Unidade.ToString();
                mInfAdicionais.Text = Selecionado.InfAdicionais;
                txtLocalizacao.Text = Selecionado.Localizacao;
                CarregaDados();
            }
        }

        private void CarregaDados()
        {
            gridListaEstoque.DataSource = ProdutoController.Instancia.GetListaEstoque(Selecionado.ID);
        }

        private void FormConsultaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void sbMovimentos_Click(object sender, EventArgs e)
        {            
            if (Selecionado != null)
            {
                using (var formConsulta = new FormConsultaMovimentosEstoque(Selecionado, null))
                    formConsulta.ShowDialog();
            }
        }
    }
}
