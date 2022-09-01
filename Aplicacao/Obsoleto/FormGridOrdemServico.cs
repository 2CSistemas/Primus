using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormGridOrdemServico : Aplicacao.Base.GridBase
    {
        private OrdemServicoController ordemServicoController = OrdemServicoController.Instancia;

        public FormGridOrdemServico(string tabela)
        {
            InicializaTela(tabela);
        }

        private void InicializaTela(string tabela)
        {
            InitializeComponent();
            this.Name = "FormGridOrdemServico";
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
            dataGridView1.Columns["Codigo"].Width = 70;
            dataGridView1.Columns["Resumo"].Caption = "Resumo";
            dataGridView1.Columns["Resumo"].Width = 230;
            dataGridView1.Columns["Cliente"].Caption = "Cliente";
            dataGridView1.Columns["Cliente"].Width = 100;
            dataGridView1.Columns["ClienteRevenda"].Caption = "Cli. Revenda";
            dataGridView1.Columns["ClienteRevenda"].Width = 100;
            dataGridView1.Columns["Responsavel"].Caption = "Resp.";
            dataGridView1.Columns["Responsavel"].Width = 60;
            dataGridView1.Columns["DataCadastro"].Caption = "Cadastro";
            dataGridView1.Columns["DataCadastro"].Width = 80;
            dataGridView1.Columns["Status"].Caption = "Status";
            dataGridView1.Columns["Status"].Width = 90;
            dataGridView1.Columns["DataStatus"].Caption = "Data Status";
            dataGridView1.Columns["DataStatus"].Width = 80;
            dataGridView1.Columns["DataPrevisao"].Caption = "Previsão Inicial";
            dataGridView1.Columns["DataPrevisao"].Width = 80;
            dataGridView1.Columns["DataprevisaoFinal"].Caption = "Previsão Final";
            dataGridView1.Columns["DataprevisaoFinal"].Width = 80;

            dataGridView1.Columns["Sistema"].Caption = "Sistema";
            dataGridView1.Columns["Sistema"].Width = 80;
            dataGridView1.Columns["Versao"].Caption = "Versão";
            dataGridView1.Columns["Versao"].Width = 80;
            CarregaLayoutSalvo();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            var lista = ordemServicoController.GetAllGrid();

            var objeto = new cwkGestao.Modelo.Proxy.pxyGridOrdemServico();

            var listaParaMostrar = MakeList(objeto);

            foreach (var item in lista)
            {
                listaParaMostrar.Add(item);
            }
            gridControl1.DataSource = listaParaMostrar;

            if (dataGridView1.SortInfo.Count == 0)
                OrdenaGrid("DataStatus", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            FormManutOrdemServico form = new FormManutOrdemServico();
            form.cwAcao = pAcao;
            form.cwID = pID;
            form.cwTabela = "Ordem de Serviço";
            form.ShowDialog();
        }
    }
}
