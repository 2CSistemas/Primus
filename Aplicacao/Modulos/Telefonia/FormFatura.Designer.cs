namespace Aplicacao.Modulos.Telefonia
{
    partial class FormFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFatura));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtValor = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.txtVencimento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.tcServicos = new DevExpress.XtraTab.XtraTabControl();
            this.tpServico = new DevExpress.XtraTab.XtraTabPage();
            this.btExcluirServico = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarServico = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirServico = new Cwork.Utilitarios.Componentes.DevButton();
            this.btConsultarServico = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcServicos = new DevExpress.XtraGrid.GridControl();
            this.gvServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpLigacoes = new DevExpress.XtraTab.XtraTabPage();
            this.gcLigacoesf = new DevExpress.XtraGrid.GridControl();
            this.gvLigacoesf = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcServicos)).BeginInit();
            this.tcServicos.SuspendLayout();
            this.tpServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).BeginInit();
            this.tpLigacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLigacoesf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLigacoesf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
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
            this.tpPrincipal.Controls.Add(this.lkpCliente);
            this.tpPrincipal.Controls.Add(this.lkbCliente);
            this.tpPrincipal.Controls.Add(this.tcServicos);
            this.tpPrincipal.Controls.Add(this.txtReferencia);
            this.tpPrincipal.Controls.Add(this.txtDataInicial);
            this.tpPrincipal.Controls.Add(this.txtDataFinal);
            this.tpPrincipal.Controls.Add(this.txtVencimento);
            this.tpPrincipal.Controls.Add(this.txtData);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(830, 445);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(192, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Vencimento:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(224, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(67, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(111, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Código:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Cliente:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(662, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Data Final:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(681, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Valor:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(425, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Data Inicial:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(714, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.txtValor.Properties.Appearance.Options.UseBackColor = true;
            this.txtValor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtValor.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtValor.Properties.DisplayFormat.FormatString = "C2";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Precision = 2;
            this.txtValor.Properties.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(111, 20);
            this.txtValor.TabIndex = 16;
            this.txtValor.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Referência:";
            // 
            // txtData
            // 
            this.txtData.CwkFuncaoValidacao = null;
            this.txtData.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(257, 3);
            this.txtData.Name = "txtData";
            this.txtData.Obrigatorio = true;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(105, 20);
            this.txtData.TabIndex = 3;
            // 
            // txtVencimento
            // 
            this.txtVencimento.CwkFuncaoValidacao = null;
            this.txtVencimento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(257, 55);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Obrigatorio = true;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtVencimento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVencimento.Size = new System.Drawing.Size(111, 20);
            this.txtVencimento.TabIndex = 14;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.CwkFuncaoValidacao = null;
            this.txtDataFinal.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(720, 3);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Obrigatorio = true;
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(105, 20);
            this.txtDataFinal.TabIndex = 7;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.CwkFuncaoValidacao = null;
            this.txtDataInicial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(488, 3);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Obrigatorio = true;
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(105, 20);
            this.txtDataInicial.TabIndex = 5;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtReferencia.EditValue = null;
            this.txtReferencia.Location = new System.Drawing.Point(67, 55);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Obrigatorio = true;
            this.txtReferencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtReferencia.Properties.Mask.EditMask = "MM/yyyy";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtReferencia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtReferencia.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtReferencia.Properties.Leave += new System.EventHandler(this.txtReferencia_Properties_Leave);
            this.txtReferencia.Size = new System.Drawing.Size(105, 20);
            this.txtReferencia.TabIndex = 12;
            // 
            // tcServicos
            // 
            this.tcServicos.Location = new System.Drawing.Point(3, 94);
            this.tcServicos.Name = "tcServicos";
            this.tcServicos.SelectedTabPage = this.tpServico;
            this.tcServicos.Size = new System.Drawing.Size(822, 346);
            this.tcServicos.TabIndex = 17;
            this.tcServicos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpServico,
            this.tpLigacoes});
            this.tcServicos.TabStop = false;
            // 
            // tpServico
            // 
            this.tpServico.Controls.Add(this.btExcluirServico);
            this.tpServico.Controls.Add(this.btAlterarServico);
            this.tpServico.Controls.Add(this.btIncluirServico);
            this.tpServico.Controls.Add(this.btConsultarServico);
            this.tpServico.Controls.Add(this.gcServicos);
            this.tpServico.Name = "tpServico";
            this.tpServico.Size = new System.Drawing.Size(815, 318);
            this.tpServico.Text = "Serviços";
            // 
            // btExcluirServico
            // 
            this.btExcluirServico.GridControl = null;
            this.btExcluirServico.Image = ((System.Drawing.Image)(resources.GetObject("btExcluirServico.Image")));
            this.btExcluirServico.ImageIndex = 5;
            this.btExcluirServico.ImageList = this.imageList1;
            this.btExcluirServico.Location = new System.Drawing.Point(735, 289);
            this.btExcluirServico.Name = "btExcluirServico";
            this.btExcluirServico.Size = new System.Drawing.Size(75, 23);
            this.btExcluirServico.SubForm = null;
            this.btExcluirServico.TabIndex = 4;
            this.btExcluirServico.Text = "&Excluir";
            // 
            // btAlterarServico
            // 
            this.btAlterarServico.GridControl = null;
            this.btAlterarServico.Image = ((System.Drawing.Image)(resources.GetObject("btAlterarServico.Image")));
            this.btAlterarServico.ImageIndex = 4;
            this.btAlterarServico.ImageList = this.imageList1;
            this.btAlterarServico.Location = new System.Drawing.Point(656, 289);
            this.btAlterarServico.Name = "btAlterarServico";
            this.btAlterarServico.Size = new System.Drawing.Size(75, 23);
            this.btAlterarServico.SubForm = null;
            this.btAlterarServico.TabIndex = 3;
            this.btAlterarServico.Text = "&Alterar";
            // 
            // btIncluirServico
            // 
            this.btIncluirServico.GridControl = null;
            this.btIncluirServico.Image = ((System.Drawing.Image)(resources.GetObject("btIncluirServico.Image")));
            this.btIncluirServico.ImageIndex = 3;
            this.btIncluirServico.ImageList = this.imageList1;
            this.btIncluirServico.Location = new System.Drawing.Point(575, 289);
            this.btIncluirServico.Name = "btIncluirServico";
            this.btIncluirServico.Size = new System.Drawing.Size(75, 23);
            this.btIncluirServico.SubForm = null;
            this.btIncluirServico.TabIndex = 2;
            this.btIncluirServico.Text = "&Incluir";
            // 
            // btConsultarServico
            // 
            this.btConsultarServico.GridControl = null;
            this.btConsultarServico.Image = ((System.Drawing.Image)(resources.GetObject("btConsultarServico.Image")));
            this.btConsultarServico.ImageIndex = 2;
            this.btConsultarServico.ImageList = this.imageList1;
            this.btConsultarServico.Location = new System.Drawing.Point(496, 289);
            this.btConsultarServico.Name = "btConsultarServico";
            this.btConsultarServico.Size = new System.Drawing.Size(75, 23);
            this.btConsultarServico.SubForm = null;
            this.btConsultarServico.TabIndex = 1;
            this.btConsultarServico.Text = "&Consultar";
            // 
            // gcServicos
            // 
            this.gcServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcServicos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcServicos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcServicos.Location = new System.Drawing.Point(3, 3);
            this.gcServicos.MainView = this.gvServicos;
            this.gcServicos.Name = "gcServicos";
            this.gcServicos.Size = new System.Drawing.Size(809, 283);
            this.gcServicos.TabIndex = 0;
            this.gcServicos.UseEmbeddedNavigator = true;
            this.gcServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServicos});
            // 
            // gvServicos
            // 
            this.gvServicos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvServicos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.Empty.Options.UseBackColor = true;
            this.gvServicos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvServicos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvServicos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvServicos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvServicos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvServicos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Preview.Options.UseFont = true;
            this.gvServicos.Appearance.Preview.Options.UseForeColor = true;
            this.gvServicos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Row.Options.UseBackColor = true;
            this.gvServicos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvServicos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvServicos.BestFitMaxRowCount = 5;
            this.gvServicos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvServicos.GridControl = this.gcServicos;
            this.gvServicos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvServicos.Name = "gvServicos";
            this.gvServicos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvServicos.OptionsBehavior.Editable = false;
            this.gvServicos.OptionsDetail.EnableMasterViewMode = false;
            this.gvServicos.OptionsView.ColumnAutoWidth = false;
            this.gvServicos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvServicos.OptionsView.EnableAppearanceOddRow = true;
            this.gvServicos.OptionsView.ShowAutoFilterRow = true;
            this.gvServicos.OptionsView.ShowFooter = true;
            // 
            // tpLigacoes
            // 
            this.tpLigacoes.Controls.Add(this.gcLigacoesf);
            this.tpLigacoes.Name = "tpLigacoes";
            this.tpLigacoes.Size = new System.Drawing.Size(815, 318);
            this.tpLigacoes.Text = "Ligações";
            // 
            // gcLigacoesf
            // 
            this.gcLigacoesf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLigacoesf.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcLigacoesf.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcLigacoesf.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcLigacoesf.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcLigacoesf.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcLigacoesf.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcLigacoesf.Location = new System.Drawing.Point(3, 3);
            this.gcLigacoesf.MainView = this.gvLigacoesf;
            this.gcLigacoesf.Name = "gcLigacoesf";
            this.gcLigacoesf.Size = new System.Drawing.Size(809, 312);
            this.gcLigacoesf.TabIndex = 1;
            this.gcLigacoesf.UseEmbeddedNavigator = true;
            this.gcLigacoesf.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLigacoesf});
            // 
            // gvLigacoesf
            // 
            this.gvLigacoesf.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.Empty.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvLigacoesf.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvLigacoesf.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvLigacoesf.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoesf.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoesf.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoesf.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvLigacoesf.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvLigacoesf.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvLigacoesf.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoesf.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.OddRow.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.OddRow.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvLigacoesf.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.Preview.Options.UseFont = true;
            this.gvLigacoesf.Appearance.Preview.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvLigacoesf.Appearance.Row.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvLigacoesf.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoesf.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvLigacoesf.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvLigacoesf.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvLigacoesf.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvLigacoesf.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvLigacoesf.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvLigacoesf.BestFitMaxRowCount = 5;
            this.gvLigacoesf.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvLigacoesf.GridControl = this.gcLigacoesf;
            this.gvLigacoesf.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvLigacoesf.Name = "gvLigacoesf";
            this.gvLigacoesf.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvLigacoesf.OptionsBehavior.Editable = false;
            this.gvLigacoesf.OptionsDetail.EnableMasterViewMode = false;
            this.gvLigacoesf.OptionsView.ColumnAutoWidth = false;
            this.gvLigacoesf.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLigacoesf.OptionsView.EnableAppearanceOddRow = true;
            this.gvLigacoesf.OptionsView.ShowAutoFilterRow = true;
            this.gvLigacoesf.OptionsView.ShowFooter = true;
            // 
            // lkpCliente
            // 
            this.lkpCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpCliente.ButtonLookup = this.lkbCliente;
            this.lkpCliente.CamposPesquisa = new string[] {
        "Pessoa.Nome",
        "Pessoa.Codigo",
        "Pessoa.Fantasia",
        "Pessoa.CNPJ_CPF"};
            this.lkpCliente.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesAND")));
            this.lkpCliente.CamposRestricoesNOT = null;
            this.lkpCliente.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesOR")));
            this.lkpCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpCliente.ColunaTamanho = new string[] {
        "280",
        "100",
        "150",
        "110"};
            this.lkpCliente.ContextoLinq = null;
            this.lkpCliente.CwkFuncaoValidacao = null;
            this.lkpCliente.CwkMascara = null;
            this.lkpCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCliente.Exemplo = null;
            this.lkpCliente.ID = 0;
            this.lkpCliente.Join = null;
            this.lkpCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpCliente.Location = new System.Drawing.Point(67, 29);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = true;
            this.lkpCliente.Size = new System.Drawing.Size(728, 20);
            this.lkpCliente.Tabela = null;
            this.lkpCliente.TabIndex = 9;
            this.lkpCliente.TituloTelaPesquisa = null;
            this.lkpCliente.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpCliente.Where = null;
            this.lkpCliente.Leave += new System.EventHandler(this.lkpCliente_Leave);
            // 
            // lkbCliente
            // 
            this.lkbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbCliente.Location = new System.Drawing.Point(801, 29);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.TabIndex = 10;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // FormFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 505);
            this.Name = "FormFatura";
            this.Text = "FormFatura";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcServicos)).EndInit();
            this.tcServicos.ResumeLayout(false);
            this.tpServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).EndInit();
            this.tpLigacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLigacoesf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLigacoesf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataInicial;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataFinal;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtVencimento;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtData;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtReferencia;
        private DevExpress.XtraTab.XtraTabControl tcServicos;
        private DevExpress.XtraTab.XtraTabPage tpServico;
        private DevExpress.XtraTab.XtraTabPage tpLigacoes;
        public DevExpress.XtraGrid.GridControl gcServicos;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvServicos;
        public DevExpress.XtraGrid.GridControl gcLigacoesf;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvLigacoesf;
        protected internal Cwork.Utilitarios.Componentes.DevButton btExcluirServico;
        protected internal Cwork.Utilitarios.Componentes.DevButton btAlterarServico;
        protected internal Cwork.Utilitarios.Componentes.DevButton btIncluirServico;
        protected internal Cwork.Utilitarios.Componentes.DevButton btConsultarServico;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
    }
}