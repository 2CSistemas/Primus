using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using DevExpress.XtraGrid;
using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Base;
using cwkGestao.Modelo.Exceptions;
using Modelo.ModeloProxy;

namespace Aplicacao
{
    public partial class GridOrcamentoNewLinq : Form
    {
        Modelo.DataClassesDataContext db;

        public string filtro = "";
        String tabela;
        //IQueryable lista;
        List<pxyPedido> lista;
        bool bSelecionar;
        string retorno = String.Empty;
        public bool atualiza;
        int? id;
        Modelo.InOutType tipo;
        List<int> ListaMultiSelect;
        private string arquivo;
        private decimal desconto;
        private Modelo.Configuracao objCfg;

        Modelo.Pedido objPedido = new Modelo.Pedido();
        BLL.Pedido bllPedido;
        BLL.Nota bllNota;
        cwkGestao.Negocio.NotaController notaController = cwkGestao.Negocio.NotaController.Instancia;
        cwkGestao.Negocio.PessoaController pessoaController = cwkGestao.Negocio.PessoaController.Instancia;

        public string Retorno
        {
            get { return this.retorno; }
        }

        public GridOrcamentoNewLinq(String pTabela, bool pSelecionar, int? pID, Modelo.InOutType pTipo)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "Grid" + pTabela + "_" + pTipo.ToString();

            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            this.db = new Modelo.DataClassesDataContext();
            tipo = pTipo;
            ListaMultiSelect = new List<int>();

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
            bllPedido = new BLL.Pedido(db);
            bllNota = new BLL.Nota(db);
            lista = new List<pxyPedido>();

            objCfg = Modelo.Configuracao.GetConfiguracao(db);
            if (tipo == Modelo.InOutType.Saída && objCfg.UtilizarFichaTecnica)
            {
                sbGerarOrdemProducao.Visible = true;
                sbConsultarProducao.Visible = true;
            }
            objCfg = (from c in db.Configuracaos
                      select c).Single();
        }

