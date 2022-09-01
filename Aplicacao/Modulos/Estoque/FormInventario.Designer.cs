namespace Aplicacao
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lblPessoa = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpProdutos = new DevExpress.XtraTab.XtraTabPage();
            this.btConsultar = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluir = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterar = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluir = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcListaProdutos = new DevExpress.XtraGrid.GridControl();
            this.gvListaProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProdutoNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCodigoProprietario = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCodigoProprietario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 480);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(685, 480);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(766, 480);
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
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.cbCodigoProprietario);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.xtraTabControl1);
            this.tpPrincipal.Controls.Add(this.txtData);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.lblPessoa);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Size = new System.Drawing.Size(823, 456);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(829, 462);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(538, 66);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 8;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // lblPessoa
            // 
            this.lblPessoa.Location = new System.Drawing.Point(48, 69);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(24, 13);
            this.lblPessoa.TabIndex = 6;
            this.lblPessoa.Text = "Filial:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtCodigo.EditValue = 0;
            this.txtCodigo.Location = new System.Drawing.Point(78, 14);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(78, 40);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 200;
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(724, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 43);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Descrição:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(35, 17);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Código:";
            // 
            // txtData
            // 
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(715, 14);
            this.txtData.Name = "txtData";
            this.txtData.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(87, 20);
            this.txtData.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl5.Location = new System.Drawing.Point(682, 17);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Data:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(6, 118);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpProdutos;
            this.xtraTabControl1.Size = new System.Drawing.Size(796, 330);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpProdutos});
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.btConsultar);
            this.tpProdutos.Controls.Add(this.btExcluir);
            this.tpProdutos.Controls.Add(this.btAlterar);
            this.tpProdutos.Controls.Add(this.btIncluir);
            this.tpProdutos.Controls.Add(this.gcListaProdutos);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Size = new System.Drawing.Size(790, 302);
            this.tpProdutos.Text = "Produtos";
            // 
            // btConsultar
            // 
            this.btConsultar.GridControl = null;
            this.btConsultar.GridControlType = null;
            this.btConsultar.GridControlTypeParams = null;
            this.btConsultar.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultar.Location = new System.Drawing.Point(468, 271);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.SubForm = null;
            this.btConsultar.SubFormType = null;
            this.btConsultar.SubFormTypeParams = null;
            this.btConsultar.TabIndex = 1;
            this.btConsultar.TabStop = false;
            this.btConsultar.Text = "&Consultar";
            // 
            // btExcluir
            // 
            this.btExcluir.GridControl = null;
            this.btExcluir.GridControlType = null;
            this.btExcluir.GridControlTypeParams = null;
            this.btExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluir.Location = new System.Drawing.Point(711, 271);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.SubForm = null;
            this.btExcluir.SubFormType = null;
            this.btExcluir.SubFormTypeParams = null;
            this.btExcluir.TabIndex = 4;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "&Excluir";
            // 
            // btAlterar
            // 
            this.btAlterar.GridControl = null;
            this.btAlterar.GridControlType = null;
            this.btAlterar.GridControlTypeParams = null;
            this.btAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterar.Location = new System.Drawing.Point(630, 271);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.SubForm = null;
            this.btAlterar.SubFormType = null;
            this.btAlterar.SubFormTypeParams = null;
            this.btAlterar.TabIndex = 3;
            this.btAlterar.TabStop = false;
            this.btAlterar.Text = "&Alterar";
            // 
            // btIncluir
            // 
            this.btIncluir.GridControl = null;
            this.btIncluir.GridControlType = null;
            this.btIncluir.GridControlTypeParams = null;
            this.btIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluir.Location = new System.Drawing.Point(549, 271);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.SubForm = null;
            this.btIncluir.SubFormType = null;
            this.btIncluir.SubFormTypeParams = null;
            this.btIncluir.TabIndex = 2;
            this.btIncluir.TabStop = false;
            this.btIncluir.Text = "&Incluir";
            // 
            // gcListaProdutos
            // 
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcListaProdutos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcListaProdutos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcListaProdutos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcListaProdutos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcListaProdutos.Location = new System.Drawing.Point(3, 3);
            this.gcListaProdutos.MainView = this.gvListaProdutos;
            this.gcListaProdutos.Name = "gcListaProdutos";
            this.gcListaProdutos.Size = new System.Drawing.Size(784, 262);
            this.gcListaProdutos.TabIndex = 0;
            this.gcListaProdutos.UseEmbeddedNavigator = true;
            this.gcListaProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListaProdutos});
            // 
            // gvListaProdutos
            // 
            this.gvListaProdutos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.Empty.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvListaProdutos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvListaProdutos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvListaProdutos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaProdutos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaProdutos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaProdutos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvListaProdutos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvListaProdutos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvListaProdutos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaProdutos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvListaProdutos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.Preview.Options.UseFont = true;
            this.gvListaProdutos.Appearance.Preview.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaProdutos.Appearance.Row.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvListaProdutos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaProdutos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaProdutos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvListaProdutos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvListaProdutos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvListaProdutos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvListaProdutos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvListaProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProdutoNome,
            this.Quantidade,
            this.Valor,
            this.Total});
            this.gvListaProdutos.GridControl = this.gcListaProdutos;
            this.gvListaProdutos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvListaProdutos.Name = "gvListaProdutos";
            this.gvListaProdutos.OptionsBehavior.Editable = false;
            this.gvListaProdutos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvListaProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListaProdutos.OptionsView.EnableAppearanceOddRow = true;
            this.gvListaProdutos.OptionsView.ShowAutoFilterRow = true;
            this.gvListaProdutos.OptionsView.ShowFooter = true;
            this.gvListaProdutos.OptionsView.ShowGroupPanel = false;
            this.gvListaProdutos.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gvListaProdutos_CustomColumnSort);
            // 
            // ProdutoNome
            // 
            this.ProdutoNome.AppearanceHeader.Options.UseTextOptions = true;
            this.ProdutoNome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProdutoNome.Caption = "Produto";
            this.ProdutoNome.FieldName = "ProdutoNome";
            this.ProdutoNome.Name = "ProdutoNome";
            this.ProdutoNome.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.ProdutoNome.Visible = true;
            this.ProdutoNome.VisibleIndex = 0;
            this.ProdutoNome.Width = 439;
            // 
            // Quantidade
            // 
            this.Quantidade.AppearanceCell.Options.UseTextOptions = true;
            this.Quantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Quantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantidade.Caption = "Quantidade";
            this.Quantidade.FieldName = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Quantidade.Visible = true;
            this.Quantidade.VisibleIndex = 1;
            this.Quantidade.Width = 86;
            // 
            // Valor
            // 
            this.Valor.AppearanceCell.Options.UseTextOptions = true;
            this.Valor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Valor.AppearanceHeader.Options.UseTextOptions = true;
            this.Valor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Valor.Caption = "Valor";
            this.Valor.DisplayFormat.FormatString = "c2";
            this.Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Valor.FieldName = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 2;
            this.Valor.Width = 116;
            // 
            // Total
            // 
            this.Total.AppearanceCell.Options.UseTextOptions = true;
            this.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.Caption = "Total";
            this.Total.DisplayFormat.FormatString = "c2";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "Total = {0:C2}")});
            this.Total.Visible = true;
            this.Total.VisibleIndex = 3;
            this.Total.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Proprietário:";
            // 
            // cbCodigoProprietario
            // 
            this.cbCodigoProprietario.EditValue = "1 | Informante";
            this.cbCodigoProprietario.Location = new System.Drawing.Point(684, 70);
            this.cbCodigoProprietario.Name = "cbCodigoProprietario";
            this.cbCodigoProprietario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCodigoProprietario.Properties.Items.AddRange(new object[] {
            "1 | Informante",
            "2 | Informante em poder de terceiros",
            "3 | Terceiros em poder de informante"});
            this.cbCodigoProprietario.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbCodigoProprietario.Size = new System.Drawing.Size(118, 20);
            this.cbCodigoProprietario.TabIndex = 11;
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(78, 66);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = false;
            this.lkpFilial.Size = new System.Drawing.Size(454, 20);
            this.lkpFilial.Tabela = null;
            this.lkpFilial.TabIndex = 6;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFilial.Where = null;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(853, 515);
            this.Name = "FormInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCodigoProprietario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private DevExpress.XtraEditors.LabelControl lblPessoa;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtData;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpProdutos;
        private Cwork.Utilitarios.Componentes.DevButton btConsultar;
        private Cwork.Utilitarios.Componentes.DevButton btExcluir;
        private Cwork.Utilitarios.Componentes.DevButton btAlterar;
        private Cwork.Utilitarios.Componentes.DevButton btIncluir;
        private DevExpress.XtraGrid.GridControl gcListaProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListaProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn ProdutoNome;
        private DevExpress.XtraGrid.Columns.GridColumn Quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbCodigoProprietario;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
    }
}
