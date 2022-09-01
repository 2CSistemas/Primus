using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;
using System.Runtime.InteropServices;
using System.IO;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Modelo.Exceptions;
using Aplicacao.Util;
using System.Reflection;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaNota : Form
    {

        private Produto objProduto;
        private FrenteCaixaNota objFrenteCaixaNota;
        private FrenteCaixaNotaItem objFrenteCaixaNotaItem;
        private TabelaPreco objTabelaPreco;
        private Filial objFilial;
        private Pessoa objCliente;
        private Pessoa objVendedor;
        private IList<FrenteCaixaNotaItem> lstFrenteCaixaNotaItemInseridos;
        private Configuracao objConfiguracao;
        private cwkGestao.Modelo.Nota objNota;
        public Boolean bAlteraQuantidade { get; set; }
        private void FormConsultaPreco()
        {
            throw new NotImplementedException();
        }
        public FormFrenteCaixaNota()
        {
            InitializeComponent();

            IniciarVenda();
        }

        private void IniciarVenda()
        {
            objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            bAlteraQuantidade = false;

            objFrenteCaixaNota = new FrenteCaixaNota();
            objFrenteCaixaNota.Codigo = FrenteCaixaNotaController.Instancia.MaxCodigo();
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = new List<FrenteCaixaNotaItem>();

            objFrenteCaixaNotaItem = new FrenteCaixaNotaItem();

            objTabelaPreco = objConfiguracao.TabelaPrecoFrenteCaixa;
            objFilial = objConfiguracao.FilialFrenteCaixa;
            objCliente = new Pessoa();
            objVendedor = new Pessoa();
            lstFrenteCaixaNotaItemInseridos = new List<FrenteCaixaNotaItem>();

            string arquivoExe = Assembly.GetEntryAssembly().Location;
            string caminho = Path.Combine(Path.GetDirectoryName(arquivoExe), "");
            caminho = caminho + "\\LogoEmpresa.jpg";
            if (File.Exists(caminho))
            {
                imagemEmpresa.Image = Bitmap.FromFile(caminho, true);

            }


            if (objVendedor.Nome != null)
            {
                labelControl7.Text = objVendedor.Nome;
            }
            else
            {
                labelControl7.Text = "Padrão";
            }

            if (objCliente.Nome != null)
            {
                labelControl8.Text = objCliente.Nome;
            }
            else
            {
                labelControl8.Text = "Consumidor";
            }

            if (objCliente.CNPJ_CPF != null)
            {
                labelControl9.Text = objCliente.CNPJ_CPF;
            }
            else
            {
                labelControl9.Text = "000.000.000-00";
            }


            InicializarCampos();
        }

        private void InicializarCampos()
        {
            txtQuantidade.EditValue = 1.00;
            txtPreco.EditValue = 0.00;
            txtSubTotal.EditValue = 0.00;
            imagemProduto.Image = Aplicacao.Properties.Resources.ImagemIndisponivel;

            devMemoListaItens.Text = String.Empty;
        }

        private void IncluirProdutoEAtualizarTela(Produto produto)
        {
            if (produto != null)
            {
                objProduto = produto;
                AtualizarDadosTela();

                if (!bAlteraQuantidade)
                {
                    if (IncluirProdutoLista())
                        SetFocusProduto();
                }
            }
            else
                SetFocusProduto();
        }

        private void AtualizarDadosTela()
        {
            txtNomeProduto.EditValue = objProduto.Nome ?? String.Empty;
            lkpProduto.EditValue = objProduto.Barra ?? String.Empty;

            VerificaQtdFracionada();

            if ((Convert.ToDouble(txtQuantidade.EditValue) == 1.0000) &&
                (Convert.ToInt32(txtQuantidade.EditValue) == 0) &&
                (txtQuantidade.EditValue == null) && (Convert.ToDouble(txtQuantidade.EditValue) == 0.0000))
            {
                txtQuantidade.EditValue = 1.0000;
            }
            else
            {
                txtQuantidade.EditValue = txtQuantidade.EditValue;
            }

            objProduto = ProdutoController.Instancia.LoadObjectById(objProduto.ID);
            txtPreco.EditValue = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal);

            if (!String.IsNullOrEmpty(objProduto.CaminhoImagem))
            {
                try
                {
                    imagemProduto.Image = Image.FromFile(objProduto.CaminhoImagem);
                }
                catch (Exception)
                {
                    imagemProduto.Image = Aplicacao.Properties.Resources.ImagemIndisponivel;
                }

            }
        }

        private bool IncluirProdutoLista()
        {
            Boolean bValidaQtdMenorIgualZero = false;
            Boolean bValidaDesconto = false;

            if (objProduto != null)
            {
                bValidaQtdMenorIgualZero = ValidaQtdMenorIgualZero();
                if (bValidaQtdMenorIgualZero)
                {
                    bValidaDesconto = ValidaDesconto();

                    if (bValidaQtdMenorIgualZero && bValidaDesconto)
                    {
                        objFrenteCaixaNotaItem = MontaObjetoFrenteCaixaItem();

                        ImprimirItemCupomTela(objFrenteCaixaNotaItem);
                        imagemProduto.Image = Aplicacao.Properties.Resources.ImagemIndisponivel;
                    }
                }
            }

            LimparCamposProduto();

            return bValidaQtdMenorIgualZero && bValidaDesconto;
        }

        private bool ValidaQtdMenorIgualZero()
        {
            if (Convert.ToDecimal(txtQuantidade.EditValue) <= 0)
            {
                MessageBox.Show(@"A quantidade deve ser maior do que zero" + Environment.NewLine
                                + "Verifique.", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private bool ValidaDesconto()
        {
            var precoMinimo = CalculaPrecoMinimo(objProduto);
            var valorComDesconto = GetPreco();
            if (valorComDesconto < precoMinimo && !(UsuarioEhGerente() || RequisitaGerente()))
            {
                MessageBox.Show(@"Desconto não autorizado" + Environment.NewLine + "Verifique.",
                                @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private static bool UsuarioEhGerente()
        {
            return cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2;
        }

        private bool RequisitaGerente()
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
            {
                objFrenteCaixaNota.GerenteDesconto = cwkControleUsuario.Facade.UltimoLoginGerente;
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }
            else
            {
                objFrenteCaixaNota.GerenteDesconto = String.Empty;
                return false;
            }
        }

        private FrenteCaixaNotaItem MontaObjetoFrenteCaixaItem()
        {
            FrenteCaixaNotaItem objFrenteCaixaNotaItem = new FrenteCaixaNotaItem();

            objFrenteCaixaNotaItem.Produto = objProduto;
            objFrenteCaixaNotaItem.Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
            objFrenteCaixaNotaItem.Sequencia = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count() + 1;
            objFrenteCaixaNotaItem.Gerente = String.Empty;
            objFrenteCaixaNotaItem.PercDesconto = Convert.ToDecimal(txtPercDesconto.EditValue ?? 0);

            objFrenteCaixaNotaItem.ValorCalculado =
                ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal);

            objFrenteCaixaNotaItem.Valor = GetPreco();
            objFrenteCaixaNotaItem.Total = objFrenteCaixaNotaItem.Quantidade * objFrenteCaixaNotaItem.Valor;
            objFrenteCaixaNotaItem.FrenteCaixaNota = objFrenteCaixaNota;

            lstFrenteCaixaNotaItemInseridos.Add(objFrenteCaixaNotaItem);
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos;

            txtSubTotal.EditValue = GetTotalVenda();

            return objFrenteCaixaNotaItem;
        }



        private decimal CalculaPrecoMinimo(Produto produto)
        {
            var tabelaPrecoProduto = ProdutoController.Instancia.GetTabelaPrecoProduto(produto, objTabelaPreco);
            if (tabelaPrecoProduto != null)
                return Math.Round(ProdutoController.Instancia.getPreco(produto.PrecoBase, tabelaPrecoProduto.MargemLucro,
                    tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Mínimo));
            return 0;
        }

        private void VerificaQtdFracionada()
        {
            if (objProduto.Unidade.BQtdFracionada)
                txtQuantidade.Properties.Mask.EditMask = "N4";
            else
                txtQuantidade.Properties.Mask.EditMask = "N0";
        }

        private void SetFocusProduto()
        {
            objProduto = null;
            bAlteraQuantidade = true;
            lkpProduto.EditValue = string.Empty;
            lkpProduto.Focus();
        }

        private decimal GetPreco()
        {
            var preco = Convert.ToDecimal(txtPreco.EditValue);
            return preco * (1 - (Convert.ToDecimal(txtPercDesconto.EditValue) / 100));
        }

        private void AtualizarCupomTela()
        {
            String cabecalho =
                FrenteCaixaNota.GetCabecalhoCupom(objFilial, objCliente, objVendedor);
            String corpoCupom = String.Join("", lstFrenteCaixaNotaItemInseridos);

            devMemoListaItens.Text = cabecalho + corpoCupom;

            txtSubTotal.EditValue = GetTotalVenda();
        }

        private void ImprimirItemCupomTela(FrenteCaixaNotaItem objFrenteCaixaNotaItem)
        {
            if (objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count == 1)
                devMemoListaItens.Text =
                    FrenteCaixaNota.GetCabecalhoCupom(objFilial, objCliente, objVendedor);

            devMemoListaItens.Text += objFrenteCaixaNotaItem;
        }

        private decimal GetTotalVenda()
        {
            objFrenteCaixaNota.TotalProdutos = lstFrenteCaixaNotaItemInseridos == null ? 0 : lstFrenteCaixaNotaItemInseridos.Sum(v => v.Total);
            objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos;

            return objFrenteCaixaNota.TotalGeral;
        }

        private void LimparCamposProduto()
        {
            lkpProduto.EditValue = "";
            txtNomeProduto.EditValue = "";
            txtQuantidade.EditValue = 0;
            txtPreco.EditValue = 0;
            txtPercDesconto.EditValue = 0.00;
            imagemProduto.Image = Aplicacao.Properties.Resources.ImagemIndisponivel;
        }

        private void FormFrenteCaixaNota_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    bAlteraQuantidade = true;
                    txtQuantidade.Focus();
                    break;
                case Keys.F3:
                    FuncaoDescartarUltimoItem();
                    break;
                case Keys.F4:
                    ConsultaPreco();
                    break;
                case Keys.F5:
                    CarregarProdutos();
                    break;
                case Keys.F6:
                    CPFCaixa();
                    break;
                case Keys.F7:
                    CarregarClientes();
                    break;
                case Keys.F8:
                    CarregarVendedores();
                    break;
                case Keys.F12:
                    FuncaoFinalizarVenda();
                    break;
            }
        }

        #region FinalizarVenda

        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            FuncaoFinalizarVenda();
        }

        private void FuncaoFinalizarVenda()
        {
            if (FinalizarVenda())
            {
                IniciarVenda();
                lkpProduto.Focus();
            }
        }

        private bool FinalizarVenda()
        {
            if (PodeFinalizar())
            {
                var form = new FormFinalizarVendaFrenteCaixa(objFrenteCaixaNota);
                form.ShowDialog();
                return form.Finalizou;
            }
            else
                MessageBox.Show("Insira produtos antes de finalizar a venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

        private bool PodeFinalizar()
        {
            return objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count > 0;
        }

        #endregion

        #region DescartarUltimoItem

        private void sbDescartar_Click(object sender, EventArgs e)
        {
            FuncaoDescartarUltimoItem();
        }

        private void FuncaoDescartarUltimoItem()
        {
            if ((PossuiItensParaDescartar()) && (EhParaDescartar()))
            {
                DescartarItem(ref objFrenteCaixaNotaItem, lstFrenteCaixaNotaItemInseridos);
                AtualizarCupomTela();
            }
        }

        private void DescartarItem(ref FrenteCaixaNotaItem objFrenteCaixaNotaItem, IList<FrenteCaixaNotaItem> lstFrenteCaixaNotaItemInseridos)
        {
            if (lstFrenteCaixaNotaItemInseridos.Contains(objFrenteCaixaNotaItem))
            {
                lstFrenteCaixaNotaItemInseridos.Remove(objFrenteCaixaNotaItem);
                objFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos != null ? lstFrenteCaixaNotaItemInseridos.LastOrDefault() : new FrenteCaixaNotaItem();
            }
        }

        private bool PossuiItensParaDescartar()
        {
            Boolean bPossuiItens = ((lstFrenteCaixaNotaItemInseridos != null) && (lstFrenteCaixaNotaItemInseridos.Count > 0));

            if (!bPossuiItens)
            {
                MessageBox.Show("Não existem itens incluídos para descartar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return bPossuiItens;
        }

        private bool EhParaDescartar()
        {
            return MessageBox.Show("Deseja descartar o último item", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        #endregion

        #region Eventos

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            IList<Produto> produtos = ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList();
            GridProdutoGen grid = new GridProdutoGen(produtos, null, true, false, typeof(FormProduto));
            grid.Selecionando = true;

            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                objProduto = ProdutoController.Instancia.LoadObjectById(grid.Selecionado.ID);
                IncluirProdutoEAtualizarTela(objProduto);
            }
        }

        private void sbCliente_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            IList<Pessoa> pessoas = PessoaController.Instancia.GetAllClientes();
            GridCliente grid = new GridCliente(pessoas, new FormPessoa(), objFrenteCaixaNota.Pessoa, "Cliente", false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            Pessoa pessoaSelecionada = ((Pessoa)grid.Selecionado) ?? new Pessoa();
            if (pessoaSelecionada != null)
            {
                if (pessoaSelecionada.BAtivo)
                {
                    objFrenteCaixaNota.Pessoa = objCliente = PessoaController.Instancia.LoadObjectById(grid.Selecionado.ID);
                    if ((objFrenteCaixaNota.Vendedor == null) && (objFrenteCaixaNota.Pessoa.GetCliente.Vendedor != null))
                    {
                        PessoaCliente objPessoaCliente = objFrenteCaixaNota.Pessoa.GetCliente;
                        if ((objPessoaCliente != null) && (objPessoaCliente.BBloqueiaVendedor))
                        {
                            objFrenteCaixaNota.Vendedor = objVendedor = PessoaController.Instancia.LoadObjectById(objPessoaCliente.Vendedor.ID);
                        }
                    }
                    labelControl8.Text = objCliente.Nome;
                    labelControl9.Text = objCliente.CNPJ_CPF;

                    AtualizarCupomTela();
                }
                else
                {
                    MessageBox.Show("Pessoa com cadastro inativo. Por favor verifique.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void sbVendedor_Click(object sender, EventArgs e)
        {
            CarregarVendedores();
        }

        private void CarregarVendedores()
        {
            IList<Pessoa> vendedores = PessoaController.Instancia.GetAllVendedores();
            GridCliente grid = new GridCliente(vendedores, null, "Vendedor", false, typeof(FormPessoa));
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                objFrenteCaixaNota.Vendedor = objVendedor = PessoaController.Instancia.LoadObjectById(grid.Selecionado.ID);
                labelControl7.Text = objVendedor.Nome;
            }

            AtualizarCupomTela();
        }

        private void devMemoListaItens_EditValueChanged(object sender, EventArgs e)
        {
            devMemoListaItens.Select(devMemoListaItens.Text.Length, devMemoListaItens.Text.Length);
            devMemoListaItens.ScrollToCaret();
        }
        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            if (lkpProduto.EditValue != null)
            {
                IncluirProdutoLista();
            }
            SetFocusProduto();
        }

        private void lkpProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(lkpProduto.Text))
                {
                    objProduto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(lkpProduto.Text);

                    if ((objProduto == null) || (objProduto == new Produto()))
                    {
                        MessageBox.Show("Produto inexistente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lkpProduto.EditValue = null;
                        lkpProduto.Focus();

                        return;
                    }

                    if (objProduto.Inativo)
                    {
                        MessageBox.Show("Este produto está inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lkpProduto.EditValue = null;
                        lkpProduto.Focus();

                        return;
                    }

                    IncluirProdutoEAtualizarTela(objProduto);
                }
                else
                {
                    objProduto = null;
                    return;
                }
            }
            catch (ApplicationException)
            {

            }
        }

        #endregion

        private void SbQuantidade_Click(object sender, EventArgs e)
        {
            bAlteraQuantidade = true;
            txtQuantidade.Focus();
        }

        private void ConsultaPreco()
        {
            FormConsultaPreco ConsultaPreco = new FormConsultaPreco();
            ConsultaPreco.ShowDialog();
        }
        private void CPFCaixa()
        {
            FormCPFCaixa CPFCaixa = new FormCPFCaixa();
            CPFCaixa.ShowDialog();
            objCliente.CNPJ_CPF = CPFCaixa.pessoaCPF;
            labelControl9.Text = objCliente.CNPJ_CPF;
        }


        private void sbPreco_Click(object sender, EventArgs e)
        {
            ConsultaPreco();
        }

        private void sbCPF_Click(object sender, EventArgs e)
        {
            CPFCaixa();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        public static string nullString(object str)
        {
            if (Convert.ToString(str) == null)
            {
                return "";
            }
            else
            {
                return Convert.ToString(str);
            }
        }
        private void FormFrenteCaixaNota_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void imagemProduto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_Leave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }
        //private void lkpDescricao_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!String.IsNullOrEmpty(lkpDescricao.Text))
        //        {
        //            objProduto = ProdutoController.Instancia.FindByDescricao(lkpDescricao.Text);

        //            if ((objProduto == null) || (objProduto == new Produto()))
        //            {
        //                MessageBox.Show("Produto inexistente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                lkpDescricao.EditValue = null;
        //                lkpDescricao.Focus();

        //                return;
        //            }

        //            if (objProduto.Inativo)
        //            {
        //                MessageBox.Show("Este produto está inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                lkpDescricao.EditValue = null;
        //                lkpDescricao.Focus();

        //                return;
        //            }

        //            IncluirProdutoEAtualizarTela(objProduto);
        //        }
        //        else
        //        {
        //            objProduto = null;
        //            return;
        //        }
        //    }
        //    catch (ApplicationException)
        //    {

        //    }
        //}
    }
}