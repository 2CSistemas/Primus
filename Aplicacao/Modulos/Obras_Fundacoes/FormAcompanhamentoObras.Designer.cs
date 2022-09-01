namespace Aplicacao.Modulos.Obras_Fundacoes
{
    partial class FormAcompanhamentoObras
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.ucGrupoEmpresas1 = new Aplicacao.Relatorios.Base.UcGrupoEmpresas();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(711, 269);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucGrupoEmpresas1);
            this.tabPage1.Controls.Add(this.txtReferencia);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Size = new System.Drawing.Size(705, 263);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(569, 287);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(648, 287);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 291);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 287);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 236);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Mês:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkMascara = null;
            this.txtReferencia.CwkValidacao = null;
            this.txtReferencia.Location = new System.Drawing.Point(46, 233);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.SelecionarTextoOnEnter = false;
            this.txtReferencia.Size = new System.Drawing.Size(139, 20);
            this.txtReferencia.TabIndex = 14;
            // 
            // ucGrupoEmpresas1
            // 
            this.ucGrupoEmpresas1.BackColor = System.Drawing.Color.Transparent;
            this.ucGrupoEmpresas1.CustomSort = null;
            this.ucGrupoEmpresas1.Location = new System.Drawing.Point(7, 4);
            this.ucGrupoEmpresas1.Name = "ucGrupoEmpresas1";
            this.ucGrupoEmpresas1.Size = new System.Drawing.Size(690, 223);
            this.ucGrupoEmpresas1.TabIndex = 15;
            // 
            // FormAcompanhamentoObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(735, 316);
            this.Name = "FormAcompanhamentoObras";
            this.Text = "Relátorio p/ Acompanhamento das Máquinas nas Obras";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtReferencia;
        private Aplicacao.Relatorios.Base.UcGrupoEmpresas ucGrupoEmpresas1;
    }
}
