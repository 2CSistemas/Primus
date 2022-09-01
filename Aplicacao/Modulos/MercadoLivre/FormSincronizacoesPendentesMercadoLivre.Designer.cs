namespace Aplicacao.Modulos.MercadoLivre
{
    partial class FormSincronizacoesPendentesMercadoLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSincronizacoesPendentesMercadoLivre));
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.gcSincronizacoes = new DevExpress.XtraGrid.GridControl();
            this.gvSincronizacoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 413);
            // 
            // sbGravar
            // 
            this.sbGravar.Image = global::Aplicacao.Properties.Resources._1333658965_arrow_refresh;
            this.sbGravar.Location = new System.Drawing.Point(552, 413);
            this.sbGravar.Size = new System.Drawing.Size(101, 23);
            this.sbGravar.Text = "&Sincronizar";
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(659, 413);
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
            this.tpPrincipal.Controls.Add(this.gcSincronizacoes);
            this.tpPrincipal.Size = new System.Drawing.Size(716, 389);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(722, 395);
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(216, 413);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 19;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // gcSincronizacoes
            // 
            this.gcSincronizacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSincronizacoes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSincronizacoes.Location = new System.Drawing.Point(0, 0);
            this.gcSincronizacoes.MainView = this.gvSincronizacoes;
            this.gcSincronizacoes.Name = "gcSincronizacoes";
            this.gcSincronizacoes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcSincronizacoes.Size = new System.Drawing.Size(716, 389);
            this.gcSincronizacoes.TabIndex = 17;
            this.gcSincronizacoes.UseEmbeddedNavigator = true;
            this.gcSincronizacoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSincronizacoes});
            this.gcSincronizacoes.Click += new System.EventHandler(this.gcSincronizacoes_Click);
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Selecionado";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.FieldName = "Selecionado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Pedido";
            this.gridColumn2.FieldName = "PedidoMercadoLivre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Erro";
            this.gridColumn3.FieldName = "Erro";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 800;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Pessoa";
            this.gridColumn4.FieldName = "IdCliente.Nome";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 600;
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(93, 413);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 18;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // FormSincronizacoesPendentesMercadoLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 448);
            this.Controls.Add(this.sbLimparSelecao);
            this.Controls.Add(this.sbSelecionarTodos);
            this.MaximizeBox = true;
            this.Name = "FormSincronizacoesPendentesMercadoLivre";
            this.Text = "Sincronizações Pendentes Mercado Livre";
            this.Controls.SetChildIndex(this.sbSelecionarTodos, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbLimparSelecao, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraGrid.GridControl gcSincronizacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSincronizacoes;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}