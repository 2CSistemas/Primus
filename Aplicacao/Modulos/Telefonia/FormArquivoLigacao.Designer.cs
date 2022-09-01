namespace Aplicacao.Modulos.Telefonia
{
    partial class FormArquivoLigacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArquivoLigacao));
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoArquivo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataImportacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaminhoArquivo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcLigacoes = new DevExpress.XtraGrid.GridControl();
            this.gvLigacoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TipoUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescricaoUso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Origem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TempoSegundos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Horario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorComImposto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GeradoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataImportacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLigacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLigacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.tpPrincipal.Controls.Add(this.gcLigacoes);
            this.tpPrincipal.Controls.Add(this.txtCaminhoArquivo);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtDataImportacao);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtTipoArquivo);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(831, 446);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = null;
            this.txtCodigo.Location = new System.Drawing.Point(97, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(92, 20);
            this.txtCodigo.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(54, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Código:";
            // 
            // txtTipoArquivo
            // 
            this.txtTipoArquivo.CwkFuncaoValidacao = null;
            this.txtTipoArquivo.CwkMascara = null;
            this.txtTipoArquivo.CwkValidacao = null;
            this.txtTipoArquivo.Location = new System.Drawing.Point(349, 3);
            this.txtTipoArquivo.Name = "txtTipoArquivo";
            this.txtTipoArquivo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTipoArquivo.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoArquivo.Properties.ReadOnly = true;
            this.txtTipoArquivo.SelecionarTextoOnEnter = false;
            this.txtTipoArquivo.Size = new System.Drawing.Size(94, 20);
            this.txtTipoArquivo.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(279, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Tipo Arquivo:";
            // 
            // txtDataImportacao
            // 
            this.txtDataImportacao.CwkFuncaoValidacao = null;
            this.txtDataImportacao.CwkMascara = null;
            this.txtDataImportacao.CwkValidacao = null;
            this.txtDataImportacao.Location = new System.Drawing.Point(657, 3);
            this.txtDataImportacao.Name = "txtDataImportacao";
            this.txtDataImportacao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDataImportacao.Properties.Appearance.Options.UseBackColor = true;
            this.txtDataImportacao.Properties.ReadOnly = true;
            this.txtDataImportacao.SelecionarTextoOnEnter = false;
            this.txtDataImportacao.Size = new System.Drawing.Size(165, 20);
            this.txtDataImportacao.TabIndex = 23;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(551, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Data da Importação:";
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.CwkFuncaoValidacao = null;
            this.txtCaminhoArquivo.CwkMascara = null;
            this.txtCaminhoArquivo.CwkValidacao = null;
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(97, 29);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCaminhoArquivo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCaminhoArquivo.Properties.ReadOnly = true;
            this.txtCaminhoArquivo.SelecionarTextoOnEnter = false;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(725, 20);
            this.txtCaminhoArquivo.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Caminho Arquivo:";
            // 
            // gcLigacoes
            // 
            this.gcLigacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLigacoes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcLigacoes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcLigacoes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcLigacoes.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcLigacoes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcLigacoes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcLigacoes.Location = new System.Drawing.Point(6, 55);
            this.gcLigacoes.MainView = this.gvLigacoes;
            this.gcLigacoes.Name = "gcLigacoes";
            this.gcLigacoes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcLigacoes.Size = new System.Drawing.Size(816, 385);
            this.gcLigacoes.TabIndex = 26;
            this.gcLigacoes.UseEmbeddedNavigator = true;
            this.gcLigacoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLigacoes});
            // 
            // gvLigacoes
            // 
            this.gvLigacoes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.Empty.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvLigacoes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvLigacoes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvLigacoes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvLigacoes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvLigacoes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvLigacoes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.OddRow.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.OddRow.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvLigacoes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.Preview.Options.UseFont = true;
            this.gvLigacoes.Appearance.Preview.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoes.Appearance.Row.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvLigacoes.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoes.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvLigacoes.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvLigacoes.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvLigacoes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvLigacoes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvLigacoes.BestFitMaxRowCount = 5;
            this.gvLigacoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TipoUso,
            this.DescricaoUso,
            this.Origem,
            this.Destino,
            this.Cidade,
            this.UF,
            this.DataHora,
            this.TempoSegundos,
            this.Horario,
            this.ValorComImposto,
            this.GeradoFatura});
            this.gvLigacoes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvLigacoes.GridControl = this.gcLigacoes;
            this.gvLigacoes.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvLigacoes.Name = "gvLigacoes";
            this.gvLigacoes.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvLigacoes.OptionsBehavior.Editable = false;
            this.gvLigacoes.OptionsDetail.EnableMasterViewMode = false;
            this.gvLigacoes.OptionsView.ColumnAutoWidth = false;
            this.gvLigacoes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLigacoes.OptionsView.EnableAppearanceOddRow = true;
            this.gvLigacoes.OptionsView.ShowAutoFilterRow = true;
            this.gvLigacoes.OptionsView.ShowFooter = true;
            // 
            // TipoUso
            // 
            this.TipoUso.AppearanceHeader.Options.UseTextOptions = true;
            this.TipoUso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TipoUso.Caption = "Tipo de Uso";
            this.TipoUso.FieldName = "TipoUso";
            this.TipoUso.Name = "TipoUso";
            this.TipoUso.Visible = true;
            this.TipoUso.VisibleIndex = 0;
            this.TipoUso.Width = 80;
            // 
            // DescricaoUso
            // 
            this.DescricaoUso.AppearanceHeader.Options.UseTextOptions = true;
            this.DescricaoUso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DescricaoUso.Caption = "Descição de Uso";
            this.DescricaoUso.FieldName = "DescricaoUso";
            this.DescricaoUso.Name = "DescricaoUso";
            this.DescricaoUso.Visible = true;
            this.DescricaoUso.VisibleIndex = 1;
            this.DescricaoUso.Width = 105;
            // 
            // Origem
            // 
            this.Origem.AppearanceHeader.Options.UseTextOptions = true;
            this.Origem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Origem.Caption = "Origem";
            this.Origem.FieldName = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.Visible = true;
            this.Origem.VisibleIndex = 2;
            this.Origem.Width = 100;
            // 
            // Destino
            // 
            this.Destino.AppearanceHeader.Options.UseTextOptions = true;
            this.Destino.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Destino.Caption = "Destino";
            this.Destino.FieldName = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.Visible = true;
            this.Destino.VisibleIndex = 3;
            this.Destino.Width = 100;
            // 
            // Cidade
            // 
            this.Cidade.AppearanceHeader.Options.UseTextOptions = true;
            this.Cidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cidade.Caption = "Cidade";
            this.Cidade.FieldName = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.Visible = true;
            this.Cidade.VisibleIndex = 4;
            this.Cidade.Width = 100;
            // 
            // UF
            // 
            this.UF.AppearanceHeader.Options.UseTextOptions = true;
            this.UF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UF.Caption = "UF";
            this.UF.FieldName = "UF";
            this.UF.Name = "UF";
            this.UF.Visible = true;
            this.UF.VisibleIndex = 5;
            this.UF.Width = 40;
            // 
            // DataHora
            // 
            this.DataHora.AppearanceHeader.Options.UseTextOptions = true;
            this.DataHora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DataHora.Caption = "Data";
            this.DataHora.FieldName = "DataHora";
            this.DataHora.Name = "DataHora";
            this.DataHora.Visible = true;
            this.DataHora.VisibleIndex = 6;
            this.DataHora.Width = 100;
            // 
            // TempoSegundos
            // 
            this.TempoSegundos.AppearanceHeader.Options.UseTextOptions = true;
            this.TempoSegundos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TempoSegundos.Caption = "Tempo em Seg.";
            this.TempoSegundos.FieldName = "TempoSegundos";
            this.TempoSegundos.Name = "TempoSegundos";
            this.TempoSegundos.Visible = true;
            this.TempoSegundos.VisibleIndex = 7;
            this.TempoSegundos.Width = 105;
            // 
            // Horario
            // 
            this.Horario.AppearanceHeader.Options.UseTextOptions = true;
            this.Horario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Horario.Caption = "Horário";
            this.Horario.FieldName = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.Visible = true;
            this.Horario.VisibleIndex = 8;
            this.Horario.Width = 97;
            // 
            // ValorComImposto
            // 
            this.ValorComImposto.AppearanceCell.Options.UseTextOptions = true;
            this.ValorComImposto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ValorComImposto.Caption = "Valor com Imposto";
            this.ValorComImposto.DisplayFormat.FormatString = "P2";
            this.ValorComImposto.FieldName = "ValorComImposto";
            this.ValorComImposto.GroupFormat.FormatString = "P2";
            this.ValorComImposto.Name = "ValorComImposto";
            this.ValorComImposto.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.ValorComImposto.Visible = true;
            this.ValorComImposto.VisibleIndex = 9;
            this.ValorComImposto.Width = 100;
            // 
            // GeradoFatura
            // 
            this.GeradoFatura.Caption = "Gerado Fatura?";
            this.GeradoFatura.ColumnEdit = this.repositoryItemCheckEdit1;
            this.GeradoFatura.FieldName = "GeradoFatura";
            this.GeradoFatura.Name = "GeradoFatura";
            this.GeradoFatura.Visible = true;
            this.GeradoFatura.VisibleIndex = 10;
            this.GeradoFatura.Width = 82;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FormArquivoLigacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 505);
            this.Name = "FormArquivoLigacao";
            this.Text = "FormArquivoLigacao";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataImportacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLigacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLigacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCaminhoArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDataImportacao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtTipoArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraGrid.GridControl gcLigacoes;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvLigacoes;
        private DevExpress.XtraGrid.Columns.GridColumn TipoUso;
        private DevExpress.XtraGrid.Columns.GridColumn DescricaoUso;
        private DevExpress.XtraGrid.Columns.GridColumn Origem;
        private DevExpress.XtraGrid.Columns.GridColumn Destino;
        private DevExpress.XtraGrid.Columns.GridColumn Cidade;
        private DevExpress.XtraGrid.Columns.GridColumn UF;
        private DevExpress.XtraGrid.Columns.GridColumn DataHora;
        private DevExpress.XtraGrid.Columns.GridColumn TempoSegundos;
        private DevExpress.XtraGrid.Columns.GridColumn Horario;
        private DevExpress.XtraGrid.Columns.GridColumn ValorComImposto;
        private DevExpress.XtraGrid.Columns.GridColumn GeradoFatura;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}