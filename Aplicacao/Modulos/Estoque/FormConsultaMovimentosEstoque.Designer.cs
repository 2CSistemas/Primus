namespace Aplicacao
{
    partial class FormConsultaMovimentosEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaMovimentosEstoque));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcMovimentos = new DevExpress.XtraGrid.GridControl();
            this.gvMovimentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnCodNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCodFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnSerieNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNumeroNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnValorUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCustoUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCustoMedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCMVUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnIdentificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnQuantidadeIdent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCMVUnitIdent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.sbConsultarNota = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit4)).BeginInit();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(785, 401);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcMovimentos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(779, 395);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcMovimentos
            // 
            this.gcMovimentos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcMovimentos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcMovimentos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcMovimentos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcMovimentos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcMovimentos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcMovimentos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcMovimentos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcMovimentos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcMovimentos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcMovimentos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcMovimentos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcMovimentos.Location = new System.Drawing.Point(3, 3);
            this.gcMovimentos.MainView = this.gvMovimentos;
            this.gcMovimentos.Name = "gcMovimentos";
            this.gcMovimentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit3,
            this.repositoryItemCalcEdit4});
            this.gcMovimentos.Size = new System.Drawing.Size(772, 388);
            this.gcMovimentos.TabIndex = 0;
            this.gcMovimentos.UseEmbeddedNavigator = true;
            this.gcMovimentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMovimentos});
            // 
            // gvMovimentos
            // 
            this.gvMovimentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMovimentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMovimentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMovimentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMovimentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMovimentos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMovimentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMovimentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMovimentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMovimentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMovimentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvMovimentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvMovimentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.Preview.Options.UseFont = true;
            this.gvMovimentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMovimentos.Appearance.Row.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvMovimentos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMovimentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvMovimentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvMovimentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMovimentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMovimentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnCodNota,
            this.columnCodFilial,
            this.columnSerieNota,
            this.columnNumeroNota,
            this.columnData,
            this.columnTipo,
            this.columnQuantidade,
            this.columnValorUnit,
            this.columnCustoUnit,
            this.columnCustoMedio,
            this.columnCMVUnit,
            this.columnIdentificador,
            this.columnQuantidadeIdent,
            this.columnCMVUnitIdent});
            this.gvMovimentos.GridControl = this.gcMovimentos;
            this.gvMovimentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvMovimentos.Name = "gvMovimentos";
            this.gvMovimentos.OptionsBehavior.Editable = false;
            this.gvMovimentos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvMovimentos.OptionsSelection.MultiSelect = true;
            this.gvMovimentos.OptionsView.ColumnAutoWidth = false;
            this.gvMovimentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMovimentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvMovimentos.OptionsView.ShowAutoFilterRow = true;
            // 
            // columnCodNota
            // 
            this.columnCodNota.Caption = "Cód. Nota";
            this.columnCodNota.FieldName = "CodNota";
            this.columnCodNota.Name = "columnCodNota";
            this.columnCodNota.Visible = true;
            this.columnCodNota.VisibleIndex = 0;
            // 
            // columnCodFilial
            // 
            this.columnCodFilial.Caption = "Cód. Filial";
            this.columnCodFilial.FieldName = "CodFilial";
            this.columnCodFilial.Name = "columnCodFilial";
            this.columnCodFilial.Visible = true;
            this.columnCodFilial.VisibleIndex = 1;
            // 
            // columnSerieNota
            // 
            this.columnSerieNota.Caption = "Série Nota";
            this.columnSerieNota.FieldName = "SerieNota";
            this.columnSerieNota.Name = "columnSerieNota";
            this.columnSerieNota.Visible = true;
            this.columnSerieNota.VisibleIndex = 2;
            // 
            // columnNumeroNota
            // 
            this.columnNumeroNota.Caption = "Número Nota";
            this.columnNumeroNota.FieldName = "NumeroNota";
            this.columnNumeroNota.Name = "columnNumeroNota";
            this.columnNumeroNota.Visible = true;
            this.columnNumeroNota.VisibleIndex = 3;
            // 
            // columnData
            // 
            this.columnData.Caption = "Data";
            this.columnData.FieldName = "Data";
            this.columnData.Name = "columnData";
            this.columnData.Visible = true;
            this.columnData.VisibleIndex = 4;
            // 
            // columnTipo
            // 
            this.columnTipo.Caption = "Tipo";
            this.columnTipo.FieldName = "Tipo";
            this.columnTipo.Name = "columnTipo";
            this.columnTipo.Visible = true;
            this.columnTipo.VisibleIndex = 5;
            // 
            // columnQuantidade
            // 
            this.columnQuantidade.Caption = "Quantidade";
            this.columnQuantidade.FieldName = "Quantidade";
            this.columnQuantidade.Name = "columnQuantidade";
            this.columnQuantidade.Visible = true;
            this.columnQuantidade.VisibleIndex = 6;
            // 
            // columnValorUnit
            // 
            this.columnValorUnit.Caption = "Valor Unitário";
            this.columnValorUnit.FieldName = "ValorUnit";
            this.columnValorUnit.Name = "columnValorUnit";
            this.columnValorUnit.Visible = true;
            this.columnValorUnit.VisibleIndex = 7;
            // 
            // columnCustoUnit
            // 
            this.columnCustoUnit.Caption = "Custo Unitário";
            this.columnCustoUnit.FieldName = "CustoUnit";
            this.columnCustoUnit.Name = "columnCustoUnit";
            this.columnCustoUnit.Visible = true;
            this.columnCustoUnit.VisibleIndex = 8;
            // 
            // columnCustoMedio
            // 
            this.columnCustoMedio.Caption = "Custo Médio";
            this.columnCustoMedio.FieldName = "CustoMedio";
            this.columnCustoMedio.Name = "columnCustoMedio";
            this.columnCustoMedio.Visible = true;
            this.columnCustoMedio.VisibleIndex = 9;
            // 
            // columnCMVUnit
            // 
            this.columnCMVUnit.Caption = "CMV Unitário";
            this.columnCMVUnit.FieldName = "CMVUnit";
            this.columnCMVUnit.Name = "columnCMVUnit";
            this.columnCMVUnit.Visible = true;
            this.columnCMVUnit.VisibleIndex = 10;
            // 
            // columnIdentificador
            // 
            this.columnIdentificador.Caption = "Identificador";
            this.columnIdentificador.FieldName = "Identificador";
            this.columnIdentificador.Name = "columnIdentificador";
            this.columnIdentificador.Visible = true;
            this.columnIdentificador.VisibleIndex = 11;
            // 
            // columnQuantidadeIdent
            // 
            this.columnQuantidadeIdent.Caption = "Quantidade Ident.";
            this.columnQuantidadeIdent.FieldName = "QuantidadeIdent";
            this.columnQuantidadeIdent.Name = "columnQuantidadeIdent";
            this.columnQuantidadeIdent.Visible = true;
            this.columnQuantidadeIdent.VisibleIndex = 12;
            // 
            // columnCMVUnitIdent
            // 
            this.columnCMVUnitIdent.Caption = "CMV Unit. Ident.";
            this.columnCMVUnitIdent.FieldName = "CMVUnitIdent";
            this.columnCMVUnitIdent.Name = "columnCMVUnitIdent";
            this.columnCMVUnitIdent.Visible = true;
            this.columnCMVUnitIdent.VisibleIndex = 13;
            // 
            // repositoryItemCalcEdit3
            // 
            this.repositoryItemCalcEdit3.AutoHeight = false;
            this.repositoryItemCalcEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit3.LookAndFeel.SkinName = "Caramel";
            this.repositoryItemCalcEdit3.Name = "repositoryItemCalcEdit3";
            // 
            // repositoryItemCalcEdit4
            // 
            this.repositoryItemCalcEdit4.AutoHeight = false;
            this.repositoryItemCalcEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit4.LookAndFeel.SkinName = "Caramel";
            this.repositoryItemCalcEdit4.Name = "repositoryItemCalcEdit4";
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 416);
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
            this.btFechar.Location = new System.Drawing.Point(722, 416);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // sbConsultarNota
            // 
            this.sbConsultarNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbConsultarNota.ImageIndex = 1;
            this.sbConsultarNota.ImageList = this.imageList1;
            this.sbConsultarNota.Location = new System.Drawing.Point(588, 416);
            this.sbConsultarNota.Name = "sbConsultarNota";
            this.sbConsultarNota.Size = new System.Drawing.Size(128, 23);
            this.sbConsultarNota.TabIndex = 1;
            this.sbConsultarNota.Text = "&Consultar Nota";
            this.sbConsultarNota.Click += new System.EventHandler(this.sbConsultarNota_Click);
            // 
            // FormConsultaMovimentosEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 451);
            this.Controls.Add(this.sbConsultarNota);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormConsultaMovimentosEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Movimentos Estoque";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMovimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        public DevExpress.XtraGrid.GridControl gcMovimentos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvMovimentos;
        private DevExpress.XtraGrid.Columns.GridColumn columnCodNota;
        private DevExpress.XtraGrid.Columns.GridColumn columnCodFilial;
        private DevExpress.XtraGrid.Columns.GridColumn columnSerieNota;
        private DevExpress.XtraGrid.Columns.GridColumn columnNumeroNota;
        private DevExpress.XtraGrid.Columns.GridColumn columnData;
        private DevExpress.XtraGrid.Columns.GridColumn columnTipo;
        private DevExpress.XtraGrid.Columns.GridColumn columnQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn columnValorUnit;
        private DevExpress.XtraGrid.Columns.GridColumn columnCustoUnit;
        private DevExpress.XtraGrid.Columns.GridColumn columnCustoMedio;
        private DevExpress.XtraGrid.Columns.GridColumn columnCMVUnit;
        private DevExpress.XtraGrid.Columns.GridColumn columnIdentificador;
        private DevExpress.XtraGrid.Columns.GridColumn columnQuantidadeIdent;
        private DevExpress.XtraGrid.Columns.GridColumn columnCMVUnitIdent;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit4;
        private DevExpress.XtraEditors.SimpleButton sbConsultarNota;
    }
}