namespace Aplicacao
{
    public partial class FormCondicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCondicao));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.chbDivide = new DevExpress.XtraEditors.CheckEdit();
            this.txtQtParcela = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.gridCondicaoParcelas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btExcluirParcelas = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarParcelas = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirParcelas = new Cwork.Utilitarios.Componentes.DevButton();
            this.btConsultarParcelas = new Cwork.Utilitarios.Componentes.DevButton();
            this.cbVencimentoFeriado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoVariacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVariacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.chbHabilitaCondicaoPDVDelivery = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDivide.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtParcela.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCondicaoParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVencimentoFeriado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoVariacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVariacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbHabilitaCondicaoPDVDelivery.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 434);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(425, 434);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(506, 434);
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
            this.tpPrincipal.Controls.Add(this.chbHabilitaCondicaoPDVDelivery);
            this.tpPrincipal.Controls.Add(this.label7);
            this.tpPrincipal.Controls.Add(this.txtVariacao);
            this.tpPrincipal.Controls.Add(this.cbTipoVariacao);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.label6);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.cbVencimentoFeriado);
            this.tpPrincipal.Controls.Add(this.btIncluirParcelas);
            this.tpPrincipal.Controls.Add(this.btAlterarParcelas);
            this.tpPrincipal.Controls.Add(this.btExcluirParcelas);
            this.tpPrincipal.Controls.Add(this.btConsultarParcelas);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.gridCondicaoParcelas);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.chbDivide);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.txtQtParcela);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(563, 410);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(569, 416);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeralInteiro;
            this.txtCodigo.Location = new System.Drawing.Point(75, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(75, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.SelecionarTextoOnEnter = true;
            this.txtNome.Size = new System.Drawing.Size(474, 20);
            this.txtNome.TabIndex = 5;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(416, 59);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 13);
            this.labelControl11.TabIndex = 9;
            this.labelControl11.Text = "Variação:";
            // 
            // chbDivide
            // 
            this.chbDivide.Location = new System.Drawing.Point(171, 56);
            this.chbDivide.Name = "chbDivide";
            this.chbDivide.Properties.Caption = "Divide";
            this.chbDivide.Properties.ValueChecked = 1;
            this.chbDivide.Properties.ValueUnchecked = 0;
            this.chbDivide.Size = new System.Drawing.Size(75, 19);
            this.chbDivide.TabIndex = 8;
            // 
            // txtQtParcela
            // 
            this.txtQtParcela.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQtParcela.Location = new System.Drawing.Point(75, 55);
            this.txtQtParcela.Name = "txtQtParcela";
            this.txtQtParcela.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtQtParcela.Properties.Mask.EditMask = "\\d{1,4}";
            this.txtQtParcela.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtQtParcela.Properties.Mask.ShowPlaceHolders = false;
            this.txtQtParcela.Size = new System.Drawing.Size(90, 20);
            this.txtQtParcela.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qt. Parcelas:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gridCondicaoParcelas
            // 
            this.gridCondicaoParcelas.Location = new System.Drawing.Point(75, 217);
            this.gridCondicaoParcelas.MainView = this.gridView1;
            this.gridCondicaoParcelas.Name = "gridCondicaoParcelas";
            this.gridCondicaoParcelas.Size = new System.Drawing.Size(474, 152);
            this.gridCondicaoParcelas.TabIndex = 14;
            this.gridCondicaoParcelas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridCondicaoParcelas.DataSourceChanged += new System.EventHandler(this.gridCondicaoParcelas_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridCondicaoParcelas;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Parcelas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btExcluirParcelas
            // 
            this.btExcluirParcelas.GridControl = null;
            this.btExcluirParcelas.GridControlType = null;
            this.btExcluirParcelas.GridControlTypeParams = null;
            this.btExcluirParcelas.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirParcelas.Location = new System.Drawing.Point(474, 375);
            this.btExcluirParcelas.Name = "btExcluirParcelas";
            this.btExcluirParcelas.Size = new System.Drawing.Size(75, 23);
            this.btExcluirParcelas.SubForm = null;
            this.btExcluirParcelas.SubFormType = null;
            this.btExcluirParcelas.SubFormTypeParams = null;
            this.btExcluirParcelas.TabIndex = 18;
            this.btExcluirParcelas.TabStop = false;
            this.btExcluirParcelas.Text = "&Excluir";
            // 
            // btAlterarParcelas
            // 
            this.btAlterarParcelas.GridControl = null;
            this.btAlterarParcelas.GridControlType = null;
            this.btAlterarParcelas.GridControlTypeParams = null;
            this.btAlterarParcelas.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarParcelas.Location = new System.Drawing.Point(393, 375);
            this.btAlterarParcelas.Name = "btAlterarParcelas";
            this.btAlterarParcelas.Size = new System.Drawing.Size(75, 23);
            this.btAlterarParcelas.SubForm = null;
            this.btAlterarParcelas.SubFormType = null;
            this.btAlterarParcelas.SubFormTypeParams = null;
            this.btAlterarParcelas.TabIndex = 17;
            this.btAlterarParcelas.TabStop = false;
            this.btAlterarParcelas.Text = "&Alterar";
            // 
            // btIncluirParcelas
            // 
            this.btIncluirParcelas.GridControl = null;
            this.btIncluirParcelas.GridControlType = null;
            this.btIncluirParcelas.GridControlTypeParams = null;
            this.btIncluirParcelas.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirParcelas.Location = new System.Drawing.Point(312, 375);
            this.btIncluirParcelas.Name = "btIncluirParcelas";
            this.btIncluirParcelas.Size = new System.Drawing.Size(75, 23);
            this.btIncluirParcelas.SubForm = null;
            this.btIncluirParcelas.SubFormType = null;
            this.btIncluirParcelas.SubFormTypeParams = null;
            this.btIncluirParcelas.TabIndex = 16;
            this.btIncluirParcelas.TabStop = false;
            this.btIncluirParcelas.Text = "&Incluir";
            // 
            // btConsultarParcelas
            // 
            this.btConsultarParcelas.GridControl = null;
            this.btConsultarParcelas.GridControlType = null;
            this.btConsultarParcelas.GridControlTypeParams = null;
            this.btConsultarParcelas.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarParcelas.Location = new System.Drawing.Point(231, 375);
            this.btConsultarParcelas.Name = "btConsultarParcelas";
            this.btConsultarParcelas.Size = new System.Drawing.Size(75, 23);
            this.btConsultarParcelas.SubForm = null;
            this.btConsultarParcelas.SubFormType = null;
            this.btConsultarParcelas.SubFormTypeParams = null;
            this.btConsultarParcelas.TabIndex = 15;
            this.btConsultarParcelas.TabStop = false;
            this.btConsultarParcelas.Text = "&Consultar";
            // 
            // cbVencimentoFeriado
            // 
            this.cbVencimentoFeriado.EditValue = "0 | No dia";
            this.cbVencimentoFeriado.Location = new System.Drawing.Point(374, 3);
            this.cbVencimentoFeriado.Name = "cbVencimentoFeriado";
            this.cbVencimentoFeriado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVencimentoFeriado.Properties.Items.AddRange(new object[] {
            "0 | Vencimento original",
            "1 | Próximo dia útil",
            "2 | Dia útil anterior"});
            this.cbVencimentoFeriado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbVencimentoFeriado.Size = new System.Drawing.Size(175, 20);
            this.cbVencimentoFeriado.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Configuração Vencimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(75, 104);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(474, 97);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descrição:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbTipoVariacao
            // 
            this.cbTipoVariacao.Location = new System.Drawing.Point(328, 55);
            this.cbTipoVariacao.Name = "cbTipoVariacao";
            this.cbTipoVariacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoVariacao.Properties.Items.AddRange(new object[] {
            "Percentual",
            "Valor"});
            this.cbTipoVariacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoVariacao.Size = new System.Drawing.Size(74, 20);
            this.cbTipoVariacao.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(254, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Tipo Variação:";
            // 
            // txtVariacao
            // 
            this.txtVariacao.CwkFuncaoValidacao = null;
            this.txtVariacao.CwkMascara = null;
            this.txtVariacao.CwkValidacao = null;
            this.txtVariacao.Location = new System.Drawing.Point(467, 56);
            this.txtVariacao.Name = "txtVariacao";
            this.txtVariacao.SelecionarTextoOnEnter = true;
            this.txtVariacao.Size = new System.Drawing.Size(82, 20);
            this.txtVariacao.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Hab.Condição:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbHabilitaCondicaoPDVDelivery
            // 
            this.chbHabilitaCondicaoPDVDelivery.EditValue = 0;
            this.chbHabilitaCondicaoPDVDelivery.Location = new System.Drawing.Point(83, 79);
            this.chbHabilitaCondicaoPDVDelivery.Name = "chbHabilitaCondicaoPDVDelivery";
            this.chbHabilitaCondicaoPDVDelivery.Properties.Caption = "Habilita Condição para PDV e Delivery";
            this.chbHabilitaCondicaoPDVDelivery.Properties.ValueChecked = 1;
            this.chbHabilitaCondicaoPDVDelivery.Properties.ValueUnchecked = 0;
            this.chbHabilitaCondicaoPDVDelivery.Size = new System.Drawing.Size(223, 19);
            this.chbHabilitaCondicaoPDVDelivery.TabIndex = 74;
            // 
            // FormCondicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(593, 469);
            this.Name = "FormCondicao";
            this.Shown += new System.EventHandler(this.FormCondicao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDivide.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtParcela.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCondicaoParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVencimentoFeriado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoVariacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVariacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbHabilitaCondicaoPDVDelivery.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit chbDivide;
        private DevExpress.XtraEditors.SpinEdit txtQtParcela;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraGrid.GridControl gridCondicaoParcelas;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirParcelas;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarParcelas;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirParcelas;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarParcelas;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit cbVencimentoFeriado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoVariacao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtVariacao;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.CheckEdit chbHabilitaCondicaoPDVDelivery;
    }
}
