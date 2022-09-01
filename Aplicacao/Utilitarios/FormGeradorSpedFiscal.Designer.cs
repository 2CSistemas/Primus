namespace Aplicacao.Utilitarios
{
    partial class FormGeradorSpedFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeradorSpedFiscal));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtArquivo = new DevExpress.XtraEditors.TextEdit();
            this.sbSelecionarArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.pnlPrincipal = new DevExpress.XtraEditors.PanelControl();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.sdAdEmpresa = new Componentes.devexpress.cwk_DevButton();
            this.cbFinalidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lblPeriodo2 = new DevExpress.XtraEditors.LabelControl();
            this.cbtipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinalidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtipo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 142);
            this.sbAjuda.TabIndex = 14;
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(267, 142);
            this.sbGravar.TabIndex = 15;
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click_1);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(348, 142);
            this.sbCancelar.TabIndex = 16;
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
            this.tpPrincipal.Controls.Add(this.pnlPrincipal);
            this.tpPrincipal.Size = new System.Drawing.Size(410, 118);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(416, 124);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Filial:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Pasta Destino:";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(86, 36);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Properties.ReadOnly = true;
            this.txtArquivo.Size = new System.Drawing.Size(285, 20);
            this.txtArquivo.TabIndex = 4;
            // 
            // sbSelecionarArquivo
            // 
            this.sbSelecionarArquivo.Location = new System.Drawing.Point(377, 36);
            this.sbSelecionarArquivo.Name = "sbSelecionarArquivo";
            this.sbSelecionarArquivo.Size = new System.Drawing.Size(24, 20);
            this.sbSelecionarArquivo.TabIndex = 5;
            this.sbSelecionarArquivo.Text = "...";
            this.sbSelecionarArquivo.Click += new System.EventHandler(this.sbSelecionarArquivo_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lkpFilial);
            this.pnlPrincipal.Controls.Add(this.sdAdEmpresa);
            this.pnlPrincipal.Controls.Add(this.cbFinalidade);
            this.pnlPrincipal.Controls.Add(this.labelControl1);
            this.pnlPrincipal.Controls.Add(this.txtDataInicial);
            this.pnlPrincipal.Controls.Add(this.txtDataFinal);
            this.pnlPrincipal.Controls.Add(this.lblPeriodo2);
            this.pnlPrincipal.Controls.Add(this.cbtipo);
            this.pnlPrincipal.Controls.Add(this.lblPeriodo);
            this.pnlPrincipal.Controls.Add(this.labelControl6);
            this.pnlPrincipal.Controls.Add(this.sbSelecionarArquivo);
            this.pnlPrincipal.Controls.Add(this.txtArquivo);
            this.pnlPrincipal.Controls.Add(this.labelControl3);
            this.pnlPrincipal.Controls.Add(this.labelControl2);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPrincipal.Size = new System.Drawing.Size(410, 116);
            this.pnlPrincipal.TabIndex = 10;
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = null;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFilial.CamposRestricoesAND = null;
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = null;
            this.lkpFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(86, 10);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(285, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 2;
            this.lkpFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            // 
            // sdAdEmpresa
            // 
            this.sdAdEmpresa.Location = new System.Drawing.Point(377, 10);
            this.sdAdEmpresa.Name = "sdAdEmpresa";
            this.sdAdEmpresa.Size = new System.Drawing.Size(24, 20);
            this.sdAdEmpresa.TabIndex = 3;
            this.sdAdEmpresa.TabStop = false;
            this.sdAdEmpresa.Text = "...";
            this.sdAdEmpresa.Click += new System.EventHandler(this.sdAdEmpresa_Click);
            // 
            // cbFinalidade
            // 
            this.cbFinalidade.EditValue = "";
            this.cbFinalidade.Location = new System.Drawing.Point(273, 88);
            this.cbFinalidade.Name = "cbFinalidade";
            this.cbFinalidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFinalidade.Properties.Items.AddRange(new object[] {
            "0 | Original",
            "1 | Substituto"});
            this.cbFinalidade.Size = new System.Drawing.Size(128, 20);
            this.cbFinalidade.TabIndex = 13;
            this.cbFinalidade.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(220, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Finalidade:";
            this.labelControl1.Visible = false;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(86, 62);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Size = new System.Drawing.Size(149, 20);
            this.txtDataInicial.TabIndex = 7;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(255, 62);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Size = new System.Drawing.Size(146, 20);
            this.txtDataFinal.TabIndex = 9;
            // 
            // lblPeriodo2
            // 
            this.lblPeriodo2.Location = new System.Drawing.Point(241, 65);
            this.lblPeriodo2.Name = "lblPeriodo2";
            this.lblPeriodo2.Size = new System.Drawing.Size(6, 13);
            this.lblPeriodo2.TabIndex = 8;
            this.lblPeriodo2.Text = "à";
            // 
            // cbtipo
            // 
            this.cbtipo.EditValue = "0 | EFD-Contribuições";
            this.cbtipo.Location = new System.Drawing.Point(86, 88);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbtipo.Properties.Items.AddRange(new object[] {
            "0 | EFD-Contribuições",
            "1 | ICMS-IPI"});
            this.cbtipo.Size = new System.Drawing.Size(128, 20);
            this.cbtipo.TabIndex = 11;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.cbtipo_SelectedIndexChanged);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(40, 65);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lblPeriodo.TabIndex = 6;
            this.lblPeriodo.Text = "Período:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(56, 91);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Tipo:";
            // 
            // FormGeradorSpedFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 177);
            this.Name = "FormGeradorSpedFiscal";
            this.Text = "Gerador SPED Fiscal";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFinalidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtipo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl pnlPrincipal;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarArquivo;
        private DevExpress.XtraEditors.TextEdit txtArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private DevExpress.XtraEditors.ComboBoxEdit cbtipo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private DevExpress.XtraEditors.LabelControl lblPeriodo2;
        private DevExpress.XtraEditors.ComboBoxEdit cbFinalidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Componentes.devexpress.cwk_DevButton sdAdEmpresa;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}