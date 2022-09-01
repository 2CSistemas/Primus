namespace Aplicacao.PCP
{
    partial class FormManutFichaTecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutFichaTecnica));
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtVersao = new Cwork.Utilitarios.Componentes.DevSpinEdit();
            this.btIncluirMP = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterarMP = new DevExpress.XtraEditors.SimpleButton();
            this.btExcluirMP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gcMateriaPrima = new DevExpress.XtraGrid.GridControl();
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAcaoMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProdutoMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.sbIncluirEtapa = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterarEtapa = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluirEtapa = new DevExpress.XtraEditors.SimpleButton();
            this.gcEtapas = new DevExpress.XtraGrid.GridControl();
            this.gvEtapas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAcaoEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequenciaEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacaoEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProdutoEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTituloEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDServicoEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEtapas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(686, 513);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Size = new System.Drawing.Size(677, 504);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(623, 531);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(542, 531);
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl2.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl2.Size = new System.Drawing.Size(671, 498);
            this.xtraTabControl2.TabIndex = 0;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            this.xtraTabControl2.TabStop = false;
            this.xtraTabControl2.Text = "xtraTabControl2";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtVersao);
            this.xtraTabPage2.Controls.Add(this.btIncluirMP);
            this.xtraTabPage2.Controls.Add(this.btAlterarMP);
            this.xtraTabPage2.Controls.Add(this.btExcluirMP);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.gcMateriaPrima);
            this.xtraTabPage2.Controls.Add(this.label4);
            this.xtraTabPage2.Controls.Add(this.txtDescricao);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.lkbProduto);
            this.xtraTabPage2.Controls.Add(this.lkProduto);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(662, 467);
            this.xtraTabPage2.Text = "Dados";
            // 
            // txtVersao
            // 
            this.txtVersao.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtVersao.Location = new System.Drawing.Point(67, 29);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtVersao.Properties.IsFloatValue = false;
            this.txtVersao.Properties.Mask.EditMask = "N00";
            this.txtVersao.Size = new System.Drawing.Size(99, 20);
            this.txtVersao.TabIndex = 4;
            // 
            // btIncluirMP
            // 
            this.btIncluirMP.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirMP.ImageIndex = 4;
            this.btIncluirMP.Location = new System.Drawing.Point(428, 441);
            this.btIncluirMP.Name = "btIncluirMP";
            this.btIncluirMP.Size = new System.Drawing.Size(75, 22);
            this.btIncluirMP.TabIndex = 9;
            this.btIncluirMP.Text = "&Incluir";
            this.btIncluirMP.Click += new System.EventHandler(this.btIncluirMP_Click);
            // 
            // btAlterarMP
            // 
            this.btAlterarMP.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarMP.ImageIndex = 5;
            this.btAlterarMP.Location = new System.Drawing.Point(506, 441);
            this.btAlterarMP.Name = "btAlterarMP";
            this.btAlterarMP.Size = new System.Drawing.Size(75, 22);
            this.btAlterarMP.TabIndex = 10;
            this.btAlterarMP.Text = "&Alterar";
            this.btAlterarMP.Click += new System.EventHandler(this.btAlterarMP_Click);
            // 
            // btExcluirMP
            // 
            this.btExcluirMP.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirMP.ImageIndex = 6;
            this.btExcluirMP.Location = new System.Drawing.Point(584, 441);
            this.btExcluirMP.Name = "btExcluirMP";
            this.btExcluirMP.Size = new System.Drawing.Size(75, 22);
            this.btExcluirMP.TabIndex = 11;
            this.btExcluirMP.Text = "&Excluir";
            this.btExcluirMP.Click += new System.EventHandler(this.btExcluirMP_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(67, 116);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(106, 18);
            this.labelControl11.TabIndex = 7;
            this.labelControl11.Text = "Matéria Prima";
            // 
            // gcMateriaPrima
            // 
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcMateriaPrima.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcMateriaPrima.EmbeddedNavigator.Name = "";
            this.gcMateriaPrima.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcMateriaPrima.Location = new System.Drawing.Point(67, 140);
            this.gcMateriaPrima.MainView = this.gvMateriaPrima;
            this.gcMateriaPrima.Name = "gcMateriaPrima";
            this.gcMateriaPrima.Size = new System.Drawing.Size(592, 295);
            this.gcMateriaPrima.TabIndex = 8;
            this.gcMateriaPrima.TabStop = false;
            this.gcMateriaPrima.UseEmbeddedNavigator = true;
            this.gcMateriaPrima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMateriaPrima});
            this.gcMateriaPrima.DoubleClick += new System.EventHandler(this.gcMateriaPrima_DoubleClick);
            // 
            // gvMateriaPrima
            // 
            this.gvMateriaPrima.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.Empty.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMateriaPrima.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMateriaPrima.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMateriaPrima.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriaPrima.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriaPrima.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriaPrima.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMateriaPrima.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriaPrima.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.OddRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.OddRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvMateriaPrima.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.Preview.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.Preview.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriaPrima.Appearance.Row.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriaPrima.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriaPrima.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAcaoMP,
            this.colCodigoMP,
            this.colDescricaoMP,
            this.colIDMP,
            this.colIDProdutoMP,
            this.colQuantidadeMP});
            this.gvMateriaPrima.GridControl = this.gcMateriaPrima;
            this.gvMateriaPrima.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvMateriaPrima.Name = "gvMateriaPrima";
            this.gvMateriaPrima.OptionsBehavior.Editable = false;
            this.gvMateriaPrima.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvMateriaPrima.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMateriaPrima.OptionsView.EnableAppearanceOddRow = true;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            // 
            // colAcaoMP
            // 
            this.colAcaoMP.Caption = "Ação";
            this.colAcaoMP.FieldName = "Acao";
            this.colAcaoMP.Name = "colAcaoMP";
            // 
            // colCodigoMP
            // 
            this.colCodigoMP.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoMP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCodigoMP.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCodigoMP.Caption = "Código";
            this.colCodigoMP.FieldName = "Codigo";
            this.colCodigoMP.Name = "colCodigoMP";
            this.colCodigoMP.Visible = true;
            this.colCodigoMP.VisibleIndex = 0;
            this.colCodigoMP.Width = 70;
            // 
            // colDescricaoMP
            // 
            this.colDescricaoMP.Caption = "Descrição";
            this.colDescricaoMP.FieldName = "Descricao";
            this.colDescricaoMP.Name = "colDescricaoMP";
            this.colDescricaoMP.Visible = true;
            this.colDescricaoMP.VisibleIndex = 1;
            this.colDescricaoMP.Width = 249;
            // 
            // colIDMP
            // 
            this.colIDMP.Caption = "ID";
            this.colIDMP.FieldName = "ID";
            this.colIDMP.Name = "colIDMP";
            // 
            // colIDProdutoMP
            // 
            this.colIDProdutoMP.Caption = "IDProduto";
            this.colIDProdutoMP.FieldName = "IDProduto";
            this.colIDProdutoMP.Name = "colIDProdutoMP";
            // 
            // colQuantidadeMP
            // 
            this.colQuantidadeMP.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidadeMP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantidadeMP.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidadeMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantidadeMP.Caption = "Quantidade";
            this.colQuantidadeMP.FieldName = "Quantidade";
            this.colQuantidadeMP.Name = "colQuantidadeMP";
            this.colQuantidadeMP.Visible = true;
            this.colQuantidadeMP.VisibleIndex = 2;
            this.colQuantidadeMP.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(67, 55);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 600;
            this.txtDescricao.Size = new System.Drawing.Size(592, 55);
            this.txtDescricao.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Versão:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lkbProduto
            // 
            this.lkbProduto.Location = new System.Drawing.Point(635, 3);
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbProduto.TabIndex = 2;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "...";
            this.lkbProduto.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // lkProduto
            // 
            this.lkProduto.ButtonLookup = this.lkbProduto;
            this.lkProduto.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkProduto.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkProduto.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkProduto.ContextoLinq = null;
            this.lkProduto.ID = 0;
            this.lkProduto.Join = null;
            this.lkProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkProduto.Location = new System.Drawing.Point(67, 3);
            this.lkProduto.Name = "lkProduto";
            this.lkProduto.OnIDChanged = null;
            this.lkProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkProduto.Size = new System.Drawing.Size(562, 20);
            this.lkProduto.Tabela = "Produto";
            this.lkProduto.TabIndex = 1;
            this.lkProduto.TituloTelaPesquisa = "Pesquisa - Produto";
            this.lkProduto.Where = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.sbIncluirEtapa);
            this.xtraTabPage3.Controls.Add(this.sbAlterarEtapa);
            this.xtraTabPage3.Controls.Add(this.sbExcluirEtapa);
            this.xtraTabPage3.Controls.Add(this.gcEtapas);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(662, 467);
            this.xtraTabPage3.Text = "Etapas";
            // 
            // sbIncluirEtapa
            // 
            this.sbIncluirEtapa.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluirEtapa.ImageIndex = 4;
            this.sbIncluirEtapa.Location = new System.Drawing.Point(428, 441);
            this.sbIncluirEtapa.Name = "sbIncluirEtapa";
            this.sbIncluirEtapa.Size = new System.Drawing.Size(75, 23);
            this.sbIncluirEtapa.TabIndex = 12;
            this.sbIncluirEtapa.Text = "&Incluir";
            this.sbIncluirEtapa.Click += new System.EventHandler(this.sbIncluirEtapa_Click);
            // 
            // sbAlterarEtapa
            // 
            this.sbAlterarEtapa.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.sbAlterarEtapa.ImageIndex = 5;
            this.sbAlterarEtapa.Location = new System.Drawing.Point(506, 441);
            this.sbAlterarEtapa.Name = "sbAlterarEtapa";
            this.sbAlterarEtapa.Size = new System.Drawing.Size(75, 22);
            this.sbAlterarEtapa.TabIndex = 13;
            this.sbAlterarEtapa.Text = "&Alterar";
            this.sbAlterarEtapa.Click += new System.EventHandler(this.sbAlterarEtapa_Click);
            // 
            // sbExcluirEtapa
            // 
            this.sbExcluirEtapa.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluirEtapa.ImageIndex = 6;
            this.sbExcluirEtapa.Location = new System.Drawing.Point(584, 441);
            this.sbExcluirEtapa.Name = "sbExcluirEtapa";
            this.sbExcluirEtapa.Size = new System.Drawing.Size(75, 23);
            this.sbExcluirEtapa.TabIndex = 14;
            this.sbExcluirEtapa.Text = "&Excluir";
            this.sbExcluirEtapa.Click += new System.EventHandler(this.sbExcluirEtapa_Click);
            // 
            // gcEtapas
            // 
            this.gcEtapas.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcEtapas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcEtapas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcEtapas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcEtapas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcEtapas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcEtapas.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcEtapas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcEtapas.EmbeddedNavigator.Name = "";
            this.gcEtapas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcEtapas.Location = new System.Drawing.Point(4, 3);
            this.gcEtapas.MainView = this.gvEtapas;
            this.gcEtapas.Name = "gcEtapas";
            this.gcEtapas.Size = new System.Drawing.Size(655, 432);
            this.gcEtapas.TabIndex = 9;
            this.gcEtapas.TabStop = false;
            this.gcEtapas.UseEmbeddedNavigator = true;
            this.gcEtapas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtapas});
            this.gcEtapas.DoubleClick += new System.EventHandler(this.gcEtapas_DoubleClick);
            // 
            // gvEtapas
            // 
            this.gvEtapas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEtapas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEtapas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEtapas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEtapas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.Empty.Options.UseBackColor = true;
            this.gvEtapas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEtapas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEtapas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEtapas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEtapas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEtapas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEtapas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEtapas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEtapas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEtapas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEtapas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEtapas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEtapas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEtapas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEtapas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEtapas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEtapas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEtapas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEtapas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEtapas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEtapas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEtapas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEtapas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEtapas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEtapas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEtapas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEtapas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEtapas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEtapas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEtapas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEtapas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEtapas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEtapas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEtapas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEtapas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEtapas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEtapas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEtapas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvEtapas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.Preview.Options.UseFont = true;
            this.gvEtapas.Appearance.Preview.Options.UseForeColor = true;
            this.gvEtapas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEtapas.Appearance.Row.Options.UseBackColor = true;
            this.gvEtapas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvEtapas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEtapas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEtapas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEtapas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEtapas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvEtapas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEtapas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvEtapas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvEtapas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAcaoEtapa,
            this.colSequenciaEtapa,
            this.colObservacaoEtapa,
            this.colIDEtapa,
            this.colIDProdutoEtapa,
            this.colTituloEtapa,
            this.colIDServicoEtapa});
            this.gvEtapas.GridControl = this.gcEtapas;
            this.gvEtapas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvEtapas.Name = "gvEtapas";
            this.gvEtapas.OptionsBehavior.Editable = false;
            this.gvEtapas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvEtapas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEtapas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEtapas.OptionsView.ShowGroupPanel = false;
            // 
            // colAcaoEtapa
            // 
            this.colAcaoEtapa.Caption = "Ação";
            this.colAcaoEtapa.FieldName = "Acao";
            this.colAcaoEtapa.Name = "colAcaoEtapa";
            // 
            // colSequenciaEtapa
            // 
            this.colSequenciaEtapa.AppearanceCell.Options.UseTextOptions = true;
            this.colSequenciaEtapa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSequenciaEtapa.AppearanceHeader.Options.UseTextOptions = true;
            this.colSequenciaEtapa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSequenciaEtapa.Caption = "Sequência";
            this.colSequenciaEtapa.FieldName = "Sequencia";
            this.colSequenciaEtapa.Name = "colSequenciaEtapa";
            this.colSequenciaEtapa.Visible = true;
            this.colSequenciaEtapa.VisibleIndex = 0;
            // 
            // colObservacaoEtapa
            // 
            this.colObservacaoEtapa.Caption = "Observação";
            this.colObservacaoEtapa.FieldName = "Observacao";
            this.colObservacaoEtapa.Name = "colObservacaoEtapa";
            this.colObservacaoEtapa.Width = 249;
            // 
            // colIDEtapa
            // 
            this.colIDEtapa.Caption = "ID";
            this.colIDEtapa.FieldName = "ID";
            this.colIDEtapa.Name = "colIDEtapa";
            // 
            // colIDProdutoEtapa
            // 
            this.colIDProdutoEtapa.Caption = "IDProduto";
            this.colIDProdutoEtapa.FieldName = "IDProduto";
            this.colIDProdutoEtapa.Name = "colIDProdutoEtapa";
            // 
            // colTituloEtapa
            // 
            this.colTituloEtapa.Caption = "Título";
            this.colTituloEtapa.FieldName = "Titulo";
            this.colTituloEtapa.Name = "colTituloEtapa";
            this.colTituloEtapa.Visible = true;
            this.colTituloEtapa.VisibleIndex = 1;
            this.colTituloEtapa.Width = 90;
            // 
            // colIDServicoEtapa
            // 
            this.colIDServicoEtapa.Caption = "IDServico";
            this.colIDServicoEtapa.FieldName = "IDServico";
            this.colIDServicoEtapa.Name = "colIDServicoEtapa";
            // 
            // FormManutFichaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(710, 566);
            this.Name = "FormManutFichaTecnica";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEtapas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtapas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraGrid.GridControl gcMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMP;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoMP;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoMP;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeMP;
        private DevExpress.XtraEditors.SimpleButton btIncluirMP;
        private DevExpress.XtraEditors.SimpleButton btAlterarMP;
        private DevExpress.XtraEditors.SimpleButton btExcluirMP;
        private DevExpress.XtraGrid.Columns.GridColumn colAcaoMP;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProdutoMP;
        private Cwork.Utilitarios.Componentes.DevSpinEdit txtVersao;
        private DevExpress.XtraEditors.SimpleButton sbIncluirEtapa;
        private DevExpress.XtraEditors.SimpleButton sbAlterarEtapa;
        private DevExpress.XtraEditors.SimpleButton sbExcluirEtapa;
        private DevExpress.XtraGrid.GridControl gcEtapas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtapas;
        private DevExpress.XtraGrid.Columns.GridColumn colAcaoEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn colSequenciaEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacaoEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProdutoEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn colTituloEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn colIDServicoEtapa;
    }
}
