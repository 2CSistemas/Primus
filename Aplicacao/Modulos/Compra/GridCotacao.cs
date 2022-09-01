using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using cwkGestao.Negocio;
using Microsoft.Reporting.WinForms;

namespace Aplicacao
{
    public partial class GridCotacao : Aplicacao.IntermediariasTela.GridCotacaoIntermediaria
    {
        public GridCotacao(IList<Cotacao> lista, Cotacao selecionado, Func<IList<Cotacao>> atualizador, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, atualizador, false, formManut, parametros)
        {
            ConfiguraBotoes();
        }

        private void ConfiguraBotoes()
        {
            sbFuncao11.Click += new EventHandler(btPedidos_Click);
            sbFuncao11.Text = "&Pedidos";
            sbFuncao11.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            sbFuncao11.Visible = true;
            sbFuncao11.Enabled = true;
            sbFuncao11.Size = new Size(75, 23);
            sbFuncao11.Location = new Point(246, 392);
            sbFuncao11.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);

            sbFuncao12.Click += new EventHandler(btGerarOrcamento_Click);
            sbFuncao12.Text = "&Gerar Orçamento";
            sbFuncao12.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao12.Visible = true;
            sbFuncao12.Enabled = true;
            sbFuncao12.Size = new Size(113, 23);
            sbFuncao12.Location = new Point(325, 392);
            sbFuncao12.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);

