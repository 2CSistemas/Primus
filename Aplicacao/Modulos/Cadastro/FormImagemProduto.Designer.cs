namespace Aplicacao
{
    partial class FormImagemProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImagemProduto));
            this.pbCaminhoFoto = new System.Windows.Forms.PictureBox();
            this.btnImagemAnterior = new DevExpress.XtraEditors.SimpleButton();
            this.btnImagemProximo = new DevExpress.XtraEditors.SimpleButton();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.txtNumeroImagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroImagem = new System.Windows.Forms.Label();
            this.ckbPrincipal = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhoFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 582);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(631, 582);
            this.sbGravar.Visible = false;
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(712, 582);
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
            this.tpPrincipal.Controls.Add(this.ckbPrincipal);
            this.tpPrincipal.Controls.Add(this.lblTotal);
            this.tpPrincipal.Controls.Add(this.lblNumeroImagem);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.txtCaminhoImagem);
            this.tpPrincipal.Controls.Add(this.txtTotal);
            this.tpPrincipal.Controls.Add(this.txtNumeroImagem);
            this.tpPrincipal.Controls.Add(this.btnImagemProximo);
            this.tpPrincipal.Controls.Add(this.btnImagemAnterior);
            this.tpPrincipal.Controls.Add(this.pbCaminhoFoto);
            this.tpPrincipal.Size = new System.Drawing.Size(769, 558);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(775, 564);
            // 
            // pbCaminhoFoto
            // 
            this.pbCaminhoFoto.BackColor = System.Drawing.Color.White;
            this.pbCaminhoFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCaminhoFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbCaminhoFoto.Image")));
            this.pbCaminhoFoto.Location = new System.Drawing.Point(12, 14);
            this.pbCaminhoFoto.Name = "pbCaminhoFoto";
            this.pbCaminhoFoto.Size = new System.Drawing.Size(744, 443);
            this.pbCaminhoFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaminhoFoto.TabIndex = 34;
            this.pbCaminhoFoto.TabStop = false;
            // 
            // btnImagemAnterior
            // 
            this.btnImagemAnterior.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImagemProdutoEsquerda.ImageOptions.Image")));
            this.btnImagemAnterior.Location = new System.Drawing.Point(12, 463);
            this.btnImagemAnterior.Name = "btnImagemAnterior";
            this.btnImagemAnterior.Size = new System.Drawing.Size(45, 28);
            this.btnImagemAnterior.TabIndex = 35;
            this.btnImagemAnterior.Click += new System.EventHandler(this.btnImagemAnterior_Click);
            // 
            // btnImagemProximo
            // 
            this.btnImagemProximo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImagemProdutoDireita.ImageOptions.Image")));
            this.btnImagemProximo.Location = new System.Drawing.Point(714, 463);
            this.btnImagemProximo.Name = "btnImagemProximo";
            this.btnImagemProximo.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnImagemProximo.Size = new System.Drawing.Size(42, 28);
            this.btnImagemProximo.TabIndex = 36;
            this.btnImagemProximo.Click += new System.EventHandler(this.btnImagemProximo_Click);
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Location = new System.Drawing.Point(12, 524);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.ReadOnly = true;
            this.txtCaminhoImagem.Size = new System.Drawing.Size(384, 21);
            this.txtCaminhoImagem.TabIndex = 42;
            // 
            // txtNumeroImagem
            // 
            this.txtNumeroImagem.Location = new System.Drawing.Point(614, 524);
            this.txtNumeroImagem.Name = "txtNumeroImagem";
            this.txtNumeroImagem.ReadOnly = true;
            this.txtNumeroImagem.Size = new System.Drawing.Size(68, 21);
            this.txtNumeroImagem.TabIndex = 43;
            this.txtNumeroImagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Caminho da Imagem";
            // 
            // lblNumeroImagem
            // 
            this.lblNumeroImagem.AutoSize = true;
            this.lblNumeroImagem.Location = new System.Drawing.Point(619, 508);
            this.lblNumeroImagem.Name = "lblNumeroImagem";
            this.lblNumeroImagem.Size = new System.Drawing.Size(60, 13);
            this.lblNumeroImagem.TabIndex = 45;
            this.lblNumeroImagem.Text = "Nº Imagem";
            // 
            // ckbPrincipal
            // 
            this.ckbPrincipal.AutoSize = true;
            this.ckbPrincipal.Enabled = false;
            this.ckbPrincipal.Location = new System.Drawing.Point(402, 528);
            this.ckbPrincipal.Name = "ckbPrincipal";
            this.ckbPrincipal.Size = new System.Drawing.Size(65, 17);
            this.ckbPrincipal.TabIndex = 46;
            this.ckbPrincipal.Text = "Principal";
            this.ckbPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(688, 524);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(68, 21);
            this.txtTotal.TabIndex = 43;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(707, 508);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "Total";
            // 
            // FormImagemProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 617);
            this.Name = "FormImagemProduto";
            this.Text = "Imagem do Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhoFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaminhoFoto;
        private DevExpress.XtraEditors.SimpleButton btnImagemAnterior;
        private DevExpress.XtraEditors.SimpleButton btnImagemProximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.TextBox txtNumeroImagem;
        private System.Windows.Forms.Label lblNumeroImagem;
        private System.Windows.Forms.CheckBox ckbPrincipal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}