using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using Cwork.Utilitarios.Componentes;
using DevExpress.XtraEditors;
using Aplicacao.Interfaces;

namespace Aplicacao
{
    public partial class FormHistoricoVenda : Aplicacao.IntermediariasTela.FormManutHistoricoVendaIntermediaria, IFormGrid
    {
        private List<GridProdutosItem> notasFiscais;
        private List<GridProdutosItem> pedidos;
        Pessoa cliente;
        Produto produto;
        private FiltroPor filtroPor;
        private InOutType inOut;
        public enum FiltroPor
        {
            Pessoa, Produto
        }

        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();
        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        public FormHistoricoVenda(Pessoa cliente, Produto produto, InOutType inOut, FiltroPor filtroPor)
        {
            this.cliente = cliente;
            this.produto = produto;
            this.inOut = inOut;
            this.filtroPor = filtroPor;
            this.inOut = inOut;
            ConfiguraTela();

            grids.Add(new TupleIFormGrid { Control = gcNotaFiscal, View = gvNotaFiscal, Tipo = typeof(GridProdutosItem) });
            grids.Add(new TupleIFormGrid { Control = gcOrcamento, View = gvOrcamento, Tipo = typeof(GridProdutosItem) });

            this.CarregarPadraoCorSistema();
        }

        protected override void ConfiguraGrid(DevExpress.XtraGrid.GridControl gridControl)
        {

        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkSuperior.Sessao = lkInferior.Sessao = ProdutoController.Instancia.getSession();

            sbGravar.Visible = false;
            sbCancelar.Text = "Fechar";

            lkInferior.Enabled = false;
            btProduto.Enabled = false;

            ConfiguraTela();
        }

        private void ConfiguraTela()
        {
            if (filtroPor == FiltroPor.Pessoa)
            {
                AtribuiExemploPessoa(lblSuperior, lkSuperior);
                lblInferior.Text = "Produto:";
                lkInferior.Exemplo = new Produto();

                chkFiltraPor.Text = "Filtra histórico por produto";
            }
            else
            {
                lblSuperior.Text = "Produto:";
                lkSuperior.Exemplo = new Produto();
                AtribuiExemploPessoa(lblInferior, lkInferior);

                chkFiltraPor.Text = "Filtra histórico por pessoa".Replace("pessoa", lblInferior.Text.Replace(":", ""));
            }
        }

        private void AtribuiExemploPessoa(LabelControl label, Lookup lkp)
        {
            if (inOut == InOutType.Entrada)
            {
                this.Text = "Histórico de Compra";

                label.Text = "Fornec:";

                lkp.Exemplo = new Pessoa() { BFornecedor = true };
                lkp.CamposRestricoesAND = new List<string> { "bfornecedor" };
            }
            else
            {
                this.Text = "Histórico de Venda";

                label.Text = "Cliente:";

                lkp.Exemplo = new Pessoa() { BCliente = true };
                lkp.CamposRestricoesAND = new List<string> { "bcliente" };
            }
        }


        private void btCarregaHist_Click(object sender, EventArgs e)
        {
            CarregarHistorico();
        }

        private void CarregarHistorico()
        {

            if (ValidarFormulario())
            {
                gvOrcamento.ClearGrouping();
                gvNotaFiscal.ClearGrouping();

                CarregaGrids();

                if (filtroPor == FiltroPor.Pessoa)
                {
                    gvNotaFiscal.Columns["Pessoa"].Visible = false;
                    gvOrcamento.Columns["Pessoa"].Visible = false;

                    if (!chkFiltraPor.Checked)
                    {
                        gvNotaFiscal.Columns["Produto"].Visible = true;
                        gvNotaFiscal.Columns["Produto"].Group();
                        gvOrcamento.Columns["Produto"].Visible = true;
                        gvOrcamento.Columns["Produto"].Group();
                    }
                    else
                    {
                        gvNotaFiscal.Columns["Produto"].Visible = false;
                        gvOrcamento.Columns["Produto"].Visible = false;
                    }
                }
                else
                {
                    gvNotaFiscal.Columns["Produto"].Visible = false;
                    gvOrcamento.Columns["Produto"].Visible = false;

                    if (!chkFiltraPor.Checked)
                    {
                        gvNotaFiscal.Columns["Pessoa"].Visible = true;
                        gvNotaFiscal.Columns["Pessoa"].Group();
                        gvOrcamento.Columns["Pessoa"].Visible = true;
                        gvOrcamento.Columns["Pessoa"].Group();
                    }
                    else
                    {
                        gvNotaFiscal.Columns["Pessoa"].Visible = false;
                        gvOrcamento.Columns["Pessoa"].Visible = false;
                    }
                }
            }
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();
            if (lkSuperior.Selecionado == null)
            {
                dxErroProvider.SetError(lkSuperior, "Campo obrigatório");
            }
            if (chkFiltraPor.Checked && lkInferior.Selecionado == null)
            {
                dxErroProvider.SetError(lkInferior, "Campo obrigatório");
            }
            if (dtInicial.DateTime > dtFinal.DateTime)
            {
                dxErroProvider.SetError(dtInicial, "Data inicial maior que a final");
                dxErroProvider.SetError(dtFinal, "Data inicial maior que a final");
            }

            return !dxErroProvider.HasErrors;
        }

