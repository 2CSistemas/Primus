namespace Aplicacao.Modulos.Manifesto
{
    partial class GridManifestoEletronico
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
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.ovGRD_Notas = new DevExpress.XtraGrid.GridControl();
            this.ovGV_Notas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(938, 441);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 36;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // ovGRD_Notas
            // 
            this.ovGRD_Notas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_Notas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ovGRD_Notas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ovGRD_Notas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ovGRD_Notas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ovGRD_Notas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ovGRD_Notas.Location = new System.Drawing.Point(8, 50);
            this.ovGRD_Notas.MainView = this.ovGV_Notas;
            this.ovGRD_Notas.Name = "ovGRD_Notas";
            this.ovGRD_Notas.Size = new System.Drawing.Size(1005, 385);
            this.ovGRD_Notas.TabIndex = 41;
            this.ovGRD_Notas.UseEmbeddedNavigator = true;
            this.ovGRD_Notas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ovGV_Notas,
            this.cardView2});
            // 
            // ovGV_Notas
            // 
            this.ovGV_Notas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.Empty.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.EvenRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.EvenRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Notas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Notas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Notas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.FixedLine.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Notas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Notas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupButton.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Notas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.GroupRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Notas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Notas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Notas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.OddRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.OddRow.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.OddRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.ovGV_Notas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.Preview.Options.UseFont = true;
            this.ovGV_Notas.Appearance.Preview.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.Row.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.ovGV_Notas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn6});
            this.ovGV_Notas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ovGV_Notas.GridControl = this.ovGRD_Notas;
            this.ovGV_Notas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.ovGV_Notas.Name = "ovGV_Notas";
            this.ovGV_Notas.OptionsBehavior.FocusLeaveOnTab = true;
            this.ovGV_Notas.OptionsDetail.EnableMasterViewMode = false;
            this.ovGV_Notas.OptionsView.EnableAppearanceEvenRow = true;
            this.ovGV_Notas.OptionsView.EnableAppearanceOddRow = true;
            this.ovGV_Notas.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Numero";
            this.gridColumn1.FieldName = "numeronota";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 65;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Série";
            this.gridColumn2.FieldName = "serie";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 58;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Data Emissão";
            this.gridColumn3.FieldName = "datanota";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CNPJ";
            this.gridColumn4.FieldName = "cnpj";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 138;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fornecedor";
            this.gridColumn5.FieldName = "fornecedor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 365;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Situação";
            this.gridColumn7.FieldName = "situacao";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 140;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Valor Nota";
            this.gridColumn6.DisplayFormat.FormatString = "{0:c2}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "valornota";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 134;
            // 
            // cardView2
            // 
            this.cardView2.GridControl = this.ovGRD_Notas;
            this.cardView2.Name = "cardView2";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.simpleButton2.ImageOptions.ImageIndex = 2;
            this.simpleButton2.Location = new System.Drawing.Point(669, 441);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(146, 23);
            this.simpleButton2.TabIndex = 43;
            this.simpleButton2.Text = "Baixar pela Chave";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Data Cotação";
            this.gridColumn8.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn8.DisplayFormat.FormatString = "d";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn8.FieldName = "Data Nota";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 144;
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(70, 10);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacao.Properties.DropDownRows = 8;
            this.cbSituacao.Properties.Items.AddRange(new object[] {
            "Todos",
            "Confirmação Da Operação",
            "Ciência Da Operação",
            "Desconhecimento Da Operação",
            "Operação Não Realizada",
            "Averbação Para Exportação"});
            this.cbSituacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSituacao.Size = new System.Drawing.Size(179, 20);
            this.cbSituacao.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Situação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Período:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(389, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 54;
            this.labelControl3.Text = "à";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(402, 12);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 55;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(303, 12);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Fornecedor:";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Cliente";
            this.gridColumn9.FieldName = "Fornecedor";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 144;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.simpleButton1.ImageOptions.ImageIndex = 2;
            this.simpleButton1.Location = new System.Drawing.Point(552, 441);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 23);
            this.simpleButton1.TabIndex = 58;
            this.simpleButton1.Text = "Manifestar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton3.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.simpleButton3.ImageOptions.ImageIndex = 2;
            this.simpleButton3.Location = new System.Drawing.Point(898, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(115, 32);
            this.simpleButton3.TabIndex = 59;
            this.simpleButton3.Text = "Buscar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(855, 12);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 61;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpPessoa.CamposRestricoesAND = null;
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = null;
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(558, 12);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(291, 20);
            this.lkpPessoa.Tabela = "Pessoa";
            this.lkpPessoa.TabIndex = 60;
            this.lkpPessoa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpPessoa.Where = null;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton4.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.simpleButton4.ImageOptions.ImageIndex = 2;
            this.simpleButton4.Location = new System.Drawing.Point(420, 441);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(126, 23);
            this.simpleButton4.TabIndex = 62;
            this.simpleButton4.Text = "Buscar Notas";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton5.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.simpleButton5.ImageOptions.ImageIndex = 2;
            this.simpleButton5.Location = new System.Drawing.Point(821, 441);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(111, 23);
            this.simpleButton5.TabIndex = 63;
            this.simpleButton5.Text = "Visualizar Danfe";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton6.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.simpleButton6.ImageOptions.ImageIndex = 2;
            this.simpleButton6.Location = new System.Drawing.Point(8, 441);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(126, 23);
            this.simpleButton6.TabIndex = 64;
            this.simpleButton6.Text = "Buscar Ultimo NSU";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // GridManifestoEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 476);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.lkbPessoa);
            this.Controls.Add(this.lkpPessoa);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDtFinal);
            this.Controls.Add(this.txtDtInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.ovGRD_Notas);
            this.Controls.Add(this.sbFechar);
            this.KeyPreview = true;
            this.Name = "GridManifestoEletronico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Manifesto Eletrônico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadMoeda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraGrid.GridControl ovGRD_Notas;
        private DevExpress.XtraGrid.Views.Grid.GridView ovGV_Notas;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        public DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        public DevExpress.XtraEditors.SimpleButton simpleButton5;
        public DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}