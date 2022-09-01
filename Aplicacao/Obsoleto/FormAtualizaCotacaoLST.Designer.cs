namespace Aplicacao
{
    partial class FormAtualizaCotacaoLST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizaCotacaoLST));
            this.gcPedidosItem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Selec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btPedidos = new Componentes.devexpress.cwk_DevButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPedidos = new Componentes.devexpress.cwk_DevLookup();
            this.btnNenhum = new DevExpress.XtraEditors.SimpleButton();
            this.btnTodos = new DevExpress.XtraEditors.SimpleButton();
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidosItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPedidos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPedidosItem
            // 
            this.gcPedidosItem.EmbeddedNavigator.Name = "";
            this.gcPedidosItem.Location = new System.Drawing.Point(13, 38);
            this.gcPedidosItem.MainView = this.gridView1;
            this.gcPedidosItem.Name = "gcPedidosItem";
            this.gcPedidosItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcPedidosItem.Size = new System.Drawing.Size(557, 184);
            this.gcPedidosItem.TabIndex = 3;
            this.gcPedidosItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Sequencia,
            this.Produto,
            this.Quantidade,
            this.Selec});
            this.gridView1.GridControl = this.gcPedidosItem;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 20;
            // 
            // Sequencia
            // 
            this.Sequencia.Caption = "Seq.";
            this.Sequencia.FieldName = "Sequencia";
            this.Sequencia.Name = "Sequencia";
            this.Sequencia.Visible = true;
            this.Sequencia.VisibleIndex = 0;
            this.Sequencia.Width = 40;
            // 
            // Produto
            // 
            this.Produto.Caption = "Produto";
            this.Produto.FieldName = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 1;
            this.Produto.Width = 165;
            // 
            // Quantidade
            // 
            this.Quantidade.Caption = "Qtd.";
            this.Quantidade.FieldName = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Visible = true;
            this.Quantidade.VisibleIndex = 2;
            this.Quantidade.Width = 40;
            // 
            // Selec
            // 
            this.Selec.Caption = "Selec.";
            this.Selec.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Selec.FieldName = "Selec";
            this.Selec.Name = "Selec";
            this.Selec.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Selec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.Selec.OptionsColumn.AllowMove = false;
            this.Selec.OptionsColumn.AllowSize = false;
            this.Selec.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.Selec.OptionsColumn.FixedWidth = true;
            this.Selec.Visible = true;
            this.Selec.VisibleIndex = 3;
            this.Selec.Width = 40;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btPedidos
            // 
            this.btPedidos.Location = new System.Drawing.Point(546, 12);
            this.btPedidos.Name = "btPedidos";
            this.btPedidos.Size = new System.Drawing.Size(24, 20);
            this.btPedidos.TabIndex = 2;
            this.btPedidos.TabStop = false;
            this.btPedidos.Text = "...";
            this.btPedidos.Click += new System.EventHandler(this.btPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // cbPedidos
            // 
            this.cbPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbPedidos.ButtonLookup = this.btPedidos;
            this.cbPedidos.Key = System.Windows.Forms.Keys.F5;
            this.cbPedidos.Location = new System.Drawing.Point(59, 12);
            this.cbPedidos.Name = "cbPedidos";
            this.cbPedidos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPedidos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbPedidos.Properties.DisplayMember = "Nome";
            this.cbPedidos.Properties.NullText = "";
            this.cbPedidos.Properties.ValueMember = "ID";
            this.cbPedidos.Size = new System.Drawing.Size(481, 20);
            this.cbPedidos.TabIndex = 1;
            this.cbPedidos.EditValueChanged += new System.EventHandler(this.cbPedidos_EditValueChanged);
            // 
            // btnNenhum
            // 
            this.btnNenhum.ImageIndex = 4;
            this.btnNenhum.Location = new System.Drawing.Point(333, 228);
            this.btnNenhum.Name = "btnNenhum";
            this.btnNenhum.Size = new System.Drawing.Size(75, 23);
            this.btnNenhum.TabIndex = 5;
            this.btnNenhum.Text = "&Nenhum";
            this.btnNenhum.Click += new System.EventHandler(this.btnNenhum_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.ImageIndex = 4;
            this.btnTodos.Location = new System.Drawing.Point(252, 228);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.btExcluir.ImageIndex = 5;
            this.btExcluir.Location = new System.Drawing.Point(495, 228);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "&Cancelar";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterar.ImageIndex = 4;
            this.btAlterar.Location = new System.Drawing.Point(414, 228);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 6;
            this.btAlterar.Text = "&Atualizar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // FormAtualizaCotacaoLST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 258);
            this.Controls.Add(this.btnNenhum);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPedidos);
            this.Controls.Add(this.gcPedidosItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAtualizaCotacaoLST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAtualizaCotacaoLST";
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidosItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPedidos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPedidosItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Sequencia;
        private DevExpress.XtraGrid.Columns.GridColumn Produto;
        private DevExpress.XtraGrid.Columns.GridColumn Quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn Selec;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private Componentes.devexpress.cwk_DevButton btPedidos;
        private System.Windows.Forms.Label label1;
        private Componentes.devexpress.cwk_DevLookup cbPedidos;
        private DevExpress.XtraEditors.SimpleButton btnNenhum;
        private DevExpress.XtraEditors.SimpleButton btnTodos;
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
    }
}