        private void GridOrcamentoNew_Load(object sender, EventArgs e)
        {
            if (tipo == Modelo.InOutType.Entrada)
            {
                this.Text = "Tabela de Orçamento de Compra";
                sbFaturar.Enabled = false;
            }
            else
            {
                this.Text = "Tabela de Orçamento de Venda";
            }

            CarregarGrid("Codigo", 0, "");
            btSelecionar.Visible = bSelecionar;

            if (bSelecionar == true && this.id != null)
            {
                atualiza = false;
                txtLocalizar.Text = this.id.ToString();
                dataGridView1.FocusedRowHandle = dataGridView1.LocateByDisplayText(0, dataGridView1.Columns.ColumnByFieldName("ID"), txtLocalizar.Text);
                dataGridView1.SelectRow(dataGridView1.FocusedRowHandle);
            }

            if (File.Exists("PadraoCorSistema.xml"))
            {
                dataGridView1.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }

            //Carrega a configuração da última tela
            if (File.Exists("Telas\\" + arquivo + ".xml"))
                dataGridView1.RestoreLayoutFromXml("Telas\\" + arquivo + ".xml");
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
            SelecionaRegistro();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.GetFocusedRow() == null)
            {
                CarregarGrid(dataGridView1.SortedColumns.View.FocusedColumn.FieldName, 0, ChamaFiltro());
            }
            else
            {
                CarregarGrid(dataGridView1.SortedColumns.View.FocusedColumn.FieldName, dataGridView1.FocusedRowHandle, ChamaFiltro());
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(1, 0);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(2, RegistroSelecionado());
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(3, RegistroSelecionado());
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(4, RegistroSelecionado());
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            //Fecha a tela
            retorno = "";
            //this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Método para carregar o Grid
        /// </summary>
        /// <param name="pSort">Coluna para ordenação</param>
        /// <param name="posicao">Posição do registro no DataGridView</param>
        /// <param name="pFiltro">Texto para filtro em todas os campos do objeto do linq</param>
        public void CarregarGrid(string pSort, int posicao, String pFiltro)
        {
            try
            {
                gridControl1.DataSource = MontaLista(pFiltro);

                dataGridView1.OptionsView.ColumnAutoWidth = false;
                dataGridView1.OptionsView.ShowFooter = true;

                dataGridView1.Columns["ID"].Visible = false;

                dataGridView1.Columns["Codigo"].Caption = "Código";
                dataGridView1.Columns["Codigo"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Codigo"].Width = 80;
                dataGridView1.Columns["Codigo"].VisibleIndex = 0;

                dataGridView1.Columns["Data"].Caption = "Data";
                dataGridView1.Columns["Data"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Data"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Data"].Width = 80;
                dataGridView1.Columns["Data"].VisibleIndex = 1;

                dataGridView1.Columns["Digitacao"].Caption = "Digitação";
                dataGridView1.Columns["Digitacao"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Digitacao"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Digitacao"].Width = 80;
                dataGridView1.Columns["Digitacao"].VisibleIndex = 2;

                dataGridView1.Columns["Status"].Caption = "Status";
                dataGridView1.Columns["Status"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Status"].Width = 80;
                dataGridView1.Columns["Status"].VisibleIndex = 3;

                dataGridView1.Columns["Nome"].Caption = "Nome";
                dataGridView1.Columns["Nome"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Nome"].Width = 330;
                dataGridView1.Columns["Nome"].VisibleIndex = 4;

                dataGridView1.Columns["Total"].Caption = "Total";
                dataGridView1.Columns["Total"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Total"].Width = 120;
                dataGridView1.Columns["Total"].VisibleIndex = 5;
                dataGridView1.Columns["Total"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                dataGridView1.Columns["Total"].DisplayFormat.FormatString = "C2";
                dataGridView1.Columns["Total"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

                if (cwkControleUsuario.Facade.getUsuarioLogado.IdGrupo != 3)
                {
                    dataGridView1.Columns["Total"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "Total = {0:C2}");
                    dataGridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", dataGridView1.Columns["Total"], "Total = {0:C2}");
                    dataGridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", null, "Total = {0:C2}");
                }

                dataGridView1.Columns["Fantasia"].Caption = "Fantasia";
                dataGridView1.Columns["Fantasia"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Fantasia"].Width = 330;
                dataGridView1.Columns["Fantasia"].VisibleIndex = 6;

                dataGridView1.Columns["Vendedor"].Caption = "Vendedor";
                dataGridView1.Columns["Vendedor"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Vendedor"].Width = 330;
                dataGridView1.Columns["Vendedor"].VisibleIndex = 7;
                if (tipo == Modelo.InOutType.Entrada)
                    dataGridView1.Columns["Vendedor"].Visible = false;

                dataGridView1.Columns["Tipo"].Caption = "Tipo";
                dataGridView1.Columns["Tipo"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Tipo"].Width = 330;
                dataGridView1.Columns["Tipo"].VisibleIndex = 8;

                dataGridView1.Columns["Numero"].Caption = "Número";
                dataGridView1.Columns["Numero"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                dataGridView1.Columns["Numero"].Width = 80;
                dataGridView1.Columns["Numero"].VisibleIndex = 9;

                //Codigo para posicionar a seleção do grid no registro correto        
                dataGridView1.SortInfo.Clear();
                dataGridView1.SortInfo.ClearSorting();
                dataGridView1.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
                dataGridView1.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                if (posicao != 0)
                {
                    if (posicao > dataGridView1.RowCount - 1)
                    {
                        posicao = dataGridView1.RowCount - 1;
                    }
                    dataGridView1.SelectRow(posicao);
                    dataGridView1.FocusedRowHandle = posicao;
                }
                else
                {
                    dataGridView1.SelectRow(0);
                    dataGridView1.FocusedRowHandle = 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Problema com o banco de dados. Verifique!\n\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
        }

        /// <summary>
        /// Método que retorna o ID do registro selecionado
        /// </summary>
        /// <returns>Retorna o ID</returns>
        public Int32 RegistroSelecionado()
        {
            Int32 id;
            try
            {
                id = (int)dataGridView1.GetFocusedRowCellValue("ID");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        /// <summary>
        /// Método para chamar a tela de filtro
        /// </summary>
        public String ChamaFiltro()
        {
            FormFiltro frmFiltro = new FormFiltro();

            frmFiltro.filtro = filtro;
            frmFiltro.ShowDialog();
            filtro = frmFiltro.filtro;

            return filtro;
        }

        /// <summary>
        /// Método responsável para selecionar um registro no dataGridView
        /// </summary>
        public void SelecionaRegistro()
        {
            if (dataGridView1.GroupCount == 0)
            {
                for (int y = 0; y < dataGridView1.RowCount; y++)
                {
                    if (dataGridView1.GetRowCellValue(y, dataGridView1.SortedColumns[0]).ToString().ToLower().IndexOf(txtLocalizar.Text.ToLower()) == 0)
                    {
                        dataGridView1.FocusedRowHandle = y;
                        dataGridView1.SelectRow(dataGridView1.FocusedRowHandle);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Método responsável para carragar o objeto da tabela e retornar a Lista que será mostrado no Grid
        /// </summary>
        /// <param name="pFiltro">Filtro para a Lista</param>
        /// <returns>Retorna um objeto do Linq (IQueryable)</returns>
        private List<pxyPedido> MontaLista(String pFiltro)
        {
            try
            {
                Modelo.Pedido objPedido = new Modelo.Pedido();
                lista = bllPedido.getListaTipo(tipo, null);

                //if (objPedido.QtdPedidosDemonstracao(db) > 5)
                //    btIncluir.Enabled = false;
                //else
                //    btIncluir.Enabled = true;
            }
            catch (SqlException)
            {
                throw;
            }

            return lista;
        }

        /// <summary>
        /// Método para carregar a tela de manutenção
        /// </summary>
        /// <param name="pAcao">Variável que determina o tipo de ação 1-Incluir; 2-Alterar; 3-Excluir; 4-Consultar</param>
        /// <param name="pID">ID do registro para Alteração, Consulta ou Exclusão. OBS: para inclusão o campo tem que ser 0.</param>
        public void CarregarManutencao(int pAcao, int pID)
        {
            try
            {
                if ((pAcao != 1) && (pID == 0))
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                }
                else
                {
                    new FormManutOrcamentoNew(pAcao, pID, tipo, db).ShowDialog();
                }

                //Caso seja uma consulta, não será atualizado o grid
                if (pAcao != 4)
                {
                    atualiza = true;
                    string coluna = "Data";
                    if (dataGridView1.SortedColumns.Count > 0)
                        coluna = dataGridView1.SortedColumns[0].FieldName;
                    else if (dataGridView1.GroupedColumns.Count > 0)
                        coluna = dataGridView1.GroupedColumns[0].FieldName;
                    if (dataGridView1.GetFocusedRow() == null)
                    {
                        CarregarGrid(coluna, 0, "");
                    }
                    else
                    {
                        CarregarGrid(coluna, dataGridView1.FocusedRowHandle, "");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Modelo.MetodosEstaticos.SqlExcecao(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void GridPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    retorno = "";
                    this.Close();
                    break;
                case Keys.F:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        btFiltro_Click(sender, e);
                    }
                    break;
                case Keys.L:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        CarregarGrid(dataGridView1.SortedColumns.View.FocusedColumn.Name, 0, "");
                    }
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, tabela);
                    break;
                case Keys.F5:
                    CarregarGrid(dataGridView1.SortedColumns[0].FieldName, 0, "");
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        if (File.Exists("Telas\\" + arquivo + ".xml"))
                        {
                            File.Delete("Telas\\" + arquivo + ".xml");
                            arquivo = "";
                        }
                    }
                    break;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ValidaSelectManutencao();
                    break;
                case Keys.Back:
                    if (txtLocalizar.Text.Length > 0)
                    {
                        txtLocalizar.Text = txtLocalizar.Text.Substring(0, (txtLocalizar.Text.TrimEnd().Length - 1));
                    }
                    SelecionaRegistro();
                    break;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                txtLocalizar.Text = txtLocalizar.Text + e.KeyChar;
                SelecionaRegistro();
            }
        }

        private void txtLocalizar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ValidaSelectManutencao();
                    break;
            }
        }

        private void ValidaSelectManutencao()
        {
            if (btAlterar.Enabled == true)
            {
                if (bSelecionar == false)
                {
                    CarregarManutencao(2, RegistroSelecionado());
                }
                else
                {
                    if (dataGridView1.OptionsSelection.MultiSelect == true)
                    {
                        ListaMultiSelect.Clear();
                        if (dataGridView1.GroupCount == 0)
                        {
                            for (int y = 0; y < dataGridView1.SelectedRowsCount; y++)
                            {
                                if (dataGridView1.GetSelectedRows()[y] >= 0)
                                {
                                    ListaMultiSelect.Add(int.Parse(dataGridView1.GetRowCellValue(dataGridView1.GetSelectedRows()[y], "ID").ToString()));
                                }
                            }
                        }
                    }
                    else
                    {
                        retorno = RegistroSelecionado().ToString();
                    }
                    this.Close();
                }
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void GridPadrao_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Salva a configuração da janela
            if (arquivo != "")
                dataGridView1.SaveLayoutToXml("Telas\\" + arquivo + ".xml");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void sbFaturar_Click(object sender, EventArgs e)
        {
            if (RegistroSelecionado() > 0)
            {
                if ((Modelo.StatusOrcamento)dataGridView1.GetFocusedRowCellValue("Status") != Modelo.StatusOrcamento.Aberto)
                {
                    MessageBox.Show("Somente pedidos com Status Aberto podem ser faturados.");
                }
                else
                {
                    objPedido = (Modelo.Pedido)objPedido.getObjeto(db, RegistroSelecionado());

                    cwkGestao.Modelo.Pessoa objPessoa = new cwkGestao.Modelo.Pessoa();
                    if (objPedido.Pessoa != null)
                        objPessoa = pessoaController.LoadObjectById(objPedido.Pessoa.ID);
                    else if (objPedido.IDPessoa.HasValue)
                        objPessoa = pessoaController.LoadObjectById(objPedido.IDPessoa.Value);
                    string mensagem;
                    if (!notaController.DadosPedidoFaturarValidos(objPessoa, out mensagem))
                    {
                        MessageBox.Show("Antes de efetuar a fatura é necessário corrigir o cadastro do cliente:"
                            + Environment.NewLine + mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //FormFaturamentoLote form = new FormFaturamentoLote(objPedido);
                        //form.ShowDialog();
                        atualiza = true;
                        if (dataGridView1.GetFocusedRow() == null)
                            CarregarGrid(dataGridView1.SortedColumns[0].FieldName, 0, "");
                        else
                            CarregarGrid(dataGridView1.SortedColumns[0].FieldName, dataGridView1.FocusedRowHandle, "");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                cwkGestao.Modelo.Pedido pedido = cwkGestao.Negocio.PedidoController.Instancia.LoadObjectById(id);
                try
                {
                    ImpressaoOrcamento impressao = ImpressaoOrcamento.GetImpressaoOrcamento(pedido);
                    impressao.Imprimir();
                }
                catch (PrinterNotFoundException printerNotFoundException)
                {
                    new FormErro(printerNotFoundException).ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void btGerarPedido_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                var aux = db.Pedidos.Where(p => p.ID == id);
                if (aux.Count() > 0)
                {
                    Modelo.Pedido objPedido = aux.First();
                    //#588b
                    #region temp
                    Telas.FormSenhaGerente prompt = new Telas.FormSenhaGerente(false);
                    Modelo.Cw_Usuario logado = Modelo.cwkGlobal.objUsuarioLogado;
                    if (!objCfg.PermitirAlteracaoVendedorPedido && objPedido.Vendedor.Senha != null)
                    {
                        prompt.ShowDialog();
                        if (prompt.cwRetorno) // confirmou login
                        {
                            if (logado.Login.Equals(Modelo.cwkGlobal.objUsuarioLogado.Login) && !objPedido.Vendedor.Senha.Equals(prompt.SenhaInformada)) // senha do vendedor incorreta
                            {
                                MessageBox.Show("Senha do vendedor incorreta.\nGeração de pedido negada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else if (!logado.Login.Equals(Modelo.cwkGlobal.objUsuarioLogado.Login)) // logou como gerente
                            {
                                Modelo.PedidoHistorico fat = new Modelo.PedidoHistorico()
                                {
                                    Data = DateTime.Now,
                                    GerenteResponsavel = Modelo.cwkGlobal.objUsuarioLogado.Login,
                                    IDPedido = objPedido.ID,
                                    Pedido = objPedido,
                                    UsuarioLogado = logado.Login,
                                    ValorTotalAnterior = objPedido.TotalPedido.Value,
                                    ValorTotalPosterior = objPedido.TotalPedido.Value,
                                    Descricao = "Orçamento faturado pelo gerente " + Modelo.cwkGlobal.objUsuarioLogado.Login
                                };
                                db.PedidoHistoricos.InsertOnSubmit(fat);
                                db.SubmitChanges();
                                Modelo.cwkGlobal.objUsuarioLogado = logado;
                            }
                        }
                        else // cancelou login
                        {
                            return;
                        }
                    }
                    #endregion
                    //#588e
                    if (objPedido.TipoPedido.Tipo == Modelo.TipoPedidoType.Orçamento)
                    {
                        FormSelecionaItensPedido form = new FormSelecionaItensPedido(db, objPedido);
                        form.ShowDialog();
                        if (form.GeracaoPedidoOk)
                        {
                            if (objPedido.Status != Modelo.StatusOrcamento.Fechado)
                            {
                                if (MessageBox.Show("Deseja mudar o status do orçamento para fechado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    objPedido.Status = Modelo.StatusOrcamento.Fechado;
                                    db.SubmitChanges();
                                }
                            }
                        }
                        CarregarGrid(dataGridView1.SortedColumns[0].FieldName, dataGridView1.FocusedRowHandle, "");
                    }
                    else
                    {
                        MessageBox.Show("O registro selecionado não é um orçamento.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void sbGerarOrdemProducao_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                if (MessageBox.Show("Deseja gerar uma ordem de produção para o pedido selecionado?", "Cwork Gestão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Modelo.Pedido objPedido;
                    if (CarregaPedidoOrdemProducao(id, out objPedido))
                    {
                        if (!Modelo.OrdemProducao.ExisteOrdemProducao(db, id))
                        {
                            if (BLL.PCP.OrdemProducao.GerarOrdemProducao(db, objPedido))
                                MessageBox.Show("Ordem de produção gerada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("A ordem de produção para este pedido já existe. Consulte as ordens de produção existentes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("O pedido selecionado não possui nenhum item configurado para produção.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        public bool CarregaPedidoOrdemProducao(int id, out Modelo.Pedido objPedido)
        {
            var aux = db.Pedidos.Where(p => p.ID == id);
            if (aux.Count() > 0)
            {
                objPedido = aux.First();
                foreach (Modelo.PedidoItem item in objPedido.PedidoItems)
                {
                    if (objPedido.PedidoItems.Contains(item.PedidoItem1))
                    {
                        return true;
                    }
                }
            }
            else
                objPedido = new Modelo.Pedido();

            return false;
        }

        private void sbConsultarProducao_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                if (Modelo.OrdemProducao.ExisteOrdemProducao(db, id))
                {
                    PCP.GridOrdemProducaoFicha grid = new Aplicacao.PCP.GridOrdemProducaoFicha("Tabela de Ordem de Produção");
                    grid.IdPedido = id;
                    grid.ShowDialog();
                }
                else
                    MessageBox.Show("O pedido selecionado não possui nenhum item configurado para produção.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void GridOrcamentoNew_Shown(object sender, EventArgs e)
        {
            dataGridView1.MoveLastVisible();
        }
    }
}
