namespace Aplicacao
{
    partial class FormConsultaEstoquePorProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaEstoquePorProduto));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDados = new DevExpress.XtraTab.XtraTabPage();
            this.txtLocalizacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.gridListaEstoque = new DevExpress.XtraGrid.GridControl();
            this.gvListaEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EstLocalidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstEfetivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstMinimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.mInfAdicionais = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.txtUnidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGrupoEstoque = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBarraFornecedor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNCM = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.sbMovimentos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInfAdicionais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(785, 442);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Controls.Add(this.lkbProduto);
            this.xtraTabPage1.Controls.Add(this.lkProduto);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(779, 436);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(3, 33);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.tabDados;
            this.xtraTabControl2.Size = new System.Drawing.Size(775, 403);
            this.xtraTabControl2.TabIndex = 3;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDados});
            this.xtraTabControl2.TabStop = false;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.txtLocalizacao);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Controls.Add(this.gridListaEstoque);
            this.tabDados.Controls.Add(this.mInfAdicionais);
            this.tabDados.Controls.Add(this.txtUnidade);
            this.tabDados.Controls.Add(this.label12);
            this.tabDados.Controls.Add(this.txtGrupoEstoque);
            this.tabDados.Controls.Add(this.label1);
            this.tabDados.Controls.Add(this.label8);
            this.tabDados.Controls.Add(this.txtBarraFornecedor);
            this.tabDados.Controls.Add(this.label7);
            this.tabDados.Controls.Add(this.txtNCM);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(769, 375);
            this.tabDados.Text = "Dados";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.CwkFuncaoValidacao = null;
            this.txtLocalizacao.CwkMascara = null;
            this.txtLocalizacao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtLocalizacao.Location = new System.Drawing.Point(88, 157);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtLocalizacao.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocalizacao.Properties.MaxLength = 30;
            this.txtLocalizacao.Properties.ReadOnly = true;
            this.txtLocalizacao.SelecionarTextoOnEnter = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(673, 20);
            this.txtLocalizacao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Localização:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gridListaEstoque
            // 
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridListaEstoque.Location = new System.Drawing.Point(9, 183);
            this.gridListaEstoque.MainView = this.gvListaEstoque;
            this.gridListaEstoque.Name = "gridListaEstoque";
            this.gridListaEstoque.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemCalcEdit2});
            this.gridListaEstoque.Size = new System.Drawing.Size(752, 191);
            this.gridListaEstoque.TabIndex = 12;
            this.gridListaEstoque.TabStop = false;
            this.gridListaEstoque.UseEmbeddedNavigator = true;
            this.gridListaEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListaEstoque});
            // 
            // gvListaEstoque
            // 
            this.gvListaEstoque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.Empty.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvListaEstoque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvListaEstoque.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvListaEstoque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvListaEstoque.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvListaEstoque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvListaEstoque.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.OddRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvListaEstoque.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.Preview.Options.UseFont = true;
            this.gvListaEstoque.Appearance.Preview.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.Row.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvListaEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EstLocalidade,
            this.EstFisico,
            this.EstPedido,
            this.EstEfetivo,
            this.EstMinimo});
            this.gvListaEstoque.GridControl = this.gridListaEstoque;
            this.gvListaEstoque.Name = "gvListaEstoque";
            this.gvListaEstoque.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvListaEstoque.OptionsSelection.MultiSelect = true;
            this.gvListaEstoque.OptionsView.ColumnAutoWidth = false;
            this.gvListaEstoque.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListaEstoque.OptionsView.EnableAppearanceOddRow = true;
            this.gvListaEstoque.OptionsView.ShowGroupPanel = false;
            // 
            // EstLocalidade
            // 
            this.EstLocalidade.AppearanceHeader.Options.UseTextOptions = true;
            this.EstLocalidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EstLocalidade.Caption = "Localidade";
            this.EstLocalidade.FieldName = "LocalEstoque";
            this.EstLocalidade.Name = "EstLocalidade";
            this.EstLocalidade.OptionsColumn.AllowEdit = false;
            this.EstLocalidade.Visible = true;
            this.EstLocalidade.VisibleIndex = 0;
            this.EstLocalidade.Width = 394;
            // 
            // EstFisico
            // 
            this.EstFisico.AppearanceCell.Options.UseTextOptions = true;
            this.EstFisico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstFisico.AppearanceHeader.Options.UseTextOptions = true;
            this.EstFisico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstFisico.Caption = "Est. Físico";
            this.EstFisico.FieldName = "EstoqueFisico";
            this.EstFisico.Name = "EstFisico";
            this.EstFisico.OptionsColumn.AllowEdit = false;
            this.EstFisico.Visible = true;
            this.EstFisico.VisibleIndex = 1;
            this.EstFisico.Width = 85;
            // 
            // EstPedido
            // 
            this.EstPedido.AppearanceCell.Options.UseTextOptions = true;
            this.EstPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstPedido.AppearanceHeader.Options.UseTextOptions = true;
            this.EstPedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstPedido.Caption = "Est. Pedido";
            this.EstPedido.FieldName = "QtdPedido";
            this.EstPedido.Name = "EstPedido";
            this.EstPedido.OptionsColumn.AllowEdit = false;
            this.EstPedido.Visible = true;
            this.EstPedido.VisibleIndex = 2;
            this.EstPedido.Width = 82;
            // 
            // EstEfetivo
            // 
            this.EstEfetivo.AppearanceCell.Options.UseTextOptions = true;
            this.EstEfetivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstEfetivo.AppearanceHeader.Options.UseTextOptions = true;
            this.EstEfetivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstEfetivo.Caption = "Efetivo";
            this.EstEfetivo.FieldName = "Saldo";
            this.EstEfetivo.Name = "EstEfetivo";
            this.EstEfetivo.OptionsColumn.AllowEdit = false;
            this.EstEfetivo.Visible = true;
            this.EstEfetivo.VisibleIndex = 3;
            this.EstEfetivo.Width = 85;
            // 
            // EstMinimo
            // 
            this.EstMinimo.AppearanceCell.Options.UseTextOptions = true;
            this.EstMinimo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstMinimo.AppearanceHeader.Options.UseTextOptions = true;
            this.EstMinimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstMinimo.Caption = "Est. Mínimo";
            this.EstMinimo.FieldName = "EstoqueMin";
            this.EstMinimo.Name = "EstMinimo";
            this.EstMinimo.OptionsColumn.AllowEdit = false;
            this.EstMinimo.Visible = true;
            this.EstMinimo.VisibleIndex = 4;
            this.EstMinimo.Width = 82;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // repositoryItemCalcEdit2
            // 
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            // 
            // mInfAdicionais
            // 
            this.mInfAdicionais.Location = new System.Drawing.Point(88, 58);
            this.mInfAdicionais.Name = "mInfAdicionais";
            this.mInfAdicionais.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.mInfAdicionais.Properties.Appearance.Options.UseBackColor = true;
            this.mInfAdicionais.Properties.MaxLength = 500;
            this.mInfAdicionais.Properties.ReadOnly = true;
            this.mInfAdicionais.Size = new System.Drawing.Size(673, 90);
            this.mInfAdicionais.TabIndex = 9;
            // 
            // txtUnidade
            // 
            this.txtUnidade.CwkFuncaoValidacao = null;
            this.txtUnidade.CwkMascara = null;
            this.txtUnidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtUnidade.Location = new System.Drawing.Point(88, 6);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUnidade.Properties.Appearance.Options.UseBackColor = true;
            this.txtUnidade.Properties.MaxLength = 30;
            this.txtUnidade.Properties.ReadOnly = true;
            this.txtUnidade.SelecionarTextoOnEnter = true;
            this.txtUnidade.Size = new System.Drawing.Size(85, 20);
            this.txtUnidade.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Inf. Adicionais:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGrupoEstoque
            // 
            this.txtGrupoEstoque.CwkFuncaoValidacao = null;
            this.txtGrupoEstoque.CwkMascara = null;
            this.txtGrupoEstoque.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtGrupoEstoque.Location = new System.Drawing.Point(88, 32);
            this.txtGrupoEstoque.Name = "txtGrupoEstoque";
            this.txtGrupoEstoque.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtGrupoEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.txtGrupoEstoque.Properties.MaxLength = 30;
            this.txtGrupoEstoque.Properties.ReadOnly = true;
            this.txtGrupoEstoque.SelecionarTextoOnEnter = true;
            this.txtGrupoEstoque.Size = new System.Drawing.Size(673, 20);
            this.txtGrupoEstoque.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Grupo Est.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBarraFornecedor
            // 
            this.txtBarraFornecedor.CwkFuncaoValidacao = null;
            this.txtBarraFornecedor.CwkMascara = null;
            this.txtBarraFornecedor.CwkValidacao = null;
            this.txtBarraFornecedor.Location = new System.Drawing.Point(655, 6);
            this.txtBarraFornecedor.Name = "txtBarraFornecedor";
            this.txtBarraFornecedor.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBarraFornecedor.Properties.Appearance.Options.UseBackColor = true;
            this.txtBarraFornecedor.Properties.ReadOnly = true;
            this.txtBarraFornecedor.SelecionarTextoOnEnter = true;
            this.txtBarraFornecedor.Size = new System.Drawing.Size(106, 20);
            this.txtBarraFornecedor.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Código Barra Fornecedor:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNCM
            // 
            this.txtNCM.CwkFuncaoValidacao = null;
            this.txtNCM.CwkMascara = null;
            this.txtNCM.CwkValidacao = null;
            this.txtNCM.Location = new System.Drawing.Point(255, 6);
            this.txtNCM.Name = "txtNCM";
            this.txtNCM.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNCM.Properties.Appearance.Options.UseBackColor = true;
            this.txtNCM.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNCM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNCM.Properties.ReadOnly = true;
            this.txtNCM.SelecionarTextoOnEnter = true;
            this.txtNCM.Size = new System.Drawing.Size(106, 20);
            this.txtNCM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NCM:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lkbProduto
            // 
            this.lkbProduto.Location = new System.Drawing.Point(734, 7);
            this.lkbProduto.Lookup = null;
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbProduto.SubForm = null;
            this.lkbProduto.SubFormType = null;
            this.lkbProduto.SubFormTypeParams = null;
            this.lkbProduto.TabIndex = 2;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "...";
            this.lkbProduto.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // lkProduto
            // 
            this.lkProduto.ButtonLookup = this.lkbProduto;
            this.lkProduto.CamposPesquisa = new string[] {
        "Codigo",
        "Nome",
        "Barra"};
            this.lkProduto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkProduto.CamposRestricoesAND")));
            this.lkProduto.CamposRestricoesNOT = null;
            this.lkProduto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkProduto.CamposRestricoesOR")));
            this.lkProduto.ColunaDescricao = new string[] {
        "Código",
        "Nome",
        "Barra"};
            this.lkProduto.ColunaTamanho = new string[] {
        "50",
        "150",
        "100"};
            this.lkProduto.ContextoLinq = null;
            this.lkProduto.CwkFuncaoValidacao = null;
            this.lkProduto.CwkMascara = null;
            this.lkProduto.CwkValidacao = null;
            this.lkProduto.Exemplo = null;
            this.lkProduto.ID = 0;
            this.lkProduto.Join = null;
            this.lkProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkProduto.Location = new System.Drawing.Point(85, 7);
            this.lkProduto.Name = "lkProduto";
            this.lkProduto.OnIDChanged = null;
            this.lkProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkProduto.SelecionarTextoOnEnter = true;
            this.lkProduto.Size = new System.Drawing.Size(643, 20);
            this.lkProduto.Tabela = "Produto";
            this.lkProduto.TabIndex = 1;
            this.lkProduto.TituloTelaPesquisa = "Pesquisa - Produto";
            this.lkProduto.ToolTip = "Campos pesquisados: Codigo, Nome, Barra.";
            this.lkProduto.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Produto:";
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 457);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 3;
            this.btAjuda.Text = "&Ajuda";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.ImageIndex = 2;
            this.btFechar.ImageList = this.imageList1;
            this.btFechar.Location = new System.Drawing.Point(722, 457);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // sbMovimentos
            // 
            this.sbMovimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbMovimentos.ImageIndex = 1;
            this.sbMovimentos.ImageList = this.imageList1;
            this.sbMovimentos.Location = new System.Drawing.Point(588, 457);
            this.sbMovimentos.Name = "sbMovimentos";
            this.sbMovimentos.Size = new System.Drawing.Size(128, 23);
            this.sbMovimentos.TabIndex = 1;
            this.sbMovimentos.Text = "&Movimentos";
            this.sbMovimentos.Click += new System.EventHandler(this.sbMovimentos_Click);
            // 
            // FormConsultaEstoquePorProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 492);
            this.Controls.Add(this.sbMovimentos);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormConsultaEstoquePorProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Estoque";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInfAdicionais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBarraFornecedor;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNCM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Cwork.Utilitarios.Componentes.DevMemoEdit mInfAdicionais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtUnidade;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtGrupoEstoque;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkProduto;
        public DevExpress.XtraGrid.GridControl gridListaEstoque;
        public DevExpress.XtraGrid.Views.Grid.GridView gvListaEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn EstLocalidade;
        private DevExpress.XtraGrid.Columns.GridColumn EstFisico;
        private DevExpress.XtraGrid.Columns.GridColumn EstPedido;
        private DevExpress.XtraGrid.Columns.GridColumn EstEfetivo;
        private DevExpress.XtraGrid.Columns.GridColumn EstMinimo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage tabDados;
        private DevExpress.XtraEditors.SimpleButton sbMovimentos;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLocalizacao;
        private System.Windows.Forms.Label label2;
    }
}