using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Linq;
using System.Collections;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormGridClienteRevenda : Aplicacao.Base.GridBase
    {
        private int? idPessoa;
        private int? idClienteRevendaMatriz;
        private ClienteRevendaController clienteRevendaController = ClienteRevendaController.Instancia;

        public FormGridClienteRevenda(string pTabela, int? pIdPessoa, int? pIdClienteRevendaMatriz, int? pIdClienteRevenda, bool selecionar)
        {
            InitializeComponent();
            InicializaTela(pTabela);
            idPessoa = pIdPessoa;
            idClienteRevendaMatriz = pIdClienteRevendaMatriz;
            this.id = pIdClienteRevenda;
            this.bSelecionar = selecionar;
        }

        private void InicializaTela(string tabela)
        {
            InitializeComponent();
            this.Name = "FormGridClienteRevenda";
            this.Text = tabela;
            this.tabela = tabela;
            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;
            dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.Columns["Codigo"].Caption = "Código";
            dataGridView1.Columns["Nome"].Caption = "Nome";
            dataGridView1.Columns["Cnpj"].Caption = "CNPJ";
            dataGridView1.Columns["Telefone"].Caption = "Fone";
            dataGridView1.Columns["Email"].Caption = "Email";

            dataGridView1.Columns["Codigo"].Width = 80;
            dataGridView1.Columns["Nome"].Width = 300;
            dataGridView1.Columns["Cnpj"].Width = 120;
            dataGridView1.Columns["Telefone"].Width = 100;
            dataGridView1.Columns["Email"].Width = 210;
            CarregaLayoutSalvo();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            var objeto = new {
                ID = 0,
                Codigo = 0,
                Nome = String.Empty,
                Cnpj = String.Empty,
                Telefone = String.Empty,
                Email = String.Empty
            };

            var listaParaMostrar = MakeList(objeto);

            if (idPessoa.HasValue)
            {
                listaParaMostrar = (from c in clienteRevendaController.GetAllByPessoa(idPessoa.Value)
                            select new
                            {
                                ID = c.ID,
                                Codigo = c.Codigo,
                                Nome = c.Nome,
                                Cnpj = c.Cnpj,
                                Telefone = c.Telefone,
                                Email = c.Email
                            }).ToList();
            }
            else if (idClienteRevendaMatriz.HasValue)
            {
                listaParaMostrar = (from c in clienteRevendaController.GetAllByMatriz(idClienteRevendaMatriz.Value)
                                    select new
                                    {
                                        ID = c.ID,
                                        Codigo = c.Codigo,
                                        Nome = c.Nome,
                                        Cnpj = c.Cnpj,
                                        Telefone = c.Telefone,
                                        Email = c.Email
                                    }).ToList();
            }

            gridControl1.DataSource = listaParaMostrar;

            OrdenaGrid("Nome", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            ClienteRevenda clienteRevenda = null;
            if (idClienteRevendaMatriz.HasValue)
                clienteRevenda = clienteRevendaController.LoadObjectById(idClienteRevendaMatriz.Value);

            FormManutClienteRevenda form = new FormManutClienteRevenda(RegistroSelecionadoCodigo(), clienteRevenda);
            form.cwAcao = pAcao;
            form.cwID = pID;
            form.IDCliente = idPessoa;
            form.cwTabela = "Cliente da Revenda";
            form.ShowDialog();
            if (clienteRevenda != null)
                clienteRevendaController.Salvar(clienteRevenda, Acao.Alterar);
        }
    }
}
