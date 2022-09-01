namespace Aplicacao
{
    partial class FormOfd_ObraDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_ObraDiario));
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescritivo = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescritivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 284);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(467, 284);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(548, 284);
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
            this.tpPrincipal.Controls.Add(this.txtDescritivo);
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(602, 257);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(611, 266);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtSequencia.EditValue = 0;
            this.txtSequencia.Location = new System.Drawing.Point(65, 6);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Mask.EditMask = "d";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(80, 20);
            this.txtSequencia.TabIndex = 7;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Descritivo:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Sequência:";
            // 
            // txtDescritivo
            // 
            this.txtDescritivo.Location = new System.Drawing.Point(65, 32);
            this.txtDescritivo.Name = "txtDescritivo";
            this.txtDescritivo.Size = new System.Drawing.Size(531, 217);
            this.txtDescritivo.TabIndex = 9;
            // 
            // FormOfd_ObraDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(635, 319);
            this.Name = "FormOfd_ObraDiario";
            this.Text = "z";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescritivo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtDescritivo;
    }
}
