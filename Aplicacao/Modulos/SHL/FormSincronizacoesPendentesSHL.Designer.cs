namespace Aplicacao.Modulos.SHL
{
    partial class FormSincronizacoesPendentesSHL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSincronizacoesPendentesSHL));
            this.sbSincronizar = new DevExpress.XtraEditors.SimpleButton();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcSincronizacoes = new DevExpress.XtraGrid.GridControl();
            this.gvSincronizacoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoErro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Erro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // sbSincronizar
            // 
            this.sbSincronizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSincronizar.Image = global::Aplicacao.Properties.Resources._1333658965_arrow_refresh;
            this.sbSincronizar.ImageIndex = 1;
            this.sbSincronizar.Location = new System.Drawing.Point(605, 413);
            this.sbSincronizar.Name = "sbSincronizar";
            this.sbSincronizar.Size = new System.Drawing.Size(82, 23);
            this.sbSincronizar.TabIndex = 8;
            this.sbSincronizar.Text = "&Sincronizar";
            this.sbSincronizar.Click += new System.EventHandler(this.sbSincronizar_Click);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(7, 413);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 10;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(693, 413);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 9;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(7, 7);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(761, 400);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcSincronizacoes);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(755, 394);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcSincronizacoes
            // 
            this.gcSincronizacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSincronizacoes.Location = new System.Drawing.Point(4, 3);
            this.gcSincronizacoes.MainView = this.gvSincronizacoes;
            this.gcSincronizacoes.Name = "gcSincronizacoes";
            this.gcSincronizacoes.Size = new System.Drawing.Size(745, 388);
            this.gcSincronizacoes.TabIndex = 14;
            this.gcSincronizacoes.UseEmbeddedNavigator = true;
            this.gcSincronizacoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSincronizacoes});
            // 
            // gvSincronizacoes
            // 
            this.gvSincronizacoes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.Empty.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvSincronizacoes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvSincronizacoes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvSincronizacoes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvSincronizacoes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvSincronizacoes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvSincronizacoes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvSincronizacoes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvSincronizacoes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvSincronizacoes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.OddRow.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvSincronizacoes.Appearance.OddRow.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvSincronizacoes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.Preview.Options.UseFont = true;
            this.gvSincronizacoes.Appearance.Preview.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSincronizacoes.Appearance.Row.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvSincronizacoes.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvSincronizacoes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSincronizacoes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvSincronizacoes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvSincronizacoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.TipoErro,
            this.Erro});
            this.gvSincronizacoes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvSincronizacoes.GridControl = this.gcSincronizacoes;
            this.gvSincronizacoes.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvSincronizacoes.Name = "gvSincronizacoes";
            this.gvSincronizacoes.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvSincronizacoes.OptionsView.ColumnAutoWidth = false;
            this.gvSincronizacoes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSincronizacoes.OptionsView.EnableAppearanceOddRow = true;
            this.gvSincronizacoes.OptionsView.ShowAutoFilterRow = true;
            this.gvSincronizacoes.OptionsView.ShowFooter = true;
            this.gvSincronizacoes.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvSincronizacoes_CustomDrawGroupPanel);
            // 
            // Selecionado
            // 
            this.Selecionado.AppearanceHeader.Options.UseTextOptions = true;
            this.Selecionado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Selecionado.Caption = "Selecionado";
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            this.Selecionado.Width = 100;
            // 
            // TipoErro
            // 
            this.TipoErro.AppearanceHeader.Options.UseTextOptions = true;
            this.TipoErro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TipoErro.Caption = "Tipo Sincronismo";
            this.TipoErro.FieldName = "TipoErro";
            this.TipoErro.Name = "TipoErro";
            this.TipoErro.OptionsColumn.ReadOnly = true;
            this.TipoErro.Visible = true;
            this.TipoErro.VisibleIndex = 1;
            this.TipoErro.Width = 180;
            // 
            // Erro
            // 
            this.Erro.AppearanceHeader.Options.UseTextOptions = true;
            this.Erro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Erro.Caption = "Erro";
            this.Erro.FieldName = "Erro";
            this.Erro.Name = "Erro";
            this.Erro.OptionsColumn.ReadOnly = true;
            this.Erro.Visible = true;
            this.Erro.VisibleIndex = 2;
            this.Erro.Width = 1200;
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(214, 413);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 16;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(88, 413);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 15;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // FormSincronizacoesPendentesSHL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 443);
            this.Controls.Add(this.sbLimparSelecao);
            this.Controls.Add(this.sbSincronizar);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbSelecionarTodos);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSincronizacoesPendentesSHL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronismos Pendentes SHL";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbSincronizar;
        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraGrid.GridControl gcSincronizacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSincronizacoes;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraGrid.Columns.GridColumn TipoErro;
        private DevExpress.XtraGrid.Columns.GridColumn Erro;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
    }
}