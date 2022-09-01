namespace Aplicacao
{
    partial class FormOfd_MedicaoServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_MedicaoServicos));
            this.txtEstaca = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbDiametro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTotalMedicao = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMetros = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstaca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiametro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMedicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMetros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 141);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(244, 141);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(325, 141);
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
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.txtMetros);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.txtTotalMedicao);
            this.tpPrincipal.Controls.Add(this.labelControl12);
            this.tpPrincipal.Controls.Add(this.txtEstaca);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.cbDiametro);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtQuantidade);
            this.tpPrincipal.Size = new System.Drawing.Size(381, 116);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(388, 123);
            // 
            // txtEstaca
            // 
            this.txtEstaca.CwkFuncaoValidacao = null;
            this.txtEstaca.CwkMascara = null;
            this.txtEstaca.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtEstaca.Location = new System.Drawing.Point(68, 36);
            this.txtEstaca.Name = "txtEstaca";
            this.txtEstaca.Properties.MaxLength = 20;
            this.txtEstaca.SelecionarTextoOnEnter = false;
            this.txtEstaca.Size = new System.Drawing.Size(130, 20);
            this.txtEstaca.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 39);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Estaca:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(208, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtQuantidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtQuantidade.Location = new System.Drawing.Point(274, 10);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "N4";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(98, 20);
            this.txtQuantidade.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Diâmetro:";
            // 
            // cbDiametro
            // 
            this.cbDiametro.EditValue = "0,25";
            this.cbDiametro.Location = new System.Drawing.Point(68, 63);
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
            this.cbDiametro.TabIndex = 11;
            // 
            // txtTotalMedicao
            // 
            this.txtTotalMedicao.Location = new System.Drawing.Point(274, 89);
            this.txtTotalMedicao.Name = "txtTotalMedicao";
            this.txtTotalMedicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtTotalMedicao.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalMedicao.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtTotalMedicao.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTotalMedicao.Properties.DisplayFormat.FormatString = "C2";
            this.txtTotalMedicao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalMedicao.Properties.EditFormat.FormatString = "C2";
            this.txtTotalMedicao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalMedicao.Properties.Precision = 2;
            this.txtTotalMedicao.Properties.ReadOnly = true;
            this.txtTotalMedicao.Size = new System.Drawing.Size(98, 20);
            this.txtTotalMedicao.TabIndex = 45;
            this.txtTotalMedicao.TabStop = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(240, 92);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(28, 13);
            this.labelControl12.TabIndex = 44;
            this.labelControl12.Text = "Total:";
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtValor.Location = new System.Drawing.Point(274, 63);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "N4";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(98, 20);
            this.txtValor.TabIndex = 46;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(240, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Valor:";
            // 
            // txtMetros
            // 
            this.txtMetros.CwkFuncaoValidacao = null;
            this.txtMetros.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtMetros.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtMetros.Location = new System.Drawing.Point(274, 36);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMetros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMetros.Properties.Mask.EditMask = "N4";
            this.txtMetros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMetros.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMetros.SelecionarTextoOnEnter = false;
            this.txtMetros.Size = new System.Drawing.Size(98, 20);
            this.txtMetros.TabIndex = 48;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(231, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Metros:";
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtSequencia.EditValue = 0;
            this.txtSequencia.Location = new System.Drawing.Point(68, 10);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSequencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSequencia.Properties.Mask.EditMask = "d";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSequencia.Properties.ReadOnly = true;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(80, 20);
            this.txtSequencia.TabIndex = 5;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Sequência:";
            // 
            // FormOfd_MedicaoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(412, 176);
            this.Name = "FormOfd_MedicaoServicos";
            this.Text = "Cadastro de Serviços de Medições";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEstaca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDiametro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalMedicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMetros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEstaca;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbDiametro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtMetros;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotalMedicao;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
