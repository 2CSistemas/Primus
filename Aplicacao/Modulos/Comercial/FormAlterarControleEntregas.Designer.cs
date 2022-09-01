namespace Aplicacao.Modulos.Comercial
{
    partial class FormAlterarControleEntregas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarControleEntregas));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpAltercaoEntrega = new DevExpress.XtraTab.XtraTabPage();
            this.txtSolicitante = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtResponsavel = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroEntrega = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcAltercaoEntrega = new DevExpress.XtraGrid.GridControl();
            this.gvAltercaoEntrega = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantidadeRestante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorQuantidadeRestante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantidadeEntregue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ValorQuantidadeEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSequencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpAltercaoEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsavel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAltercaoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAltercaoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 461);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 4;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbGravar
            // 
            this.sbGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGravar.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbGravar.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(773, 461);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 5;
            this.sbGravar.Text = "&Gravar";
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(854, 461);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 6;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpAltercaoEntrega;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(917, 443);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpAltercaoEntrega});
            this.xtraTabControl1.TabStop = false;
            // 
            // tpAltercaoEntrega
            // 
            this.tpAltercaoEntrega.Controls.Add(this.txtSolicitante);
            this.tpAltercaoEntrega.Controls.Add(this.labelControl6);
            this.tpAltercaoEntrega.Controls.Add(this.txtResponsavel);
            this.tpAltercaoEntrega.Controls.Add(this.labelControl5);
            this.tpAltercaoEntrega.Controls.Add(this.txtNumeroEntrega);
            this.tpAltercaoEntrega.Controls.Add(this.labelControl3);
            this.tpAltercaoEntrega.Controls.Add(this.labelControl1);
            this.tpAltercaoEntrega.Controls.Add(this.labelControl4);
            this.tpAltercaoEntrega.Controls.Add(this.gcAltercaoEntrega);
            this.tpAltercaoEntrega.Controls.Add(this.txtSequencia);
            this.tpAltercaoEntrega.Controls.Add(this.labelControl2);
            this.tpAltercaoEntrega.Controls.Add(this.txtData);
            this.tpAltercaoEntrega.Name = "tpAltercaoEntrega";
            this.tpAltercaoEntrega.Size = new System.Drawing.Size(911, 437);
            this.tpAltercaoEntrega.Text = "xtraTabPage1";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.CwkFuncaoValidacao = null;
            this.txtSolicitante.CwkMascara = null;
            this.txtSolicitante.CwkValidacao = null;
            this.txtSolicitante.Location = new System.Drawing.Point(346, 29);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.SelecionarTextoOnEnter = false;
            this.txtSolicitante.Size = new System.Drawing.Size(149, 20);
            this.txtSolicitante.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(287, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Solicitante:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.CwkFuncaoValidacao = null;
            this.txtResponsavel.CwkMascara = null;
            this.txtResponsavel.CwkValidacao = null;
            this.txtResponsavel.Location = new System.Drawing.Point(346, 3);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.SelecionarTextoOnEnter = false;
            this.txtResponsavel.Size = new System.Drawing.Size(149, 20);
            this.txtResponsavel.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(276, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Responsável:";
            // 
            // txtNumeroEntrega
            // 
            this.txtNumeroEntrega.CwkFuncaoValidacao = null;
            this.txtNumeroEntrega.CwkMascara = null;
            this.txtNumeroEntrega.CwkValidacao = null;
            this.txtNumeroEntrega.Location = new System.Drawing.Point(104, 55);
            this.txtNumeroEntrega.Name = "txtNumeroEntrega";
            this.txtNumeroEntrega.Properties.Mask.EditMask = "n0";
            this.txtNumeroEntrega.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumeroEntrega.Properties.ReadOnly = true;
            this.txtNumeroEntrega.SelecionarTextoOnEnter = false;
            this.txtNumeroEntrega.Size = new System.Drawing.Size(149, 20);
            this.txtNumeroEntrega.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Número Entrega:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Data:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(3, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Lista de Produtos";
            // 
            // gcAltercaoEntrega
            // 
            this.gcAltercaoEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAltercaoEntrega.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcAltercaoEntrega.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcAltercaoEntrega.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcAltercaoEntrega.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcAltercaoEntrega.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcAltercaoEntrega.Location = new System.Drawing.Point(3, 103);
            this.gcAltercaoEntrega.MainView = this.gvAltercaoEntrega;
            this.gcAltercaoEntrega.Name = "gcAltercaoEntrega";
            this.gcAltercaoEntrega.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcAltercaoEntrega.Size = new System.Drawing.Size(904, 330);
            this.gcAltercaoEntrega.TabIndex = 3;
            this.gcAltercaoEntrega.UseEmbeddedNavigator = true;
            this.gcAltercaoEntrega.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAltercaoEntrega});
            // 
            // gvAltercaoEntrega
            // 
            this.gvAltercaoEntrega.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.Empty.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAltercaoEntrega.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAltercaoEntrega.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAltercaoEntrega.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAltercaoEntrega.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAltercaoEntrega.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAltercaoEntrega.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAltercaoEntrega.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAltercaoEntrega.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAltercaoEntrega.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvAltercaoEntrega.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvAltercaoEntrega.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.Preview.Options.UseFont = true;
            this.gvAltercaoEntrega.Appearance.Preview.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAltercaoEntrega.Appearance.Row.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvAltercaoEntrega.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAltercaoEntrega.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvAltercaoEntrega.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvAltercaoEntrega.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sequencia,
            this.Codigo,
            this.Descricao,
            this.UN,
            this.QuantidadeRestante,
            this.ValorQuantidadeRestante,
            this.QuantidadeEntregue,
            this.ValorQuantidadeEntrega});
            this.gvAltercaoEntrega.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvAltercaoEntrega.GridControl = this.gcAltercaoEntrega;
            this.gvAltercaoEntrega.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvAltercaoEntrega.Name = "gvAltercaoEntrega";
            this.gvAltercaoEntrega.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvAltercaoEntrega.OptionsView.ColumnAutoWidth = false;
            this.gvAltercaoEntrega.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAltercaoEntrega.OptionsView.EnableAppearanceOddRow = true;
            this.gvAltercaoEntrega.OptionsView.ShowGroupPanel = false;
            this.gvAltercaoEntrega.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.gvAltercaoEntrega_InvalidValueException);
            // 
            // Sequencia
            // 
            this.Sequencia.AppearanceHeader.Options.UseTextOptions = true;
            this.Sequencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sequencia.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Sequencia.Caption = "Seq.";
            this.Sequencia.FieldName = "Sequencia";
            this.Sequencia.Name = "Sequencia";
            this.Sequencia.OptionsColumn.AllowEdit = false;
            this.Sequencia.OptionsColumn.ReadOnly = true;
            this.Sequencia.Visible = true;
            this.Sequencia.VisibleIndex = 0;
            this.Sequencia.Width = 44;
            // 
            // Codigo
            // 
            this.Codigo.AppearanceHeader.Options.UseTextOptions = true;
            this.Codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Codigo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "PedidoItem.ID";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.OptionsColumn.ReadOnly = true;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            // 
            // Descricao
            // 
            this.Descricao.AppearanceHeader.Options.UseTextOptions = true;
            this.Descricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descricao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "PedidoItem.ProdutoNome";
            this.Descricao.Name = "Descricao";
            this.Descricao.OptionsColumn.AllowEdit = false;
            this.Descricao.OptionsColumn.ReadOnly = true;
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 2;
            this.Descricao.Width = 339;
            // 
            // UN
            // 
            this.UN.AppearanceHeader.Options.UseTextOptions = true;
            this.UN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UN.Caption = "UN";
            this.UN.FieldName = "PedidoItem.Unidade";
            this.UN.Name = "UN";
            this.UN.OptionsColumn.AllowEdit = false;
            this.UN.OptionsColumn.ReadOnly = true;
            this.UN.Visible = true;
            this.UN.VisibleIndex = 3;
            this.UN.Width = 57;
            // 
            // QuantidadeRestante
            // 
            this.QuantidadeRestante.AppearanceHeader.Options.UseTextOptions = true;
            this.QuantidadeRestante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantidadeRestante.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QuantidadeRestante.Caption = "Saldo";
            this.QuantidadeRestante.FieldName = "QuantidadeRestante";
            this.QuantidadeRestante.Name = "QuantidadeRestante";
            this.QuantidadeRestante.OptionsColumn.AllowEdit = false;
            this.QuantidadeRestante.OptionsColumn.ReadOnly = true;
            this.QuantidadeRestante.Visible = true;
            this.QuantidadeRestante.VisibleIndex = 4;
            this.QuantidadeRestante.Width = 76;
            // 
            // ValorQuantidadeRestante
            // 
            this.ValorQuantidadeRestante.AppearanceHeader.Options.UseTextOptions = true;
            this.ValorQuantidadeRestante.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ValorQuantidadeRestante.Caption = "Valor";
            this.ValorQuantidadeRestante.DisplayFormat.FormatString = "c2";
            this.ValorQuantidadeRestante.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ValorQuantidadeRestante.FieldName = "ValorQuantidadeRestante";
            this.ValorQuantidadeRestante.Name = "ValorQuantidadeRestante";
            this.ValorQuantidadeRestante.OptionsColumn.AllowEdit = false;
            this.ValorQuantidadeRestante.OptionsColumn.ReadOnly = true;
            this.ValorQuantidadeRestante.Visible = true;
            this.ValorQuantidadeRestante.VisibleIndex = 5;
            this.ValorQuantidadeRestante.Width = 86;
            // 
            // QuantidadeEntregue
            // 
            this.QuantidadeEntregue.AppearanceHeader.Options.UseTextOptions = true;
            this.QuantidadeEntregue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuantidadeEntregue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.QuantidadeEntregue.Caption = "Quantidade Entregue";
            this.QuantidadeEntregue.ColumnEdit = this.repositoryItemTextEdit1;
            this.QuantidadeEntregue.FieldName = "QuantidadeEntrega";
            this.QuantidadeEntregue.Name = "QuantidadeEntregue";
            this.QuantidadeEntregue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.QuantidadeEntregue.Visible = true;
            this.QuantidadeEntregue.VisibleIndex = 6;
            this.QuantidadeEntregue.Width = 121;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "0";
            this.repositoryItemTextEdit1.NullValuePrompt = "0";
            this.repositoryItemTextEdit1.NullValuePromptShowForEmptyValue = true;
            // 
            // ValorQuantidadeEntrega
            // 
            this.ValorQuantidadeEntrega.AppearanceHeader.Options.UseTextOptions = true;
            this.ValorQuantidadeEntrega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ValorQuantidadeEntrega.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ValorQuantidadeEntrega.Caption = "Valor";
            this.ValorQuantidadeEntrega.DisplayFormat.FormatString = "c2";
            this.ValorQuantidadeEntrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ValorQuantidadeEntrega.FieldName = "ValorQuantidadeEntrega";
            this.ValorQuantidadeEntrega.Name = "ValorQuantidadeEntrega";
            this.ValorQuantidadeEntrega.OptionsColumn.AllowEdit = false;
            this.ValorQuantidadeEntrega.OptionsColumn.ReadOnly = true;
            this.ValorQuantidadeEntrega.Visible = true;
            this.ValorQuantidadeEntrega.VisibleIndex = 7;
            this.ValorQuantidadeEntrega.Width = 85;
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = null;
            this.txtSequencia.Location = new System.Drawing.Point(104, 3);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.ReadOnly = true;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(149, 20);
            this.txtSequencia.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Sequência:";
            // 
            // txtData
            // 
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(104, 29);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.EditMask = "g";
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(149, 20);
            this.txtData.TabIndex = 1;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormAlterarControleEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 496);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGravar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormAlterarControleEntregas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração Entrega";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpAltercaoEntrega.ResumeLayout(false);
            this.tpAltercaoEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsavel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAltercaoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAltercaoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbGravar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage tpAltercaoEntrega;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtSequencia;
        private DevExpress.XtraGrid.GridControl gcAltercaoEntrega;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAltercaoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn Sequencia;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn UN;
        private DevExpress.XtraGrid.Columns.GridColumn QuantidadeRestante;
        private DevExpress.XtraGrid.Columns.GridColumn ValorQuantidadeRestante;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNumeroEntrega;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn QuantidadeEntregue;
        private DevExpress.XtraGrid.Columns.GridColumn ValorQuantidadeEntrega;
        private DevExpress.XtraEditors.DateEdit txtData;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtSolicitante;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtResponsavel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}