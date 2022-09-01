namespace Aplicacao.Util.Telas
{
    partial class FormEscolheImpressorasPRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscolheImpressorasPRN));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkpImpresora = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbImpressora = new Cwork.Utilitarios.Componentes.LookupButton();
            this.btnAbrePastaLayout = new DevExpress.XtraEditors.SimpleButton();
            this.lbLayoutEtiqueta = new DevExpress.XtraEditors.LabelControl();
            this.cbListaPRN = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpImpresora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPRN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(555, 68);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnAbrePastaLayout);
            this.xtraTabPage1.Controls.Add(this.lbLayoutEtiqueta);
            this.xtraTabPage1.Controls.Add(this.cbListaPRN);
            this.xtraTabPage1.Controls.Add(this.lkbImpressora);
            this.xtraTabPage1.Controls.Add(this.lkpImpresora);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Size = new System.Drawing.Size(549, 62);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(487, 81);
            this.sbCancelar.TabIndex = 9;
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
            this.sbGravar.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbGravar.Location = new System.Drawing.Point(406, 81);
            this.sbGravar.TabIndex = 8;
            this.sbGravar.Text = "&Imprimir";
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 81);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Impressora:";
            // 
            // lkpImpresora
            // 
            this.lkpImpresora.ButtonLookup = null;
            this.lkpImpresora.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpImpresora.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpImpresora.CamposRestricoesAND")));
            this.lkpImpresora.CamposRestricoesNOT = null;
            this.lkpImpresora.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpImpresora.CamposRestricoesOR")));
            this.lkpImpresora.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpImpresora.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpImpresora.ContextoLinq = null;
            this.lkpImpresora.CwkFuncaoValidacao = null;
            this.lkpImpresora.CwkMascara = null;
            this.lkpImpresora.CwkValidacao = null;
            this.lkpImpresora.Exemplo = null;
            this.lkpImpresora.ID = 0;
            this.lkpImpresora.Join = null;
            this.lkpImpresora.Key = System.Windows.Forms.Keys.F5;
            this.lkpImpresora.Location = new System.Drawing.Point(80, 34);
            this.lkpImpresora.Name = "lkpImpresora";
            this.lkpImpresora.OnIDChanged = null;
            this.lkpImpresora.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpImpresora.Properties.Appearance.Options.UseBackColor = true;
            this.lkpImpresora.SelecionarTextoOnEnter = true;
            this.lkpImpresora.Size = new System.Drawing.Size(428, 20);
            this.lkpImpresora.Tabela = null;
            this.lkpImpresora.TabIndex = 9;
            this.lkpImpresora.TituloTelaPesquisa = null;
            this.lkpImpresora.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpImpresora.Where = null;
            // 
            // lkbImpressora
            // 
            this.lkbImpressora.Location = new System.Drawing.Point(514, 34);
            this.lkbImpressora.Lookup = null;
            this.lkbImpressora.Name = "lkbImpressora";
            this.lkbImpressora.Size = new System.Drawing.Size(24, 20);
            this.lkbImpressora.SubForm = null;
            this.lkbImpressora.SubFormType = null;
            this.lkbImpressora.SubFormTypeParams = null;
            this.lkbImpressora.TabIndex = 10;
            this.lkbImpressora.TabStop = false;
            this.lkbImpressora.Text = "...";
            this.lkbImpressora.Click += new System.EventHandler(this.lkbImpressora_Click);
            // 
            // btnAbrePastaLayout
            // 
            this.btnAbrePastaLayout.Image = global::Aplicacao.Properties.Resources.folder1;
            this.btnAbrePastaLayout.Location = new System.Drawing.Point(514, 6);
            this.btnAbrePastaLayout.Name = "btnAbrePastaLayout";
            this.btnAbrePastaLayout.Size = new System.Drawing.Size(26, 23);
            this.btnAbrePastaLayout.TabIndex = 13;
            this.btnAbrePastaLayout.Click += new System.EventHandler(this.btnAbrePastaLayout_Click);
            // 
            // lbLayoutEtiqueta
            // 
            this.lbLayoutEtiqueta.Location = new System.Drawing.Point(37, 10);
            this.lbLayoutEtiqueta.Name = "lbLayoutEtiqueta";
            this.lbLayoutEtiqueta.Size = new System.Drawing.Size(37, 13);
            this.lbLayoutEtiqueta.TabIndex = 11;
            this.lbLayoutEtiqueta.Text = "Layout:";
            // 
            // cbListaPRN
            // 
            this.cbListaPRN.Location = new System.Drawing.Point(80, 7);
            this.cbListaPRN.Name = "cbListaPRN";
            this.cbListaPRN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListaPRN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbListaPRN.Size = new System.Drawing.Size(428, 20);
            this.cbListaPRN.TabIndex = 12;
            this.cbListaPRN.Enter += new System.EventHandler(this.cbListaPRN_Enter);
            // 
            // FormEscolheImpressorasPRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 111);
            this.Name = "FormEscolheImpressorasPRN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Imprimir Etiqueta Formato PRN";
            this.Shown += new System.EventHandler(this.FormEscolheImpressorasPRN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpImpresora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaPRN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.Lookup lkpImpresora;
        private Cwork.Utilitarios.Componentes.LookupButton lkbImpressora;
        private DevExpress.XtraEditors.SimpleButton btnAbrePastaLayout;
        private DevExpress.XtraEditors.LabelControl lbLayoutEtiqueta;
        private DevExpress.XtraEditors.ComboBoxEdit cbListaPRN;
    }
}