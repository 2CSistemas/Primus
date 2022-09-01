namespace Aplicacao.Modulos.Cadastro
{
    partial class GridUsuarios
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gcUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gvUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbSelecionar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUsuarios
            // 
            this.gcUsuarios.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcUsuarios.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcUsuarios.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcUsuarios.Location = new System.Drawing.Point(8, 8);
            this.gcUsuarios.MainView = this.gvUsuarios;
            this.gcUsuarios.Name = "gcUsuarios";
            this.gcUsuarios.Size = new System.Drawing.Size(812, 330);
            this.gcUsuarios.TabIndex = 1;
            this.gcUsuarios.UseEmbeddedNavigator = true;
            this.gcUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsuarios});
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvUsuarios.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvUsuarios.Appearance.Empty.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvUsuarios.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvUsuarios.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvUsuarios.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvUsuarios.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvUsuarios.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvUsuarios.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvUsuarios.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvUsuarios.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvUsuarios.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvUsuarios.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvUsuarios.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvUsuarios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvUsuarios.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvUsuarios.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvUsuarios.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.OddRow.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.OddRow.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvUsuarios.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.Preview.Options.UseFont = true;
            this.gvUsuarios.Appearance.Preview.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvUsuarios.Appearance.Row.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvUsuarios.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvUsuarios.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvUsuarios.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvUsuarios.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvUsuarios.Appearance.TopNewRow.BackColor = System.Drawing.Color.Black;
            this.gvUsuarios.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvUsuarios.BestFitMaxRowCount = 5;
            this.gvUsuarios.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvUsuarios.GridControl = this.gcUsuarios;
            this.gvUsuarios.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvUsuarios.OptionsBehavior.Editable = false;
            this.gvUsuarios.OptionsDetail.EnableMasterViewMode = false;
            this.gvUsuarios.OptionsView.ColumnAutoWidth = false;
            this.gvUsuarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUsuarios.OptionsView.EnableAppearanceOddRow = true;
            this.gvUsuarios.OptionsView.ShowAutoFilterRow = true;
            this.gvUsuarios.OptionsView.ShowFooter = true;
           
            // 
            // GridUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 490);
            this.Controls.Add(this.sbSelecionar);
            this.Controls.Add(this.gcUsuarios);
            this.Name = "GridUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcUsuarios;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvUsuarios;
    }
}