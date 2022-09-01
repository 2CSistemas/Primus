using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class GridPessoa : Aplicacao.Base.GridBase
    {
        private BLL.Pessoa bllPessoa;
        public bool bCliente { get; set; }
        public bool bFornecedor { get; set; }
        public bool bFuncionario { get; set; }
        public bool bVendedor { get; set; }

        public GridPessoa(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "GridPessoa";
            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            if (pdb != null)
                this.db = pdb;
            else
            {
                this.db = new Modelo.DataClassesDataContext();
            }
            bllPessoa = new BLL.Pessoa(db);
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Nome"].Width = 280;
            dataGridView1.Columns["Fantasia"].Width = 200;
            dataGridView1.Columns["Cidade"].Width = 150;
            dataGridView1.Columns["CNPJ_CPF"].Width = 110;
            dataGridView1.Columns["Classificação"].Width = 150;
            dataGridView1.Columns["Telefone"].Width = 90;
            dataGridView1.Columns["Estado"].Width = 65;
            dataGridView1.Columns["NomeVendedor"].Width = 100;
            dataGridView1.Columns["NomeVendedor"].Caption = "Nome Vendedor";
            dataGridView1.Columns["bCliente"].Caption = "Cliente";
            dataGridView1.Columns["bFuncionario"].Caption = "Funcionário";
            dataGridView1.Columns["bVendedor"].Caption = "Vendedor";
            dataGridView1.Columns["bFornecedor"].Caption = "Fornecedor";

            CarregaLayoutSalvo();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            gridControl1.DataSource = bllPessoa.getLista(bCliente, bFuncionario, bVendedor, bFornecedor);
            OrdenaGrid("Nome", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            FormManutPes form = new FormManutPes(pAcao, pID, bCliente, bFuncionario, bVendedor, bFornecedor);
            form.ShowDialog();
        }

        private void sbClientesRevenda_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                FormGridClienteRevenda form = new FormGridClienteRevenda("Tabela de Cliente da Revenda", id,null, null, false);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void GridPessoa_Load(object sender, EventArgs e)
        {
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (bCliente && configuracao.UtilizaControleDaRevenda == 1)
            {
                sbClientesRevenda.Visible = true;
            }
        }
    }
}