        private void CarregaGrids()
        {
            if (filtroPor == FiltroPor.Pessoa)
            {
                notasFiscais = new List<GridProdutosItem>();
                foreach (var ni in NotaController.Instancia.GetProdutoVendaPorClienteNoPeriodo((Pessoa)lkSuperior.Selecionado, (Produto)lkInferior.Selecionado, dtInicial.DateTime, dtFinal.DateTime, inOut))
                    notasFiscais.Add(new GridProdutosItem(ni));
                gcNotaFiscal.DataSource = notasFiscais;

                pedidos = new List<GridProdutosItem>();
                foreach (var pi in PedidoController.Instancia.GetProdutoVendaPorClienteNoPeriodo((Pessoa)lkSuperior.Selecionado, (Produto)lkInferior.Selecionado, dtInicial.DateTime, dtFinal.DateTime, inOut))
                    pedidos.Add(new GridProdutosItem(pi));
                gcOrcamento.DataSource = pedidos;
            }
            else
            {
                notasFiscais = new List<GridProdutosItem>();
                foreach (var ni in NotaController.Instancia.GetProdutoVendaPorClienteNoPeriodo((Pessoa)lkInferior.Selecionado, (Produto)lkSuperior.Selecionado, dtInicial.DateTime, dtFinal.DateTime, inOut))
                    notasFiscais.Add(new GridProdutosItem(ni));
                gcNotaFiscal.DataSource = notasFiscais;

                pedidos = new List<GridProdutosItem>();
                foreach (var pi in PedidoController.Instancia.GetProdutoVendaPorClienteNoPeriodo((Pessoa)lkInferior.Selecionado, (Produto)lkSuperior.Selecionado, dtInicial.DateTime, dtFinal.DateTime, inOut))
                    pedidos.Add(new GridProdutosItem(pi));
                gcOrcamento.DataSource = pedidos;
            }
        }

        private void cbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtInicial.DateTime = DateTime.Today.AddDays(-Convert.ToInt32(cbPeriodo.Text.Substring(8, 2)));
                dtFinal.DateTime = DateTime.Today;

