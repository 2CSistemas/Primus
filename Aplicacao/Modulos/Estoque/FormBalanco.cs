using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.ControleEstoque;
using Aplicacao.Base;
using DevExpress.XtraEditors.Repository;
using Aplicacao.Util;
using cwkGestao.Integracao.Magento.Exportacao;
using Aplicacao.Modulos.Cadastro;

namespace Aplicacao
{
    public partial class FormBalanco : Aplicacao.IntermediariasTela.FormManutBalancoIntermediaria
    {
        private string displayQtd = "##,###,##0.####";
        private Produto produtoSelecionado;
        private int indiceSelecionado;
        IList<Imei> listaImeiProduto;

        public FormBalanco()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //FormBalancoItem formBalancoItem = new FormBalancoItem();
            //btnAlterarBalancoItem.SubForm = formBalancoItem;
            //btnIncluirBalancoItem.SubForm = formBalancoItem;
            //btnExcluirBalancoItem.SubForm = formBalancoItem;
            //btnConsultarBalancoItem.SubForm = formBalancoItem;

            FormBalancoItem formBalancoItem = new FormBalancoItem();
            btnAlterarBalancoItem.SubFormType = btnIncluirBalancoItem.SubFormType = btnExcluirBalancoItem.SubFormType = btnConsultarBalancoItem.SubFormType = typeof(FormBalancoItem);

            //lkbLocalEstoque.SubForm = new FormLocalEstoque();
            lkbLocalEstoque.SubFormType = typeof(FormLocalEstoque);
        }

        protected override void AcoesAntesSalvar()
        {
            if (Operacao == Acao.Excluir)
            {
                var sel = Selecionado.BalancoItems.FirstOrDefault();
                if (sel != null && sel.NotaItem != null)
                {
                    NotaController.Instancia.RegisterNewIntoTransaction(sel.NotaItem.Nota);
                    NotaController.Instancia.CommitUnitOfWorkTransaction();
                }
            }
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            //Configuracao objConf = ConfiguracaoController.Instancia.GetConfiguracao();
            //String mensagemDetalheAviso = "";

            //IList<BalancoItem> balancoItensErrados = Selecionado.BalancoItems.Where(b => ImeiController.VerificaUtilizacaoImei(b.Produto)).ToList();

            //foreach (var item in balancoItensErrados)
            //{
            //    listaImeiProduto = ImeiController.Instancia.GetAllByIDProduto(item.Produto.ID, true);

            //    mensagemDetalheAviso += item.Quantidade == listaImeiProduto.Count ? ""
            //        : String.Format("Quantidade do Produto {0}, não bate com a quantidade de IMEI.{1}", item.Produto.Nome, Environment.NewLine);

            //    if (objConf.UtilizaControleIMEI && !String.IsNullOrEmpty(mensagemDetalheAviso) && item.Quantidade > 0)
            //    {
            //        FormAviso formErro = new FormAviso("Não foi possível salvar o balanço, pois a quantidade de IMEIs relacionados com os itens difere da quantidade total de itens.", mensagemDetalheAviso);
            //        formErro.Show();
            //    }
            //    else
            //    {
            //        base.sbGravar_Click(sender, e);
            //    }
            //}

            //if(balancoItensErrados.Count() == 0)
            //{ 
                base.sbGravar_Click(sender, e);
            //}
        }

