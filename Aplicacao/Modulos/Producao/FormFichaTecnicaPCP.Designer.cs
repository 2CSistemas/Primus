namespace Aplicacao
{
    partial class FormFichaTecnicaPCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFichaTecnicaPCP));
            this.tcVersao = new DevExpress.XtraTab.XtraTabControl();
            this.tpAdicionar = new DevExpress.XtraTab.XtraTabPage();
            this.sbExcluiFichaTecnica = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcVersao)).BeginInit();
            this.tcVersao.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 682);
            this.sbAjuda.TabIndex = 32;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(744, 682);
            this.sbGravar.TabIndex = 30;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(825, 682);
            this.sbCancelar.TabIndex = 31;
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
            this.tpPrincipal.Controls.Add(this.tcVersao);
            this.tpPrincipal.Size = new System.Drawing.Size(882, 658);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(888, 664);
            // 
            // tcVersao
            // 
            this.tcVersao.Location = new System.Drawing.Point(3, 3);
            this.tcVersao.Name = "tcVersao";
            this.tcVersao.SelectedTabPage = this.tpAdicionar;
            this.tcVersao.Size = new System.Drawing.Size(881, 657);
            this.tcVersao.TabIndex = 1;
            this.tcVersao.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpAdicionar});
            this.tcVersao.DoubleClick += new System.EventHandler(this.tcVersao_DoubleClick);
            this.tcVersao.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcVersao_SelectedPageChanged);
            // 
            // tpAdicionar
            // 
            this.tpAdicionar.Name = "tpAdicionar";
            this.tpAdicionar.Size = new System.Drawing.Size(875, 631);
            this.tpAdicionar.Text = "+";
            // 
            // sbExcluiFichaTecnica
            // 
            this.sbExcluiFichaTecnica.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbExcluiFichaTecnica.Location = new System.Drawing.Point(93, 682);
            this.sbExcluiFichaTecnica.Name = "sbExcluiFichaTecnica";
            this.sbExcluiFichaTecnica.Size = new System.Drawing.Size(138, 23);
            this.sbExcluiFichaTecnica.TabIndex = 70;
            this.sbExcluiFichaTecnica.Text = "Excluir Ficha Técnica";
            this.sbExcluiFichaTecnica.Click += new System.EventHandler(this.sbExcluiFichaTecnica_Click);
            // 
            // FormFichaTecnicaPCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(912, 717);
            this.Controls.Add(this.sbExcluiFichaTecnica);
            this.Name = "FormFichaTecnicaPCP";
            this.Shown += new System.EventHandler(this.FormFichaTecnicaPCP_Shown);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            this.Controls.SetChildIndex(this.sbExcluiFichaTecnica, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcVersao)).EndInit();
            this.tcVersao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcVersao;
        private DevExpress.XtraTab.XtraTabPage tpAdicionar;
        private DevExpress.XtraEditors.SimpleButton sbExcluiFichaTecnica;


    }
}
