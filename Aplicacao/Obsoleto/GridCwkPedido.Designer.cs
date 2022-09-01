namespace Aplicacao
{
    partial class GridCwkPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridCwkPedido));
            this.btnAtestadoPontoMT = new DevExpress.XtraEditors.SimpleButton();
            this.btnGerarBanco = new DevExpress.XtraEditors.SimpleButton();
            this.btnGerarArquivoLicenca = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGerarLicenca = new DevExpress.XtraEditors.SimpleButton();
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
            // btnAtestadoPontoMT
            // 
            this.btnAtestadoPontoMT.Image = ((System.Drawing.Image)(resources.GetObject("btnAtestadoPontoMT.Image")));
            this.btnAtestadoPontoMT.Location = new System.Drawing.Point(174, 405);
            this.btnAtestadoPontoMT.Name = "btnAtestadoPontoMT";
            this.btnAtestadoPontoMT.Size = new System.Drawing.Size(156, 23);
            this.btnAtestadoPontoMT.TabIndex = 21;
            this.btnAtestadoPontoMT.Text = "Atestado Ponto MT";
            this.btnAtestadoPontoMT.Click += new System.EventHandler(this.btnAtestadoPontoMT_Click);
            // 
            // btnGerarBanco
            // 
            this.btnGerarBanco.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarBanco.Image")));
            this.btnGerarBanco.Location = new System.Drawing.Point(12, 405);
            this.btnGerarBanco.Name = "btnGerarBanco";
            this.btnGerarBanco.Size = new System.Drawing.Size(156, 23);
            this.btnGerarBanco.TabIndex = 20;
            this.btnGerarBanco.Text = "Gerar Banco Ponto";
            this.btnGerarBanco.Click += new System.EventHandler(this.btnGerarBanco_Click);
            // 
            // btnGerarArquivoLicenca
            // 
            this.btnGerarArquivoLicenca.Image = global::Aplicacao.Properties.Resources.Acerto_copy;
            this.btnGerarArquivoLicenca.Location = new System.Drawing.Point(336, 434);
            this.btnGerarArquivoLicenca.Name = "btnGerarArquivoLicenca";
            this.btnGerarArquivoLicenca.Size = new System.Drawing.Size(156, 23);
            this.btnGerarArquivoLicenca.TabIndex = 21;
            this.btnGerarArquivoLicenca.Text = "Gerar Arquivo Licença";
            this.btnGerarArquivoLicenca.Visible = false;
            this.btnGerarArquivoLicenca.Click += new System.EventHandler(this.btnGerarArquivoLicenca_Click);
            // 
            // btnGerarLicenca
            // 
            this.btnGerarLicenca.Image = global::Aplicacao.Properties.Resources.Clone;
            this.btnGerarLicenca.Location = new System.Drawing.Point(336, 405);
            this.btnGerarLicenca.Name = "btnGerarLicenca";
            this.btnGerarLicenca.Size = new System.Drawing.Size(156, 23);
            this.btnGerarLicenca.TabIndex = 22;
            this.btnGerarLicenca.Text = "Gerar Licenças";
            this.btnGerarLicenca.ToolTip = "Gerar uma determinada quantidade de licenças baseada em uma selecionada.";
            this.btnGerarLicenca.Click += new System.EventHandler(this.btnGerarLicenca_Click);
            // 
            // GridCwkPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(835, 463);
            this.Controls.Add(this.btnGerarLicenca);
            this.Controls.Add(this.btnGerarArquivoLicenca);
            this.Controls.Add(this.btnAtestadoPontoMT);
            this.Controls.Add(this.btnGerarBanco);
            this.Name = "GridCwkPedido";
            this.Text = "Tabela de Orçamento";
            this.Load += new System.EventHandler(this.GridCwkPedido_Load);
            this.Controls.SetChildIndex(this.btConsultar, 0);
            this.Controls.SetChildIndex(this.btIncluir, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btExcluir, 0);
            this.Controls.SetChildIndex(this.sbFechar, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            this.Controls.SetChildIndex(this.btSelecionar, 0);
            this.Controls.SetChildIndex(this.btnGerarBanco, 0);
            this.Controls.SetChildIndex(this.btnAtestadoPontoMT, 0);
            this.Controls.SetChildIndex(this.btnGerarArquivoLicenca, 0);
            this.Controls.SetChildIndex(this.btnGerarLicenca, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtestadoPontoMT;
        private DevExpress.XtraEditors.SimpleButton btnGerarBanco;
        private DevExpress.XtraEditors.SimpleButton btnGerarArquivoLicenca;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnGerarLicenca;
    }
}
