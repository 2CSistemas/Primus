namespace Aplicacao.Relatorios
{
    partial class FormBaseContas
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
            this.gcTipoDocumento = new DevExpress.XtraGrid.GridControl();
            this.gvTipoDocumento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(712, 547);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelControl10);
            this.tabPage1.Controls.Add(this.gcTipoDocumento);
            this.tabPage1.Size = new System.Drawing.Size(706, 541);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcTipoDocumento, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl10, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 565);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 565);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 569);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 565);
            // 
            // gcTipoDocumento
            // 
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTipoDocumento.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTipoDocumento.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTipoDocumento.Location = new System.Drawing.Point(52, 200);
            this.gcTipoDocumento.LookAndFeel.UseWindowsXPTheme = true;
            this.gcTipoDocumento.MainView = this.gvTipoDocumento;
            this.gcTipoDocumento.Name = "gcTipoDocumento";
            this.gcTipoDocumento.Size = new System.Drawing.Size(635, 130);
            this.gcTipoDocumento.TabIndex = 4;
            this.gcTipoDocumento.UseEmbeddedNavigator = true;
            this.gcTipoDocumento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoDocumento});
            // 
            // gvTipoDocumento
            // 
            this.gvTipoDocumento.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoDocumento.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoDocumento.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoDocumento.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoDocumento.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoDocumento.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoDocumento.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoDocumento.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoDocumento.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoDocumento.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoDocumento.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoDocumento.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.Preview.Options.UseFont = true;
            this.gvTipoDocumento.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoDocumento.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoDocumento.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoDocumento.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoDocumento.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoDocumento.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipoDocumento.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoDocumento.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoDocumento.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoDocumento.GridControl = this.gcTipoDocumento;
            this.gvTipoDocumento.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTipoDocumento.Name = "gvTipoDocumento";
            this.gvTipoDocumento.OptionsBehavior.Editable = false;
            this.gvTipoDocumento.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTipoDocumento.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoDocumento.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoDocumento.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(52, 178);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(123, 16);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "Tipo de Documento";
            // 
            // FormBaseContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 594);
            this.Name = "FormBaseContas";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcTipoDocumento;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTipoDocumento;
        protected DevExpress.XtraEditors.LabelControl labelControl10;
    }
}
