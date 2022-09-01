namespace Aplicacao.Relatorios
{
    partial class NotasPorServico
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
            this.gcTipoMovimentacao = new DevExpress.XtraGrid.GridControl();
            this.gvTipoMovimentacao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcServico = new DevExpress.XtraGrid.GridControl();
            this.gvServico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(712, 496);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Controls.Add(this.gcServico);
            this.tabPage1.Controls.Add(this.gcTipoMovimentacao);
            this.tabPage1.Size = new System.Drawing.Size(706, 490);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcTipoMovimentacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcServico, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl4, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl5, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 514);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 514);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 518);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 514);
            // 
            // gcTipoMovimentacao
            // 
            this.gcTipoMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTipoMovimentacao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTipoMovimentacao.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTipoMovimentacao.Location = new System.Drawing.Point(52, 320);
            this.gcTipoMovimentacao.MainView = this.gvTipoMovimentacao;
            this.gcTipoMovimentacao.Name = "gcTipoMovimentacao";
            this.gcTipoMovimentacao.Size = new System.Drawing.Size(635, 133);
            this.gcTipoMovimentacao.TabIndex = 24;
            this.gcTipoMovimentacao.UseEmbeddedNavigator = true;
            this.gcTipoMovimentacao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoMovimentacao});
            // 
            // gvTipoMovimentacao
            // 
            this.gvTipoMovimentacao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoMovimentacao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoMovimentacao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoMovimentacao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimentacao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimentacao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimentacao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoMovimentacao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoMovimentacao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoMovimentacao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimentacao.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoMovimentacao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.Preview.Options.UseFont = true;
            this.gvTipoMovimentacao.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimentacao.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimentacao.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimentacao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimentacao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipoMovimentacao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoMovimentacao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoMovimentacao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoMovimentacao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvTipoMovimentacao.GridControl = this.gcTipoMovimentacao;
            this.gvTipoMovimentacao.Name = "gvTipoMovimentacao";
            this.gvTipoMovimentacao.OptionsBehavior.Editable = false;
            this.gvTipoMovimentacao.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTipoMovimentacao.OptionsSelection.MultiSelect = true;
            this.gvTipoMovimentacao.OptionsSelection.UseIndicatorForSelection = false;
            this.gvTipoMovimentacao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoMovimentacao.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoMovimentacao.OptionsView.ShowAutoFilterRow = true;
            this.gvTipoMovimentacao.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nome";
            this.gridColumn1.FieldName = "Nome";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "ID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gcServico
            // 
            this.gcServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcServico.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcServico.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcServico.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcServico.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcServico.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcServico.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcServico.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcServico.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcServico.Location = new System.Drawing.Point(52, 181);
            this.gcServico.MainView = this.gvServico;
            this.gcServico.Name = "gcServico";
            this.gcServico.Size = new System.Drawing.Size(635, 133);
            this.gcServico.TabIndex = 25;
            this.gcServico.UseEmbeddedNavigator = true;
            this.gcServico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServico});
            // 
            // gvServico
            // 
            this.gvServico.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvServico.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvServico.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvServico.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvServico.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvServico.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvServico.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvServico.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvServico.Appearance.Empty.Options.UseBackColor = true;
            this.gvServico.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvServico.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvServico.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvServico.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvServico.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServico.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServico.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvServico.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvServico.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvServico.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvServico.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServico.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServico.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvServico.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvServico.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvServico.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvServico.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvServico.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvServico.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvServico.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvServico.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvServico.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvServico.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvServico.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServico.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServico.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvServico.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServico.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServico.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvServico.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvServico.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvServico.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.OddRow.Options.UseBackColor = true;
            this.gvServico.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.OddRow.Options.UseForeColor = true;
            this.gvServico.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvServico.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.Preview.Options.UseFont = true;
            this.gvServico.Appearance.Preview.Options.UseForeColor = true;
            this.gvServico.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.Row.Options.UseBackColor = true;
            this.gvServico.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvServico.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvServico.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvServico.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvServico.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvServico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gvServico.GridControl = this.gcServico;
            this.gvServico.Name = "gvServico";
            this.gvServico.OptionsBehavior.Editable = false;
            this.gvServico.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvServico.OptionsSelection.MultiSelect = true;
            this.gvServico.OptionsSelection.UseIndicatorForSelection = false;
            this.gvServico.OptionsView.EnableAppearanceEvenRow = true;
            this.gvServico.OptionsView.EnableAppearanceOddRow = true;
            this.gvServico.OptionsView.ShowAutoFilterRow = true;
            this.gvServico.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nome";
            this.gridColumn3.FieldName = "Nome";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(597, 462);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(467, 462);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Período:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(607, 459);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 29;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(513, 459);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 320);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Tp. Mov.";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Serviço:";
            // 
            // NotasPorServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 543);
            this.Name = "NotasPorServico";
            this.Text = "Notas Por Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcServico;
        public DevExpress.XtraGrid.Views.Grid.GridView gvServico;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        public DevExpress.XtraGrid.GridControl gcTipoMovimentacao;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTipoMovimentacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;

    }
}