namespace Aplicacao
{
    partial class FormFecharBalanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFecharBalanco));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLocalEstoqueStr = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFechadoEm = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIniciadoEm = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalEstoqueStr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechadoEm.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechadoEm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciadoEm.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciadoEm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 82);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(321, 82);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(402, 82);
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
            this.tpPrincipal.Controls.Add(this.txtIniciadoEm);
            this.tpPrincipal.Controls.Add(this.txtFechadoEm);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtLocalEstoqueStr);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(459, 58);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(465, 64);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Local Estoque:";
            // 
            // txtLocalEstoqueStr
            // 
            this.txtLocalEstoqueStr.CwkFuncaoValidacao = null;
            this.txtLocalEstoqueStr.CwkMascara = null;
            this.txtLocalEstoqueStr.CwkValidacao = null;
            this.txtLocalEstoqueStr.Location = new System.Drawing.Point(91, 3);
            this.txtLocalEstoqueStr.Name = "txtLocalEstoqueStr";
            this.txtLocalEstoqueStr.Properties.ReadOnly = true;
            this.txtLocalEstoqueStr.SelecionarTextoOnEnter = false;
            this.txtLocalEstoqueStr.Size = new System.Drawing.Size(358, 20);
            this.txtLocalEstoqueStr.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Iniciado em:";
            // 
            // txtFechadoEm
            // 
            this.txtFechadoEm.CwkFuncaoValidacao = null;
            this.txtFechadoEm.CwkValidacao = null;
            this.txtFechadoEm.EditValue = null;
            this.txtFechadoEm.Location = new System.Drawing.Point(349, 29);
            this.txtFechadoEm.Name = "txtFechadoEm";
            this.txtFechadoEm.Obrigatorio = true;
            this.txtFechadoEm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechadoEm.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFechadoEm.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtFechadoEm.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFechadoEm.Size = new System.Drawing.Size(100, 20);
            this.txtFechadoEm.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(281, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Fechado em:";
            // 
            // txtIniciadoEm
            // 
            this.txtIniciadoEm.CwkFuncaoValidacao = null;
            this.txtIniciadoEm.CwkValidacao = null;
            this.txtIniciadoEm.EditValue = null;
            this.txtIniciadoEm.Location = new System.Drawing.Point(91, 29);
            this.txtIniciadoEm.Name = "txtIniciadoEm";
            this.txtIniciadoEm.Obrigatorio = true;
            this.txtIniciadoEm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIniciadoEm.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtIniciadoEm.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIniciadoEm.Properties.ReadOnly = true;
            this.txtIniciadoEm.Size = new System.Drawing.Size(100, 20);
            this.txtIniciadoEm.TabIndex = 6;
            // 
            // FormFecharBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(489, 117);
            this.Name = "FormFecharBalanco";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalEstoqueStr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechadoEm.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechadoEm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciadoEm.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIniciadoEm.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLocalEstoqueStr;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtFechadoEm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtIniciadoEm;
    }
}
