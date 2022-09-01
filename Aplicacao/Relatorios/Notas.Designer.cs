namespace Aplicacao.Relatorios
{
    partial class Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.sbAux = new Componentes.devexpress.cwk_DevButton();
            this.cbAux = new Componentes.devexpress.cwk_DevLookup();
            this.labelAux = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.chbAux = new DevExpress.XtraEditors.CheckEdit();
            this.gcTipoMovimentacao = new DevExpress.XtraGrid.GridControl();
            this.gvTipoMovimentacao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbTipoData = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAux.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAux.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(709, 424);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTipoData);
            this.tabPage1.Controls.Add(this.gcTipoMovimentacao);
            this.tabPage1.Controls.Add(this.chbAux);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Controls.Add(this.sbAux);
            this.tabPage1.Controls.Add(this.cbAux);
            this.tabPage1.Controls.Add(this.labelAux);
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Size = new System.Drawing.Size(703, 418);
            this.tabPage1.Controls.SetChildIndex(this.groupControl1, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelAux, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbAux, 0);
            this.tabPage1.Controls.SetChildIndex(this.sbAux, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbAux, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcTipoMovimentacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbTipoData, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(567, 442);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(646, 442);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 446);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 442);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rgTipo);
            this.groupControl1.Location = new System.Drawing.Point(52, 178);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(338, 56);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Tipo ";
            // 
            // rgTipo
            // 
            this.rgTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgTipo.Location = new System.Drawing.Point(0, 18);
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Movimentação"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Estado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Cliente/Fornecedor")});
            this.rgTipo.Size = new System.Drawing.Size(338, 38);
            this.rgTipo.TabIndex = 4;
            this.rgTipo.SelectedIndexChanged += new System.EventHandler(this.rgTipo_SelectedIndexChanged);
            // 
            // sbAux
            // 
            this.sbAux.Location = new System.Drawing.Point(559, 393);
            this.sbAux.Name = "sbAux";
            this.sbAux.Size = new System.Drawing.Size(24, 20);
            this.sbAux.TabIndex = 14;
            this.sbAux.TabStop = false;
            this.sbAux.Text = "...";
            this.sbAux.Click += new System.EventHandler(this.sbAux_Click);
            // 
            // cbAux
            // 
            this.cbAux.ButtonLookup = this.sbAux;
            this.cbAux.Key = System.Windows.Forms.Keys.F5;
            this.cbAux.Location = new System.Drawing.Point(94, 393);
            this.cbAux.Name = "cbAux";
            this.cbAux.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAux.Properties.DisplayMember = "Nome";
            this.cbAux.Properties.NullText = "";
            this.cbAux.Properties.ValueMember = "ID";
            this.cbAux.Size = new System.Drawing.Size(459, 20);
            this.cbAux.TabIndex = 13;
            // 
            // labelAux
            // 
            this.labelAux.Location = new System.Drawing.Point(51, 396);
            this.labelAux.Name = "labelAux";
            this.labelAux.Size = new System.Drawing.Size(37, 13);
            this.labelAux.TabIndex = 12;
            this.labelAux.Text = "Cliente:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(597, 196);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "à";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(607, 193);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 18;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(513, 193);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 17;
            // 
            // chbAux
            // 
            this.chbAux.Location = new System.Drawing.Point(589, 394);
            this.chbAux.Name = "chbAux";
            this.chbAux.Properties.Caption = "Todos Clientes";
            this.chbAux.Size = new System.Drawing.Size(92, 19);
            this.chbAux.TabIndex = 20;
            this.chbAux.CheckedChanged += new System.EventHandler(this.chbAux_CheckedChanged);
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
            this.gcTipoMovimentacao.Location = new System.Drawing.Point(52, 245);
            this.gcTipoMovimentacao.MainView = this.gvTipoMovimentacao;
            this.gcTipoMovimentacao.Name = "gcTipoMovimentacao";
            this.gcTipoMovimentacao.Size = new System.Drawing.Size(635, 133);
            this.gcTipoMovimentacao.TabIndex = 21;
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
            // cbTipoData
            // 
            this.cbTipoData.EditValue = "";
            this.cbTipoData.Location = new System.Drawing.Point(396, 193);
            this.cbTipoData.Name = "cbTipoData";
            this.cbTipoData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoData.Properties.Items.AddRange(new object[] {
            "Data",
            "Data Autorização"});
            this.cbTipoData.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoData.Size = new System.Drawing.Size(111, 20);
            this.cbTipoData.TabIndex = 24;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(733, 471);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAux.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAux.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoData.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private Componentes.devexpress.cwk_DevButton sbAux;
        private Componentes.devexpress.cwk_DevLookup cbAux;
        private DevExpress.XtraEditors.LabelControl labelAux;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.CheckEdit chbAux;
        public DevExpress.XtraGrid.GridControl gcTipoMovimentacao;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTipoMovimentacao;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoData;
    }
}
