namespace Aplicacao.Modulos.Comercial
{
    partial class FormImprimeEtiquetaCorreios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImprimeEtiquetaCorreios));
            this.txtPosicao = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.gcProdutos = new DevExpress.XtraGrid.GridControl();
            this.gvProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPosicao
            // 
            this.txtPosicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosicao.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPosicao.Location = new System.Drawing.Point(511, 458);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPosicao.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtPosicao.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPosicao.Size = new System.Drawing.Size(86, 20);
            this.txtPosicao.TabIndex = 11;
            this.txtPosicao.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(408, 461);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Posição 1ª Etiqueta:";
            this.labelControl1.Visible = false;
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.btImprimir.Location = new System.Drawing.Point(648, 455);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 9;
            this.btImprimir.Text = "&Imprimir";
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.Location = new System.Drawing.Point(18, 455);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 8;
            this.btAjuda.Text = "&Ajuda";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.btFechar.ImageIndex = 2;
            this.btFechar.Location = new System.Drawing.Point(729, 455);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 7;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // gcProdutos
            // 
            this.gcProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProdutos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcProdutos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcProdutos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcProdutos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcProdutos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcProdutos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcProdutos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProdutos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcProdutos.Location = new System.Drawing.Point(0, 0);
            this.gcProdutos.MainView = this.gvProdutos;
            this.gcProdutos.Name = "gcProdutos";
            this.gcProdutos.Size = new System.Drawing.Size(786, 434);
            this.gcProdutos.TabIndex = 4;
            this.gcProdutos.UseEmbeddedNavigator = true;
            this.gcProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutos});
            // 
            // gvProdutos
            // 
            this.gvProdutos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProdutos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProdutos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.Empty.Options.UseBackColor = true;
            this.gvProdutos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProdutos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProdutos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProdutos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvProdutos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.Preview.Options.UseFont = true;
            this.gvProdutos.Appearance.Preview.Options.UseForeColor = true;
            this.gvProdutos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.Row.Options.UseBackColor = true;
            this.gvProdutos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvProdutos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProdutos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvProdutos.GridControl = this.gcProdutos;
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvProdutos.OptionsSelection.MultiSelect = true;
            this.gvProdutos.OptionsView.ColumnAutoWidth = false;
            this.gvProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutos.OptionsView.EnableAppearanceOddRow = true;
            this.gvProdutos.OptionsView.ShowAutoFilterRow = true;
            this.gvProdutos.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvProdutos_CustomDrawGroupPanel);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(792, 440);
            this.xtraTabControl1.TabIndex = 12;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcProdutos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(786, 434);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // FormImprimeEtiquetaCorreios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btFechar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormImprimeEtiquetaCorreios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de Etiquetas Correios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImprimeEtiquetaCorreios_FormClosing);
            this.Load += new System.EventHandler(this.FormImprimeEtiquetaCorreios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImprimeEtiquetaCorreios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtPosicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit txtPosicao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btImprimir;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        public DevExpress.XtraGrid.GridControl gcProdutos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvProdutos;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    }
}