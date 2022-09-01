namespace Aplicacao
{
    public partial class FormDadosSubstituto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDadosSubstituto));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUF_ST = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtIE_ST = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUF_ST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIE_ST.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 85);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(301, 85);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(382, 85);
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
            this.tpPrincipal.Controls.Add(this.txtIE_ST);
            this.tpPrincipal.Controls.Add(this.txtUF_ST);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Size = new System.Drawing.Size(439, 61);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(445, 67);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IE:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUF_ST
            // 
            this.txtUF_ST.CwkFuncaoValidacao = null;
            this.txtUF_ST.CwkMascara = null;
            this.txtUF_ST.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtUF_ST.Location = new System.Drawing.Point(49, 3);
            this.txtUF_ST.Name = "txtUF_ST";
            this.txtUF_ST.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUF_ST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtUF_ST.Properties.Mask.EditMask = "[A-Z]{2}";
            this.txtUF_ST.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtUF_ST.Properties.Mask.ShowPlaceHolders = false;
            this.txtUF_ST.Properties.MaxLength = 10;
            this.txtUF_ST.SelecionarTextoOnEnter = true;
            this.txtUF_ST.Size = new System.Drawing.Size(85, 20);
            this.txtUF_ST.TabIndex = 1;
            // 
            // txtIE_ST
            // 
            this.txtIE_ST.CwkFuncaoValidacao = null;
            this.txtIE_ST.CwkMascara = null;
            this.txtIE_ST.CwkValidacao = null;
            this.txtIE_ST.Location = new System.Drawing.Point(49, 29);
            this.txtIE_ST.Name = "txtIE_ST";
            this.txtIE_ST.Properties.MaxLength = 20;
            this.txtIE_ST.SelecionarTextoOnEnter = false;
            this.txtIE_ST.Size = new System.Drawing.Size(387, 20);
            this.txtIE_ST.TabIndex = 37;
            // 
            // FormDadosSubstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(469, 120);
            this.Name = "FormDadosSubstituto";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUF_ST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIE_ST.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtUF_ST;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtIE_ST;
    }
}
