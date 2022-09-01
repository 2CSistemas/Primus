namespace Aplicacao
{
    partial class FormManutReparcelamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutReparcelamento));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtValorTotal = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcDocNovos = new DevExpress.XtraGrid.GridControl();
            this.gvDocNovos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcDocAntigos = new DevExpress.XtraGrid.GridControl();
            this.gvDocAntigos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtJuros = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataBase = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocNovos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocNovos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocAntigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocAntigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBase.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(809, 440);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtValorTotal);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.txtObservacao);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtJuros);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtDataBase);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtData);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(800, 431);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(683, 11);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorTotal.Properties.DisplayFormat.FormatString = "n2";
            this.txtValorTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorTotal.Properties.Mask.EditMask = "n2";
            this.txtValorTotal.Properties.Precision = 2;
            this.txtValorTotal.Properties.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(622, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Valor Total:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcDocNovos);
            this.groupControl2.Location = new System.Drawing.Point(411, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(372, 297);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Documentos Novos";
            // 
            // gcDocNovos
            // 
            this.gcDocNovos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDocNovos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDocNovos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDocNovos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDocNovos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDocNovos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcDocNovos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcDocNovos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcDocNovos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcDocNovos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcDocNovos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcDocNovos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDocNovos.EmbeddedNavigator.Name = "";
            this.gcDocNovos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcDocNovos.Location = new System.Drawing.Point(2, 20);
            this.gcDocNovos.LookAndFeel.UseWindowsXPTheme = true;
            this.gcDocNovos.MainView = this.gvDocNovos;
            this.gcDocNovos.Name = "gcDocNovos";
            this.gcDocNovos.Size = new System.Drawing.Size(368, 275);
            this.gcDocNovos.TabIndex = 2;
            this.gcDocNovos.UseEmbeddedNavigator = true;
            this.gcDocNovos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocNovos});
            // 
            // gvDocNovos
            // 
            this.gvDocNovos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.Empty.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocNovos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocNovos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocNovos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocNovos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocNovos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocNovos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocNovos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocNovos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocNovos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocNovos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvDocNovos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.Preview.Options.UseFont = true;
            this.gvDocNovos.Appearance.Preview.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocNovos.Appearance.Row.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvDocNovos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocNovos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocNovos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDocNovos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvDocNovos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvDocNovos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvDocNovos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvDocNovos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvDocNovos.GridControl = this.gcDocNovos;
            this.gvDocNovos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvDocNovos.Name = "gvDocNovos";
            this.gvDocNovos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvDocNovos.OptionsBehavior.Editable = false;
            this.gvDocNovos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvDocNovos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDocNovos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDocNovos.OptionsView.EnableAppearanceOddRow = true;
            this.gvDocNovos.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Num. Docto";
            this.gridColumn2.FieldName = "NumDocumento";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 91;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Vencimento";
            this.gridColumn3.FieldName = "Vencimento";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 91;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Valor";
            this.gridColumn4.DisplayFormat.FormatString = "c2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Valor";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 99;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcDocAntigos);
            this.groupControl1.Location = new System.Drawing.Point(17, 123);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 297);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Documentos Antigos";
            // 
            // gcDocAntigos
            // 
            this.gcDocAntigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDocAntigos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDocAntigos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDocAntigos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDocAntigos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDocAntigos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcDocAntigos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcDocAntigos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcDocAntigos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcDocAntigos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcDocAntigos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcDocAntigos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDocAntigos.EmbeddedNavigator.Name = "";
            this.gcDocAntigos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcDocAntigos.Location = new System.Drawing.Point(2, 20);
            this.gcDocAntigos.LookAndFeel.UseWindowsXPTheme = true;
            this.gcDocAntigos.MainView = this.gvDocAntigos;
            this.gcDocAntigos.Name = "gcDocAntigos";
            this.gcDocAntigos.Size = new System.Drawing.Size(368, 275);
            this.gcDocAntigos.TabIndex = 1;
            this.gcDocAntigos.UseEmbeddedNavigator = true;
            this.gcDocAntigos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocAntigos});
            // 
            // gvDocAntigos
            // 
            this.gvDocAntigos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.Empty.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocAntigos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocAntigos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocAntigos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocAntigos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocAntigos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocAntigos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocAntigos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocAntigos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocAntigos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocAntigos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvDocAntigos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.Preview.Options.UseFont = true;
            this.gvDocAntigos.Appearance.Preview.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocAntigos.Appearance.Row.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvDocAntigos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocAntigos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocAntigos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDocAntigos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvDocAntigos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvDocAntigos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvDocAntigos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvDocAntigos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colNumDocumento,
            this.colVencimento,
            this.colValor});
            this.gvDocAntigos.GridControl = this.gcDocAntigos;
            this.gvDocAntigos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvDocAntigos.Name = "gvDocAntigos";
            this.gvDocAntigos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvDocAntigos.OptionsBehavior.Editable = false;
            this.gvDocAntigos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvDocAntigos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDocAntigos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDocAntigos.OptionsView.EnableAppearanceOddRow = true;
            this.gvDocAntigos.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 66;
            // 
            // colNumDocumento
            // 
            this.colNumDocumento.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumDocumento.Caption = "Num. Docto";
            this.colNumDocumento.FieldName = "NumDocumento";
            this.colNumDocumento.Name = "colNumDocumento";
            this.colNumDocumento.Visible = true;
            this.colNumDocumento.VisibleIndex = 1;
            this.colNumDocumento.Width = 91;
            // 
            // colVencimento
            // 
            this.colVencimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colVencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVencimento.Caption = "Vencimento";
            this.colVencimento.FieldName = "Vencimento";
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.Visible = true;
            this.colVencimento.VisibleIndex = 2;
            this.colVencimento.Width = 91;
            // 
            // colValor
            // 
            this.colValor.AppearanceCell.Options.UseTextOptions = true;
            this.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colValor.AppearanceHeader.Options.UseTextOptions = true;
            this.colValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValor.Caption = "Valor";
            this.colValor.DisplayFormat.FormatString = "c2";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 3;
            this.colValor.Width = 99;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(85, 37);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.ReadOnly = true;
            this.txtObservacao.Size = new System.Drawing.Size(698, 80);
            this.txtObservacao.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Observação:";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(505, 11);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtJuros.Properties.DisplayFormat.FormatString = "n2";
            this.txtJuros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtJuros.Properties.Mask.EditMask = "n2";
            this.txtJuros.Properties.Precision = 2;
            this.txtJuros.Properties.ReadOnly = true;
            this.txtJuros.Size = new System.Drawing.Size(100, 20);
            this.txtJuros.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(469, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Juros:";
            // 
            // txtDataBase
            // 
            this.txtDataBase.EditValue = null;
            this.txtDataBase.Location = new System.Drawing.Point(269, 11);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataBase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataBase.Properties.ReadOnly = true;
            this.txtDataBase.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataBase.Size = new System.Drawing.Size(100, 20);
            this.txtDataBase.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(210, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data Base:";
            // 
            // txtData
            // 
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(85, 11);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.ReadOnly = true;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(800, 431);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help.ico");
            this.imageList1.Images.SetKeyName(1, "Selecionar.ico");
            this.imageList1.Images.SetKeyName(2, "Consulta.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir.ico");
            this.imageList1.Images.SetKeyName(6, "fechar tela.ico");
            this.imageList1.Images.SetKeyName(7, "Gravar copy.ico");
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageIndex = 6;
            this.simpleButton1.ImageList = this.imageList1;
            this.simpleButton1.Location = new System.Drawing.Point(746, 458);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "&Fechar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageIndex = 7;
            this.sbGravar.ImageList = this.imageList1;
            this.sbGravar.Location = new System.Drawing.Point(665, 458);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 17;
            this.sbGravar.Text = "&Ok";
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // FormManutReparcelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 490);
            this.Controls.Add(this.sbGravar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManutReparcelamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManutReparcelamento";
            this.Load += new System.EventHandler(this.FormManutReparcelamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDocNovos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocNovos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDocAntigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocAntigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBase.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit txtData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDataBase;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit txtJuros;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtObservacao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraGrid.GridControl gcDocAntigos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvDocAntigos;
        private DevExpress.XtraEditors.CalcEdit txtValorTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        public DevExpress.XtraGrid.GridControl gcDocNovos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvDocNovos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton sbGravar;
    }
}