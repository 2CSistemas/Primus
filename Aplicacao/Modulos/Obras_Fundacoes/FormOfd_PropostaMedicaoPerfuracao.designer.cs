namespace Aplicacao
{
    partial class FormOfd_PropostaMedicaoPerfuracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_PropostaMedicaoPerfuracao));
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbDiametro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProfundidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtEstaca = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiametro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfundidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstaca.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 112);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(272, 112);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(353, 112);
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
            this.tpPrincipal.Controls.Add(this.txtEstaca);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.txtTotal);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtProfundidade);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtQuantidade);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.cbDiametro);
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(410, 88);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(416, 94);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtSequencia.EditValue = 0;
            this.txtSequencia.Location = new System.Drawing.Point(65, 6);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSequencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSequencia.Properties.Mask.EditMask = "d";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSequencia.Properties.ReadOnly = true;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(80, 20);
            this.txtSequencia.TabIndex = 1;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sequência:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Diâmetro:";
            // 
            // cbDiametro
            // 
            this.cbDiametro.EditValue = "0,25";
            this.cbDiametro.Location = new System.Drawing.Point(65, 59);
            this.cbDiametro.Name = "cbDiametro";
            this.cbDiametro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDiametro.Properties.ImmediatePopup = true;
            this.cbDiametro.Properties.Items.AddRange(new object[] {
            "0,25",
            "0,30",
            "0,32",
            "0,38",
            "0,35",
            "0,40",
            "0,45",
            "0,50",
            "0,60",
            "0,70",
            "0,80",
            "0,90",
            "1,00",
            "1,10",
            "1,20",
            "1,30",
            "1,40",
            "1,50",
            "1,60"});
            this.cbDiametro.Properties.Tag = "";
            this.cbDiametro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDiametro.Size = new System.Drawing.Size(80, 20);
            this.cbDiametro.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(235, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtQuantidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtQuantidade.Location = new System.Drawing.Point(301, 6);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "n2";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(98, 20);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(227, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Profundidade:";
            // 
            // txtProfundidade
            // 
            this.txtProfundidade.CwkFuncaoValidacao = null;
            this.txtProfundidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtProfundidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtProfundidade.Location = new System.Drawing.Point(301, 32);
            this.txtProfundidade.Name = "txtProfundidade";
            this.txtProfundidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProfundidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProfundidade.Properties.Mask.EditMask = "N2";
            this.txtProfundidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProfundidade.Properties.Mask.ShowPlaceHolders = false;
            this.txtProfundidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProfundidade.SelecionarTextoOnEnter = false;
            this.txtProfundidade.Size = new System.Drawing.Size(98, 20);
            this.txtProfundidade.TabIndex = 9;
            this.txtProfundidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(267, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.CwkFuncaoValidacao = null;
            this.txtTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtTotal.CwkValidacao = null;
            this.txtTotal.Location = new System.Drawing.Point(301, 58);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.Mask.EditMask = "N2";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.SelecionarTextoOnEnter = false;
            this.txtTotal.Size = new System.Drawing.Size(98, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            // 
            // txtEstaca
            // 
            this.txtEstaca.CwkFuncaoValidacao = null;
            this.txtEstaca.CwkMascara = null;
            this.txtEstaca.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtEstaca.Location = new System.Drawing.Point(65, 32);
            this.txtEstaca.Name = "txtEstaca";
            this.txtEstaca.Properties.MaxLength = 20;
            this.txtEstaca.SelecionarTextoOnEnter = false;
            this.txtEstaca.Size = new System.Drawing.Size(130, 20);
            this.txtEstaca.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(23, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Estaca:";
            // 
            // FormOfd_PropostaMedicaoPerfuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(440, 147);
            this.Name = "FormOfd_PropostaMedicaoPerfuracao";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiametro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfundidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstaca.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbDiametro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtProfundidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEstaca;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
