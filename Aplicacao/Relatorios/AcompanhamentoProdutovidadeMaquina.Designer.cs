namespace Aplicacao.Relatorios
{
    partial class AcompanhamentoProdutovidadeMaquina
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
            this.gcMaquinas = new DevExpress.XtraGrid.GridControl();
            this.gvMaquinas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaquinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaquinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(694, 293);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.txtDataInicial);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.gcMaquinas);
            this.tabPage1.Size = new System.Drawing.Size(688, 287);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(552, 311);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(631, 311);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 315);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 311);
            // 
            // gcMaquinas
            // 
            this.gcMaquinas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcMaquinas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcMaquinas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcMaquinas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcMaquinas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcMaquinas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcMaquinas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcMaquinas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcMaquinas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcMaquinas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcMaquinas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcMaquinas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcMaquinas.Location = new System.Drawing.Point(45, 28);
            this.gcMaquinas.MainView = this.gvMaquinas;
            this.gcMaquinas.Name = "gcMaquinas";
            this.gcMaquinas.Size = new System.Drawing.Size(633, 224);
            this.gcMaquinas.TabIndex = 6;
            this.gcMaquinas.UseEmbeddedNavigator = true;
            this.gcMaquinas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaquinas});
            // 
            // gvMaquinas
            // 
            this.gvMaquinas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.Empty.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMaquinas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMaquinas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMaquinas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMaquinas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMaquinas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMaquinas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMaquinas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMaquinas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMaquinas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMaquinas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvMaquinas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.Preview.Options.UseFont = true;
            this.gvMaquinas.Appearance.Preview.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMaquinas.Appearance.Row.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMaquinas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMaquinas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvMaquinas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvMaquinas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvMaquinas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvMaquinas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMaquinas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMaquinas.BestFitMaxRowCount = 5;
            this.gvMaquinas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3});
            this.gvMaquinas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvMaquinas.GridControl = this.gcMaquinas;
            this.gvMaquinas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvMaquinas.Name = "gvMaquinas";
            this.gvMaquinas.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvMaquinas.OptionsBehavior.Editable = false;
            this.gvMaquinas.OptionsDetail.EnableMasterViewMode = false;
            this.gvMaquinas.OptionsSelection.MultiSelect = true;
            this.gvMaquinas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMaquinas.OptionsView.EnableAppearanceOddRow = true;
            this.gvMaquinas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descrição";
            this.gridColumn3.FieldName = "Descricao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 540;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(45, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Máquinas";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(541, 261);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(368, 261);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Período:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(553, 258);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(125, 20);
            this.txtDataFinal.TabIndex = 13;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(414, 258);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(121, 20);
            this.txtDataInicial.TabIndex = 11;
            // 
            // AcompanhamentoProdutovidadeMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(718, 340);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AcompanhamentoProdutovidadeMaquina";
            this.Shown += new System.EventHandler(this.AcompanhamentoProdutovidadeMaquina_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaquinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaquinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcMaquinas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaquinas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
    }
}
