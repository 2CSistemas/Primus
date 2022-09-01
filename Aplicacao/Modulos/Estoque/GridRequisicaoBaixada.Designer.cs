namespace Aplicacao.Modulos.Estoque
{
    partial class GridRequisicaoBaixada
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
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeloDoctoString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPessoaNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilialID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilialNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuspendLayout();
            // 
            // sbConsultar
            // 
            this.sbConsultar.Location = new System.Drawing.Point(300, 392);
            // 
            // sbFuncao12
            // 
            this.sbFuncao12.Size = new System.Drawing.Size(103, 23);
            // 
            // sbFuncao22
            // 
            this.sbFuncao22.Size = new System.Drawing.Size(103, 23);
            // 
            // sbFuncao13
            // 
            this.sbFuncao13.Location = new System.Drawing.Point(292, 392);
            // 
            // sbFuncao23
            // 
            this.sbFuncao23.Location = new System.Drawing.Point(675, 420);
            this.sbFuncao23.Size = new System.Drawing.Size(75, 23);
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 100;
            // 
            // colDt
            // 
            this.colDt.AppearanceCell.Options.UseTextOptions = true;
            this.colDt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDt.AppearanceHeader.Options.UseTextOptions = true;
            this.colDt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDt.Caption = "Data";
            this.colDt.FieldName = "Dt";
            this.colDt.Name = "colDt";
            this.colDt.OptionsColumn.AllowEdit = false;
            this.colDt.Visible = true;
            this.colDt.VisibleIndex = 1;
            this.colDt.Width = 90;
            // 
            // colModeloDoctoString
            // 
            this.colModeloDoctoString.AppearanceCell.Options.UseTextOptions = true;
            this.colModeloDoctoString.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModeloDoctoString.AppearanceHeader.Options.UseTextOptions = true;
            this.colModeloDoctoString.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModeloDoctoString.Caption = "Modelo";
            this.colModeloDoctoString.FieldName = "ModeloDoctoString";
            this.colModeloDoctoString.Name = "colModeloDoctoString";
            this.colModeloDoctoString.OptionsColumn.AllowEdit = false;
            this.colModeloDoctoString.Visible = true;
            this.colModeloDoctoString.VisibleIndex = 2;
            this.colModeloDoctoString.Width = 90;
            // 
            // colSerie
            // 
            this.colSerie.AppearanceCell.Options.UseTextOptions = true;
            this.colSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSerie.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSerie.Caption = "Série";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.AllowEdit = false;
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 3;
            this.colSerie.Width = 90;
            // 
            // colNumero
            // 
            this.colNumero.AppearanceCell.Options.UseTextOptions = true;
            this.colNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNumero.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumero.Caption = "Numero";
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.OptionsColumn.AllowEdit = false;
            this.colNumero.Visible = true;
            this.colNumero.VisibleIndex = 4;
            this.colNumero.Width = 90;
            // 
            // colPessoaNome
            // 
            this.colPessoaNome.AppearanceCell.Options.UseTextOptions = true;
            this.colPessoaNome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPessoaNome.AppearanceHeader.Options.UseTextOptions = true;
            this.colPessoaNome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPessoaNome.Caption = "Cliente";
            this.colPessoaNome.FieldName = "PessoaNome";
            this.colPessoaNome.Name = "colPessoaNome";
            this.colPessoaNome.OptionsColumn.AllowEdit = false;
            this.colPessoaNome.Visible = true;
            this.colPessoaNome.VisibleIndex = 5;
            this.colPessoaNome.Width = 90;
            // 
            // colTotalNota
            // 
            this.colTotalNota.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalNota.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalNota.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalNota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalNota.Caption = "Total";
            this.colTotalNota.DisplayFormat.FormatString = "c2";
            this.colTotalNota.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotalNota.FieldName = "TotalNota";
            this.colTotalNota.Name = "colTotalNota";
            this.colTotalNota.OptionsColumn.AllowEdit = false;
            this.colTotalNota.Visible = true;
            this.colTotalNota.VisibleIndex = 6;
            this.colTotalNota.Width = 90;
            // 
            // colTipoNota
            // 
            this.colTipoNota.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoNota.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoNota.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoNota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipoNota.Caption = "Tipo";
            this.colTipoNota.FieldName = "TipoNota";
            this.colTipoNota.Name = "colTipoNota";
            this.colTipoNota.OptionsColumn.AllowEdit = false;
            this.colTipoNota.Visible = true;
            this.colTipoNota.VisibleIndex = 7;
            this.colTipoNota.Width = 90;
            // 
            // colFilialID
            // 
            this.colFilialID.AppearanceCell.Options.UseTextOptions = true;
            this.colFilialID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colFilialID.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilialID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFilialID.Caption = "Filial";
            this.colFilialID.FieldName = "FilialID";
            this.colFilialID.Name = "colFilialID";
            this.colFilialID.OptionsColumn.AllowEdit = false;
            this.colFilialID.Visible = true;
            this.colFilialID.VisibleIndex = 8;
            this.colFilialID.Width = 90;
            // 
            // colFilialNome
            // 
            this.colFilialNome.AppearanceCell.Options.UseTextOptions = true;
            this.colFilialNome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colFilialNome.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilialNome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFilialNome.Caption = "Nome Filial";
            this.colFilialNome.FieldName = "FilialNome";
            this.colFilialNome.Name = "colFilialNome";
            this.colFilialNome.OptionsColumn.AllowEdit = false;
            this.colFilialNome.Visible = true;
            this.colFilialNome.VisibleIndex = 9;
            this.colFilialNome.Width = 90;
            // 
            // GridNotaComplementarGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Name = "GridNotaComplementarGen";
            this.ResumeLayout(false);

        }

        #endregion             

        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModeloDoctoString;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colPessoaNome;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNota;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoNota;
        private DevExpress.XtraGrid.Columns.GridColumn colFilialID;
        private DevExpress.XtraGrid.Columns.GridColumn colFilialNome;
    }
}
