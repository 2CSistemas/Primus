namespace Aplicacao.PCP
{
    partial class FormManutOrdemProducaoPedidoOld
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
            this.gcExecucao = new DevExpress.XtraGrid.GridControl();
            this.gvExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSequenciaExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuncionarioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbIncluirExecucao = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterarExecucao = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluirExecucao = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btAjudar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btExcluirOP = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterarOP = new DevExpress.XtraEditors.SimpleButton();
            this.gvOrdemProducao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdutoOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassificacaoOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOrdemProducao = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrdemProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrdemProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // gcExecucao
            // 
            this.gcExecucao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcExecucao.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcExecucao.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcExecucao.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcExecucao.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcExecucao.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcExecucao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Name = "";
            this.gcExecucao.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcExecucao.Location = new System.Drawing.Point(12, 272);
            this.gcExecucao.LookAndFeel.UseWindowsXPTheme = true;
            this.gcExecucao.MainView = this.gvExecucao;
            this.gcExecucao.Name = "gcExecucao";
            this.gcExecucao.Size = new System.Drawing.Size(624, 204);
            this.gcExecucao.TabIndex = 5;
            this.gcExecucao.UseEmbeddedNavigator = true;
            this.gcExecucao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExecucao});
            this.gcExecucao.DoubleClick += new System.EventHandler(this.gcExecucao_DoubleClick);
            // 
            // gvExecucao
            // 
            this.gvExecucao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvExecucao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvExecucao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.Empty.Options.UseBackColor = true;
            this.gvExecucao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExecucao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExecucao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExecucao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvExecucao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvExecucao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvExecucao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExecucao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExecucao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvExecucao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvExecucao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvExecucao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.Preview.Options.UseFont = true;
            this.gvExecucao.Appearance.Preview.Options.UseForeColor = true;
            this.gvExecucao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.Row.Options.UseBackColor = true;
            this.gvExecucao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvExecucao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvExecucao.BestFitMaxRowCount = 5;
            this.gvExecucao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSequenciaExecucao,
            this.colDescricaoExecucao,
            this.colFuncionarioExecucao,
            this.colIDExecucao});
            this.gvExecucao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvExecucao.GridControl = this.gcExecucao;
            this.gvExecucao.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvExecucao.Name = "gvExecucao";
            this.gvExecucao.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvExecucao.OptionsBehavior.Editable = false;
            this.gvExecucao.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvExecucao.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvExecucao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvExecucao.OptionsView.EnableAppearanceOddRow = true;
            this.gvExecucao.OptionsView.ShowAutoFilterRow = true;
            this.gvExecucao.OptionsView.ShowGroupPanel = false;
            // 
            // colSequenciaExecucao
            // 
            this.colSequenciaExecucao.Caption = "Seq.";
            this.colSequenciaExecucao.FieldName = "Sequencia";
            this.colSequenciaExecucao.Name = "colSequenciaExecucao";
            this.colSequenciaExecucao.Visible = true;
            this.colSequenciaExecucao.VisibleIndex = 0;
            this.colSequenciaExecucao.Width = 40;
            // 
            // colDescricaoExecucao
            // 
            this.colDescricaoExecucao.Caption = "Descrição";
            this.colDescricaoExecucao.FieldName = "Descricao";
            this.colDescricaoExecucao.Name = "colDescricaoExecucao";
            this.colDescricaoExecucao.Visible = true;
            this.colDescricaoExecucao.VisibleIndex = 1;
            this.colDescricaoExecucao.Width = 281;
            // 
            // colFuncionarioExecucao
            // 
            this.colFuncionarioExecucao.Caption = "Funcionário";
            this.colFuncionarioExecucao.FieldName = "Funcionario";
            this.colFuncionarioExecucao.Name = "colFuncionarioExecucao";
            this.colFuncionarioExecucao.Visible = true;
            this.colFuncionarioExecucao.VisibleIndex = 2;
            this.colFuncionarioExecucao.Width = 282;
            // 
            // colIDExecucao
            // 
            this.colIDExecucao.Caption = "ID";
            this.colIDExecucao.FieldName = "ID";
            this.colIDExecucao.Name = "colIDExecucao";
            // 
            // sbIncluirExecucao
            // 
            this.sbIncluirExecucao.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluirExecucao.ImageIndex = 4;
            this.sbIncluirExecucao.Location = new System.Drawing.Point(405, 483);
            this.sbIncluirExecucao.Name = "sbIncluirExecucao";
            this.sbIncluirExecucao.Size = new System.Drawing.Size(75, 22);
            this.sbIncluirExecucao.TabIndex = 6;
            this.sbIncluirExecucao.Text = "&Incluir";
            this.sbIncluirExecucao.Click += new System.EventHandler(this.sbIncluirExecucao_Click);
            // 
            // sbAlterarExecucao
            // 
            this.sbAlterarExecucao.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.sbAlterarExecucao.ImageIndex = 5;
            this.sbAlterarExecucao.Location = new System.Drawing.Point(483, 483);
            this.sbAlterarExecucao.Name = "sbAlterarExecucao";
            this.sbAlterarExecucao.Size = new System.Drawing.Size(75, 22);
            this.sbAlterarExecucao.TabIndex = 7;
            this.sbAlterarExecucao.Text = "&Alterar";
            this.sbAlterarExecucao.Click += new System.EventHandler(this.sbAlterarExecucao_Click);
            // 
            // sbExcluirExecucao
            // 
            this.sbExcluirExecucao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluirExecucao.ImageIndex = 6;
            this.sbExcluirExecucao.Location = new System.Drawing.Point(561, 483);
            this.sbExcluirExecucao.Name = "sbExcluirExecucao";
            this.sbExcluirExecucao.Size = new System.Drawing.Size(75, 22);
            this.sbExcluirExecucao.TabIndex = 8;
            this.sbExcluirExecucao.Text = "&Excluir";
            this.sbExcluirExecucao.Click += new System.EventHandler(this.sbExcluirExecucao_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 248);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 18);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Execução";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.btFechar.ImageIndex = 2;
            this.btFechar.Location = new System.Drawing.Point(561, 511);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 9;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btAjudar
            // 
            this.btAjudar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjudar.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.btAjudar.ImageIndex = 0;
            this.btAjudar.Location = new System.Drawing.Point(12, 511);
            this.btAjudar.Name = "btAjudar";
            this.btAjudar.Size = new System.Drawing.Size(75, 23);
            this.btAjudar.TabIndex = 10;
            this.btAjudar.Text = "&Ajuda";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(12, 12);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(124, 18);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Ordem Produção";
            // 
            // btExcluirOP
            // 
            this.btExcluirOP.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirOP.ImageIndex = 6;
            this.btExcluirOP.Location = new System.Drawing.Point(561, 244);
            this.btExcluirOP.Name = "btExcluirOP";
            this.btExcluirOP.Size = new System.Drawing.Size(75, 22);
            this.btExcluirOP.TabIndex = 3;
            this.btExcluirOP.Text = "&Excluir";
            this.btExcluirOP.Click += new System.EventHandler(this.btExcluirOP_Click);
            // 
            // btAlterarOP
            // 
            this.btAlterarOP.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarOP.ImageIndex = 5;
            this.btAlterarOP.Location = new System.Drawing.Point(483, 244);
            this.btAlterarOP.Name = "btAlterarOP";
            this.btAlterarOP.Size = new System.Drawing.Size(75, 22);
            this.btAlterarOP.TabIndex = 2;
            this.btAlterarOP.Text = "&Alterar";
            this.btAlterarOP.Click += new System.EventHandler(this.btAlterarOP_Click);
            // 
            // gvOrdemProducao
            // 
            this.gvOrdemProducao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.Empty.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOrdemProducao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOrdemProducao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOrdemProducao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrdemProducao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrdemProducao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrdemProducao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOrdemProducao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOrdemProducao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOrdemProducao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrdemProducao.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvOrdemProducao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.Preview.Options.UseFont = true;
            this.gvOrdemProducao.Appearance.Preview.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrdemProducao.Appearance.Row.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvOrdemProducao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrdemProducao.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrdemProducao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvOrdemProducao.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvOrdemProducao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvOrdemProducao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvOrdemProducao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvOrdemProducao.BestFitMaxRowCount = 5;
            this.gvOrdemProducao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoOP,
            this.colProdutoOP,
            this.colClassificacaoOP});
            this.gvOrdemProducao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvOrdemProducao.GridControl = this.gcOrdemProducao;
            this.gvOrdemProducao.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvOrdemProducao.Name = "gvOrdemProducao";
            this.gvOrdemProducao.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvOrdemProducao.OptionsBehavior.Editable = false;
            this.gvOrdemProducao.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvOrdemProducao.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvOrdemProducao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOrdemProducao.OptionsView.EnableAppearanceOddRow = true;
            this.gvOrdemProducao.OptionsView.ShowAutoFilterRow = true;
            this.gvOrdemProducao.OptionsView.ShowGroupPanel = false;
            this.gvOrdemProducao.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOrdemProducao_FocusedRowChanged);
            // 
            // colCodigoOP
            // 
            this.colCodigoOP.Caption = "Código";
            this.colCodigoOP.FieldName = "Codigo";
            this.colCodigoOP.Name = "colCodigoOP";
            this.colCodigoOP.Visible = true;
            this.colCodigoOP.VisibleIndex = 0;
            this.colCodigoOP.Width = 73;
            // 
            // colProdutoOP
            // 
            this.colProdutoOP.Caption = "Produto";
            this.colProdutoOP.FieldName = "Produto";
            this.colProdutoOP.Name = "colProdutoOP";
            this.colProdutoOP.Visible = true;
            this.colProdutoOP.VisibleIndex = 1;
            this.colProdutoOP.Width = 215;
            // 
            // colClassificacaoOP
            // 
            this.colClassificacaoOP.Caption = "Classificação";
            this.colClassificacaoOP.FieldName = "Classificacao";
            this.colClassificacaoOP.Name = "colClassificacaoOP";
            this.colClassificacaoOP.Visible = true;
            this.colClassificacaoOP.VisibleIndex = 2;
            this.colClassificacaoOP.Width = 206;
            // 
            // gcOrdemProducao
            // 
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcOrdemProducao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcOrdemProducao.EmbeddedNavigator.Name = "";
            this.gcOrdemProducao.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcOrdemProducao.Location = new System.Drawing.Point(12, 34);
            this.gcOrdemProducao.LookAndFeel.UseWindowsXPTheme = true;
            this.gcOrdemProducao.MainView = this.gvOrdemProducao;
            this.gcOrdemProducao.Name = "gcOrdemProducao";
            this.gcOrdemProducao.Size = new System.Drawing.Size(624, 204);
            this.gcOrdemProducao.TabIndex = 1;
            this.gcOrdemProducao.UseEmbeddedNavigator = true;
            this.gcOrdemProducao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrdemProducao});
            this.gcOrdemProducao.DoubleClick += new System.EventHandler(this.gcOrdemProducao_DoubleClick);
            // 
            // FormManutOrdemProducaoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 546);
            this.Controls.Add(this.btAjudar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.sbIncluirExecucao);
            this.Controls.Add(this.sbAlterarExecucao);
            this.Controls.Add(this.sbExcluirExecucao);
            this.Controls.Add(this.btAlterarOP);
            this.Controls.Add(this.btExcluirOP);
            this.Controls.Add(this.gcExecucao);
            this.Controls.Add(this.gcOrdemProducao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormManutOrdemProducaoPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem Produção";
            this.Load += new System.EventHandler(this.FormManutOrdemProducaoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrdemProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrdemProducao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcExecucao;
        public DevExpress.XtraGrid.Views.Grid.GridView gvExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colSequenciaExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colFuncionarioExecucao;
        private DevExpress.XtraEditors.SimpleButton sbIncluirExecucao;
        private DevExpress.XtraEditors.SimpleButton sbAlterarExecucao;
        private DevExpress.XtraEditors.SimpleButton sbExcluirExecucao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        private DevExpress.XtraEditors.SimpleButton btAjudar;
        private DevExpress.XtraGrid.Columns.GridColumn colIDExecucao;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btExcluirOP;
        private DevExpress.XtraEditors.SimpleButton btAlterarOP;
        public DevExpress.XtraGrid.Views.Grid.GridView gvOrdemProducao;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoOP;
        private DevExpress.XtraGrid.Columns.GridColumn colProdutoOP;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificacaoOP;
        public DevExpress.XtraGrid.GridControl gcOrdemProducao;
    }
}