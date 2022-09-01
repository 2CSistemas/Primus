namespace Aplicacao
{
    partial class FormManutEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutEmail));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.chbFinanceiro = new DevExpress.XtraEditors.CheckEdit();
            this.chbCompra = new DevExpress.XtraEditors.CheckEdit();
            this.chbVenda = new DevExpress.XtraEditors.CheckEdit();
            this.chbAdministrativo = new DevExpress.XtraEditors.CheckEdit();
            this.chbContato = new DevExpress.XtraEditors.CheckEdit();
            this.chbSugestao = new DevExpress.XtraEditors.CheckEdit();
            this.chbMsn = new DevExpress.XtraEditors.CheckEdit();
            this.grupoTipo = new DevExpress.XtraEditors.GroupControl();
            this.chbNFe = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFinanceiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAdministrativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbContato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSugestao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMsn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoTipo)).BeginInit();
            this.grupoTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbNFe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(372, 131);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grupoTipo);
            this.xtraTabPage1.Controls.Add(this.txtEmail);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Size = new System.Drawing.Size(363, 122);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(309, 149);
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click_1);
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
            this.sbGravar.Location = new System.Drawing.Point(228, 149);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 149);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.Location = new System.Drawing.Point(45, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(295, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // chbFinanceiro
            // 
            this.chbFinanceiro.Location = new System.Drawing.Point(5, 23);
            this.chbFinanceiro.Name = "chbFinanceiro";
            this.chbFinanceiro.Properties.Caption = "Financeiro";
            this.chbFinanceiro.Size = new System.Drawing.Size(75, 19);
            this.chbFinanceiro.TabIndex = 0;
            // 
            // chbCompra
            // 
            this.chbCompra.Location = new System.Drawing.Point(190, 48);
            this.chbCompra.Name = "chbCompra";
            this.chbCompra.Properties.Caption = "Compra";
            this.chbCompra.Size = new System.Drawing.Size(64, 19);
            this.chbCompra.TabIndex = 6;
            // 
            // chbVenda
            // 
            this.chbVenda.Location = new System.Drawing.Point(86, 48);
            this.chbVenda.Name = "chbVenda";
            this.chbVenda.Properties.Caption = "Venda";
            this.chbVenda.Size = new System.Drawing.Size(56, 19);
            this.chbVenda.TabIndex = 5;
            // 
            // chbAdministrativo
            // 
            this.chbAdministrativo.Location = new System.Drawing.Point(86, 23);
            this.chbAdministrativo.Name = "chbAdministrativo";
            this.chbAdministrativo.Properties.Caption = "Administrativo";
            this.chbAdministrativo.Size = new System.Drawing.Size(96, 19);
            this.chbAdministrativo.TabIndex = 1;
            // 
            // chbContato
            // 
            this.chbContato.Location = new System.Drawing.Point(5, 48);
            this.chbContato.Name = "chbContato";
            this.chbContato.Properties.Caption = "Contato";
            this.chbContato.Size = new System.Drawing.Size(67, 19);
            this.chbContato.TabIndex = 4;
            // 
            // chbSugestao
            // 
            this.chbSugestao.Location = new System.Drawing.Point(190, 23);
            this.chbSugestao.Name = "chbSugestao";
            this.chbSugestao.Properties.Caption = "Sugestão";
            this.chbSugestao.Size = new System.Drawing.Size(75, 19);
            this.chbSugestao.TabIndex = 2;
            // 
            // chbMsn
            // 
            this.chbMsn.Location = new System.Drawing.Point(275, 23);
            this.chbMsn.Name = "chbMsn";
            this.chbMsn.Properties.Caption = "MSN";
            this.chbMsn.Size = new System.Drawing.Size(49, 19);
            this.chbMsn.TabIndex = 3;
            // 
            // grupoTipo
            // 
            this.grupoTipo.Controls.Add(this.chbNFe);
            this.grupoTipo.Controls.Add(this.chbAdministrativo);
            this.grupoTipo.Controls.Add(this.chbMsn);
            this.grupoTipo.Controls.Add(this.chbFinanceiro);
            this.grupoTipo.Controls.Add(this.chbSugestao);
            this.grupoTipo.Controls.Add(this.chbCompra);
            this.grupoTipo.Controls.Add(this.chbContato);
            this.grupoTipo.Controls.Add(this.chbVenda);
            this.grupoTipo.Location = new System.Drawing.Point(11, 10);
            this.grupoTipo.Name = "grupoTipo";
            this.grupoTipo.Size = new System.Drawing.Size(329, 73);
            this.grupoTipo.TabIndex = 1;
            this.grupoTipo.Text = "Tipo";
            // 
            // chbNFe
            // 
            this.chbNFe.Location = new System.Drawing.Point(275, 49);
            this.chbNFe.Name = "chbNFe";
            this.chbNFe.Properties.Caption = "NFe";
            this.chbNFe.Size = new System.Drawing.Size(49, 19);
            this.chbNFe.TabIndex = 7;
            // 
            // FormManutEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(396, 184);
            this.Name = "FormManutEmail";
            this.Text = "Cadastro de Email";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFinanceiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAdministrativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbContato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSugestao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMsn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoTipo)).EndInit();
            this.grupoTipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbNFe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chbFinanceiro;
        private DevExpress.XtraEditors.CheckEdit chbMsn;
        private DevExpress.XtraEditors.CheckEdit chbSugestao;
        private DevExpress.XtraEditors.CheckEdit chbContato;
        private DevExpress.XtraEditors.CheckEdit chbAdministrativo;
        private DevExpress.XtraEditors.CheckEdit chbVenda;
        private DevExpress.XtraEditors.CheckEdit chbCompra;
        private DevExpress.XtraEditors.GroupControl grupoTipo;
        private DevExpress.XtraEditors.CheckEdit chbNFe;
    }
}
