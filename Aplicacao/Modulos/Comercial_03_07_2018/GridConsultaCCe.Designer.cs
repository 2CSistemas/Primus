namespace Aplicacao.Modulos.Comercial
{
    partial class GridConsultaCCe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridConsultaCCe));
            this.pnCCe = new DevExpress.XtraEditors.GroupControl();
            this.gcCCe = new DevExpress.XtraGrid.GridControl();
            this.gvCCe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DtEnvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TextoCorrecao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LogRecibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btImprimirCCe = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnCCe)).BeginInit();
            this.pnCCe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCCe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCCe)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 426);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(618, 427);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(774, 426);
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
            this.tpPrincipal.Controls.Add(this.pnCCe);
            this.tpPrincipal.Size = new System.Drawing.Size(831, 402);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(837, 408);
            // 
            // pnCCe
            // 
            this.pnCCe.Controls.Add(this.gcCCe);
            this.pnCCe.Location = new System.Drawing.Point(5, 6);
            this.pnCCe.Name = "pnCCe";
            this.pnCCe.Size = new System.Drawing.Size(821, 390);
            this.pnCCe.TabIndex = 38;
            this.pnCCe.Text = "CC-e";
            // 
            // gcCCe
            // 
            this.gcCCe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCCe.Location = new System.Drawing.Point(2, 22);
            this.gcCCe.MainView = this.gvCCe;
            this.gcCCe.Name = "gcCCe";
            this.gcCCe.Size = new System.Drawing.Size(817, 366);
            this.gcCCe.TabIndex = 0;
            this.gcCCe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCCe});
            this.gcCCe.DoubleClick += new System.EventHandler(this.gcCCe_DoubleClick);
            // 
            // gvCCe
            // 
            this.gvCCe.ActiveFilterEnabled = false;
            this.gvCCe.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvCCe.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCCe.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCCe.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCCe.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCCe.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCCe.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCCe.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCCe.Appearance.Empty.Options.UseBackColor = true;
            this.gvCCe.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvCCe.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvCCe.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCCe.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvCCe.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCCe.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCCe.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCCe.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvCCe.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCCe.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCCe.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCCe.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCCe.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCCe.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCCe.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCCe.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCCe.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCCe.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCCe.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCCe.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCCe.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCCe.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCCe.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCCe.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCCe.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCCe.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCCe.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCCe.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCCe.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCCe.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCCe.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCCe.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCCe.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCCe.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCCe.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCCe.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCCe.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCCe.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCCe.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvCCe.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCCe.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCCe.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvCCe.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCCe.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvCCe.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.Preview.Options.UseFont = true;
            this.gvCCe.Appearance.Preview.Options.UseForeColor = true;
            this.gvCCe.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCCe.Appearance.Row.Options.UseBackColor = true;
            this.gvCCe.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvCCe.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCCe.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvCCe.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCCe.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvCCe.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvCCe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sequencia,
            this.DtEnvio,
            this.TextoCorrecao,
            this.Status,
            this.LogRecibo});
            this.gvCCe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvCCe.GridControl = this.gcCCe;
            this.gvCCe.Name = "gvCCe";
            this.gvCCe.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvCCe.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvCCe.OptionsCustomization.AllowFilter = false;
            this.gvCCe.OptionsCustomization.AllowSort = false;
            this.gvCCe.OptionsDetail.EnableMasterViewMode = false;
            this.gvCCe.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvCCe.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCCe.OptionsView.EnableAppearanceOddRow = true;
            this.gvCCe.OptionsView.ShowGroupPanel = false;
            // 
            // Sequencia
            // 
            this.Sequencia.Caption = "Sequência";
            this.Sequencia.FieldName = "Sequencia";
            this.Sequencia.Name = "Sequencia";
            this.Sequencia.Visible = true;
            this.Sequencia.VisibleIndex = 0;
            this.Sequencia.Width = 71;
            // 
            // DtEnvio
            // 
            this.DtEnvio.Caption = "Data de Envio";
            this.DtEnvio.FieldName = "DtEnvio";
            this.DtEnvio.Name = "DtEnvio";
            this.DtEnvio.Visible = true;
            this.DtEnvio.VisibleIndex = 1;
            this.DtEnvio.Width = 124;
            // 
            // TextoCorrecao
            // 
            this.TextoCorrecao.Caption = "Texto Correção";
            this.TextoCorrecao.FieldName = "TextoCorrecao";
            this.TextoCorrecao.Name = "TextoCorrecao";
            this.TextoCorrecao.Visible = true;
            this.TextoCorrecao.VisibleIndex = 2;
            this.TextoCorrecao.Width = 315;
            // 
            // Status
            // 
            this.Status.Caption = "Situação";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 92;
            // 
            // LogRecibo
            // 
            this.LogRecibo.Caption = "Motivo";
            this.LogRecibo.FieldName = "LogRecibo";
            this.LogRecibo.Name = "LogRecibo";
            this.LogRecibo.Visible = true;
            this.LogRecibo.VisibleIndex = 4;
            this.LogRecibo.Width = 197;
            // 
            // btImprimirCCe
            // 
            this.btImprimirCCe.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            this.btImprimirCCe.Location = new System.Drawing.Point(697, 426);
            this.btImprimirCCe.Name = "btImprimirCCe";
            this.btImprimirCCe.Size = new System.Drawing.Size(75, 23);
            this.btImprimirCCe.TabIndex = 8;
            this.btImprimirCCe.Text = "Imprimir";
            this.btImprimirCCe.Click += new System.EventHandler(this.btImprimirCCe_Click);
            // 
            // GridConsultaCCe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 461);
            this.Controls.Add(this.btImprimirCCe);
            this.Name = "GridConsultaCCe";
            this.Text = "Consulta CCe";
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            this.Controls.SetChildIndex(this.btImprimirCCe, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnCCe)).EndInit();
            this.pnCCe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCCe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCCe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl pnCCe;
        private DevExpress.XtraGrid.GridControl gcCCe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCCe;
        private DevExpress.XtraGrid.Columns.GridColumn Sequencia;
        private DevExpress.XtraGrid.Columns.GridColumn DtEnvio;
        private DevExpress.XtraGrid.Columns.GridColumn TextoCorrecao;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn LogRecibo;
        private DevExpress.XtraEditors.SimpleButton btImprimirCCe;
    }
}