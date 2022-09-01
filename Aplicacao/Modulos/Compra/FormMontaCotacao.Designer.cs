namespace Aplicacao
{
    partial class FormMontaCotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMontaCotacao));
            this.gcCotacaoProdutos = new DevExpress.XtraGrid.GridControl();
            this.gvCotacaoProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkbCotacao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCotacao = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnTodos = new DevExpress.XtraEditors.SimpleButton();
            this.btnNenhum = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCotacaoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotacaoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCotacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 359);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(598, 359);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(679, 359);
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
            this.tpPrincipal.Controls.Add(this.btnNenhum);
            this.tpPrincipal.Controls.Add(this.btnTodos);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkbCotacao);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.lkpCotacao);
            this.tpPrincipal.Controls.Add(this.gcCotacaoProdutos);
            this.tpPrincipal.Size = new System.Drawing.Size(736, 335);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(742, 341);
            // 
            // gcCotacaoProdutos
            // 
            this.gcCotacaoProdutos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcCotacaoProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcCotacaoProdutos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcCotacaoProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcCotacaoProdutos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcCotacaoProdutos.Location = new System.Drawing.Point(13, 32);
            this.gcCotacaoProdutos.MainView = this.gvCotacaoProdutos;
            this.gcCotacaoProdutos.Name = "gcCotacaoProdutos";
            this.gcCotacaoProdutos.Size = new System.Drawing.Size(707, 260);
            this.gcCotacaoProdutos.TabIndex = 9;
            this.gcCotacaoProdutos.Tag = "Dont Change me!";
            this.gcCotacaoProdutos.UseEmbeddedNavigator = true;
            this.gcCotacaoProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCotacaoProdutos});
            // 
            // gvCotacaoProdutos
            // 
            this.gvCotacaoProdutos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.Empty.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCotacaoProdutos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCotacaoProdutos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCotacaoProdutos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoProdutos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoProdutos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoProdutos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCotacaoProdutos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCotacaoProdutos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCotacaoProdutos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoProdutos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvCotacaoProdutos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.Preview.Options.UseFont = true;
            this.gvCotacaoProdutos.Appearance.Preview.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoProdutos.Appearance.Row.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvCotacaoProdutos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoProdutos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoProdutos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCotacaoProdutos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvCotacaoProdutos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCotacaoProdutos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvCotacaoProdutos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvCotacaoProdutos.BestFitMaxRowCount = 5;
            this.gvCotacaoProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvCotacaoProdutos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvCotacaoProdutos.GridControl = this.gcCotacaoProdutos;
            this.gvCotacaoProdutos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvCotacaoProdutos.Name = "gvCotacaoProdutos";
            this.gvCotacaoProdutos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvCotacaoProdutos.OptionsDetail.EnableMasterViewMode = false;
            this.gvCotacaoProdutos.OptionsView.ColumnAutoWidth = false;
            this.gvCotacaoProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCotacaoProdutos.OptionsView.EnableAppearanceOddRow = true;
            this.gvCotacaoProdutos.OptionsView.ShowGroupPanel = false;
            this.gvCotacaoProdutos.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Produto";
            this.gridColumn2.FieldName = "Produto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 452;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Qtd.";
            this.gridColumn3.FieldName = "Quantidade";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 81;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Selec.";
            this.gridColumn4.FieldName = "Selecionado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 51;
            // 
            // lkbCotacao
            // 
            this.lkbCotacao.Location = new System.Drawing.Point(534, 301);
            this.lkbCotacao.Lookup = null;
            this.lkbCotacao.Name = "lkbCotacao";
            this.lkbCotacao.Size = new System.Drawing.Size(24, 20);
            this.lkbCotacao.SubForm = null;
            this.lkbCotacao.SubFormType = null;
            this.lkbCotacao.SubFormTypeParams = null;
            this.lkbCotacao.TabIndex = 6;
            this.lkbCotacao.TabStop = false;
            this.lkbCotacao.Text = "...";
            // 
            // lkpCotacao
            // 
            this.lkpCotacao.ButtonLookup = this.lkbCotacao;
            this.lkpCotacao.CamposPesquisa = new string[] {
        "Codigo",
        "Resumo"};
            this.lkpCotacao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCotacao.CamposRestricoesAND")));
            this.lkpCotacao.CamposRestricoesNOT = null;
            this.lkpCotacao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCotacao.CamposRestricoesOR")));
            this.lkpCotacao.ColunaDescricao = new string[] {
        "Codigo",
        "Resumo"};
            this.lkpCotacao.ColunaTamanho = new string[] {
        "50",
        "200"};
            this.lkpCotacao.ContextoLinq = null;
            this.lkpCotacao.CwkFuncaoValidacao = null;
            this.lkpCotacao.CwkMascara = null;
            this.lkpCotacao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCotacao.Exemplo = null;
            this.lkpCotacao.ID = 0;
            this.lkpCotacao.Join = null;
            this.lkpCotacao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCotacao.Location = new System.Drawing.Point(73, 301);
            this.lkpCotacao.Name = "lkpCotacao";
            this.lkpCotacao.OnIDChanged = null;
            this.lkpCotacao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCotacao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCotacao.SelecionarTextoOnEnter = true;
            this.lkpCotacao.Size = new System.Drawing.Size(455, 20);
            this.lkpCotacao.Tabela = null;
            this.lkpCotacao.TabIndex = 5;
            this.lkpCotacao.TituloTelaPesquisa = null;
            this.lkpCotacao.ToolTip = "Campos pesquisados: Codigo, Resumo.";
            this.lkpCotacao.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 304);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Cotação:";
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "50",
        "200"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(73, 6);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(617, 20);
            this.lkpFilial.Tabela = null;
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFilial.Where = null;
            this.lkpFilial.Leave += new System.EventHandler(this.lkpFilial_Leave);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(696, 6);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 2;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Empresa:";
            // 
            // btnTodos
            // 
            this.btnTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.btnTodos.Location = new System.Drawing.Point(564, 300);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 7;
            this.btnTodos.Text = "Todos";
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnNenhum
            // 
            this.btnNenhum.ImageIndex = 2;
            this.btnNenhum.ImageList = this.imageList1;
            this.btnNenhum.Location = new System.Drawing.Point(645, 300);
            this.btnNenhum.Name = "btnNenhum";
            this.btnNenhum.Size = new System.Drawing.Size(75, 23);
            this.btnNenhum.TabIndex = 8;
            this.btnNenhum.Text = "Nenhum";
            this.btnNenhum.Click += new System.EventHandler(this.btnNenhum_Click);
            // 
            // FormMontaCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 394);
            this.Name = "FormMontaCotacao";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCotacaoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotacaoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCotacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCotacaoProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCotacaoProdutos;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCotacao;
        private Cwork.Utilitarios.Componentes.Lookup lkpCotacao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.SimpleButton btnTodos;
        private DevExpress.XtraEditors.SimpleButton btnNenhum;
    }
}
