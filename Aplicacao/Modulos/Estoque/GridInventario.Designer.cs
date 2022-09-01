namespace Aplicacao.Modulos.Estoque
{
    partial class GridInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridInventario));
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sbSelecionar
            // 
            this.sbSelecionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbSelecionar.ImageOptions.Image")));
            this.sbSelecionar.ImageOptions.ImageIndex = 1;
            this.sbSelecionar.Location = new System.Drawing.Point(148, 420);
            // 
            // sbFechar
            // 
            this.sbFechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbFechar.ImageOptions.Image")));
            this.sbFechar.ImageOptions.ImageIndex = 6;
            // 
            // sbExcluir
            // 
            this.sbExcluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbExcluir.ImageOptions.Image")));
            this.sbExcluir.ImageOptions.ImageIndex = 5;
            // 
            // sbAlterar
            // 
            this.sbAlterar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAlterar.ImageOptions.Image")));
            this.sbAlterar.ImageOptions.ImageIndex = 4;
            // 
            // sbIncluir
            // 
            this.sbIncluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbIncluir.ImageOptions.Image")));
            this.sbIncluir.ImageOptions.ImageIndex = 3;
            // 
            // sbConsultar
            // 
            this.sbConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbConsultar.ImageOptions.Image")));
            this.sbConsultar.ImageOptions.ImageIndex = 2;
            // 
            // sbFuncao10
            // 
            this.sbFuncao10.Enabled = true;
            this.sbFuncao10.ImageOptions.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbFuncao10.ImageOptions.ImageIndex = 1;
            this.sbFuncao10.Location = new System.Drawing.Point(14, 392);
            this.sbFuncao10.Size = new System.Drawing.Size(112, 23);
            this.sbFuncao10.Text = "Gerar Inventário";
            this.sbFuncao10.Visible = true;
            this.sbFuncao10.Click += new System.EventHandler(this.sbFuncao10_Click);
            // 
            // sbFuncao11
            // 
            this.sbFuncao11.Location = new System.Drawing.Point(148, 392);
            // 
            // sbFuncao12
            // 
            this.sbFuncao12.ImageOptions.ImageIndex = 1;
            this.sbFuncao12.Location = new System.Drawing.Point(219, 392);
            // 
            // sbFuncao22
            // 
            this.sbFuncao22.ImageOptions.ImageIndex = 1;
            this.sbFuncao22.Location = new System.Drawing.Point(237, 420);
            // 
            // sbFuncao13
            // 
            this.sbFuncao13.ImageOptions.ImageIndex = 1;
            this.sbFuncao13.Location = new System.Drawing.Point(308, 392);
            // 
            // sbFuncao23
            // 
            this.sbFuncao23.ImageOptions.ImageIndex = 1;
            this.sbFuncao23.Location = new System.Drawing.Point(326, 420);
            // 
            // sbImprimirFiltro
            // 
            this.sbImprimirFiltro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbImprimirFiltro.ImageOptions.Image")));
            this.sbImprimirFiltro.ImageOptions.ImageIndex = 6;
            // 
            // btTrocarProduto
            // 
            this.btTrocarProduto.ImageOptions.ImageIndex = 1;
            this.btTrocarProduto.Location = new System.Drawing.Point(397, 392);
            // 
            // sbFuncao25
            // 
            this.sbFuncao25.ImageOptions.ImageIndex = 1;
            this.sbFuncao25.Location = new System.Drawing.Point(415, 421);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(14, 420);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(112, 23);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // GridInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.btnImprimir);
            this.Name = "GridInventario";
            this.Text = "Inventário";
            this.Controls.SetChildIndex(this.sbConsultar, 0);
            this.Controls.SetChildIndex(this.sbIncluir, 0);
            this.Controls.SetChildIndex(this.sbAlterar, 0);
            this.Controls.SetChildIndex(this.sbExcluir, 0);
            this.Controls.SetChildIndex(this.sbFechar, 0);
            this.Controls.SetChildIndex(this.sbSelecionar, 0);
            this.Controls.SetChildIndex(this.sbFuncao11, 0);
            this.Controls.SetChildIndex(this.sbFuncao12, 0);
            this.Controls.SetChildIndex(this.sbFuncao22, 0);
            this.Controls.SetChildIndex(this.sbFuncao13, 0);
            this.Controls.SetChildIndex(this.sbFuncao23, 0);
            this.Controls.SetChildIndex(this.sbFuncao10, 0);
            this.Controls.SetChildIndex(this.sbImprimirFiltro, 0);
            this.Controls.SetChildIndex(this.btTrocarProduto, 0);
            this.Controls.SetChildIndex(this.sbFuncao25, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFiltro)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
    }
}
