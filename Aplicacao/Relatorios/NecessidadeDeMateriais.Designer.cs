namespace Aplicacao.Relatorios
{
    partial class NecessidadeDeMateriais
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
            this.lblLocalEstoque = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.lkpLocalEstoque = new DevExpress.XtraEditors.LookUpEdit();
            this.lblGrupoEstoque = new DevExpress.XtraEditors.LabelControl();
            this.gcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.gvEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbGrupo = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTpOrcamento = new DevExpress.XtraEditors.LabelControl();
            this.lbTpRequisicao = new DevExpress.XtraEditors.LabelControl();
            this.gcGrupoEstoque = new DevExpress.XtraGrid.GridControl();
            this.gvGrupoEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Classificacao_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTipoRequisicao = new DevExpress.XtraGrid.GridControl();
            this.gvTipoRequisicao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTipoOrcamento = new DevExpress.XtraGrid.GridControl();
            this.gvTipoOrcamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoString = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoRequisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoRequisicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(826, 636);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gcTipoOrcamento);
            this.tabPage1.Controls.Add(this.gcTipoRequisicao);
            this.tabPage1.Controls.Add(this.gcGrupoEstoque);
            this.tabPage1.Controls.Add(this.lbTpRequisicao);
            this.tabPage1.Controls.Add(this.lbTpOrcamento);
            this.tabPage1.Controls.Add(this.gcEmpresas);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.lblGrupoEstoque);
            this.tabPage1.Controls.Add(this.lblLocalEstoque);
            this.tabPage1.Controls.Add(this.dateEdit2);
            this.tabPage1.Controls.Add(this.dateEdit1);
            this.tabPage1.Controls.Add(this.lblPeriodo);
            this.tabPage1.Controls.Add(this.lkpLocalEstoque);
            this.tabPage1.Size = new System.Drawing.Size(820, 630);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(684, 654);
            this.btOk.Click += new System.EventHandler(this.btOk_Click_1);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(763, 654);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 658);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 654);
            // 
            // lblLocalEstoque
            // 
            this.lblLocalEstoque.Location = new System.Drawing.Point(22, 599);
            this.lblLocalEstoque.Name = "lblLocalEstoque";
            this.lblLocalEstoque.Size = new System.Drawing.Size(70, 13);
            this.lblLocalEstoque.TabIndex = 44;
            this.lblLocalEstoque.Text = "Local Estoque:";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(708, 596);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(99, 20);
            this.dateEdit2.TabIndex = 43;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(603, 596);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(99, 20);
            this.dateEdit1.TabIndex = 42;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(557, 599);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lblPeriodo.TabIndex = 41;
            this.lblPeriodo.Text = "Período:";
            // 
            // lkpLocalEstoque
            // 
            this.lkpLocalEstoque.Location = new System.Drawing.Point(95, 596);
            this.lkpLocalEstoque.Name = "lkpLocalEstoque";
            this.lkpLocalEstoque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpLocalEstoque.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FilialStr", "Filial"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição")});
            this.lkpLocalEstoque.Properties.NullText = "";
            this.lkpLocalEstoque.Properties.PopupSizeable = false;
            this.lkpLocalEstoque.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkpLocalEstoque.Size = new System.Drawing.Size(456, 20);
            this.lkpLocalEstoque.TabIndex = 40;
            // 
            // lblGrupoEstoque
            // 
            this.lblGrupoEstoque.Location = new System.Drawing.Point(17, 393);
            this.lblGrupoEstoque.Name = "lblGrupoEstoque";
            this.lblGrupoEstoque.Size = new System.Drawing.Size(75, 13);
            this.lblGrupoEstoque.TabIndex = 49;
            this.lblGrupoEstoque.Text = "Grupo Estoque:";
            // 
            // gcEmpresas
            // 
            this.gcEmpresas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcEmpresas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcEmpresas.Location = new System.Drawing.Point(95, 33);
            this.gcEmpresas.LookAndFeel.UseWindowsXPTheme = true;
            this.gcEmpresas.MainView = this.gvEmpresas;
            this.gcEmpresas.Name = "gcEmpresas";
            this.gcEmpresas.Size = new System.Drawing.Size(712, 133);
            this.gcEmpresas.TabIndex = 55;
            this.gcEmpresas.UseEmbeddedNavigator = true;
            this.gcEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpresas});
            // 
            // gvEmpresas
            // 
            this.gvEmpresas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.Empty.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEmpresas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEmpresas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEmpresas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEmpresas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEmpresas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEmpresas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvEmpresas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.Preview.Options.UseFont = true;
            this.gvEmpresas.Appearance.Preview.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.Row.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvEmpresas.BestFitMaxRowCount = 5;
            this.gvEmpresas.GridControl = this.gcEmpresas;
            this.gvEmpresas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvEmpresas.Name = "gvEmpresas";
            this.gvEmpresas.OptionsBehavior.Editable = false;
            this.gvEmpresas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvEmpresas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmpresas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEmpresas.OptionsView.ShowGroupPanel = false;
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.EditValue = "";
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(95, 7);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Size = new System.Drawing.Size(712, 20);
            this.cbGrupo.TabIndex = 54;
            this.cbGrupo.EditValueChanged += new System.EventHandler(this.cbGrupo_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Grupo:";
            // 
            // lbTpOrcamento
            // 
            this.lbTpOrcamento.Location = new System.Drawing.Point(16, 189);
            this.lbTpOrcamento.Name = "lbTpOrcamento";
            this.lbTpOrcamento.Size = new System.Drawing.Size(76, 13);
            this.lbTpOrcamento.TabIndex = 56;
            this.lbTpOrcamento.Text = "Tp. Orçamento:";
            // 
            // lbTpRequisicao
            // 
            this.lbTpRequisicao.Location = new System.Drawing.Point(457, 170);
            this.lbTpRequisicao.Name = "lbTpRequisicao";
            this.lbTpRequisicao.Size = new System.Drawing.Size(74, 13);
            this.lbTpRequisicao.TabIndex = 57;
            this.lbTpRequisicao.Text = "Tp. Requisição:";
            // 
            // gcGrupoEstoque
            // 
            this.gcGrupoEstoque.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcGrupoEstoque.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcGrupoEstoque.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcGrupoEstoque.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcGrupoEstoque.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcGrupoEstoque.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcGrupoEstoque.Location = new System.Drawing.Point(95, 393);
            this.gcGrupoEstoque.MainView = this.gvGrupoEstoque;
            this.gcGrupoEstoque.Name = "gcGrupoEstoque";
            this.gcGrupoEstoque.Size = new System.Drawing.Size(712, 158);
            this.gcGrupoEstoque.TabIndex = 58;
            this.gcGrupoEstoque.UseEmbeddedNavigator = true;
            this.gcGrupoEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGrupoEstoque});
            // 
            // gvGrupoEstoque
            // 
            this.gvGrupoEstoque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.Empty.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvGrupoEstoque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvGrupoEstoque.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvGrupoEstoque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoEstoque.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoEstoque.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoEstoque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvGrupoEstoque.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvGrupoEstoque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvGrupoEstoque.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoEstoque.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.OddRow.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.OddRow.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvGrupoEstoque.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.Preview.Options.UseFont = true;
            this.gvGrupoEstoque.Appearance.Preview.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoEstoque.Appearance.Row.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoEstoque.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoEstoque.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoEstoque.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvGrupoEstoque.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvGrupoEstoque.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvGrupoEstoque.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvGrupoEstoque.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvGrupoEstoque.BestFitMaxRowCount = 5;
            this.gvGrupoEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo_,
            this.Nome_,
            this.Classificacao_});
            this.gvGrupoEstoque.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvGrupoEstoque.GridControl = this.gcGrupoEstoque;
            this.gvGrupoEstoque.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvGrupoEstoque.Name = "gvGrupoEstoque";
            this.gvGrupoEstoque.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvGrupoEstoque.OptionsBehavior.Editable = false;
            this.gvGrupoEstoque.OptionsDetail.EnableMasterViewMode = false;
            this.gvGrupoEstoque.OptionsSelection.MultiSelect = true;
            this.gvGrupoEstoque.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGrupoEstoque.OptionsView.EnableAppearanceOddRow = true;
            this.gvGrupoEstoque.OptionsView.ShowAutoFilterRow = true;
            this.gvGrupoEstoque.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo_
            // 
            this.Codigo_.Caption = "Código";
            this.Codigo_.FieldName = "Codigo";
            this.Codigo_.Name = "Codigo_";
            this.Codigo_.Visible = true;
            this.Codigo_.VisibleIndex = 0;
            this.Codigo_.Width = 94;
            // 
            // Nome_
            // 
            this.Nome_.Caption = "Grupo de Estoque";
            this.Nome_.FieldName = "Nome";
            this.Nome_.Name = "Nome_";
            this.Nome_.Visible = true;
            this.Nome_.VisibleIndex = 1;
            this.Nome_.Width = 394;
            // 
            // Classificacao_
            // 
            this.Classificacao_.Caption = "Classificação";
            this.Classificacao_.FieldName = "Classificacao";
            this.Classificacao_.Name = "Classificacao_";
            this.Classificacao_.Visible = true;
            this.Classificacao_.VisibleIndex = 2;
            this.Classificacao_.Width = 206;
            // 
            // gcTipoRequisicao
            // 
            this.gcTipoRequisicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTipoRequisicao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTipoRequisicao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTipoRequisicao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTipoRequisicao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTipoRequisicao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTipoRequisicao.Location = new System.Drawing.Point(457, 189);
            this.gcTipoRequisicao.MainView = this.gvTipoRequisicao;
            this.gcTipoRequisicao.Name = "gcTipoRequisicao";
            this.gcTipoRequisicao.Size = new System.Drawing.Size(350, 198);
            this.gcTipoRequisicao.TabIndex = 59;
            this.gcTipoRequisicao.UseEmbeddedNavigator = true;
            this.gcTipoRequisicao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoRequisicao});
            // 
            // gvTipoRequisicao
            // 
            this.gvTipoRequisicao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoRequisicao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoRequisicao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoRequisicao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoRequisicao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoRequisicao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoRequisicao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoRequisicao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoRequisicao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoRequisicao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoRequisicao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoRequisicao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.Preview.Options.UseFont = true;
            this.gvTipoRequisicao.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoRequisicao.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoRequisicao.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoRequisicao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoRequisicao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoRequisicao.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipoRequisicao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoRequisicao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoRequisicao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoRequisicao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoTR,
            this.NomeTR});
            this.gvTipoRequisicao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTipoRequisicao.GridControl = this.gcTipoRequisicao;
            this.gvTipoRequisicao.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTipoRequisicao.Name = "gvTipoRequisicao";
            this.gvTipoRequisicao.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvTipoRequisicao.OptionsBehavior.Editable = false;
            this.gvTipoRequisicao.OptionsSelection.MultiSelect = true;
            this.gvTipoRequisicao.OptionsView.ColumnAutoWidth = false;
            this.gvTipoRequisicao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoRequisicao.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoRequisicao.OptionsView.ShowAutoFilterRow = true;
            this.gvTipoRequisicao.OptionsView.ShowFooter = true;
            this.gvTipoRequisicao.OptionsView.ShowGroupPanel = false;
            // 
            // CodigoTR
            // 
            this.CodigoTR.Caption = "Código";
            this.CodigoTR.FieldName = "Codigo";
            this.CodigoTR.Name = "CodigoTR";
            this.CodigoTR.Visible = true;
            this.CodigoTR.VisibleIndex = 0;
            // 
            // NomeTR
            // 
            this.NomeTR.Caption = "Tipo Requisição";
            this.NomeTR.FieldName = "Nome";
            this.NomeTR.Name = "NomeTR";
            this.NomeTR.Visible = true;
            this.NomeTR.VisibleIndex = 1;
            this.NomeTR.Width = 258;
            // 
            // gcTipoOrcamento
            // 
            this.gcTipoOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTipoOrcamento.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTipoOrcamento.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTipoOrcamento.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTipoOrcamento.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTipoOrcamento.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTipoOrcamento.Location = new System.Drawing.Point(95, 189);
            this.gcTipoOrcamento.MainView = this.gvTipoOrcamento;
            this.gcTipoOrcamento.Name = "gcTipoOrcamento";
            this.gcTipoOrcamento.Size = new System.Drawing.Size(350, 198);
            this.gcTipoOrcamento.TabIndex = 60;
            this.gcTipoOrcamento.UseEmbeddedNavigator = true;
            this.gcTipoOrcamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoOrcamento});
            // 
            // gvTipoOrcamento
            // 
            this.gvTipoOrcamento.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoOrcamento.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoOrcamento.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoOrcamento.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoOrcamento.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoOrcamento.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoOrcamento.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoOrcamento.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoOrcamento.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoOrcamento.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoOrcamento.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoOrcamento.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.Preview.Options.UseFont = true;
            this.gvTipoOrcamento.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoOrcamento.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoOrcamento.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoOrcamento.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoOrcamento.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoOrcamento.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipoOrcamento.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoOrcamento.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoOrcamento.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoOrcamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoTP,
            this.NomeTP,
            this.TipoString});
            this.gvTipoOrcamento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTipoOrcamento.GridControl = this.gcTipoOrcamento;
            this.gvTipoOrcamento.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTipoOrcamento.Name = "gvTipoOrcamento";
            this.gvTipoOrcamento.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvTipoOrcamento.OptionsBehavior.Editable = false;
            this.gvTipoOrcamento.OptionsSelection.MultiSelect = true;
            this.gvTipoOrcamento.OptionsView.ColumnAutoWidth = false;
            this.gvTipoOrcamento.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoOrcamento.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoOrcamento.OptionsView.ShowAutoFilterRow = true;
            this.gvTipoOrcamento.OptionsView.ShowFooter = true;
            this.gvTipoOrcamento.OptionsView.ShowGroupPanel = false;
            // 
            // CodigoTP
            // 
            this.CodigoTP.Caption = "Código";
            this.CodigoTP.FieldName = "Codigo";
            this.CodigoTP.Name = "CodigoTP";
            this.CodigoTP.Visible = true;
            this.CodigoTP.VisibleIndex = 0;
            // 
            // NomeTP
            // 
            this.NomeTP.Caption = "Tipo Orçamento";
            this.NomeTP.FieldName = "Nome";
            this.NomeTP.Name = "NomeTP";
            this.NomeTP.Visible = true;
            this.NomeTP.VisibleIndex = 1;
            this.NomeTP.Width = 167;
            // 
            // TipoString
            // 
            this.TipoString.Caption = "Tipo";
            this.TipoString.FieldName = "TipoString";
            this.TipoString.Name = "TipoString";
            this.TipoString.Visible = true;
            this.TipoString.VisibleIndex = 2;
            this.TipoString.Width = 93;
            // 
            // NecessidadeDeMateriais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 683);
            this.Name = "NecessidadeDeMateriais";
            this.Text = "Relatório de Necessidade de Materiais";
            this.Shown += new System.EventHandler(this.NecessidadeDeMateriais_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoRequisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoRequisicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoOrcamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblLocalEstoque;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private DevExpress.XtraEditors.LookUpEdit lkpLocalEstoque;
        private DevExpress.XtraEditors.LabelControl lblGrupoEstoque;
        public DevExpress.XtraGrid.GridControl gcEmpresas;
        public DevExpress.XtraGrid.Views.Grid.GridView gvEmpresas;
        protected Componentes.devexpress.cwk_DevLookup cbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbTpRequisicao;
        private DevExpress.XtraEditors.LabelControl lbTpOrcamento;
        private DevExpress.XtraGrid.GridControl gcGrupoEstoque;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGrupoEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo_;
        private DevExpress.XtraGrid.Columns.GridColumn Nome_;
        private DevExpress.XtraGrid.Columns.GridColumn Classificacao_;
        private DevExpress.XtraGrid.GridControl gcTipoRequisicao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoRequisicao;
        private DevExpress.XtraGrid.GridControl gcTipoOrcamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoOrcamento;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoTR;
        private DevExpress.XtraGrid.Columns.GridColumn NomeTR;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoTP;
        private DevExpress.XtraGrid.Columns.GridColumn NomeTP;
        private DevExpress.XtraGrid.Columns.GridColumn TipoString;

    }
}