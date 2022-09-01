using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormArquivoLigacao : Aplicacao.IntermediariasTela.FormManutArquivoLiagacaoIntermediaria
    {
        private IList<Tel_Ligacao> ligacoes;

        public FormArquivoLigacao(Tel_ArquivoLigacao ArquivoLigacao)
        {
            if (ArquivoLigacao != null)
            {
                Selecionado = ArquivoLigacao;
                Selecionado.Ligacoes = ArquivoLigacao.Ligacoes;    
            }
            InitializeComponent();
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void ConfiguraGrid(DevExpress.XtraGrid.GridControl gridControl)
        {
            base.ConfiguraGrid(gridControl);

            gvLigacoes.OptionsView.ShowFooter = true;
            gvLigacoes.Columns.ColumnByFieldName("TempoSegundos").SummaryItem.DisplayFormat = "Total = {0:##########0}";
            gvLigacoes.Columns.ColumnByFieldName("TempoSegundos").SummaryItem.FieldName = "TempoSegundos";
            gvLigacoes.Columns.ColumnByFieldName("TempoSegundos").SummaryItem.SummaryType = SummaryItemType.Sum;

            gvLigacoes.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TempoSegundos", null, "(Total = {0:##########0} segundos)")});

            base.ConfiguraGrid(gridControl);

            gvLigacoes.OptionsView.ShowFooter = true;
            gvLigacoes.Columns.ColumnByFieldName("ValorComImposto").SummaryItem.DisplayFormat = "Total = {0:##########0}";
            gvLigacoes.Columns.ColumnByFieldName("ValorComImposto").SummaryItem.FieldName = "ValorComImposto";
            gvLigacoes.Columns.ColumnByFieldName("ValorComImposto").SummaryItem.SummaryType = SummaryItemType.Sum;
            
            
            gvLigacoes.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorComImposto", null , "(Total = {0:##########0}) ValorComImposto" )});
      
        }
        
    }
}
