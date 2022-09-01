using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System.Linq;
using Aplicacao.Base;
using cwkGestao.Negocio.Faturamento;

namespace Aplicacao
{
    public partial class FormBaixarOrcamentos : Aplicacao.Relatorios.Base.FormBase
    {
        CwkPedidoController controller = CwkPedidoController.Instancia;
        Nota objNota = new Nota();
        private NotaItem notaItem;

        #region Construtores

        public FormBaixarOrcamentos()
        {
            InitializeComponent();
            InicializaComponentes();
            dtFinal.EditValue = DateTime.Now;
            dtInicial.EditValue = DateTime.Now.AddMonths(-3);
        }

        #endregion

        #region Eventos

        private void lkpCliente_Leave(object sender, EventArgs e)
        {
            MostraPedidos();
        }

        private void btOk_Click_1(object sender, EventArgs e)
        {
            if (gcCwkPedido.DataSource == null || ((List<CwkPedido>)gcCwkPedido.DataSource).Where(ped => ped.BDemonstracao).Count() == 0)
            {
                new FormErro(new Exception("Nenhum Pedido Selecionado.")).ShowDialog();
                return;
            }

            if (MessageBox.Show("Deseja faturar os orçamentos selecionados?", "Faturar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FaturarPedidos();
                MostraPedidos();
                CalculaTotais();
                GerarParcelas();
            }
            //this.Close();
        }

        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            if (lkpCliente.Selecionado == null || dtFinal.EditValue == null || dtInicial.EditValue == null)
            {
                new FormErro(new Exception("Selecione um cliente e datas inicial e final.")).ShowDialog();
                return;
            }
            MostraPedidos();
            CalculaTotais();
            GerarParcelas();
        }

        void repositoryItemCheckEdit1_Click(object sender, System.EventArgs e)
        {
            int handle = ((DevExpress.XtraGrid.Views.Grid.GridView)((DevExpress.XtraGrid.GridControl)((Control)sender).Parent).DefaultView).GetSelectedRows()[0];
            ((CwkPedido)((DevExpress.XtraGrid.Views.Grid.GridView)((DevExpress.XtraGrid.GridControl)((Control)sender).Parent).DefaultView).GetRow(handle)).BDemonstracao = ((DevExpress.XtraEditors.CheckEdit)sender).Checked;
            GerarParcelas();
            CalculaTotais();
        }

        private void sbAtualizarParcelas_Click(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void dtInicial_Leave(object sender, EventArgs e)
        {
            MostraPedidos();
        }

        private void dtFinal_Leave(object sender, EventArgs e)
        {
            MostraPedidos();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtDesconto.EditValue) > 100) txtDesconto.EditValue = 100;
            else if (Convert.ToDecimal(txtDesconto.EditValue) < -100) txtDesconto.EditValue = -100;
            CalculaTotais();
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpCliente, PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            GridGenerica<Filial> grid = new GridGenerica<Filial>(FilialController.Instancia.GetAll(), new FormFilial(), (Filial)lkpFilial.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();
            if (grid.Selecionado != null)
                lkpFilial.EditValue = grid.Selecionado;
        }

        private void lkbTipoMovto_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<TipoNota>(lkpTipoMovto, typeof(FormTipoNota));
        }

        private void lkBtCondicao_Click(object sender, EventArgs e)
        {
            GridGenerica<Condicao> grid = new GridGenerica<Condicao>(CondicaoController.Instancia.GetAll(), new FormCondicao(), (Condicao)lkpCondicao.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();
            if (grid.Selecionado != null)
                lkpCondicao.EditValue = grid.Selecionado;
        }

        private void sbSelecionarTudo_Click(object sender, EventArgs e)
        {
            SelecionarTodos(true);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SelecionarTodos(false);
        }

        private void sbConsultar_Click(object sender, EventArgs e)
        {
            if (gcCwkPedido.DataSource == null) return;
            try
            {
                FormManutPedido form = new FormManutPedido();
                form.cwAcao = 4;

                form.cwID = ((CwkPedido)gvCwkPedido.GetRow(gvCwkPedido.GetSelectedRows()[0])).ID;
                form.cwTabela = "Orçamento";
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                new FormErro(new Exception("Nenhum registro selecionado", ex)).ShowDialog();

            }
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpVendedor, PessoaController.Instancia.GetAllVendedores(), "Vendedor", typeof(FormPessoa));
        }

