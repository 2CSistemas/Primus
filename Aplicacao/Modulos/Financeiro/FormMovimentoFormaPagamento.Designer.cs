namespace Aplicacao
{
    partial class FormMovimentoFormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimentoFormaPagamento));
            this.gcFormaPagamentoMovimentos = new DevExpress.XtraGrid.GridControl();
            this.gvFormaPagamentoMovimentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFormaPagamentoMovimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormaPagamentoMovimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 314);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(615, 314);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(696, 314);
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
            this.tpPrincipal.Controls.Add(this.gcFormaPagamentoMovimentos);
            this.tpPrincipal.Size = new System.Drawing.Size(750, 287);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(759, 296);
            // 
            // gcFormaPagamentoMovimentos
            // 
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.Name = "";
            this.gcFormaPagamentoMovimentos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcFormaPagamentoMovimentos.Location = new System.Drawing.Point(3, 3);
            this.gcFormaPagamentoMovimentos.LookAndFeel.UseWindowsXPTheme = true;
            this.gcFormaPagamentoMovimentos.MainView = this.gvFormaPagamentoMovimentos;
            this.gcFormaPagamentoMovimentos.Name = "gcFormaPagamentoMovimentos";
            this.gcFormaPagamentoMovimentos.Size = new System.Drawing.Size(742, 277);
            this.gcFormaPagamentoMovimentos.TabIndex = 2;
            this.gcFormaPagamentoMovimentos.UseEmbeddedNavigator = true;
            this.gcFormaPagamentoMovimentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFormaPagamentoMovimentos});
            // 
            // gvFormaPagamentoMovimentos
            // 
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFormaPagamentoMovimentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFormaPagamentoMovimentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFormaPagamentoMovimentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormaPagamentoMovimentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormaPagamentoMovimentos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormaPagamentoMovimentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFormaPagamentoMovimentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFormaPagamentoMovimentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFormaPagamentoMovimentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormaPagamentoMovimentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFormaPagamentoMovimentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.Preview.Options.UseFont = true;
            this.gvFormaPagamentoMovimentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormaPagamentoMovimentos.Appearance.Row.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFormaPagamentoMovimentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormaPagamentoMovimentos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormaPagamentoMovimentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFormaPagamentoMovimentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFormaPagamentoMovimentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFormaPagamentoMovimentos.BestFitMaxRowCount = 5;
            this.gvFormaPagamentoMovimentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Descricao,
            this.Valor,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvFormaPagamentoMovimentos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvFormaPagamentoMovimentos.GridControl = this.gcFormaPagamentoMovimentos;
            this.gvFormaPagamentoMovimentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFormaPagamentoMovimentos.Name = "gvFormaPagamentoMovimentos";
            this.gvFormaPagamentoMovimentos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvFormaPagamentoMovimentos.OptionsBehavior.Editable = false;
            this.gvFormaPagamentoMovimentos.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvFormaPagamentoMovimentos.OptionsView.ColumnAutoWidth = false;
            this.gvFormaPagamentoMovimentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFormaPagamentoMovimentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvFormaPagamentoMovimentos.OptionsView.ShowAutoFilterRow = true;
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
            // FormMovimentoFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(783, 349);
            this.Name = "FormMovimentoFormaPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFormaPagamentoMovimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormaPagamentoMovimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcFormaPagamentoMovimentos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvFormaPagamentoMovimentos;
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
