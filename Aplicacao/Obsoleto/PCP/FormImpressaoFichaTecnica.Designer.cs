namespace Aplicacao.Obsoleto.PCP
{
    partial class FormImpressaoFichaTecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImpressaoFichaTecnica));
            DevExpress.XtraGrid.Columns.GridColumn CodigoProduto;
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.gcFT = new DevExpress.XtraGrid.GridControl();
            this.gvFT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoFicha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            CodigoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(944, 513);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcFT);
            this.xtraTabPage1.Size = new System.Drawing.Size(938, 507);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(881, 531);
            this.sbCancelar.TabIndex = 6;
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
            this.sbGravar.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.Image")));
            this.sbGravar.Location = new System.Drawing.Point(800, 531);
            this.sbGravar.TabIndex = 5;
            this.sbGravar.Text = "Imprimir";
            // 
            // sbAjuda
            // 
            this.sbAjuda.TabIndex = 2;
            // 
            // CodigoProduto
            // 
            CodigoProduto.AppearanceCell.Options.UseTextOptions = true;
            CodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            CodigoProduto.AppearanceHeader.Options.UseTextOptions = true;
            CodigoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CodigoProduto.Caption = "Código do Produto";
            CodigoProduto.FieldName = "Produto.Codigo";
            CodigoProduto.Name = "CodigoProduto";
            CodigoProduto.OptionsColumn.AllowEdit = false;
            CodigoProduto.Visible = true;
            CodigoProduto.VisibleIndex = 1;
            CodigoProduto.Width = 174;
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = ((System.Drawing.Image)(resources.GetObject("sbSelecionarTodos.Image")));
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(93, 531);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 3;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // gcFT
            // 
            this.gcFT.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFT.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcFT.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcFT.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcFT.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcFT.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcFT.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcFT.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcFT.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcFT.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcFT.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFT.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcFT.Location = new System.Drawing.Point(3, 3);
            this.gcFT.MainView = this.gvFT;
            this.gcFT.Name = "gcFT";
            this.gcFT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcFT.Size = new System.Drawing.Size(932, 501);
            this.gcFT.TabIndex = 19;
            this.gcFT.UseEmbeddedNavigator = true;
            this.gcFT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFT});
            // 
            // gvFT
            // 
            this.gvFT.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFT.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFT.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFT.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFT.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFT.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFT.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFT.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFT.Appearance.Empty.Options.UseBackColor = true;
            this.gvFT.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFT.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFT.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFT.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFT.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFT.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFT.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFT.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFT.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFT.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFT.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFT.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFT.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFT.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFT.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFT.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFT.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFT.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvFT.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFT.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFT.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFT.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFT.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvFT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFT.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFT.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFT.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFT.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFT.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFT.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFT.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFT.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFT.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFT.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFT.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFT.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFT.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFT.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFT.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFT.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFT.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFT.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFT.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFT.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFT.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvFT.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFT.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFT.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFT.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFT.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFT.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFT.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFT.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.Preview.Options.UseFont = true;
            this.gvFT.Appearance.Preview.Options.UseForeColor = true;
            this.gvFT.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFT.Appearance.Row.Options.UseBackColor = true;
            this.gvFT.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFT.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvFT.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFT.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFT.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvFT.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFT.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFT.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFT.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            CodigoProduto,
            this.Descricao,
            this.Nome,
            this.CodigoFicha});
            this.gvFT.GridControl = this.gcFT;
            this.gvFT.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFT.Name = "gvFT";
            this.gvFT.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvFT.OptionsSelection.MultiSelect = true;
            this.gvFT.OptionsView.ColumnAutoWidth = false;
            this.gvFT.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFT.OptionsView.EnableAppearanceOddRow = true;
            this.gvFT.OptionsView.ShowAutoFilterRow = true;
            this.gvFT.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvFT_CustomDrawGroupPanel);
            // 
            // Selecionado
            // 
            this.Selecionado.Caption = "Selecionado";
            this.Selecionado.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Descricao
            // 
            this.Descricao.AppearanceHeader.Options.UseTextOptions = true;
            this.Descricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "Produto.DescLonga1";
            this.Descricao.Name = "Descricao";
            this.Descricao.OptionsColumn.AllowEdit = false;
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 3;
            this.Descricao.Width = 209;
            // 
            // Nome
            // 
            this.Nome.AppearanceHeader.Options.UseTextOptions = true;
            this.Nome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Nome.Caption = "Versão";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.OptionsColumn.AllowEdit = false;
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 2;
            this.Nome.Width = 324;
            // 
            // CodigoFicha
            // 
            this.CodigoFicha.AppearanceHeader.Options.UseTextOptions = true;
            this.CodigoFicha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CodigoFicha.Caption = "Código da Ficha";
            this.CodigoFicha.FieldName = "Codigo";
            this.CodigoFicha.Name = "CodigoFicha";
            this.CodigoFicha.OptionsColumn.AllowEdit = false;
            this.CodigoFicha.Visible = true;
            this.CodigoFicha.VisibleIndex = 4;
            this.CodigoFicha.Width = 133;
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = ((System.Drawing.Image)(resources.GetObject("sbLimparSelecao.Image")));
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(219, 531);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 4;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // FormImpressaoFichaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 566);
            this.Controls.Add(this.sbLimparSelecao);
            this.Controls.Add(this.sbSelecionarTodos);
            this.Name = "FormImpressaoFichaTecnica";
            this.Text = "Impressão de ficha técnica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImpressaoFichaTecnica_FormClosing);
            this.Load += new System.EventHandler(this.FormImpressaoFichaTecnica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImpressaoFichaTecnica_KeyDown);
            this.Controls.SetChildIndex(this.sbSelecionarTodos, 0);
            this.Controls.SetChildIndex(this.sbLimparSelecao, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        public DevExpress.XtraGrid.GridControl gcFT;
        public DevExpress.XtraGrid.Views.Grid.GridView gvFT;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoFicha;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;

    }
}