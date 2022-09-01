
namespace Aplicacao.Modulos.Seguranca
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblVersao = new DevExpress.XtraEditors.LabelControl();
            this.sbConfigurar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblVersao.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.lblVersao.Appearance.Options.UseFont = true;
            this.lblVersao.Appearance.Options.UseForeColor = true;
            this.lblVersao.Location = new System.Drawing.Point(82, 442);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(101, 14);
            this.lblVersao.TabIndex = 10;
            this.lblVersao.Text = "Versão 4.00.001";
            // 
            // sbConfigurar
            // 
            this.sbConfigurar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sbConfigurar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.sbConfigurar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbConfigurar.Appearance.Options.UseBackColor = true;
            this.sbConfigurar.Appearance.Options.UseFont = true;
            this.sbConfigurar.Appearance.Options.UseForeColor = true;
            this.sbConfigurar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbConfigurar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbConfigurar.ImageOptions.Image")));
            this.sbConfigurar.ImageOptions.ImageIndex = 1;
            this.sbConfigurar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbConfigurar.Location = new System.Drawing.Point(23, 442);
            this.sbConfigurar.Name = "sbConfigurar";
            this.sbConfigurar.Size = new System.Drawing.Size(25, 22);
            this.sbConfigurar.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageIndex = 1;
            this.simpleButton1.Location = new System.Drawing.Point(202, 348);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 42);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "&Sair";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sbEntrar
            // 
            this.sbEntrar.Appearance.BackColor = System.Drawing.Color.White;
            this.sbEntrar.Appearance.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.sbEntrar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sbEntrar.Appearance.Options.UseBackColor = true;
            this.sbEntrar.Appearance.Options.UseFont = true;
            this.sbEntrar.Appearance.Options.UseForeColor = true;
            this.sbEntrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbEntrar.ImageOptions.Image")));
            this.sbEntrar.ImageOptions.ImageIndex = 0;
            this.sbEntrar.Location = new System.Drawing.Point(53, 348);
            this.sbEntrar.Name = "sbEntrar";
            this.sbEntrar.Size = new System.Drawing.Size(130, 42);
            this.sbEntrar.TabIndex = 7;
            this.sbEntrar.Text = "&Entrar";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicacao.Properties.Resources.TelaDeLogin;
            this.ClientSize = new System.Drawing.Size(380, 527);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.sbConfigurar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sbEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(380, 527);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbEntrar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton sbConfigurar;
        public DevExpress.XtraEditors.LabelControl lblVersao;
    }
}