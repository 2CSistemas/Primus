using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using Modelo;
using System.Linq;
using System.Reflection;
using DevExpress.Utils;

namespace Aplicacao
{
    public partial class GridOrdemProducaoExecucao : Aplicacao.Base.GridBase
    {
        private Modelo.DataClassesDataContext db;

        public int IdOrdemProducao = 0;

        private DataTable dt;

        public GridOrdemProducaoExecucao()
        {
            InitializeComponent();
        }

        public GridOrdemProducaoExecucao(int pIdOrdemProducao)
        {
            InitializeComponent();
            IdOrdemProducao = pIdOrdemProducao;
        }

        public GridOrdemProducaoExecucao(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "GridOrdemProducaoExecucao";

            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            if (pdb != null)
                this.db = pdb;
            else
            {
                this.db = new Modelo.DataClassesDataContext();
                this.db.ObjectTrackingEnabled = false;
            }
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            int idfuncanterior = 0;
            IQueryable query, querynomefunc;
            string nomefunc = null;
            base.CarregarGrid(pFiltro);
            if (db == null)
                db = new Modelo.DataClassesDataContext();

            Modelo.OrdemProducaoExecucao objOrdemProducaoExecucao = new Modelo.OrdemProducaoExecucao();
            query = objOrdemProducaoExecucao.getListaGrid(db, IdOrdemProducao);

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("IdFuncionario"), new DataColumn("OrdemProducao"), new DataColumn("Quantidade"), new DataColumn("ID"), new DataColumn("Servico"), new DataColumn("Descricao"), new DataColumn("Sequencia"), new DataColumn("NomeFuncionario"), new DataColumn("DataInicio"), new DataColumn("DataTermino") });
            dt.Columns["NomeFuncionario"].ReadOnly = false;
            

            foreach (Object item in query)
            {
                DataRow linha = dt.NewRow();

                Type tipoItem = item.GetType();
                
                PropertyInfo propriedade;                

                propriedade = tipoItem.GetProperty("Descricao");
                linha["Descricao"] = propriedade.GetValue(item, null);

                propriedade = tipoItem.GetProperty("OrdemProducao");
                linha["OrdemProducao"] = propriedade.GetValue(item, null);

                propriedade = tipoItem.GetProperty("Servico");
                linha["Servico"] = propriedade.GetValue(item, null);

                propriedade = tipoItem.GetProperty("Quantidade");
                linha["Quantidade"] = propriedade.GetValue(item, null);

                propriedade = tipoItem.GetProperty("ID");
                linha["ID"] = propriedade.GetValue(item, null);

                propriedade = tipoItem.GetProperty("Sequencia");
                linha["Sequencia"] = propriedade.GetValue(item, null);

                propriedade = tipoItem.GetProperty("Funcionario");
                linha["IdFuncionario"] = propriedade.GetValue(item, null);

                //idfuncanterior = Convert.ToInt16(propriedade.GetValue(item, null));

                if (idfuncanterior != Convert.ToInt16(propriedade.GetValue(item, null)))
                {
                    idfuncanterior = Convert.ToInt16(propriedade.GetValue(item, null));
                    nomefunc = objOrdemProducaoExecucao.getNomeFuncionario(db, idfuncanterior);                   
                    linha["NomeFuncionario"] = nomefunc;
                    
                }
                else
                {
                    linha["NomeFuncionario"] = nomefunc;
                }

                propriedade = tipoItem.GetProperty("DataInicio");
                linha["DataInicio"] = propriedade.GetValue(item, null);

                propriedade = tipoItem.GetProperty("DataTermino");
                linha["DataTermino"] = propriedade.GetValue(item, null);

                dt.Rows.Add(linha);               
                
            }
            gridControl1.DataSource = dt;
            OrdenaGrid("Sequencia", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;

            dataGridView1.Columns["Sequencia"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Sequencia"].Width = 100;
            dataGridView1.Columns["Sequencia"].VisibleIndex = 0;
            dataGridView1.Columns["Sequencia"].Caption = "Sequencia";

            dataGridView1.Columns["Descricao"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            dataGridView1.Columns["Descricao"].Width = 350;
            dataGridView1.Columns["Descricao"].VisibleIndex = 1;
            dataGridView1.Columns["Descricao"].Caption = "Descrição";

            dataGridView1.Columns["Quantidade"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Quantidade"].Width = 100;
            dataGridView1.Columns["Quantidade"].VisibleIndex = 2;
            dataGridView1.Columns["Quantidade"].Caption = "Quantidade";
            var mascara = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            mascara.EditFormat.FormatType = FormatType.Numeric;
            mascara.EditFormat.FormatString = "n2";
            mascara.DisplayFormat.FormatType = FormatType.Numeric;
            mascara.DisplayFormat.FormatString = "n2";
            mascara.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            mascara.Mask.EditMask = "n2";
            mascara.Mask.UseMaskAsDisplayFormat = true;

            dataGridView1.Columns["Quantidade"].ColumnEdit = mascara;
            //dataGridView1.Columns["Quantidade"].DisplayFormat.FormatType = FormatType.Custom;
            //dataGridView1.Columns["Quantidade"].DisplayFormat.FormatString = "{0:#0.00}";

            dataGridView1.Columns["NomeFuncionario"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            dataGridView1.Columns["NomeFuncionario"].Width = 241;
            dataGridView1.Columns["NomeFuncionario"].VisibleIndex = 3;
            dataGridView1.Columns["NomeFuncionario"].Caption = "Funcionário";

            dataGridView1.Columns["DataInicio"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["DataInicio"].Width = 100;
            dataGridView1.Columns["DataInicio"].VisibleIndex = 4;
            dataGridView1.Columns["DataInicio"].Caption = "Data Início";

            dataGridView1.Columns["DataTermino"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.Columns["DataTermino"].Width = 100;
            dataGridView1.Columns["DataTermino"].VisibleIndex = 5;
            dataGridView1.Columns["DataTermino"].Caption = "Data Término";

            dataGridView1.Columns["IdFuncionario"].Visible = false;
            dataGridView1.Columns["OrdemProducao"].Visible = false;
            dataGridView1.Columns["Servico"].Visible = false;

            dataGridView1.Columns["ID"].Visible = false;
            CarregaLayoutSalvo();
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            FormManutOrdemProducaoExecucao form = new FormManutOrdemProducaoExecucao(db, IdOrdemProducao);
            form.cwAcao = pAcao;
            form.cwID = pID;
            form.cwTabela = "Ordem Produção Execução";
            form.ShowDialog();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            dataGridView1.OptionsView.ShowFooter = true;
            dataGridView1.Columns.ColumnByFieldName("Quantidade").SummaryItem.DisplayFormat = "Total = {0:n2}";
            dataGridView1.Columns.ColumnByFieldName("Quantidade").SummaryItem.FieldName = "Quantidade";
            dataGridView1.Columns.ColumnByFieldName("Quantidade").SummaryItem.SummaryType = SummaryItemType.Sum;

        }
    }
}
