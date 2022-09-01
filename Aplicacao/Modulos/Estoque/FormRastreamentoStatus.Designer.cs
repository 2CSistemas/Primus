namespace Aplicacao.Modulos.Estoque
{
    partial class FormRastreamentoStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRastreamentoStatus));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcRastreamentos = new DevExpress.XtraGrid.GridControl();
            this.gvRastreamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnDataEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRastreamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRastreamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(2, "Fechar.ico");
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 9);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(472, 401);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcRastreamentos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(466, 395);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcRastreamentos
            // 
            this.gcRastreamentos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcRastreamentos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcRastreamentos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcRastreamentos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcRastreamentos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcRastreamentos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcRastreamentos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcRastreamentos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcRastreamentos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcRastreamentos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcRastreamentos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcRastreamentos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcRastreamentos.Location = new System.Drawing.Point(3, 3);
            this.gcRastreamentos.MainView = this.gvRastreamentos;
            this.gcRastreamentos.Name = "gcRastreamentos";
            this.gcRastreamentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit3,
            this.repositoryItemCalcEdit4});
            this.gcRastreamentos.Size = new System.Drawing.Size(460, 388);
            this.gcRastreamentos.TabIndex = 0;
            this.gcRastreamentos.UseEmbeddedNavigator = true;
            this.gcRastreamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRastreamentos});
            // 
            // gvRastreamentos
            // 
            this.gvRastreamentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRastreamentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRastreamentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRastreamentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRastreamentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRastreamentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRastreamentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvRastreamentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvRastreamentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.Preview.Options.UseFont = true;
            this.gvRastreamentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentos.Appearance.Row.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvRastreamentos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRastreamentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRastreamentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvRastreamentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvRastreamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnDataEvento,
            this.columnDescricao});
            this.gvRastreamentos.GridControl = this.gcRastreamentos;
            this.gvRastreamentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvRastreamentos.Name = "gvRastreamentos";
            this.gvRastreamentos.OptionsBehavior.Editable = false;
            this.gvRastreamentos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvRastreamentos.OptionsSelection.MultiSelect = true;
            this.gvRastreamentos.OptionsView.ColumnAutoWidth = false;
            this.gvRastreamentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRastreamentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvRastreamentos.OptionsView.ShowAutoFilterRow = true;
            // 
            // columnDataEvento
            // 
            this.columnDataEvento.AppearanceCell.Options.UseTextOptions = true;
            this.columnDataEvento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnDataEvento.Caption = "Data";
            this.columnDataEvento.FieldName = "DataEvento";
            this.columnDataEvento.Name = "columnDataEvento";
            this.columnDataEvento.Visible = true;
            this.columnDataEvento.VisibleIndex = 0;
            this.columnDataEvento.Width = 90;
            // 
            // columnDescricao
            // 
            this.columnDescricao.Caption = "Descrição";
            this.columnDescricao.FieldName = "StatusEntEventoCorreio.EventosCorreio.Descricao";
            this.columnDescricao.Name = "columnDescricao";
            this.columnDescricao.Visible = true;
            this.columnDescricao.VisibleIndex = 1;
            this.columnDescricao.Width = 349;
            // 
            // repositoryItemCalcEdit3
            // 
            this.repositoryItemCalcEdit3.AutoHeight = false;
            this.repositoryItemCalcEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit3.LookAndFeel.SkinName = "Caramel";
            this.repositoryItemCalcEdit3.Name = "repositoryItemCalcEdit3";
            // 
            // repositoryItemCalcEdit4
            // 
            this.repositoryItemCalcEdit4.AutoHeight = false;
            this.repositoryItemCalcEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit4.LookAndFeel.SkinName = "Caramel";
            this.repositoryItemCalcEdit4.Name = "repositoryItemCalcEdit4";
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 416);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 3;
            this.btAjuda.Text = "&Ajuda";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.ImageIndex = 2;
            this.btFechar.ImageList = this.imageList1;
            this.btFechar.Location = new System.Drawing.Point(409, 416);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // FormRastreamentoStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 451);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormRastreamentoStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Rastreamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRastreamentoStatus_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRastreamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRastreamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        public DevExpress.XtraGrid.GridControl gcRastreamentos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvRastreamentos;
        private DevExpress.XtraGrid.Columns.GridColumn columnDataEvento;
        private DevExpress.XtraGrid.Columns.GridColumn columnDescricao;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit4;
    }
}