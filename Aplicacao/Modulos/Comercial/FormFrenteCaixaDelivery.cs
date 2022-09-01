using Aplicacao.Modulos.Comercial.ControlUser;
using Aplicacao.Modulos.Comercial.Impressao;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DBUtils.Classes;
using DevExpress.PivotGrid.Printing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaDelivery : Form
    {
        private class CompareGrupo1 : IEqualityComparer<Grupo1>
        {
            public bool Equals(Grupo1 a, Grupo1 b)
            {
                return a?.ID == b?.ID;
            }

            public int GetHashCode(Grupo1 obj)
            {
                return 0; // obj?.ID;
            }
        }

        private Pessoa Cliente { get; set; }
        private DataTable Itens = null;
        private FluxoCaixa FluxoCorrente = null;
        private IniFile ArquivoIni;
        private int Serie;

        private Configuracao objConfiguracao { get { return ConfiguracaoController.Instancia.GetConfiguracao(); } }

        private string CaminhoIni
        {
            get
            {
                return Debugger.IsAttached ?
                    $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini" :
                    $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";
            }
        }

        public FormFrenteCaixaDelivery()
        {
            InitializeComponent();
            Init();

            if ("1".Equals(ArquivoIni.GetValue("Configuracoes_PDV", "MAXIMIZADO", "0")))
            {
                //WindowState = FormWindowState.Maximized;

                Location = new Point(0, 0);
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;

                Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Bounds = Screen.PrimaryScreen.Bounds;
                ControlBox = false;
            }

            FluxoCorrente = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(Modelo.cwkGlobal.objUsuarioLogado.Id);

            AdicionarGrupos();
            InitCliente();
            InitGrid();
            AtualizarTotais();

            LBLRemovercliente.Enabled = false;
            CarregarProdutosPorGrupo(new Grupo1 { ID = -1, Nome = "SEM CATEGORIA" });
        }

        private void Init()
        {
            ArquivoIni = new IniFile(CaminhoIni);
            Serie = Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1"));
        }

        private bool VerificaAberturaCaixa()
        {
            FluxoCorrente = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(Modelo.cwkGlobal.objUsuarioLogado.Id);
            if (FluxoCorrente == null)
            {
                if (AbrirCaixa())
                {
                    FluxoCorrente = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(Modelo.cwkGlobal.objUsuarioLogado.Id);
                    return true;
                }
                return false;
            }
            return true;
        }

        private bool AbrirCaixa()
        {
            var FormAbertura = new FormFrenteCaixaAbrirCaixa();
            FormAbertura.ShowDialog();
            return FormAbertura.AbriuCaixa;
        }

        private void FecharCaixa()
        {
            FormFrenteCaixaFecharCaixa Fechar = new FormFrenteCaixaFecharCaixa(FluxoCorrente);
            Fechar.ShowDialog();
            if (Fechar.Fechou)
            {
                DialogResult dr = MessageBox.Show("Deseja Imprimir o Relatório de Fluxo de Caixa?", "IMPRESSÃO DO FLUXO DE CAIXA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    XRReportFluxoCaixa RelatorioFluxoCaixa = new XRReportFluxoCaixa(FluxoCorrente);
                    ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);
                    tool.ShowPreviewDialog();
                }

                if (!VerificaAberturaCaixa())
                    Close();
            }
        }

        private void SangrarCaixa()
        {
            var Sangria = new FormFrenteCaixaSangriaCaixa(FluxoCorrente);
            Sangria.ShowDialog();
        }

        private void SuprimentoCaixa()
        {
            var Suprimento = new FormFrenteCaixaSuprimentoCaixa(FluxoCorrente);
            Suprimento.ShowDialog();
        }

        private void AdicionarGrupos()
        {
            GroupPanel_Categorias.Controls.Clear();
            var Grupos = ProdutoController.Instancia.GetGrupos1Produto()?.Distinct(new CompareGrupo1());
            if (Grupos != null)
            {
                GroupPanel_Categorias.Controls.Add(new UC_GrupoProduto(new cwkGestao.Modelo.Grupo1 { ID = -1, Nome = "SEM CATEGORIA" }));

                foreach (var G in Grupos)
                    GroupPanel_Categorias.Controls.Add(new UC_GrupoProduto(G));
            }
        }

        private void InitCliente()
        {
            Cliente = null;
            TXT_Cliente.Text = "<Cliente Não Informado>";
        }

        public void CarregarProdutosPorGrupo(Grupo1 Grupo)
        {
            GroupPanel_Produtos.Controls.Clear();
            if (Grupo == null)
                return;

            groupBox3.Text = $"PRODUTOS DA CATEGORIA - [{Grupo.Nome}]";

            IList<Produto> Produtos = ProdutoController.Instancia.GetProdutosPorGrupo1(Grupo.ID);

            var lQuery = Produtos?.Where(o => (o.Codigo ?? "").ToUpper().Contains(TXT_Produto.Text.ToUpper()) ||
                                              (o.Barra ?? "").ToUpper().Contains(TXT_Produto.Text.ToUpper()) ||
                                              (o.Nome ?? "").ToUpper().Contains(TXT_Produto.Text.ToUpper()));

            foreach (var Prod in lQuery)
            {
                Prod.PrecoBase = ProdutoController.Instancia.getPreco(Prod, objConfiguracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal);
                if (Prod.PrecoBase == 0)
                    continue;

                GroupPanel_Produtos.Controls.Add(new UC_Produto(Prod));
            }

            VerificarItensJaAdicionados();
        }

        public void AdicionarProduto(Produto P, decimal? Quantidade, decimal? Valor)
        {
            DataRow dr = Itens.NewRow();
            dr["Guid"] = Guid.NewGuid();

            if (!Quantidade.HasValue && !Valor.HasValue)
            {
                FormFrenteCaixaDeliveryDadosProduto A = new FormFrenteCaixaDeliveryDadosProduto(dr["Guid"].ToString(), P.ID, P.Nome, 1, P.PrecoBase);
                A.ShowDialog(this);
                if (!A.Salvou)
                    return;

                Quantidade = A.Quantidade;
                Valor = A.Valor;
            }

            dr["IDProduto"] = P.ID;
            dr["CodigoItem"] = P.Codigo;
            dr["DescricaoItem"] = P.Nome;
            dr["Quantidade"] = Quantidade;
            dr["ValorUnitarioItem"] = Valor;
            dr["ValorTotalItem"] = Quantidade * Valor;
            Itens.Rows.Add(dr);

            ovGRD_Itens.DataSource = Itens;
            ovGRD_Itens.Refresh();

            AtualizarTotais();

            TXT_Produto.Text = string.Empty;
            PesquisarProdutoCategoria();
        }

        private void ChamaDadosCliente()
        {
            // Dados do Cliente
            var FormCliente = new FormFrenteCaixaDeliveryDadosCliente();
            FormCliente.ShowDialog(this);

            // e agora?
            if (FormCliente.PedidoSelecioando != null)
            {
                CancelarVenda(false);

                foreach (var Item in FormCliente.PedidoSelecioando.Items)
                    AdicionarProduto(Item.Produto, Item.Quantidade, Item.Valor);

                TXT_Cliente.Text = $"Cliente: {FormCliente.PessoaRetornar.Nome}";
                Cliente = FormCliente.PessoaRetornar;
                LBLRemovercliente.ForeColor = Color.Red;
                LBLRemovercliente.Enabled = true;
            }
            else
            {
                if (FormCliente.PessoaRetornar != null)
                {
                    TXT_Cliente.Text = $"Cliente: {FormCliente.PessoaRetornar.Nome}";
                    Cliente = FormCliente.PessoaRetornar;
                    LBLRemovercliente.ForeColor = Color.Red;
                    LBLRemovercliente.Enabled = true;
                }
                else
                {
                    if (FormCliente.PessoaRetornar == null && Cliente != null)
                        return;

                    Cliente = null;
                    TXT_Cliente.Text = "<Cliente Não Informado>";
                    LBLRemovercliente.ForeColor = Color.Gray;
                    LBLRemovercliente.Enabled = false;
                }
            }
        }

        private void simpleButton5_Click(object sender, System.EventArgs e)
        {
            ChamaDadosCliente();
        }

        private void TXT_Cliente_Click(object sender, System.EventArgs e)
        {
            // Abrir os Dados do Cliente...
            if (Cliente == null)
                return;

            var Form = new FormPessoaDelivery(Cliente);
            Form.ShowDialog(this);
            if (Form.Selecionado != null)
                TXT_Cliente.Text = $"Cliente: {Form.Selecionado.Nome}";
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            Cliente = null;
            TXT_Cliente.Text = "<Cliente Não Informado>";
            LBLRemovercliente.ForeColor = Color.Gray;
            LBLRemovercliente.Enabled = false;
        }

        private void simpleButton2_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a Venda?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            CancelarVenda(true);
        }

        private void CancelarVenda(bool CarregarGrupos)
        {
            // Cancelar Venda
            LimparItens();

            Cliente = null;
            TXT_Cliente.Text = "<Cliente Não Informado>";
            LBLRemovercliente.ForeColor = Color.Gray;
            LBLRemovercliente.Enabled = false;

            if (CarregarGrupos)
                CarregarProdutosPorGrupo(new Grupo1 { ID = -1, Nome = "SEM CATEGORIA" });

            Itens.Clear();
            AtualizarTotais();
        }

        private void LimparItens()
        {
            AtualizarTotais();
        }

        private void RemoverItem()
        {

            AtualizarTotais();
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Guid");
            dt.Columns.Add("IDProduto");
            dt.Columns.Add("CodigoItem");
            dt.Columns.Add("DescricaoItem");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("ValorUnitarioItem");
            dt.Columns.Add("ValorTotalItem");
            return dt;
        }

        private void InitGrid()
        {
            Itens = CreateDataTable();

            ovGRD_Itens.DataSource = Itens;
            ovGRD_Itens.Refresh();

            AjustaHeaderItens();
        }

        private void AjustaHeaderItens()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Open Sans", 11, FontStyle.Regular);
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (DataGridViewColumn column in ovGRD_Itens.Columns)
            {
                switch (column.Name)
                {
                    case "CodigoItem":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "CÓDIGO";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "DescricaoItem":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.43);
                        column.HeaderText = "DESCRIÇÃO DO ITEM";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Quantidade":
                        column.DisplayIndex = 2;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.12);
                        column.HeaderText = "QUANTIDADE";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "ValorUnitarioItem":
                        column.DisplayIndex = 3;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "VLR. UNIT. (R$)";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "ValorTotalItem":
                        column.DisplayIndex = 4;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "VLR. TOTAL (R$)";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        column.DisplayIndex = 0;
                        column.Visible = false;
                        break;
                }
            }
        }
        private void ovGRD_Itens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (ovGRD_Itens.Columns[e.ColumnIndex].Name)
            {
                case "ValorUnitarioItem":
                case "ValorTotalItem":
                    e.Value = Convert.ToDecimal(e.Value).ToString("n2");
                    break;
                case "Quantidade":
                    e.Value = Convert.ToDecimal(e.Value).ToString("n4");
                    break;
            }
        }

        private void AtualizarTotais()
        {
            var lQuery = Itens.AsEnumerable().Where(o => o.RowState != DataRowState.Deleted);

            TXT_QuantidadeItens.Text = $"{lQuery.Count()} Itens";
            TXT_ValorTotal.Text = lQuery.Sum(o => Convert.ToDecimal(o["VALORTOTALITEM"])).ToString("c2");

            VerificarItensJaAdicionados();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ovGRD_Itens.CurrentRow == null)
                return;

            string Guid = (ovGRD_Itens.CurrentRow.DataBoundItem as DataRowView)["GUID"].ToString();
            Itens.DefaultView.RowFilter = $"[GUID] = '{Guid}'";
            Itens.DefaultView[0].Delete();
            Itens.DefaultView.RowFilter = string.Empty;

            ovGRD_Itens.DataSource = Itens;
            ovGRD_Itens.Refresh();

            AtualizarTotais();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Editar Item
            if (ovGRD_Itens.CurrentRow == null)
                return;

            string Guid = (ovGRD_Itens.CurrentRow.DataBoundItem as DataRowView)["GUID"].ToString();

            ovGRD_Itens.DataSource = Itens.Copy();
            ovGRD_Itens.Refresh();

            Itens.DefaultView.RowFilter = $"[GUID] = '{Guid}'";
            if (Itens.DefaultView.Count != 1)
                return;

            FormFrenteCaixaDeliveryDadosProduto A = new FormFrenteCaixaDeliveryDadosProduto(Itens.DefaultView[0]["Guid"].ToString(),
                                                                                            Convert.ToInt32(Itens.DefaultView[0]["IDProduto"]),
                                                                                            Itens.DefaultView[0]["DescricaoItem"].ToString(),
                                                                                            Convert.ToDecimal(Itens.DefaultView[0]["Quantidade"]),
                                                                                            Convert.ToDecimal(Itens.DefaultView[0]["ValorUnitarioItem"]));
            A.ShowDialog(this);
            if (!A.Salvou)
                return;

            Itens.DefaultView[0]["Quantidade"] = A.Quantidade;
            Itens.DefaultView[0]["ValorUnitarioItem"] = A.Valor;
            Itens.DefaultView[0]["ValorTotalItem"] = A.Quantidade * A.Valor;

            Itens.DefaultView.RowFilter = string.Empty;
            ovGRD_Itens.DataSource = Itens;
            ovGRD_Itens.Refresh();

            AtualizarTotais();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PesquisarProdutoCategoria();
        }

        private void PesquisarProdutoCategoria()
        {
            string Descricao = TXT_Produto.Text;

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarGrupos();
                CarregarProdutosPorGrupo(new Grupo1 { ID = -1, Nome = "SEM CATEGORIA" });
            }
            else
            {
                IList<Produto> Produtos = ProdutoController.Instancia.GetProdutosFiltroDelivery(Descricao);
                var ProdutosComGrupo = Produtos.Where(o => o.Grupo1 != null);

                foreach (var Prod in ProdutosComGrupo)
                {
                    Prod.PrecoBase = ProdutoController.Instancia.getPreco(Prod, objConfiguracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal);
                    if (Prod.PrecoBase == 0)
                        continue;
                }
                ProdutosComGrupo = ProdutosComGrupo.Where(o => o.PrecoBase != 0);

                var ProdutosSemGrupo = Produtos.Where(o => o.Grupo1 == null);
                foreach (var Prod in ProdutosSemGrupo)
                {
                    Prod.PrecoBase = ProdutoController.Instancia.getPreco(Prod, objConfiguracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal);
                    if (Prod.PrecoBase == 0)
                        continue;
                }
                ProdutosSemGrupo = ProdutosSemGrupo.Where(o => o.PrecoBase != 0);


                /* Adicionando as Categorias */
                GroupPanel_Categorias.Controls.Clear();
                GroupPanel_Categorias.Controls.Add(new UC_GrupoProduto(new cwkGestao.Modelo.Grupo1 { ID = -1, Nome = "SEM CATEGORIA" }));
                if (ProdutosComGrupo?.Count() > 0)
                {
                    foreach (var G in ProdutosComGrupo.Select(o => o.Grupo1).Distinct(new CompareGrupo1()))
                        GroupPanel_Categorias.Controls.Add(new UC_GrupoProduto(G));
                }

                /* Adicionando os Produtos */
                if (ProdutosSemGrupo?.Count() > 0)
                    CarregarProdutosPorGrupo(new Grupo1 { ID = -1, Nome = "SEM CATEGORIA" });
                else
                    CarregarProdutosPorGrupo(ProdutosComGrupo.FirstOrDefault()?.Grupo1);
            }
        }
        private void TXT_Produto_Leave(object sender, EventArgs e)
        {
            PesquisarProdutoCategoria();
        }

        public void VerificarItensJaAdicionados()
        {
            using (var _Itens = Itens?.Copy())
            {
                foreach (UC_Produto UCProd in GroupPanel_Produtos.Controls)
                {
                    UCProd.ColocaCorNormal();
                    if (_Itens.AsEnumerable().Where(o => o.RowState != DataRowState.Deleted && Convert.ToInt32(o["IDProduto"]) == UCProd.p.ID)?.Count() > 0)
                        UCProd.ProdutoSelecionado();
                }
            }
        }
        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            fn_FinalizarVenda();
        }

        private void fn_FinalizarVenda()
        {
            if (Itens.AsEnumerable().Where(o => o.RowState != DataRowState.Deleted).Count() == 0)
            {
                MessageBox.Show("Insira produtos antes de finalizar a venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cliente == null)
            {
                MessageBox.Show("Informe o cliente antes de finalizar a venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Finalizar a Venda
            FrenteCaixaNota objFrenteCaixaNota = new FrenteCaixaNota();
            objFrenteCaixaNota.Codigo = NotaController.Instancia.GetNovoCodigoFrenteCaixaNota();
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = new List<FrenteCaixaNotaItem>();
            objFrenteCaixaNota.Pessoa = Cliente;

            foreach (DataRow Item in Itens.Rows)
            {
                if (Item.RowState == DataRowState.Deleted)
                    continue;

                FrenteCaixaNotaItem ItemNota = new FrenteCaixaNotaItem();
                ItemNota.Produto = ProdutoController.Instancia.GetAll().Where(o => o.ID == Convert.ToInt32(Item["IDProduto"])).FirstOrDefault();
                ItemNota.Quantidade = Convert.ToDecimal(Item["Quantidade"]);
                ItemNota.Sequencia = 1 + objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count;
                ItemNota.Gerente = string.Empty;
                ItemNota.PercDesconto = 0;

                ItemNota.ValorCalculado = Convert.ToDecimal(Item["ValorUnitarioItem"]);
                ItemNota.Valor = Convert.ToDecimal(Item["ValorUnitarioItem"]);
                ItemNota.Total = ItemNota.Quantidade * ItemNota.Valor;

                ItemNota.FrenteCaixaNota = objFrenteCaixaNota;
                objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Add(ItemNota);
            }

            objFrenteCaixaNota.TotalProdutos = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Total);
            objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos;

            if (Cliente != null)
                Cliente = PessoaController.Instancia.GetPessoa(Cliente.ID);

            var Form = new FormFrenteCaixaDeliveryFinalizar(objFrenteCaixaNota, Serie, FluxoCorrente, Cliente);
            Form.ShowDialog(this);

            if (Form.Finalizou)
                IniciarNovaVenda();
        }
        private void IniciarNovaVenda()
        {
            InitCliente();
            InitGrid();
            AtualizarTotais();

            LBLRemovercliente.Enabled = false;
            CarregarProdutosPorGrupo(new Grupo1 { ID = -1, Nome = "SEM CATEGORIA" });
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F5:
                    CarregarProdutos();
                    break;
                case Keys.F10:
                    if (FluxoCorrente != null)
                        MessageBox.Show("O Fluxo de caixa já está aberto, feche o fluxo atual para abrir outro.", "ATENÇÃO!", MessageBoxButtons.OK);
                    else
                        AbrirCaixa();
                    break;
                case Keys.F11:
                    FecharCaixa();
                    break;
                case (Keys.Control | Keys.F10):
                    SangrarCaixa();
                    break;
                case (Keys.Control | Keys.F11):
                    SuprimentoCaixa();
                    break;
                case Keys.F12:
                    fn_FinalizarVenda();
                    break;
                case (Keys.Control | Keys.M):
                    AbrirMonitor();
                    break;
                case (Keys.Control | Keys.S):
                    Sair();
                    break;
                case (Keys.Control | Keys.P):
                    AbrirPDV();
                    break;
                //case (Keys.Control | Keys.F12):
                //    FinalizaDelivery();
                //    break;
            }
            return base.ProcessDialogKey(keyData);
        }


        //private void FinalizaDelivery()
        //{
        //    Close();
        //    var form = new FormFrenteCaixaDeliveryFinalizar();
        //    form.ShowDialog(this);
        //}



        private void AbrirPDV()
        {
            Close();
            var form = new FormFrenteCaixaNota();
            form.ShowDialog(this);
            //Show();
        }

        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do Delivery?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void AbrirMonitor()
        {
            var Form = new FormFrenteCaixaDeliveryMonitor();
            Form.ShowDialog(this);
        }

        private void FormFrenteCaixaDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Itens?.AsEnumerable().Where(o => o.RowState != DataRowState.Deleted).Count() > 0)
                if (MessageBox.Show("Deseja encerrar e cancelar a venda?", "MENSAGEM", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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
                var objProduto = ProdutoController.Instancia.LoadObjectById(grid.Selecionado.ID);
                var Preco = ProdutoController.Instancia.getPreco(objProduto, objConfiguracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal);

                if (Preco == 0)
                {
                    MessageBox.Show("O preço do produto não pode ser menor ou igual a zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                AdicionarProduto(objProduto, 1, Preco);
            }
        }

        private void FormFrenteCaixaDelivery_Shown(object sender, EventArgs e)
        {
            if (1 == objConfiguracao.AbrirTelaDadosClienteDelivery)
                ChamaDadosCliente();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Delivery?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}