        private void lkbTipoMovtoServico_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<TipoNota>(lkpTipoMovtoServico, typeof(FormTipoNota));
        }

        private void gvCwkPedidoEmpresa_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Matriz" && e.IsGetData)
            {
                e.Value = getMatriz(sender as DevExpress.XtraGrid.Views.Grid.GridView, e.ListSourceRowIndex);
            }
        }

        private void gcPedidoItem_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Valor" && e.IsGetData)
            {
                e.Value = getTotalValue(sender as DevExpress.XtraGrid.Views.Base.ColumnView, e.ListSourceRowIndex);
            }

        }

        #endregion

        #region Métodos

        private void CalculaTotais()
        {
            txtSubTotal.EditValue = ((List<CwkPedido>)gcCwkPedido.DataSource).Where(ped => ped.BDemonstracao).Sum(ped => ped.CwkPedidoEmpresas.Sum(pedEmp => pedEmp.ValorProduto));
            txtTotal.EditValue = Math.Round(Convert.ToDecimal(txtSubTotal.EditValue) * (100 - Convert.ToDecimal(txtDesconto.EditValue)) / 100, 3);
            objNota.TotalNota = Convert.ToDecimal(txtTotal.EditValue);
        }

        private void InicializaComponentes()
        {
            lkpCliente.Sessao = controller.getSession();
            lkpCliente.Exemplo = new Pessoa() { BCliente = true };
            lkpCliente.CamposRestricoesAND = new List<string>() { "BCliente" };
            lkpCliente.CamposPesquisa = new string[] { "Nome", "Codigo" };

            lkpVendedor.Sessao = controller.getSession();
            lkpVendedor.Exemplo = new Pessoa() { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string>() { "BVendedor" };
            lkpVendedor.CamposPesquisa = new string[] { "Nome", "Codigo" };

            lkpCondicao.Sessao = controller.getSession();
            lkpCondicao.Exemplo = new Condicao();
            lkpCondicao.CamposPesquisa = new string[] { "Nome", "Codigo" };

            lkpTipoMovto.Sessao = controller.getSession();
            lkpTipoMovto.Exemplo = new TipoNota();
            lkpTipoMovto.CamposPesquisa = new string[] { "Nome", "Codigo" };

            lkpTipoMovtoServico.Sessao = controller.getSession();
            lkpTipoMovtoServico.Exemplo = new TipoNota();
            lkpTipoMovtoServico.CamposPesquisa = new string[] { "Nome", "Codigo" };

            lkpFilial.Sessao = controller.getSession();
            lkpFilial.Exemplo = new Filial();
            lkpFilial.CamposPesquisa = new String[] { "Nome", "Codigo" };

            chbSalvarFiltro.Visible = false;

        }

        private object getTotalValue(DevExpress.XtraGrid.Views.Base.ColumnView columnView, int p)
        {
            CwkPedido row = (CwkPedido)gvCwkPedido.GetRow(p);

            return row.CwkPedidoEmpresas.Sum(pedEmp => pedEmp.ValorProduto);
        }

        private object getMatriz(DevExpress.XtraGrid.Views.Grid.GridView gridview, int p)
        {
            CwkPedidoEmpresa row = (CwkPedidoEmpresa)gridview.GetRow(p);

            return row.ClienteRevenda.Matriz;
        }

        private String MontarMensagemErro(Exception e)
        {
            StringBuilder msg = new StringBuilder();
            Exception ex = e;
            msg.Append(ex.Message);
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                msg.Append(ex.Message);
            }
            return msg.ToString();
        }

        private void FaturarPedidos()
        {
            String erros = ValidarTela();

            if (erros.Length > 0)
            {
                new FormErro(new Exception("Preencha/verifique os campos:\n" + erros)).ShowDialog();
                return;
            }
            if (Convert.ToDecimal(txtTotal.EditValue) == 0)
            {
                new FormErro(new Exception("Impossível faturar o valor total = 0.")).ShowDialog();

                return;
            }
            try
            {
                CalculaTotais();
                GerarParcelas();
                List<CwkPedido> pedidos = ((List<CwkPedido>)gcCwkPedido.DataSource).Where(ped => ped.BDemonstracao).ToList();
                MontaNota(objNota);
                StringBuilder codigosSerie = new StringBuilder("Números de série: ");
                int sequencia = 1;



                //cfop, csosn, ipi, mais um                
                foreach (CwkPedido pedido in pedidos)
                {
                    foreach (CwkPedidoEmpresa pedidoEmpresa in pedido.CwkPedidoEmpresas.Where(pd => pd.Produto != null))
                    {
                        int count = objNota.NotaItems.Where(item => item.Produto.Codigo == pedidoEmpresa.Produto.Codigo).Count();
                        if (objNota.NotaItems.Where(item => item.Produto.Codigo == pedidoEmpresa.Produto.Codigo).Count() == 0 || objNota.NotaItems.Where(item => item.Produto.Codigo == pedidoEmpresa.Produto.Codigo).Single().Valor != pedidoEmpresa.ValorProduto)
                        {
                            notaItem = new NotaItem { Sequencia = sequencia, ProdutoNome = pedidoEmpresa.Produto.Nome, Nota = objNota, Produto = pedidoEmpresa.Produto, Valor = pedidoEmpresa.ValorProduto.Value, Dt = DateTime.Now,Unidade = pedidoEmpresa.Produto.Unidade.Sigla,Quantidade = pedidoEmpresa.Quantidade.HasValue ? pedidoEmpresa.Quantidade.Value : 1, CFOP = pedidoEmpresa.Produto.CFOP };
                            notaItem.orig_N11 = pedidoEmpresa.Produto.OrigemProd;
                            notaItem.cEnq_O06 = pedidoEmpresa.Produto.ENQ_IPI.ToString();
                            
                            notaItem.Total = notaItem.Valor * notaItem.Quantidade;

                            NotaBuilder.IniciaTributacao(notaItem);
                            objNota.NotaItems.Add(notaItem);
                        }
                        else if (objNota.NotaItems.Where(item => item.Produto.Codigo == pedidoEmpresa.Produto.Codigo).Single().Valor == pedidoEmpresa.ValorProduto)
                            objNota.NotaItems.Where(item => item.Produto.Codigo == pedidoEmpresa.Produto.Codigo).Single().Quantidade += pedidoEmpresa.Quantidade.HasValue ? pedidoEmpresa.Quantidade.Value : 1;
                        sequencia++;
                    }
                    codigosSerie.Append(String.Format("{0:000}-{1},", pedido.Sistema.Codigo, pedido.NumeroSerie));
                    pedido.BDemonstracao = false;
                    pedido.Status = OrcamentoStatus.Faturado;
                }


                #region servico
                Nota objNotaServico = new Nota();
                if (pedidos.Where(pedido => pedido.CwkPedidoEmpresas.Where(pedempresa => pedempresa.Servico != null).Count() > 0).Count() > 0)
                {
                    IList<NotaItemServico> servicosNota = GeraNotaServicoItens(pedidos);

                    MontaNota(objNotaServico);
                    objNotaServico.Numero++;
                    objNotaServico.Codigo++;
                    objNotaServico.TipoNota = (TipoNota)lkpTipoMovtoServico.Selecionado;
                    objNotaServico.ModeloDocto = (int)objNotaServico.TipoNota.ModeloDocto;
                    objNotaServico.NotaItemsServicos = servicosNota;
                    foreach (NotaItemServico notaItemsServico in objNotaServico.NotaItemsServicos)
                        notaItemsServico.Nota = objNotaServico;
                    LogicaTelaNotaFiscal logicaTelaNota = new LogicaTelaNotaFiscal(objNotaServico);
                    logicaTelaNota.AtualizaImpostosServico();
                    objNotaServico.TotalServico = servicosNota.Sum(ns => ns.Valor * ns.Quantidade);
                    objNotaServico.TotalNota = objNotaServico.TotalServico;
                    objNotaServico.NotaParcelas = CondicaoController.Instancia.GerarParcelasNota(objNotaServico.Condicao, objNotaServico.TotalNota, dtFaturamento.DateTime);
                    NotaController.Instancia.Salvar(objNotaServico, Acao.Incluir);
                }

                #endregion


                foreach (var notaItem in objNota.NotaItems)
                     notaItem.Total = notaItem.Valor * notaItem.Quantidade;


                objNota.ObservacaoUsuario = objNota.ObservacaoUsuario + "; " + codigosSerie.Remove(codigosSerie.Length - 1, 1).Append(".").ToString();
                objNota.ModeloDocto = (int)((TipoNota)lkpTipoMovto.Selecionado).ModeloDocto;
                new NotaBuilder(objNota).SetTotaisNota();
                decimal percdesc = Convert.ToDecimal(txtDesconto.EditValue);
                objNota.TotalProduto = objNota.NotaItems.Sum(it => it.Valor * it.Quantidade) * (1 - percdesc / 100);
                objNota.TotalNota = objNota.TotalProduto;
                objNota.NotaParcelas = CondicaoController.Instancia.GerarParcelasNota(objNota.Condicao, objNota.TotalNota, dtFaturamento.DateTime);
                if (objNota.TotalNota > 0) NotaController.Instancia.Salvar(objNota, Acao.Incluir);

                foreach (CwkPedido pedido in pedidos)
                {
                    controller.Salvar(pedido, Acao.Alterar);
                }
                String mensagem = String.Empty;
                if (objNota.TipoNota.BGeraFinanceiro)
                    try
                    {
                        if (objNota.ID > 0) NotaController.Instancia.GeraFinanceiroEGrava(objNota);
                        if (objNotaServico.ID > 0) NotaController.Instancia.GeraFinanceiroEGrava(objNotaServico);
                    }
                    catch (Exception e) { new FormErro(e).ShowDialog(); }

                FormNota newForm = new FormNota(InOutType.Entrada);
                newForm.Selecionado = NotaController.Instancia.LoadObjectById(objNota.ID);
                newForm.Operacao = Acao.Consultar;
                objNota = new Nota();
            }
            catch (Exception e)
            {
                new FormErro(e).ShowDialog();
            }
        }

        private IList<NotaItemServico> GeraNotaServicoItens(List<CwkPedido> pedidos)
        {
            IList<NotaItemServico> servicos = new List<NotaItemServico>();

            foreach (CwkPedido cwkPedido in pedidos)
            {
                foreach (CwkPedidoEmpresa item in cwkPedido.CwkPedidoEmpresas.Where(ped => ped.Servico != null))
                {
                    servicos.Add(new NotaItemServico() { Servico = item.Servico, CodigoServico = item.Servico.Codigo, NomeServico = item.Servico.Nome, Quantidade = item.Quantidade ?? 1, Valor = item.ValorProduto.Value, SubTotal = item.ValorProduto.Value * (item.Quantidade ?? 1) });

                }
            }

            return servicos;
        }

        private string ValidarTela()
        {
            StringBuilder erros = new StringBuilder();
            if (dtFaturamento.DateTime.Year < 1800)
            {
                erros.AppendLine("Data Faturamento.");
                dxErroProvider.SetError(dtFaturamento, "Campo obrigatório");
            }
            else dxErroProvider.SetError(dtFaturamento, "");
            if (lkpCondicao.Selecionado == null)
            {
                erros.AppendLine("Condição");
                dxErroProvider.SetError(lkpCondicao, "Campo obrigatório");
            }
            else dxErroProvider.SetError(lkpCondicao, "");
            if (lkpTipoMovto.Selecionado == null)
            {
                erros.AppendLine("Tipo Movimento.");
                dxErroProvider.SetError(lkpTipoMovto, "Campo obrigatório");
            }
            else
            {

                Filial fil = (Filial)lkpFilial.Selecionado;
                string msgerrodocapeta = "";
                string msgerrodocapeta2 = "";
                bool booleano = true;
                if (NotaController.Instancia.DadosNfeValidos((Pessoa)lkpCliente.Selecionado, fil.Cidade.UF.ID, (int?)((TipoNota)lkpTipoMovto.Selecionado).ModeloDocto, out msgerrodocapeta, out booleano)
                    && NotaController.Instancia.DadosPedidoFaturarValidos((Pessoa) lkpCliente.Selecionado, out msgerrodocapeta2))
                {
                    dxErroProvider.SetError(lkpTipoMovto, "");

                }
                else
                {
                    erros.AppendLine("Tipo Movimento.");
                    dxErroProvider.SetError(lkpTipoMovto, msgerrodocapeta + msgerrodocapeta2);
                }

            }


            if (lkpTipoMovtoServico.Selecionado == null)
            {
                erros.AppendLine("Tipo Movimento Serviço.");
                dxErroProvider.SetError(lkpTipoMovtoServico, "Campo obrigatório");
            }
            else
            {

                Filial fil = (Filial)lkpFilial.Selecionado;
                string msgerrodocapeta = "";
                string msgerrodocapeta2 = "";
                bool booleano = true;
                if (NotaController.Instancia.DadosNfeValidos((Pessoa)lkpCliente.Selecionado, fil.Cidade.UF.ID, (int?)((TipoNota)lkpTipoMovtoServico.Selecionado).ModeloDocto, out msgerrodocapeta, out booleano)
                    && NotaController.Instancia.DadosPedidoFaturarValidos((Pessoa)lkpCliente.Selecionado, out msgerrodocapeta2))
                {
                    dxErroProvider.SetError(lkpTipoMovtoServico, "");

                }
                else
                {
                    erros.AppendLine("Tipo Movimento Serviço.");
                    dxErroProvider.SetError(lkpTipoMovtoServico, msgerrodocapeta + msgerrodocapeta2);
                }

            }

            if (lkpVendedor.Selecionado == null)
            {
                erros.AppendLine("Vendedor.");
                dxErroProvider.SetError(lkpVendedor, "Campo obrigatório");
            }
            else dxErroProvider.SetError(lkpVendedor, "");

            if (lkpFilial.Selecionado == null)
            {
                erros.AppendLine("Filial.");
                dxErroProvider.SetError(lkpFilial, "Campo obrigatório");
            }
            else dxErroProvider.SetError(lkpFilial, "");
            return erros.ToString();
        }

        private void MontaNota(Nota objNotap)
        {
            objNotap.Vendedor = ((Pessoa)lkpVendedor.Selecionado).PessoaVendedores.First();
            objNotap.Dt = dtFaturamento.DateTime;
            objNotap.Codigo = NotaController.Instancia.GetNovoCodigoNota();
            objNotap.Condicao = (Condicao)lkpCondicao.Selecionado;
            objNotap.DtDigitacao = DateTime.Now;
            objNotap.ObservacaoUsuario = txtObs1.Text.TrimEnd();
            objNotap.ObservacaoUsuario += (String.IsNullOrEmpty(objNotap.ObservacaoUsuario) ? "" : "; ") + txtObs2.Text.TrimEnd();
            objNotap.ObservacaoUsuario += (String.IsNullOrEmpty(objNotap.ObservacaoUsuario) ? "" : "; ") + txtObs3.Text.TrimEnd();
            objNotap.NotaItemsServicos = new List<NotaItemServico>();
            objNotap.PercDesconto = Convert.ToDecimal(txtDesconto.EditValue);
            objNotap.Pessoa = (Pessoa)lkpCliente.Selecionado;
            objNotap.BPessoaContribuinte = objNotap.Pessoa.BContribuinte;
            objNotap.TipoNota = (TipoNota)lkpTipoMovto.Selecionado;
            objNotap.TotalNota = Convert.ToDecimal(txtTotal.EditValue);
            objNotap.TotalProduto = Convert.ToDecimal(txtSubTotal.EditValue);
            objNotap.TabelaPreco = TabelaPrecoController.Instancia.GetAll().First();
            objNotap.NotaItems = new List<NotaItem>();
            objNotap.Filial = (Filial)lkpFilial.Selecionado;
            objNotap.NotaParcelas = ((List<NotaParcela>)gcParcelas.DataSource);
            objNotap.Ent_Sai = InOutType.Saída;
            objNotap.Serie = objNotap.TipoNota.Serie;
            objNotap.Numero = NotaController.Instancia.NovoNumeroSerie(objNotap, null);
            objNotap.PessoaBairro = objNotap.Pessoa.PessoaEnderecos[0].Bairro;
            objNotap.PessoaCEP = objNotap.Pessoa.PessoaEnderecos[0].CEP;
            objNotap.PessoaCidade = objNotap.Pessoa.PessoaEnderecos[0].Cidade.Nome;
            objNotap.PessoaCidadeIBGE = objNotap.Pessoa.PessoaEnderecos[0].Cidade.IBGE;
            objNotap.PessoaCNPJCPF = objNotap.Pessoa.CNPJ_CPF;
            objNotap.PessoaEndereco = objNotap.Pessoa.PessoaEnderecos[0].Endereco;
            objNotap.PessoaInscRG = objNotap.Pessoa.RG + objNotap.Pessoa.Inscricao;
            objNotap.PessoaNome = objNotap.Pessoa.Nome;
            objNotap.PessoaTelefone = objNotap.Pessoa.PessoaTelefones[0].Numero;
            objNotap.PessoaUF = objNotap.Pessoa.PessoaEnderecos[0].Cidade.UF.Sigla;
            objNotap.ModeloDocto = (int)objNotap.TipoNota.ModeloDocto;

        }

        private void MostraPedidos()
        {
            if (lkpCliente.Selecionado == null || dtFinal.EditValue == null || dtInicial.EditValue == null) return;
            try
            {
                List<CwkPedido> pedidos = controller.GetPedidos((Pessoa)lkpCliente.Selecionado, dtInicial.DateTime, dtFinal.DateTime)
                                                    .Where(ped => ped.Status == OrcamentoStatus.AguardandoFaturamento).ToList();

                gcCwkPedido.DataSource = pedidos;
            }
            catch (Exception ex) { new FormErro(ex).ShowDialog(); }

            gcCwkPedido.Refresh();
            gvCwkPedido.RefreshData();
        }

        private void GerarParcelas()
        {
            if (lkpCondicao.Selecionado == null) return;

            objNota.Condicao = (Condicao)lkpCondicao.Selecionado;
            objNota.Dt = dtFaturamento.DateTime;
            CalculaTotais();
            try
            {
                if (objNota.TotalNota > 0)
                    gcParcelas.DataSource = CondicaoController.Instancia.GerarParcelas(objNota);
                else if (gcParcelas.DataSource != null)
                    ((List<NotaParcela>)gcParcelas.DataSource).Clear();
            }
            catch (Exception e) { new FormErro(e).ShowDialog(); }
            gcParcelas.Refresh();
            gvParcela.RefreshData();

        }

        private void SelecionarTodos(bool p)
        {
            if (gcCwkPedido.DataSource == null) return;
            foreach (CwkPedido ped in ((List<CwkPedido>)gvCwkPedido.DataSource))
            {
                ped.BDemonstracao = p;
            }
            gcCwkPedido.Refresh();
            gvCwkPedido.RefreshData();
        }

        #endregion

        #region Tipos

        public class NestedRecords : System.Collections.ArrayList
        {
            public NestedRecords(List<CwkPedido> pedidos)
            {
                foreach (CwkPedido item in pedidos)
                {
                    Add(item);
                }

            }
            public virtual new CwkPedido this[int index]
            {
                get { return (CwkPedido)(base[index]); }
            }
        }

        #endregion
    }
}
