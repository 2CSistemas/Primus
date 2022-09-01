namespace Aplicacao
{
    partial class GridProdutoMais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridProdutoMais));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarcado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarraFornecedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescReduzida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcTabelaPreco = new DevExpress.XtraGrid.GridControl();
            this.gvTabelaPreco = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btConsultarEstoque = new DevExpress.XtraEditors.SimpleButton();
            this.btImagemProduto = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTabelaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTabelaPreco)).BeginInit();
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
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridControl1.Location = new System.Drawing.Point(12, 38);
            this.gridControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.gridControl1.MainView = this.dataGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(813, 272);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataGridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            this.dataGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMarcado,
            this.colNome,
            this.colUnidade,
            this.colCodigo,
            this.colBarra,
            this.colBarraFornecedor,
            this.colGrupo,
            this.colDescReduzida,
            this.colID});
            this.dataGridView1.GridControl = this.gridControl1;
            this.dataGridView1.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.dataGridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.dataGridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.dataGridView1.OptionsView.ColumnAutoWidth = false;
            this.dataGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.dataGridView1.OptionsView.EnableAppearanceOddRow = true;
            this.dataGridView1.OptionsView.ShowGroupPanel = false;
            this.dataGridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dataGridView1_FocusedRowChanged);
            // 
            // colMarcado
            // 
            this.colMarcado.AppearanceHeader.Options.UseTextOptions = true;
            this.colMarcado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarcado.FieldName = "Marcado";
            this.colMarcado.Name = "colMarcado";
            this.colMarcado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMarcado.Visible = true;
            this.colMarcado.VisibleIndex = 0;
            this.colMarcado.Width = 33;
            // 
            // colNome
            // 
            this.colNome.AppearanceHeader.Options.UseTextOptions = true;
            this.colNome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.OptionsColumn.AllowEdit = false;
            this.colNome.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 461;
            // 
            // colUnidade
            // 
            this.colUnidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnidade.Caption = "Und.";
            this.colUnidade.FieldName = "Unidade";
            this.colUnidade.Name = "colUnidade";
            this.colUnidade.OptionsColumn.AllowEdit = false;
            this.colUnidade.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnidade.Visible = true;
            this.colUnidade.VisibleIndex = 2;
            this.colUnidade.Width = 44;
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 3;
            this.colCodigo.Width = 95;
            // 
            // colBarra
            // 
            this.colBarra.AppearanceHeader.Options.UseTextOptions = true;
            this.colBarra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBarra.Caption = "Barra";
            this.colBarra.FieldName = "Barra";
            this.colBarra.Name = "colBarra";
            this.colBarra.Visible = true;
            this.colBarra.VisibleIndex = 4;
            this.colBarra.Width = 100;
            // 
            // colBarraFornecedor
            // 
            this.colBarraFornecedor.AppearanceHeader.Options.UseTextOptions = true;
            this.colBarraFornecedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBarraFornecedor.Caption = "Barra Fornecedor";
            this.colBarraFornecedor.FieldName = "BarraFornecedor";
            this.colBarraFornecedor.Name = "colBarraFornecedor";
            this.colBarraFornecedor.Visible = true;
            this.colBarraFornecedor.VisibleIndex = 5;
            this.colBarraFornecedor.Width = 100;
            // 
            // colGrupo
            // 
            this.colGrupo.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrupo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrupo.Caption = "Grupo";
            this.colGrupo.FieldName = "Grupo";
            this.colGrupo.Name = "colGrupo";
            this.colGrupo.OptionsColumn.AllowEdit = false;
            this.colGrupo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGrupo.Visible = true;
            this.colGrupo.VisibleIndex = 6;
            this.colGrupo.Width = 170;
            // 
            // colDescReduzida
            // 
            this.colDescReduzida.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescReduzida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescReduzida.Caption = "Desc. Reduzida";
            this.colDescReduzida.FieldName = "DescReduzida";
            this.colDescReduzida.Name = "colDescReduzida";
            this.colDescReduzida.OptionsColumn.AllowEdit = false;
            this.colDescReduzida.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescReduzida.Visible = true;
            this.colDescReduzida.VisibleIndex = 7;
            this.colDescReduzida.Width = 212;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
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
            this.btConsultar.Location = new System.Drawing.Point(516, 316);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "&Consultar";
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.ImageIndex = 3;
            this.btIncluir.ImageList = this.imageList1;
            this.btIncluir.Location = new System.Drawing.Point(594, 316);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 3;
            this.btIncluir.Text = "&Incluir";
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.ImageIndex = 4;
            this.btAlterar.ImageList = this.imageList1;
            this.btAlterar.Location = new System.Drawing.Point(672, 316);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 4;
            this.btAlterar.Text = "&Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.ImageIndex = 5;
            this.btExcluir.ImageList = this.imageList1;
            this.btExcluir.Location = new System.Drawing.Point(750, 316);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 5;
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
            this.sbFechar.TabIndex = 8;
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
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "A&juda";
            // 
            // btSelecionar
            // 
            this.btSelecionar.ImageIndex = 1;
            this.btSelecionar.ImageList = this.imageList1;
            this.btSelecionar.Location = new System.Drawing.Point(90, 463);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(83, 23);
            this.btSelecionar.TabIndex = 9;
            this.btSelecionar.Text = "&Selecionar";
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btFiltro
            // 
            this.btFiltro.Location = new System.Drawing.Point(737, 38);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(75, 23);
            this.btFiltro.TabIndex = 11;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.Visible = false;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.EditValue = "";
            this.txtLocalizar.Location = new System.Drawing.Point(12, 12);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Properties.MaxLength = 80;
            this.txtLocalizar.Size = new System.Drawing.Size(813, 20);
            this.txtLocalizar.TabIndex = 0;
            this.txtLocalizar.Leave += new System.EventHandler(this.txtLocalizar_Leave);
            this.txtLocalizar.TextChanged += new System.EventHandler(this.txtLocalizar_TextChanged);
            // 
            // gcTabelaPreco
            // 
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Name = "";
            this.gcTabelaPreco.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTabelaPreco.Location = new System.Drawing.Point(12, 345);
            this.gcTabelaPreco.MainView = this.gvTabelaPreco;
            this.gcTabelaPreco.Name = "gcTabelaPreco";
            this.gcTabelaPreco.Size = new System.Drawing.Size(813, 112);
            this.gcTabelaPreco.TabIndex = 7;
            this.gcTabelaPreco.UseEmbeddedNavigator = true;
            this.gcTabelaPreco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTabelaPreco});
            // 
            // gvTabelaPreco
            // 
            this.gvTabelaPreco.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.Empty.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTabelaPreco.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTabelaPreco.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTabelaPreco.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTabelaPreco.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTabelaPreco.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTabelaPreco.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTabelaPreco.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.Preview.Options.UseFont = true;
            this.gvTabelaPreco.Appearance.Preview.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.Row.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTabelaPreco.GridControl = this.gcTabelaPreco;
            this.gvTabelaPreco.Name = "gvTabelaPreco";
            this.gvTabelaPreco.OptionsBehavior.Editable = false;
            this.gvTabelaPreco.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTabelaPreco.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTabelaPreco.OptionsView.EnableAppearanceOddRow = true;
            this.gvTabelaPreco.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 320);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tabelas de Preço";
            // 
            // btConsultarEstoque
            // 
            this.btConsultarEstoque.ImageIndex = 2;
            this.btConsultarEstoque.ImageList = this.imageList1;
            this.btConsultarEstoque.Location = new System.Drawing.Point(389, 316);
            this.btConsultarEstoque.Name = "btConsultarEstoque";
            this.btConsultarEstoque.Size = new System.Drawing.Size(124, 23);
            this.btConsultarEstoque.TabIndex = 12;
            this.btConsultarEstoque.Text = "&Consultar Estoque";
            this.btConsultarEstoque.Click += new System.EventHandler(this.btConsultarEstoque_Click);
            // 
            // btImagemProduto
            // 
            this.btImagemProduto.ImageIndex = 2;
            this.btImagemProduto.ImageList = this.imageList1;
            this.btImagemProduto.Location = new System.Drawing.Point(272, 316);
            this.btImagemProduto.Name = "btImagemProduto";
            this.btImagemProduto.Size = new System.Drawing.Size(113, 23);
            this.btImagemProduto.TabIndex = 13;
            this.btImagemProduto.Text = "&Imagem Produto";
            this.btImagemProduto.Click += new System.EventHandler(this.btImagemProduto_Click);
            // 
            // GridProdutoMais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 498);
            this.Controls.Add(this.btImagemProduto);
            this.Controls.Add(this.btConsultarEstoque);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gcTabelaPreco);
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
            this.Name = "GridProdutoMais";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Produto";
            this.Load += new System.EventHandler(this.GridPadrao_Load);
            this.Shown += new System.EventHandler(this.GridProduto_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GridPadrao_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridPadrao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTabelaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTabelaPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btConsultar;
        private DevExpress.XtraEditors.SimpleButton btIncluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btSelecionar;
        private DevExpress.XtraEditors.SimpleButton btFiltro;
        private DevExpress.XtraEditors.TextEdit txtLocalizar;
        public DevExpress.XtraGrid.GridControl gcTabelaPreco;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTabelaPreco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        public DevExpress.XtraGrid.Views.Grid.GridView dataGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcado;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidade;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescReduzida;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colBarraFornecedor;
        private DevExpress.XtraEditors.SimpleButton btConsultarEstoque;
        private DevExpress.XtraEditors.SimpleButton btImagemProduto;

    }
}