namespace Aplicacao.PCP
{
    partial class FormManutOrdemProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutOrdemProducao));
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.sbIncluirExecucao = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterarExecucao = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluirExecucao = new DevExpress.XtraEditors.SimpleButton();
            this.gcExecucao = new DevExpress.XtraGrid.GridControl();
            this.gvExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSequenciaExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServicoExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataTermino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuncionarioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblExecucao = new DevExpress.XtraEditors.LabelControl();
            this.lkbClassificacao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkClassificacao = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClassificacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(624, 493);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Size = new System.Drawing.Size(615, 484);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(561, 511);
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
            this.imageList1.Images.SetKeyName(7, "Selecionar.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(480, 511);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 511);
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(5, 94);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(65, 13);
            this.labelControl23.TabIndex = 8;
            this.labelControl23.Text = "Classificação:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtCodigo.Properties.Mask.EditMask = "n0";
            this.txtCodigo.Properties.Precision = 0;
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl2.Size = new System.Drawing.Size(612, 481);
            this.xtraTabControl2.TabIndex = 0;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            this.xtraTabControl2.TabStop = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.sbIncluirExecucao);
            this.xtraTabPage2.Controls.Add(this.sbAlterarExecucao);
            this.xtraTabPage2.Controls.Add(this.sbExcluirExecucao);
            this.xtraTabPage2.Controls.Add(this.gcExecucao);
            this.xtraTabPage2.Controls.Add(this.lblExecucao);
            this.xtraTabPage2.Controls.Add(this.lkbClassificacao);
            this.xtraTabPage2.Controls.Add(this.lkClassificacao);
            this.xtraTabPage2.Controls.Add(this.lkbFilial);
            this.xtraTabPage2.Controls.Add(this.lkFilial);
            this.xtraTabPage2.Controls.Add(this.lkbPessoa);
            this.xtraTabPage2.Controls.Add(this.lkPessoa);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.txtCodigo);
            this.xtraTabPage2.Controls.Add(this.labelControl23);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(603, 450);
            this.xtraTabPage2.Text = "Ordem Produção";
            // 
            // sbIncluirExecucao
            // 
            this.sbIncluirExecucao.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluirExecucao.ImageIndex = 4;
            this.sbIncluirExecucao.Location = new System.Drawing.Point(369, 425);
            this.sbIncluirExecucao.Name = "sbIncluirExecucao";
            this.sbIncluirExecucao.Size = new System.Drawing.Size(75, 22);
            this.sbIncluirExecucao.TabIndex = 13;
            this.sbIncluirExecucao.Text = "&Incluir";
            this.sbIncluirExecucao.Click += new System.EventHandler(this.sbIncluirExecucao_Click);
            // 
            // sbAlterarExecucao
            // 
            this.sbAlterarExecucao.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.sbAlterarExecucao.ImageIndex = 5;
            this.sbAlterarExecucao.Location = new System.Drawing.Point(447, 425);
            this.sbAlterarExecucao.Name = "sbAlterarExecucao";
            this.sbAlterarExecucao.Size = new System.Drawing.Size(75, 22);
            this.sbAlterarExecucao.TabIndex = 14;
            this.sbAlterarExecucao.Text = "&Alterar";
            this.sbAlterarExecucao.Click += new System.EventHandler(this.sbAlterarExecucao_Click);
            // 
            // sbExcluirExecucao
            // 
            this.sbExcluirExecucao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluirExecucao.ImageIndex = 6;
            this.sbExcluirExecucao.Location = new System.Drawing.Point(525, 425);
            this.sbExcluirExecucao.Name = "sbExcluirExecucao";
            this.sbExcluirExecucao.Size = new System.Drawing.Size(75, 22);
            this.sbExcluirExecucao.TabIndex = 15;
            this.sbExcluirExecucao.Text = "&Excluir";
            this.sbExcluirExecucao.Click += new System.EventHandler(this.sbExcluirExecucao_Click);
            // 
            // gcExecucao
            // 
            this.gcExecucao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcExecucao.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcExecucao.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcExecucao.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcExecucao.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcExecucao.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcExecucao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcExecucao.EmbeddedNavigator.Name = "";
            this.gcExecucao.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcExecucao.Location = new System.Drawing.Point(5, 141);
            this.gcExecucao.LookAndFeel.UseWindowsXPTheme = true;
            this.gcExecucao.MainView = this.gvExecucao;
            this.gcExecucao.Name = "gcExecucao";
            this.gcExecucao.Size = new System.Drawing.Size(595, 278);
            this.gcExecucao.TabIndex = 12;
            this.gcExecucao.UseEmbeddedNavigator = true;
            this.gcExecucao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExecucao});
            // 
            // gvExecucao
            // 
            this.gvExecucao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvExecucao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvExecucao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.Empty.Options.UseBackColor = true;
            this.gvExecucao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExecucao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvExecucao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExecucao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvExecucao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvExecucao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvExecucao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvExecucao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvExecucao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvExecucao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvExecucao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvExecucao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvExecucao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvExecucao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.Preview.Options.UseFont = true;
            this.gvExecucao.Appearance.Preview.Options.UseForeColor = true;
            this.gvExecucao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvExecucao.Appearance.Row.Options.UseBackColor = true;
            this.gvExecucao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvExecucao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvExecucao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvExecucao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvExecucao.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvExecucao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvExecucao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvExecucao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvExecucao.BestFitMaxRowCount = 5;
            this.gvExecucao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSequenciaExecucao,
            this.colServicoExecucao,
            this.colDataInicioExecucao,
            this.colDataTermino,
            this.colFuncionarioExecucao,
            this.colIDExecucao});
            this.gvExecucao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvExecucao.GridControl = this.gcExecucao;
            this.gvExecucao.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvExecucao.Name = "gvExecucao";
            this.gvExecucao.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvExecucao.OptionsBehavior.Editable = false;
            this.gvExecucao.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvExecucao.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvExecucao.OptionsView.ColumnAutoWidth = false;
            this.gvExecucao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvExecucao.OptionsView.EnableAppearanceOddRow = true;
            this.gvExecucao.OptionsView.ShowAutoFilterRow = true;
            this.gvExecucao.OptionsView.ShowGroupPanel = false;
            this.gvExecucao.DoubleClick += new System.EventHandler(this.gcExecucao_DoubleClick);
            // 
            // colSequenciaExecucao
            // 
            this.colSequenciaExecucao.AppearanceCell.Options.UseTextOptions = true;
            this.colSequenciaExecucao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSequenciaExecucao.AppearanceHeader.Options.UseTextOptions = true;
            this.colSequenciaExecucao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSequenciaExecucao.Caption = "Seq.";
            this.colSequenciaExecucao.FieldName = "Sequencia";
            this.colSequenciaExecucao.Name = "colSequenciaExecucao";
            this.colSequenciaExecucao.Visible = true;
            this.colSequenciaExecucao.VisibleIndex = 0;
            this.colSequenciaExecucao.Width = 55;
            // 
            // colServicoExecucao
            // 
            this.colServicoExecucao.Caption = "Serviço";
            this.colServicoExecucao.FieldName = "Servico";
            this.colServicoExecucao.Name = "colServicoExecucao";
            this.colServicoExecucao.Visible = true;
            this.colServicoExecucao.VisibleIndex = 1;
            this.colServicoExecucao.Width = 281;
            // 
            // colDataInicioExecucao
            // 
            this.colDataInicioExecucao.Caption = "Início";
            this.colDataInicioExecucao.FieldName = "DataInicio";
            this.colDataInicioExecucao.Name = "colDataInicioExecucao";
            this.colDataInicioExecucao.Visible = true;
            this.colDataInicioExecucao.VisibleIndex = 2;
            // 
            // colDataTermino
            // 
            this.colDataTermino.Caption = "Término";
            this.colDataTermino.FieldName = "DataTermino";
            this.colDataTermino.Name = "colDataTermino";
            this.colDataTermino.Visible = true;
            this.colDataTermino.VisibleIndex = 3;
            // 
            // colFuncionarioExecucao
            // 
            this.colFuncionarioExecucao.Caption = "Funcionário";
            this.colFuncionarioExecucao.FieldName = "Funcionario";
            this.colFuncionarioExecucao.Name = "colFuncionarioExecucao";
            this.colFuncionarioExecucao.Visible = true;
            this.colFuncionarioExecucao.VisibleIndex = 4;
            this.colFuncionarioExecucao.Width = 282;
            // 
            // colIDExecucao
            // 
            this.colIDExecucao.Caption = "ID";
            this.colIDExecucao.FieldName = "ID";
            this.colIDExecucao.Name = "colIDExecucao";
            // 
            // lblExecucao
            // 
            this.lblExecucao.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecucao.Appearance.Options.UseFont = true;
            this.lblExecucao.Location = new System.Drawing.Point(5, 117);
            this.lblExecucao.Name = "lblExecucao";
            this.lblExecucao.Size = new System.Drawing.Size(70, 18);
            this.lblExecucao.TabIndex = 11;
            this.lblExecucao.Text = "Execução";
            // 
            // lkbClassificacao
            // 
            this.lkbClassificacao.Location = new System.Drawing.Point(576, 91);
            this.lkbClassificacao.Name = "lkbClassificacao";
            this.lkbClassificacao.Size = new System.Drawing.Size(24, 20);
            this.lkbClassificacao.TabIndex = 10;
            this.lkbClassificacao.TabStop = false;
            this.lkbClassificacao.Text = "...";
            this.lkbClassificacao.Click += new System.EventHandler(this.lkbClassificacao_Click);
            // 
            // lkClassificacao
            // 
            this.lkClassificacao.ButtonLookup = this.lkbClassificacao;
            this.lkClassificacao.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkClassificacao.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkClassificacao.ColunaTamanho = new string[] {
        "60",
        "140"};
            this.lkClassificacao.ContextoLinq = null;
            this.lkClassificacao.ID = 0;
            this.lkClassificacao.Join = null;
            this.lkClassificacao.Key = System.Windows.Forms.Keys.F5;
            this.lkClassificacao.Location = new System.Drawing.Point(76, 91);
            this.lkClassificacao.Name = "lkClassificacao";
            this.lkClassificacao.OnIDChanged = null;
            this.lkClassificacao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkClassificacao.Properties.Appearance.Options.UseBackColor = true;
            this.lkClassificacao.Size = new System.Drawing.Size(494, 20);
            this.lkClassificacao.Tabela = "ClassificacaoOrdemProducao";
            this.lkClassificacao.TabIndex = 9;
            this.lkClassificacao.TituloTelaPesquisa = "Pesquisa - Classificação";
            this.lkClassificacao.ToolTip = "Nome, Descrição";
            this.lkClassificacao.Where = null;
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(576, 39);
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.TabIndex = 4;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkFilial
            // 
            this.lkFilial.ButtonLookup = this.lkbFilial;
            this.lkFilial.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkFilial.ContextoLinq = null;
            this.lkFilial.ID = 0;
            this.lkFilial.Join = null;
            this.lkFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkFilial.Location = new System.Drawing.Point(76, 39);
            this.lkFilial.Name = "lkFilial";
            this.lkFilial.OnIDChanged = null;
            this.lkFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkFilial.Size = new System.Drawing.Size(494, 20);
            this.lkFilial.Tabela = "Filial";
            this.lkFilial.TabIndex = 3;
            this.lkFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkFilial.Where = null;
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(576, 65);
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.TabIndex = 7;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkPessoa
            // 
            this.lkPessoa.ButtonLookup = this.lkbPessoa;
            this.lkPessoa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkPessoa.ContextoLinq = null;
            this.lkPessoa.ID = 0;
            this.lkPessoa.Join = null;
            this.lkPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkPessoa.Location = new System.Drawing.Point(76, 65);
            this.lkPessoa.Name = "lkPessoa";
            this.lkPessoa.OnIDChanged = null;
            this.lkPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkPessoa.Size = new System.Drawing.Size(494, 20);
            this.lkPessoa.Tabela = "Pessoa";
            this.lkPessoa.TabIndex = 6;
            this.lkPessoa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkPessoa.Where = "Pessoa.bCliente = 1 AND ";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(25, 42);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Empresa:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Cliente:";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(603, 450);
            this.xtraTabPage3.Text = "Histórico";
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
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.gridControl1.MainView = this.dataGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(597, 444);
            this.gridControl1.TabIndex = 0;
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
            this.dataGridView1.BestFitMaxRowCount = 5;
            this.dataGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.dataGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dataGridView1.GridControl = this.gridControl1;
            this.dataGridView1.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.dataGridView1.OptionsBehavior.Editable = false;
            this.dataGridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.dataGridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.dataGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.dataGridView1.OptionsView.EnableAppearanceOddRow = true;
            this.dataGridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Data";
            this.gridColumn1.FieldName = "Data";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sequência";
            this.gridColumn2.FieldName = "Sequencia";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Classificação";
            this.gridColumn3.FieldName = "Classificacao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 272;
            // 
            // FormManutOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(648, 546);
            this.Name = "FormManutOrdemProducao";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClassificacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView dataGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkPessoa;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkFilial;
        private Cwork.Utilitarios.Componentes.LookupButton lkbClassificacao;
        private Cwork.Utilitarios.Componentes.Lookup lkClassificacao;
        private DevExpress.XtraEditors.LabelControl lblExecucao;
        public DevExpress.XtraGrid.GridControl gcExecucao;
        public DevExpress.XtraGrid.Views.Grid.GridView gvExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colSequenciaExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colServicoExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colFuncionarioExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colIDExecucao;
        private DevExpress.XtraEditors.SimpleButton sbIncluirExecucao;
        private DevExpress.XtraEditors.SimpleButton sbAlterarExecucao;
        private DevExpress.XtraEditors.SimpleButton sbExcluirExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicioExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTermino;
    }
}
