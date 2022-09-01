namespace Aplicacao.Modulos.Comercial
{
    partial class FormProdutoCodBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutoCodBarra));
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.chBControleIdentificacao = new DevExpress.XtraEditors.CheckEdit();
            this.txtCodigoBarra = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chBControleIdentificacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 66);
            this.sbAjuda.TabIndex = 1;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(359, 66);
            this.sbGravar.TabIndex = 2;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(440, 66);
            this.sbCancelar.TabIndex = 3;
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
            this.tpPrincipal.Controls.Add(this.txtCodigoBarra);
            this.tpPrincipal.Controls.Add(this.chBControleIdentificacao);
            this.tpPrincipal.Controls.Add(this.labelControl33);
            this.tpPrincipal.Size = new System.Drawing.Size(496, 41);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(503, 48);
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(9, 13);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(81, 13);
            this.labelControl33.TabIndex = 0;
            this.labelControl33.Text = "Código de Barra:";
            // 
            // chBControleIdentificacao
            // 
            this.chBControleIdentificacao.CausesValidation = false;
            this.chBControleIdentificacao.Location = new System.Drawing.Point(333, 11);
            this.chBControleIdentificacao.Name = "chBControleIdentificacao";
            this.chBControleIdentificacao.Properties.Caption = "Controle de Identificação";
            this.chBControleIdentificacao.Size = new System.Drawing.Size(155, 19);
            this.chBControleIdentificacao.TabIndex = 2;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(96, 11);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Properties.MaxLength = 30;
            this.txtCodigoBarra.Size = new System.Drawing.Size(231, 20);
            this.txtCodigoBarra.TabIndex = 1;
            // 
            // FormProdutoCodBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(527, 101);
            this.Name = "FormProdutoCodBarra";
            this.Text = "Cadastro de Códigos de Barra";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chBControleIdentificacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarra.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.CheckEdit chBControleIdentificacao;
        private DevExpress.XtraEditors.TextEdit txtCodigoBarra;
    }
}
