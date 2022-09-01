namespace Aplicacao
{
    partial class GridOrdemProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridOrdemProducao));
            this.sbExecucao = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprime = new DevExpress.XtraEditors.SimpleButton();
            this.sbOrdemProducaoVazia = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimirOrdemProducaoValores = new DevExpress.XtraEditors.SimpleButton();
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
            // sbExecucao
            // 
            this.sbExecucao.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbExecucao.Location = new System.Drawing.Point(12, 406);
            this.sbExecucao.Name = "sbExecucao";
            this.sbExecucao.Size = new System.Drawing.Size(75, 23);
            this.sbExecucao.TabIndex = 20;
            this.sbExecucao.Text = "Execução";
            this.sbExecucao.Click += new System.EventHandler(this.sbExecucao_Click);
            // 
            // sbImprime
            // 
            this.sbImprime.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprime.Location = new System.Drawing.Point(93, 406);
            this.sbImprime.Name = "sbImprime";
            this.sbImprime.Size = new System.Drawing.Size(165, 23);
            this.sbImprime.TabIndex = 21;
            this.sbImprime.Text = "Imprimir Ordem de Produção";
            this.sbImprime.Click += new System.EventHandler(this.sbImprime_Click);
            // 
            // sbOrdemProducaoVazia
            // 
            this.sbOrdemProducaoVazia.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbOrdemProducaoVazia.Location = new System.Drawing.Point(93, 435);
            this.sbOrdemProducaoVazia.Name = "sbOrdemProducaoVazia";
            this.sbOrdemProducaoVazia.Size = new System.Drawing.Size(165, 23);
            this.sbOrdemProducaoVazia.TabIndex = 22;
            this.sbOrdemProducaoVazia.Text = "Ordem de Produção Vazia";
            this.sbOrdemProducaoVazia.Click += new System.EventHandler(this.sbOrdemProducaoVazia_Click);
            // 
            // sbImprimirOrdemProducaoValores
            // 
            this.sbImprimirOrdemProducaoValores.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimirOrdemProducaoValores.Location = new System.Drawing.Point(264, 406);
            this.sbImprimirOrdemProducaoValores.Name = "sbImprimirOrdemProducaoValores";
            this.sbImprimirOrdemProducaoValores.Size = new System.Drawing.Size(208, 23);
            this.sbImprimirOrdemProducaoValores.TabIndex = 23;
            this.sbImprimirOrdemProducaoValores.Text = "Imprimir Ordem de Produção Valores";
            this.sbImprimirOrdemProducaoValores.Click += new System.EventHandler(this.sbImprimirOrdemProducaoValores_Click);
            // 
            // GridOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(835, 463);
            this.Controls.Add(this.sbImprimirOrdemProducaoValores);
            this.Controls.Add(this.sbOrdemProducaoVazia);
            this.Controls.Add(this.sbImprime);
            this.Controls.Add(this.sbExecucao);
            this.Name = "GridOrdemProducao";
            this.ShowInTaskbar = false;
            this.Controls.SetChildIndex(this.btConsultar, 0);
            this.Controls.SetChildIndex(this.btIncluir, 0);
            this.Controls.SetChildIndex(this.btAlterar, 0);
            this.Controls.SetChildIndex(this.btExcluir, 0);
            this.Controls.SetChildIndex(this.sbFechar, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            this.Controls.SetChildIndex(this.btSelecionar, 0);
            this.Controls.SetChildIndex(this.sbExecucao, 0);
            this.Controls.SetChildIndex(this.sbImprime, 0);
            this.Controls.SetChildIndex(this.sbOrdemProducaoVazia, 0);
            this.Controls.SetChildIndex(this.sbImprimirOrdemProducaoValores, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbExecucao;
        private DevExpress.XtraEditors.SimpleButton sbImprime;
        private DevExpress.XtraEditors.SimpleButton sbOrdemProducaoVazia;
        private DevExpress.XtraEditors.SimpleButton sbImprimirOrdemProducaoValores;
    }
}
