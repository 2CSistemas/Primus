namespace Aplicacao
{
    partial class FormManutGeraBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutGeraBanco));
            this.txtPedido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbCaminho = new Componentes.devexpress.cwk_DevButton();
            this.txtCaminho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(556, 65);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtPedido);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.sbCaminho);
            this.xtraTabPage1.Controls.Add(this.txtCaminho);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Size = new System.Drawing.Size(547, 56);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(493, 83);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(412, 83);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 83);
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(59, 3);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPedido.Properties.Appearance.Options.UseBackColor = true;
            this.txtPedido.Properties.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(483, 20);
            this.txtPedido.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Pedido:";
            // 
            // sbCaminho
            // 
            this.sbCaminho.Location = new System.Drawing.Point(518, 29);
            this.sbCaminho.Name = "sbCaminho";
            this.sbCaminho.Size = new System.Drawing.Size(24, 20);
            this.sbCaminho.TabIndex = 9;
            this.sbCaminho.TabStop = false;
            this.sbCaminho.Text = "...";
            this.sbCaminho.Click += new System.EventHandler(this.sbCaminho_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(59, 29);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(453, 20);
            this.txtCaminho.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Dir. Saída:";
            // 
            // FormManutGeraBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(580, 118);
            this.Name = "FormManutGeraBanco";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminho.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPedido;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Componentes.devexpress.cwk_DevButton sbCaminho;
        private DevExpress.XtraEditors.TextEdit txtCaminho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