            sbFuncao13.Click += new EventHandler(btPrecos_Click);
            sbFuncao13.Text = "P&reços";
            sbFuncao13.Image = global::Aplicacao.Properties.Resources.Recalcula_Marcacaes_copy;
            sbFuncao13.Visible = true;
            sbFuncao13.Enabled = true;
            sbFuncao13.Size = new Size(75, 23);
            sbFuncao13.Location = new Point(441, 392);
            sbFuncao13.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);

            sbFuncao23.Click += new EventHandler(btImprimir_Click);
            sbFuncao23.Text = "I&mprimir";
            sbFuncao23.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao23.Visible = true;
            sbFuncao23.Enabled = true;
            sbFuncao23.Size = new Size(75, 23);
            sbFuncao23.Location = new Point(675, 420);
            sbFuncao23.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            FormConsultaPedidoCotacao form = new FormConsultaPedidoCotacao();
            form.Selecionado = CotacaoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);

            form.ShowDialog();
        }

        private void btGerarOrcamento_Click(object sender, EventArgs e)
        {
            var cotacao = GetRegistroSelecionado();
            if (cotacao.TipoCotacao == TipoCotacao.Cotação)
                new FormGerarOrdemCompra(cotacao).ShowDialog();
            else
                MessageBox.Show("Esta cotação é uma Lista de produtos. Para gerar um orçamento selecione um registro do tipo Cotação.");
        }

        private void btPrecos_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                if (registroSelecionado.TipoCotacao != TipoCotacao.Lista)
                {
                    var cotacao = CotacaoController.Instancia.LoadObjectById(registroSelecionado.ID);
                    var form = new FormPrecosFornecedores(cotacao);
                    if (cwkControleUsuario.Facade.ControleAcesso(form))
                    {
                        form.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("O cadastro de preços não pode ser feito para cotações do tipo Lista.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        #region reuso relatorio
        private List<string> ColetaFornecedores()
        {
            List<string> fornc = new List<string>();
            var forn1 = PessoaController.Instancia.LoadObjectById(GetRegistroSelecionado().IDFornecedor_01) ?? new Pessoa();
            var forn2 = PessoaController.Instancia.LoadObjectById(GetRegistroSelecionado().IDFornecedor_02) ?? new Pessoa();
            var forn3 = PessoaController.Instancia.LoadObjectById(GetRegistroSelecionado().IDFornecedor_03) ?? new Pessoa();
            var forn4 = PessoaController.Instancia.LoadObjectById(GetRegistroSelecionado().IDFornecedor_04) ?? new Pessoa();
            var forn5 = PessoaController.Instancia.LoadObjectById(GetRegistroSelecionado().IDFornecedor_05) ?? new Pessoa();
            var forn6 = PessoaController.Instancia.LoadObjectById(GetRegistroSelecionado().IDFornecedor_06) ?? new Pessoa();
            fornc.Add(forn1.Nome);
            fornc.Add(forn2.Nome);
            fornc.Add(forn3.Nome);
            fornc.Add(forn4.Nome);
            fornc.Add(forn5.Nome);
            fornc.Add(forn6.Nome);
            return fornc;
        }

        private List<string> ColetaCondicoes()
        {
            List<string> conds = new List<string>();
            var con1 = CondicaoController.Instancia.LoadObjectById(GetRegistroSelecionado().IDCondicao_01) ?? new Condicao();
            var con2 = CondicaoController.Instancia.LoadObjectById(GetRegistroSelecionado().IDCondicao_02) ?? new Condicao();
            var con3 = CondicaoController.Instancia.LoadObjectById(GetRegistroSelecionado().IDCondicao_03) ?? new Condicao();
            var con4 = CondicaoController.Instancia.LoadObjectById(GetRegistroSelecionado().IDCondicao_04) ?? new Condicao();
            var con5 = CondicaoController.Instancia.LoadObjectById(GetRegistroSelecionado().IDCondicao_05) ?? new Condicao();
            var con6 = CondicaoController.Instancia.LoadObjectById(GetRegistroSelecionado().IDCondicao_06) ?? new Condicao();
            conds.Add(con1.Nome);
            conds.Add(con2.Nome);
            conds.Add(con3.Nome);
            conds.Add(con4.Nome);
            conds.Add(con5.Nome);
            conds.Add(con6.Nome);
            return conds;
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            Cotacao objCotacao;
            if (GetRegistroSelecionado().TipoCotacao == TipoCotacao.Lista)
                MessageBox.Show("Esta cotação é uma Lista de produtos, um relatório não pode ser gerado!");
            else
            {
                objCotacao = GetRegistroSelecionado();

                List<object> listaDT = new List<object>();
                List<string> listaDS = new List<string>();
                Relatorio.dsCotacao dt = new Relatorio.dsCotacao();

                Object Empresa = FilialController.Instancia.GetFilialPrincipal();

                #region Parametros
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();

                ReportParameter p1 = new ReportParameter("Nome", objCotacao.Observacao.ToString());
                ReportParameter p2 = new ReportParameter("DataCriacao", objCotacao.Dt.ToString());
                ReportParameter p3 = new ReportParameter("Resumo", objCotacao.Resumo.ToString());
                ReportParameter p4 = new ReportParameter("Codigo", objCotacao.Codigo.ToString());
                ReportParameter p5 = new ReportParameter("Frete1", objCotacao.Frete_01.ToString());
                ReportParameter p6 = new ReportParameter("Frete2", objCotacao.Frete_02.ToString());
                ReportParameter p7 = new ReportParameter("Frete3", objCotacao.Frete_03.ToString());
                ReportParameter p8 = new ReportParameter("Frete4", objCotacao.Frete_04.ToString());
                ReportParameter p9 = new ReportParameter("Frete5", objCotacao.Frete_05.ToString());
                ReportParameter p10 = new ReportParameter("Frete6", objCotacao.Frete_06.ToString());
                ReportParameter p11 = new ReportParameter("IPI1", (objCotacao.IPI_01 / 100).ToString());
                ReportParameter p12 = new ReportParameter("IPI2", (objCotacao.IPI_02 / 100).ToString());
                ReportParameter p13 = new ReportParameter("IPI3", (objCotacao.IPI_03 / 100).ToString());
                ReportParameter p14 = new ReportParameter("IPI4", (objCotacao.IPI_04 / 100).ToString());
                ReportParameter p15 = new ReportParameter("IPI5", (objCotacao.IPI_05 / 100).ToString());
                ReportParameter p16 = new ReportParameter("IPI6", (objCotacao.IPI_06 / 100).ToString());
                ReportParameter p17 = new ReportParameter("Desconto1", (objCotacao.Desconto_01/ 100).ToString());
                ReportParameter p18 = new ReportParameter("Desconto2", (objCotacao.Desconto_02 / 100).ToString());
                ReportParameter p19 = new ReportParameter("Desconto3", (objCotacao.Desconto_03 / 100).ToString());
                ReportParameter p20 = new ReportParameter("Desconto4", (objCotacao.Desconto_04 / 100).ToString());
                ReportParameter p21 = new ReportParameter("Desconto5", (objCotacao.Desconto_05 / 100).ToString());
                ReportParameter p22 = new ReportParameter("Desconto6", (objCotacao.Desconto_06 / 100).ToString());
                ReportParameter p23 = new ReportParameter("Prazo1", String.IsNullOrEmpty(objCotacao.PrazoEntrega_01) ? "" : objCotacao.PrazoEntrega_01.ToString().Substring(0, 10));
                ReportParameter p24 = new ReportParameter("Prazo2", String.IsNullOrEmpty(objCotacao.PrazoEntrega_02) ? "" : objCotacao.PrazoEntrega_02.ToString().Substring(0, 10));
                ReportParameter p25 = new ReportParameter("Prazo3", String.IsNullOrEmpty(objCotacao.PrazoEntrega_03) ? "" : objCotacao.PrazoEntrega_03.ToString().Substring(0, 10));
                ReportParameter p26 = new ReportParameter("Prazo4", String.IsNullOrEmpty(objCotacao.PrazoEntrega_04) ? "" : objCotacao.PrazoEntrega_04.ToString().Substring(0, 10));
                ReportParameter p27 = new ReportParameter("Prazo5", String.IsNullOrEmpty(objCotacao.PrazoEntrega_05) ? "" : objCotacao.PrazoEntrega_05.ToString().Substring(0, 10));
                ReportParameter p28 = new ReportParameter("Prazo6", String.IsNullOrEmpty(objCotacao.PrazoEntrega_06) ? "" : objCotacao.PrazoEntrega_06.ToString().Substring(0, 10));
                ReportParameter p29 = new ReportParameter("Empresa", Empresa.ToString());
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);
                parametros.Add(p6);
                parametros.Add(p7);
                parametros.Add(p8);
                parametros.Add(p9);
                parametros.Add(p10);
                parametros.Add(p11);
                parametros.Add(p12);
                parametros.Add(p13);
                parametros.Add(p14);
                parametros.Add(p15);
                parametros.Add(p16);
                parametros.Add(p17);
                parametros.Add(p18);
                parametros.Add(p19);
                parametros.Add(p20);
                parametros.Add(p21);
                parametros.Add(p22);
                parametros.Add(p23);
                parametros.Add(p24);
                parametros.Add(p25);
                parametros.Add(p26);
                parametros.Add(p27);
                parametros.Add(p28);
                parametros.Add(p29);
                #endregion

                List<string> Forn = ColetaFornecedores();
                dt.Fornecedor.AddFornecedorRow(TrimToMaxLength(Forn[0], 16),TrimToMaxLength(Forn[1], 16),TrimToMaxLength(Forn[2], 16),
                                                TrimToMaxLength(Forn[3], 16),TrimToMaxLength(Forn[4], 16),TrimToMaxLength(Forn[5], 16));

                listaDT.Add(dt.Fornecedor);
                listaDS.Add("dsCotacao_Fornecedor");

                List<string> Cond = ColetaCondicoes();
                dt.Condicao.AddCondicaoRow(Cond[0], Cond[1], Cond[2], Cond[3], Cond[4], Cond[5]);

                listaDT.Add(dt.Condicao);
                listaDS.Add("dsCotacao_Condicao");

                IList<CotacaoProduto> CotProd = CotacaoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID).CotacaoProdutos.Distinct().ToList();

                foreach (CotacaoProduto cotprod in CotProd)
                {
                    decimal? ValorFinal1, ValorFinal2, ValorFinal3, ValorFinal4, ValorFinal5, ValorFinal6;
                    ValorFinal1 = cotprod.Preco_01 * cotprod.Quantidade;
                    ValorFinal2 = cotprod.Preco_02 * cotprod.Quantidade;
                    ValorFinal3 = cotprod.Preco_03 * cotprod.Quantidade;
                    ValorFinal4 = cotprod.Preco_04 * cotprod.Quantidade;
                    ValorFinal5 = cotprod.Preco_05 * cotprod.Quantidade;
                    ValorFinal6 = cotprod.Preco_06 * cotprod.Quantidade;

                    dt.dtCotacaoProduto.AdddtCotacaoProdutoRow(cotprod.Produto.Nome, (cotprod.Preco_01 == null ? "0" : cotprod.Preco_01.ToString()),
                        (cotprod.Preco_02 == null ? "0" : cotprod.Preco_02.ToString()), (cotprod.Preco_03 == null ? "0" : cotprod.Preco_03.ToString()),
                        (cotprod.Preco_04 == null ? "0" : cotprod.Preco_04.ToString()), (cotprod.Preco_05 == null ? "0" : cotprod.Preco_05.ToString()),
                        (cotprod.Preco_06 == null ? "0" : cotprod.Preco_06.ToString()), cotprod.Quantidade.ToString(), cotprod.Codigo.ToString(),
                        cotprod.Cotacao.ID.ToString(), (ValorFinal1 == null ? "0" : ValorFinal1.ToString()), (ValorFinal2 == null ? "0" : ValorFinal2.ToString()),
                        (ValorFinal3 == null ? "0" : ValorFinal3.ToString()), (ValorFinal4 == null ? "0" : ValorFinal4.ToString()),
                        (ValorFinal5 == null ? "0" : ValorFinal5.ToString()), (ValorFinal6 == null ? "0" : ValorFinal6.ToString()));
                }
                listaDT.Add(dt.dtCotacaoProduto);
                listaDS.Add("dsCotacao_dtCotacaoProduto");

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptCotacao.rdlc", listaDS, listaDT, parametros);
                form.Show();
            }
            
        }
        private string TrimToMaxLength(string valor, int max )
        {
            return valor == null ? "" : valor.Substring(0, Math.Min(max, valor.Length));
        }
        #endregion

    }
}
