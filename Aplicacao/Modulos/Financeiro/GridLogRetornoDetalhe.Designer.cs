namespace Aplicacao.Modulos.Financeiro
{
    partial class GridLogRetornoDetalhe
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
            this.SuspendLayout();
            // 
            // sbSelecionar
            // 
            this.sbSelecionar.Enabled = false;
            // 
            // sbFechar
            // 
            this.sbFechar.Location = new System.Drawing.Point(753, 392);
            // 
            // sbExcluir
            // 
            this.sbExcluir.Enabled = false;
            this.sbExcluir.Location = new System.Drawing.Point(752, 421);
            this.sbExcluir.Visible = false;
            // 
            // sbAlterar
            // 
            this.sbAlterar.Enabled = false;
            this.sbAlterar.Location = new System.Drawing.Point(672, 421);
            this.sbAlterar.Visible = false;
            // 
            // sbIncluir
            // 
            this.sbIncluir.Enabled = false;
            this.sbIncluir.Location = new System.Drawing.Point(591, 421);
            this.sbIncluir.Visible = false;
            // 
            // sbConsultar
            // 
            this.sbConsultar.Location = new System.Drawing.Point(672, 392);
            // 
            // sbFuncao10
            // 
            this.sbFuncao10.Location = new System.Drawing.Point(12, 421);
            // 
            // sbImprimirFiltro
            // 
            this.sbImprimirFiltro.Location = new System.Drawing.Point(513, 392);
            // 
            // GridLogRetornoDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Name = "GridLogRetornoDetalhe";
            this.Text = "Tabela de Log Retorno Detalhe";
            this.Load += new System.EventHandler(this.GridLogRetornoDetalhe_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}