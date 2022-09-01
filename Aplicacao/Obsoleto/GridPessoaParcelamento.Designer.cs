namespace Aplicacao
{
    partial class GridPessoaParcelamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridPessoaParcelamento));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData_Base = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDPessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReparcelamentoDocs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.btIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btSelecionar = new DevExpress.XtraEditors.SimpleButton();
            this.btFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocalizar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.gridControl1.Location = new System.Drawing.Point(12, 38);
            this.gridControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.gridControl1.MainView = this.dataGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(813, 390);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataGridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
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
            this.dataGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
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
            this.dataGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
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
            this.dataGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.dataGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colData,
            this.colData_Base,
            this.colJuros,
            this.colValorTotal,
            this.colObservacao,
            this.colId,
            this.colIDPessoa,
            this.colReparcelamentoDocs,
            this.colPessoa});
            this.dataGridView1.GridControl = this.gridControl1;
            this.dataGridView1.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.dataGridView1.OptionsBehavior.Editable = false;
            this.dataGridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.dataGridView1.OptionsDetail.EnableMasterViewMode = false;
            this.dataGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.dataGridView1.OptionsView.EnableAppearanceOddRow = true;
            this.dataGridView1.OptionsView.ShowAutoFilterRow = true;
            this.dataGridView1.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.dataGridView1_CustomDrawGroupPanel);
            // 
            // colData
            // 
            this.colData.AppearanceCell.Options.UseTextOptions = true;
            this.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colData.AppearanceHeader.Options.UseTextOptions = true;
            this.colData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colData.Caption = "Data";
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 80;
            // 
            // colData_Base
            // 
            this.colData_Base.AppearanceCell.Options.UseTextOptions = true;
            this.colData_Base.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colData_Base.AppearanceHeader.Options.UseTextOptions = true;
            this.colData_Base.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colData_Base.Caption = "Data Base";
            this.colData_Base.FieldName = "Data_Base";
            this.colData_Base.Name = "colData_Base";
            this.colData_Base.Visible = true;
            this.colData_Base.VisibleIndex = 1;
            this.colData_Base.Width = 80;
            // 
            // colJuros
            // 
            this.colJuros.AppearanceCell.Options.UseTextOptions = true;
            this.colJuros.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colJuros.AppearanceHeader.Options.UseTextOptions = true;
            this.colJuros.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJuros.Caption = "Juros";
            this.colJuros.FieldName = "Juros";
            this.colJuros.Name = "colJuros";
            this.colJuros.Visible = true;
            this.colJuros.VisibleIndex = 2;
            this.colJuros.Width = 100;
            // 
            // colValorTotal
            // 
            this.colValorTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colValorTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorTotal.Caption = "Valor Total";
            this.colValorTotal.DisplayFormat.FormatString = "c2";
            this.colValorTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorTotal.FieldName = "ValorTotal";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.Visible = true;
            this.colValorTotal.VisibleIndex = 3;
            this.colValorTotal.Width = 110;
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colObservacao.Caption = "Observação";
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 4;
            this.colObservacao.Width = 400;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "gridColumn1";
            this.colId.FieldName = "ID";
            this.colId.Name = "colId";
            // 
            // colIDPessoa
            // 
            this.colIDPessoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colIDPessoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIDPessoa.Caption = "gridColumn3";
            this.colIDPessoa.FieldName = "IDPessoa";
            this.colIDPessoa.Name = "colIDPessoa";
            this.colIDPessoa.Width = 237;
            // 
            // colReparcelamentoDocs
            // 
            this.colReparcelamentoDocs.AppearanceHeader.Options.UseTextOptions = true;
            this.colReparcelamentoDocs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReparcelamentoDocs.Caption = "gridColumn1";
            this.colReparcelamentoDocs.FieldName = "ReparcelamentoDocs";
            this.colReparcelamentoDocs.Name = "colReparcelamentoDocs";
            // 
            // colPessoa
            // 
            this.colPessoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colPessoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPessoa.Caption = "gridColumn1";
            this.colPessoa.FieldName = "Pessoa";
            this.colPessoa.Name = "colPessoa";
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
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 300);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btConsultar
            // 
            this.btConsultar.ImageIndex = 2;
            this.btConsultar.ImageList = this.imageList1;
            this.btConsultar.Location = new System.Drawing.Point(667, 434);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 11;
            this.btConsultar.Text = "&Consultar";
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.ImageIndex = 3;
            this.btIncluir.ImageList = this.imageList1;
            this.btIncluir.Location = new System.Drawing.Point(508, 434);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 12;
            this.btIncluir.Text = "&Incluir";
            this.btIncluir.Visible = false;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.ImageIndex = 4;
            this.btAlterar.ImageList = this.imageList1;
            this.btAlterar.Location = new System.Drawing.Point(586, 434);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 13;
            this.btAlterar.Text = "&Alterar";
            this.btAlterar.Visible = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.ImageIndex = 5;
            this.btExcluir.ImageList = this.imageList1;
            this.btExcluir.Location = new System.Drawing.Point(748, 434);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.ImageIndex = 6;
            this.sbFechar.ImageList = this.imageList1;
            this.sbFechar.Location = new System.Drawing.Point(750, 463);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 15;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageIndex = 0;
            this.simpleButton2.ImageList = this.imageList1;
            this.simpleButton2.Location = new System.Drawing.Point(12, 463);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "A&juda";
            // 
            // btSelecionar
            // 
            this.btSelecionar.ImageIndex = 1;
            this.btSelecionar.ImageList = this.imageList1;
            this.btSelecionar.Location = new System.Drawing.Point(90, 463);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(83, 23);
            this.btSelecionar.TabIndex = 17;
            this.btSelecionar.Text = "&Selecionar";
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btFiltro
            // 
            this.btFiltro.Location = new System.Drawing.Point(750, 9);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(75, 23);
            this.btFiltro.TabIndex = 18;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Location = new System.Drawing.Point(12, 12);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Properties.MaxLength = 80;
            this.txtLocalizar.Size = new System.Drawing.Size(730, 20);
            this.txtLocalizar.TabIndex = 19;
            this.txtLocalizar.TextChanged += new System.EventHandler(this.txtLocalizar_TextChanged);
            this.txtLocalizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocalizar_KeyDown);
            // 
            // GridPessoaParcelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 498);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GridPessoaParcelamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcelamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GridPadrao_FormClosed);
            this.Load += new System.EventHandler(this.GridPadrao_Load);
            this.Shown += new System.EventHandler(this.GridPessoaParcelamento_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridPadrao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        public DevExpress.XtraGrid.Views.Grid.GridView dataGridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btConsultar;
        private DevExpress.XtraEditors.SimpleButton btIncluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btSelecionar;
        private DevExpress.XtraEditors.SimpleButton btFiltro;
        private DevExpress.XtraEditors.TextEdit txtLocalizar;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPessoa;
        private DevExpress.XtraGrid.Columns.GridColumn colData_Base;
        private DevExpress.XtraGrid.Columns.GridColumn colJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colValorTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colReparcelamentoDocs;
        private DevExpress.XtraGrid.Columns.GridColumn colPessoa;

    }
}