namespace Aplicacao.Modulos.Comercial
{
    partial class FormIdentificador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIdentificador));
            this.lblIdentificador = new DevExpress.XtraEditors.LabelControl();
            this.lblPessoa = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 139);
            this.sbAjuda.TabIndex = 1;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(415, 139);
            this.sbGravar.TabIndex = 2;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(496, 139);
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
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.lblIdentificador);
            this.tpPrincipal.Controls.Add(this.lblPessoa);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Size = new System.Drawing.Size(553, 115);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(559, 121);
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.Location = new System.Drawing.Point(11, 13);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(65, 13);
            this.lblIdentificador.TabIndex = 0;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // lblPessoa
            // 
            this.lblPessoa.Location = new System.Drawing.Point(26, 39);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(50, 13);
            this.lblPessoa.TabIndex = 2;
            this.lblPessoa.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.Location = new System.Drawing.Point(82, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtCodigo.Properties.Mask.EditMask = "N00";
            this.txtCodigo.Properties.MaxLength = 9;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(82, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 150;
            this.txtDescricao.Size = new System.Drawing.Size(459, 66);
            this.txtDescricao.TabIndex = 3;
            // 
            // FormIdentificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(583, 174);
            this.Name = "FormIdentificador";
            this.Text = "Identificadores";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblIdentificador;
        private DevExpress.XtraEditors.LabelControl lblPessoa;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtDescricao;
    }
}
