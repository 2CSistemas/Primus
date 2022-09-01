namespace Aplicacao
{
    partial class FormManutAcompanhamentoProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutAcompanhamentoProjeto));
            this.txtDescricao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.gcAgrupamentos = new DevExpress.XtraGrid.GridControl();
            this.gvAgrupamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAgrupamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgrupamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(573, 320);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcAgrupamentos);
            this.xtraTabPage1.Controls.Add(this.txtData);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtDescricao);
            this.xtraTabPage1.Size = new System.Drawing.Size(564, 311);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(510, 338);
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
            this.sbGravar.Location = new System.Drawing.Point(429, 338);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 338);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(59, 14);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(489, 112);
            this.txtDescricao.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Descrição:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(59, 132);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 3;
            // 
            // gcAgrupamentos
            // 
            this.gcAgrupamentos.EmbeddedNavigator.Name = "";
            this.gcAgrupamentos.Location = new System.Drawing.Point(59, 158);
            this.gcAgrupamentos.MainView = this.gvAgrupamentos;
            this.gcAgrupamentos.Name = "gcAgrupamentos";
            this.gcAgrupamentos.Size = new System.Drawing.Size(489, 140);
            this.gcAgrupamentos.TabIndex = 4;
            this.gcAgrupamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAgrupamentos});
            // 
            // gvAgrupamentos
            // 
            this.gvAgrupamentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAgrupamentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAgrupamentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAgrupamentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAgrupamentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAgrupamentos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAgrupamentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAgrupamentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAgrupamentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAgrupamentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAgrupamentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvAgrupamentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.Preview.Options.UseFont = true;
            this.gvAgrupamentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAgrupamentos.Appearance.Row.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvAgrupamentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAgrupamentos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAgrupamentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAgrupamentos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvAgrupamentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAgrupamentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvAgrupamentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvAgrupamentos.BestFitMaxRowCount = 5;
            this.gvAgrupamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.gvAgrupamentos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvAgrupamentos.GridControl = this.gcAgrupamentos;
            this.gvAgrupamentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvAgrupamentos.Name = "gvAgrupamentos";
            this.gvAgrupamentos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvAgrupamentos.OptionsDetail.EnableMasterViewMode = false;
            this.gvAgrupamentos.OptionsView.ColumnAutoWidth = false;
            this.gvAgrupamentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAgrupamentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvAgrupamentos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Agrupamento";
            this.gridColumn1.FieldName = "Agrupamento";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 81;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descrição";
            this.gridColumn3.FieldName = "Descricao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 153;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Serviços";
            this.gridColumn2.FieldName = "Servicos";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 410;
            // 
            // FormManutAcompanhamentoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 373);
            this.Name = "FormManutAcompanhamentoProjeto";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAgrupamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgrupamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtDescricao;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtData;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcAgrupamentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAgrupamentos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
