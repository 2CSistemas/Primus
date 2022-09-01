namespace Aplicacao
{
    partial class FormNFe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNFe));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtEmail = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txt2CNPJ_CPF = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalNota = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPessoaNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btEnviarNFe = new DevExpress.XtraEditors.SimpleButton();
            this.btImprimirNFe = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtNumProtocolo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumRecibo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtChaveNota = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btCancelarNFe = new DevExpress.XtraEditors.SimpleButton();
            this.btConsultaNFe = new DevExpress.XtraEditors.SimpleButton();
            this.btReciboNFe = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btEditarDanfe = new DevExpress.XtraEditors.SimpleButton();
            this.btEmail = new DevExpress.XtraEditors.SimpleButton();
            this.btPreDanfe = new DevExpress.XtraEditors.SimpleButton();
            this.sbCCe = new DevExpress.XtraEditors.SimpleButton();
            this.sbConsultaCCe = new DevExpress.XtraEditors.SimpleButton();
            this.btnResolve = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2CNPJ_CPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPessoaNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumProtocolo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumRecibo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChaveNota.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.txt2CNPJ_CPF);
            this.groupControl1.Controls.Add(this.txtSerie);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtTotalNota);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtPessoaNome);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtData);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNumero);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(702, 104);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dados Nota Fiscal";
            // 
            // txtEmail
            // 
            this.txtEmail.CwkFuncaoValidacao = null;
            this.txtEmail.CwkMascara = null;
            this.txtEmail.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtEmail.Location = new System.Drawing.Point(391, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 100;
            this.txtEmail.SelecionarTextoOnEnter = false;
            this.txtEmail.Size = new System.Drawing.Size(306, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(357, 78);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 13);
            this.labelControl10.TabIndex = 35;
            this.labelControl10.Text = "Email:";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(23, 78);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(23, 13);
            this.labelControl17.TabIndex = 33;
            this.labelControl17.Text = "CPF:";
            // 
            // txt2CNPJ_CPF
            // 
            this.txt2CNPJ_CPF.CausesValidation = false;
            this.txt2CNPJ_CPF.CwkFuncaoValidacao = null;
            this.txt2CNPJ_CPF.CwkMascara = null;
            this.txt2CNPJ_CPF.CwkValidacao = null;
            this.txt2CNPJ_CPF.Location = new System.Drawing.Point(52, 75);
            this.txt2CNPJ_CPF.Name = "txt2CNPJ_CPF";
            this.txt2CNPJ_CPF.Properties.Mask.EditMask = "\\d\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d-\\d\\d";
            this.txt2CNPJ_CPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txt2CNPJ_CPF.Properties.MaxLength = 20;
            this.txt2CNPJ_CPF.SelecionarTextoOnEnter = false;
            this.txt2CNPJ_CPF.Size = new System.Drawing.Size(227, 20);
            this.txt2CNPJ_CPF.TabIndex = 34;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(52, 23);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(87, 20);
            this.txtSerie.TabIndex = 9;
            this.txtSerie.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(18, 26);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Série:";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Location = new System.Drawing.Point(556, 23);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotalNota.Properties.DisplayFormat.FormatString = "c";
            this.txtTotalNota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTotalNota.Properties.ReadOnly = true;
            this.txtTotalNota.Size = new System.Drawing.Size(141, 20);
            this.txtTotalNota.TabIndex = 5;
            this.txtTotalNota.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(481, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Total da Nota:";
            // 
            // txtPessoaNome
            // 
            this.txtPessoaNome.Location = new System.Drawing.Point(52, 49);
            this.txtPessoaNome.Name = "txtPessoaNome";
            this.txtPessoaNome.Properties.ReadOnly = true;
            this.txtPessoaNome.Size = new System.Drawing.Size(645, 20);
            this.txtPessoaNome.TabIndex = 7;
            this.txtPessoaNome.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Cliente:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(391, 23);
            this.txtData.Name = "txtData";
            this.txtData.Properties.DisplayFormat.FormatString = "d";
            this.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(84, 20);
            this.txtData.TabIndex = 3;
            this.txtData.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(358, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(192, 23);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(87, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(145, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Número:";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gridControl1.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gridControl1.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gridControl1.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridControl1.Location = new System.Drawing.Point(12, 210);
            this.gridControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.gridControl1.MainView = this.dataGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(702, 218);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataGridView1});
            // 
            // dataGridView1
            // 
            this.dataGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dataGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dataGridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.Empty.Options.UseBackColor = true;
            this.dataGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.dataGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.dataGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.dataGridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dataGridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dataGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.dataGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.dataGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.dataGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dataGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dataGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.dataGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.Preview.Options.UseFont = true;
            this.dataGridView1.Appearance.Preview.Options.UseForeColor = true;
            this.dataGridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.dataGridView1.Appearance.Row.Options.UseBackColor = true;
            this.dataGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dataGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.dataGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dataGridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.dataGridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dataGridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.dataGridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.dataGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.dataGridView1.GridControl = this.gridControl1;
            this.dataGridView1.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OptionsBehavior.Editable = false;
            this.dataGridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.dataGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.dataGridView1.OptionsView.EnableAppearanceOddRow = true;
            this.dataGridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.dataGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fases da NFe";
            this.gridColumn1.FieldName = "Column";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // btEnviarNFe
            // 
            this.btEnviarNFe.ImageOptions.Image = global::Aplicacao.Properties.Resources.Importação_de_Bilhetes_copy;
            this.btEnviarNFe.Location = new System.Drawing.Point(12, 462);
            this.btEnviarNFe.Name = "btEnviarNFe";
            this.btEnviarNFe.Size = new System.Drawing.Size(75, 23);
            this.btEnviarNFe.TabIndex = 3;
            this.btEnviarNFe.Text = "&Enviar";
            this.btEnviarNFe.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btImprimirNFe
            // 
            this.btImprimirNFe.ImageOptions.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            this.btImprimirNFe.Location = new System.Drawing.Point(174, 462);
            this.btImprimirNFe.Name = "btImprimirNFe";
            this.btImprimirNFe.Size = new System.Drawing.Size(75, 23);
            this.btImprimirNFe.TabIndex = 7;
            this.btImprimirNFe.Text = "&Imprimir";
            this.btImprimirNFe.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtNumProtocolo);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtNumRecibo);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtChaveNota);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(12, 122);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(702, 82);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Dados NFe";
            // 
            // txtNumProtocolo
            // 
            this.txtNumProtocolo.Location = new System.Drawing.Point(447, 56);
            this.txtNumProtocolo.Name = "txtNumProtocolo";
            this.txtNumProtocolo.Properties.ReadOnly = true;
            this.txtNumProtocolo.Size = new System.Drawing.Size(250, 20);
            this.txtNumProtocolo.TabIndex = 5;
            this.txtNumProtocolo.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(364, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Num. Protocolo:";
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.Location = new System.Drawing.Point(87, 56);
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Properties.ReadOnly = true;
            this.txtNumRecibo.Size = new System.Drawing.Size(250, 20);
            this.txtNumRecibo.TabIndex = 3;
            this.txtNumRecibo.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Num. Recibo:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 59);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Num. Recibo:";
            // 
            // txtChaveNota
            // 
            this.txtChaveNota.Location = new System.Drawing.Point(87, 30);
            this.txtChaveNota.Name = "txtChaveNota";
            this.txtChaveNota.Properties.ReadOnly = true;
            this.txtChaveNota.Size = new System.Drawing.Size(610, 20);
            this.txtChaveNota.TabIndex = 1;
            this.txtChaveNota.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Chave da Nota:";
            // 
            // btCancelarNFe
            // 
            this.btCancelarNFe.ImageOptions.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.btCancelarNFe.Location = new System.Drawing.Point(255, 462);
            this.btCancelarNFe.Name = "btCancelarNFe";
            this.btCancelarNFe.Size = new System.Drawing.Size(75, 23);
            this.btCancelarNFe.TabIndex = 9;
            this.btCancelarNFe.Text = "&Cancelar";
            this.btCancelarNFe.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btConsultaNFe
            // 
            this.btConsultaNFe.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultaNFe.Location = new System.Drawing.Point(93, 434);
            this.btConsultaNFe.Name = "btConsultaNFe";
            this.btConsultaNFe.Size = new System.Drawing.Size(75, 23);
            this.btConsultaNFe.TabIndex = 4;
            this.btConsultaNFe.Text = "N&Fe";
            this.btConsultaNFe.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btReciboNFe
            // 
            this.btReciboNFe.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btReciboNFe.Location = new System.Drawing.Point(93, 462);
            this.btReciboNFe.Name = "btReciboNFe";
            this.btReciboNFe.Size = new System.Drawing.Size(75, 23);
            this.btReciboNFe.TabIndex = 5;
            this.btReciboNFe.Text = "&Recibo";
            this.btReciboNFe.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btFechar
            // 
            this.btFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.btFechar.Location = new System.Drawing.Point(639, 462);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 11;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btEditarDanfe
            // 
            this.btEditarDanfe.Location = new System.Drawing.Point(639, 434);
            this.btEditarDanfe.Name = "btEditarDanfe";
            this.btEditarDanfe.Size = new System.Drawing.Size(75, 23);
            this.btEditarDanfe.TabIndex = 10;
            this.btEditarDanfe.Text = "Ed&itar DANFE";
            this.btEditarDanfe.Click += new System.EventHandler(this.btEditarDanfe_Click);
            // 
            // btEmail
            // 
            this.btEmail.Location = new System.Drawing.Point(174, 434);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(75, 23);
            this.btEmail.TabIndex = 6;
            this.btEmail.Text = "E&mail";
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click_1);
            // 
            // btPreDanfe
            // 
            this.btPreDanfe.Enabled = false;
            this.btPreDanfe.Location = new System.Drawing.Point(12, 434);
            this.btPreDanfe.Name = "btPreDanfe";
            this.btPreDanfe.Size = new System.Drawing.Size(75, 23);
            this.btPreDanfe.TabIndex = 12;
            this.btPreDanfe.Text = "Pré-&Danfe";
            this.btPreDanfe.Click += new System.EventHandler(this.btPreDanfe_Click);
            // 
            // sbCCe
            // 
            this.sbCCe.ImageOptions.Image = global::Aplicacao.Properties.Resources._48px_Crystal_Clear_app_korganizer;
            this.sbCCe.Location = new System.Drawing.Point(337, 434);
            this.sbCCe.Name = "sbCCe";
            this.sbCCe.Size = new System.Drawing.Size(95, 23);
            this.sbCCe.TabIndex = 13;
            this.sbCCe.Text = "CCe";
            this.sbCCe.Click += new System.EventHandler(this.sbCCe_Click);
            // 
            // sbConsultaCCe
            // 
            this.sbConsultaCCe.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbConsultaCCe.Location = new System.Drawing.Point(336, 461);
            this.sbConsultaCCe.Name = "sbConsultaCCe";
            this.sbConsultaCCe.Size = new System.Drawing.Size(95, 23);
            this.sbConsultaCCe.TabIndex = 14;
            this.sbConsultaCCe.Text = "Consulta CCe";
            this.sbConsultaCCe.Click += new System.EventHandler(this.sbConsultaCCe_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.ImageOptions.Image = global::Aplicacao.Properties.Resources._1333658965_arrow_refresh;
            this.btnResolve.Location = new System.Drawing.Point(255, 434);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(75, 23);
            this.btnResolve.TabIndex = 15;
            this.btnResolve.Text = "Re&solve";
            this.btnResolve.Visible = false;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // FormNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 495);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.sbConsultaCCe);
            this.Controls.Add(this.sbCCe);
            this.Controls.Add(this.btPreDanfe);
            this.Controls.Add(this.btEmail);
            this.Controls.Add(this.btEditarDanfe);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btReciboNFe);
            this.Controls.Add(this.btConsultaNFe);
            this.Controls.Add(this.btCancelarNFe);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btImprimirNFe);
            this.Controls.Add(this.btEnviarNFe);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota Fiscal Eletrônica";
            this.Load += new System.EventHandler(this.FormNFe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2CNPJ_CPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPessoaNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumProtocolo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumRecibo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChaveNota.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit txtTotalNota;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPessoaNome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit txtData;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btEnviarNFe;
        private DevExpress.XtraEditors.SimpleButton btImprimirNFe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtNumProtocolo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNumRecibo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtChaveNota;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btCancelarNFe;
        private DevExpress.XtraEditors.SimpleButton btConsultaNFe;
        private DevExpress.XtraEditors.SimpleButton btReciboNFe;
        private DevExpress.XtraEditors.SimpleButton btEditarDanfe;
        private DevExpress.XtraEditors.SimpleButton btEmail;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btPreDanfe;
        private DevExpress.XtraEditors.SimpleButton sbCCe;
        private DevExpress.XtraEditors.SimpleButton sbConsultaCCe;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txt2CNPJ_CPF;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnResolve;
        public DevExpress.XtraEditors.SimpleButton btFechar;
    }
}