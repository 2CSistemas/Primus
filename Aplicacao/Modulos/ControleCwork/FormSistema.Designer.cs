namespace Aplicacao
{
    partial class FormSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSistema));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnIncluirVersao = new Cwork.Utilitarios.Componentes.DevButton();
            this.btnAlterarVersao = new Cwork.Utilitarios.Componentes.DevButton();
            this.btnExcluirVersao = new Cwork.Utilitarios.Componentes.DevButton();
            this.btnConsultarVersao = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcVersaos = new DevExpress.XtraGrid.GridControl();
            this.gvVersaos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cbSistemaLicenca = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVersaos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVersaos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSistemaLicenca.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 307);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(449, 307);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(530, 307);
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
            this.tpPrincipal.Controls.Add(this.cbSistemaLicenca);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.xtraTabControl1);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(584, 280);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(593, 289);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(71, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.Mask.ShowPlaceHolders = false;
            this.txtNome.Properties.MaxLength = 20;
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(500, 20);
            this.txtNome.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nome:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(28, 55);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(553, 222);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnIncluirVersao);
            this.xtraTabPage1.Controls.Add(this.btnAlterarVersao);
            this.xtraTabPage1.Controls.Add(this.btnExcluirVersao);
            this.xtraTabPage1.Controls.Add(this.btnConsultarVersao);
            this.xtraTabPage1.Controls.Add(this.gcVersaos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(544, 191);
            this.xtraTabPage1.Text = "Versão";
            // 
            // btnIncluirVersao
            // 
            this.btnIncluirVersao.GridControl = null;
            this.btnIncluirVersao.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnIncluirVersao.Location = new System.Drawing.Point(303, 166);
            this.btnIncluirVersao.Name = "btnIncluirVersao";
            this.btnIncluirVersao.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirVersao.SubForm = null;
            this.btnIncluirVersao.TabIndex = 18;
            this.btnIncluirVersao.TabStop = false;
            this.btnIncluirVersao.Text = "&Incluir";
            // 
            // btnAlterarVersao
            // 
            this.btnAlterarVersao.GridControl = null;
            this.btnAlterarVersao.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnAlterarVersao.Location = new System.Drawing.Point(384, 166);
            this.btnAlterarVersao.Name = "btnAlterarVersao";
            this.btnAlterarVersao.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarVersao.SubForm = null;
            this.btnAlterarVersao.TabIndex = 19;
            this.btnAlterarVersao.TabStop = false;
            this.btnAlterarVersao.Text = "&Alterar";
            // 
            // btnExcluirVersao
            // 
            this.btnExcluirVersao.GridControl = null;
            this.btnExcluirVersao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnExcluirVersao.Location = new System.Drawing.Point(465, 166);
            this.btnExcluirVersao.Name = "btnExcluirVersao";
            this.btnExcluirVersao.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirVersao.SubForm = null;
            this.btnExcluirVersao.TabIndex = 20;
            this.btnExcluirVersao.TabStop = false;
            this.btnExcluirVersao.Text = "&Excluir";
            // 
            // btnConsultarVersao
            // 
            this.btnConsultarVersao.GridControl = null;
            this.btnConsultarVersao.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btnConsultarVersao.Location = new System.Drawing.Point(222, 166);
            this.btnConsultarVersao.Name = "btnConsultarVersao";
            this.btnConsultarVersao.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVersao.SubForm = null;
            this.btnConsultarVersao.TabIndex = 17;
            this.btnConsultarVersao.TabStop = false;
            this.btnConsultarVersao.Text = "&Consultar";
            // 
            // gcVersaos
            // 
            this.gcVersaos.EmbeddedNavigator.Name = "";
            this.gcVersaos.Location = new System.Drawing.Point(3, 3);
            this.gcVersaos.MainView = this.gvVersaos;
            this.gcVersaos.Name = "gcVersaos";
            this.gcVersaos.Size = new System.Drawing.Size(537, 159);
            this.gcVersaos.TabIndex = 0;
            this.gcVersaos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVersaos});
            // 
            // gvVersaos
            // 
            this.gvVersaos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvVersaos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvVersaos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvVersaos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvVersaos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.Empty.Options.UseBackColor = true;
            this.gvVersaos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvVersaos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvVersaos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvVersaos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvVersaos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvVersaos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvVersaos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvVersaos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvVersaos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvVersaos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvVersaos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvVersaos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvVersaos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvVersaos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvVersaos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvVersaos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvVersaos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvVersaos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvVersaos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvVersaos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvVersaos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvVersaos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvVersaos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvVersaos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvVersaos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvVersaos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvVersaos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvVersaos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvVersaos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvVersaos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvVersaos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvVersaos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvVersaos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvVersaos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvVersaos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvVersaos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvVersaos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvVersaos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvVersaos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.Preview.Options.UseFont = true;
            this.gvVersaos.Appearance.Preview.Options.UseForeColor = true;
            this.gvVersaos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvVersaos.Appearance.Row.Options.UseBackColor = true;
            this.gvVersaos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvVersaos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvVersaos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvVersaos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvVersaos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvVersaos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvVersaos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvVersaos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvVersaos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvVersaos.GridControl = this.gcVersaos;
            this.gvVersaos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvVersaos.Name = "gvVersaos";
            this.gvVersaos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvVersaos.OptionsBehavior.Editable = false;
            this.gvVersaos.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvVersaos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVersaos.OptionsView.EnableAppearanceOddRow = true;
            this.gvVersaos.OptionsView.ShowAutoFilterRow = true;
            this.gvVersaos.OptionsView.ShowGroupPanel = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(72, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // cbSistemaLicenca
            // 
            this.cbSistemaLicenca.Location = new System.Drawing.Point(357, 3);
            this.cbSistemaLicenca.Name = "cbSistemaLicenca";
            this.cbSistemaLicenca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSistemaLicenca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSistemaLicenca.Size = new System.Drawing.Size(214, 20);
            this.cbSistemaLicenca.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(310, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Sistema:";
            // 
            // FormSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(617, 342);
            this.Name = "FormSistema";
            this.Shown += new System.EventHandler(this.FormSistema_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVersaos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVersaos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSistemaLicenca.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gcVersaos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVersaos;
        private Cwork.Utilitarios.Componentes.DevButton btnIncluirVersao;
        private Cwork.Utilitarios.Componentes.DevButton btnAlterarVersao;
        private Cwork.Utilitarios.Componentes.DevButton btnExcluirVersao;
        private Cwork.Utilitarios.Componentes.DevButton btnConsultarVersao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbSistemaLicenca;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
