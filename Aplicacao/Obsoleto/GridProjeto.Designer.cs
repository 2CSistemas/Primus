namespace Aplicacao
{
    partial class GridProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridProjeto));
            this.sbMontarOrcamento = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcompanhamentoProjeto = new DevExpress.XtraEditors.SimpleButton();
            this.btArquivoOrcamento = new DevExpress.XtraEditors.SimpleButton();
            this.sbAprovar = new DevExpress.XtraEditors.SimpleButton();
            this.sbDesaprovar = new DevExpress.XtraEditors.SimpleButton();
            this.sbConcluir = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help.ico");
            this.imageList1.Images.SetKeyName(1, "Selecionar.ico");
            this.imageList1.Images.SetKeyName(2, "Consulta.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir.ico");
            this.imageList1.Images.SetKeyName(6, "fechar tela.ico");
            // 
            // btConsultar
            // 
            this.btConsultar.TabIndex = 7;
            // 
            // btIncluir
            // 
            this.btIncluir.TabIndex = 8;
            // 
            // btAlterar
            // 
            this.btAlterar.TabIndex = 9;
            // 
            // btExcluir
            // 
            this.btExcluir.TabIndex = 10;
            // 
            // sbFechar
            // 
            this.sbFechar.TabIndex = 11;
            // 
            // simpleButton2
            // 
            this.simpleButton2.TabIndex = 12;
            // 
            // sbMontarOrcamento
            // 
            this.sbMontarOrcamento.Image = ((System.Drawing.Image)(resources.GetObject("sbMontarOrcamento.Image")));
            this.sbMontarOrcamento.ImageIndex = 2;
            this.sbMontarOrcamento.ImageList = this.imageList1;
            this.sbMontarOrcamento.Location = new System.Drawing.Point(12, 406);
            this.sbMontarOrcamento.Name = "sbMontarOrcamento";
            this.sbMontarOrcamento.Size = new System.Drawing.Size(161, 23);
            this.sbMontarOrcamento.TabIndex = 1;
            this.sbMontarOrcamento.Text = "&Montar Orçamento";
            this.sbMontarOrcamento.Click += new System.EventHandler(this.sbMontarOrcamento_Click);
            // 
            // btnAcompanhamentoProjeto
            // 
            this.btnAcompanhamentoProjeto.ImageIndex = 3;
            this.btnAcompanhamentoProjeto.ImageList = this.imageList1;
            this.btnAcompanhamentoProjeto.Location = new System.Drawing.Point(176, 435);
            this.btnAcompanhamentoProjeto.Name = "btnAcompanhamentoProjeto";
            this.btnAcompanhamentoProjeto.Size = new System.Drawing.Size(138, 23);
            this.btnAcompanhamentoProjeto.TabIndex = 3;
            this.btnAcompanhamentoProjeto.Text = "Acompanhar Projeto";
            this.btnAcompanhamentoProjeto.Click += new System.EventHandler(this.btnAcompanhamentoProjeto_Click);
            // 
            // btArquivoOrcamento
            // 
            this.btArquivoOrcamento.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.btArquivoOrcamento.ImageList = this.imageList1;
            this.btArquivoOrcamento.Location = new System.Drawing.Point(176, 406);
            this.btArquivoOrcamento.Name = "btArquivoOrcamento";
            this.btArquivoOrcamento.Size = new System.Drawing.Size(138, 23);
            this.btArquivoOrcamento.TabIndex = 2;
            this.btArquivoOrcamento.Text = "&Imprimir Orçamento";
            this.btArquivoOrcamento.Click += new System.EventHandler(this.btArquivoOrcamento_Click);
            // 
            // sbAprovar
            // 
            this.sbAprovar.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbAprovar.ImageList = this.imageList1;
            this.sbAprovar.Location = new System.Drawing.Point(317, 406);
            this.sbAprovar.Name = "sbAprovar";
            this.sbAprovar.Size = new System.Drawing.Size(90, 23);
            this.sbAprovar.TabIndex = 4;
            this.sbAprovar.Text = "Aprovar";
            this.sbAprovar.Click += new System.EventHandler(this.sbAprovar_Click);
            // 
            // sbDesaprovar
            // 
            this.sbDesaprovar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbDesaprovar.ImageList = this.imageList1;
            this.sbDesaprovar.Location = new System.Drawing.Point(317, 434);
            this.sbDesaprovar.Name = "sbDesaprovar";
            this.sbDesaprovar.Size = new System.Drawing.Size(90, 23);
            this.sbDesaprovar.TabIndex = 5;
            this.sbDesaprovar.Text = "Desaprovar";
            this.sbDesaprovar.Click += new System.EventHandler(this.sbDesaprovar_Click);
            // 
            // sbConcluir
            // 
            this.sbConcluir.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbConcluir.ImageIndex = 3;
            this.sbConcluir.Location = new System.Drawing.Point(410, 406);
            this.sbConcluir.Name = "sbConcluir";
            this.sbConcluir.Size = new System.Drawing.Size(90, 23);
            this.sbConcluir.TabIndex = 6;
            this.sbConcluir.Text = "Concluir";
            this.sbConcluir.Click += new System.EventHandler(this.sbConcluir_Click);
            // 
            // GridProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(835, 463);
            this.Controls.Add(this.sbConcluir);
            this.Controls.Add(this.sbDesaprovar);
            this.Controls.Add(this.sbAprovar);
            this.Controls.Add(this.btArquivoOrcamento);
            this.Controls.Add(this.btnAcompanhamentoProjeto);
            this.Controls.Add(this.sbMontarOrcamento);
            this.Name = "GridProjeto";
            this.Controls.SetChildIndex(this.btConsultar, 0);
            this.Controls.SetChildIndex(this.btIncluir, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btExcluir, 0);
            this.Controls.SetChildIndex(this.sbFechar, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            this.Controls.SetChildIndex(this.btSelecionar, 0);
            this.Controls.SetChildIndex(this.sbMontarOrcamento, 0);
            this.Controls.SetChildIndex(this.btnAcompanhamentoProjeto, 0);
            this.Controls.SetChildIndex(this.btArquivoOrcamento, 0);
            this.Controls.SetChildIndex(this.sbAprovar, 0);
            this.Controls.SetChildIndex(this.sbDesaprovar, 0);
            this.Controls.SetChildIndex(this.sbConcluir, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbMontarOrcamento;
        private DevExpress.XtraEditors.SimpleButton btnAcompanhamentoProjeto;
        private DevExpress.XtraEditors.SimpleButton btArquivoOrcamento;
        private DevExpress.XtraEditors.SimpleButton sbAprovar;
        private DevExpress.XtraEditors.SimpleButton sbDesaprovar;
        private DevExpress.XtraEditors.SimpleButton sbConcluir;
    }
}