        private void btnIncluirMais_Click(object sender, EventArgs e)
        {
            try
            {
                GridProdutoGenMais grid = new GridProdutoGenMais(new List<Produto>(), false, typeof(FormProduto));
                grid.sbFuncao22.Text = "Selecionar Todos";
                grid.sbFuncao22.Visible = true;
                grid.sbFuncao22.Enabled = true;
                grid.sbFuncao23.Text = "Desmarcar Todos";
                grid.sbFuncao23.Visible = true;
                grid.sbFuncao23.Enabled = true;
                grid.ShowDialog();

                AdicionarMais(grid.ProdutosSelecionados);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void AdicionarMais(IList<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                var balancoItem = new BalancoItem();
                balancoItem.Produto = item;
                balancoItem.Quantidade = 0.00m;
                balancoItem.Balanco = Selecionado;
                Selecionado.BalancoItems.Add(balancoItem);
            }
            AtualizaGridBalancoItem();
        }

        private void AtualizaGridBalancoItem()
        {
            gcBalancoItems.DataSource = null;
            gcBalancoItems.DataSource = Selecionado.BalancoItems;
            gcBalancoItems.RefreshDataSource();
 			gcBalancoItems.Refresh();
            gvBalancoItems.RefreshData();
            gvBalancoItems.MoveLastVisible();        }

        private void FormBalanco_Shown(object sender, EventArgs e)
        {
            MascaraColunaQtd();
            gvBalancoItems.Columns[0].OptionsColumn.AllowEdit = false;
        }

        private void MascaraColunaQtd()
        {
            RepositoryItemTextEdit repositorio = new RepositoryItemTextEdit();

            repositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.EditFormat.FormatString = displayQtd;
            repositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.DisplayFormat.FormatString = displayQtd;

            repositorio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repositorio.Mask.EditMask = "n0";

            gvBalancoItems.Columns[1].ColumnEdit = repositorio;
            gvBalancoItems.RefreshEditor(false);
        }

        private void gvBalancoItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (Selecionado != null && gvBalancoItems.FocusedRowHandle >= 0)
            {
                TrataMascaraQtd(Selecionado.BalancoItems[gvBalancoItems.FocusedRowHandle]);
            }
        }

        private void TrataMascaraQtd(BalancoItem item)
        {
            if (item.Produto != null)
            {
                string editMask = "";

                if (item.Produto.Unidade.BQtdFracionada)
                    editMask = "n4";
                else
                    editMask = "n0";

                ((RepositoryItemTextEdit)gvBalancoItems.Columns[1].ColumnEdit).Mask.EditMask = editMask;

                ((RepositoryItemTextEdit)gvBalancoItems.Columns[1].ColumnEdit).EditFormat.FormatString = displayQtd;
                ((RepositoryItemTextEdit)gvBalancoItems.Columns[1].ColumnEdit).DisplayFormat.FormatString = displayQtd;

                gvBalancoItems.RefreshEditor(false);
            }
        }

        private void btnIncluirIMEI_Click(object sender, EventArgs e)
        {
            if (produtoSelecionado != null)
            {
                Imei objImei = new Imei(produtoSelecionado);
                listaImeiProduto = ImeiController.Instancia.GetAllByIDProduto(produtoSelecionado.ID, true);

                GridImeiGen form = new GridImeiGen(listaImeiProduto, objImei, false, false, typeof(FormImei));
                form.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum produto selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void gvBalancoItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            VerificarImei();
        }

        private void gcBalancoItems_MouseClick(object sender, MouseEventArgs e)
        {
            VerificarImei();
        }

        private void gcBalancoItems_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarImei();
        }

        private void VerificarImei()
        {
            try
            {
                PegarProdutoSelecionado();
                btnIncluirIMEI.Visible = ImeiController.VerificaUtilizacaoImei(produtoSelecionado);
                indiceSelecionado = gvBalancoItems.GetSelectedRows()[0];
            }
            catch (Exception)
            {
                indiceSelecionado = -1;
            }
        }

        private void PegarProdutoSelecionado()
        {
            BalancoItem balancoItem = ((BalancoItem)gvBalancoItems.GetRegistroSelecionado());
            produtoSelecionado = balancoItem == null ? new Produto() : balancoItem.Produto;
        }

        private void FormBalanco_Load(object sender, EventArgs e)
        {
            btnIncluirIMEI.Visible = false;
            PegarProdutoSelecionado();
        }

 



  
    }
}
