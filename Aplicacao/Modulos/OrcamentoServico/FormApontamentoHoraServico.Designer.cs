namespace Aplicacao
{
    partial class FormApontamentoHoraServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApontamentoHoraServico));
            this.lkpFuncionario = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFuncionario = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcApontamentos = new DevExpress.XtraGrid.GridControl();
            this.gvApontamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnIncluir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApontamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).BeginInit();
            this.SuspendLayout();
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
            this.tpPrincipal.Controls.Add(this.btnIncluir);
            this.tpPrincipal.Controls.Add(this.btnAlterar);
            this.tpPrincipal.Controls.Add(this.btnExcluir);
            this.tpPrincipal.Controls.Add(this.gcApontamentos);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.lkbFuncionario);
            this.tpPrincipal.Controls.Add(this.lkpFuncionario);
            // 
            // lkpFuncionario
            // 
            this.lkpFuncionario.ButtonLookup = this.lkbFuncionario;
            this.lkpFuncionario.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFuncionario.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFuncionario.CamposRestricoesAND")));
            this.lkpFuncionario.CamposRestricoesNOT = null;
            this.lkpFuncionario.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFuncionario.CamposRestricoesOR")));
            this.lkpFuncionario.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpFuncionario.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFuncionario.ContextoLinq = null;
            this.lkpFuncionario.CwkFuncaoValidacao = null;
            this.lkpFuncionario.CwkMascara = null;
            this.lkpFuncionario.CwkValidacao = null;
            this.lkpFuncionario.Exemplo = null;
            this.lkpFuncionario.ID = 0;
            this.lkpFuncionario.Join = null;
            this.lkpFuncionario.Key = System.Windows.Forms.Keys.F5;
            this.lkpFuncionario.Location = new System.Drawing.Point(88, 3);
            this.lkpFuncionario.Name = "lkpFuncionario";
            this.lkpFuncionario.OnIDChanged = null;
            this.lkpFuncionario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFuncionario.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFuncionario.SelecionarTextoOnEnter = false;
            this.lkpFuncionario.Size = new System.Drawing.Size(707, 20);
            this.lkpFuncionario.Tabela = null;
            this.lkpFuncionario.TabIndex = 0;
            this.lkpFuncionario.TituloTelaPesquisa = null;
            this.lkpFuncionario.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFuncionario.Where = null;
            // 
            // lkbFuncionario
            // 
            this.lkbFuncionario.Location = new System.Drawing.Point(801, 3);
            this.lkbFuncionario.Lookup = null;
            this.lkbFuncionario.Name = "lkbFuncionario";
            this.lkbFuncionario.Size = new System.Drawing.Size(24, 20);
            this.lkbFuncionario.SubForm = null;
            this.lkbFuncionario.TabIndex = 1;
            this.lkbFuncionario.TabStop = false;
            this.lkbFuncionario.Text = "...";
            this.lkbFuncionario.Click += new System.EventHandler(this.lkbFuncionario_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Funcionário:";
            // 
            // gcApontamentos
            // 
            this.gcApontamentos.EmbeddedNavigator.Name = "";
            this.gcApontamentos.Location = new System.Drawing.Point(3, 29);
            this.gcApontamentos.MainView = this.gvApontamentos;
            this.gcApontamentos.Name = "gcApontamentos";
            this.gcApontamentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemTimeEdit2});
            this.gcApontamentos.Size = new System.Drawing.Size(822, 377);
            this.gcApontamentos.TabIndex = 3;
            this.gcApontamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvApontamentos});
            this.gcApontamentos.EditorKeyUp += new System.Windows.Forms.KeyEventHandler(this.gcApontamentos_EditorKeyUp);
            // 
            // gvApontamentos
            // 
            this.gvApontamentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvApontamentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvApontamentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvApontamentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvApontamentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvApontamentos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvApontamentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvApontamentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvApontamentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvApontamentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvApontamentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvApontamentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.Preview.Options.UseFont = true;
            this.gvApontamentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvApontamentos.Appearance.Row.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvApontamentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvApontamentos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvApontamentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvApontamentos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvApontamentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvApontamentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvApontamentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvApontamentos.BestFitMaxRowCount = 5;
            this.gvApontamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvApontamentos.GridControl = this.gcApontamentos;
            this.gvApontamentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvApontamentos.Name = "gvApontamentos";
            this.gvApontamentos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvApontamentos.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvApontamentos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvApontamentos.OptionsDetail.EnableMasterViewMode = false;
            this.gvApontamentos.OptionsView.ColumnAutoWidth = false;
            this.gvApontamentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvApontamentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvApontamentos.OptionsView.ShowGroupPanel = false;
            this.gvApontamentos.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvApontamentos_CustomUnboundColumnData);
            this.gvApontamentos.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gvApontamentos_FocusedColumnChanged);
            this.gvApontamentos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvApontamentos_KeyUp);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "OS";
            this.gridColumn1.FieldName = "OSCod";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Data";
            this.gridColumn2.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn2.FieldName = "Data";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 88;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.Caption = "Serviço";
            this.gridColumn3.FieldName = "ServicoCod";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 482;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hora Início";
            this.gridColumn4.ColumnEdit = this.repositoryItemTimeEdit1;
            this.gridColumn4.FieldName = "HoraInicio";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 78;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Mask.EditMask = "t";
            this.repositoryItemTimeEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Hora Fim";
            this.gridColumn5.ColumnEdit = this.repositoryItemTimeEdit2;
            this.gridColumn5.FieldName = "HoraFim";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 77;
            // 
            // repositoryItemTimeEdit2
            // 
            this.repositoryItemTimeEdit2.AutoHeight = false;
            this.repositoryItemTimeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit2.Mask.EditMask = "t";
            this.repositoryItemTimeEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTimeEdit2.Name = "repositoryItemTimeEdit2";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnExcluir.Location = new System.Drawing.Point(750, 412);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnAlterar.Location = new System.Drawing.Point(669, 412);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnIncluir.Location = new System.Drawing.Point(588, 412);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // FormApontamentoHoraServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(861, 505);
            this.Name = "FormApontamentoHoraServico";
            this.Text = "Apontamento de Horas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormApontamentoHoraServico_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApontamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcApontamentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvApontamentos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFuncionario;
        private Cwork.Utilitarios.Componentes.Lookup lkpFuncionario;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit2;
        private DevExpress.XtraEditors.SimpleButton btnIncluir;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;

    }
}
