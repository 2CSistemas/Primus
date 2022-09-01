namespace Aplicacao
{
    partial class FormFaturamentoAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturamentoAtendimento));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcFaturamentoAtendimentos = new DevExpress.XtraGrid.GridControl();
            this.gvFaturamentoAtendimentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclServico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpServico = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gclQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHorasAtendimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclHorasFaturamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDesconto = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gclDespesasAdicionais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDespesasAdicionais = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gclObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meObservacoes = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gclTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclSelecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturamentoAtendimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaturamentoAtendimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDespesasAdicionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meObservacoes)).BeginInit();
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
            this.tpPrincipal.Controls.Add(this.panelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(831, 446);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcFaturamentoAtendimentos);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(831, 446);
            this.panelControl1.TabIndex = 30;
            // 
            // gcFaturamentoAtendimentos
            // 
            this.gcFaturamentoAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFaturamentoAtendimentos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFaturamentoAtendimentos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcFaturamentoAtendimentos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcFaturamentoAtendimentos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcFaturamentoAtendimentos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFaturamentoAtendimentos.Location = new System.Drawing.Point(2, 2);
            this.gcFaturamentoAtendimentos.MainView = this.gvFaturamentoAtendimentos;
            this.gcFaturamentoAtendimentos.Name = "gcFaturamentoAtendimentos";
            this.gcFaturamentoAtendimentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDesconto,
            this.txtDespesasAdicionais,
            this.lkpServico,
            this.meObservacoes,
            this.repositoryItemCheckEdit1});
            this.gcFaturamentoAtendimentos.Size = new System.Drawing.Size(827, 442);
            this.gcFaturamentoAtendimentos.TabIndex = 28;
            this.gcFaturamentoAtendimentos.UseEmbeddedNavigator = true;
            this.gcFaturamentoAtendimentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFaturamentoAtendimentos});
            this.gcFaturamentoAtendimentos.Leave += new System.EventHandler(this.gcFaturamentoAtendimentos_Leave);
            // 
            // gvFaturamentoAtendimentos
            // 
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaturamentoAtendimentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaturamentoAtendimentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaturamentoAtendimentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.RoyalBlue;
            this.gvFaturamentoAtendimentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturamentoAtendimentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaturamentoAtendimentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaturamentoAtendimentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaturamentoAtendimentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturamentoAtendimentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFaturamentoAtendimentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFaturamentoAtendimentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.Preview.Options.UseFont = true;
            this.gvFaturamentoAtendimentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturamentoAtendimentos.Appearance.Row.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.Row.Options.UseTextOptions = true;
            this.gvFaturamentoAtendimentos.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvFaturamentoAtendimentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFaturamentoAtendimentos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFaturamentoAtendimentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFaturamentoAtendimentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFaturamentoAtendimentos.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gvFaturamentoAtendimentos.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvFaturamentoAtendimentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclSelecionado,
            this.gclCliente,
            this.gclServico,
            this.gclQuantidade,
            this.gclHorasAtendimento,
            this.gclHorasFaturamento,
            this.gclValor,
            this.gclDesconto,
            this.gclDespesasAdicionais,
            this.gclObservacao,
            this.gclTotal});
            this.gvFaturamentoAtendimentos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvFaturamentoAtendimentos.GridControl = this.gcFaturamentoAtendimentos;
            this.gvFaturamentoAtendimentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFaturamentoAtendimentos.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvFaturamentoAtendimentos.Name = "gvFaturamentoAtendimentos";
            this.gvFaturamentoAtendimentos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvFaturamentoAtendimentos.OptionsCustomization.AllowGroup = false;
            this.gvFaturamentoAtendimentos.OptionsDetail.EnableMasterViewMode = false;
            this.gvFaturamentoAtendimentos.OptionsSelection.MultiSelect = true;
            this.gvFaturamentoAtendimentos.OptionsView.ColumnAutoWidth = false;
            this.gvFaturamentoAtendimentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFaturamentoAtendimentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvFaturamentoAtendimentos.OptionsView.RowAutoHeight = true;
            this.gvFaturamentoAtendimentos.OptionsView.ShowGroupPanel = false;
            this.gvFaturamentoAtendimentos.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gvFaturamentoAtendimentos_BeforeLeaveRow);
            this.gvFaturamentoAtendimentos.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvFaturamentoAtendimentos_InvalidRowException);
            this.gvFaturamentoAtendimentos.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvFaturamentoAtendimentos_ValidateRow);
            // 
            // gclCliente
            // 
            this.gclCliente.Caption = "Cliente";
            this.gclCliente.FieldName = "Cliente";
            this.gclCliente.Name = "gclCliente";
            this.gclCliente.OptionsColumn.AllowEdit = false;
            this.gclCliente.OptionsColumn.AllowFocus = false;
            this.gclCliente.Visible = true;
            this.gclCliente.VisibleIndex = 1;
            this.gclCliente.Width = 250;
            // 
            // gclServico
            // 
            this.gclServico.Caption = "Serviço";
            this.gclServico.ColumnEdit = this.lkpServico;
            this.gclServico.FieldName = "Servico";
            this.gclServico.Name = "gclServico";
            this.gclServico.Visible = true;
            this.gclServico.VisibleIndex = 2;
            this.gclServico.Width = 250;
            // 
            // lkpServico
            // 
            this.lkpServico.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lkpServico.AutoHeight = false;
            this.lkpServico.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpServico.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", 100, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", 250, "Descrição")});
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.NullText = "Escolha um Serviço";
            this.lkpServico.NullValuePrompt = "Escolha um Serviço";
            this.lkpServico.NullValuePromptShowForEmptyValue = true;
            // 
            // gclQuantidade
            // 
            this.gclQuantidade.Caption = "Quantidade";
            this.gclQuantidade.FieldName = "Quantidade";
            this.gclQuantidade.Name = "gclQuantidade";
            this.gclQuantidade.OptionsColumn.AllowEdit = false;
            this.gclQuantidade.OptionsColumn.AllowFocus = false;
            this.gclQuantidade.Visible = true;
            this.gclQuantidade.VisibleIndex = 3;
            this.gclQuantidade.Width = 125;
            // 
            // gclHorasAtendimento
            // 
            this.gclHorasAtendimento.Caption = "Horas Atendimento";
            this.gclHorasAtendimento.FieldName = "HorasDeAtendimento";
            this.gclHorasAtendimento.Name = "gclHorasAtendimento";
            this.gclHorasAtendimento.OptionsColumn.AllowEdit = false;
            this.gclHorasAtendimento.OptionsColumn.AllowFocus = false;
            this.gclHorasAtendimento.Visible = true;
            this.gclHorasAtendimento.VisibleIndex = 4;
            this.gclHorasAtendimento.Width = 150;
            // 
            // gclHorasFaturamento
            // 
            this.gclHorasFaturamento.Caption = "Horas Faturamento";
            this.gclHorasFaturamento.FieldName = "HorasDeFaturamento";
            this.gclHorasFaturamento.Name = "gclHorasFaturamento";
            this.gclHorasFaturamento.OptionsColumn.AllowEdit = false;
            this.gclHorasFaturamento.OptionsColumn.AllowFocus = false;
            this.gclHorasFaturamento.Visible = true;
            this.gclHorasFaturamento.VisibleIndex = 5;
            this.gclHorasFaturamento.Width = 150;
            // 
            // gclValor
            // 
            this.gclValor.Caption = "Valor";
            this.gclValor.DisplayFormat.FormatString = "c2";
            this.gclValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gclValor.FieldName = "Valor";
            this.gclValor.Name = "gclValor";
            this.gclValor.OptionsColumn.AllowEdit = false;
            this.gclValor.OptionsColumn.AllowFocus = false;
            this.gclValor.Visible = true;
            this.gclValor.VisibleIndex = 6;
            this.gclValor.Width = 100;
            // 
            // gclDesconto
            // 
            this.gclDesconto.Caption = "Desconto";
            this.gclDesconto.ColumnEdit = this.txtDesconto;
            this.gclDesconto.DisplayFormat.FormatString = "c2";
            this.gclDesconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gclDesconto.FieldName = "Desconto";
            this.gclDesconto.Name = "gclDesconto";
            this.gclDesconto.Visible = true;
            this.gclDesconto.VisibleIndex = 7;
            this.gclDesconto.Width = 100;
            // 
            // txtDesconto
            // 
            this.txtDesconto.AutoHeight = false;
            this.txtDesconto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDesconto.DisplayFormat.FormatString = "c2";
            this.txtDesconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDesconto.EditFormat.FormatString = "c2";
            this.txtDesconto.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Precision = 2;
            // 
            // gclDespesasAdicionais
            // 
            this.gclDespesasAdicionais.Caption = "Adicionais (Desp. Viagens e outros)";
            this.gclDespesasAdicionais.ColumnEdit = this.txtDespesasAdicionais;
            this.gclDespesasAdicionais.DisplayFormat.FormatString = "c2";
            this.gclDespesasAdicionais.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gclDespesasAdicionais.FieldName = "DespesasAdicionais";
            this.gclDespesasAdicionais.Name = "gclDespesasAdicionais";
            this.gclDespesasAdicionais.Visible = true;
            this.gclDespesasAdicionais.VisibleIndex = 8;
            this.gclDespesasAdicionais.Width = 250;
            // 
            // txtDespesasAdicionais
            // 
            this.txtDespesasAdicionais.AutoHeight = false;
            this.txtDespesasAdicionais.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDespesasAdicionais.DisplayFormat.FormatString = "c2";
            this.txtDespesasAdicionais.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDespesasAdicionais.EditFormat.FormatString = "c2";
            this.txtDespesasAdicionais.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDespesasAdicionais.Name = "txtDespesasAdicionais";
            this.txtDespesasAdicionais.Precision = 2;
            // 
            // gclObservacao
            // 
            this.gclObservacao.Caption = "Observações";
            this.gclObservacao.ColumnEdit = this.meObservacoes;
            this.gclObservacao.FieldName = "Observacao";
            this.gclObservacao.Name = "gclObservacao";
            this.gclObservacao.Visible = true;
            this.gclObservacao.VisibleIndex = 9;
            this.gclObservacao.Width = 200;
            // 
            // meObservacoes
            // 
            this.meObservacoes.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.meObservacoes.MaxLength = 200;
            this.meObservacoes.Name = "meObservacoes";
            this.meObservacoes.NullText = "Observações";
            this.meObservacoes.NullValuePrompt = "Observações";
            this.meObservacoes.NullValuePromptShowForEmptyValue = true;
            // 
            // gclTotal
            // 
            this.gclTotal.Caption = "Total";
            this.gclTotal.DisplayFormat.FormatString = "c2";
            this.gclTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gclTotal.FieldName = "Total";
            this.gclTotal.Name = "gclTotal";
            this.gclTotal.OptionsColumn.AllowEdit = false;
            this.gclTotal.OptionsColumn.AllowFocus = false;
            this.gclTotal.Visible = true;
            this.gclTotal.VisibleIndex = 10;
            this.gclTotal.Width = 100;
            // 
            // gclSelecionado
            // 
            this.gclSelecionado.Caption = "Selecionado";
            this.gclSelecionado.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gclSelecionado.FieldName = "Selecionado";
            this.gclSelecionado.Name = "gclSelecionado";
            this.gclSelecionado.Visible = true;
            this.gclSelecionado.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FormFaturamentoAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(861, 505);
            this.Name = "FormFaturamentoAtendimento";
            this.Text = "Faturamento de Atendimentos";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturamentoAtendimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaturamentoAtendimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDespesasAdicionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meObservacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcFaturamentoAtendimentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFaturamentoAtendimentos;
        private DevExpress.XtraGrid.Columns.GridColumn gclCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gclServico;
        private DevExpress.XtraGrid.Columns.GridColumn gclQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn gclHorasAtendimento;
        private DevExpress.XtraGrid.Columns.GridColumn gclHorasFaturamento;
        private DevExpress.XtraGrid.Columns.GridColumn gclValor;
        private DevExpress.XtraGrid.Columns.GridColumn gclDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn gclDespesasAdicionais;
        private DevExpress.XtraGrid.Columns.GridColumn gclTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit txtDesconto;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit txtDespesasAdicionais;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkpServico;
        private DevExpress.XtraGrid.Columns.GridColumn gclObservacao;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit meObservacoes;
        private DevExpress.XtraGrid.Columns.GridColumn gclSelecionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
