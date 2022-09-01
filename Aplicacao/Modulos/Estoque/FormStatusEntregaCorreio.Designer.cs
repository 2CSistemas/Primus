namespace Aplicacao.Modulos.Comercial
{
    partial class FormStatusEntregaCorreio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatusEntregaCorreio));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.EventosCorreio = new DevExpress.XtraTab.XtraTabPage();
            this.gcEventosCorreio = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gvEventosCorreio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Detalhe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusEntrega = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricaoHTML = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.tabStatusEntrega = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            this.EventosCorreio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEventosCorreio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventosCorreio)).BeginInit();
            this.StatusEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabStatusEntrega)).BeginInit();
            this.tabStatusEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 450);
            this.sbAjuda.TabIndex = 2;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(565, 450);
            this.sbGravar.TabIndex = 0;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(646, 450);
            this.sbCancelar.TabIndex = 1;
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
            this.tpPrincipal.Controls.Add(this.tabStatusEntrega);
            this.tpPrincipal.Size = new System.Drawing.Size(703, 426);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(709, 432);
            this.tcPrincipal.TabIndex = 3;
            // 
            // EventosCorreio
            // 
            this.EventosCorreio.Controls.Add(this.gcEventosCorreio);
            this.EventosCorreio.Name = "EventosCorreio";
            this.EventosCorreio.Size = new System.Drawing.Size(690, 393);
            this.EventosCorreio.Text = "Eventos Correio";
            // 
            // gcEventosCorreio
            // 
            this.gcEventosCorreio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcEventosCorreio.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcEventosCorreio.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcEventosCorreio.Location = new System.Drawing.Point(3, 3);
            this.gcEventosCorreio.MainView = this.gvEventosCorreio;
            this.gcEventosCorreio.Name = "gcEventosCorreio";
            this.gcEventosCorreio.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.gcEventosCorreio.Size = new System.Drawing.Size(684, 387);
            this.gcEventosCorreio.TabIndex = 1;
            this.gcEventosCorreio.UseEmbeddedNavigator = true;
            this.gcEventosCorreio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEventosCorreio});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcEventosCorreio;
            this.gridView1.Name = "gridView1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "P4";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "c2";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Mask.EditMask = "c2";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Mask.EditMask = "n3";
            this.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // gvEventosCorreio
            // 
            this.gvEventosCorreio.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.Empty.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEventosCorreio.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEventosCorreio.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEventosCorreio.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEventosCorreio.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEventosCorreio.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEventosCorreio.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEventosCorreio.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEventosCorreio.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEventosCorreio.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEventosCorreio.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvEventosCorreio.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.Preview.Options.UseFont = true;
            this.gvEventosCorreio.Appearance.Preview.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEventosCorreio.Appearance.Row.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvEventosCorreio.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEventosCorreio.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEventosCorreio.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEventosCorreio.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvEventosCorreio.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEventosCorreio.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvEventosCorreio.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvEventosCorreio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.Tipo,
            this.Descricao,
            this.Detalhe});
            this.gvEventosCorreio.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvEventosCorreio.GridControl = this.gcEventosCorreio;
            this.gvEventosCorreio.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvEventosCorreio.Name = "gvEventosCorreio";
            this.gvEventosCorreio.OptionsBehavior.Editable = false;
            this.gvEventosCorreio.OptionsCustomization.AllowColumnMoving = false;
            this.gvEventosCorreio.OptionsCustomization.AllowColumnResizing = false;
            this.gvEventosCorreio.OptionsCustomization.AllowFilter = false;
            this.gvEventosCorreio.OptionsCustomization.AllowGroup = false;
            this.gvEventosCorreio.OptionsCustomization.AllowSort = false;
            this.gvEventosCorreio.OptionsNavigation.UseTabKey = false;
            this.gvEventosCorreio.OptionsSelection.MultiSelect = true;
            this.gvEventosCorreio.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEventosCorreio.OptionsView.EnableAppearanceOddRow = true;
            this.gvEventosCorreio.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 45;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 1;
            this.Tipo.Width = 150;
            // 
            // Descricao
            // 
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 2;
            this.Descricao.Width = 201;
            // 
            // Detalhe
            // 
            this.Detalhe.Caption = "Detalhe";
            this.Detalhe.FieldName = "Detalhe";
            this.Detalhe.Name = "Detalhe";
            this.Detalhe.Visible = true;
            this.Detalhe.VisibleIndex = 3;
            this.Detalhe.Width = 216;
            // 
            // StatusEntrega
            // 
            this.StatusEntrega.Controls.Add(this.txtCodigo);
            this.StatusEntrega.Controls.Add(this.labelControl4);
            this.StatusEntrega.Controls.Add(this.labelControl3);
            this.StatusEntrega.Controls.Add(this.txtDescricaoHTML);
            this.StatusEntrega.Controls.Add(this.labelControl2);
            this.StatusEntrega.Controls.Add(this.txtDescricao);
            this.StatusEntrega.Controls.Add(this.labelControl1);
            this.StatusEntrega.Name = "StatusEntrega";
            this.StatusEntrega.Size = new System.Drawing.Size(690, 393);
            this.StatusEntrega.Tag = "StatusEntregaTag";
            this.StatusEntrega.Text = "Status Entrega";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 44);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(601, 133);
            this.txtDescricao.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descrição:";
            // 
            // txtDescricaoHTML
            // 
            this.txtDescricaoHTML.Location = new System.Drawing.Point(73, 183);
            this.txtDescricaoHTML.Name = "txtDescricaoHTML";
            this.txtDescricaoHTML.Size = new System.Drawing.Size(601, 200);
            this.txtDescricaoHTML.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 183);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Descrição:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 202);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "(HTML)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(73, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.Properties.MaxLength = 2;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(113, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // tabStatusEntrega
            // 
            this.tabStatusEntrega.Location = new System.Drawing.Point(3, 3);
            this.tabStatusEntrega.Name = "tabStatusEntrega";
            this.tabStatusEntrega.SelectedTabPage = this.StatusEntrega;
            this.tabStatusEntrega.Size = new System.Drawing.Size(696, 419);
            this.tabStatusEntrega.TabIndex = 0;
            this.tabStatusEntrega.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.StatusEntrega,
            this.EventosCorreio});
            // 
            // FormStatusEntregaCorreio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(733, 485);
            this.Name = "FormStatusEntregaCorreio";
            this.Text = "Status Entrega";
            this.Shown += new System.EventHandler(this.FormStatusEntrega_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            this.EventosCorreio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEventosCorreio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventosCorreio)).EndInit();
            this.StatusEntrega.ResumeLayout(false);
            this.StatusEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabStatusEntrega)).EndInit();
            this.tabStatusEntrega.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabStatusEntrega;
        private DevExpress.XtraTab.XtraTabPage StatusEntrega;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraRichEdit.RichEditControl txtDescricaoHTML;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage EventosCorreio;
        public DevExpress.XtraGrid.GridControl gcEventosCorreio;
        public DevExpress.XtraGrid.Views.Grid.GridView gvEventosCorreio;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn Detalhe;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

    }
}
