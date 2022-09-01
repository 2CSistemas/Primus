namespace Aplicacao
{
    partial class FormFiltroABC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltroABC));
            this.txtDtFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDtInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(166, 41);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 6;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(58, 41);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Período:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(144, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "até";
            // 
            // sbConsultar
            // 
            this.sbConsultar.ImageIndex = 0;
            this.sbConsultar.ImageList = this.imageList1;
            this.sbConsultar.Location = new System.Drawing.Point(58, 67);
            this.sbConsultar.Name = "sbConsultar";
            this.sbConsultar.Size = new System.Drawing.Size(298, 23);
            this.sbConsultar.TabIndex = 7;
            this.sbConsultar.Text = "&Consultar";
            this.sbConsultar.Click += new System.EventHandler(this.sbConsultar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Consulta copy.ico");
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(362, 15);
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.TabIndex = 2;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkFilial
            // 
            this.lkFilial.ButtonLookup = this.lkbFilial;
            this.lkFilial.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkFilial.ContextoLinq = null;
            this.lkFilial.ID = 0;
            this.lkFilial.Join = null;
            this.lkFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkFilial.Location = new System.Drawing.Point(58, 15);
            this.lkFilial.Name = "lkFilial";
            this.lkFilial.OnIDChanged = null;
            this.lkFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkFilial.Size = new System.Drawing.Size(298, 20);
            this.lkFilial.Tabela = "Filial";
            this.lkFilial.TabIndex = 1;
            this.lkFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkFilial.Where = null;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Empresa:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormFiltroABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 104);
            this.Controls.Add(this.lkbFilial);
            this.Controls.Add(this.lkFilial);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.sbConsultar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDtFinal);
            this.Controls.Add(this.txtDtInicial);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFiltroABC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curva ABC";
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtFinal;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtInicial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbConsultar;
        private System.Windows.Forms.ImageList imageList1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkFilial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}