                dtInicial.Enabled = false;
                dtFinal.Enabled = false;
            }
            catch
            {
                dtInicial.Enabled = true;
                dtFinal.Enabled = true;
            }
        }

        private void chkFiltraPorProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFiltraPor.Checked)
            {
                lkInferior.Enabled = true;
                btProduto.Enabled = true;
            }
            else
            {
                lkInferior.Enabled = false;
                lkInferior.Text = null;
                btProduto.Enabled = false;
            }
        }

        private void sbConsultarNota_Click(object sender, EventArgs e)
        {
            try
            {
                GridProdutosItem item = (GridProdutosItem)gvNotaFiscal.GetRow(gvNotaFiscal.GetSelectedRows()[0]);
                Nota selecionado = (Nota)item.Holder;
                Nota loadObjectById = NotaController.Instancia.LoadObjectById(selecionado.ID);
                new FormNota((InOutType)loadObjectById.TipoNota.Ent_Sai) { Selecionado = loadObjectById, Operacao = Acao.Consultar }.ShowDialog();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Nenhum registro selecionado. Verifique!", "Erro");
                return;
            }          
        }

        private void sbConsultarOrcamento_Click(object sender, EventArgs e)
        {
            GridProdutosItem item = (GridProdutosItem)gvOrcamento.GetRow(gvOrcamento.GetSelectedRows()[0]);


            Pedido selecionado = (Pedido)item.Holder;
            new FormOrcamento() { Selecionado = PedidoController.Instancia.LoadObjectById(selecionado.ID), Operacao = Acao.Consultar }.ShowDialog();

        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            AbreGridLookup(lkSuperior);
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            AbreGridLookup(lkInferior);
        }

        private void AbreGridLookup(Lookup lookup)
        {
            try
            {
                Produto produto = (Produto)lookup.Exemplo;
                GridProdutoGen grid = new GridProdutoGen(ProdutoController.Instancia.GetAll(), (Produto)lookup.Selecionado, true, false, typeof(FormProduto));
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lookup.Localizar(grid.Selecionado.ID);
                }
            }
            catch (InvalidCastException)
            {
                Pessoa pessoa = (Pessoa)lookup.Exemplo;
                if (pessoa.BCliente)
                {
                    LookupUtil.GridLookupPessoa(lookup, PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
                }
                else
                {
                    LookupUtil.GridLookupPessoa(lookup, PessoaController.Instancia.GetAllFornecedores(), "Fornecedores", typeof(FormPessoa));
                }
            }
        }

        private void FormHistoricoVenda_Shown(object sender, EventArgs e)
        {
            cbPeriodo.SelectedIndex = 0;

            if (produto != null)
            {
                lkInferior.Localizar(produto.ID);

                chkFiltraPor.Checked = true;
                //                chkFiltraPor.Enabled = false;

                //                lkInferior.Enabled = false;
                //                btProduto.Enabled = false;

            }

            if (this.cliente != null)
            {
                lkSuperior.Localizar(cliente.ID);
                lkSuperior.Enabled = false;
                btCliente.Enabled = false;

                //                chkFiltraPor.Enabled = false;
                CarregarHistorico();
            }

            if (lkSuperior.Selecionado != null)
            {
                sbConsultarNota.Enabled = false;
                sbConsultarOrcamento.Enabled = false;
            }
        }

        private void gvNotaFiscal_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gvOrcamento_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
    }

    public class GridProdutosItem
    {
        public GridProdutosItem(NotaItem ni)
        {
            Holder = ni.Nota;

            Venda = ni.Nota.Codigo;
            switch (ni.Nota.TipoNota.ModeloDocto)
            {
                case TipoNota.ModeloDocumento.NFe:
                    Tipo = "NFe";
                    break;
                case TipoNota.ModeloDocumento.CupomFiscal:
                    Tipo = "CF";
                    break;
                case TipoNota.ModeloDocumento.ModeloUm:
                    Tipo = "NF";
                    break;
                case TipoNota.ModeloDocumento.Balanco:
                    Tipo = "Bal";
                    break;
            }
            Pessoa = ni.Nota.PessoaNome;
            Quantidade = ni.Quantidade;
            Data = ni.Nota.Dt;
            VlrCalc = ni.ValorCalculado;
            VlrUnit = ni.Valor;
            Desconto = ni.PercDesconto;
            Total = ni.Total;
            Produto = ni.Produto.Nome;
        }

        public GridProdutosItem(PedidoItem ni)
        {
            Holder = ni.Pedido;
            Venda = ni.Pedido.Codigo;
            Tipo = ni.Pedido.TipoPedido.TipoExibicao;
            Pessoa = ni.Pedido.PessoaNome;
            Quantidade = ni.Quantidade;
            Data = ni.Pedido.Dt;
            VlrCalc = ni.ValorCalculado;
            VlrUnit = ni.Valor;
            Desconto = ni.PercDesconto;
            Total = ni.Total;
            Produto = ni.Produto.Nome;
        }

        public object Holder { get; set; }

        public string Pessoa { get; set; }
        public int Venda { get; set; }
        public String Tipo { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime Data { get; set; }
        public decimal VlrCalc { get; set; }
        public decimal VlrUnit { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
        public string Produto { get; set; }

    }
}
