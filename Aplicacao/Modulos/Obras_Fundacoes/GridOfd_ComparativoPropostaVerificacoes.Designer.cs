namespace Aplicacao.Modulos.Obras_Fundacoes
{
    partial class GridOfd_ComparativoPropostaVerificacoes
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridOfd_ComparativoPropostaVerificacoes));
            this.gcComparativo = new DevExpress.XtraGrid.GridControl();
            this.gvComparativo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcComparativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComparativo)).BeginInit();
            this.SuspendLayout();
            // 
            // gcComparativo
            // 
            this.gcComparativo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcComparativo.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcComparativo.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcComparativo.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcComparativo.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcComparativo.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcComparativo.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcComparativo.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcComparativo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcComparativo.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcComparativo.Location = new System.Drawing.Point(12, 12);
            this.gcComparativo.MainView = this.gvComparativo;
            this.gcComparativo.Name = "gcComparativo";
            this.gcComparativo.Size = new System.Drawing.Size(1203, 376);
            this.gcComparativo.TabIndex = 1;
            this.gcComparativo.UseEmbeddedNavigator = true;
            this.gcComparativo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComparativo});
            // 
            // gvComparativo
            // 
            this.gvComparativo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvComparativo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvComparativo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvComparativo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvComparativo.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.Empty.Options.UseBackColor = true;
            this.gvComparativo.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvComparativo.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvComparativo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvComparativo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvComparativo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvComparativo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvComparativo.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvComparativo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvComparativo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvComparativo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvComparativo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvComparativo.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvComparativo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvComparativo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvComparativo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvComparativo.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvComparativo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvComparativo.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvComparativo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvComparativo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvComparativo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvComparativo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvComparativo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvComparativo.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvComparativo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvComparativo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvComparativo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvComparativo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvComparativo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvComparativo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvComparativo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvComparativo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvComparativo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvComparativo.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvComparativo.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvComparativo.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.OddRow.Options.UseBackColor = true;
            this.gvComparativo.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.OddRow.Options.UseForeColor = true;
            this.gvComparativo.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvComparativo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.Preview.Options.UseFont = true;
            this.gvComparativo.Appearance.Preview.Options.UseForeColor = true;
            this.gvComparativo.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvComparativo.Appearance.Row.Options.UseBackColor = true;
            this.gvComparativo.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvComparativo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvComparativo.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvComparativo.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvComparativo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvComparativo.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvComparativo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvComparativo.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvComparativo.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvComparativo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn9,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.LightCoral;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[Quantidade] < [QuantidadeProposta] || [Profundidade] < [ProfundidadeProposta] ||" +
                " [Total] < [TotalProposta] || [Diametro] < [DiametroProposta]";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightGreen;
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.LightGreen;
            styleFormatCondition2.Appearance.BorderColor = System.Drawing.Color.LightGreen;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseBorderColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[QuantidadeProposta] == [Quantidade] && [Profundidade] == [ProfundidadeProposta] " +
                "&& [Total] == [TotalProposta] && [Diametro] == [DiametroProposta]";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            styleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.PapayaWhip;
            styleFormatCondition3.Appearance.BorderColor = System.Drawing.Color.PapayaWhip;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseBorderColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[Quantidade] > [QuantidadeProposta] || [Profundidade] > [ProfundidadeProposta] ||" +
                " [Total] > [TotalProposta] || [Diametro] > [DiametroProposta]";
            this.gvComparativo.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gvComparativo.GridControl = this.gcComparativo;
            this.gvComparativo.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvComparativo.Name = "gvComparativo";
            this.gvComparativo.OptionsBehavior.Editable = false;
            this.gvComparativo.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvComparativo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvComparativo.OptionsView.EnableAppearanceOddRow = true;
            this.gvComparativo.OptionsView.ShowAutoFilterRow = true;
            this.gvComparativo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Data Verificação";
            this.gridColumn12.FieldName = "DataVerificacao";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 108;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Data do Relatório";
            this.gridColumn10.FieldName = "DataRelatorio";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 100;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Relatório";
            this.gridColumn11.FieldName = "Relatorio";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 78;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Estaca";
            this.gridColumn1.FieldName = "Estaca";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 69;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Diâmetro Proposta";
            this.gridColumn2.FieldName = "DiametroProposta";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 110;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Diâmetro Verificação";
            this.gridColumn9.FieldName = "Diametro";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 106;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Qnt. Proposta";
            this.gridColumn3.FieldName = "QuantidadeProposta";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 91;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Qtd. Verificação";
            this.gridColumn4.FieldName = "Quantidade";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 91;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Profundidade Proposta";
            this.gridColumn5.FieldName = "ProfundidadeProposta";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 8;
            this.gridColumn5.Width = 125;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Profundidade Verificação";
            this.gridColumn6.FieldName = "Profundidade";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 9;
            this.gridColumn6.Width = 126;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Total Proposta";
            this.gridColumn7.FieldName = "TotalProposta";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 10;
            this.gridColumn7.Width = 86;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total Verificação";
            this.gridColumn8.FieldName = "Total";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 11;
            this.gridColumn8.Width = 95;
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(11, 394);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 6;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbImprimir
            // 
            this.sbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimir.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimir.ImageIndex = 1;
            this.sbImprimir.Location = new System.Drawing.Point(1055, 394);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(75, 23);
            this.sbImprimir.TabIndex = 4;
            this.sbImprimir.Text = "&Imprimir";
            this.sbImprimir.Click += new System.EventHandler(this.sbImprimir_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(1136, 394);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 5;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // GridOfd_ComparativoPropostaVerificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 429);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.gcComparativo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GridOfd_ComparativoPropostaVerificacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparativo Proposta x Verificações";
            ((System.ComponentModel.ISupportInitialize)(this.gcComparativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComparativo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcComparativo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComparativo;
        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbImprimir;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}