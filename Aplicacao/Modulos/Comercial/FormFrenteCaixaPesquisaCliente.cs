using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaPesquisaCliente : Form
    {
        private DataTable CLIENTES = null;
        private IList<Pessoa> Clientes = null;
        public Pessoa Selecionado = null;
        private IList<PessoaEndereco> Enderecos = null;

        public FormFrenteCaixaPesquisaCliente()
        {
            InitializeComponent();

            Text = $"Pesquisa de Clientes";

            Clientes = PessoaController.Instancia.GetAll().Where(o => o.BCliente).ToList();
            CLIENTES = CreateDataTablePessoas();
            Enderecos = PessoaEnderecoController.Instancia.GetAll();

            foreach (var Cliente in Clientes)
                AdicionarCliente(Cliente);

            InitGrid();
        }

        public void AdicionarCliente(Pessoa Cli)
        {
            DataRow dr = CLIENTES.NewRow();
            dr["Guid"] = Guid.NewGuid();

            dr["ID"] = Cli.ID;
            dr["Nome"] = Cli.Nome.ToUpper();
            dr["Telefone"] = Cli.TelefonePrincipal;

            var Endereco = Enderecos.FirstOrDefault(o => o.Pessoa.ID == Cli.ID && o.BPrincipal);
            dr["Endereco"] = Endereco?.ToString().ToUpper();
            dr["Cep"] = Endereco?.CEP;
            CLIENTES.Rows.Add(dr);

            ovGRD_Pessoas.DataSource = CLIENTES;
            ovGRD_Pessoas.Refresh();
        }

        private void FitlrarCliente()
        {
            string ValorPesquisa = TXT_Pesquisa.Text.ToUpper();

            string Expression = $"[Nome] like '%{ValorPesquisa}%' OR [Telefone] like '%{ValorPesquisa}%' OR [Endereco] like '%{ValorPesquisa}%' OR [Cep] like '%{ValorPesquisa}%'";

            CLIENTES.DefaultView.RowFilter = Expression;
            ovGRD_Pessoas.DataSource = CLIENTES;
            ovGRD_Pessoas.Refresh();
        }

        private DataTable CreateDataTablePessoas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Guid");
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Endereco");
            dt.Columns.Add("Cep");
            return dt;
        }

        private void InitGrid()
        {
            ovGRD_Pessoas.DataSource = CLIENTES;
            ovGRD_Pessoas.Refresh();
            AjustaHeaderItens();
        }

        private void AjustaHeaderItens()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Open Sans", 10, FontStyle.Regular);
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (DataGridViewColumn column in ovGRD_Pessoas.Columns)
            {
                switch (column.Name)
                {
                    case "Nome":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pessoas.Width * 0.35);
                        column.HeaderText = "NOME";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Telefone":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pessoas.Width * 0.15); ;
                        column.HeaderText = "TELEFONE";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Endereco":
                        column.DisplayIndex = 2;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pessoas.Width * 0.35);
                        column.HeaderText = "ENDEREÇO";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Cep":
                        column.DisplayIndex = 3;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pessoas.Width * 0.15);
                        column.HeaderText = "CEP";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    default:
                        column.DisplayIndex = 0;
                        column.Visible = false;
                        break;
                }
            }
        }

        private void ovGRD_Pedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (ovGRD_Pessoas.Columns[e.ColumnIndex].Name)
            {
                case "ValorTotal":
                    e.Value = Convert.ToDecimal(e.Value).ToString("c2");
                    break;
            }
        }

        private void ovGRD_Pedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var IDSelecionado = Convert.ToInt32(((sender as DataGridView).SelectedRows[0].DataBoundItem as DataRowView).Row["ID"]);

            Selecionado = Clientes.FirstOrDefault(o => o.ID == IDSelecionado);
            Close();
        }

        private void TXT_Pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
                FitlrarCliente();
        }

        private void FormFrenteCaixaPesquisaCliente_Shown(object sender, EventArgs e)
        {
            TXT_Pesquisa.Focus();
        }
    }
}
