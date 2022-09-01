namespace Aplicacao
{
    partial class GridPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridPessoa));
            this.sbClientesRevenda = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Selecionar copy.ico");
            this.imageList1.Images.SetKeyName(2, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Fechar.ico");
            // 
            // btConsultar
            // 
            this.btConsultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btConsultar.ImageOptions.Image")));
            this.btConsultar.ImageOptions.ImageIndex = 2;
            this.btConsultar.ImageOptions.ImageList = this.imageList1;
            // 
            // btIncluir
            // 
            this.btIncluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.ImageOptions.Image")));
            this.btIncluir.ImageOptions.ImageIndex = 3;
            this.btIncluir.ImageOptions.ImageList = this.imageList1;
            // 
            // btAlterar
            // 
            this.btAlterar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.ImageOptions.Image")));
            this.btAlterar.ImageOptions.ImageIndex = 4;
            this.btAlterar.ImageOptions.ImageList = this.imageList1;
            // 
            // btExcluir
            // 
            this.btExcluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.ImageOptions.Image")));
            this.btExcluir.ImageOptions.ImageIndex = 5;
            this.btExcluir.ImageOptions.ImageList = this.imageList1;
            // 
            // sbFechar
            // 
            this.sbFechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbFechar.ImageOptions.Image")));
            this.sbFechar.ImageOptions.ImageIndex = 6;
            this.sbFechar.ImageOptions.ImageList = this.imageList1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageIndex = 0;
            this.simpleButton2.ImageOptions.ImageList = this.imageList1;
            // 
            // btSelecionar
            // 
            this.btSelecionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSelecionar.ImageOptions.Image")));
            this.btSelecionar.ImageOptions.ImageIndex = 1;
            this.btSelecionar.ImageOptions.ImageList = this.imageList1;
            // 
            // sbClientesRevenda
            // 
            this.sbClientesRevenda.ImageOptions.Image = global::Aplicacao.Properties.Resources.Funcionários_copy;
            this.sbClientesRevenda.Location = new System.Drawing.Point(12, 406);
            this.sbClientesRevenda.Name = "sbClientesRevenda";
            this.sbClientesRevenda.Size = new System.Drawing.Size(161, 23);
            this.sbClientesRevenda.TabIndex = 20;
            this.sbClientesRevenda.Text = "Clientes Revenda";
            this.sbClientesRevenda.Visible = false;
            this.sbClientesRevenda.Click += new System.EventHandler(this.sbClientesRevenda_Click);
            // 
            // GridPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(835, 463);
            this.Controls.Add(this.sbClientesRevenda);
            this.Name = "GridPessoa";
            this.Load += new System.EventHandler(this.GridPessoa_Load);
            this.Controls.SetChildIndex(this.btConsultar, 0);
            this.Controls.SetChildIndex(this.btIncluir, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btExcluir, 0);
            this.Controls.SetChildIndex(this.sbFechar, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            this.Controls.SetChildIndex(this.btSelecionar, 0);
            this.Controls.SetChildIndex(this.sbClientesRevenda, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbClientesRevenda;
    }
}
