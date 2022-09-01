namespace Aplicacao.Relatorios
{
    partial class ComissaoVendedorFinanceiroProdutoServico
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
            this.cbVendedor = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTodos = new DevExpress.XtraEditors.CheckEdit();
            this.sbVendedor = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtInicio = new DevExpress.XtraEditors.DateEdit();
            this.txtFim = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcTipoNota = new DevExpress.XtraGrid.GridControl();
            this.gvTipoNota = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoNota)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(712, 408);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gcTipoNota);
            this.tabPage1.Controls.Add(this.cbVendedor);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.txtFim);
            this.tabPage1.Controls.Add(this.sbVendedor);
            this.tabPage1.Controls.Add(this.cbTodos);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtInicio);
            this.tabPage1.Size = new System.Drawing.Size(706, 402);
            this.tabPage1.Controls.SetChildIndex(this.txtInicio, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl4, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbTodos, 0);
            this.tabPage1.Controls.SetChildIndex(this.sbVendedor, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtFim, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl5, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbVendedor, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcTipoNota, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 426);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 426);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 430);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 426);
            // 
            // cbVendedor
            // 
            this.cbVendedor.ButtonLookup = null;
            this.cbVendedor.Key = System.Windows.Forms.Keys.F5;
            this.cbVendedor.Location = new System.Drawing.Point(112, 368);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVendedor.Properties.DisplayMember = "Nome";
            this.cbVendedor.Properties.NullText = "";
            this.cbVendedor.Properties.ValueMember = "ID";
            this.cbVendedor.Size = new System.Drawing.Size(482, 20);
            this.cbVendedor.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 371);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Vendedor: ";
            // 
            // cbTodos
            // 
            this.cbTodos.Location = new System.Drawing.Point(632, 369);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Properties.Caption = "Todos";
            this.cbTodos.Size = new System.Drawing.Size(55, 19);
            this.cbTodos.TabIndex = 5;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.cbTodos_CheckedChanged);
            // 
            // sbVendedor
            // 
            this.sbVendedor.Location = new System.Drawing.Point(600, 368);
            this.sbVendedor.Name = "sbVendedor";
            this.sbVendedor.Size = new System.Drawing.Size(26, 23);
            this.sbVendedor.TabIndex = 6;
            this.sbVendedor.Text = "...";
            this.sbVendedor.Click += new System.EventHandler(this.sbVendedor_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(575, 341);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "à";
            // 
            // txtInicio
            // 
            this.txtInicio.EditValue = null;
            this.txtInicio.Location = new System.Drawing.Point(469, 338);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 10;
            // 
            // txtFim
            // 
            this.txtFim.EditValue = null;
            this.txtFim.Location = new System.Drawing.Point(587, 338);
            this.txtFim.Name = "txtFim";
            this.txtFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtFim.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFim.Size = new System.Drawing.Size(100, 20);
            this.txtFim.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(423, 341);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Período:";
            // 
            // gcTipoNota
            // 
            this.gcTipoNota.Location = new System.Drawing.Point(52, 209);
            this.gcTipoNota.LookAndFeel.UseWindowsXPTheme = true;
            this.gcTipoNota.MainView = this.gvTipoNota;
            this.gcTipoNota.Name = "gcTipoNota";
            this.gcTipoNota.Size = new System.Drawing.Size(635, 123);
            this.gcTipoNota.TabIndex = 13;
            this.gcTipoNota.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoNota});
            // 
            // gvTipoNota
            // 
            this.gvTipoNota.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoNota.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoNota.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoNota.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoNota.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoNota.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoNota.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoNota.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoNota.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoNota.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoNota.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoNota.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.Preview.Options.UseFont = true;
            this.gvTipoNota.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoNota.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoNota.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoNota.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoNota.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoNota.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipoNota.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoNota.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoNota.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoNota.BestFitMaxRowCount = 5;
            this.gvTipoNota.GridControl = this.gcTipoNota;
            this.gvTipoNota.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTipoNota.Name = "gvTipoNota";
            this.gvTipoNota.OptionsBehavior.Editable = false;
            this.gvTipoNota.OptionsSelection.MultiSelect = true;
            this.gvTipoNota.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoNota.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoNota.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(53, 187);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Tipos de Nota";
            // 
            // ComissaoVendedorFinanceiroProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ComissaoVendedorFinanceiroProdutoServico";
            this.ShowInTaskbar = false;
            this.Text = "Relatório de Comissão";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.devexpress.cwk_DevLookup cbVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit cbTodos;
        private DevExpress.XtraEditors.SimpleButton sbVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtFim;
        private DevExpress.XtraEditors.DateEdit txtInicio;
        private DevExpress.XtraGrid.GridControl gcTipoNota;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoNota;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
