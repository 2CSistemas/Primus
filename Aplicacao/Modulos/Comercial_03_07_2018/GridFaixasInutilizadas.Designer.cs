namespace Aplicacao.Modulos.Comercial
{
    partial class GridFaixasInutilizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridFaixasInutilizadas));
            this.gcFaixasInutilizadas = new DevExpress.XtraGrid.GridControl();
            this.gvFaixasInutilizadas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroFim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Justificativa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModeloNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbInutilizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaixasInutilizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaixasInutilizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(849, 369);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcFaixasInutilizadas);
            this.xtraTabPage1.Size = new System.Drawing.Size(843, 363);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(786, 387);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(400, 387);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 387);
            // 
            // gcFaixasInutilizadas
            // 
            this.gcFaixasInutilizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFaixasInutilizadas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFaixasInutilizadas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcFaixasInutilizadas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcFaixasInutilizadas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcFaixasInutilizadas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFaixasInutilizadas.Location = new System.Drawing.Point(3, 3);
            this.gcFaixasInutilizadas.MainView = this.gvFaixasInutilizadas;
            this.gcFaixasInutilizadas.Name = "gcFaixasInutilizadas";
            this.gcFaixasInutilizadas.Size = new System.Drawing.Size(837, 357);
            this.gcFaixasInutilizadas.TabIndex = 16;
            this.gcFaixasInutilizadas.UseEmbeddedNavigator = true;
            this.gcFaixasInutilizadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFaixasInutilizadas});
            // 
            // gvFaixasInutilizadas
            // 
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.Empty.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaixasInutilizadas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaixasInutilizadas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaixasInutilizadas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaixasInutilizadas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFaixasInutilizadas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.Preview.Options.UseFont = true;
            this.gvFaixasInutilizadas.Appearance.Preview.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.Row.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Serie,
            this.NumeroInicio,
            this.NumeroFim,
            this.Justificativa,
            this.Data,
            this.Ano,
            this.ModeloNota});
            this.gvFaixasInutilizadas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvFaixasInutilizadas.GridControl = this.gcFaixasInutilizadas;
            this.gvFaixasInutilizadas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFaixasInutilizadas.Name = "gvFaixasInutilizadas";
            this.gvFaixasInutilizadas.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvFaixasInutilizadas.OptionsView.ColumnAutoWidth = false;
            this.gvFaixasInutilizadas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFaixasInutilizadas.OptionsView.EnableAppearanceOddRow = true;
            this.gvFaixasInutilizadas.OptionsView.ShowAutoFilterRow = true;
            this.gvFaixasInutilizadas.OptionsView.ShowFooter = true;
            // 
            // Serie
            // 
            this.Serie.AppearanceHeader.Options.UseTextOptions = true;
            this.Serie.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Serie.Caption = "Série";
            this.Serie.FieldName = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.OptionsColumn.ReadOnly = true;
            this.Serie.Visible = true;
            this.Serie.VisibleIndex = 1;
            this.Serie.Width = 94;
            // 
            // NumeroInicio
            // 
            this.NumeroInicio.AppearanceHeader.Options.UseTextOptions = true;
            this.NumeroInicio.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NumeroInicio.Caption = "Número Início";
            this.NumeroInicio.FieldName = "NumeroInicio";
            this.NumeroInicio.Name = "NumeroInicio";
            this.NumeroInicio.OptionsColumn.ReadOnly = true;
            this.NumeroInicio.Visible = true;
            this.NumeroInicio.VisibleIndex = 2;
            this.NumeroInicio.Width = 93;
            // 
            // NumeroFim
            // 
            this.NumeroFim.AppearanceHeader.Options.UseTextOptions = true;
            this.NumeroFim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NumeroFim.Caption = "Número Fim";
            this.NumeroFim.FieldName = "NumeroFim";
            this.NumeroFim.Name = "NumeroFim";
            this.NumeroFim.OptionsColumn.ReadOnly = true;
            this.NumeroFim.Visible = true;
            this.NumeroFim.VisibleIndex = 3;
            this.NumeroFim.Width = 104;
            // 
            // Justificativa
            // 
            this.Justificativa.AppearanceHeader.Options.UseTextOptions = true;
            this.Justificativa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Justificativa.Caption = "Justificativa";
            this.Justificativa.FieldName = "Justificativa";
            this.Justificativa.Name = "Justificativa";
            this.Justificativa.OptionsColumn.ReadOnly = true;
            this.Justificativa.Visible = true;
            this.Justificativa.VisibleIndex = 4;
            this.Justificativa.Width = 325;
            // 
            // Data
            // 
            this.Data.AppearanceHeader.Options.UseTextOptions = true;
            this.Data.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Data.Caption = "Data";
            this.Data.FieldName = "Data";
            this.Data.Name = "Data";
            this.Data.OptionsColumn.ReadOnly = true;
            this.Data.Visible = true;
            this.Data.VisibleIndex = 5;
            this.Data.Width = 84;
            // 
            // Ano
            // 
            this.Ano.AppearanceHeader.Options.UseTextOptions = true;
            this.Ano.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Ano.Caption = "Ano";
            this.Ano.FieldName = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.OptionsColumn.ReadOnly = true;
            this.Ano.Visible = true;
            this.Ano.VisibleIndex = 6;
            this.Ano.Width = 54;
            // 
            // ModeloNota
            // 
            this.ModeloNota.AppearanceHeader.Options.UseTextOptions = true;
            this.ModeloNota.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ModeloNota.Caption = "Modelo Nota";
            this.ModeloNota.FieldName = "ModeloNotaStr";
            this.ModeloNota.Name = "ModeloNota";
            this.ModeloNota.Visible = true;
            this.ModeloNota.VisibleIndex = 0;
            this.ModeloNota.Width = 71;
            // 
            // sbInutilizar
            // 
            this.sbInutilizar.Image = ((System.Drawing.Image)(resources.GetObject("sbInutilizar.Image")));
            this.sbInutilizar.Location = new System.Drawing.Point(651, 387);
            this.sbInutilizar.Name = "sbInutilizar";
            this.sbInutilizar.Size = new System.Drawing.Size(129, 23);
            this.sbInutilizar.TabIndex = 4;
            this.sbInutilizar.Text = "Inutilizar nova faixa";
            this.sbInutilizar.Click += new System.EventHandler(this.sbInutilizar_Click);
            // 
            // GridFaixasInutilizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 422);
            this.Controls.Add(this.sbInutilizar);
            this.Name = "GridFaixasInutilizadas";
            this.Text = "Faixas Inutilizadas";
            this.Controls.SetChildIndex(this.sbInutilizar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaixasInutilizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaixasInutilizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcFaixasInutilizadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFaixasInutilizadas;
        private DevExpress.XtraGrid.Columns.GridColumn Serie;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroInicio;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroFim;
        private DevExpress.XtraGrid.Columns.GridColumn Justificativa;
        private DevExpress.XtraGrid.Columns.GridColumn Data;
        private DevExpress.XtraEditors.SimpleButton sbInutilizar;
        private DevExpress.XtraGrid.Columns.GridColumn Ano;
        private DevExpress.XtraGrid.Columns.GridColumn ModeloNota;

    }
}