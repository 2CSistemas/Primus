namespace Aplicacao.Modulos.Financeiro
{
    partial class GridLogRetorno
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
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeArquivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremessa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomeRemessa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogRetornoDetalhe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltData = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sbSelecionar
            // 
            this.sbSelecionar.Location = new System.Drawing.Point(101, 392);
            // 
            // sbFechar
            // 
            this.sbFechar.Location = new System.Drawing.Point(753, 392);
            // 
            // sbExcluir
            // 
            this.sbExcluir.Location = new System.Drawing.Point(752, 421);
            this.sbExcluir.Visible = false;
            // 
            // sbAlterar
            // 
            this.sbAlterar.Location = new System.Drawing.Point(672, 421);
            this.sbAlterar.Visible = false;
            // 
            // sbIncluir
            // 
            this.sbIncluir.Location = new System.Drawing.Point(591, 421);
            this.sbIncluir.Visible = false;
            // 
            // sbConsultar
            // 
            this.sbConsultar.Location = new System.Drawing.Point(672, 392);
            // 
            // sbFuncao10
            // 
            this.sbFuncao10.Location = new System.Drawing.Point(12, 416);
            // 
            // sbFuncao11
            // 
            this.sbFuncao11.Location = new System.Drawing.Point(101, 416);
            // 
            // sbFuncao22
            // 
            this.sbFuncao22.Location = new System.Drawing.Point(185, 416);
            // 
            // sbFuncao23
            // 
            this.sbFuncao23.Location = new System.Drawing.Point(362, 392);
            // 
            // sbImprimirFiltro
            // 
            this.sbImprimirFiltro.Location = new System.Drawing.Point(513, 392);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colNomeArquivo
            // 
            this.colNomeArquivo.FieldName = "NomeArquivo";
            this.colNomeArquivo.Name = "colNomeArquivo";
            this.colNomeArquivo.Visible = true;
            this.colNomeArquivo.VisibleIndex = 1;
            // 
            // colremessa
            // 
            this.colremessa.FieldName = "remessa";
            this.colremessa.Name = "colremessa";
            this.colremessa.Visible = true;
            this.colremessa.VisibleIndex = 2;
            // 
            // colnomeRemessa
            // 
            this.colnomeRemessa.FieldName = "nomeRemessa";
            this.colnomeRemessa.Name = "colnomeRemessa";
            this.colnomeRemessa.OptionsColumn.ReadOnly = true;
            this.colnomeRemessa.Visible = true;
            this.colnomeRemessa.VisibleIndex = 3;
            // 
            // colIncData
            // 
            this.colIncData.FieldName = "IncData";
            this.colIncData.Name = "colIncData";
            this.colIncData.Visible = true;
            this.colIncData.VisibleIndex = 4;
            // 
            // colIncUsuario
            // 
            this.colIncUsuario.FieldName = "IncUsuario";
            this.colIncUsuario.Name = "colIncUsuario";
            this.colIncUsuario.Visible = true;
            this.colIncUsuario.VisibleIndex = 5;
            // 
            // colLogRetornoDetalhe
            // 
            this.colLogRetornoDetalhe.FieldName = "LogRetornoDetalhe";
            this.colLogRetornoDetalhe.Name = "colLogRetornoDetalhe";
            this.colLogRetornoDetalhe.Visible = true;
            this.colLogRetornoDetalhe.VisibleIndex = 6;
            // 
            // colAltUsuario
            // 
            this.colAltUsuario.FieldName = "AltUsuario";
            this.colAltUsuario.Name = "colAltUsuario";
            this.colAltUsuario.Visible = true;
            this.colAltUsuario.VisibleIndex = 7;
            // 
            // colAltData
            // 
            this.colAltData.FieldName = "AltData";
            this.colAltData.Name = "colAltData";
            this.colAltData.Visible = true;
            this.colAltData.VisibleIndex = 8;
            // 
            // GridLogRetorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Name = "GridLogRetorno";
            this.Text = "Tabela de Logs de Retorno";
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeArquivo;
        private DevExpress.XtraGrid.Columns.GridColumn colremessa;
        private DevExpress.XtraGrid.Columns.GridColumn colnomeRemessa;
        private DevExpress.XtraGrid.Columns.GridColumn colIncData;
        private DevExpress.XtraGrid.Columns.GridColumn colIncUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colLogRetornoDetalhe;
        private DevExpress.XtraGrid.Columns.GridColumn colAltUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colAltData;
    }
}