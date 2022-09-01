namespace Aplicacao
{
    partial class GridGenerica<T>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridOrcamentoNewLinq));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.sbFuncao11 = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionar = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.sbIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.sbFuncao12 = new DevExpress.XtraEditors.SimpleButton();
            this.sbFuncao22 = new DevExpress.XtraEditors.SimpleButton();
            this.sbFuncao13 = new DevExpress.XtraEditors.SimpleButton();
            this.sbFuncao23 = new DevExpress.XtraEditors.SimpleButton();
            this.sbFuncao10 = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.gcPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbImprimirFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.btTrocarProduto = new DevExpress.XtraEditors.SimpleButton();
            this.pnlPrincipal = new DevExpress.XtraEditors.PanelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.pnlFiltro = new DevExpress.XtraEditors.PanelControl();
            this.ucFiltroGridGenerica = new Aplicacao.UserControls.UCFiltroGrid();
            this.sbFuncao25 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbFuncao11
            // 
            this.sbFuncao11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao11.Enabled = false;
            this.sbFuncao11.Location = new System.Drawing.Point(99, 392);
            this.sbFuncao11.Name = "sbFuncao11";
            this.sbFuncao11.Size = new System.Drawing.Size(83, 23);
            this.sbFuncao11.TabIndex = 7;
            this.sbFuncao11.Text = "Funcao11";
            this.sbFuncao11.Visible = false;
            // 
            // sbSelecionar
            // 
            this.sbSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionar.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionar.ImageIndex = 1;
            this.sbSelecionar.Location = new System.Drawing.Point(99, 420);
            this.sbSelecionar.Name = "sbSelecionar";
            this.sbSelecionar.Size = new System.Drawing.Size(83, 23);
            this.sbSelecionar.TabIndex = 11;
            this.sbSelecionar.Text = "&Selecionar";
            this.sbSelecionar.Visible = false;
            this.sbSelecionar.Click += new System.EventHandler(this.sbSelecionar_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageIndex = 6;
            this.sbFechar.Location = new System.Drawing.Point(753, 420);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 5;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // sbExcluir
            // 
            this.sbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluir.ImageIndex = 5;
            this.sbExcluir.Location = new System.Drawing.Point(753, 392);
            this.sbExcluir.Name = "sbExcluir";
            this.sbExcluir.Size = new System.Drawing.Size(75, 23);
            this.sbExcluir.TabIndex = 4;
            this.sbExcluir.Text = "E&xcluir";
            this.sbExcluir.Click += new System.EventHandler(this.sbExcluir_Click);
            // 
            // sbAlterar
            // 
            this.sbAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.sbAlterar.ImageIndex = 4;
            this.sbAlterar.Location = new System.Drawing.Point(675, 392);
            this.sbAlterar.Name = "sbAlterar";
            this.sbAlterar.Size = new System.Drawing.Size(75, 23);
            this.sbAlterar.TabIndex = 3;
            this.sbAlterar.Text = "&Alterar";
            this.sbAlterar.Click += new System.EventHandler(this.sbAlterar_Click);
            // 
            // sbIncluir
            // 
            this.sbIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluir.ImageIndex = 3;
            this.sbIncluir.Location = new System.Drawing.Point(597, 392);
            this.sbIncluir.Name = "sbIncluir";
            this.sbIncluir.Size = new System.Drawing.Size(75, 23);
            this.sbIncluir.TabIndex = 2;
            this.sbIncluir.Text = "&Incluir";
            this.sbIncluir.Click += new System.EventHandler(this.sbIncluir_Click);
            // 
            // sbConsultar
            // 
            this.sbConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbConsultar.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbConsultar.ImageIndex = 2;
            this.sbConsultar.Location = new System.Drawing.Point(519, 392);
            this.sbConsultar.Name = "sbConsultar";
            this.sbConsultar.Size = new System.Drawing.Size(75, 23);
            this.sbConsultar.TabIndex = 1;
            this.sbConsultar.Text = "&Consultar";
            this.sbConsultar.Click += new System.EventHandler(this.sbConsultar_Click);
            // 
            // sbFuncao12
            // 
            this.sbFuncao12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao12.Enabled = false;
            this.sbFuncao12.ImageIndex = 1;
            this.sbFuncao12.Location = new System.Drawing.Point(185, 392);
            this.sbFuncao12.Name = "sbFuncao12";
            this.sbFuncao12.Size = new System.Drawing.Size(83, 23);
            this.sbFuncao12.TabIndex = 8;
            this.sbFuncao12.Text = "Funcao12";
            this.sbFuncao12.Visible = false;
            // 
            // sbFuncao22
            // 
            this.sbFuncao22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao22.Enabled = false;
            this.sbFuncao22.ImageIndex = 1;
            this.sbFuncao22.Location = new System.Drawing.Point(185, 420);
            this.sbFuncao22.Name = "sbFuncao22";
            this.sbFuncao22.Size = new System.Drawing.Size(83, 23);
            this.sbFuncao22.TabIndex = 12;
            this.sbFuncao22.Text = "Funcao22";
            this.sbFuncao22.Visible = false;
            // 
            // sbFuncao13
            // 
            this.sbFuncao13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao13.Enabled = false;
            this.sbFuncao13.ImageIndex = 1;
            this.sbFuncao13.Location = new System.Drawing.Point(273, 392);
            this.sbFuncao13.Name = "sbFuncao13";
            this.sbFuncao13.Size = new System.Drawing.Size(83, 23);
            this.sbFuncao13.TabIndex = 9;
            this.sbFuncao13.Text = "Funcao13";
            this.sbFuncao13.Visible = false;
            // 
            // sbFuncao23
            // 
            this.sbFuncao23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao23.Enabled = false;
            this.sbFuncao23.ImageIndex = 1;
            this.sbFuncao23.Location = new System.Drawing.Point(273, 420);
            this.sbFuncao23.Name = "sbFuncao23";
            this.sbFuncao23.Size = new System.Drawing.Size(83, 23);
            this.sbFuncao23.TabIndex = 13;
            this.sbFuncao23.Text = "Funcao23";
            this.sbFuncao23.Visible = false;
            // 
            // sbFuncao10
            // 
            this.sbFuncao10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao10.Enabled = false;
            this.sbFuncao10.ImageIndex = 1;
            this.sbFuncao10.Location = new System.Drawing.Point(12, 392);
            this.sbFuncao10.Name = "sbFuncao10";
            this.sbFuncao10.Size = new System.Drawing.Size(83, 23);
            this.sbFuncao10.TabIndex = 6;
            this.sbFuncao10.Text = "Funcao10";
            this.sbFuncao10.Visible = false;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gcPrincipal;
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(60, 60, 100, 60);
            this.printableComponentLink1.MinMargins = new System.Drawing.Printing.Margins(10, 10, 50, 10);
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "",
                "",
                "[Page # of Pages #]"}, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near), null);
            this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            this.printableComponentLink1.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink1_CreateMarginalHeaderArea);
            // 
            // gcPrincipal
            // 
            this.gcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcPrincipal.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcPrincipal.Location = new System.Drawing.Point(2, 2);
            this.gcPrincipal.MainView = this.gvPrincipal;
            this.gcPrincipal.Name = "gcPrincipal";
            this.gcPrincipal.Size = new System.Drawing.Size(812, 330);
            this.gcPrincipal.TabIndex = 0;
            this.gcPrincipal.UseEmbeddedNavigator = true;
            this.gcPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrincipal});
            this.gcPrincipal.DoubleClick += new System.EventHandler(this.gcPrincipal_DoubleClick);
            // 
            // gvPrincipal
            // 
            this.gvPrincipal.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.Empty.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPrincipal.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPrincipal.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPrincipal.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPrincipal.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPrincipal.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPrincipal.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvPrincipal.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.Preview.Options.UseFont = true;
            this.gvPrincipal.Appearance.Preview.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.Row.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.TopNewRow.BackColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPrincipal.BestFitMaxRowCount = 5;
            this.gvPrincipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPrincipal.GridControl = this.gcPrincipal;
            this.gvPrincipal.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPrincipal.Name = "gvPrincipal";
            this.gvPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPrincipal.OptionsBehavior.Editable = false;
            this.gvPrincipal.OptionsDetail.EnableMasterViewMode = false;
            this.gvPrincipal.OptionsView.ColumnAutoWidth = false;
            this.gvPrincipal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrincipal.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrincipal.OptionsView.ShowAutoFilterRow = true;
            this.gvPrincipal.OptionsView.ShowFooter = true;
            this.gvPrincipal.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvPrincipal_CustomDrawGroupPanel);
            this.gvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvPrincipal_KeyDown);
            this.gvPrincipal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvPrincipal_KeyUp);
            // 
            // sbImprimirFiltro
            // 
            this.sbImprimirFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimirFiltro.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbImprimirFiltro.ImageIndex = 6;
            this.sbImprimirFiltro.Location = new System.Drawing.Point(519, 420);
            this.sbImprimirFiltro.Name = "sbImprimirFiltro";
            this.sbImprimirFiltro.Size = new System.Drawing.Size(153, 23);
            this.sbImprimirFiltro.TabIndex = 14;
            this.sbImprimirFiltro.Text = "Im&primirFiltro";
            this.sbImprimirFiltro.Click += new System.EventHandler(this.sbImprimirFiltro_Click);
            // 
            // btTrocarProduto
            // 
            this.btTrocarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTrocarProduto.ImageIndex = 1;
            this.btTrocarProduto.Location = new System.Drawing.Point(362, 392);
            this.btTrocarProduto.Name = "btTrocarProduto";
            this.btTrocarProduto.Size = new System.Drawing.Size(101, 23);
            this.btTrocarProduto.TabIndex = 18;
            this.btTrocarProduto.Text = "&Trocar Produto";
            this.btTrocarProduto.Visible = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPrincipal.Controls.Add(this.pnlGrid);
            this.pnlPrincipal.Controls.Add(this.pnlFiltro);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(816, 374);
            this.pnlPrincipal.TabIndex = 21;
            // 
            // pnlGrid
            // 
            this.pnlGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGrid.Controls.Add(this.gcPrincipal);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(816, 334);
            this.pnlGrid.TabIndex = 21;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFiltro.Controls.Add(this.ucFiltroGridGenerica);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(816, 40);
            this.pnlFiltro.TabIndex = 20;
            // 
            // ucFiltroGridGenerica
            // 
            this.ucFiltroGridGenerica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFiltroGridGenerica.Location = new System.Drawing.Point(2, 2);
            this.ucFiltroGridGenerica.Name = "ucFiltroGridGenerica";
            this.ucFiltroGridGenerica.Size = new System.Drawing.Size(812, 36);
            this.ucFiltroGridGenerica.TabIndex = 20;
            // 
            // sbFuncao25
            // 
            this.sbFuncao25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao25.Enabled = false;
            this.sbFuncao25.ImageIndex = 1;
            this.sbFuncao25.Location = new System.Drawing.Point(12, 420);
            this.sbFuncao25.Name = "sbFuncao25";
            this.sbFuncao25.Size = new System.Drawing.Size(83, 23);
            this.sbFuncao25.TabIndex = 22;
            this.sbFuncao25.Text = "Funcao25";
            this.sbFuncao25.Visible = false;
            // 
            // GridGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.sbFuncao25);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btTrocarProduto);
            this.Controls.Add(this.sbImprimirFiltro);
            this.Controls.Add(this.sbFuncao10);
            this.Controls.Add(this.sbFuncao23);
            this.Controls.Add(this.sbFuncao13);
            this.Controls.Add(this.sbFuncao22);
            this.Controls.Add(this.sbFuncao12);
            this.Controls.Add(this.sbFuncao11);
            this.Controls.Add(this.sbSelecionar);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.sbExcluir);
            this.Controls.Add(this.sbAlterar);
            this.Controls.Add(this.sbIncluir);
            this.Controls.Add(this.sbConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridGenerica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridGenerica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridGenerica_FormClosing);
            this.Shown += new System.EventHandler(this.GridGenerica_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridGenerica_KeyDown);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.GridGenerica_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPrincipal)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton sbSelecionar;
        protected DevExpress.XtraEditors.SimpleButton sbFechar;
        protected DevExpress.XtraEditors.SimpleButton sbExcluir;
        protected DevExpress.XtraEditors.SimpleButton sbAlterar;
        protected DevExpress.XtraEditors.SimpleButton sbIncluir;
        protected DevExpress.XtraEditors.SimpleButton sbConsultar;
        public DevExpress.XtraEditors.SimpleButton sbFuncao10;
        public DevExpress.XtraEditors.SimpleButton sbFuncao11;
        public DevExpress.XtraEditors.SimpleButton sbFuncao12;
        public DevExpress.XtraEditors.SimpleButton sbFuncao22;
        public DevExpress.XtraEditors.SimpleButton sbFuncao13;
        public DevExpress.XtraEditors.SimpleButton sbFuncao23;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        protected DevExpress.XtraEditors.SimpleButton sbImprimirFiltro;
        protected DevExpress.XtraEditors.SimpleButton btTrocarProduto;
        public DevExpress.XtraGrid.GridControl gcPrincipal;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraEditors.PanelControl pnlPrincipal;
        protected DevExpress.XtraEditors.PanelControl pnlFiltro;
        protected DevExpress.XtraEditors.PanelControl pnlGrid;
        protected Aplicacao.UserControls.UCFiltroGrid ucFiltroGridGenerica;
        public DevExpress.XtraEditors.SimpleButton sbFuncao25;
    }
}