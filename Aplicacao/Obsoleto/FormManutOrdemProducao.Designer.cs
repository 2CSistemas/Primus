namespace Aplicacao
{
    partial class FormManutOrdemProducao
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutOrdemProducao));
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.txtProjetoAgrupamento = new DevExpress.XtraEditors.TextEdit();
            this.gcServicos = new DevExpress.XtraGrid.GridControl();
            this.gvServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkbClassificacao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkClassificacao = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbProjeto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkProjeto = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjetoAgrupamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClassificacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(561, 351);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Size = new System.Drawing.Size(555, 345);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(498, 369);
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
            this.imageList1.Images.SetKeyName(7, "Selecionar.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(417, 369);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 369);
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(5, 120);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(65, 13);
            this.labelControl23.TabIndex = 11;
            this.labelControl23.Text = "Classificação:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, false)});
            this.txtCodigo.Properties.Mask.EditMask = "n0";
            this.txtCodigo.Properties.Precision = 0;
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl2.Size = new System.Drawing.Size(546, 340);
            this.xtraTabControl2.TabIndex = 0;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            this.xtraTabControl2.TabStop = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtDescricao);
            this.xtraTabPage2.Controls.Add(this.txtProjetoAgrupamento);
            this.xtraTabPage2.Controls.Add(this.gcServicos);
            this.xtraTabPage2.Controls.Add(this.labelControl5);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.lkbClassificacao);
            this.xtraTabPage2.Controls.Add(this.lkClassificacao);
            this.xtraTabPage2.Controls.Add(this.lkbProjeto);
            this.xtraTabPage2.Controls.Add(this.lkProjeto);
            this.xtraTabPage2.Controls.Add(this.lkbFilial);
            this.xtraTabPage2.Controls.Add(this.lkFilial);
            this.xtraTabPage2.Controls.Add(this.lkbPessoa);
            this.xtraTabPage2.Controls.Add(this.lkPessoa);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.txtCodigo);
            this.xtraTabPage2.Controls.Add(this.labelControl23);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(540, 312);
            this.xtraTabPage2.Text = "Ordem Produção";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(76, 145);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(428, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // txtProjetoAgrupamento
            // 
            this.txtProjetoAgrupamento.Location = new System.Drawing.Point(305, 13);
            this.txtProjetoAgrupamento.Name = "txtProjetoAgrupamento";
            this.txtProjetoAgrupamento.Size = new System.Drawing.Size(199, 20);
            this.txtProjetoAgrupamento.TabIndex = 2;
            // 
            // gcServicos
            // 
            this.gcServicos.Location = new System.Drawing.Point(20, 176);
            this.gcServicos.MainView = this.gvServicos;
            this.gcServicos.Name = "gcServicos";
            this.gcServicos.Size = new System.Drawing.Size(484, 130);
            this.gcServicos.TabIndex = 18;
            this.gcServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServicos});
            // 
            // gvServicos
            // 
            this.gvServicos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvServicos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.Empty.Options.UseBackColor = true;
            this.gvServicos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvServicos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvServicos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvServicos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvServicos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvServicos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Preview.Options.UseFont = true;
            this.gvServicos.Appearance.Preview.Options.UseForeColor = true;
            this.gvServicos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Row.Options.UseBackColor = true;
            this.gvServicos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvServicos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvServicos.BestFitMaxRowCount = 5;
            this.gvServicos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5});
            this.gvServicos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvServicos.GridControl = this.gcServicos;
            this.gvServicos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvServicos.Name = "gvServicos";
            this.gvServicos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvServicos.OptionsBehavior.Editable = false;
            this.gvServicos.OptionsDetail.EnableMasterViewMode = false;
            this.gvServicos.OptionsView.ColumnAutoWidth = false;
            this.gvServicos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvServicos.OptionsView.EnableAppearanceOddRow = true;
            this.gvServicos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Serviço";
            this.gridColumn4.FieldName = "Servico";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 365;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Horas Planejadas";
            this.gridColumn5.FieldName = "Quantidade";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 96;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(191, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Projeto-Agrupamento:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Descrição:";
            // 
            // lkbClassificacao
            // 
            this.lkbClassificacao.Location = new System.Drawing.Point(510, 117);
            this.lkbClassificacao.Lookup = null;
            this.lkbClassificacao.Name = "lkbClassificacao";
            this.lkbClassificacao.Size = new System.Drawing.Size(24, 20);
            this.lkbClassificacao.SubForm = null;
            this.lkbClassificacao.SubFormType = null;
            this.lkbClassificacao.SubFormTypeParams = null;
            this.lkbClassificacao.TabIndex = 13;
            this.lkbClassificacao.TabStop = false;
            this.lkbClassificacao.Text = "...";
            this.lkbClassificacao.Click += new System.EventHandler(this.lkbClassificacao_Click);
            // 
            // lkClassificacao
            // 
            this.lkClassificacao.ButtonLookup = this.lkbClassificacao;
            this.lkClassificacao.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkClassificacao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkClassificacao.CamposRestricoesAND")));
            this.lkClassificacao.CamposRestricoesNOT = null;
            this.lkClassificacao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkClassificacao.CamposRestricoesOR")));
            this.lkClassificacao.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkClassificacao.ColunaTamanho = new string[] {
        "60",
        "140"};
            this.lkClassificacao.ContextoLinq = null;
            this.lkClassificacao.CwkFuncaoValidacao = null;
            this.lkClassificacao.CwkMascara = null;
            this.lkClassificacao.CwkValidacao = null;
            this.lkClassificacao.Exemplo = null;
            this.lkClassificacao.ID = 0;
            this.lkClassificacao.Join = null;
            this.lkClassificacao.Key = System.Windows.Forms.Keys.F5;
            this.lkClassificacao.Location = new System.Drawing.Point(76, 117);
            this.lkClassificacao.Name = "lkClassificacao";
            this.lkClassificacao.OnIDChanged = null;
            this.lkClassificacao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkClassificacao.Properties.Appearance.Options.UseBackColor = true;
            this.lkClassificacao.SelecionarTextoOnEnter = false;
            this.lkClassificacao.Size = new System.Drawing.Size(428, 20);
            this.lkClassificacao.Tabela = "ClassificacaoOrdemProducao";
            this.lkClassificacao.TabIndex = 12;
            this.lkClassificacao.TituloTelaPesquisa = "Pesquisa - Classificação";
            this.lkClassificacao.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkClassificacao.Where = null;
            // 
            // lkbProjeto
            // 
            this.lkbProjeto.Location = new System.Drawing.Point(510, 91);
            this.lkbProjeto.Lookup = null;
            this.lkbProjeto.Name = "lkbProjeto";
            this.lkbProjeto.Size = new System.Drawing.Size(24, 20);
            this.lkbProjeto.SubForm = null;
            this.lkbProjeto.SubFormType = null;
            this.lkbProjeto.SubFormTypeParams = null;
            this.lkbProjeto.TabIndex = 10;
            this.lkbProjeto.TabStop = false;
            this.lkbProjeto.Text = "...";
            this.lkbProjeto.Click += new System.EventHandler(this.lkbProjeto_Click);
            // 
            // lkProjeto
            // 
            this.lkProjeto.ButtonLookup = this.lkbProjeto;
            this.lkProjeto.CamposPesquisa = new string[] {
        "Nome",
        "Descricao"};
            this.lkProjeto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkProjeto.CamposRestricoesAND")));
            this.lkProjeto.CamposRestricoesNOT = null;
            this.lkProjeto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkProjeto.CamposRestricoesOR")));
            this.lkProjeto.ColunaDescricao = new string[] {
        "Nome",
        "Descrição"};
            this.lkProjeto.ColunaTamanho = new string[] {
        "80",
        "120"};
            this.lkProjeto.ContextoLinq = null;
            this.lkProjeto.CwkFuncaoValidacao = null;
            this.lkProjeto.CwkMascara = null;
            this.lkProjeto.CwkValidacao = null;
            this.lkProjeto.Exemplo = null;
            this.lkProjeto.ID = 0;
            this.lkProjeto.Join = null;
            this.lkProjeto.Key = System.Windows.Forms.Keys.F5;
            this.lkProjeto.Location = new System.Drawing.Point(76, 91);
            this.lkProjeto.Name = "lkProjeto";
            this.lkProjeto.OnIDChanged = null;
            this.lkProjeto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkProjeto.Properties.Appearance.Options.UseBackColor = true;
            this.lkProjeto.SelecionarTextoOnEnter = false;
            this.lkProjeto.Size = new System.Drawing.Size(428, 20);
            this.lkProjeto.Tabela = "Projeto";
            this.lkProjeto.TabIndex = 9;
            this.lkProjeto.TituloTelaPesquisa = "Pesquisa - Projeto";
            this.lkProjeto.ToolTip = "Campos pesquisados: Nome, Descricao.";
            this.lkProjeto.Where = "Projeto.Status = 2 and";
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(510, 39);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 4;
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
            this.lkFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkFilial.CamposRestricoesAND")));
            this.lkFilial.CamposRestricoesNOT = null;
            this.lkFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkFilial.CamposRestricoesOR")));
            this.lkFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkFilial.ContextoLinq = null;
            this.lkFilial.CwkFuncaoValidacao = null;
            this.lkFilial.CwkMascara = null;
            this.lkFilial.CwkValidacao = null;
            this.lkFilial.Exemplo = null;
            this.lkFilial.ID = 0;
            this.lkFilial.Join = null;
            this.lkFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkFilial.Location = new System.Drawing.Point(76, 39);
            this.lkFilial.Name = "lkFilial";
            this.lkFilial.OnIDChanged = null;
            this.lkFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkFilial.SelecionarTextoOnEnter = false;
            this.lkFilial.Size = new System.Drawing.Size(428, 20);
            this.lkFilial.Tabela = "Filial";
            this.lkFilial.TabIndex = 3;
            this.lkFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkFilial.Where = null;
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(510, 65);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 7;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkPessoa
            // 
            this.lkPessoa.ButtonLookup = this.lkbPessoa;
            this.lkPessoa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkPessoa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkPessoa.CamposRestricoesAND")));
            this.lkPessoa.CamposRestricoesNOT = null;
            this.lkPessoa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkPessoa.CamposRestricoesOR")));
            this.lkPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkPessoa.ContextoLinq = null;
            this.lkPessoa.CwkFuncaoValidacao = null;
            this.lkPessoa.CwkMascara = null;
            this.lkPessoa.CwkValidacao = null;
            this.lkPessoa.Exemplo = null;
            this.lkPessoa.ID = 0;
            this.lkPessoa.Join = null;
            this.lkPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkPessoa.Location = new System.Drawing.Point(76, 65);
            this.lkPessoa.Name = "lkPessoa";
            this.lkPessoa.OnIDChanged = null;
            this.lkPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkPessoa.SelecionarTextoOnEnter = false;
            this.lkPessoa.Size = new System.Drawing.Size(428, 20);
            this.lkPessoa.Tabela = "Pessoa";
            this.lkPessoa.TabIndex = 6;
            this.lkPessoa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkPessoa.Where = "Pessoa.bCliente = 1 AND ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Projeto:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(25, 42);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Empresa:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Cliente:";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(540, 312);
            this.xtraTabPage3.Text = "Histórico";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gridControl1.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gridControl1.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gridControl1.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.gridControl1.MainView = this.dataGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(531, 303);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataGridView1});
            // 
            // dataGridView1
            // 
            this.dataGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dataGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dataGridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.Empty.Options.UseBackColor = true;
            this.dataGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.dataGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.dataGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.dataGridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dataGridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dataGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.dataGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.dataGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.dataGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.dataGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.Preview.Options.UseFont = true;
            this.dataGridView1.Appearance.Preview.Options.UseForeColor = true;
            this.dataGridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.Row.Options.UseBackColor = true;
            this.dataGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dataGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.dataGridView1.BestFitMaxRowCount = 5;
            this.dataGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.dataGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dataGridView1.GridControl = this.gridControl1;
            this.dataGridView1.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.dataGridView1.OptionsBehavior.Editable = false;
            this.dataGridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.dataGridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.dataGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.dataGridView1.OptionsView.EnableAppearanceOddRow = true;
            this.dataGridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Data";
            this.gridColumn1.FieldName = "Data";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sequência";
            this.gridColumn2.FieldName = "Sequencia";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Classificação";
            this.gridColumn3.FieldName = "Classificacao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 272;
            // 
            // FormManutOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(585, 404);
            this.Name = "FormManutOrdemProducao";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjetoAgrupamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClassificacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView dataGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkPessoa;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkFilial;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProjeto;
        private Cwork.Utilitarios.Componentes.Lookup lkProjeto;
        private Cwork.Utilitarios.Componentes.LookupButton lkbClassificacao;
        private Cwork.Utilitarios.Componentes.Lookup lkClassificacao;
        private DevExpress.XtraGrid.GridControl gcServicos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServicos;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.TextEdit txtProjetoAgrupamento;
    }
}
