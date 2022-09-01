namespace Aplicacao
{
    partial class GridConsultaFormasPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridConsultaFormasPagamento));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.GridFormasPagamento = new DevExpress.XtraGrid.GridControl();
            this.gvFormasPagamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFormasPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormasPagamento)).BeginInit();
            this.SuspendLayout();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(757, 292);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.GridFormasPagamento);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(751, 286);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // GridFormasPagamento
            // 
            this.GridFormasPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.GridFormasPagamento.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.GridFormasPagamento.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.GridFormasPagamento.Location = new System.Drawing.Point(3, 3);
            this.GridFormasPagamento.LookAndFeel.UseWindowsXPTheme = true;
            this.GridFormasPagamento.MainView = this.gvFormasPagamento;
            this.GridFormasPagamento.Name = "GridFormasPagamento";
            this.GridFormasPagamento.Size = new System.Drawing.Size(742, 277);
            this.GridFormasPagamento.TabIndex = 1;
            this.GridFormasPagamento.UseEmbeddedNavigator = true;
            this.GridFormasPagamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFormasPagamento});
            // 
            // gvFormasPagamento
            // 
            this.gvFormasPagamento.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.Empty.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFormasPagamento.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFormasPagamento.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFormasPagamento.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFormasPagamento.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFormasPagamento.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFormasPagamento.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFormasPagamento.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.Preview.Options.UseFont = true;
            this.gvFormasPagamento.Appearance.Preview.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.Row.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFormasPagamento.BestFitMaxRowCount = 5;
            this.gvFormasPagamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Descricao,
            this.Valor,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvFormasPagamento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvFormasPagamento.GridControl = this.GridFormasPagamento;
            this.gvFormasPagamento.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFormasPagamento.Name = "gvFormasPagamento";
            this.gvFormasPagamento.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvFormasPagamento.OptionsBehavior.Editable = false;
            this.gvFormasPagamento.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvFormasPagamento.OptionsView.ColumnAutoWidth = false;
            this.gvFormasPagamento.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFormasPagamento.OptionsView.EnableAppearanceOddRow = true;
            this.gvFormasPagamento.OptionsView.ShowAutoFilterRow = true;
            // 
            // Descricao
            // 
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "FormaPagamento";
            this.Descricao.Name = "Descricao";
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 0;
            this.Descricao.Width = 116;
            // 
            // Valor
            // 
            this.Valor.AppearanceCell.Options.UseTextOptions = true;
            this.Valor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Valor.AppearanceHeader.Options.UseTextOptions = true;
            this.Valor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Valor.Caption = "Valor";
            this.Valor.DisplayFormat.FormatString = "C2";
            this.Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Valor.FieldName = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 1;
            this.Valor.Width = 81;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nome Banco";
            this.gridColumn1.FieldName = "NomeBanco";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Num. Banco";
            this.gridColumn2.FieldName = "NumBanco";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Agência";
            this.gridColumn3.FieldName = "Agencia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 58;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Conta";
            this.gridColumn4.FieldName = "Conta";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 72;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cheque";
            this.gridColumn5.FieldName = "Cheque";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 58;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Emitente";
            this.gridColumn6.FieldName = "Emitente";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 107;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "CPF/CPNJ";
            this.gridColumn7.FieldName = "CpfCnpjEmitente";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 90;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(694, 310);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 3;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // GridConsultaFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 336);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GridConsultaFormasPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultando Formas De Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFormasPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormasPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraGrid.GridControl GridFormasPagamento;
        public DevExpress.XtraGrid.Views.Grid.GridView gvFormasPagamento;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}