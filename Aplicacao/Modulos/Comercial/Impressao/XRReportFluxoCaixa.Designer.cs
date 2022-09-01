namespace Aplicacao.Modulos.Comercial.Impressao
{
    partial class XRReportFluxoCaixa
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.XRSubReport_Retirada = new DevExpress.XtraReports.UI.XRSubreport();
            this.XRSubReport_Suprimentos = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.TXT_NUMEROPEDIDO = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_EMPRESA = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_ENDERECO = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_TELEFONE = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_INSCRICAOESTADUAL = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_UsuarioAbertura = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_DataAbertura = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_DataEmissao = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_DataFechamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_ValorFechamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_ValorAbertura = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.XRSubReport_Sangria = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.ovDS_Dados = new System.Data.DataSet();
            this.DADOS = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.ovTXT_Observacao = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_DATAIMPRESSAO = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine8 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.ovDS_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DADOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine5,
            this.ovTXT_ValorFechamento,
            this.xrLabel7,
            this.xrLabel25,
            this.xrLabel8,
            this.ovTXT_Observacao,
            this.TXT_DATAIMPRESSAO});
            this.BottomMargin.HeightF = 69.52626F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel14});
            this.Detail.HeightF = 15.00001F;
            this.Detail.HierarchyPrintOptions.Indent = 20.83333F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DADOS].[TOTALPAGO]")});
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(196.1012F, 0F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(103.8989F, 15.00001F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel15.TextFormatString = "{0:c2}";
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DADOS].[DESCFORMAPAGAMENTO]")});
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(15F, 0F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(181.1F, 15F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "xrLabel14";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(196.1145F, 206.3141F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(103.8988F, 18.53574F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Total Pago (R$)";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(15.01341F, 206.314F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(181.1012F, 18.53571F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Forma de Pagamento";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine7,
            this.xrLabel18,
            this.xrLine2,
            this.xrLine1,
            this.TXT_NUMEROPEDIDO,
            this.TXT_EMPRESA,
            this.TXT_ENDERECO,
            this.TXT_TELEFONE,
            this.TXT_INSCRICAOESTADUAL,
            this.ovTXT_UsuarioAbertura,
            this.ovTXT_DataAbertura,
            this.ovTXT_DataEmissao,
            this.ovTXT_DataFechamento,
            this.ovTXT_ValorAbertura,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel13,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1});
            this.ReportHeader.HeightF = 224.8499F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // XRSubReport_Retirada
            // 
            this.XRSubReport_Retirada.CanShrink = true;
            this.XRSubReport_Retirada.LocationFloat = new DevExpress.Utils.PointFloat(3.612402E-06F, 120.1349F);
            this.XRSubReport_Retirada.Name = "XRSubReport_Retirada";
            this.XRSubReport_Retirada.SizeF = new System.Drawing.SizeF(315F, 19.79167F);
            // 
            // XRSubReport_Suprimentos
            // 
            this.XRSubReport_Suprimentos.CanShrink = true;
            this.XRSubReport_Suprimentos.LocationFloat = new DevExpress.Utils.PointFloat(0F, 79.49276F);
            this.XRSubReport_Suprimentos.Name = "XRSubReport_Suprimentos";
            this.XRSubReport_Suprimentos.SizeF = new System.Drawing.SizeF(315F, 19.79167F);
            // 
            // xrLine3
            // 
            this.xrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine3.LineWidth = 0.5F;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(14.9999F, 18F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(285.0001F, 2.314819F);
            // 
            // xrLine2
            // 
            this.xrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine2.LineWidth = 0.5F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(14.99991F, 91.8952F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(285.0001F, 2.314819F);
            // 
            // xrLine1
            // 
            this.xrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine1.LineWidth = 0.5F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(14.99992F, 67.68517F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(285.0001F, 2.314819F);
            // 
            // TXT_NUMEROPEDIDO
            // 
            this.TXT_NUMEROPEDIDO.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.TXT_NUMEROPEDIDO.LocationFloat = new DevExpress.Utils.PointFloat(15F, 69.99999F);
            this.TXT_NUMEROPEDIDO.Multiline = true;
            this.TXT_NUMEROPEDIDO.Name = "TXT_NUMEROPEDIDO";
            this.TXT_NUMEROPEDIDO.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_NUMEROPEDIDO.SizeF = new System.Drawing.SizeF(285F, 21.89521F);
            this.TXT_NUMEROPEDIDO.StylePriority.UseFont = false;
            this.TXT_NUMEROPEDIDO.StylePriority.UseTextAlignment = false;
            this.TXT_NUMEROPEDIDO.Text = "RELATÓRIO DE FLUXO DE CAIXA";
            this.TXT_NUMEROPEDIDO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_EMPRESA
            // 
            this.TXT_EMPRESA.Font = new System.Drawing.Font("Arial", 8F);
            this.TXT_EMPRESA.LocationFloat = new DevExpress.Utils.PointFloat(15F, 0F);
            this.TXT_EMPRESA.Multiline = true;
            this.TXT_EMPRESA.Name = "TXT_EMPRESA";
            this.TXT_EMPRESA.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_EMPRESA.SizeF = new System.Drawing.SizeF(285.0001F, 16F);
            this.TXT_EMPRESA.StylePriority.UseFont = false;
            this.TXT_EMPRESA.StylePriority.UseTextAlignment = false;
            this.TXT_EMPRESA.Text = "EMPRESA";
            this.TXT_EMPRESA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_ENDERECO
            // 
            this.TXT_ENDERECO.Font = new System.Drawing.Font("Arial", 8F);
            this.TXT_ENDERECO.LocationFloat = new DevExpress.Utils.PointFloat(15F, 16F);
            this.TXT_ENDERECO.Multiline = true;
            this.TXT_ENDERECO.Name = "TXT_ENDERECO";
            this.TXT_ENDERECO.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_ENDERECO.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_ENDERECO.StylePriority.UseFont = false;
            this.TXT_ENDERECO.StylePriority.UseTextAlignment = false;
            this.TXT_ENDERECO.Text = "ENDEREÇO";
            this.TXT_ENDERECO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_TELEFONE
            // 
            this.TXT_TELEFONE.Font = new System.Drawing.Font("Arial", 8F);
            this.TXT_TELEFONE.LocationFloat = new DevExpress.Utils.PointFloat(15F, 32F);
            this.TXT_TELEFONE.Multiline = true;
            this.TXT_TELEFONE.Name = "TXT_TELEFONE";
            this.TXT_TELEFONE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_TELEFONE.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_TELEFONE.StylePriority.UseFont = false;
            this.TXT_TELEFONE.StylePriority.UseTextAlignment = false;
            this.TXT_TELEFONE.Text = "CNPJ_TELEFONE";
            this.TXT_TELEFONE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_INSCRICAOESTADUAL
            // 
            this.TXT_INSCRICAOESTADUAL.Font = new System.Drawing.Font("Arial", 8F);
            this.TXT_INSCRICAOESTADUAL.LocationFloat = new DevExpress.Utils.PointFloat(15F, 48F);
            this.TXT_INSCRICAOESTADUAL.Multiline = true;
            this.TXT_INSCRICAOESTADUAL.Name = "TXT_INSCRICAOESTADUAL";
            this.TXT_INSCRICAOESTADUAL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_INSCRICAOESTADUAL.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_INSCRICAOESTADUAL.StylePriority.UseFont = false;
            this.TXT_INSCRICAOESTADUAL.StylePriority.UseTextAlignment = false;
            this.TXT_INSCRICAOESTADUAL.Text = "INSCRICAO_ESTADUAL";
            this.TXT_INSCRICAOESTADUAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ovTXT_UsuarioAbertura
            // 
            this.ovTXT_UsuarioAbertura.CanShrink = true;
            this.ovTXT_UsuarioAbertura.Font = new System.Drawing.Font("Arial", 7F);
            this.ovTXT_UsuarioAbertura.LocationFloat = new DevExpress.Utils.PointFloat(56.5434F, 98.21001F);
            this.ovTXT_UsuarioAbertura.Multiline = true;
            this.ovTXT_UsuarioAbertura.Name = "ovTXT_UsuarioAbertura";
            this.ovTXT_UsuarioAbertura.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_UsuarioAbertura.SizeF = new System.Drawing.SizeF(243.4698F, 15.00001F);
            this.ovTXT_UsuarioAbertura.StylePriority.UseFont = false;
            this.ovTXT_UsuarioAbertura.StylePriority.UseTextAlignment = false;
            this.ovTXT_UsuarioAbertura.Text = "ovTXT_UsuarioAbertura";
            this.ovTXT_UsuarioAbertura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ovTXT_DataAbertura
            // 
            this.ovTXT_DataAbertura.CanShrink = true;
            this.ovTXT_DataAbertura.Font = new System.Drawing.Font("Arial", 7F);
            this.ovTXT_DataAbertura.LocationFloat = new DevExpress.Utils.PointFloat(86.74313F, 128.21F);
            this.ovTXT_DataAbertura.Multiline = true;
            this.ovTXT_DataAbertura.Name = "ovTXT_DataAbertura";
            this.ovTXT_DataAbertura.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_DataAbertura.SizeF = new System.Drawing.SizeF(213.2701F, 15F);
            this.ovTXT_DataAbertura.StylePriority.UseFont = false;
            this.ovTXT_DataAbertura.StylePriority.UseTextAlignment = false;
            this.ovTXT_DataAbertura.Text = "ovTXT_DataAbertura";
            this.ovTXT_DataAbertura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ovTXT_DataEmissao
            // 
            this.ovTXT_DataEmissao.CanShrink = true;
            this.ovTXT_DataEmissao.Font = new System.Drawing.Font("Arial", 7F);
            this.ovTXT_DataEmissao.LocationFloat = new DevExpress.Utils.PointFloat(86.74313F, 113.21F);
            this.ovTXT_DataEmissao.Multiline = true;
            this.ovTXT_DataEmissao.Name = "ovTXT_DataEmissao";
            this.ovTXT_DataEmissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_DataEmissao.SizeF = new System.Drawing.SizeF(213.2701F, 14.99998F);
            this.ovTXT_DataEmissao.StylePriority.UseFont = false;
            this.ovTXT_DataEmissao.StylePriority.UseTextAlignment = false;
            this.ovTXT_DataEmissao.Text = "ovTXT_DataEmissao";
            this.ovTXT_DataEmissao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ovTXT_DataFechamento
            // 
            this.ovTXT_DataFechamento.CanShrink = true;
            this.ovTXT_DataFechamento.Font = new System.Drawing.Font("Arial", 7F);
            this.ovTXT_DataFechamento.LocationFloat = new DevExpress.Utils.PointFloat(99.76341F, 143.21F);
            this.ovTXT_DataFechamento.Multiline = true;
            this.ovTXT_DataFechamento.Name = "ovTXT_DataFechamento";
            this.ovTXT_DataFechamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_DataFechamento.SizeF = new System.Drawing.SizeF(200.2497F, 14.99998F);
            this.ovTXT_DataFechamento.StylePriority.UseFont = false;
            this.ovTXT_DataFechamento.StylePriority.UseTextAlignment = false;
            this.ovTXT_DataFechamento.Text = "ovTXT_DataFechamento";
            this.ovTXT_DataFechamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ovTXT_ValorFechamento
            // 
            this.ovTXT_ValorFechamento.CanShrink = true;
            this.ovTXT_ValorFechamento.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.ovTXT_ValorFechamento.LocationFloat = new DevExpress.Utils.PointFloat(114.1473F, 4.314833F);
            this.ovTXT_ValorFechamento.Multiline = true;
            this.ovTXT_ValorFechamento.Name = "ovTXT_ValorFechamento";
            this.ovTXT_ValorFechamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_ValorFechamento.SizeF = new System.Drawing.SizeF(185.8632F, 14.99998F);
            this.ovTXT_ValorFechamento.StylePriority.UseFont = false;
            this.ovTXT_ValorFechamento.StylePriority.UseTextAlignment = false;
            this.ovTXT_ValorFechamento.Text = "ovTXT_ValorFechamento";
            this.ovTXT_ValorFechamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ovTXT_ValorAbertura
            // 
            this.ovTXT_ValorAbertura.CanShrink = true;
            this.ovTXT_ValorAbertura.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.ovTXT_ValorAbertura.LocationFloat = new DevExpress.Utils.PointFloat(72.13615F, 162.4635F);
            this.ovTXT_ValorAbertura.Multiline = true;
            this.ovTXT_ValorAbertura.Name = "ovTXT_ValorAbertura";
            this.ovTXT_ValorAbertura.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_ValorAbertura.SizeF = new System.Drawing.SizeF(227.8639F, 15F);
            this.ovTXT_ValorAbertura.StylePriority.UseFont = false;
            this.ovTXT_ValorAbertura.StylePriority.UseTextAlignment = false;
            this.ovTXT_ValorAbertura.Text = "ovTXT_ValorAbertura";
            this.ovTXT_ValorAbertura.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(15.01314F, 113.21F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(71.73F, 15F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Data Emissão:";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XRSubReport_Sangria
            // 
            this.XRSubReport_Sangria.CanShrink = true;
            this.XRSubReport_Sangria.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.85055F);
            this.XRSubReport_Sangria.Name = "XRSubReport_Sangria";
            this.XRSubReport_Sangria.SizeF = new System.Drawing.SizeF(315F, 19.79167F);
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(15.01352F, 20.31482F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(285.001F, 18.53572F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "SANGRIAS";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(15.01352F, 4.314833F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(99.13F, 15F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Valor de Fechamento:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(15.01341F, 143.21F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(84.75F, 15F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Data Fechamento:";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(15.01314F, 128.21F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(71.73F, 15F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Data Abertura:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(15.01314F, 98.21001F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(41.53F, 15F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Usuário:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(15.01313F, 184.7783F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(284.997F, 18.53571F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "VENDAS";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(15.01352F, 19.31488F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(84.74998F, 15F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Observação:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ovDS_Dados
            // 
            this.ovDS_Dados.DataSetName = "ovDS_Dados";
            this.ovDS_Dados.Tables.AddRange(new System.Data.DataTable[] {
            this.DADOS});
            // 
            // DADOS
            // 
            this.DADOS.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.DADOS.TableName = "DADOS";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "DESCFORMAPAGAMENTO";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "TOTALPAGO";
            this.dataColumn2.DataType = typeof(decimal);
            // 
            // ovTXT_Observacao
            // 
            this.ovTXT_Observacao.CanShrink = true;
            this.ovTXT_Observacao.Font = new System.Drawing.Font("Arial", 7F);
            this.ovTXT_Observacao.LocationFloat = new DevExpress.Utils.PointFloat(15.01687F, 34.31501F);
            this.ovTXT_Observacao.Multiline = true;
            this.ovTXT_Observacao.Name = "ovTXT_Observacao";
            this.ovTXT_Observacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_Observacao.SizeF = new System.Drawing.SizeF(285F, 15F);
            this.ovTXT_Observacao.StylePriority.UseFont = false;
            this.ovTXT_Observacao.StylePriority.UseTextAlignment = false;
            this.ovTXT_Observacao.Text = "ovTXT_Observacao";
            this.ovTXT_Observacao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XRSubReport_Retirada,
            this.xrLine8,
            this.xrLabel19,
            this.XRSubReport_Suprimentos,
            this.xrLine4,
            this.xrLabel10,
            this.XRSubReport_Sangria,
            this.xrLabel9,
            this.xrLine3,
            this.xrLabel6,
            this.xrLabel16});
            this.ReportFooter.HeightF = 139.9266F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Arial", 6.5F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(15.01687F, 49.31493F);
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(91.64733F, 14.95075F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Data de Impressão:";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TXT_DATAIMPRESSAO
            // 
            this.TXT_DATAIMPRESSAO.Font = new System.Drawing.Font("Arial", 6.5F);
            this.TXT_DATAIMPRESSAO.LocationFloat = new DevExpress.Utils.PointFloat(106.6642F, 49.31493F);
            this.TXT_DATAIMPRESSAO.Multiline = true;
            this.TXT_DATAIMPRESSAO.Name = "TXT_DATAIMPRESSAO";
            this.TXT_DATAIMPRESSAO.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_DATAIMPRESSAO.SizeF = new System.Drawing.SizeF(193.3464F, 14.95074F);
            this.TXT_DATAIMPRESSAO.StylePriority.UseFont = false;
            this.TXT_DATAIMPRESSAO.StylePriority.UseTextAlignment = false;
            this.TXT_DATAIMPRESSAO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DADOS].[TOTALPAGO])")});
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(196.1146F, 0F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(103.9F, 15F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            xrSummary1.IgnoreNullValues = true;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel16.Summary = xrSummary1;
            this.xrLabel16.Text = "xrLabel15";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel16.TextFormatString = "{0:c2}";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(14.9999F, 162.4635F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(57.13623F, 15F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Abertura:";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine7
            // 
            this.xrLine7.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine7.LineWidth = 0.5F;
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(14.9999F, 179.4635F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(285.0001F, 2.314819F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(15.01342F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(181.1012F, 15F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "TOTAL VENDAS:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(14.99896F, 60.95704F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(285.001F, 18.53572F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "SUPRIMENTO";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine4
            // 
            this.xrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine4.LineWidth = 0.5F;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(14.9999F, 58.64222F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(285.0001F, 2.314819F);
            // 
            // xrLine8
            // 
            this.xrLine8.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine8.LineWidth = 0.5F;
            this.xrLine8.LocationFloat = new DevExpress.Utils.PointFloat(14.9999F, 99.28443F);
            this.xrLine8.Name = "xrLine8";
            this.xrLine8.SizeF = new System.Drawing.SizeF(285.0001F, 2.314819F);
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(14.99897F, 101.5992F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(285.001F, 18.53572F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "DESPESAS";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine5
            // 
            this.xrLine5.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine5.LineWidth = 0.5F;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(14.9999F, 0F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(285.0001F, 2.314819F);
            // 
            // XRReportFluxoCaixa
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ovDS_Dados,
            this.DADOS});
            this.DataSource = this.ovDS_Dados;
            this.DisplayName = "RelatorioFechamentoCaixaPDV";
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 20, 70);
            this.PageWidth = 315;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.RollPaper = true;
            this.SnapGridSize = 13.02083F;
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.ovDS_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DADOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRSubreport XRSubReport_Sangria;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private System.Data.DataSet ovDS_Dados;
        private System.Data.DataTable DADOS;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_Observacao;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_ValorFechamento;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_ValorAbertura;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_DataFechamento;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_DataEmissao;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_DataAbertura;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_UsuarioAbertura;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel TXT_NUMEROPEDIDO;
        private DevExpress.XtraReports.UI.XRLabel TXT_EMPRESA;
        private DevExpress.XtraReports.UI.XRLabel TXT_ENDERECO;
        private DevExpress.XtraReports.UI.XRLabel TXT_TELEFONE;
        private DevExpress.XtraReports.UI.XRLabel TXT_INSCRICAOESTADUAL;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel TXT_DATAIMPRESSAO;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRSubreport XRSubReport_Suprimentos;
        private DevExpress.XtraReports.UI.XRSubreport XRSubReport_Retirada;
        private DevExpress.XtraReports.UI.XRLine xrLine7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLine xrLine8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLine xrLine5;
    }
}
