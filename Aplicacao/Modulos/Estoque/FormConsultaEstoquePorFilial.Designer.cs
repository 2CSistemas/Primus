namespace Aplicacao
{
    partial class FormConsultaEstoquePorFilial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaEstoquePorFilial));
            this.gcEstoque = new DevExpress.XtraGrid.GridControl();
            this.gvEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lkbLocalEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpLocalEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btConsultarEstoque = new DevExpress.XtraEditors.SimpleButton();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.rgpMostrar = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbMovimentos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgpMostrar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEstoque
            // 
            this.gcEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEstoque.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEstoque.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEstoque.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEstoque.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEstoque.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcEstoque.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcEstoque.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcEstoque.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcEstoque.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcEstoque.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcEstoque.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcEstoque.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcEstoque.Location = new System.Drawing.Point(3, 61);
            this.gcEstoque.MainView = this.gvEstoque;
            this.gcEstoque.Name = "gcEstoque";
            this.gcEstoque.Size = new System.Drawing.Size(786, 367);
            this.gcEstoque.TabIndex = 7;
            this.gcEstoque.TabStop = false;
            this.gcEstoque.UseEmbeddedNavigator = true;
            this.gcEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEstoque});
            // 
            // gvEstoque
            // 
            this.gvEstoque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEstoque.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEstoque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEstoque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEstoque.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.Empty.Options.UseBackColor = true;
            this.gvEstoque.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEstoque.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEstoque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEstoque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEstoque.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEstoque.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEstoque.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEstoque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEstoque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEstoque.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEstoque.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEstoque.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEstoque.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEstoque.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEstoque.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEstoque.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEstoque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEstoque.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEstoque.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEstoque.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEstoque.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEstoque.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEstoque.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEstoque.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEstoque.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEstoque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEstoque.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEstoque.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEstoque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEstoque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEstoque.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEstoque.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEstoque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEstoque.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEstoque.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEstoque.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEstoque.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvEstoque.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEstoque.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvEstoque.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.Preview.Options.UseFont = true;
            this.gvEstoque.Appearance.Preview.Options.UseForeColor = true;
            this.gvEstoque.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEstoque.Appearance.Row.Options.UseBackColor = true;
            this.gvEstoque.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvEstoque.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvEstoque.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEstoque.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEstoque.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEstoque.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEstoque.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvEstoque.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvEstoque.GridControl = this.gcEstoque;
            this.gvEstoque.Name = "gvEstoque";
            this.gvEstoque.OptionsBehavior.Editable = false;
            this.gvEstoque.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvEstoque.OptionsSelection.MultiSelect = true;
            this.gvEstoque.OptionsView.ColumnAutoWidth = false;
            this.gvEstoque.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEstoque.OptionsView.EnableAppearanceOddRow = true;
            this.gvEstoque.OptionsView.ShowAutoFilterRow = true;
            this.gvEstoque.OptionsView.ShowFooter = true;
            this.gvEstoque.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvEstoque_CustomDrawGroupPanel);
            this.gvEstoque.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gvEstoque_CustomRowFilter);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(2, "Fechar.ico");
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 9);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(801, 440);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lkbLocalEstoque);
            this.xtraTabPage1.Controls.Add(this.lkpLocalEstoque);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.btConsultarEstoque);
            this.xtraTabPage1.Controls.Add(this.lkbFilial);
            this.xtraTabPage1.Controls.Add(this.lkpFilial);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.gcEstoque);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(795, 434);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // lkbLocalEstoque
            // 
            this.lkbLocalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbLocalEstoque.Enabled = false;
            this.lkbLocalEstoque.Location = new System.Drawing.Point(624, 33);
            this.lkbLocalEstoque.Lookup = null;
            this.lkbLocalEstoque.Name = "lkbLocalEstoque";
            this.lkbLocalEstoque.Size = new System.Drawing.Size(24, 20);
            this.lkbLocalEstoque.SubForm = null;
            this.lkbLocalEstoque.SubFormType = null;
            this.lkbLocalEstoque.SubFormTypeParams = null;
            this.lkbLocalEstoque.TabIndex = 5;
            this.lkbLocalEstoque.TabStop = false;
            this.lkbLocalEstoque.Text = "...";
            this.lkbLocalEstoque.Click += new System.EventHandler(this.lkbLocalEstoque_Click);
            // 
            // lkpLocalEstoque
            // 
            this.lkpLocalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpLocalEstoque.ButtonLookup = this.lkbLocalEstoque;
            this.lkpLocalEstoque.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo",
        "Filial.Nome"};
            this.lkpLocalEstoque.CamposRestricoesAND = null;
            this.lkpLocalEstoque.CamposRestricoesNOT = null;
            this.lkpLocalEstoque.CamposRestricoesOR = null;
            this.lkpLocalEstoque.ColunaDescricao = new string[] {
        "Descrição",
        "Código",
        "Filial"};
            this.lkpLocalEstoque.ColunaTamanho = new string[] {
        "200",
        "90",
        "150"};
            this.lkpLocalEstoque.ContextoLinq = null;
            this.lkpLocalEstoque.CwkFuncaoValidacao = null;
            this.lkpLocalEstoque.CwkMascara = null;
            this.lkpLocalEstoque.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpLocalEstoque.Enabled = false;
            this.lkpLocalEstoque.Exemplo = null;
            this.lkpLocalEstoque.ID = 0;
            this.lkpLocalEstoque.Join = null;
            this.lkpLocalEstoque.Key = System.Windows.Forms.Keys.F5;
            this.lkpLocalEstoque.Location = new System.Drawing.Point(81, 33);
            this.lkpLocalEstoque.Name = "lkpLocalEstoque";
            this.lkpLocalEstoque.OnIDChanged = null;
            this.lkpLocalEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpLocalEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpLocalEstoque.SelecionarTextoOnEnter = true;
            this.lkpLocalEstoque.Size = new System.Drawing.Size(537, 20);
            this.lkpLocalEstoque.Tabela = "";
            this.lkpLocalEstoque.TabIndex = 4;
            this.lkpLocalEstoque.TituloTelaPesquisa = "";
            this.lkpLocalEstoque.ToolTip = "Campos pesquisados: Descricao, Codigo, Filial.Nome.";
            this.lkpLocalEstoque.Where = null;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Local Estoque:";
            // 
            // btConsultarEstoque
            // 
            this.btConsultarEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConsultarEstoque.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarEstoque.ImageIndex = 1;
            this.btConsultarEstoque.Location = new System.Drawing.Point(654, 33);
            this.btConsultarEstoque.Name = "btConsultarEstoque";
            this.btConsultarEstoque.Size = new System.Drawing.Size(135, 22);
            this.btConsultarEstoque.TabIndex = 6;
            this.btConsultarEstoque.Text = "&Consultar Estoque";
            this.btConsultarEstoque.Click += new System.EventHandler(this.btConsultarEstoque_Click);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbFilial.Location = new System.Drawing.Point(624, 7);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 2;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkpFilial
            // 
            this.lkpFilial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpFilial.ButtonLookup = this.lkbFilial;
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
            this.lkpFilial.Location = new System.Drawing.Point(81, 7);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(537, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            this.lkpFilial.Leave += new System.EventHandler(this.lkpFilial_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Empresa:";
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 455);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 5;
            this.btAjuda.Text = "&Ajuda";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.ImageIndex = 2;
            this.btFechar.ImageList = this.imageList1;
            this.btFechar.Location = new System.Drawing.Point(738, 455);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 4;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // rgpMostrar
            // 
            this.rgpMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rgpMostrar.EditValue = 2;
            this.rgpMostrar.Location = new System.Drawing.Point(152, 455);
            this.rgpMostrar.Name = "rgpMostrar";
            this.rgpMostrar.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Abaixo de Zero"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Abaixo do Mínimo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Todos")});
            this.rgpMostrar.Size = new System.Drawing.Size(402, 23);
            this.rgpMostrar.TabIndex = 2;
            this.rgpMostrar.EditValueChanged += new System.EventHandler(this.rgpMostrar_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Location = new System.Drawing.Point(105, 460);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mostrar:";
            // 
            // sbMovimentos
            // 
            this.sbMovimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbMovimentos.ImageIndex = 1;
            this.sbMovimentos.ImageList = this.imageList1;
            this.sbMovimentos.Location = new System.Drawing.Point(604, 455);
            this.sbMovimentos.Name = "sbMovimentos";
            this.sbMovimentos.Size = new System.Drawing.Size(128, 23);
            this.sbMovimentos.TabIndex = 3;
            this.sbMovimentos.Text = "&Movimentos";
            this.sbMovimentos.Click += new System.EventHandler(this.sbMovimentos_Click);
            // 
            // FormConsultaEstoquePorFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 490);
            this.Controls.Add(this.sbMovimentos);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rgpMostrar);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormConsultaEstoquePorFilial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estoque por Empresa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultaEstoquePorFilial_FormClosing);
            this.Load += new System.EventHandler(this.FormConsultaEstoquePorFilial_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gcEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgpMostrar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcEstoque;
        public DevExpress.XtraGrid.Views.Grid.GridView gvEstoque;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btConsultarEstoque;
        private DevExpress.XtraEditors.RadioGroup rgpMostrar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.Lookup lkpLocalEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.LookupButton lkbLocalEstoque;
        private DevExpress.XtraEditors.SimpleButton sbMovimentos;
    }
}