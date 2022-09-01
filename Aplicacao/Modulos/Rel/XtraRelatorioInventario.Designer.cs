
namespace Aplicacao.Modulos.Rel
{
    partial class XtraRelatorioInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_Empresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrNumeroPagina = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrDataImpressao = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ovDS_Dados = new System.Data.DataSet();
            this.DADOS = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.cwkGestaoDataSet1 = new Relatorio.cwkGestaoDataSet();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.txtSomaTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.txtTotalValor = new DevExpress.XtraReports.UI.XRLabel();
            this.txtTotalQuantidade = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtQuantidadeProdutos = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ovDS_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DADOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkGestaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 18F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 35.05674F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel13});
            this.Detail.HeightF = 16F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DADOS].[quantidade]")});
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(463.2144F, 0F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(106.6951F, 16F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel15.TextFormatString = "{0:n2}";
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DADOS].[valor]")});
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(569.9094F, 0F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(106.1467F, 16F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "xrLabel16";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel16.TextFormatString = "{0:n2}";
            // 
            // xrLabel17
            // 
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DADOS].[total]")});
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(676.0562F, 0F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(90.94379F, 16F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "xrLabel17";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel17.TextFormatString = "{0:n2}";
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DADOS].[produto]")});
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(463.2144F, 16F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "xrLabel13";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.ovTXT_Empresa,
            this.xrNumeroPagina,
            this.xrDataImpressao,
            this.xrLabel3});
            this.ReportHeader.HeightF = 73.59471F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(676.0562F, 54.38258F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(90.94379F, 19.21213F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Total";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(569.9095F, 54.38258F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(106.1467F, 19.21213F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Valor";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(463.2144F, 54.38258F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(106.6951F, 19.21213F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Quantidade";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 54.38258F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(463.2144F, 19.21213F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Produto";
            // 
            // ovTXT_Empresa
            // 
            this.ovTXT_Empresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ovTXT_Empresa.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.ovTXT_Empresa.Multiline = true;
            this.ovTXT_Empresa.Name = "ovTXT_Empresa";
            this.ovTXT_Empresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_Empresa.SizeF = new System.Drawing.SizeF(510.8892F, 23F);
            this.ovTXT_Empresa.StylePriority.UseFont = false;
            this.ovTXT_Empresa.Text = "TXT_Empresa";
            // 
            // xrNumeroPagina
            // 
            this.xrNumeroPagina.LocationFloat = new DevExpress.Utils.PointFloat(727.1389F, 0F);
            this.xrNumeroPagina.Name = "xrNumeroPagina";
            this.xrNumeroPagina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrNumeroPagina.SizeF = new System.Drawing.SizeF(29.86108F, 23F);
            this.xrNumeroPagina.StylePriority.UseTextAlignment = false;
            this.xrNumeroPagina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrDataImpressao
            // 
            this.xrDataImpressao.LocationFloat = new DevExpress.Utils.PointFloat(493.7582F, 23F);
            this.xrDataImpressao.Name = "xrDataImpressao";
            this.xrDataImpressao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDataImpressao.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrDataImpressao.SizeF = new System.Drawing.SizeF(263.2418F, 23F);
            this.xrDataImpressao.StylePriority.UseTextAlignment = false;
            this.xrDataImpressao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(493.7582F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Relatório de Inventário";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ovDS_Dados
            // 
            this.ovDS_Dados.DataSetName = "NewDataSet";
            this.ovDS_Dados.Tables.AddRange(new System.Data.DataTable[] {
            this.DADOS});
            // 
            // DADOS
            // 
            this.DADOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.DADOS.TableName = "DADOS";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "produto";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "quantidade";
            this.dataColumn2.DataType = typeof(decimal);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "valor";
            this.dataColumn3.DataType = typeof(decimal);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "total";
            this.dataColumn4.DataType = typeof(decimal);
            // 
            // cwkGestaoDataSet1
            // 
            this.cwkGestaoDataSet1.DataSetName = "cwkGestaoDataSet";
            this.cwkGestaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtSomaTotal,
            this.txtTotalValor,
            this.txtTotalQuantidade,
            this.xrLabel6,
            this.txtQuantidadeProdutos});
            this.ReportFooter.HeightF = 22.98861F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // txtSomaTotal
            // 
            this.txtSomaTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DADOS].[total])")});
            this.txtSomaTotal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtSomaTotal.LocationFloat = new DevExpress.Utils.PointFloat(676.0562F, 6.988613F);
            this.txtSomaTotal.Multiline = true;
            this.txtSomaTotal.Name = "txtSomaTotal";
            this.txtSomaTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtSomaTotal.SizeF = new System.Drawing.SizeF(90.94379F, 16F);
            this.txtSomaTotal.StylePriority.UseFont = false;
            this.txtSomaTotal.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.txtSomaTotal.Summary = xrSummary1;
            this.txtSomaTotal.Text = "xrLabel13";
            this.txtSomaTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.txtSomaTotal.TextFormatString = "{0:n2}";
            // 
            // txtTotalValor
            // 
            this.txtTotalValor.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DADOS].[valor])")});
            this.txtTotalValor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtTotalValor.LocationFloat = new DevExpress.Utils.PointFloat(569.9095F, 6.988613F);
            this.txtTotalValor.Multiline = true;
            this.txtTotalValor.Name = "txtTotalValor";
            this.txtTotalValor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtTotalValor.SizeF = new System.Drawing.SizeF(106.1467F, 16F);
            this.txtTotalValor.StylePriority.UseFont = false;
            this.txtTotalValor.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.txtTotalValor.Summary = xrSummary2;
            this.txtTotalValor.Text = "xrLabel13";
            this.txtTotalValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.txtTotalValor.TextFormatString = "{0:n2}";
            // 
            // txtTotalQuantidade
            // 
            this.txtTotalQuantidade.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DADOS].[quantidade])")});
            this.txtTotalQuantidade.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtTotalQuantidade.LocationFloat = new DevExpress.Utils.PointFloat(463.2144F, 6.988613F);
            this.txtTotalQuantidade.Multiline = true;
            this.txtTotalQuantidade.Name = "txtTotalQuantidade";
            this.txtTotalQuantidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtTotalQuantidade.SizeF = new System.Drawing.SizeF(106.695F, 16F);
            this.txtTotalQuantidade.StylePriority.UseFont = false;
            this.txtTotalQuantidade.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.txtTotalQuantidade.Summary = xrSummary3;
            this.txtTotalQuantidade.Text = "xrLabel13";
            this.txtTotalQuantidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.txtTotalQuantidade.TextFormatString = "{0:n2}";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6.988613F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(106.6951F, 15.99999F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Total de Produtos:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtQuantidadeProdutos
            // 
            this.txtQuantidadeProdutos.Font = new System.Drawing.Font("Arial", 8F);
            this.txtQuantidadeProdutos.LocationFloat = new DevExpress.Utils.PointFloat(106.6951F, 6.988609F);
            this.txtQuantidadeProdutos.Multiline = true;
            this.txtQuantidadeProdutos.Name = "txtQuantidadeProdutos";
            this.txtQuantidadeProdutos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtQuantidadeProdutos.SizeF = new System.Drawing.SizeF(36.60455F, 16F);
            this.txtQuantidadeProdutos.StylePriority.UseFont = false;
            this.txtQuantidadeProdutos.StylePriority.UseTextAlignment = false;
            this.txtQuantidadeProdutos.Text = "xrLabel13";
            this.txtQuantidadeProdutos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XtraRelatorioInventario
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ovDS_Dados,
            this.cwkGestaoDataSet1,
            this.DADOS});
            this.DataSource = this.ovDS_Dados;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(30, 30, 18, 35);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.ovDS_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DADOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkGestaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPageInfo xrNumeroPagina;
        private DevExpress.XtraReports.UI.XRPageInfo xrDataImpressao;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_Empresa;
        private System.Data.DataSet ovDS_Dados;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private Relatorio.cwkGestaoDataSet cwkGestaoDataSet1;
        private System.Data.DataTable DADOS;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel txtQuantidadeProdutos;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel txtSomaTotal;
        private DevExpress.XtraReports.UI.XRLabel txtTotalValor;
        private DevExpress.XtraReports.UI.XRLabel txtTotalQuantidade;
    }
}
