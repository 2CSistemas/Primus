namespace Aplicacao.Modulos.Telefonia
{
    partial class FormDesativarTelefonesCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesativarTelefonesCliente));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbDesativar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.gcTelefones = new DevExpress.XtraGrid.GridControl();
            this.gvTelefones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtrepositoryProduto = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.chkPedidoItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMotivoDesligamento = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtContatoDesligamento = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtDataDesligamento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTelefones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTelefones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContatoDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 311);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbDesativar
            // 
            this.sbDesativar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbDesativar.Image = ((System.Drawing.Image)(resources.GetObject("sbDesativar.Image")));
            this.sbDesativar.ImageIndex = 1;
            this.sbDesativar.Location = new System.Drawing.Point(464, 311);
            this.sbDesativar.Name = "sbDesativar";
            this.sbDesativar.Size = new System.Drawing.Size(80, 23);
            this.sbDesativar.TabIndex = 1;
            this.sbDesativar.Text = "&Desativar";
            this.sbDesativar.Click += new System.EventHandler(this.sbDesativar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(550, 311);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(613, 293);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.lkbCliente);
            this.xtraTabPage1.Controls.Add(this.lkpCliente);
            this.xtraTabPage1.Controls.Add(this.gcTelefones);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtMotivoDesligamento);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtContatoDesligamento);
            this.xtraTabPage1.Controls.Add(this.txtDataDesligamento);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(607, 287);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Cliente:";
            // 
            // lkbCliente
            // 
            this.lkbCliente.Location = new System.Drawing.Point(574, 6);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.TabIndex = 2;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // lkpCliente
            // 
            this.lkpCliente.ButtonLookup = this.lkbCliente;
            this.lkpCliente.CamposPesquisa = new string[] {
        "Pessoa.Nome",
        "Pessoa.Codigo"};
            this.lkpCliente.CamposRestricoesAND = null;
            this.lkpCliente.CamposRestricoesNOT = null;
            this.lkpCliente.CamposRestricoesOR = null;
            this.lkpCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCliente.ColunaTamanho = new string[] {
        "280",
        "200"};
            this.lkpCliente.ContextoLinq = null;
            this.lkpCliente.CwkFuncaoValidacao = null;
            this.lkpCliente.CwkMascara = null;
            this.lkpCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCliente.Exemplo = null;
            this.lkpCliente.ID = 0;
            this.lkpCliente.Join = " ";
            this.lkpCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpCliente.Location = new System.Drawing.Point(49, 6);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = true;
            this.lkpCliente.Size = new System.Drawing.Size(519, 20);
            this.lkpCliente.Tabela = "Pessoa";
            this.lkpCliente.TabIndex = 1;
            this.lkpCliente.TituloTelaPesquisa = "Pesquisa - Cliente";
            this.lkpCliente.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCliente.Where = null;
            // 
            // gcTelefones
            // 
            this.gcTelefones.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTelefones.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTelefones.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTelefones.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTelefones.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTelefones.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTelefones.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTelefones.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTelefones.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTelefones.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTelefones.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTelefones.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTelefones.Location = new System.Drawing.Point(6, 32);
            this.gcTelefones.MainView = this.gvTelefones;
            this.gcTelefones.Name = "gcTelefones";
            this.gcTelefones.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtrepositoryProduto,
            this.chkPedidoItem});
            this.gcTelefones.Size = new System.Drawing.Size(592, 167);
            this.gcTelefones.TabIndex = 3;
            this.gcTelefones.UseEmbeddedNavigator = true;
            this.gcTelefones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTelefones});
            // 
            // gvTelefones
            // 
            this.gvTelefones.ActiveFilterEnabled = false;
            this.gvTelefones.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTelefones.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTelefones.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTelefones.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTelefones.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.Empty.Options.UseBackColor = true;
            this.gvTelefones.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTelefones.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTelefones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTelefones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTelefones.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTelefones.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTelefones.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTelefones.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTelefones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTelefones.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTelefones.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTelefones.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTelefones.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTelefones.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTelefones.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTelefones.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTelefones.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTelefones.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTelefones.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTelefones.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTelefones.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTelefones.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTelefones.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTelefones.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTelefones.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTelefones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTelefones.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTelefones.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTelefones.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTelefones.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTelefones.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTelefones.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTelefones.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTelefones.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTelefones.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.Preview.Options.UseFont = true;
            this.gvTelefones.Appearance.Preview.Options.UseForeColor = true;
            this.gvTelefones.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTelefones.Appearance.Row.Options.UseBackColor = true;
            this.gvTelefones.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTelefones.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvTelefones.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTelefones.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTelefones.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTelefones.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTelefones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1});
            this.gvTelefones.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTelefones.GridControl = this.gcTelefones;
            this.gvTelefones.Name = "gvTelefones";
            this.gvTelefones.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvTelefones.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTelefones.OptionsCustomization.AllowFilter = false;
            this.gvTelefones.OptionsCustomization.AllowSort = false;
            this.gvTelefones.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvTelefones.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTelefones.OptionsView.EnableAppearanceOddRow = true;
            this.gvTelefones.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Selecionado";
            this.gridColumn4.FieldName = "Selecionado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Número";
            this.gridColumn2.FieldName = "Numero";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 185;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Data Ativação";
            this.gridColumn3.FieldName = "DataAtivacao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Piloto";
            this.gridColumn1.FieldName = "Piloto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 100;
            // 
            // txtrepositoryProduto
            // 
            this.txtrepositoryProduto.Appearance.Options.UseTextOptions = true;
            this.txtrepositoryProduto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtrepositoryProduto.AutoHeight = false;
            this.txtrepositoryProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtrepositoryProduto.Mask.EditMask = "\\d{0,20}";
            this.txtrepositoryProduto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtrepositoryProduto.Mask.ShowPlaceHolders = false;
            this.txtrepositoryProduto.MaxLength = 20;
            this.txtrepositoryProduto.Name = "txtrepositoryProduto";
            // 
            // chkPedidoItem
            // 
            this.chkPedidoItem.AutoHeight = false;
            this.chkPedidoItem.Name = "chkPedidoItem";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 234);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Motivo:";
            // 
            // txtMotivoDesligamento
            // 
            this.txtMotivoDesligamento.CwkFuncaoValidacao = null;
            this.txtMotivoDesligamento.CwkMascara = null;
            this.txtMotivoDesligamento.CwkValidacao = null;
            this.txtMotivoDesligamento.Location = new System.Drawing.Point(55, 231);
            this.txtMotivoDesligamento.Name = "txtMotivoDesligamento";
            this.txtMotivoDesligamento.SelecionarTextoOnEnter = false;
            this.txtMotivoDesligamento.Size = new System.Drawing.Size(543, 20);
            this.txtMotivoDesligamento.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Data:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 260);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Contato:";
            // 
            // txtContatoDesligamento
            // 
            this.txtContatoDesligamento.CwkFuncaoValidacao = null;
            this.txtContatoDesligamento.CwkMascara = null;
            this.txtContatoDesligamento.CwkValidacao = null;
            this.txtContatoDesligamento.Location = new System.Drawing.Point(55, 257);
            this.txtContatoDesligamento.Name = "txtContatoDesligamento";
            this.txtContatoDesligamento.SelecionarTextoOnEnter = false;
            this.txtContatoDesligamento.Size = new System.Drawing.Size(543, 20);
            this.txtContatoDesligamento.TabIndex = 9;
            // 
            // txtDataDesligamento
            // 
            this.txtDataDesligamento.CwkFuncaoValidacao = null;
            this.txtDataDesligamento.CwkValidacao = null;
            this.txtDataDesligamento.EditValue = null;
            this.txtDataDesligamento.Location = new System.Drawing.Point(55, 205);
            this.txtDataDesligamento.Name = "txtDataDesligamento";
            this.txtDataDesligamento.Obrigatorio = true;
            this.txtDataDesligamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataDesligamento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataDesligamento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataDesligamento.Size = new System.Drawing.Size(100, 20);
            this.txtDataDesligamento.TabIndex = 5;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormDesativarTelefonesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 346);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbDesativar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormDesativarTelefonesCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desativar Telefones Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExcluirLoteFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTelefones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTelefones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContatoDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbDesativar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataDesligamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtContatoDesligamento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtMotivoDesligamento;
        public DevExpress.XtraGrid.GridControl gcTelefones;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTelefones;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkPedidoItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtrepositoryProduto;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}