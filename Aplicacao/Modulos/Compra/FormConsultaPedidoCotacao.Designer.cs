namespace Aplicacao
{
    partial class FormConsultaPedidoCotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPedidoCotacao));
            this.txtCotacao = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcPedidoItem = new DevExpress.XtraGrid.GridControl();
            this.gvPedidoItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCotacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 358);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(631, 358);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(712, 358);
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
            this.tpPrincipal.Controls.Add(this.txtCotacao);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.gcPedidoItem);
            this.tpPrincipal.Size = new System.Drawing.Size(766, 331);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(775, 340);
            // 
            // txtCotacao
            // 
            this.txtCotacao.CwkFuncaoValidacao = null;
            this.txtCotacao.CwkMascara = null;
            this.txtCotacao.CwkValidacao = null;
            this.txtCotacao.Location = new System.Drawing.Point(56, 3);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Properties.ReadOnly = true;
            this.txtCotacao.SelecionarTextoOnEnter = false;
            this.txtCotacao.Size = new System.Drawing.Size(705, 20);
            this.txtCotacao.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Cotação:";
            // 
            // gcPedidoItem
            // 
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Name = "";
            this.gcPedidoItem.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedidoItem.Location = new System.Drawing.Point(6, 29);
            this.gcPedidoItem.MainView = this.gvPedidoItem;
            this.gcPedidoItem.Name = "gcPedidoItem";
            this.gcPedidoItem.Size = new System.Drawing.Size(755, 297);
            this.gcPedidoItem.TabIndex = 8;
            this.gcPedidoItem.UseEmbeddedNavigator = true;
            this.gcPedidoItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidoItem});
            // 
            // gvPedidoItem
            // 
            this.gvPedidoItem.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.Empty.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidoItem.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidoItem.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidoItem.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidoItem.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidoItem.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidoItem.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvPedidoItem.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.Preview.Options.UseFont = true;
            this.gvPedidoItem.Appearance.Preview.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.Row.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPedidoItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPedido,
            this.colCodigoProduto,
            this.colProduto,
            this.colValor,
            this.colQuantidade,
            this.colTotal});
            this.gvPedidoItem.GridControl = this.gcPedidoItem;
            this.gvPedidoItem.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPedidoItem.Name = "gvPedidoItem";
            this.gvPedidoItem.OptionsBehavior.Editable = false;
            this.gvPedidoItem.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPedidoItem.OptionsSelection.MultiSelect = true;
            this.gvPedidoItem.OptionsView.ColumnAutoWidth = false;
            this.gvPedidoItem.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidoItem.OptionsView.EnableAppearanceOddRow = true;
            // 
            // colPedido
            // 
            this.colPedido.Caption = "Pedido";
            this.colPedido.FieldName = "CodigoPedido";
            this.colPedido.Name = "colPedido";
            this.colPedido.Visible = true;
            this.colPedido.VisibleIndex = 0;
            this.colPedido.Width = 90;
            // 
            // colCodigoProduto
            // 
            this.colCodigoProduto.Caption = "Cód. Produto";
            this.colCodigoProduto.FieldName = "CodigoProduto";
            this.colCodigoProduto.Name = "colCodigoProduto";
            this.colCodigoProduto.Visible = true;
            this.colCodigoProduto.VisibleIndex = 1;
            // 
            // colProduto
            // 
            this.colProduto.Caption = "Produto";
            this.colProduto.FieldName = "NomeProduto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 2;
            this.colProduto.Width = 340;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.DisplayFormat.FormatString = "c2";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 3;
            this.colValor.Width = 100;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Caption = "Quantidade";
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 4;
            this.colQuantidade.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "c2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 150;
            // 
            // FormConsultaPedidoCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(799, 393);
            this.Name = "FormConsultaPedidoCotacao";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCotacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevTextEdit txtCotacao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraGrid.GridControl gcPedidoItem;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidoItem;
        private DevExpress.XtraGrid.Columns.GridColumn colPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
    }
}
