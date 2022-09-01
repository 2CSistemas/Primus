
namespace Aplicacao.Utilitarios
{
    partial class GridAtualizaRegrasNCM
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
            this.btnCadastraRegrasNCM = new System.Windows.Forms.Button();
            this.gcNCMs = new DevExpress.XtraGrid.GridControl();
            this.gvFaixasInutilizadas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroFim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Justificativa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModeloNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMarcarTodos = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcNCMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaixasInutilizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastraRegrasNCM
            // 
            this.btnCadastraRegrasNCM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastraRegrasNCM.Location = new System.Drawing.Point(242, 385);
            this.btnCadastraRegrasNCM.Name = "btnCadastraRegrasNCM";
            this.btnCadastraRegrasNCM.Size = new System.Drawing.Size(133, 25);
            this.btnCadastraRegrasNCM.TabIndex = 0;
            this.btnCadastraRegrasNCM.Text = "Cadastra Regras NCM";
            this.btnCadastraRegrasNCM.UseVisualStyleBackColor = true;
            this.btnCadastraRegrasNCM.Click += new System.EventHandler(this.button1_Click);
            // 
            // gcNCMs
            // 
            this.gcNCMs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNCMs.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNCMs.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNCMs.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNCMs.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNCMs.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNCMs.Location = new System.Drawing.Point(12, 12);
            this.gcNCMs.MainView = this.gvFaixasInutilizadas;
            this.gcNCMs.Name = "gcNCMs";
            this.gcNCMs.Size = new System.Drawing.Size(849, 367);
            this.gcNCMs.TabIndex = 17;
            this.gcNCMs.UseEmbeddedNavigator = true;
            this.gcNCMs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFaixasInutilizadas});
            // 
            // gvFaixasInutilizadas
            // 
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.Empty.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaixasInutilizadas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaixasInutilizadas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaixasInutilizadas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaixasInutilizadas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFaixasInutilizadas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFaixasInutilizadas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.Preview.Options.UseFont = true;
            this.gvFaixasInutilizadas.Appearance.Preview.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaixasInutilizadas.Appearance.Row.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFaixasInutilizadas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFaixasInutilizadas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFaixasInutilizadas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFaixasInutilizadas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Serie,
            this.NumeroInicio,
            this.NumeroFim,
            this.Justificativa,
            this.Data,
            this.Ano,
            this.ModeloNota});
            this.gvFaixasInutilizadas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvFaixasInutilizadas.GridControl = this.gcNCMs;
            this.gvFaixasInutilizadas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFaixasInutilizadas.Name = "gvFaixasInutilizadas";
            this.gvFaixasInutilizadas.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvFaixasInutilizadas.OptionsView.ColumnAutoWidth = false;
            this.gvFaixasInutilizadas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFaixasInutilizadas.OptionsView.EnableAppearanceOddRow = true;
            this.gvFaixasInutilizadas.OptionsView.ShowAutoFilterRow = true;
            this.gvFaixasInutilizadas.OptionsView.ShowFooter = true;
            // 
            // Serie
            // 
            this.Serie.AppearanceHeader.Options.UseTextOptions = true;
            this.Serie.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Serie.Caption = "Série";
            this.Serie.FieldName = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.OptionsColumn.ReadOnly = true;
            this.Serie.Visible = true;
            this.Serie.VisibleIndex = 1;
            this.Serie.Width = 94;
            // 
            // NumeroInicio
            // 
            this.NumeroInicio.AppearanceHeader.Options.UseTextOptions = true;
            this.NumeroInicio.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NumeroInicio.Caption = "Número Início";
            this.NumeroInicio.FieldName = "NumeroInicio";
            this.NumeroInicio.Name = "NumeroInicio";
            this.NumeroInicio.OptionsColumn.ReadOnly = true;
            this.NumeroInicio.Visible = true;
            this.NumeroInicio.VisibleIndex = 2;
            this.NumeroInicio.Width = 93;
            // 
            // NumeroFim
            // 
            this.NumeroFim.AppearanceHeader.Options.UseTextOptions = true;
            this.NumeroFim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NumeroFim.Caption = "Número Fim";
            this.NumeroFim.FieldName = "NumeroFim";
            this.NumeroFim.Name = "NumeroFim";
            this.NumeroFim.OptionsColumn.ReadOnly = true;
            this.NumeroFim.Visible = true;
            this.NumeroFim.VisibleIndex = 3;
            this.NumeroFim.Width = 104;
            // 
            // Justificativa
            // 
            this.Justificativa.AppearanceHeader.Options.UseTextOptions = true;
            this.Justificativa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Justificativa.Caption = "Justificativa";
            this.Justificativa.FieldName = "Justificativa";
            this.Justificativa.Name = "Justificativa";
            this.Justificativa.OptionsColumn.ReadOnly = true;
            this.Justificativa.Visible = true;
            this.Justificativa.VisibleIndex = 4;
            this.Justificativa.Width = 325;
            // 
            // Data
            // 
            this.Data.AppearanceHeader.Options.UseTextOptions = true;
            this.Data.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Data.Caption = "Data";
            this.Data.FieldName = "Data";
            this.Data.Name = "Data";
            this.Data.OptionsColumn.ReadOnly = true;
            this.Data.Visible = true;
            this.Data.VisibleIndex = 5;
            this.Data.Width = 84;
            // 
            // Ano
            // 
            this.Ano.AppearanceHeader.Options.UseTextOptions = true;
            this.Ano.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Ano.Caption = "Ano";
            this.Ano.FieldName = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.OptionsColumn.ReadOnly = true;
            this.Ano.Visible = true;
            this.Ano.VisibleIndex = 6;
            this.Ano.Width = 54;
            // 
            // ModeloNota
            // 
            this.ModeloNota.AppearanceHeader.Options.UseTextOptions = true;
            this.ModeloNota.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ModeloNota.Caption = "Modelo Nota";
            this.ModeloNota.FieldName = "ModeloNotaStr";
            this.ModeloNota.Name = "ModeloNota";
            this.ModeloNota.Visible = true;
            this.ModeloNota.VisibleIndex = 0;
            this.ModeloNota.Width = 71;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(777, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 25);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMarcarTodos.Location = new System.Drawing.Point(12, 385);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Size = new System.Drawing.Size(109, 25);
            this.btnMarcarTodos.TabIndex = 19;
            this.btnMarcarTodos.Text = "Marcar Todos";
            this.btnMarcarTodos.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(127, 385);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(109, 25);
            this.btnDesmarcarTodos.TabIndex = 20;
            this.btnDesmarcarTodos.Text = "Desmarcar Todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = true;
            // 
            // FormAtualizaRegrasNCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 422);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnMarcarTodos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gcNCMs);
            this.Controls.Add(this.btnCadastraRegrasNCM);
            this.Name = "FormAtualizaRegrasNCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualiza Regras de NCM";
            ((System.ComponentModel.ISupportInitialize)(this.gcNCMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaixasInutilizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastraRegrasNCM;
        private DevExpress.XtraGrid.GridControl gcNCMs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFaixasInutilizadas;
        private DevExpress.XtraGrid.Columns.GridColumn Serie;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroInicio;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroFim;
        private DevExpress.XtraGrid.Columns.GridColumn Justificativa;
        private DevExpress.XtraGrid.Columns.GridColumn Data;
        private DevExpress.XtraGrid.Columns.GridColumn Ano;
        private DevExpress.XtraGrid.Columns.GridColumn ModeloNota;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMarcarTodos;
        private System.Windows.Forms.Button btnDesmarcarTodos;
    }
}