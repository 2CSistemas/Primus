namespace Aplicacao
{
    partial class FormTextoLei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextoLei));
            this.txtDescricaoTextoLei = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.lblIdentificador = new DevExpress.XtraEditors.LabelControl();
            this.lblPessoa = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoTextoLei.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 277);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(410, 277);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(491, 277);
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
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtDescricaoTextoLei);
            this.tpPrincipal.Controls.Add(this.lblIdentificador);
            this.tpPrincipal.Controls.Add(this.lblPessoa);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Size = new System.Drawing.Size(548, 253);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(554, 259);
            // 
            // txtDescricaoTextoLei
            // 
            this.txtDescricaoTextoLei.Location = new System.Drawing.Point(80, 59);
            this.txtDescricaoTextoLei.Name = "txtDescricaoTextoLei";
            this.txtDescricaoTextoLei.Properties.MaxLength = 5000;
            this.txtDescricaoTextoLei.Size = new System.Drawing.Size(459, 185);
            this.txtDescricaoTextoLei.TabIndex = 6;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.Location = new System.Drawing.Point(36, 10);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(37, 13);
            this.lblIdentificador.TabIndex = 1;
            this.lblIdentificador.Text = "Código:";
            // 
            // lblPessoa
            // 
            this.lblPessoa.Location = new System.Drawing.Point(26, 61);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(48, 13);
            this.lblPessoa.TabIndex = 5;
            this.lblPessoa.Text = "Texto Lei:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.Location = new System.Drawing.Point(80, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtCodigo.Properties.Mask.EditMask = "N00";
            this.txtCodigo.Properties.MaxLength = 9;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.EditValue = "";
            this.txtDescricao.Location = new System.Drawing.Point(80, 33);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtDescricao.Properties.MaxLength = 150;
            this.txtDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescricao.Size = new System.Drawing.Size(459, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // FormTextoLei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(578, 312);
            this.Name = "FormTextoLei";
            this.Text = "Texto lei";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoTextoLei.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevMemoEdit txtDescricaoTextoLei;
        private DevExpress.XtraEditors.LabelControl lblIdentificador;
        private DevExpress.XtraEditors.LabelControl lblPessoa;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
