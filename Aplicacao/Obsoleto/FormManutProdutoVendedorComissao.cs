using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormManutProdutoVendedorComissao : Aplicacao.Base.ManutBase
    {
        BLL.ProdutoVendedorComissao bllProdutoVendedorComissao;
        BLL.Produto bllProduto;
        
        Modelo.Vendedor vendedor;
        public Modelo.ProdutoVendedorComissao produtoVendedorComissao { get; set; }
        public Boolean confirma { get; set; }
        public Modelo.Produto produto { get; set; }
        private int operacao { get; set; }
        private Decimal tempCom = 0;

        public FormManutProdutoVendedorComissao()
        {

        }

        public FormManutProdutoVendedorComissao(Modelo.Vendedor vendedor, Modelo.DataClassesDataContext db, string nomePessoa)
        {
            this.db = db;
            this.vendedor = vendedor;
            this.operacao = 1;
            bllProdutoVendedorComissao = new BLL.ProdutoVendedorComissao(db);
            bllProduto = new BLL.Produto(db);

            InitializeComponent();
            CarregaProdutos();
            lblVendedor.Text = nomePessoa;
        }

        public FormManutProdutoVendedorComissao(Modelo.Vendedor vendedor, Modelo.ProdutoVendedorComissao pvc, Modelo.DataClassesDataContext db, int operacao, string nomePessoa)
        {
            this.db = db;
            this.produtoVendedorComissao = pvc;
            this.vendedor = vendedor;
            this.operacao = operacao;
            bllProdutoVendedorComissao = new BLL.ProdutoVendedorComissao(db);
            bllProduto = new BLL.Produto(db);

            InitializeComponent();
            
            AjustaTela();
            CarregaProdutos();
            lblVendedor.Text = nomePessoa;
            CarregaDados();
        }

        private void AjustaTela()
        {
            switch (operacao)
            {
                case 0: // Consulta
                    sbGravar.Visible = false;
                    lkpProduto.Properties.ReadOnly = true;
                    txtComissao.Properties.ReadOnly = true;
                    cbTipoComissao.Properties.ReadOnly = true;
                    break;
                case 3: // Exclusão
                    sbGravar.Text = "Excluir";
                    lkpProduto.Enabled = false;
                    txtComissao.Enabled = false;
                    cbTipoComissao.Enabled = false;
                    break;
                case 1: // Inserção
                case 2: // Alteraçao
                    sbGravar.Text = "Gravar";
                    break;
                
            }
        }

        private void CarregaDados()
        {
            //cbProduto.EditValue = produtoVendedorComissao.IDProduto;
            txtComissao.EditValue = produtoVendedorComissao.ComissaoPct;
            cbTipoComissao.SelectedIndex = produtoVendedorComissao.TipoComissao;
            lkpProduto.ID = produtoVendedorComissao.IDProduto;
            lkpProduto.Localizar(lkpProduto.ID);
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            confirma = true;
            if (lkpProduto.ID == 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }
            //int produtoId = Convert.ToInt32(cbProduto.EditValue);
            int produtoId = lkpProduto.ID;
            produto = (Modelo.Produto)bllProduto.getObjeto(produtoId);
            switch (operacao)
            {
                case 0: //Consulta
                    break;
                case 1: //Inserçao
                    
                    produtoVendedorComissao = new Modelo.ProdutoVendedorComissao()
                    {
                        ComissaoPct = Convert.ToDecimal("0"+txtComissao.EditValue.ToString().Replace(".",",")),
                        IDProduto = produtoId,
                        IDVendedor = vendedor.ID,
                        TipoComissao = Convert.ToByte(cbTipoComissao.SelectedIndex),
                        Produto = new Modelo.Produto() { Nome = produto.Nome, ID = produto.ID }
                        //Vendedor = vendedor

                    };
                    //db.ProdutoVendedorComissaos.InsertOnSubmit(produtoVendedorComissao);
                    break;
                case 2: //Alteraçao
                    produtoVendedorComissao.IDProduto = produtoId;
                    //produtoVendedorComissao.Produto = prod;
                    produtoVendedorComissao.ComissaoPct = Convert.ToDecimal(txtComissao.EditValue.ToString().Replace(".", ","));
                    produtoVendedorComissao.TipoComissao = Convert.ToByte(cbTipoComissao.SelectedIndex);
                    //db.ProdutoVendedorComissaos.InsertOnSubmit(produtoVendedorComissao);
                    //db.ProdutoVendedorComissaos.Attach(produtoVendedorComissao);
                    break;
                case 3: //Deleçao
                    //if(produtoVendedorComissao.ID > 0)
                    //    db.ProdutoVendedorComissaos.DeleteOnSubmit(produtoVendedorComissao);
                    break;
            }

           
            //db.SubmitChanges();
            this.Close();
        }

        protected override void sbCancelar_Click(object sender, EventArgs e)
        {
            confirma = false;
            this.Close();
        }

        private void CarregaProdutos()
        {
            lkpProduto.ContextoLinq = db;
            //cbProduto.Properties.DataSource = bllProduto.getListaCombo();

        }

        private void cbTipoComissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoComissao.SelectedIndex == 0)
            {
                txtComissao.EditValue = tempCom;
                txtComissao.Enabled = true;
            }
            else
            {
                tempCom = Convert.ToDecimal("0" + txtComissao.EditValue.ToString().Replace(".",","));
                txtComissao.EditValue = 100;
                txtComissao.Enabled = false;
            }

        }

        private void txtComissao_Enter(object sender, EventArgs e)
        {
            txtComissao.SelectAll();
        }

        private void txtComissao_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtComissao.EditValue) > 100)
            {
                txtComissao.EditValue = 100;
            }
        }

        private void lkbtnProduto_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Produto produtoSelecionado = null;
            if (lkpProduto.ID > 0)
                produtoSelecionado = cwkGestao.Negocio.ProdutoController.Instancia.LoadObjectById(lkpProduto.ID);
            GridProdutoGen grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll(), produtoSelecionado, true, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkpProduto.ID = grid.Selecionado.ID;
                    lkpProduto.Localizar(lkpProduto.ID);
                }
            }
            
            lkpProduto.Focus();
        }
    }
}
