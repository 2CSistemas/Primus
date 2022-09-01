namespace Aplicacao
{
    partial class FormEnviaEmailOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviaEmailOS));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorpo = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDestinatario = new DevExpress.XtraRichEdit.RichEditControl();
            this.txtAssunto = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.lbAtt = new DevExpress.XtraEditors.LabelControl();
            this.lbAtributos = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbAtributos)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Image = null;
            this.sbAjuda.Location = new System.Drawing.Point(12, 365);
            this.sbAjuda.Text = "Ajuda";
            // 
            // sbGravar
            // 
            this.sbGravar.Enabled = false;
            this.sbGravar.Image = global::Aplicacao.Properties.Resources._1371664476_14028;
            this.sbGravar.Location = new System.Drawing.Point(580, 365);
            this.sbGravar.Text = "Enviar";
            this.sbGravar.Visible = false;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.Location = new System.Drawing.Point(661, 365);
            this.sbCancelar.Text = "Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
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
            this.tpPrincipal.Controls.Add(this.lbAtt);
            this.tpPrincipal.Controls.Add(this.lbAtributos);
            this.tpPrincipal.Controls.Add(this.txtAssunto);
            this.tpPrincipal.Controls.Add(this.txtDestinatario);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtCorpo);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(723, 341);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(729, 347);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Assunto:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Destinatário:";
            // 
            // txtCorpo
            // 
            this.txtCorpo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtCorpo.Appearance.Text.Options.UseFont = true;
            this.txtCorpo.Location = new System.Drawing.Point(84, 55);
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Options.MailMerge.KeepLastParagraph = false;
            this.txtCorpo.Size = new System.Drawing.Size(392, 270);
            this.txtCorpo.TabIndex = 11;
            this.txtCorpo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCorpo_DragDrop);
            this.txtCorpo.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtCorpo_DragEnter);
            this.txtCorpo.DragOver += new System.Windows.Forms.DragEventHandler(this.txtCorpo_DragOver);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Corpo E-mail:";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtDestinatario.Appearance.Text.Options.UseFont = true;
            this.txtDestinatario.Appearance.Text.Options.UseTextOptions = true;
            this.txtDestinatario.Appearance.Text.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtDestinatario.Location = new System.Drawing.Point(84, 3);
            this.txtDestinatario.Margin = new System.Windows.Forms.Padding(1);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Options.MailMerge.KeepLastParagraph = false;
            this.txtDestinatario.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.txtDestinatario.Size = new System.Drawing.Size(394, 21);
            this.txtDestinatario.TabIndex = 13;
            // 
            // txtAssunto
            // 
            this.txtAssunto.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtAssunto.Appearance.Text.Options.UseFont = true;
            this.txtAssunto.Appearance.Text.Options.UseTextOptions = true;
            this.txtAssunto.Appearance.Text.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtAssunto.Location = new System.Drawing.Point(84, 30);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(1);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Options.MailMerge.KeepLastParagraph = false;
            this.txtAssunto.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.txtAssunto.Size = new System.Drawing.Size(392, 21);
            this.txtAssunto.TabIndex = 14;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::Aplicacao.Properties.Resources._1371664476_14028;
            this.btnIncluir.Location = new System.Drawing.Point(580, 365);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Enviar";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lbAtt
            // 
            this.lbAtt.Location = new System.Drawing.Point(482, 6);
            this.lbAtt.Name = "lbAtt";
            this.lbAtt.Size = new System.Drawing.Size(48, 13);
            this.lbAtt.TabIndex = 23;
            this.lbAtt.Text = "Atributos:";
            // 
            // lbAtributos
            // 
            this.lbAtributos.Location = new System.Drawing.Point(482, 22);
            this.lbAtributos.Name = "lbAtributos";
            this.lbAtributos.Size = new System.Drawing.Size(229, 302);
            this.lbAtributos.TabIndex = 22;
            this.lbAtributos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAtributos_MouseDown);
            // 
            // FormEnviaEmailOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(753, 400);
            this.Controls.Add(this.btnIncluir);
            this.Name = "FormEnviaEmailOS";
            this.Text = "Enviar E-mail OS";
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbAtributos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraRichEdit.RichEditControl txtCorpo;
        private DevExpress.XtraRichEdit.RichEditControl txtDestinatario;
        private DevExpress.XtraRichEdit.RichEditControl txtAssunto;
        private DevExpress.XtraEditors.SimpleButton btnIncluir;
        private DevExpress.XtraEditors.LabelControl lbAtt;
        private DevExpress.XtraEditors.ListBoxControl lbAtributos;
    }
}
