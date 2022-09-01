namespace Aplicacao.Modulos.Magento
{
    partial class FormPedidosPendentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidosPendentes));
            this.gcSincronizacoes = new DevExpress.XtraGrid.GridControl();
            this.gvSincronizacoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDIntegracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDPedidoMagento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClienteNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.Sincronizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(861, 441);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.sbLimparSelecao);
            this.xtraTabPage1.Controls.Add(this.sbSelecionarTodos);
            this.xtraTabPage1.Controls.Add(this.gcSincronizacoes);
            this.xtraTabPage1.Size = new System.Drawing.Size(855, 435);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(798, 459);
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click_1);
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
            this.sbGravar.Image = global::Aplicacao.Properties.Resources._1333658965_arrow_refresh;
            this.sbGravar.Location = new System.Drawing.Point(529, 459);
            this.sbGravar.Size = new System.Drawing.Size(80, 23);
            this.sbGravar.Text = "&Sincronizar";
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 459);
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
            this.gcSincronizacoes.Location = new System.Drawing.Point(12, 12);
            this.gcSincronizacoes.MainView = this.gvSincronizacoes;
            this.gcSincronizacoes.Name = "gcSincronizacoes";
            this.gcSincronizacoes.Size = new System.Drawing.Size(831, 389);
            this.gcSincronizacoes.TabIndex = 15;
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
            this.gridColumn12,
            this.IDIntegracao,
            this.IDPedidoMagento,
            this.ClienteNome,
            this.Selecionado});
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
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "Erro";
            this.gridColumn12.FieldName = "Erro";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            this.gridColumn12.Width = 428;
            // 
            // IDIntegracao
            // 
            this.IDIntegracao.Caption = "ID Pedido Magento";
            this.IDIntegracao.FieldName = "IDIntegracao";
            this.IDIntegracao.Name = "IDIntegracao";
            this.IDIntegracao.OptionsColumn.ReadOnly = true;
            this.IDIntegracao.Visible = true;
            this.IDIntegracao.VisibleIndex = 1;
            this.IDIntegracao.Width = 99;
            // 
            // IDPedidoMagento
            // 
            this.IDPedidoMagento.Caption = "Número do Pedido";
            this.IDPedidoMagento.FieldName = "IDPedidoMagento";
            this.IDPedidoMagento.Name = "IDPedidoMagento";
            this.IDPedidoMagento.OptionsColumn.ReadOnly = true;
            this.IDPedidoMagento.Visible = true;
            this.IDPedidoMagento.VisibleIndex = 2;
            this.IDPedidoMagento.Width = 103;
            // 
            // ClienteNome
            // 
            this.ClienteNome.Caption = "Cliente";
            this.ClienteNome.FieldName = "ClienteNome";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.OptionsColumn.ReadOnly = true;
            this.ClienteNome.Visible = true;
            this.ClienteNome.VisibleIndex = 3;
            this.ClienteNome.Width = 124;
            // 
            // Selecionado
            // 
            this.Selecionado.Caption = "Selecionar";
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            this.Selecionado.Width = 59;
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(135, 407);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 18;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(12, 407);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 17;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // Sincronizar
            // 
            this.Sincronizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sincronizar.Image = global::Aplicacao.Properties.Resources._1333658965_arrow_refresh;
            this.Sincronizar.ImageIndex = 6;
            this.Sincronizar.Location = new System.Drawing.Point(707, 459);
            this.Sincronizar.Name = "Sincronizar";
            this.Sincronizar.Size = new System.Drawing.Size(85, 23);
            this.Sincronizar.TabIndex = 18;
            this.Sincronizar.Text = "&Sincronizar";
            this.Sincronizar.Click += new System.EventHandler(this.Sincronizar_Click);
            // 
            // FormPedidosPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 494);
            this.Controls.Add(this.Sincronizar);
            this.Name = "FormPedidosPendentes";
            this.Text = "Pedidos Pendentes";
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.Sincronizar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSincronizacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSincronizacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSincronizacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSincronizacoes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        private DevExpress.XtraGrid.Columns.GridColumn IDIntegracao;
        private DevExpress.XtraGrid.Columns.GridColumn IDPedidoMagento;
        private DevExpress.XtraGrid.Columns.GridColumn ClienteNome;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraEditors.SimpleButton Sincronizar;
    }
}