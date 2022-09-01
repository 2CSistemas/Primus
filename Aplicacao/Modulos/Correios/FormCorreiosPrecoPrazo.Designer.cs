namespace Aplicacao.Modulos.Correios
{
    partial class FormCorreiosPrecoPrazo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorreiosPrecoPrazo));
            this.sbGeraVolumes = new DevExpress.XtraEditors.SimpleButton();
            this.seVolumes = new DevExpress.XtraEditors.SpinEdit();
            this.lbVolumes = new DevExpress.XtraEditors.LabelControl();
            this.gcCadastroVolumes = new DevExpress.XtraGrid.GridControl();
            this.gvCadastroVolumes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Largura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seLargura = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Altura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seAltura = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Comprimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seComprimento = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Diametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seDiametro = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sePeso = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ValorDeclarado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seValorDeclarado = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.FormatoPacoteTransporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpFormato = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaoPropria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbMaoPropria = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.AvisoRecebimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbAvisoRecebimento = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seVolumes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCadastroVolumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCadastroVolumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seComprimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValorDeclarado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFormato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaoPropria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAvisoRecebimento)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 380);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(831, 380);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(912, 380);
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
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
            this.tpPrincipal.Controls.Add(this.gcCadastroVolumes);
            this.tpPrincipal.Controls.Add(this.sbGeraVolumes);
            this.tpPrincipal.Controls.Add(this.seVolumes);
            this.tpPrincipal.Controls.Add(this.lbVolumes);
            this.tpPrincipal.Size = new System.Drawing.Size(969, 356);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(975, 362);
            // 
            // sbGeraVolumes
            // 
            this.sbGeraVolumes.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbGeraVolumes.Location = new System.Drawing.Point(166, 3);
            this.sbGeraVolumes.Name = "sbGeraVolumes";
            this.sbGeraVolumes.Size = new System.Drawing.Size(75, 20);
            this.sbGeraVolumes.TabIndex = 26;
            this.sbGeraVolumes.Text = "Gerar";
            this.sbGeraVolumes.Click += new System.EventHandler(this.sbGeraVolumes_Click);
            // 
            // seVolumes
            // 
            this.seVolumes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seVolumes.Location = new System.Drawing.Point(60, 3);
            this.seVolumes.Name = "seVolumes";
            this.seVolumes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seVolumes.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seVolumes.Properties.NullText = "0";
            this.seVolumes.Size = new System.Drawing.Size(100, 20);
            this.seVolumes.TabIndex = 25;
            // 
            // lbVolumes
            // 
            this.lbVolumes.Location = new System.Drawing.Point(11, 6);
            this.lbVolumes.Name = "lbVolumes";
            this.lbVolumes.Size = new System.Drawing.Size(43, 13);
            this.lbVolumes.TabIndex = 24;
            this.lbVolumes.Text = "Volumes:";
            // 
            // gcCadastroVolumes
            // 
            this.gcCadastroVolumes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcCadastroVolumes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcCadastroVolumes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcCadastroVolumes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcCadastroVolumes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcCadastroVolumes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcCadastroVolumes.Location = new System.Drawing.Point(0, 32);
            this.gcCadastroVolumes.MainView = this.gvCadastroVolumes;
            this.gcCadastroVolumes.Name = "gcCadastroVolumes";
            this.gcCadastroVolumes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbMaoPropria,
            this.cbAvisoRecebimento,
            this.lkpFormato,
            this.seLargura,
            this.seAltura,
            this.seComprimento,
            this.seDiametro,
            this.sePeso,
            this.seValorDeclarado});
            this.gcCadastroVolumes.Size = new System.Drawing.Size(969, 324);
            this.gcCadastroVolumes.TabIndex = 27;
            this.gcCadastroVolumes.UseEmbeddedNavigator = true;
            this.gcCadastroVolumes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCadastroVolumes});
            // 
            // gvCadastroVolumes
            // 
            this.gvCadastroVolumes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.Empty.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCadastroVolumes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCadastroVolumes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCadastroVolumes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCadastroVolumes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCadastroVolumes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCadastroVolumes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCadastroVolumes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCadastroVolumes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCadastroVolumes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvCadastroVolumes.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvCadastroVolumes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.Preview.Options.UseFont = true;
            this.gvCadastroVolumes.Appearance.Preview.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCadastroVolumes.Appearance.Row.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvCadastroVolumes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCadastroVolumes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCadastroVolumes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvCadastroVolumes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvCadastroVolumes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Largura,
            this.Altura,
            this.Comprimento,
            this.Diametro,
            this.Peso,
            this.ValorDeclarado,
            this.FormatoPacoteTransporte,
            this.MaoPropria,
            this.AvisoRecebimento});
            this.gvCadastroVolumes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvCadastroVolumes.GridControl = this.gcCadastroVolumes;
            this.gvCadastroVolumes.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvCadastroVolumes.Name = "gvCadastroVolumes";
            this.gvCadastroVolumes.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvCadastroVolumes.OptionsCustomization.AllowFilter = false;
            this.gvCadastroVolumes.OptionsCustomization.AllowSort = false;
            this.gvCadastroVolumes.OptionsDetail.EnableMasterViewMode = false;
            this.gvCadastroVolumes.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvCadastroVolumes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCadastroVolumes.OptionsView.EnableAppearanceOddRow = true;
            this.gvCadastroVolumes.OptionsView.ShowGroupPanel = false;
            // 
            // Largura
            // 
            this.Largura.AppearanceHeader.Options.UseTextOptions = true;
            this.Largura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Largura.Caption = "Largura (cm)";
            this.Largura.ColumnEdit = this.seLargura;
            this.Largura.DisplayFormat.FormatString = "N2";
            this.Largura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Largura.FieldName = "NVlLargura";
            this.Largura.Name = "Largura";
            this.Largura.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Largura.Visible = true;
            this.Largura.VisibleIndex = 0;
            this.Largura.Width = 105;
            // 
            // seLargura
            // 
            this.seLargura.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.seLargura.AutoHeight = false;
            this.seLargura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seLargura.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seLargura.Name = "seLargura";
            this.seLargura.NullText = "0";
            this.seLargura.NullValuePrompt = "0";
            // 
            // Altura
            // 
            this.Altura.AppearanceHeader.Options.UseTextOptions = true;
            this.Altura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Altura.Caption = "Altura (cm)";
            this.Altura.ColumnEdit = this.seAltura;
            this.Altura.DisplayFormat.FormatString = "N2";
            this.Altura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Altura.FieldName = "NVlAltura";
            this.Altura.Name = "Altura";
            this.Altura.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Altura.Visible = true;
            this.Altura.VisibleIndex = 1;
            this.Altura.Width = 105;
            // 
            // seAltura
            // 
            this.seAltura.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.seAltura.AutoHeight = false;
            this.seAltura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seAltura.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seAltura.Name = "seAltura";
            this.seAltura.NullText = "0";
            this.seAltura.NullValuePrompt = "0";
            // 
            // Comprimento
            // 
            this.Comprimento.AppearanceHeader.Options.UseTextOptions = true;
            this.Comprimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Comprimento.Caption = "Comprimento (cm)";
            this.Comprimento.ColumnEdit = this.seComprimento;
            this.Comprimento.DisplayFormat.FormatString = "N2";
            this.Comprimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Comprimento.FieldName = "NVlComprimento";
            this.Comprimento.Name = "Comprimento";
            this.Comprimento.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Comprimento.Visible = true;
            this.Comprimento.VisibleIndex = 2;
            this.Comprimento.Width = 105;
            // 
            // seComprimento
            // 
            this.seComprimento.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.seComprimento.AutoHeight = false;
            this.seComprimento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seComprimento.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seComprimento.Name = "seComprimento";
            this.seComprimento.NullText = "0";
            this.seComprimento.NullValuePrompt = "0";
            // 
            // Diametro
            // 
            this.Diametro.AppearanceHeader.Options.UseTextOptions = true;
            this.Diametro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Diametro.Caption = "Diâmetro (cm)";
            this.Diametro.ColumnEdit = this.seDiametro;
            this.Diametro.DisplayFormat.FormatString = "N2";
            this.Diametro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Diametro.FieldName = "NVlDiametro";
            this.Diametro.Name = "Diametro";
            this.Diametro.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Diametro.Visible = true;
            this.Diametro.VisibleIndex = 3;
            this.Diametro.Width = 105;
            // 
            // seDiametro
            // 
            this.seDiametro.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.seDiametro.AutoHeight = false;
            this.seDiametro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seDiametro.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seDiametro.Name = "seDiametro";
            this.seDiametro.NullText = "0";
            this.seDiametro.NullValuePrompt = "0";
            // 
            // Peso
            // 
            this.Peso.AppearanceHeader.Options.UseTextOptions = true;
            this.Peso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Peso.Caption = "Peso (kg)";
            this.Peso.ColumnEdit = this.sePeso;
            this.Peso.DisplayFormat.FormatString = "N3";
            this.Peso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Peso.FieldName = "NVlPeso";
            this.Peso.Name = "Peso";
            this.Peso.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Peso.Visible = true;
            this.Peso.VisibleIndex = 4;
            this.Peso.Width = 105;
            // 
            // sePeso
            // 
            this.sePeso.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.sePeso.AutoHeight = false;
            this.sePeso.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.sePeso.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sePeso.Name = "sePeso";
            this.sePeso.NullText = "0";
            this.sePeso.NullValuePrompt = "0";
            // 
            // ValorDeclarado
            // 
            this.ValorDeclarado.AppearanceHeader.Options.UseTextOptions = true;
            this.ValorDeclarado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ValorDeclarado.Caption = "Valor Declarado (R$)";
            this.ValorDeclarado.ColumnEdit = this.seValorDeclarado;
            this.ValorDeclarado.DisplayFormat.FormatString = "C2";
            this.ValorDeclarado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ValorDeclarado.FieldName = "NVlValorDeclarado";
            this.ValorDeclarado.Name = "ValorDeclarado";
            this.ValorDeclarado.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.ValorDeclarado.Visible = true;
            this.ValorDeclarado.VisibleIndex = 5;
            this.ValorDeclarado.Width = 110;
            // 
            // seValorDeclarado
            // 
            this.seValorDeclarado.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.seValorDeclarado.AutoHeight = false;
            this.seValorDeclarado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seValorDeclarado.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seValorDeclarado.Name = "seValorDeclarado";
            this.seValorDeclarado.NullText = "0";
            this.seValorDeclarado.NullValuePrompt = "0";
            // 
            // FormatoPacoteTransporte
            // 
            this.FormatoPacoteTransporte.AppearanceHeader.Options.UseTextOptions = true;
            this.FormatoPacoteTransporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FormatoPacoteTransporte.Caption = "Formato";
            this.FormatoPacoteTransporte.ColumnEdit = this.lkpFormato;
            this.FormatoPacoteTransporte.FieldName = "FormatoPacoteTransporte";
            this.FormatoPacoteTransporte.Name = "FormatoPacoteTransporte";
            this.FormatoPacoteTransporte.Visible = true;
            this.FormatoPacoteTransporte.VisibleIndex = 6;
            this.FormatoPacoteTransporte.Width = 150;
            // 
            // lkpFormato
            // 
            this.lkpFormato.AutoHeight = false;
            this.lkpFormato.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkpFormato.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpFormato.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", 50, "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", 100, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", 300, "Descrição")});
            this.lkpFormato.Name = "lkpFormato";
            this.lkpFormato.NullText = "Escolha um Formato";
            this.lkpFormato.NullValuePrompt = "Escolha um Formato";
            // 
            // MaoPropria
            // 
            this.MaoPropria.AppearanceHeader.Options.UseTextOptions = true;
            this.MaoPropria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaoPropria.Caption = "Mão Própria";
            this.MaoPropria.ColumnEdit = this.cbMaoPropria;
            this.MaoPropria.FieldName = "SCdMaoPropria";
            this.MaoPropria.Name = "MaoPropria";
            this.MaoPropria.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MaoPropria.Visible = true;
            this.MaoPropria.VisibleIndex = 7;
            this.MaoPropria.Width = 80;
            // 
            // cbMaoPropria
            // 
            this.cbMaoPropria.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbMaoPropria.AutoHeight = false;
            this.cbMaoPropria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMaoPropria.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cbMaoPropria.Name = "cbMaoPropria";
            this.cbMaoPropria.NullText = "Não";
            this.cbMaoPropria.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // AvisoRecebimento
            // 
            this.AvisoRecebimento.AppearanceHeader.Options.UseTextOptions = true;
            this.AvisoRecebimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AvisoRecebimento.Caption = "Aviso de Recebimento";
            this.AvisoRecebimento.ColumnEdit = this.cbAvisoRecebimento;
            this.AvisoRecebimento.FieldName = "SCdAvisoRecebimento";
            this.AvisoRecebimento.Name = "AvisoRecebimento";
            this.AvisoRecebimento.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.AvisoRecebimento.Visible = true;
            this.AvisoRecebimento.VisibleIndex = 8;
            this.AvisoRecebimento.Width = 80;
            // 
            // cbAvisoRecebimento
            // 
            this.cbAvisoRecebimento.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbAvisoRecebimento.AutoHeight = false;
            this.cbAvisoRecebimento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAvisoRecebimento.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cbAvisoRecebimento.Name = "cbAvisoRecebimento";
            this.cbAvisoRecebimento.NullText = "Não";
            this.cbAvisoRecebimento.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // FormCorreiosPrecoPrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 415);
            this.Name = "FormCorreiosPrecoPrazo";
            this.Text = "Cadastro de Volumes";
            this.Shown += new System.EventHandler(this.FormCorreiosPrecoPrazo_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCorreiosPrecoPrazo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seVolumes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCadastroVolumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCadastroVolumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seComprimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDiametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seValorDeclarado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFormato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaoPropria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAvisoRecebimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbGeraVolumes;
        private DevExpress.XtraEditors.SpinEdit seVolumes;
        private DevExpress.XtraEditors.LabelControl lbVolumes;
        private DevExpress.XtraGrid.GridControl gcCadastroVolumes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCadastroVolumes;
        private DevExpress.XtraGrid.Columns.GridColumn Largura;
        private DevExpress.XtraGrid.Columns.GridColumn Altura;
        private DevExpress.XtraGrid.Columns.GridColumn Comprimento;
        private DevExpress.XtraGrid.Columns.GridColumn Diametro;
        private DevExpress.XtraGrid.Columns.GridColumn Peso;
        private DevExpress.XtraGrid.Columns.GridColumn ValorDeclarado;
        private DevExpress.XtraGrid.Columns.GridColumn FormatoPacoteTransporte;
        private DevExpress.XtraGrid.Columns.GridColumn MaoPropria;
        private DevExpress.XtraGrid.Columns.GridColumn AvisoRecebimento;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbMaoPropria;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbAvisoRecebimento;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkpFormato;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seLargura;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seAltura;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seComprimento;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seDiametro;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit sePeso;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seValorDeclarado;
    }
}