namespace Aplicacao
{
    partial class FormBalanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBalanco));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnConsultarBalancoItem = new Cwork.Utilitarios.Componentes.DevButton();
            this.btnIncluirBalancoItem = new Cwork.Utilitarios.Componentes.DevButton();
            this.btnAlterarBalancoItem = new Cwork.Utilitarios.Componentes.DevButton();
            this.btnExcluirBalancoItem = new Cwork.Utilitarios.Componentes.DevButton();
            this.btnIncluirMais = new DevExpress.XtraEditors.SimpleButton();
            this.gcBalancoItems = new DevExpress.XtraGrid.GridControl();
            this.gvBalancoItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkbLocalEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpLocalEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.btnIncluirIMEI = new Cwork.Utilitarios.Componentes.DevButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBalancoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalancoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoque.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 478);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(476, 478);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(557, 478);
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
            this.tpPrincipal.Controls.Add(this.btnIncluirIMEI);
            this.tpPrincipal.Controls.Add(this.lkbLocalEstoque);
            this.tpPrincipal.Controls.Add(this.lkpLocalEstoque);
            this.tpPrincipal.Controls.Add(this.gcBalancoItems);
            this.tpPrincipal.Controls.Add(this.btnIncluirMais);
            this.tpPrincipal.Controls.Add(this.btnExcluirBalancoItem);
            this.tpPrincipal.Controls.Add(this.btnAlterarBalancoItem);
            this.tpPrincipal.Controls.Add(this.btnIncluirBalancoItem);
            this.tpPrincipal.Controls.Add(this.btnConsultarBalancoItem);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(614, 454);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(620, 460);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Local Estoque:";
            // 
            // btnConsultarBalancoItem
            // 
            this.btnConsultarBalancoItem.GridControl = null;
            this.btnConsultarBalancoItem.GridControlType = null;
            this.btnConsultarBalancoItem.GridControlTypeParams = null;
            this.btnConsultarBalancoItem.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btnConsultarBalancoItem.Location = new System.Drawing.Point(209, 425);
            this.btnConsultarBalancoItem.Name = "btnConsultarBalancoItem";
            this.btnConsultarBalancoItem.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarBalancoItem.SubForm = null;
            this.btnConsultarBalancoItem.SubFormType = null;
            this.btnConsultarBalancoItem.SubFormTypeParams = null;
            this.btnConsultarBalancoItem.TabIndex = 4;
            this.btnConsultarBalancoItem.Text = "Consultar";
            // 
            // btnIncluirBalancoItem
            // 
            this.btnIncluirBalancoItem.GridControl = null;
            this.btnIncluirBalancoItem.GridControlType = null;
            this.btnIncluirBalancoItem.GridControlTypeParams = null;
            this.btnIncluirBalancoItem.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnIncluirBalancoItem.Location = new System.Drawing.Point(371, 425);
            this.btnIncluirBalancoItem.Name = "btnIncluirBalancoItem";
            this.btnIncluirBalancoItem.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirBalancoItem.SubForm = null;
            this.btnIncluirBalancoItem.SubFormType = null;
            this.btnIncluirBalancoItem.SubFormTypeParams = null;
            this.btnIncluirBalancoItem.TabIndex = 6;
            this.btnIncluirBalancoItem.Text = "Incluir";
            // 
            // btnAlterarBalancoItem
            // 
            this.btnAlterarBalancoItem.GridControl = null;
            this.btnAlterarBalancoItem.GridControlType = null;
            this.btnAlterarBalancoItem.GridControlTypeParams = null;
            this.btnAlterarBalancoItem.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnAlterarBalancoItem.Location = new System.Drawing.Point(452, 425);
            this.btnAlterarBalancoItem.Name = "btnAlterarBalancoItem";
            this.btnAlterarBalancoItem.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarBalancoItem.SubForm = null;
            this.btnAlterarBalancoItem.SubFormType = null;
            this.btnAlterarBalancoItem.SubFormTypeParams = null;
            this.btnAlterarBalancoItem.TabIndex = 7;
            this.btnAlterarBalancoItem.Text = "Alterar";
            // 
            // btnExcluirBalancoItem
            // 
            this.btnExcluirBalancoItem.GridControl = null;
            this.btnExcluirBalancoItem.GridControlType = null;
            this.btnExcluirBalancoItem.GridControlTypeParams = null;
            this.btnExcluirBalancoItem.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnExcluirBalancoItem.Location = new System.Drawing.Point(533, 425);
            this.btnExcluirBalancoItem.Name = "btnExcluirBalancoItem";
            this.btnExcluirBalancoItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirBalancoItem.SubForm = null;
            this.btnExcluirBalancoItem.SubFormType = null;
            this.btnExcluirBalancoItem.SubFormTypeParams = null;
            this.btnExcluirBalancoItem.TabIndex = 8;
            this.btnExcluirBalancoItem.Text = "Excluir";
            // 
            // btnIncluirMais
            // 
            this.btnIncluirMais.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnIncluirMais.Location = new System.Drawing.Point(290, 425);
            this.btnIncluirMais.Name = "btnIncluirMais";
            this.btnIncluirMais.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirMais.TabIndex = 5;
            this.btnIncluirMais.Text = "&Incluir +";
            this.btnIncluirMais.Click += new System.EventHandler(this.btnIncluirMais_Click);
            // 
            // gcBalancoItems
            // 
            this.gcBalancoItems.Location = new System.Drawing.Point(7, 32);
            this.gcBalancoItems.MainView = this.gvBalancoItems;
            this.gcBalancoItems.Name = "gcBalancoItems";
            this.gcBalancoItems.Size = new System.Drawing.Size(601, 387);
            this.gcBalancoItems.TabIndex = 3;
            this.gcBalancoItems.TabStop = false;
            this.gcBalancoItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBalancoItems});
            this.gcBalancoItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcBalancoItems_KeyDown);
            this.gcBalancoItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gcBalancoItems_MouseClick);
            // 
            // gvBalancoItems
            // 
            this.gvBalancoItems.ActiveFilterEnabled = false;
            this.gvBalancoItems.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.Empty.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvBalancoItems.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvBalancoItems.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvBalancoItems.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBalancoItems.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBalancoItems.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBalancoItems.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvBalancoItems.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvBalancoItems.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvBalancoItems.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.OddRow.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvBalancoItems.Appearance.OddRow.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvBalancoItems.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.Preview.Options.UseFont = true;
            this.gvBalancoItems.Appearance.Preview.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBalancoItems.Appearance.Row.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvBalancoItems.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvBalancoItems.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvBalancoItems.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvBalancoItems.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvBalancoItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduto,
            this.colQuantidade,
            this.CodMarca});
            this.gvBalancoItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvBalancoItems.GridControl = this.gcBalancoItems;
            this.gvBalancoItems.Name = "gvBalancoItems";
            this.gvBalancoItems.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvBalancoItems.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvBalancoItems.OptionsCustomization.AllowFilter = false;
            this.gvBalancoItems.OptionsCustomization.AllowSort = false;
            this.gvBalancoItems.OptionsDetail.EnableMasterViewMode = false;
            this.gvBalancoItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvBalancoItems.OptionsView.ColumnAutoWidth = false;
            this.gvBalancoItems.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBalancoItems.OptionsView.EnableAppearanceOddRow = true;
            this.gvBalancoItems.OptionsView.ShowGroupPanel = false;
            this.gvBalancoItems.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBalancoItems_FocusedRowChanged);
            this.gvBalancoItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvBalancoItems_KeyDown);
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduto.Caption = "Produto";
            this.colProduto.FieldName = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 0;
            this.colProduto.Width = 63;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantidade.Caption = "Quantidade";
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 1;
            this.colQuantidade.Width = 72;
            // 
            // CodMarca
            // 
            this.CodMarca.Caption = "Código Marca";
            this.CodMarca.FieldName = "CodMarca";
            this.CodMarca.Name = "CodMarca";
            this.CodMarca.Visible = true;
            this.CodMarca.VisibleIndex = 2;
            // 
            // lkbLocalEstoque
            // 
            this.lkbLocalEstoque.Location = new System.Drawing.Point(584, 6);
            this.lkbLocalEstoque.Lookup = null;
            this.lkbLocalEstoque.Name = "lkbLocalEstoque";
            this.lkbLocalEstoque.Size = new System.Drawing.Size(24, 20);
            this.lkbLocalEstoque.SubForm = null;
            this.lkbLocalEstoque.SubFormType = null;
            this.lkbLocalEstoque.SubFormTypeParams = null;
            this.lkbLocalEstoque.TabIndex = 2;
            this.lkbLocalEstoque.TabStop = false;
            this.lkbLocalEstoque.Text = "...";
            // 
            // lkpLocalEstoque
            // 
            this.lkpLocalEstoque.ButtonLookup = this.lkbLocalEstoque;
            this.lkpLocalEstoque.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpLocalEstoque.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpLocalEstoque.CamposRestricoesAND")));
            this.lkpLocalEstoque.CamposRestricoesNOT = null;
            this.lkpLocalEstoque.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpLocalEstoque.CamposRestricoesOR")));
            this.lkpLocalEstoque.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkpLocalEstoque.ColunaTamanho = new string[] {
        "80",
        "150"};
            this.lkpLocalEstoque.ContextoLinq = null;
            this.lkpLocalEstoque.CwkFuncaoValidacao = null;
            this.lkpLocalEstoque.CwkMascara = null;
            this.lkpLocalEstoque.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpLocalEstoque.Exemplo = null;
            this.lkpLocalEstoque.ID = 0;
            this.lkpLocalEstoque.Join = null;
            this.lkpLocalEstoque.Key = System.Windows.Forms.Keys.F5;
            this.lkpLocalEstoque.Location = new System.Drawing.Point(83, 6);
            this.lkpLocalEstoque.Name = "lkpLocalEstoque";
            this.lkpLocalEstoque.OnIDChanged = null;
            this.lkpLocalEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpLocalEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpLocalEstoque.SelecionarTextoOnEnter = true;
            this.lkpLocalEstoque.Size = new System.Drawing.Size(495, 20);
            this.lkpLocalEstoque.Tabela = null;
            this.lkpLocalEstoque.TabIndex = 1;
            this.lkpLocalEstoque.TituloTelaPesquisa = null;
            this.lkpLocalEstoque.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpLocalEstoque.Where = null;
            // 
            // btnIncluirIMEI
            // 
            this.btnIncluirIMEI.GridControl = null;
            this.btnIncluirIMEI.GridControlType = null;
            this.btnIncluirIMEI.GridControlTypeParams = null;
            this.btnIncluirIMEI.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnIncluirIMEI.Location = new System.Drawing.Point(7, 425);
            this.btnIncluirIMEI.Name = "btnIncluirIMEI";
            this.btnIncluirIMEI.Size = new System.Drawing.Size(67, 23);
            this.btnIncluirIMEI.SubForm = null;
            this.btnIncluirIMEI.SubFormType = null;
            this.btnIncluirIMEI.SubFormTypeParams = null;
            this.btnIncluirIMEI.TabIndex = 9;
            this.btnIncluirIMEI.Text = "IMEI";
            this.btnIncluirIMEI.Click += new System.EventHandler(this.btnIncluirIMEI_Click);
            // 
            // FormBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(644, 513);
            this.Name = "FormBalanco";
            this.Load += new System.EventHandler(this.FormBalanco_Load);
            this.Shown += new System.EventHandler(this.FormBalanco_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBalancoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalancoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoque.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevButton btnConsultarBalancoItem;
        private Cwork.Utilitarios.Componentes.DevButton btnExcluirBalancoItem;
        private Cwork.Utilitarios.Componentes.DevButton btnAlterarBalancoItem;
        private Cwork.Utilitarios.Componentes.DevButton btnIncluirBalancoItem;
        private DevExpress.XtraEditors.SimpleButton btnIncluirMais;
        private DevExpress.XtraGrid.GridControl gcBalancoItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBalancoItems;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn CodMarca;
        private Cwork.Utilitarios.Componentes.LookupButton lkbLocalEstoque;
        private Cwork.Utilitarios.Componentes.Lookup lkpLocalEstoque;
        private Cwork.Utilitarios.Componentes.DevButton btnIncluirIMEI;
    }
}
