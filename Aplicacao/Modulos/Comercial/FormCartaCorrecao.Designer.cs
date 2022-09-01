namespace Aplicacao
{
    partial class FormCartaCorrecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCartaCorrecao));
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTextoCorrecao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoCorrecao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 191);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(488, 191);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(569, 191);
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
            this.tpPrincipal.Controls.Add(this.txtTextoCorrecao);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.txtData);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(626, 167);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(632, 173);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtSequencia.EditValue = 0;
            this.txtSequencia.Location = new System.Drawing.Point(79, 13);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSequencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSequencia.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSequencia.Properties.Mask.ShowPlaceHolders = false;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(80, 20);
            this.txtSequencia.TabIndex = 1;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(20, 16);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sequência:";
            // 
            // txtData
            // 
            this.txtData.CwkFuncaoValidacao = null;
            this.txtData.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DATAHORA;
            this.txtData.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtData.EditValue = 0;
            this.txtData.Location = new System.Drawing.Point(233, 13);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Appearance.Options.UseTextOptions = true;
            this.txtData.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtData.Properties.DisplayFormat.FormatString = "g";
            this.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtData.Properties.EditFormat.FormatString = "g";
            this.txtData.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtData.Properties.Mask.EditMask = "g";
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.Mask.ShowPlaceHolders = false;
            this.txtData.SelecionarTextoOnEnter = true;
            this.txtData.Size = new System.Drawing.Size(114, 20);
            this.txtData.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(173, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data/Hora:";
            // 
            // txtTextoCorrecao
            // 
            this.txtTextoCorrecao.Location = new System.Drawing.Point(79, 40);
            this.txtTextoCorrecao.Name = "txtTextoCorrecao";
            this.txtTextoCorrecao.Size = new System.Drawing.Size(531, 106);
            this.txtTextoCorrecao.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(25, 42);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Correção:";
            // 
            // FormCartaCorrecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 226);
            this.Name = "FormCartaCorrecao";
            this.Text = "Carta de Correção Eletrônica";
            this.Shown += new System.EventHandler(this.FormCartaCorrecao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoCorrecao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtTextoCorrecao;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}