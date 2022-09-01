using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Modulos.Telefonia.Impressao;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using System.IO;
using Ionic.Zip;
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Negocio.Contratos;
using DevExpress.XtraPrinting;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Aplicacao.Modulos.Contratos
{
    public partial class GridPesquisaFaturasContratoProduto : Form
    {
        ContratoController contratoController = ContratoController.Instancia;
        ContratoProdutoController contratoProdutoController = ContratoProdutoController.Instancia;

        FaturadorContratoProduto faturadorContratoProduto;
        IList<ContratoProduto> listaContratosProdutoParaFaturar, listaContratoProdutoSelecionados;

        PrintableComponentLink printableComponentLink1;
        public GridPesquisaFaturasContratoProduto(DateTime vencimento, Filial filial, TabelaPreco tabelaPreco, TipoNota tipoNotaProduto, bool Aumentar30Dias, bool UsarMesAtualParaValidarGeracao)
        {
            InitializeComponent();

            InicializarListasContratosProdutos();
            faturadorContratoProduto = new FaturadorContratoProduto(vencimento, filial, tabelaPreco, tipoNotaProduto, Aumentar30Dias, UsarMesAtualParaValidarGeracao);

            IEnumerable<IGrouping<int, ContratoProduto>> grupoContrato = faturadorContratoProduto.ListaContratosProduto.GroupBy(s => s.Contrato.ID);

            IList<pxyContratoProduto> listaContratosProduto = new List<pxyContratoProduto>();
            foreach (var grupo in grupoContrato)
            {
                IList<ContratoProduto> lstContratoProduto = grupo.Select(s => s).ToList();
                ContratoProduto primeiroContratoProduto = lstContratoProduto.FirstOrDefault();
                Contrato contrato = primeiroContratoProduto.Contrato;

                pxyContratoProduto proxy = new pxyContratoProduto(grupo.Key, lstContratoProduto, contrato.Pessoa.Nome, primeiroContratoProduto.Vencimento, lstContratoProduto.Sum(s => s.Total), contrato.Observacao);
                listaContratosProduto.Add(proxy);
            }

            gcContratoProdutos.DataSource = listaContratosProduto;
            
        }

      
        private void InicializarListasContratosProdutos()
        {
            listaContratoProdutoSelecionados = listaContratosProdutoParaFaturar = new List<ContratoProduto>();
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(false);
        }

        private void sbInverterSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(null);
        }

        private void AlterarSelecaoPedidos(bool? selecionado)
        {
            var lista = gcContratoProdutos.DataSource;
            if (lista != null)
            {
                foreach (var itemSelecionado in (List<pxyContratoProduto>)lista)
                {
                    if (selecionado.HasValue)
                    {
                        itemSelecionado.Selecionado = selecionado.Value;
                    }
                    else
                    {
                        itemSelecionado.Selecionado = !itemSelecionado.Selecionado;
                    }
                }
            }
            gcContratoProdutos.RefreshDataSource();
        }

        #region Impressão da Pivot Grid

        private void sbImprimirFiltro_Click(object sender, EventArgs e)
        {
            printableComponentLink1 = new PrintableComponentLink(new PrintingSystem());
            printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printableComponentLink1.Component = gcContratoProdutos;
            printableComponentLink1.CreateMarginalHeaderArea += printableComponentLink1_CreateMarginalHeaderArea;
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }

        private void printableComponentLink1_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TelasUtil.CriaHeaderImpressaoFiltro(e, this.gvContratoProdutos, ref printableComponentLink1, this.Text);
        }

      
        #endregion

        private void btGerarContratos_Click(object sender, EventArgs e)
        {
            StringBuilder sbMensagemErroFatura;

            gcContratoProdutos.DataSource = gcContratoProdutos.DataSource == null ? new List<pxyContratoProduto>() : gcContratoProdutos.DataSource;
            listaContratoProdutoSelecionados = ((List<pxyContratoProduto>)gcContratoProdutos.DataSource).Where(px => px.Selecionado).SelectMany(s => s.ContratoProcuto).ToList();
            if (ValidarTela())
            {
                bool sucesso = false;
                sbMensagemErroFatura = faturadorContratoProduto.Faturar(ref sucesso, listaContratoProdutoSelecionados);

                if (sbMensagemErroFatura.Length > 0)
                {
                    FormAviso form = new FormAviso("Processo de Geração de Faturas finalizado, algumas das faturas não puderam ser geradas", sbMensagemErroFatura.ToString());
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Processo de Geração de Faturas finalizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FecharTela();
            }
        }

        public Boolean ValidarTela()
        {
            if (listaContratoProdutoSelecionados.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("É preciso Selecionar ao menos um Contrato", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void FecharTela()
        {
            this.Close();
        }

    }
}
