namespace Aplicacao.UserControls
{
    partial class UCAcoesOfd_Proposta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sbAguardarAprovacao = new DevExpress.XtraEditors.SimpleButton();
            this.sbAprovar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sbAguardarAprovacao
            // 
            this.sbAguardarAprovacao.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbAguardarAprovacao.Location = new System.Drawing.Point(0, 0);
            this.sbAguardarAprovacao.Name = "sbAguardarAprovacao";
            this.sbAguardarAprovacao.Size = new System.Drawing.Size(145, 23);
            this.sbAguardarAprovacao.TabIndex = 6;
            this.sbAguardarAprovacao.Text = "Aguardar Aprovação";
            // 
            // sbAprovar
            // 
            this.sbAprovar.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbAprovar.Location = new System.Drawing.Point(0, 25);
            this.sbAprovar.Name = "sbAprovar";
            this.sbAprovar.Size = new System.Drawing.Size(145, 23);
            this.sbAprovar.TabIndex = 7;
            this.sbAprovar.Text = "Aprovar";
            // 
            // sbCancelar
            // 
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbCancelar.Location = new System.Drawing.Point(0, 50);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(145, 23);
            this.sbCancelar.TabIndex = 8;
            this.sbCancelar.Text = "Cancelar";
            // 
            // UCAcoesOfd_Proposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.sbAprovar);
            this.Controls.Add(this.sbAguardarAprovacao);
            this.Name = "UCAcoesOfd_Proposta";
            this.Size = new System.Drawing.Size(146, 75);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAguardarAprovacao;
        public DevExpress.XtraEditors.SimpleButton sbAprovar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
    }
}
