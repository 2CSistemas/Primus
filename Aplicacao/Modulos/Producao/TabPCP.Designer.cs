using System;
namespace Aplicacao.Modulos.Producao
{
    partial class TabPCP
    {

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabPCP));
            this._gcFichaTecnicaPCPItem = new DevExpress.XtraGrid.GridControl();
            this._gvFichaTecnicaPCPItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aproveitamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataVigor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Versao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbFichaTecnicaRegras = new DevExpress.XtraEditors.LabelControl();
            this._sbCarregaFichaTecnicaItens = new DevExpress.XtraEditors.SimpleButton();
            this.lbObservacao = new DevExpress.XtraEditors.LabelControl();
            this._meObservacao = new DevExpress.XtraEditors.MemoEdit();
            this._sbIncluiFichaTecnicaItem = new DevExpress.XtraEditors.SimpleButton();
            this._sbAlteraFichaTecnicaItem = new DevExpress.XtraEditors.SimpleButton();
            this._sbExcluiFichaTecnicaItem = new DevExpress.XtraEditors.SimpleButton();
            this._sbIncluiFichaTecnicaRegra = new DevExpress.XtraEditors.SimpleButton();
            this._sbAlteraFichaTecnicaRegra = new DevExpress.XtraEditors.SimpleButton();
            this._sbExcluiFichaTecnicaRegra = new DevExpress.XtraEditors.SimpleButton();
            this._pbImagemProduto = new System.Windows.Forms.PictureBox();
            this._sbCapturarImagemProduto = new DevExpress.XtraEditors.SimpleButton();
            this._sbSelecionarImagemProduto = new DevExpress.XtraEditors.SimpleButton();
            this._sbExcluirImagemProduto = new DevExpress.XtraEditors.SimpleButton();
            this.lbNumRevisao = new DevExpress.XtraEditors.LabelControl();
            this.lbData = new DevExpress.XtraEditors.LabelControl();
            this.lbDimensaoLiquido = new DevExpress.XtraEditors.LabelControl();
            this.lbDimesaoBruto = new DevExpress.XtraEditors.LabelControl();
            this.lbDimensoes = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this._sePesoLiquido = new DevExpress.XtraEditors.SpinEdit();
            this._seVolumeLiquido = new DevExpress.XtraEditors.SpinEdit();
            this._seAreaLiquido = new DevExpress.XtraEditors.SpinEdit();
            this._seEspessuraLiquido = new DevExpress.XtraEditors.SpinEdit();
            this._seLarguraLiquido = new DevExpress.XtraEditors.SpinEdit();
            this._seComprimentoLiquido = new DevExpress.XtraEditors.SpinEdit();
            this.lbFormula = new DevExpress.XtraEditors.LabelControl();
            this.lbCodBarras = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lbPcOP = new DevExpress.XtraEditors.LabelControl();
            this._sePecaOP = new DevExpress.XtraEditors.SpinEdit();
            this.lbPeso = new DevExpress.XtraEditors.LabelControl();
            this._sePesoBruto = new DevExpress.XtraEditors.SpinEdit();
            this.lbVolume = new DevExpress.XtraEditors.LabelControl();
            this._seVolumeBruto = new DevExpress.XtraEditors.SpinEdit();
            this.lbArea = new DevExpress.XtraEditors.LabelControl();
            this._seAreaBruto = new DevExpress.XtraEditors.SpinEdit();
            this.lbEspessura = new DevExpress.XtraEditors.LabelControl();
            this._seEspessuraBruto = new DevExpress.XtraEditors.SpinEdit();
            this.lbLargura = new DevExpress.XtraEditors.LabelControl();
            this._seLarguraBruto = new DevExpress.XtraEditors.SpinEdit();
            this.lbComprimento = new DevExpress.XtraEditors.LabelControl();
            this.lbCodigo = new DevExpress.XtraEditors.LabelControl();
            this._sbEAN13 = new DevExpress.XtraEditors.SimpleButton();
            this._meFormula = new DevExpress.XtraEditors.MemoEdit();
            this._seComprimentoBruto = new DevExpress.XtraEditors.SpinEdit();
            this._seRevisao = new DevExpress.XtraEditors.SpinEdit();
            this._deData = new DevExpress.XtraEditors.DateEdit();
            this._txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this._txtCodBarras = new DevExpress.XtraEditors.TextEdit();
            this._gcFichaTecnicaPCPRegra = new DevExpress.XtraGrid.GridControl();
            this._gvFichaTecnicaPCPRegra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.dxErrorProviderTab = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._gcFichaTecnicaPCPItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gvFichaTecnicaPCPItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._meObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sePesoLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seVolumeLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seAreaLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seEspessuraLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seLarguraLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seComprimentoLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sePecaOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sePesoBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seVolumeBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seAreaBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seEspessuraBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seLarguraBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._meFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seComprimentoBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._seRevisao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCodBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gcFichaTecnicaPCPRegra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gvFichaTecnicaPCPRegra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderTab)).BeginInit();
            this.SuspendLayout();
            // 
            // _gcFichaTecnicaPCPItem
            // 
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.Append.Visible = false;
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this._gcFichaTecnicaPCPItem.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this._gcFichaTecnicaPCPItem.Location = new System.Drawing.Point(3, 266);
            this._gcFichaTecnicaPCPItem.LookAndFeel.UseWindowsXPTheme = true;
            this._gcFichaTecnicaPCPItem.MainView = this._gvFichaTecnicaPCPItem;
            this._gcFichaTecnicaPCPItem.Name = "_gcFichaTecnicaPCPItem";
            this._gcFichaTecnicaPCPItem.Size = new System.Drawing.Size(866, 169);
            this._gcFichaTecnicaPCPItem.TabIndex = 137;
            this._gcFichaTecnicaPCPItem.UseEmbeddedNavigator = true;
            this._gcFichaTecnicaPCPItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gvFichaTecnicaPCPItem});
            // 
            // _gvFichaTecnicaPCPItem
            // 
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.Empty.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.EvenRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.EvenRow.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.EvenRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this._gvFichaTecnicaPCPItem.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this._gvFichaTecnicaPCPItem.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this._gvFichaTecnicaPCPItem.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.FilterPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FilterPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.FixedLine.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPItem.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.FocusedCell.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FocusedCell.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPItem.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPItem.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FocusedRow.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FocusedRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.FooterPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FooterPanel.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.FooterPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.GroupButton.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupButton.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.GroupFooter.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupFooter.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupFooter.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this._gvFichaTecnicaPCPItem.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.GroupRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this._gvFichaTecnicaPCPItem.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this._gvFichaTecnicaPCPItem.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.HeaderPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.HeaderPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPItem.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.OddRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.OddRow.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.OddRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this._gvFichaTecnicaPCPItem.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.Preview.Options.UseFont = true;
            this._gvFichaTecnicaPCPItem.Appearance.Preview.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPItem.Appearance.Row.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPItem.Appearance.RowSeparator.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPItem.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPItem.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.SelectedRow.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.SelectedRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPItem.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPItem.Appearance.TopNewRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPItem.BestFitMaxRowCount = 5;
            this._gvFichaTecnicaPCPItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.MateriaPrima,
            this.Quantidade,
            this.Aproveitamento,
            this.Unidade,
            this.DataVigor,
            this.Versao});
            this._gvFichaTecnicaPCPItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this._gvFichaTecnicaPCPItem.GridControl = this._gcFichaTecnicaPCPItem;
            this._gvFichaTecnicaPCPItem.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this._gvFichaTecnicaPCPItem.Name = "_gvFichaTecnicaPCPItem";
            this._gvFichaTecnicaPCPItem.OptionsBehavior.AllowIncrementalSearch = true;
            this._gvFichaTecnicaPCPItem.OptionsBehavior.Editable = false;
            this._gvFichaTecnicaPCPItem.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this._gvFichaTecnicaPCPItem.OptionsDetail.EnableDetailToolTip = true;
            this._gvFichaTecnicaPCPItem.OptionsSelection.EnableAppearanceHideSelection = false;
            this._gvFichaTecnicaPCPItem.OptionsView.ColumnAutoWidth = false;
            this._gvFichaTecnicaPCPItem.OptionsView.EnableAppearanceEvenRow = true;
            this._gvFichaTecnicaPCPItem.OptionsView.EnableAppearanceOddRow = true;
            this._gvFichaTecnicaPCPItem.OptionsView.ShowAutoFilterRow = true;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Produto.Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 98;
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.Caption = "Matéria Prima";
            this.MateriaPrima.FieldName = "Produto";
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.Visible = true;
            this.MateriaPrima.VisibleIndex = 1;
            this.MateriaPrima.Width = 361;
            // 
            // Quantidade
            // 
            this.Quantidade.Caption = "Quantidade";
            this.Quantidade.FieldName = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Visible = true;
            this.Quantidade.VisibleIndex = 2;
            // 
            // Aproveitamento
            // 
            this.Aproveitamento.Caption = "Aproveitamento";
            this.Aproveitamento.DisplayFormat.FormatString = "{0:00} %";
            this.Aproveitamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Aproveitamento.FieldName = "Aproveitamento";
            this.Aproveitamento.Name = "Aproveitamento";
            this.Aproveitamento.Visible = true;
            this.Aproveitamento.VisibleIndex = 3;
            this.Aproveitamento.Width = 87;
            // 
            // Unidade
            // 
            this.Unidade.Caption = "Unidade";
            this.Unidade.FieldName = "Produto.Unidade.Sigla";
            this.Unidade.Name = "Unidade";
            this.Unidade.Visible = true;
            this.Unidade.VisibleIndex = 4;
            this.Unidade.Width = 50;
            // 
            // DataVigor
            // 
            this.DataVigor.Caption = "Data Vigor";
            this.DataVigor.FieldName = "DataVigor";
            this.DataVigor.Name = "DataVigor";
            this.DataVigor.Visible = true;
            this.DataVigor.VisibleIndex = 5;
            this.DataVigor.Width = 86;
            // 
            // Versao
            // 
            this.Versao.Caption = "Versão";
            this.Versao.FieldName = "FichaTecnicaPCPFilha.Nome";
            this.Versao.Name = "Versao";
            this.Versao.Visible = true;
            this.Versao.VisibleIndex = 6;
            this.Versao.Width = 90;
            // 
            // lbFichaTecnicaRegras
            // 
            this.lbFichaTecnicaRegras.Location = new System.Drawing.Point(439, 467);
            this.lbFichaTecnicaRegras.Name = "lbFichaTecnicaRegras";
            this.lbFichaTecnicaRegras.Size = new System.Drawing.Size(38, 13);
            this.lbFichaTecnicaRegras.TabIndex = 130;
            this.lbFichaTecnicaRegras.Text = "Regras:";
            // 
            // _sbCarregaFichaTecnicaItens
            // 
            this._sbCarregaFichaTecnicaItens.Image = ((System.Drawing.Image)(resources.GetObject("_sbCarregaFichaTecnicaItens.Image")));
            this._sbCarregaFichaTecnicaItens.Location = new System.Drawing.Point(2, 441);
            this._sbCarregaFichaTecnicaItens.Name = "_sbCarregaFichaTecnicaItens";
            this._sbCarregaFichaTecnicaItens.Size = new System.Drawing.Size(100, 20);
            this._sbCarregaFichaTecnicaItens.TabIndex = 23;
            this._sbCarregaFichaTecnicaItens.Text = "Carregar Ficha";
            this._sbCarregaFichaTecnicaItens.Click += new System.EventHandler(this._sbCarregaFichaTecnicaItens_Click);
            // 
            // lbObservacao
            // 
            this.lbObservacao.Location = new System.Drawing.Point(2, 467);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(62, 13);
            this.lbObservacao.TabIndex = 128;
            this.lbObservacao.Text = "Observação:";
            // 
            // _meObservacao
            // 
            this._meObservacao.Location = new System.Drawing.Point(2, 486);
            this._meObservacao.Name = "_meObservacao";
            this._meObservacao.Size = new System.Drawing.Size(430, 112);
            this._meObservacao.TabIndex = 28;
            // 
            // _sbIncluiFichaTecnicaItem
            // 
            this._sbIncluiFichaTecnicaItem.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this._sbIncluiFichaTecnicaItem.Location = new System.Drawing.Point(557, 441);
            this._sbIncluiFichaTecnicaItem.Name = "_sbIncluiFichaTecnicaItem";
            this._sbIncluiFichaTecnicaItem.Size = new System.Drawing.Size(100, 20);
            this._sbIncluiFichaTecnicaItem.TabIndex = 25;
            this._sbIncluiFichaTecnicaItem.Text = "Incluir";
            this._sbIncluiFichaTecnicaItem.Click += new System.EventHandler(this._sbIncluiFichaTecnicaItem_Click);
            // 
            // _sbAlteraFichaTecnicaItem
            // 
            this._sbAlteraFichaTecnicaItem.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this._sbAlteraFichaTecnicaItem.Location = new System.Drawing.Point(663, 441);
            this._sbAlteraFichaTecnicaItem.Name = "_sbAlteraFichaTecnicaItem";
            this._sbAlteraFichaTecnicaItem.Size = new System.Drawing.Size(100, 20);
            this._sbAlteraFichaTecnicaItem.TabIndex = 26;
            this._sbAlteraFichaTecnicaItem.Text = "Alterar";
            this._sbAlteraFichaTecnicaItem.Click += new System.EventHandler(this._sbAlteraFichaTecnicaItem_Click);
            // 
            // _sbExcluiFichaTecnicaItem
            // 
            this._sbExcluiFichaTecnicaItem.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this._sbExcluiFichaTecnicaItem.Location = new System.Drawing.Point(769, 441);
            this._sbExcluiFichaTecnicaItem.Name = "_sbExcluiFichaTecnicaItem";
            this._sbExcluiFichaTecnicaItem.Size = new System.Drawing.Size(100, 20);
            this._sbExcluiFichaTecnicaItem.TabIndex = 27;
            this._sbExcluiFichaTecnicaItem.Text = "Excluir";
            this._sbExcluiFichaTecnicaItem.Click += new System.EventHandler(this._sbExcluiFichaTecnicaItem_Click);
            // 
            // _sbIncluiFichaTecnicaRegra
            // 
            this._sbIncluiFichaTecnicaRegra.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this._sbIncluiFichaTecnicaRegra.Location = new System.Drawing.Point(557, 604);
            this._sbIncluiFichaTecnicaRegra.Name = "_sbIncluiFichaTecnicaRegra";
            this._sbIncluiFichaTecnicaRegra.Size = new System.Drawing.Size(100, 20);
            this._sbIncluiFichaTecnicaRegra.TabIndex = 30;
            this._sbIncluiFichaTecnicaRegra.Text = "Incluir";
            this._sbIncluiFichaTecnicaRegra.Click += new System.EventHandler(this._sbIncluiFichaTecnicaRegra_Click);
            // 
            // _sbAlteraFichaTecnicaRegra
            // 
            this._sbAlteraFichaTecnicaRegra.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this._sbAlteraFichaTecnicaRegra.Location = new System.Drawing.Point(663, 604);
            this._sbAlteraFichaTecnicaRegra.Name = "_sbAlteraFichaTecnicaRegra";
            this._sbAlteraFichaTecnicaRegra.Size = new System.Drawing.Size(100, 20);
            this._sbAlteraFichaTecnicaRegra.TabIndex = 31;
            this._sbAlteraFichaTecnicaRegra.Text = "Alterar";
            this._sbAlteraFichaTecnicaRegra.Click += new System.EventHandler(this._sbAlteraFichaTecnicaRegra_Click);
            // 
            // _sbExcluiFichaTecnicaRegra
            // 
            this._sbExcluiFichaTecnicaRegra.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this._sbExcluiFichaTecnicaRegra.Location = new System.Drawing.Point(769, 604);
            this._sbExcluiFichaTecnicaRegra.Name = "_sbExcluiFichaTecnicaRegra";
            this._sbExcluiFichaTecnicaRegra.Size = new System.Drawing.Size(100, 20);
            this._sbExcluiFichaTecnicaRegra.TabIndex = 32;
            this._sbExcluiFichaTecnicaRegra.Text = "Excluir";
            this._sbExcluiFichaTecnicaRegra.Click += new System.EventHandler(this._sbExcluiFichaTecnicaRegra_Click);
            // 
            // _pbImagemProduto
            // 
            this._pbImagemProduto.BackColor = System.Drawing.Color.Transparent;
            this._pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pbImagemProduto.ErrorImage = global::Aplicacao.Properties.Resources.cancelar_copy;
            this._pbImagemProduto.Image = global::Aplicacao.Properties.Resources.Logo_128;
            this._pbImagemProduto.InitialImage = global::Aplicacao.Properties.Resources.Logo_128;
            this._pbImagemProduto.Location = new System.Drawing.Point(464, 3);
            this._pbImagemProduto.Name = "_pbImagemProduto";
            this._pbImagemProduto.Size = new System.Drawing.Size(405, 157);
            this._pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pbImagemProduto.TabIndex = 126;
            this._pbImagemProduto.TabStop = false;
            // 
            // _sbCapturarImagemProduto
            // 
            this._sbCapturarImagemProduto.Location = new System.Drawing.Point(557, 162);
            this._sbCapturarImagemProduto.Name = "_sbCapturarImagemProduto";
            this._sbCapturarImagemProduto.Size = new System.Drawing.Size(100, 20);
            this._sbCapturarImagemProduto.TabIndex = 19;
            this._sbCapturarImagemProduto.Text = "Capturar";
            this._sbCapturarImagemProduto.Click += new System.EventHandler(this._sbCapturarImagemProduto_Click);
            // 
            // _sbSelecionarImagemProduto
            // 
            this._sbSelecionarImagemProduto.Location = new System.Drawing.Point(663, 162);
            this._sbSelecionarImagemProduto.Name = "_sbSelecionarImagemProduto";
            this._sbSelecionarImagemProduto.Size = new System.Drawing.Size(100, 20);
            this._sbSelecionarImagemProduto.TabIndex = 20;
            this._sbSelecionarImagemProduto.Text = "Selecionar";
            this._sbSelecionarImagemProduto.Click += new System.EventHandler(this._sbSelecionarImagemProduto_Click);
            // 
            // _sbExcluirImagemProduto
            // 
            this._sbExcluirImagemProduto.Location = new System.Drawing.Point(769, 162);
            this._sbExcluirImagemProduto.Name = "_sbExcluirImagemProduto";
            this._sbExcluirImagemProduto.Size = new System.Drawing.Size(100, 20);
            this._sbExcluirImagemProduto.TabIndex = 21;
            this._sbExcluirImagemProduto.Text = "Excluir";
            this._sbExcluirImagemProduto.Click += new System.EventHandler(this._sbExcluirImagemProduto_Click);
            // 
            // lbNumRevisao
            // 
            this.lbNumRevisao.Location = new System.Drawing.Point(18, 58);
            this.lbNumRevisao.Name = "lbNumRevisao";
            this.lbNumRevisao.Size = new System.Drawing.Size(97, 13);
            this.lbNumRevisao.TabIndex = 123;
            this.lbNumRevisao.Text = "Número da Revisão:";
            // 
            // lbData
            // 
            this.lbData.Location = new System.Drawing.Point(88, 32);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(27, 13);
            this.lbData.TabIndex = 122;
            this.lbData.Text = "Data:";
            // 
            // lbDimensaoLiquido
            // 
            this.lbDimensaoLiquido.Location = new System.Drawing.Point(249, 86);
            this.lbDimensaoLiquido.Name = "lbDimensaoLiquido";
            this.lbDimensaoLiquido.Size = new System.Drawing.Size(33, 13);
            this.lbDimensaoLiquido.TabIndex = 121;
            this.lbDimensaoLiquido.Text = "Líquido";
            // 
            // lbDimesaoBruto
            // 
            this.lbDimesaoBruto.Location = new System.Drawing.Point(121, 86);
            this.lbDimesaoBruto.Name = "lbDimesaoBruto";
            this.lbDimesaoBruto.Size = new System.Drawing.Size(26, 13);
            this.lbDimesaoBruto.TabIndex = 120;
            this.lbDimesaoBruto.Text = "Bruto";
            // 
            // lbDimensoes
            // 
            this.lbDimensoes.Location = new System.Drawing.Point(18, 86);
            this.lbDimensoes.Name = "lbDimensoes";
            this.lbDimensoes.Size = new System.Drawing.Size(55, 13);
            this.lbDimensoes.TabIndex = 119;
            this.lbDimensoes.Text = "Dimensões:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(321, 243);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(11, 13);
            this.labelControl9.TabIndex = 118;
            this.labelControl9.Text = "kg";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(321, 217);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(18, 13);
            this.labelControl18.TabIndex = 117;
            this.labelControl18.Text = "cm³";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(321, 191);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(18, 13);
            this.labelControl19.TabIndex = 116;
            this.labelControl19.Text = "cm²";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(321, 165);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(16, 13);
            this.labelControl20.TabIndex = 115;
            this.labelControl20.Text = "mm";
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(321, 139);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(16, 13);
            this.labelControl21.TabIndex = 114;
            this.labelControl21.Text = "mm";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(321, 113);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(16, 13);
            this.labelControl22.TabIndex = 113;
            this.labelControl22.Text = "mm";
            // 
            // _sePesoLiquido
            // 
            this._sePesoLiquido.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._sePesoLiquido.Location = new System.Drawing.Point(215, 240);
            this._sePesoLiquido.Name = "_sePesoLiquido";
            this._sePesoLiquido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._sePesoLiquido.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._sePesoLiquido.Properties.NullText = "0";
            this._sePesoLiquido.Size = new System.Drawing.Size(100, 20);
            this._sePesoLiquido.TabIndex = 18;
            // 
            // _seVolumeLiquido
            // 
            this._seVolumeLiquido.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seVolumeLiquido.Location = new System.Drawing.Point(215, 214);
            this._seVolumeLiquido.Name = "_seVolumeLiquido";
            this._seVolumeLiquido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seVolumeLiquido.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seVolumeLiquido.Properties.NullText = "0";
            this._seVolumeLiquido.Size = new System.Drawing.Size(100, 20);
            this._seVolumeLiquido.TabIndex = 16;
            // 
            // _seAreaLiquido
            // 
            this._seAreaLiquido.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seAreaLiquido.Location = new System.Drawing.Point(215, 188);
            this._seAreaLiquido.Name = "_seAreaLiquido";
            this._seAreaLiquido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seAreaLiquido.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seAreaLiquido.Properties.NullText = "0";
            this._seAreaLiquido.Size = new System.Drawing.Size(100, 20);
            this._seAreaLiquido.TabIndex = 14;
            // 
            // _seEspessuraLiquido
            // 
            this._seEspessuraLiquido.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seEspessuraLiquido.Location = new System.Drawing.Point(215, 162);
            this._seEspessuraLiquido.Name = "_seEspessuraLiquido";
            this._seEspessuraLiquido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seEspessuraLiquido.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seEspessuraLiquido.Properties.NullText = "0";
            this._seEspessuraLiquido.Size = new System.Drawing.Size(100, 20);
            this._seEspessuraLiquido.TabIndex = 12;
            // 
            // _seLarguraLiquido
            // 
            this._seLarguraLiquido.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seLarguraLiquido.Location = new System.Drawing.Point(215, 136);
            this._seLarguraLiquido.Name = "_seLarguraLiquido";
            this._seLarguraLiquido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seLarguraLiquido.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seLarguraLiquido.Properties.NullText = "0";
            this._seLarguraLiquido.Size = new System.Drawing.Size(100, 20);
            this._seLarguraLiquido.TabIndex = 10;
            // 
            // _seComprimentoLiquido
            // 
            this._seComprimentoLiquido.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seComprimentoLiquido.Location = new System.Drawing.Point(215, 110);
            this._seComprimentoLiquido.Name = "_seComprimentoLiquido";
            this._seComprimentoLiquido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seComprimentoLiquido.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seComprimentoLiquido.Properties.NullText = "0";
            this._seComprimentoLiquido.Size = new System.Drawing.Size(100, 20);
            this._seComprimentoLiquido.TabIndex = 8;
            // 
            // lbFormula
            // 
            this.lbFormula.Location = new System.Drawing.Point(417, 192);
            this.lbFormula.Name = "lbFormula";
            this.lbFormula.Size = new System.Drawing.Size(42, 13);
            this.lbFormula.TabIndex = 111;
            this.lbFormula.Text = "Fórmula:";
            // 
            // lbCodBarras
            // 
            this.lbCodBarras.Location = new System.Drawing.Point(267, 6);
            this.lbCodBarras.Name = "lbCodBarras";
            this.lbCodBarras.Size = new System.Drawing.Size(86, 13);
            this.lbCodBarras.TabIndex = 109;
            this.lbCodBarras.Text = "Código de Barras:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(193, 243);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(11, 13);
            this.labelControl10.TabIndex = 104;
            this.labelControl10.Text = "kg";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(193, 217);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(18, 13);
            this.labelControl11.TabIndex = 102;
            this.labelControl11.Text = "cm³";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(193, 191);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(18, 13);
            this.labelControl12.TabIndex = 100;
            this.labelControl12.Text = "cm²";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(193, 165);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(16, 13);
            this.labelControl13.TabIndex = 99;
            this.labelControl13.Text = "mm";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(193, 139);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(16, 13);
            this.labelControl14.TabIndex = 96;
            this.labelControl14.Text = "mm";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(193, 113);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(16, 13);
            this.labelControl15.TabIndex = 94;
            this.labelControl15.Text = "mm";
            // 
            // lbPcOP
            // 
            this.lbPcOP.Location = new System.Drawing.Point(285, 58);
            this.lbPcOP.Name = "lbPcOP";
            this.lbPcOP.Size = new System.Drawing.Size(68, 13);
            this.lbPcOP.TabIndex = 92;
            this.lbPcOP.Text = "Peças por OP:";
            // 
            // _sePecaOP
            // 
            this._sePecaOP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._sePecaOP.Location = new System.Drawing.Point(359, 55);
            this._sePecaOP.Name = "_sePecaOP";
            this._sePecaOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._sePecaOP.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._sePecaOP.Properties.NullText = "0";
            this._sePecaOP.Size = new System.Drawing.Size(100, 20);
            this._sePecaOP.TabIndex = 6;
            // 
            // lbPeso
            // 
            this.lbPeso.Location = new System.Drawing.Point(18, 243);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(27, 13);
            this.lbPeso.TabIndex = 90;
            this.lbPeso.Text = "Peso:";
            // 
            // _sePesoBruto
            // 
            this._sePesoBruto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._sePesoBruto.Location = new System.Drawing.Point(87, 240);
            this._sePesoBruto.Name = "_sePesoBruto";
            this._sePesoBruto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._sePesoBruto.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._sePesoBruto.Properties.NullText = "0";
            this._sePesoBruto.Size = new System.Drawing.Size(100, 20);
            this._sePesoBruto.TabIndex = 17;
            // 
            // lbVolume
            // 
            this.lbVolume.Location = new System.Drawing.Point(18, 217);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(38, 13);
            this.lbVolume.TabIndex = 87;
            this.lbVolume.Text = "Volume:";
            // 
            // _seVolumeBruto
            // 
            this._seVolumeBruto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seVolumeBruto.Location = new System.Drawing.Point(87, 214);
            this._seVolumeBruto.Name = "_seVolumeBruto";
            this._seVolumeBruto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seVolumeBruto.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seVolumeBruto.Properties.NullText = "0";
            this._seVolumeBruto.Size = new System.Drawing.Size(100, 20);
            this._seVolumeBruto.TabIndex = 15;
            // 
            // lbArea
            // 
            this.lbArea.Location = new System.Drawing.Point(18, 191);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(27, 13);
            this.lbArea.TabIndex = 84;
            this.lbArea.Text = "Área:";
            // 
            // _seAreaBruto
            // 
            this._seAreaBruto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seAreaBruto.Location = new System.Drawing.Point(87, 188);
            this._seAreaBruto.Name = "_seAreaBruto";
            this._seAreaBruto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seAreaBruto.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seAreaBruto.Properties.NullText = "0";
            this._seAreaBruto.Size = new System.Drawing.Size(100, 20);
            this._seAreaBruto.TabIndex = 13;
            // 
            // lbEspessura
            // 
            this.lbEspessura.Location = new System.Drawing.Point(18, 165);
            this.lbEspessura.Name = "lbEspessura";
            this.lbEspessura.Size = new System.Drawing.Size(53, 13);
            this.lbEspessura.TabIndex = 81;
            this.lbEspessura.Text = "Espessura:";
            // 
            // _seEspessuraBruto
            // 
            this._seEspessuraBruto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seEspessuraBruto.Location = new System.Drawing.Point(87, 162);
            this._seEspessuraBruto.Name = "_seEspessuraBruto";
            this._seEspessuraBruto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seEspessuraBruto.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seEspessuraBruto.Properties.NullText = "0";
            this._seEspessuraBruto.Size = new System.Drawing.Size(100, 20);
            this._seEspessuraBruto.TabIndex = 11;
            // 
            // lbLargura
            // 
            this.lbLargura.Location = new System.Drawing.Point(18, 139);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(41, 13);
            this.lbLargura.TabIndex = 78;
            this.lbLargura.Text = "Largura:";
            // 
            // _seLarguraBruto
            // 
            this._seLarguraBruto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seLarguraBruto.Location = new System.Drawing.Point(87, 136);
            this._seLarguraBruto.Name = "_seLarguraBruto";
            this._seLarguraBruto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seLarguraBruto.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seLarguraBruto.Properties.NullText = "0";
            this._seLarguraBruto.Size = new System.Drawing.Size(100, 20);
            this._seLarguraBruto.TabIndex = 9;
            // 
            // lbComprimento
            // 
            this.lbComprimento.Location = new System.Drawing.Point(18, 113);
            this.lbComprimento.Name = "lbComprimento";
            this.lbComprimento.Size = new System.Drawing.Size(67, 13);
            this.lbComprimento.TabIndex = 75;
            this.lbComprimento.Text = "Comprimento:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.Location = new System.Drawing.Point(78, 6);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(37, 13);
            this.lbCodigo.TabIndex = 72;
            this.lbCodigo.Text = "Código:";
            // 
            // _sbEAN13
            // 
            this._sbEAN13.Location = new System.Drawing.Point(359, 29);
            this._sbEAN13.Name = "_sbEAN13";
            this._sbEAN13.Size = new System.Drawing.Size(100, 20);
            this._sbEAN13.TabIndex = 4;
            this._sbEAN13.Text = "Gerar EAN13";
            this._sbEAN13.Click += new System.EventHandler(this._sbEAN13_Click);
            // 
            // _meFormula
            // 
            this._meFormula.Location = new System.Drawing.Point(464, 189);
            this._meFormula.Name = "_meFormula";
            this._meFormula.Size = new System.Drawing.Size(405, 71);
            this._meFormula.TabIndex = 22;
            // 
            // _seComprimentoBruto
            // 
            this._seComprimentoBruto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seComprimentoBruto.Location = new System.Drawing.Point(87, 110);
            this._seComprimentoBruto.Name = "_seComprimentoBruto";
            this._seComprimentoBruto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seComprimentoBruto.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seComprimentoBruto.Properties.NullText = "0";
            this._seComprimentoBruto.Size = new System.Drawing.Size(100, 20);
            this._seComprimentoBruto.TabIndex = 7;
            // 
            // _seRevisao
            // 
            this._seRevisao.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._seRevisao.Location = new System.Drawing.Point(121, 55);
            this._seRevisao.Name = "_seRevisao";
            this._seRevisao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._seRevisao.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this._seRevisao.Properties.NullText = "0";
            this._seRevisao.Size = new System.Drawing.Size(140, 20);
            this._seRevisao.TabIndex = 5;
            this._seRevisao.Leave += new System.EventHandler(this._seRevisao_Leave);
            // 
            // _deData
            // 
            this._deData.EditValue = null;
            this._deData.Location = new System.Drawing.Point(121, 29);
            this._deData.Name = "_deData";
            this._deData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._deData.Size = new System.Drawing.Size(140, 20);
            this._deData.TabIndex = 3;
            this._deData.Leave += new System.EventHandler(this._deData_Leave);
            // 
            // _txtCodigo
            // 
            this._txtCodigo.Location = new System.Drawing.Point(121, 3);
            this._txtCodigo.Name = "_txtCodigo";
            this._txtCodigo.Size = new System.Drawing.Size(140, 20);
            this._txtCodigo.TabIndex = 1;
            this._txtCodigo.Leave += new System.EventHandler(this._txtCodigo_Leave);
            // 
            // _txtCodBarras
            // 
            this._txtCodBarras.Location = new System.Drawing.Point(359, 3);
            this._txtCodBarras.Name = "_txtCodBarras";
            this._txtCodBarras.Size = new System.Drawing.Size(100, 20);
            this._txtCodBarras.TabIndex = 2;
            // 
            // _gcFichaTecnicaPCPRegra
            // 
            this._gcFichaTecnicaPCPRegra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._gcFichaTecnicaPCPRegra.EmbeddedNavigator.Buttons.Append.Visible = false;
            this._gcFichaTecnicaPCPRegra.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this._gcFichaTecnicaPCPRegra.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this._gcFichaTecnicaPCPRegra.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this._gcFichaTecnicaPCPRegra.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this._gcFichaTecnicaPCPRegra.Location = new System.Drawing.Point(439, 486);
            this._gcFichaTecnicaPCPRegra.MainView = this._gvFichaTecnicaPCPRegra;
            this._gcFichaTecnicaPCPRegra.Name = "_gcFichaTecnicaPCPRegra";
            this._gcFichaTecnicaPCPRegra.Size = new System.Drawing.Size(427, 112);
            this._gcFichaTecnicaPCPRegra.TabIndex = 138;
            this._gcFichaTecnicaPCPRegra.UseEmbeddedNavigator = true;
            this._gcFichaTecnicaPCPRegra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._gvFichaTecnicaPCPRegra,
            this.cardView1});
            // 
            // _gvFichaTecnicaPCPRegra
            // 
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.Empty.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.EvenRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.EvenRow.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.EvenRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FilterPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FixedLine.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedCell.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedCell.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FocusedRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.FooterPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FooterPanel.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.FooterPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.GroupButton.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupButton.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupFooter.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupFooter.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupFooter.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this._gvFichaTecnicaPCPRegra.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.GroupRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this._gvFichaTecnicaPCPRegra.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this._gvFichaTecnicaPCPRegra.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.HeaderPanel.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.HeaderPanel.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this._gvFichaTecnicaPCPRegra.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.OddRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.OddRow.Options.UseBorderColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.OddRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this._gvFichaTecnicaPCPRegra.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.Preview.Options.UseFont = true;
            this._gvFichaTecnicaPCPRegra.Appearance.Preview.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this._gvFichaTecnicaPCPRegra.Appearance.Row.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this._gvFichaTecnicaPCPRegra.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.RowSeparator.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.SelectedRow.Options.UseForeColor = true;
            this._gvFichaTecnicaPCPRegra.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this._gvFichaTecnicaPCPRegra.Appearance.TopNewRow.Options.UseBackColor = true;
            this._gvFichaTecnicaPCPRegra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this._gvFichaTecnicaPCPRegra.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this._gvFichaTecnicaPCPRegra.GridControl = this._gcFichaTecnicaPCPRegra;
            this._gvFichaTecnicaPCPRegra.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this._gvFichaTecnicaPCPRegra.Name = "_gvFichaTecnicaPCPRegra";
            this._gvFichaTecnicaPCPRegra.OptionsBehavior.Editable = false;
            this._gvFichaTecnicaPCPRegra.OptionsBehavior.FocusLeaveOnTab = true;
            this._gvFichaTecnicaPCPRegra.OptionsCustomization.AllowFilter = false;
            this._gvFichaTecnicaPCPRegra.OptionsCustomization.AllowSort = false;
            this._gvFichaTecnicaPCPRegra.OptionsDetail.EnableMasterViewMode = false;
            this._gvFichaTecnicaPCPRegra.OptionsSelection.EnableAppearanceFocusedCell = false;
            this._gvFichaTecnicaPCPRegra.OptionsView.EnableAppearanceEvenRow = true;
            this._gvFichaTecnicaPCPRegra.OptionsView.EnableAppearanceOddRow = true;
            this._gvFichaTecnicaPCPRegra.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 117;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descricao";
            this.gridColumn2.FieldName = "Descricao";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 687;
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this._gcFichaTecnicaPCPRegra;
            this.cardView1.Name = "cardView1";
            // 
            // dxErrorProviderTab
            // 
            this.dxErrorProviderTab.ContainerControl = this;
            // 
            // TabPCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._gcFichaTecnicaPCPRegra);
            this.Controls.Add(this._gcFichaTecnicaPCPItem);
            this.Controls.Add(this._txtCodBarras);
            this.Controls.Add(this._txtCodigo);
            this.Controls.Add(this._deData);
            this.Controls.Add(this._seRevisao);
            this.Controls.Add(this.lbFichaTecnicaRegras);
            this.Controls.Add(this._sbCarregaFichaTecnicaItens);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this._meObservacao);
            this.Controls.Add(this._sbIncluiFichaTecnicaItem);
            this.Controls.Add(this._sbAlteraFichaTecnicaItem);
            this.Controls.Add(this._sbExcluiFichaTecnicaItem);
            this.Controls.Add(this._sbIncluiFichaTecnicaRegra);
            this.Controls.Add(this._sbAlteraFichaTecnicaRegra);
            this.Controls.Add(this._sbExcluiFichaTecnicaRegra);
            this.Controls.Add(this._pbImagemProduto);
            this.Controls.Add(this._sbCapturarImagemProduto);
            this.Controls.Add(this._sbSelecionarImagemProduto);
            this.Controls.Add(this._sbExcluirImagemProduto);
            this.Controls.Add(this.lbNumRevisao);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbDimensaoLiquido);
            this.Controls.Add(this.lbDimesaoBruto);
            this.Controls.Add(this.lbDimensoes);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.labelControl21);
            this.Controls.Add(this.labelControl22);
            this.Controls.Add(this._sePesoLiquido);
            this.Controls.Add(this._seVolumeLiquido);
            this.Controls.Add(this._seAreaLiquido);
            this.Controls.Add(this._seEspessuraLiquido);
            this.Controls.Add(this._seLarguraLiquido);
            this.Controls.Add(this._seComprimentoLiquido);
            this.Controls.Add(this.lbFormula);
            this.Controls.Add(this.lbCodBarras);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.lbPcOP);
            this.Controls.Add(this._sePecaOP);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this._sePesoBruto);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this._seVolumeBruto);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this._seAreaBruto);
            this.Controls.Add(this.lbEspessura);
            this.Controls.Add(this._seEspessuraBruto);
            this.Controls.Add(this.lbLargura);
            this.Controls.Add(this._seLarguraBruto);
            this.Controls.Add(this.lbComprimento);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this._sbEAN13);
            this.Controls.Add(this._meFormula);
            this.Controls.Add(this._seComprimentoBruto);
            this.Name = "TabPCP";
            this.Size = new System.Drawing.Size(869, 624);
            ((System.ComponentModel.ISupportInitialize)(this._gcFichaTecnicaPCPItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gvFichaTecnicaPCPItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._meObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sePesoLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seVolumeLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seAreaLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seEspessuraLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seLarguraLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seComprimentoLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sePecaOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sePesoBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seVolumeBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seAreaBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seEspessuraBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seLarguraBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._meFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seComprimentoBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._seRevisao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCodBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gcFichaTecnicaPCPRegra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gvFichaTecnicaPCPRegra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbFichaTecnicaRegras;
        private DevExpress.XtraEditors.SimpleButton _sbCarregaFichaTecnicaItens;
        private DevExpress.XtraEditors.LabelControl lbObservacao;
        private DevExpress.XtraEditors.MemoEdit _meObservacao;
        private DevExpress.XtraEditors.SimpleButton _sbIncluiFichaTecnicaItem;
        private DevExpress.XtraEditors.SimpleButton _sbAlteraFichaTecnicaItem;
        private DevExpress.XtraEditors.SimpleButton _sbExcluiFichaTecnicaItem;
        private DevExpress.XtraEditors.SimpleButton _sbIncluiFichaTecnicaRegra;
        private DevExpress.XtraEditors.SimpleButton _sbAlteraFichaTecnicaRegra;
        private DevExpress.XtraEditors.SimpleButton _sbExcluiFichaTecnicaRegra;
        private System.Windows.Forms.PictureBox _pbImagemProduto;
        private DevExpress.XtraEditors.SimpleButton _sbCapturarImagemProduto;
        private DevExpress.XtraEditors.SimpleButton _sbSelecionarImagemProduto;
        private DevExpress.XtraEditors.SimpleButton _sbExcluirImagemProduto;
        private DevExpress.XtraEditors.LabelControl lbNumRevisao;
        private DevExpress.XtraEditors.LabelControl lbData;
        private DevExpress.XtraEditors.LabelControl lbDimensaoLiquido;
        private DevExpress.XtraEditors.LabelControl lbDimesaoBruto;
        private DevExpress.XtraEditors.LabelControl lbDimensoes;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.SpinEdit _sePesoLiquido;
        private DevExpress.XtraEditors.SpinEdit _seVolumeLiquido;
        private DevExpress.XtraEditors.SpinEdit _seAreaLiquido;
        private DevExpress.XtraEditors.SpinEdit _seEspessuraLiquido;
        private DevExpress.XtraEditors.SpinEdit _seLarguraLiquido;
        private DevExpress.XtraEditors.SpinEdit _seComprimentoLiquido;
        private DevExpress.XtraEditors.LabelControl lbFormula;
        private DevExpress.XtraEditors.LabelControl lbCodBarras;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl lbPcOP;
        private DevExpress.XtraEditors.SpinEdit _sePecaOP;
        private DevExpress.XtraEditors.LabelControl lbPeso;
        private DevExpress.XtraEditors.SpinEdit _sePesoBruto;
        private DevExpress.XtraEditors.LabelControl lbVolume;
        private DevExpress.XtraEditors.SpinEdit _seVolumeBruto;
        private DevExpress.XtraEditors.LabelControl lbArea;
        private DevExpress.XtraEditors.SpinEdit _seAreaBruto;
        private DevExpress.XtraEditors.LabelControl lbEspessura;
        private DevExpress.XtraEditors.SpinEdit _seEspessuraBruto;
        private DevExpress.XtraEditors.LabelControl lbLargura;
        private DevExpress.XtraEditors.SpinEdit _seLarguraBruto;
        private DevExpress.XtraEditors.LabelControl lbComprimento;
        private DevExpress.XtraEditors.LabelControl lbCodigo;
        private DevExpress.XtraEditors.SimpleButton _sbEAN13;
        private DevExpress.XtraEditors.MemoEdit _meFormula;
        private DevExpress.XtraEditors.SpinEdit _seComprimentoBruto;
        private DevExpress.XtraEditors.SpinEdit _seRevisao;
        private DevExpress.XtraEditors.DateEdit _deData;
        private DevExpress.XtraEditors.TextEdit _txtCodigo;
        private DevExpress.XtraEditors.TextEdit _txtCodBarras;
        public DevExpress.XtraGrid.GridControl _gcFichaTecnicaPCPItem;
        public DevExpress.XtraGrid.Views.Grid.GridView _gvFichaTecnicaPCPItem;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn MateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn Quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn Aproveitamento;
        private DevExpress.XtraGrid.Columns.GridColumn Unidade;
        private DevExpress.XtraGrid.Columns.GridColumn DataVigor;
        private DevExpress.XtraGrid.Columns.GridColumn Versao;
        private DevExpress.XtraGrid.GridControl _gcFichaTecnicaPCPRegra;
        private DevExpress.XtraGrid.Views.Grid.GridView _gvFichaTecnicaPCPRegra;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.ComponentModel.IContainer components;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProviderTab;


    }
}
