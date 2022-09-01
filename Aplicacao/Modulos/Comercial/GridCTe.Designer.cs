
namespace Aplicacao.Modulos.Comercial
{
    partial class GridCTe
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
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.ovGRD_CTe = new DevExpress.XtraGrid.GridControl();
            this.ovGV_Notas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.sbConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.sbIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_CTe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(938, 479);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 37;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // ovGRD_CTe
            // 
            this.ovGRD_CTe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_CTe.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ovGRD_CTe.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ovGRD_CTe.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ovGRD_CTe.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ovGRD_CTe.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ovGRD_CTe.Location = new System.Drawing.Point(10, 12);
            this.ovGRD_CTe.MainView = this.ovGV_Notas;
            this.ovGRD_CTe.Name = "ovGRD_CTe";
            this.ovGRD_CTe.Size = new System.Drawing.Size(1005, 432);
            this.ovGRD_CTe.TabIndex = 42;
            this.ovGRD_CTe.UseEmbeddedNavigator = true;
            this.ovGRD_CTe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ovGV_Notas,
            this.cardView2});
            // 
            // ovGV_Notas
            // 
            this.ovGV_Notas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.Empty.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.EvenRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.EvenRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Notas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Notas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Notas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.FixedLine.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Notas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Notas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupButton.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Notas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.GroupRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Notas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Notas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Notas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.OddRow.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.OddRow.Options.UseBorderColor = true;
            this.ovGV_Notas.Appearance.OddRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.ovGV_Notas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.Preview.Options.UseFont = true;
            this.ovGV_Notas.Appearance.Preview.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Notas.Appearance.Row.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.ovGV_Notas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.ovGV_Notas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.ovGV_Notas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Notas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.ovGV_Notas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn6});
            this.ovGV_Notas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ovGV_Notas.GridControl = this.ovGRD_CTe;
            this.ovGV_Notas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.ovGV_Notas.Name = "ovGV_Notas";
            this.ovGV_Notas.OptionsBehavior.FocusLeaveOnTab = true;
            this.ovGV_Notas.OptionsDetail.EnableMasterViewMode = false;
            this.ovGV_Notas.OptionsView.EnableAppearanceEvenRow = true;
            this.ovGV_Notas.OptionsView.EnableAppearanceOddRow = true;
            this.ovGV_Notas.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Numero";
            this.gridColumn1.FieldName = "numeronota";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 65;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Série";
            this.gridColumn2.FieldName = "serie";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 58;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Data Emissão";
            this.gridColumn3.FieldName = "datanota";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CNPJ";
            this.gridColumn4.FieldName = "cnpj";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 138;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Pessoa";
            this.gridColumn5.FieldName = "fornecedor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 365;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Situação";
            this.gridColumn7.FieldName = "situacao";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 140;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Valor Nota";
            this.gridColumn6.DisplayFormat.FormatString = "{0:c2}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "valornota";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 134;
            // 
            // cardView2
            // 
            this.cardView2.GridControl = this.ovGRD_CTe;
            this.cardView2.Name = "cardView2";
            // 
            // sbConsultar
            // 
            this.sbConsultar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbConsultar.Location = new System.Drawing.Point(695, 450);
            this.sbConsultar.Name = "sbConsultar";
            this.sbConsultar.Size = new System.Drawing.Size(75, 23);
            this.sbConsultar.TabIndex = 43;
            this.sbConsultar.Text = "Consultar";
            // 
            // sbIncluir
            // 
            this.sbIncluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluir.Location = new System.Drawing.Point(776, 450);
            this.sbIncluir.Name = "sbIncluir";
            this.sbIncluir.Size = new System.Drawing.Size(75, 23);
            this.sbIncluir.TabIndex = 44;
            this.sbIncluir.Text = "Incluir";
            this.sbIncluir.Click += new System.EventHandler(this.sbIncluir_Click);
            // 
            // sbAlterar
            // 
            this.sbAlterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.sbAlterar.Location = new System.Drawing.Point(857, 450);
            this.sbAlterar.Name = "sbAlterar";
            this.sbAlterar.Size = new System.Drawing.Size(75, 23);
            this.sbAlterar.TabIndex = 45;
            this.sbAlterar.Text = "Alterar";
            // 
            // sbExcluir
            // 
            this.sbExcluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluir.Location = new System.Drawing.Point(938, 450);
            this.sbExcluir.Name = "sbExcluir";
            this.sbExcluir.Size = new System.Drawing.Size(75, 23);
            this.sbExcluir.TabIndex = 46;
            this.sbExcluir.Text = "Excluir";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.simpleButton1.Location = new System.Drawing.Point(12, 450);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 23);
            this.simpleButton1.TabIndex = 47;
            this.simpleButton1.Text = "Importa XML";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // GridCTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 504);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sbExcluir);
            this.Controls.Add(this.sbAlterar);
            this.Controls.Add(this.sbIncluir);
            this.Controls.Add(this.sbConsultar);
            this.Controls.Add(this.ovGRD_CTe);
            this.Controls.Add(this.sbFechar);
            this.KeyPreview = true;
            this.Name = "GridCTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de CT-e - Conhecimento de Transporte Eletrônico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridCTe_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_CTe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraGrid.GridControl ovGRD_CTe;
        private DevExpress.XtraGrid.Views.Grid.GridView ovGV_Notas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        private DevExpress.XtraEditors.SimpleButton sbConsultar;
        private DevExpress.XtraEditors.SimpleButton sbIncluir;
        private DevExpress.XtraEditors.SimpleButton sbAlterar;
        private DevExpress.XtraEditors.SimpleButton sbExcluir;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}