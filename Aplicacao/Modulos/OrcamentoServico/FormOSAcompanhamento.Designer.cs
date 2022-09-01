namespace Aplicacao
{
    partial class FormOSAcompanhamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSAcompanhamento));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtHora = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOcorrencia = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.txtUsuario = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOcorrencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 185);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(350, 185);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(431, 185);
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
            this.tpPrincipal.Controls.Add(this.txtUsuario);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.txtOcorrencia);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtHora);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtData);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(485, 158);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(494, 167);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.CwkFuncaoValidacao = null;
            this.txtData.CwkMascara = null;
            this.txtData.CwkValidacao = null;
            this.txtData.Location = new System.Drawing.Point(69, 3);
            this.txtData.Name = "txtData";
            this.txtData.Properties.DisplayFormat.FormatString = "d";
            this.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.EditFormat.FormatString = "d";
            this.txtData.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.Mask.EditMask = "d";
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.SelecionarTextoOnEnter = false;
            this.txtData.Size = new System.Drawing.Size(71, 20);
            this.txtData.TabIndex = 1;
            // 
            // txtHora
            // 
            this.txtHora.CwkFuncaoValidacao = null;
            this.txtHora.CwkMascara = null;
            this.txtHora.CwkValidacao = null;
            this.txtHora.Location = new System.Drawing.Point(69, 29);
            this.txtHora.Name = "txtHora";
            this.txtHora.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtHora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHora.SelecionarTextoOnEnter = false;
            this.txtHora.Size = new System.Drawing.Size(71, 20);
            this.txtHora.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hora:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ocorrência:";
            // 
            // txtOcorrencia
            // 
            this.txtOcorrencia.Location = new System.Drawing.Point(69, 56);
            this.txtOcorrencia.Name = "txtOcorrencia";
            this.txtOcorrencia.Size = new System.Drawing.Size(408, 96);
            this.txtOcorrencia.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.CwkFuncaoValidacao = null;
            this.txtUsuario.CwkMascara = null;
            this.txtUsuario.CwkValidacao = null;
            this.txtUsuario.Location = new System.Drawing.Point(350, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.SelecionarTextoOnEnter = false;
            this.txtUsuario.Size = new System.Drawing.Size(127, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(304, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Usuário:";
            // 
            // FormOSAcompanhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(518, 220);
            this.Name = "FormOSAcompanhamento";
            this.Shown += new System.EventHandler(this.FormOSAcompanhamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOcorrencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtOcorrencia;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtHora;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
