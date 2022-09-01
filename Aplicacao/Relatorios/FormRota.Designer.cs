namespace Aplicacao.Relatorios
{
    partial class FormRota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRota));
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lbResponsavel = new DevExpress.XtraEditors.LabelControl();
            this.lbCliente = new DevExpress.XtraEditors.LabelControl();
            this.gcClientes = new DevExpress.XtraGrid.GridControl();
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.gvEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTipoData = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbData = new DevExpress.XtraEditors.LabelControl();
            this.txtCBStatus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.gcResponsavel = new DevExpress.XtraGrid.GridControl();
            this.gvResponsavel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcOperador = new DevExpress.XtraGrid.GridControl();
            this.gvOperador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbOperador = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCBStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOperador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(1022, 463);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gcOperador);
            this.tabPage1.Controls.Add(this.lbOperador);
            this.tabPage1.Controls.Add(this.gcResponsavel);
            this.tabPage1.Controls.Add(this.lbStatus);
            this.tabPage1.Controls.Add(this.txtCBStatus);
            this.tabPage1.Controls.Add(this.lbData);
            this.tabPage1.Controls.Add(this.txtTipoData);
            this.tabPage1.Controls.Add(this.gcEmpresas);
            this.tabPage1.Controls.Add(this.gcClientes);
            this.tabPage1.Controls.Add(this.lbCliente);
            this.tabPage1.Controls.Add(this.lbResponsavel);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.lbPeriodo);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.txtDataInicial);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Size = new System.Drawing.Size(1016, 457);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(880, 481);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(959, 481);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 485);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 481);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(50, 31);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Properties.ValueMember = "ID";
            this.cbGrupo.Size = new System.Drawing.Size(484, 20);
            this.cbGrupo.TabIndex = 9;
            this.cbGrupo.EditValueChanged += new System.EventHandler(this.cbGrupo_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(336, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "à";
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.Location = new System.Drawing.Point(163, 10);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lbPeriodo.TabIndex = 2;
            this.lbPeriodo.Text = "Período:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(348, 7);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(125, 20);
            this.txtDataFinal.TabIndex = 5;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(209, 7);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(121, 20);
            this.txtDataInicial.TabIndex = 3;
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponsavel.Location = new System.Drawing.Point(50, 249);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(102, 19);
            this.lbResponsavel.TabIndex = 13;
            this.lbResponsavel.Text = "Responsável";
            // 
            // lbCliente
            // 
            this.lbCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(540, 29);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(58, 19);
            this.lbCliente.TabIndex = 10;
            this.lbCliente.Text = "Cliente";
            // 
            // gcClientes
            // 
            this.gcClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcClientes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcClientes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcClientes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcClientes.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcClientes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcClientes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcClientes.Location = new System.Drawing.Point(540, 54);
            this.gcClientes.MainView = this.gvClientes;
            this.gcClientes.Name = "gcClientes";
            this.gcClientes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcClientes.Size = new System.Drawing.Size(467, 189);
            this.gcClientes.TabIndex = 12;
            this.gcClientes.UseEmbeddedNavigator = true;
            this.gcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes,
            this.gridView3});
            // 
            // gvClientes
            // 
            this.gvClientes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvClientes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvClientes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvClientes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvClientes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvClientes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvClientes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.Empty.Options.UseBackColor = true;
            this.gvClientes.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvClientes.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvClientes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvClientes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvClientes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvClientes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvClientes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvClientes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvClientes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvClientes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvClientes.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvClientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvClientes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvClientes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvClientes.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvClientes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvClientes.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvClientes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvClientes.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvClientes.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvClientes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvClientes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvClientes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvClientes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvClientes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvClientes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.OddRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvClientes.Appearance.OddRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvClientes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.Preview.Options.UseFont = true;
            this.gvClientes.Appearance.Preview.Options.UseForeColor = true;
            this.gvClientes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvClientes.Appearance.Row.Options.UseBackColor = true;
            this.gvClientes.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvClientes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvClientes.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvClientes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvClientes.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvClientes.BestFitMaxRowCount = 5;
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoCliente,
            this.NomeCliente});
            this.gvClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvClientes.GridControl = this.gcClientes;
            this.gvClientes.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvClientes.OptionsSelection.MultiSelect = true;
            this.gvClientes.OptionsView.ColumnAutoWidth = false;
            this.gvClientes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientes.OptionsView.EnableAppearanceOddRow = true;
            this.gvClientes.OptionsView.ShowAutoFilterRow = true;
            this.gvClientes.OptionsView.ShowGroupPanel = false;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.Caption = "Código";
            this.CodigoCliente.FieldName = "Codigo";
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.OptionsColumn.AllowEdit = false;
            this.CodigoCliente.OptionsColumn.ReadOnly = true;
            this.CodigoCliente.Visible = true;
            this.CodigoCliente.VisibleIndex = 0;
            this.CodigoCliente.Width = 71;
            // 
            // NomeCliente
            // 
            this.NomeCliente.Caption = "Nome";
            this.NomeCliente.FieldName = "Nome";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.OptionsColumn.AllowEdit = false;
            this.NomeCliente.OptionsColumn.ReadOnly = true;
            this.NomeCliente.Visible = true;
            this.NomeCliente.VisibleIndex = 1;
            this.NomeCliente.Width = 493;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView3
            // 
            this.gridView3.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView3.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView3.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.Empty.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView3.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView3.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView3.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView3.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView3.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView3.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView3.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView3.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView3.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView3.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView3.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.Preview.Options.UseFont = true;
            this.gridView3.Appearance.Preview.Options.UseForeColor = true;
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView3.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView3.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView3.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView3.BestFitMaxRowCount = 5;
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.GridControl = this.gcClientes;
            this.gridView3.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsDetail.EnableMasterViewMode = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFooter = true;
            // 
            // gcEmpresas
            // 
            this.gcEmpresas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcEmpresas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcEmpresas.Location = new System.Drawing.Point(50, 54);
            this.gcEmpresas.MainView = this.gvEmpresas;
            this.gcEmpresas.Name = "gcEmpresas";
            this.gcEmpresas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit3});
            this.gcEmpresas.Size = new System.Drawing.Size(484, 189);
            this.gcEmpresas.TabIndex = 11;
            this.gcEmpresas.UseEmbeddedNavigator = true;
            this.gcEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpresas,
            this.gridView4});
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
            this.gvEmpresas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoEmpresa,
            this.NomeEmpresa,
            this.CNPJEmpresa,
            this.ID});
            this.gvEmpresas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvEmpresas.GridControl = this.gcEmpresas;
            this.gvEmpresas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvEmpresas.Name = "gvEmpresas";
            this.gvEmpresas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvEmpresas.OptionsSelection.MultiSelect = true;
            this.gvEmpresas.OptionsView.ColumnAutoWidth = false;
            this.gvEmpresas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmpresas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEmpresas.OptionsView.ShowAutoFilterRow = true;
            this.gvEmpresas.OptionsView.ShowGroupPanel = false;
            // 
            // CodigoEmpresa
            // 
            this.CodigoEmpresa.Caption = "Código";
            this.CodigoEmpresa.FieldName = "Codigo";
            this.CodigoEmpresa.Name = "CodigoEmpresa";
            this.CodigoEmpresa.OptionsColumn.AllowEdit = false;
            this.CodigoEmpresa.OptionsColumn.ReadOnly = true;
            this.CodigoEmpresa.Visible = true;
            this.CodigoEmpresa.VisibleIndex = 0;
            this.CodigoEmpresa.Width = 71;
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.Caption = "Nome";
            this.NomeEmpresa.FieldName = "Nome";
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.OptionsColumn.AllowEdit = false;
            this.NomeEmpresa.OptionsColumn.ReadOnly = true;
            this.NomeEmpresa.Visible = true;
            this.NomeEmpresa.VisibleIndex = 1;
            this.NomeEmpresa.Width = 692;
            // 
            // CNPJEmpresa
            // 
            this.CNPJEmpresa.Caption = "CNPJ";
            this.CNPJEmpresa.FieldName = "CNPJ";
            this.CNPJEmpresa.Name = "CNPJEmpresa";
            this.CNPJEmpresa.Visible = true;
            this.CNPJEmpresa.VisibleIndex = 2;
            this.CNPJEmpresa.Width = 175;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // gridView4
            // 
            this.gridView4.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView4.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView4.Appearance.Empty.Options.UseBackColor = true;
            this.gridView4.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView4.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView4.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView4.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView4.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView4.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView4.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView4.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView4.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView4.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView4.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView4.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView4.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView4.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView4.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView4.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView4.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.Preview.Options.UseFont = true;
            this.gridView4.Appearance.Preview.Options.UseForeColor = true;
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView4.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView4.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView4.BestFitMaxRowCount = 5;
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.GridControl = this.gcEmpresas;
            this.gridView4.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsDetail.EnableMasterViewMode = false;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView4.OptionsView.EnableAppearanceOddRow = true;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowFooter = true;
            // 
            // txtTipoData
            // 
            this.txtTipoData.EditValue = "Programada";
            this.txtTipoData.Location = new System.Drawing.Point(50, 7);
            this.txtTipoData.Name = "txtTipoData";
            this.txtTipoData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTipoData.Properties.Items.AddRange(new object[] {
            "Programada",
            "Relizada"});
            this.txtTipoData.Size = new System.Drawing.Size(100, 20);
            this.txtTipoData.TabIndex = 1;
            // 
            // lbData
            // 
            this.lbData.Location = new System.Drawing.Point(20, 10);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(27, 13);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data:";
            // 
            // txtCBStatus
            // 
            this.txtCBStatus.EditValue = "3";
            this.txtCBStatus.Location = new System.Drawing.Point(540, 7);
            this.txtCBStatus.Name = "txtCBStatus";
            this.txtCBStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCBStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pendente", "0", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Efetuado", "1", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cancelado", "2", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Todos", "3", 3)});
            this.txtCBStatus.Properties.LargeImages = this.imageList1;
            this.txtCBStatus.Size = new System.Drawing.Size(100, 20);
            this.txtCBStatus.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Azul Pendente 16x16.png");
            this.imageList1.Images.SetKeyName(1, "Vermelho Cancelar 16x16.png");
            this.imageList1.Images.SetKeyName(2, "Verde Efetuado 16x16.png");
            this.imageList1.Images.SetKeyName(3, "Cinza Todos 16x16.png");
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(499, 10);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status:";
            // 
            // gcResponsavel
            // 
            this.gcResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcResponsavel.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcResponsavel.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcResponsavel.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcResponsavel.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcResponsavel.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcResponsavel.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcResponsavel.Location = new System.Drawing.Point(50, 274);
            this.gcResponsavel.MainView = this.gvResponsavel;
            this.gcResponsavel.Name = "gcResponsavel";
            this.gcResponsavel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcResponsavel.Size = new System.Drawing.Size(484, 180);
            this.gcResponsavel.TabIndex = 15;
            this.gcResponsavel.UseEmbeddedNavigator = true;
            this.gcResponsavel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResponsavel,
            this.gridView2});
            // 
            // gvResponsavel
            // 
            this.gvResponsavel.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.Empty.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvResponsavel.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvResponsavel.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvResponsavel.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvResponsavel.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvResponsavel.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvResponsavel.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvResponsavel.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvResponsavel.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvResponsavel.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvResponsavel.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.OddRow.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.OddRow.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvResponsavel.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.Preview.Options.UseFont = true;
            this.gvResponsavel.Appearance.Preview.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvResponsavel.Appearance.Row.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvResponsavel.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvResponsavel.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvResponsavel.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvResponsavel.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvResponsavel.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvResponsavel.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvResponsavel.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvResponsavel.BestFitMaxRowCount = 5;
            this.gvResponsavel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvResponsavel.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvResponsavel.GridControl = this.gcResponsavel;
            this.gvResponsavel.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvResponsavel.Name = "gvResponsavel";
            this.gvResponsavel.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvResponsavel.OptionsSelection.MultiSelect = true;
            this.gvResponsavel.OptionsView.ColumnAutoWidth = false;
            this.gvResponsavel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvResponsavel.OptionsView.EnableAppearanceOddRow = true;
            this.gvResponsavel.OptionsView.ShowAutoFilterRow = true;
            this.gvResponsavel.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 71;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome";
            this.gridColumn2.FieldName = "Nome";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 493;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView2.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.Preview.Options.UseFont = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView2.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView2.BestFitMaxRowCount = 5;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gcResponsavel;
            this.gridView2.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // gcOperador
            // 
            this.gcOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOperador.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcOperador.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcOperador.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcOperador.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcOperador.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcOperador.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcOperador.Location = new System.Drawing.Point(540, 274);
            this.gcOperador.MainView = this.gvOperador;
            this.gcOperador.Name = "gcOperador";
            this.gcOperador.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit4});
            this.gcOperador.Size = new System.Drawing.Size(467, 180);
            this.gcOperador.TabIndex = 16;
            this.gcOperador.UseEmbeddedNavigator = true;
            this.gcOperador.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOperador,
            this.gridView6});
            // 
            // gvOperador
            // 
            this.gvOperador.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvOperador.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvOperador.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvOperador.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvOperador.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvOperador.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvOperador.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvOperador.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvOperador.Appearance.Empty.Options.UseBackColor = true;
            this.gvOperador.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvOperador.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvOperador.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvOperador.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvOperador.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvOperador.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOperador.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOperador.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvOperador.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvOperador.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvOperador.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvOperador.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOperador.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOperador.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvOperador.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvOperador.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvOperador.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperador.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvOperador.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvOperador.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperador.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperador.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvOperador.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvOperador.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvOperador.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvOperador.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvOperador.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvOperador.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvOperador.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvOperador.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvOperador.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvOperador.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvOperador.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOperador.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOperador.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvOperador.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvOperador.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvOperador.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOperador.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOperador.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvOperador.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvOperador.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvOperador.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperador.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvOperador.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvOperador.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvOperador.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.OddRow.Options.UseBackColor = true;
            this.gvOperador.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvOperador.Appearance.OddRow.Options.UseForeColor = true;
            this.gvOperador.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvOperador.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.Preview.Options.UseFont = true;
            this.gvOperador.Appearance.Preview.Options.UseForeColor = true;
            this.gvOperador.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperador.Appearance.Row.Options.UseBackColor = true;
            this.gvOperador.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvOperador.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperador.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperador.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperador.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvOperador.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvOperador.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvOperador.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvOperador.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvOperador.BestFitMaxRowCount = 5;
            this.gvOperador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gvOperador.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvOperador.GridControl = this.gcOperador;
            this.gvOperador.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvOperador.Name = "gvOperador";
            this.gvOperador.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvOperador.OptionsSelection.MultiSelect = true;
            this.gvOperador.OptionsView.ColumnAutoWidth = false;
            this.gvOperador.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOperador.OptionsView.EnableAppearanceOddRow = true;
            this.gvOperador.OptionsView.ShowAutoFilterRow = true;
            this.gvOperador.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "Codigo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 71;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nome";
            this.gridColumn4.FieldName = "Nome";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 493;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // gridView6
            // 
            this.gridView6.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView6.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView6.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView6.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView6.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView6.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView6.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView6.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView6.Appearance.Empty.Options.UseBackColor = true;
            this.gridView6.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView6.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView6.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView6.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView6.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView6.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView6.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView6.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView6.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView6.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView6.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView6.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView6.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView6.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView6.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView6.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView6.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView6.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView6.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView6.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView6.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView6.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView6.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView6.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView6.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView6.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView6.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView6.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView6.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView6.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView6.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView6.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView6.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView6.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView6.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView6.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView6.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView6.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView6.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView6.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView6.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView6.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView6.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView6.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView6.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView6.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.Preview.Options.UseFont = true;
            this.gridView6.Appearance.Preview.Options.UseForeColor = true;
            this.gridView6.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView6.Appearance.Row.Options.UseBackColor = true;
            this.gridView6.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView6.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView6.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView6.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView6.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView6.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView6.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView6.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView6.BestFitMaxRowCount = 5;
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.GridControl = this.gcOperador;
            this.gridView6.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView6.OptionsBehavior.Editable = false;
            this.gridView6.OptionsDetail.EnableMasterViewMode = false;
            this.gridView6.OptionsView.ColumnAutoWidth = false;
            this.gridView6.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView6.OptionsView.EnableAppearanceOddRow = true;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowFooter = true;
            // 
            // lbOperador
            // 
            this.lbOperador.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperador.Location = new System.Drawing.Point(540, 249);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(76, 19);
            this.lbOperador.TabIndex = 14;
            this.lbOperador.Text = "Operador";
            // 
            // FormRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1046, 510);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRota";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCBStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOperador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevLookupEdit cbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lbPeriodo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        private DevExpress.XtraEditors.LabelControl lbResponsavel;
        private DevExpress.XtraEditors.LabelControl lbCliente;
        private DevExpress.XtraGrid.GridControl gcClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn NomeCliente;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gcEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn NomeEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn CNPJEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.LabelControl lbData;
        private DevExpress.XtraEditors.ComboBoxEdit txtTipoData;
        private DevExpress.XtraEditors.ImageComboBoxEdit txtCBStatus;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraGrid.GridControl gcResponsavel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResponsavel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gcOperador;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOperador;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.LabelControl lbOperador;
    }
}
