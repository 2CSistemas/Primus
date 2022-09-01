namespace Aplicacao.Relatorios
{
    partial class FormFaturamentoRevendas
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
            this.chbSelecionarTodos = new DevExpress.XtraEditors.CheckEdit();
            this.txtDataFinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcRevendas = new DevExpress.XtraGrid.GridControl();
            this.gvRevendas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbDataFiltro = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSelecionarTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRevendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRevendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataFiltro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(985, 383);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbDataFiltro);
            this.tabPage1.Controls.Add(this.lblFiltro);
            this.tabPage1.Controls.Add(this.gcRevendas);
            this.tabPage1.Controls.Add(this.chbSelecionarTodos);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDataInicial);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Size = new System.Drawing.Size(979, 377);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(843, 401);
            this.btOk.TabIndex = 10;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(922, 401);
            this.btCancelar.TabIndex = 11;
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 405);
            this.chbSalvarFiltro.TabIndex = 9;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 401);
            this.simpleButton2.TabIndex = 8;
            // 
            // chbSelecionarTodos
            // 
            this.chbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbSelecionarTodos.Location = new System.Drawing.Point(3, 351);
            this.chbSelecionarTodos.Name = "chbSelecionarTodos";
            this.chbSelecionarTodos.Properties.Caption = "Selecionar Todos";
            this.chbSelecionarTodos.Size = new System.Drawing.Size(104, 19);
            this.chbSelecionarTodos.TabIndex = 1;
            this.chbSelecionarTodos.CheckedChanged += new System.EventHandler(this.chbSelecionarTodos_CheckedChanged);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(876, 350);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(100, 20);
            this.txtDataFinal.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(864, 353);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "à";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(758, 350);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicial.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(712, 353);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Periodo:";
            // 
            // gcRevendas
            // 
            this.gcRevendas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcRevendas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcRevendas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcRevendas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcRevendas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcRevendas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcRevendas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcRevendas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcRevendas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcRevendas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcRevendas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcRevendas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcRevendas.Location = new System.Drawing.Point(3, 3);
            this.gcRevendas.LookAndFeel.UseWindowsXPTheme = true;
            this.gcRevendas.MainView = this.gvRevendas;
            this.gcRevendas.Name = "gcRevendas";
            this.gcRevendas.Size = new System.Drawing.Size(973, 342);
            this.gcRevendas.TabIndex = 0;
            this.gcRevendas.UseEmbeddedNavigator = true;
            this.gcRevendas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRevendas});
            // 
            // gvRevendas
            // 
            this.gvRevendas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvRevendas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRevendas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRevendas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRevendas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRevendas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvRevendas.Appearance.Empty.Options.UseBackColor = true;
            this.gvRevendas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvRevendas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvRevendas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRevendas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRevendas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRevendas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRevendas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvRevendas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRevendas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvRevendas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRevendas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRevendas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRevendas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRevendas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRevendas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRevendas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvRevendas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvRevendas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRevendas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRevendas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRevendas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRevendas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRevendas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvRevendas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRevendas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRevendas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRevendas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRevendas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRevendas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRevendas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRevendas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRevendas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRevendas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRevendas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRevendas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRevendas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRevendas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRevendas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRevendas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRevendas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRevendas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvRevendas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.Preview.Options.UseFont = true;
            this.gvRevendas.Appearance.Preview.Options.UseForeColor = true;
            this.gvRevendas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRevendas.Appearance.Row.Options.UseBackColor = true;
            this.gvRevendas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRevendas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRevendas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRevendas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvRevendas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRevendas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvRevendas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRevendas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvRevendas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvRevendas.BestFitMaxRowCount = 5;
            this.gvRevendas.GridControl = this.gcRevendas;
            this.gvRevendas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvRevendas.Name = "gvRevendas";
            this.gvRevendas.OptionsBehavior.Editable = false;
            this.gvRevendas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvRevendas.OptionsSelection.MultiSelect = true;
            this.gvRevendas.OptionsView.ColumnAutoWidth = false;
            this.gvRevendas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRevendas.OptionsView.EnableAppearanceOddRow = true;
            this.gvRevendas.OptionsView.ShowGroupPanel = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(540, 353);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(33, 13);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Data:";
            // 
            // cbDataFiltro
            // 
            this.cbDataFiltro.EditValue = "Compra";
            this.cbDataFiltro.Location = new System.Drawing.Point(578, 350);
            this.cbDataFiltro.Name = "cbDataFiltro";
            this.cbDataFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDataFiltro.Properties.ImmediatePopup = true;
            this.cbDataFiltro.Properties.Items.AddRange(new object[] {
            "Compra",
            "Liberação"});
            this.cbDataFiltro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDataFiltro.Size = new System.Drawing.Size(128, 20);
            this.cbDataFiltro.TabIndex = 3;
            // 
            // FormFaturamentoRevendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1009, 430);
            this.Name = "FormFaturamentoRevendas";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSelecionarTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRevendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRevendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataFiltro.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.CheckEdit chbSelecionarTodos;
        private DevExpress.XtraEditors.DateEdit txtDataFinal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtDataInicial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraGrid.GridControl gcRevendas;
        public DevExpress.XtraGrid.Views.Grid.GridView gvRevendas;
        private System.Windows.Forms.Label lblFiltro;
        private DevExpress.XtraEditors.ComboBoxEdit cbDataFiltro;
    }
}
