namespace Aplicacao.Relatorios
{
    partial class FormRptImpostoNFSe
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.gcTipoMovimentacao = new DevExpress.XtraGrid.GridControl();
            this.gvTipoMovimentacao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chbImpostosRetidos = new DevExpress.XtraEditors.CheckEdit();
            this.gcStatus = new DevExpress.XtraGrid.GridControl();
            this.gvStatus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbImpostosRetidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(730, 504);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gcStatus);
            this.tabPage1.Controls.Add(this.chbImpostosRetidos);
            this.tabPage1.Controls.Add(this.gcTipoMovimentacao);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Size = new System.Drawing.Size(724, 498);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcTipoMovimentacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbImpostosRetidos, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcStatus, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(588, 522);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(667, 522);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 526);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 522);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(601, 459);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(451, 461);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Período:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(625, 458);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 22;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(497, 458);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 20;
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
            this.gcTipoMovimentacao.Size = new System.Drawing.Size(653, 133);
            this.gcTipoMovimentacao.TabIndex = 23;
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
            // chbImpostosRetidos
            // 
            this.chbImpostosRetidos.Location = new System.Drawing.Point(50, 459);
            this.chbImpostosRetidos.Name = "chbImpostosRetidos";
            this.chbImpostosRetidos.Properties.Caption = "Somente Impostos com retenção";
            this.chbImpostosRetidos.Size = new System.Drawing.Size(189, 19);
            this.chbImpostosRetidos.TabIndex = 24;
            // 
            // gcStatus
            // 
            this.gcStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStatus.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcStatus.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcStatus.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcStatus.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcStatus.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcStatus.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcStatus.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcStatus.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcStatus.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcStatus.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcStatus.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcStatus.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcStatus.Location = new System.Drawing.Point(52, 181);
            this.gcStatus.MainView = this.gvStatus;
            this.gcStatus.Name = "gcStatus";
            this.gcStatus.Size = new System.Drawing.Size(653, 133);
            this.gcStatus.TabIndex = 25;
            this.gcStatus.UseEmbeddedNavigator = true;
            this.gcStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStatus});
            // 
            // gvStatus
            // 
            this.gvStatus.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvStatus.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvStatus.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvStatus.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvStatus.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvStatus.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvStatus.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvStatus.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvStatus.Appearance.Empty.Options.UseBackColor = true;
            this.gvStatus.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvStatus.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvStatus.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvStatus.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvStatus.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvStatus.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvStatus.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvStatus.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvStatus.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvStatus.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvStatus.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvStatus.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvStatus.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvStatus.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvStatus.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvStatus.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvStatus.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvStatus.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvStatus.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvStatus.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvStatus.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvStatus.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvStatus.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvStatus.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvStatus.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvStatus.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvStatus.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvStatus.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvStatus.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvStatus.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvStatus.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvStatus.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvStatus.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvStatus.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvStatus.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvStatus.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvStatus.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvStatus.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvStatus.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvStatus.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvStatus.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvStatus.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvStatus.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvStatus.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvStatus.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvStatus.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvStatus.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.OddRow.Options.UseBackColor = true;
            this.gvStatus.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvStatus.Appearance.OddRow.Options.UseForeColor = true;
            this.gvStatus.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvStatus.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.Preview.Options.UseFont = true;
            this.gvStatus.Appearance.Preview.Options.UseForeColor = true;
            this.gvStatus.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvStatus.Appearance.Row.Options.UseBackColor = true;
            this.gvStatus.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvStatus.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvStatus.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvStatus.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvStatus.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvStatus.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvStatus.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvStatus.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvStatus.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvStatus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigo,
            this.status});
            this.gvStatus.GridControl = this.gcStatus;
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.OptionsBehavior.Editable = false;
            this.gvStatus.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvStatus.OptionsSelection.MultiSelect = true;
            this.gvStatus.OptionsSelection.UseIndicatorForSelection = false;
            this.gvStatus.OptionsView.EnableAppearanceEvenRow = true;
            this.gvStatus.OptionsView.EnableAppearanceOddRow = true;
            this.gvStatus.OptionsView.ShowGroupPanel = false;
            // 
            // codigo
            // 
            this.codigo.Caption = "codigo";
            this.codigo.FieldName = "codigo";
            this.codigo.Name = "codigo";
            // 
            // status
            // 
            this.status.Caption = "Status";
            this.status.FieldName = "status";
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 0;
            // 
            // FormRptImpostoNFSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 551);
            this.Name = "FormRptImpostoNFSe";
            this.Text = "Relatório de Impostos NFSe";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbImpostosRetidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        public DevExpress.XtraGrid.GridControl gcTipoMovimentacao;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTipoMovimentacao;
        private DevExpress.XtraEditors.CheckEdit chbImpostosRetidos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        public DevExpress.XtraGrid.GridControl gcStatus;
        public DevExpress.XtraGrid.Views.Grid.GridView gvStatus;
        private DevExpress.XtraGrid.Columns.GridColumn codigo;
        private DevExpress.XtraGrid.Columns.GridColumn status;
    }
}