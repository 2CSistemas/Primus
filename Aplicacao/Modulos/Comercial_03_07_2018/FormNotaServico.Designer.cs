namespace Aplicacao
{
    public partial class FormNotaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaServico));
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmissao = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalProduto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalNota = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcNotaServicoItems = new DevExpress.XtraGrid.GridControl();
            this.gvNotaServicoItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CServicoCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CServicoDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.btnlkpFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.btnlkpCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.btnlkpCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.btIncluirServicos = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarServicos = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirServicos = new Cwork.Utilitarios.Componentes.DevButton();
            this.btConsultarServicos = new Cwork.Utilitarios.Componentes.DevButton();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmissao.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaServicoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaServicoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 419);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(624, 419);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(705, 419);
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
            this.tpPrincipal.Controls.Add(this.btnlkpCondicao);
            this.tpPrincipal.Controls.Add(this.btnlkpCliente);
            this.tpPrincipal.Controls.Add(this.btnlkpFilial);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.btIncluirServicos);
            this.tpPrincipal.Controls.Add(this.btAlterarServicos);
            this.tpPrincipal.Controls.Add(this.btExcluirServicos);
            this.tpPrincipal.Controls.Add(this.btConsultarServicos);
            this.tpPrincipal.Controls.Add(this.lkpCondicao);
            this.tpPrincipal.Controls.Add(this.lkpCliente);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.txtDesconto);
            this.tpPrincipal.Controls.Add(this.labelControl9);
            this.tpPrincipal.Controls.Add(this.txtTotalProduto);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.txtObservacao);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.txtTotalNota);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.gcNotaServicoItems);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl23);
            this.tpPrincipal.Controls.Add(this.txtEmissao);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtData);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(759, 392);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(768, 401);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Condição:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Cliente:";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(193, 6);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(45, 13);
            this.labelControl23.TabIndex = 2;
            this.labelControl23.Text = "Empresa:";
            // 
            // txtEmissao
            // 
            this.txtEmissao.EditValue = null;
            this.txtEmissao.Location = new System.Drawing.Point(244, 29);
            this.txtEmissao.Name = "txtEmissao";
            this.txtEmissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmissao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtEmissao.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtEmissao.Size = new System.Drawing.Size(103, 20);
            this.txtEmissao.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(196, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Emissão:";
            // 
            // txtData
            // 
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(67, 29);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(102, 20);
            this.txtData.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Data:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Número:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(481, 296);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDesconto.Properties.DisplayFormat.FormatString = "c2";
            this.txtDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDesconto.Properties.Mask.EditMask = "c2";
            this.txtDesconto.Properties.Precision = 2;
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 22;
            this.txtDesconto.EditValueChanged += new System.EventHandler(this.txtDesconto_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(587, 299);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(54, 13);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Total Nota:";
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Location = new System.Drawing.Point(647, 270);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotalProduto.Properties.DisplayFormat.FormatString = "c2";
            this.txtTotalProduto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalProduto.Properties.Mask.EditMask = "c2";
            this.txtTotalProduto.Properties.Precision = 2;
            this.txtTotalProduto.Properties.ReadOnly = true;
            this.txtTotalProduto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProduto.TabIndex = 20;
            this.txtTotalProduto.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(567, 273);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Total Produtos:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(13, 322);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.MaxLength = 1292;
            this.txtObservacao.Size = new System.Drawing.Size(734, 59);
            this.txtObservacao.TabIndex = 26;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 296);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Observação:";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Location = new System.Drawing.Point(647, 296);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotalNota.Properties.DisplayFormat.FormatString = "c2";
            this.txtTotalNota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalNota.Properties.Mask.EditMask = "c2";
            this.txtTotalNota.Properties.Precision = 2;
            this.txtTotalNota.Properties.ReadOnly = true;
            this.txtTotalNota.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNota.TabIndex = 24;
            this.txtTotalNota.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(426, 299);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Desconto:";
            // 
            // gcNotaServicoItems
            // 
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcNotaServicoItems.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNotaServicoItems.EmbeddedNavigator.Name = "";
            this.gcNotaServicoItems.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcNotaServicoItems.Location = new System.Drawing.Point(13, 107);
            this.gcNotaServicoItems.LookAndFeel.UseWindowsXPTheme = true;
            this.gcNotaServicoItems.MainView = this.gvNotaServicoItems;
            this.gcNotaServicoItems.Name = "gcNotaServicoItems";
            this.gcNotaServicoItems.Size = new System.Drawing.Size(734, 154);
            this.gcNotaServicoItems.TabIndex = 0;
            this.gcNotaServicoItems.TabStop = false;
            this.gcNotaServicoItems.UseEmbeddedNavigator = true;
            this.gcNotaServicoItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotaServicoItems});
            // 
            // gvNotaServicoItems
            // 
            this.gvNotaServicoItems.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.Empty.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaServicoItems.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaServicoItems.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaServicoItems.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaServicoItems.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaServicoItems.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaServicoItems.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaServicoItems.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaServicoItems.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaServicoItems.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaServicoItems.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvNotaServicoItems.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.Preview.Options.UseFont = true;
            this.gvNotaServicoItems.Appearance.Preview.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaServicoItems.Appearance.Row.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvNotaServicoItems.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaServicoItems.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaServicoItems.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNotaServicoItems.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvNotaServicoItems.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNotaServicoItems.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvNotaServicoItems.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvNotaServicoItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sequencia,
            this.CServicoCodigo,
            this.CServicoDescricao,
            this.Quantidade,
            this.ValorUnitario,
            this.Total});
            this.gvNotaServicoItems.GridControl = this.gcNotaServicoItems;
            this.gvNotaServicoItems.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvNotaServicoItems.Name = "gvNotaServicoItems";
            this.gvNotaServicoItems.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvNotaServicoItems.OptionsBehavior.Editable = false;
            this.gvNotaServicoItems.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvNotaServicoItems.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvNotaServicoItems.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNotaServicoItems.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotaServicoItems.OptionsView.ShowAutoFilterRow = true;
            this.gvNotaServicoItems.OptionsView.ShowGroupPanel = false;
            this.gvNotaServicoItems.DataSourceChanged += new System.EventHandler(this.gvNotaServicoItems_DataSourceChanged);
            // 
            // Sequencia
            // 
            this.Sequencia.AppearanceCell.Options.UseTextOptions = true;
            this.Sequencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Sequencia.AppearanceHeader.Options.UseTextOptions = true;
            this.Sequencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sequencia.Caption = "Seq.";
            this.Sequencia.DisplayFormat.FormatString = "0";
            this.Sequencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Sequencia.FieldName = "Sequencia";
            this.Sequencia.Name = "Sequencia";
            this.Sequencia.Visible = true;
            this.Sequencia.VisibleIndex = 0;
            this.Sequencia.Width = 54;
            // 
            // CServicoCodigo
            // 
            this.CServicoCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.CServicoCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CServicoCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.CServicoCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CServicoCodigo.Caption = "Código";
            this.CServicoCodigo.DisplayFormat.FormatString = "n0";
            this.CServicoCodigo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CServicoCodigo.FieldName = "ServicoCodigo";
            this.CServicoCodigo.Name = "CServicoCodigo";
            this.CServicoCodigo.Visible = true;
            this.CServicoCodigo.VisibleIndex = 1;
            this.CServicoCodigo.Width = 70;
            // 
            // CServicoDescricao
            // 
            this.CServicoDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.CServicoDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CServicoDescricao.Caption = "Descrição";
            this.CServicoDescricao.FieldName = "ServicoDescricao";
            this.CServicoDescricao.Name = "CServicoDescricao";
            this.CServicoDescricao.Visible = true;
            this.CServicoDescricao.VisibleIndex = 2;
            this.CServicoDescricao.Width = 304;
            // 
            // Quantidade
            // 
            this.Quantidade.AppearanceCell.Options.UseTextOptions = true;
            this.Quantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Quantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantidade.Caption = "Qtd.";
            this.Quantidade.DisplayFormat.FormatString = "n0";
            this.Quantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Quantidade.FieldName = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Visible = true;
            this.Quantidade.VisibleIndex = 3;
            this.Quantidade.Width = 74;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.ValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ValorUnitario.AppearanceHeader.Options.UseTextOptions = true;
            this.ValorUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ValorUnitario.Caption = "Vlr. Unitário";
            this.ValorUnitario.DisplayFormat.FormatString = "c2";
            this.ValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ValorUnitario.FieldName = "ValorUnitario";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Visible = true;
            this.ValorUnitario.VisibleIndex = 4;
            this.ValorUnitario.Width = 93;
            // 
            // Total
            // 
            this.Total.AppearanceCell.Options.UseTextOptions = true;
            this.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.Caption = "Total";
            this.Total.DisplayFormat.FormatString = "c2";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 5;
            this.Total.Width = 118;
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.btnlkpFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "50",
        "20"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(244, 3);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = false;
            this.lkpFilial.Size = new System.Drawing.Size(473, 20);
            this.lkpFilial.Tabela = null;
            this.lkpFilial.TabIndex = 3;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            // 
            // btnlkpFilial
            // 
            this.btnlkpFilial.Location = new System.Drawing.Point(723, 3);
            this.btnlkpFilial.Lookup = null;
            this.btnlkpFilial.Name = "btnlkpFilial";
            this.btnlkpFilial.Size = new System.Drawing.Size(24, 20);
            this.btnlkpFilial.SubForm = null;
            this.btnlkpFilial.TabIndex = 4;
            this.btnlkpFilial.TabStop = false;
            this.btnlkpFilial.Text = "...";
            this.btnlkpFilial.Click += new System.EventHandler(this.btnlkpFilial_Click);
            // 
            // lkpCliente
            // 
            this.lkpCliente.ButtonLookup = this.btnlkpCliente;
            this.lkpCliente.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpCliente.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesAND")));
            this.lkpCliente.CamposRestricoesNOT = null;
            this.lkpCliente.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesOR")));
            this.lkpCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCliente.ColunaTamanho = new string[] {
        "50",
        "20"};
            this.lkpCliente.ContextoLinq = null;
            this.lkpCliente.CwkFuncaoValidacao = null;
            this.lkpCliente.CwkMascara = null;
            this.lkpCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCliente.Exemplo = null;
            this.lkpCliente.ID = 0;
            this.lkpCliente.Join = null;
            this.lkpCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpCliente.Location = new System.Drawing.Point(67, 55);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = false;
            this.lkpCliente.Size = new System.Drawing.Size(650, 20);
            this.lkpCliente.Tabela = null;
            this.lkpCliente.TabIndex = 10;
            this.lkpCliente.TituloTelaPesquisa = null;
            this.lkpCliente.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCliente.Where = null;
            // 
            // btnlkpCliente
            // 
            this.btnlkpCliente.Location = new System.Drawing.Point(723, 55);
            this.btnlkpCliente.Lookup = null;
            this.btnlkpCliente.Name = "btnlkpCliente";
            this.btnlkpCliente.Size = new System.Drawing.Size(24, 20);
            this.btnlkpCliente.SubForm = null;
            this.btnlkpCliente.TabIndex = 11;
            this.btnlkpCliente.TabStop = false;
            this.btnlkpCliente.Text = "...";
            this.btnlkpCliente.Click += new System.EventHandler(this.btnlkpCliente_Click);
            // 
            // lkpCondicao
            // 
            this.lkpCondicao.ButtonLookup = this.btnlkpCondicao;
            this.lkpCondicao.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpCondicao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesAND")));
            this.lkpCondicao.CamposRestricoesNOT = null;
            this.lkpCondicao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesOR")));
            this.lkpCondicao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCondicao.ColunaTamanho = new string[] {
        "50",
        "20"};
            this.lkpCondicao.ContextoLinq = null;
            this.lkpCondicao.CwkFuncaoValidacao = null;
            this.lkpCondicao.CwkMascara = null;
            this.lkpCondicao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCondicao.Exemplo = null;
            this.lkpCondicao.ID = 0;
            this.lkpCondicao.Join = null;
            this.lkpCondicao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCondicao.Location = new System.Drawing.Point(67, 81);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.SelecionarTextoOnEnter = false;
            this.lkpCondicao.Size = new System.Drawing.Size(650, 20);
            this.lkpCondicao.Tabela = null;
            this.lkpCondicao.TabIndex = 13;
            this.lkpCondicao.TituloTelaPesquisa = null;
            this.lkpCondicao.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCondicao.Where = null;
            // 
            // btnlkpCondicao
            // 
            this.btnlkpCondicao.Location = new System.Drawing.Point(723, 81);
            this.btnlkpCondicao.Lookup = null;
            this.btnlkpCondicao.Name = "btnlkpCondicao";
            this.btnlkpCondicao.Size = new System.Drawing.Size(24, 20);
            this.btnlkpCondicao.SubForm = null;
            this.btnlkpCondicao.TabIndex = 14;
            this.btnlkpCondicao.TabStop = false;
            this.btnlkpCondicao.Text = "...";
            this.btnlkpCondicao.Click += new System.EventHandler(this.btnlkpCondicao_Click);
            // 
            // btIncluirServicos
            // 
            this.btIncluirServicos.GridControl = null;
            this.btIncluirServicos.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirServicos.Location = new System.Drawing.Point(94, 267);
            this.btIncluirServicos.Name = "btIncluirServicos";
            this.btIncluirServicos.Size = new System.Drawing.Size(75, 23);
            this.btIncluirServicos.SubForm = null;
            this.btIncluirServicos.TabIndex = 16;
            this.btIncluirServicos.Text = "&Incluir";
            // 
            // btAlterarServicos
            // 
            this.btAlterarServicos.GridControl = null;
            this.btAlterarServicos.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarServicos.Location = new System.Drawing.Point(175, 267);
            this.btAlterarServicos.Name = "btAlterarServicos";
            this.btAlterarServicos.Size = new System.Drawing.Size(75, 23);
            this.btAlterarServicos.SubForm = null;
            this.btAlterarServicos.TabIndex = 17;
            this.btAlterarServicos.Text = "&Alterar";
            // 
            // btExcluirServicos
            // 
            this.btExcluirServicos.GridControl = null;
            this.btExcluirServicos.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirServicos.Location = new System.Drawing.Point(256, 267);
            this.btExcluirServicos.Name = "btExcluirServicos";
            this.btExcluirServicos.Size = new System.Drawing.Size(75, 23);
            this.btExcluirServicos.SubForm = null;
            this.btExcluirServicos.TabIndex = 18;
            this.btExcluirServicos.Text = "&Excluir";
            // 
            // btConsultarServicos
            // 
            this.btConsultarServicos.GridControl = null;
            this.btConsultarServicos.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarServicos.Location = new System.Drawing.Point(13, 267);
            this.btConsultarServicos.Name = "btConsultarServicos";
            this.btConsultarServicos.Size = new System.Drawing.Size(75, 23);
            this.btConsultarServicos.SubForm = null;
            this.btConsultarServicos.TabIndex = 15;
            this.btConsultarServicos.Text = "&Consultar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeralInteiro;
            this.txtCodigo.Location = new System.Drawing.Point(67, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(102, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // FormNotaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 454);
            this.Name = "FormNotaServico";
            this.Shown += new System.EventHandler(this.FormNotaServico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmissao.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaServicoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaServicoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevCalcEdit txtDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotalProduto;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtObservacao;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotalNota;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraGrid.GridControl gcNotaServicoItems;
        public DevExpress.XtraGrid.Views.Grid.GridView gvNotaServicoItems;
        private DevExpress.XtraGrid.Columns.GridColumn Sequencia;
        private DevExpress.XtraGrid.Columns.GridColumn CServicoCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn CServicoDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn Quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn ValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtEmissao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtData;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirServicos;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarServicos;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirServicos;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarServicos;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpCondicao;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpCliente;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpFilial;

    }
}
