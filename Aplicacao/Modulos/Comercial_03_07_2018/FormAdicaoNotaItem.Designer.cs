namespace Aplicacao
{
    partial class FormAdicaoNotaItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicaoNotaItem));
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.txtI30_xPed = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.txtI28_cFabricante = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.txtI26_nAdicao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtI27_nSeqAdic = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtI29_vDescDI = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtI31_nItemPed = new Cwork.Utilitarios.Componentes.DevTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtI30_xPed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI28_cFabricante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI26_nAdicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI27_nSeqAdic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI29_vDescDI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI31_nItemPed.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 113);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(319, 113);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(400, 113);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.txtI31_nItemPed);
            this.tpPrincipal.Controls.Add(this.txtI29_vDescDI);
            this.tpPrincipal.Controls.Add(this.txtI27_nSeqAdic);
            this.tpPrincipal.Controls.Add(this.txtI26_nAdicao);
            this.tpPrincipal.Controls.Add(this.labelControl39);
            this.tpPrincipal.Controls.Add(this.labelControl38);
            this.tpPrincipal.Controls.Add(this.txtI30_xPed);
            this.tpPrincipal.Controls.Add(this.labelControl37);
            this.tpPrincipal.Controls.Add(this.labelControl36);
            this.tpPrincipal.Controls.Add(this.txtI28_cFabricante);
            this.tpPrincipal.Controls.Add(this.labelControl35);
            this.tpPrincipal.Controls.Add(this.labelControl34);
            this.tpPrincipal.Size = new System.Drawing.Size(454, 86);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(463, 95);
            // 
            // labelControl39
            // 
            this.labelControl39.Location = new System.Drawing.Point(257, 61);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(101, 13);
            this.labelControl39.TabIndex = 10;
            this.labelControl39.Text = "Item Pedido Compra:";
            // 
            // labelControl38
            // 
            this.labelControl38.Location = new System.Drawing.Point(6, 61);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(104, 13);
            this.labelControl38.TabIndex = 8;
            this.labelControl38.Text = "Num. Pedido Compra:";
            // 
            // txtI30_xPed
            // 
            this.txtI30_xPed.CwkFuncaoValidacao = null;
            this.txtI30_xPed.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtI30_xPed.CwkValidacao = null;
            this.txtI30_xPed.Location = new System.Drawing.Point(116, 58);
            this.txtI30_xPed.Name = "txtI30_xPed";
            this.txtI30_xPed.Properties.Appearance.Options.UseTextOptions = true;
            this.txtI30_xPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtI30_xPed.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtI30_xPed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtI30_xPed.Properties.Mask.ShowPlaceHolders = false;
            this.txtI30_xPed.Properties.MaxLength = 6;
            this.txtI30_xPed.SelecionarTextoOnEnter = true;
            this.txtI30_xPed.Size = new System.Drawing.Size(103, 20);
            this.txtI30_xPed.TabIndex = 9;
            this.txtI30_xPed.ToolTip = "Número do Pedido de Compra";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(269, 35);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(89, 13);
            this.labelControl37.TabIndex = 6;
            this.labelControl37.Text = "Valor desconto DI:";
            // 
            // labelControl36
            // 
            this.labelControl36.Location = new System.Drawing.Point(27, 35);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(83, 13);
            this.labelControl36.TabIndex = 4;
            this.labelControl36.Text = "Cód. frabricante:";
            // 
            // txtI28_cFabricante
            // 
            this.txtI28_cFabricante.CwkFuncaoValidacao = null;
            this.txtI28_cFabricante.CwkMascara = null;
            this.txtI28_cFabricante.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtI28_cFabricante.Location = new System.Drawing.Point(116, 32);
            this.txtI28_cFabricante.Name = "txtI28_cFabricante";
            this.txtI28_cFabricante.Properties.MaxLength = 60;
            this.txtI28_cFabricante.SelecionarTextoOnEnter = true;
            this.txtI28_cFabricante.Size = new System.Drawing.Size(103, 20);
            this.txtI28_cFabricante.TabIndex = 5;
            this.txtI28_cFabricante.ToolTip = "Código do fabricante estrangeiro";
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(271, 9);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(87, 13);
            this.labelControl35.TabIndex = 2;
            this.labelControl35.Text = "Num. seq. adição:";
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(47, 9);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(63, 13);
            this.labelControl34.TabIndex = 0;
            this.labelControl34.Text = "Num. adição:";
            // 
            // txtI26_nAdicao
            // 
            this.txtI26_nAdicao.CwkFuncaoValidacao = null;
            this.txtI26_nAdicao.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtI26_nAdicao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtI26_nAdicao.Location = new System.Drawing.Point(116, 6);
            this.txtI26_nAdicao.Name = "txtI26_nAdicao";
            this.txtI26_nAdicao.Properties.Appearance.Options.UseTextOptions = true;
            this.txtI26_nAdicao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtI26_nAdicao.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtI26_nAdicao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtI26_nAdicao.Properties.Mask.ShowPlaceHolders = false;
            this.txtI26_nAdicao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtI26_nAdicao.Properties.MaxLength = 3;
            this.txtI26_nAdicao.SelecionarTextoOnEnter = true;
            this.txtI26_nAdicao.Size = new System.Drawing.Size(51, 20);
            this.txtI26_nAdicao.TabIndex = 1;
            this.txtI26_nAdicao.ToolTip = "Numero da adição";
            // 
            // txtI27_nSeqAdic
            // 
            this.txtI27_nSeqAdic.CwkFuncaoValidacao = null;
            this.txtI27_nSeqAdic.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtI27_nSeqAdic.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtI27_nSeqAdic.Location = new System.Drawing.Point(364, 6);
            this.txtI27_nSeqAdic.Name = "txtI27_nSeqAdic";
            this.txtI27_nSeqAdic.Properties.Appearance.Options.UseTextOptions = true;
            this.txtI27_nSeqAdic.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtI27_nSeqAdic.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtI27_nSeqAdic.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtI27_nSeqAdic.Properties.Mask.ShowPlaceHolders = false;
            this.txtI27_nSeqAdic.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtI27_nSeqAdic.Properties.MaxLength = 3;
            this.txtI27_nSeqAdic.SelecionarTextoOnEnter = true;
            this.txtI27_nSeqAdic.Size = new System.Drawing.Size(83, 20);
            this.txtI27_nSeqAdic.TabIndex = 3;
            this.txtI27_nSeqAdic.ToolTip = "Numero seqüencial do item dentro da adição";
            // 
            // txtI29_vDescDI
            // 
            this.txtI29_vDescDI.CwkFuncaoValidacao = null;
            this.txtI29_vDescDI.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtI29_vDescDI.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtI29_vDescDI.Location = new System.Drawing.Point(364, 32);
            this.txtI29_vDescDI.Name = "txtI29_vDescDI";
            this.txtI29_vDescDI.Properties.Appearance.Options.UseTextOptions = true;
            this.txtI29_vDescDI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtI29_vDescDI.Properties.Mask.EditMask = "c2";
            this.txtI29_vDescDI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtI29_vDescDI.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtI29_vDescDI.SelecionarTextoOnEnter = true;
            this.txtI29_vDescDI.Size = new System.Drawing.Size(83, 20);
            this.txtI29_vDescDI.TabIndex = 7;
            this.txtI29_vDescDI.ToolTip = "Valor do desconto do item da DI – adição";
            // 
            // txtI31_nItemPed
            // 
            this.txtI31_nItemPed.CwkFuncaoValidacao = null;
            this.txtI31_nItemPed.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtI31_nItemPed.CwkValidacao = null;
            this.txtI31_nItemPed.Location = new System.Drawing.Point(364, 58);
            this.txtI31_nItemPed.Name = "txtI31_nItemPed";
            this.txtI31_nItemPed.Properties.Appearance.Options.UseTextOptions = true;
            this.txtI31_nItemPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtI31_nItemPed.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtI31_nItemPed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtI31_nItemPed.Properties.Mask.ShowPlaceHolders = false;
            this.txtI31_nItemPed.Properties.MaxLength = 6;
            this.txtI31_nItemPed.SelecionarTextoOnEnter = true;
            this.txtI31_nItemPed.Size = new System.Drawing.Size(83, 20);
            this.txtI31_nItemPed.TabIndex = 11;
            this.txtI31_nItemPed.ToolTip = "Item do Pedido de Compra";
            // 
            // FormAdicaoNotaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(487, 148);
            this.Name = "FormAdicaoNotaItem";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtI30_xPed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI28_cFabricante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI26_nAdicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI27_nSeqAdic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI29_vDescDI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI31_nItemPed.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtI30_xPed;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtI28_cFabricante;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtI26_nAdicao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtI27_nSeqAdic;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtI29_vDescDI;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtI31_nItemPed;

    }
}
