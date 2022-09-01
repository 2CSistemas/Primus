namespace Aplicacao.Modulos.Rel
{
    partial class XtraCarneFinanceiro
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.TXT_Empresa = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_Endereco = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_Cidade = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_Telefone = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_Carne = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_Parcela = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_Vencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.TXT_ValorParcela = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_Observacao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.ovTXT_DetalhesCompra = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrBarCode1,
            this.ovTXT_DetalhesCompra,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLine1,
            this.xrLine3,
            this.ovTXT_Observacao,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.TXT_ValorParcela,
            this.TXT_Vencimento,
            this.TXT_Parcela,
            this.TXT_Carne,
            this.TXT_Telefone,
            this.TXT_Cidade,
            this.TXT_Endereco,
            this.TXT_Empresa});
            this.ReportHeader.HeightF = 396.8933F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // TXT_Empresa
            // 
            this.TXT_Empresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Empresa.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
            this.TXT_Empresa.Multiline = true;
            this.TXT_Empresa.Name = "TXT_Empresa";
            this.TXT_Empresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_Empresa.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_Empresa.StylePriority.UseFont = false;
            this.TXT_Empresa.StylePriority.UseTextAlignment = false;
            this.TXT_Empresa.Text = "EMPRESA";
            this.TXT_Empresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_Endereco
            // 
            this.TXT_Endereco.LocationFloat = new DevExpress.Utils.PointFloat(10F, 16F);
            this.TXT_Endereco.Multiline = true;
            this.TXT_Endereco.Name = "TXT_Endereco";
            this.TXT_Endereco.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_Endereco.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_Endereco.StylePriority.UseTextAlignment = false;
            this.TXT_Endereco.Text = "ENDERECO";
            this.TXT_Endereco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_Cidade
            // 
            this.TXT_Cidade.LocationFloat = new DevExpress.Utils.PointFloat(10F, 31.99999F);
            this.TXT_Cidade.Multiline = true;
            this.TXT_Cidade.Name = "TXT_Cidade";
            this.TXT_Cidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_Cidade.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_Cidade.StylePriority.UseTextAlignment = false;
            this.TXT_Cidade.Text = "CIDADE";
            this.TXT_Cidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_Telefone
            // 
            this.TXT_Telefone.LocationFloat = new DevExpress.Utils.PointFloat(10F, 47.99999F);
            this.TXT_Telefone.Multiline = true;
            this.TXT_Telefone.Name = "TXT_Telefone";
            this.TXT_Telefone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_Telefone.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_Telefone.StylePriority.UseTextAlignment = false;
            this.TXT_Telefone.Text = "TELEFONE";
            this.TXT_Telefone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TXT_Carne
            // 
            this.TXT_Carne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Carne.LocationFloat = new DevExpress.Utils.PointFloat(9.256013F, 162.9553F);
            this.TXT_Carne.Multiline = true;
            this.TXT_Carne.Name = "TXT_Carne";
            this.TXT_Carne.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_Carne.SizeF = new System.Drawing.SizeF(285F, 16F);
            this.TXT_Carne.StylePriority.UseFont = false;
            this.TXT_Carne.StylePriority.UseTextAlignment = false;
            this.TXT_Carne.Text = "Carnê Financeiro";
            this.TXT_Carne.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TXT_Parcela
            // 
            this.TXT_Parcela.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Parcela.LocationFloat = new DevExpress.Utils.PointFloat(9.776845F, 197.0999F);
            this.TXT_Parcela.Multiline = true;
            this.TXT_Parcela.Name = "TXT_Parcela";
            this.TXT_Parcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_Parcela.SizeF = new System.Drawing.SizeF(91.84521F, 22.99998F);
            this.TXT_Parcela.StylePriority.UseFont = false;
            this.TXT_Parcela.StylePriority.UseTextAlignment = false;
            this.TXT_Parcela.Text = "TXT_Parcela";
            this.TXT_Parcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TXT_Vencimento
            // 
            this.TXT_Vencimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Vencimento.LocationFloat = new DevExpress.Utils.PointFloat(101.6221F, 197.0999F);
            this.TXT_Vencimento.Multiline = true;
            this.TXT_Vencimento.Name = "TXT_Vencimento";
            this.TXT_Vencimento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_Vencimento.SizeF = new System.Drawing.SizeF(89.31552F, 22.99998F);
            this.TXT_Vencimento.StylePriority.UseFont = false;
            this.TXT_Vencimento.StylePriority.UseTextAlignment = false;
            this.TXT_Vencimento.Text = "TXT_Vencimento";
            this.TXT_Vencimento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TXT_ValorParcela
            // 
            this.TXT_ValorParcela.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ValorParcela.LocationFloat = new DevExpress.Utils.PointFloat(190.9375F, 197.0999F);
            this.TXT_ValorParcela.Multiline = true;
            this.TXT_ValorParcela.Name = "TXT_ValorParcela";
            this.TXT_ValorParcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TXT_ValorParcela.SizeF = new System.Drawing.SizeF(103.8393F, 22.99998F);
            this.TXT_ValorParcela.StylePriority.UseFont = false;
            this.TXT_ValorParcela.StylePriority.UseTextAlignment = false;
            this.TXT_ValorParcela.Text = "TXT_ValorParcela";
            this.TXT_ValorParcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.776845F, 181.0999F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(91.84521F, 16F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Parcela";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(101.6221F, 181.0999F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(89.31552F, 16F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Vencimento";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(190.9375F, 181.0999F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(103.8393F, 16F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Valor Parcela";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10.52089F, 220.0999F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(85.21472F, 18.65973F);
            this.xrLabel4.Text = "Observação:";
            // 
            // ovTXT_Observacao
            // 
            this.ovTXT_Observacao.LocationFloat = new DevExpress.Utils.PointFloat(9.776726F, 238.7596F);
            this.ovTXT_Observacao.Multiline = true;
            this.ovTXT_Observacao.Name = "ovTXT_Observacao";
            this.ovTXT_Observacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_Observacao.SizeF = new System.Drawing.SizeF(285.0001F, 18.65976F);
            this.ovTXT_Observacao.Text = "ovTXT_Observacao";
            // 
            // xrLine3
            // 
            this.xrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine3.LineWidth = 0.5F;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(9.255891F, 178.9553F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(285F, 2.144623F);
            // 
            // xrLine1
            // 
            this.xrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine1.LineWidth = 0.5F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(9.256051F, 261.0653F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(285F, 2.144623F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10.52089F, 276.6394F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(284.9998F, 15.99997F);
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "ASSINATURA";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 76.49999F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(164.3814F, 18.65973F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "Detalhes da Compra";
            // 
            // ovTXT_DetalhesCompra
            // 
            this.ovTXT_DetalhesCompra.LocationFloat = new DevExpress.Utils.PointFloat(9.999909F, 95.15972F);
            this.ovTXT_DetalhesCompra.Multiline = true;
            this.ovTXT_DetalhesCompra.Name = "ovTXT_DetalhesCompra";
            this.ovTXT_DetalhesCompra.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ovTXT_DetalhesCompra.SizeF = new System.Drawing.SizeF(285.0001F, 67.79559F);
            this.ovTXT_DetalhesCompra.Text = "ovTXT_DetalhesCompra";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(82.81248F, 292.6394F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 96F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(145.6251F, 44.79166F);
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            this.xrBarCode1.Symbology = code128Generator1;
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(10.52089F, 348.3686F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(285.0001F, 38.52475F);
            this.xrLabel7.Text = "ovTXT_ObservacaoRodape";
            // 
            // XtraCarneFinanceiro
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageWidth = 315;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.RollPaper = true;
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel TXT_Empresa;
        private DevExpress.XtraReports.UI.XRLabel TXT_Endereco;
        private DevExpress.XtraReports.UI.XRLabel TXT_Cidade;
        private DevExpress.XtraReports.UI.XRLabel TXT_Telefone;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel TXT_ValorParcela;
        private DevExpress.XtraReports.UI.XRLabel TXT_Vencimento;
        private DevExpress.XtraReports.UI.XRLabel TXT_Parcela;
        private DevExpress.XtraReports.UI.XRLabel TXT_Carne;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_Observacao;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRLabel ovTXT_DetalhesCompra;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    }
}
