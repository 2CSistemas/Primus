namespace Aplicacao
{
    partial class FormOfd_PropostaPerfuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_PropostaPerfuracoes));
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbDiametro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorUnitario = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstaca = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProfundidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiametro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstaca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfundidade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 141);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(310, 141);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(391, 141);
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
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.txtValorUnitario);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.cbDiametro);
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(448, 117);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(454, 123);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtSequencia.EditValue = 0;
            this.txtSequencia.Location = new System.Drawing.Point(84, 8);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Mask.EditMask = "d";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(80, 20);
            this.txtSequencia.TabIndex = 2;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 11);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sequência:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Diâmetro:";
            // 
            // cbDiametro
            // 
            this.cbDiametro.EditValue = "0,25";
            this.cbDiametro.Location = new System.Drawing.Point(84, 61);
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
            this.cbDiametro.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 90);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Valor Unitário:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.CwkFuncaoValidacao = null;
            this.txtValorUnitario.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorUnitario.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtValorUnitario.Location = new System.Drawing.Point(84, 87);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorUnitario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorUnitario.Properties.Mask.EditMask = "c2";
            this.txtValorUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorUnitario.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorUnitario.SelecionarTextoOnEnter = false;
            this.txtValorUnitario.Size = new System.Drawing.Size(98, 20);
            this.txtValorUnitario.TabIndex = 14;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtQuantidade.CwkValidacao = null;
            this.txtQuantidade.Location = new System.Drawing.Point(338, 8);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "N4";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(98, 20);
            this.txtQuantidade.TabIndex = 4;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(272, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Quantidade:";
            // 
            // txtEstaca
            // 
            this.txtEstaca.CwkFuncaoValidacao = null;
            this.txtEstaca.CwkMascara = null;
            this.txtEstaca.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtEstaca.Location = new System.Drawing.Point(84, 35);
            this.txtEstaca.Name = "txtEstaca";
            this.txtEstaca.Properties.MaxLength = 20;
            this.txtEstaca.SelecionarTextoOnEnter = false;
            this.txtEstaca.Size = new System.Drawing.Size(130, 20);
            this.txtEstaca.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(42, 38);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Estaca:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(237, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Total Profundidade:";
            // 
            // txtTotal
            // 
            this.txtTotal.CwkFuncaoValidacao = null;
            this.txtTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtTotal.CwkValidacao = null;
            this.txtTotal.Location = new System.Drawing.Point(338, 61);
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
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(264, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Profundidade:";
            // 
            // txtProfundidade
            // 
            this.txtProfundidade.CwkFuncaoValidacao = null;
            this.txtProfundidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtProfundidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtProfundidade.Location = new System.Drawing.Point(338, 35);
            this.txtProfundidade.Name = "txtProfundidade";
            this.txtProfundidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProfundidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProfundidade.Properties.Mask.EditMask = "N2";
            this.txtProfundidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProfundidade.Properties.Mask.ShowPlaceHolders = false;
            this.txtProfundidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProfundidade.SelecionarTextoOnEnter = false;
            this.txtProfundidade.Size = new System.Drawing.Size(98, 20);
            this.txtProfundidade.TabIndex = 8;
            this.txtProfundidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // FormOfd_PropostaPerfuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(478, 176);
            this.Name = "FormOfd_PropostaPerfuracoes";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiametro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstaca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfundidade.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbDiametro;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorUnitario;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEstaca;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtProfundidade;
    }
}
