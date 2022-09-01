namespace Aplicacao.PCP
{
    partial class FormManutEtapaProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutEtapaProducao));
            this.label1 = new System.Windows.Forms.Label();
            this.lkbServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtSequencia = new Cwork.Utilitarios.Componentes.DevSpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.txtTitulo = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(574, 149);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtTitulo);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtObservacao);
            this.xtraTabPage1.Controls.Add(this.txtSequencia);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.lkbServico);
            this.xtraTabPage1.Controls.Add(this.lkServico);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Size = new System.Drawing.Size(565, 140);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(511, 167);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(430, 167);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 167);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serviço:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lkbServico
            // 
            this.lkbServico.Location = new System.Drawing.Point(538, 29);
            this.lkbServico.Name = "lkbServico";
            this.lkbServico.Size = new System.Drawing.Size(24, 20);
            this.lkbServico.TabIndex = 4;
            this.lkbServico.TabStop = false;
            this.lkbServico.Text = "...";
            this.lkbServico.Click += new System.EventHandler(this.lkbServico_Click);
            // 
            // lkServico
            // 
            this.lkServico.ButtonLookup = this.lkbServico;
            this.lkServico.CamposPesquisa = new string[] {
        "nome",
        "=codigo"};
            this.lkServico.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkServico.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkServico.ContextoLinq = null;
            this.lkServico.ID = 0;
            this.lkServico.Join = null;
            this.lkServico.Key = System.Windows.Forms.Keys.F5;
            this.lkServico.Location = new System.Drawing.Point(77, 29);
            this.lkServico.Name = "lkServico";
            this.lkServico.OnIDChanged = null;
            this.lkServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkServico.Size = new System.Drawing.Size(455, 20);
            this.lkServico.Tabela = "Servico";
            this.lkServico.TabIndex = 3;
            this.lkServico.TituloTelaPesquisa = "Pesquisa - Serviço";
            this.lkServico.Where = null;
            // 
            // txtSequencia
            // 
            this.txtSequencia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSequencia.Location = new System.Drawing.Point(77, 3);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtSequencia.Properties.IsFloatValue = false;
            this.txtSequencia.Properties.Mask.EditMask = "N00";
            this.txtSequencia.Size = new System.Drawing.Size(99, 20);
            this.txtSequencia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sequência:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observação:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(77, 81);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.MaxLength = 600;
            this.txtObservacao.Size = new System.Drawing.Size(455, 55);
            this.txtObservacao.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(77, 55);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(455, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Título:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormManutEtapaProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(598, 202);
            this.Name = "FormManutEtapaProducao";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbServico;
        private Cwork.Utilitarios.Componentes.Lookup lkServico;
        private Cwork.Utilitarios.Componentes.DevSpinEdit txtSequencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtObservacao;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTitulo;
    }
}
