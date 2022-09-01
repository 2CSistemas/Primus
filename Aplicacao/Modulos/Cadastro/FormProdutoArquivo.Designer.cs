namespace Aplicacao
{
    partial class FormProdutoArquivo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.devButton1 = new Cwork.Utilitarios.Componentes.DevButton();
            this.devButton2 = new Cwork.Utilitarios.Componentes.DevButton();
            this.btSelecionarArquivo = new Cwork.Utilitarios.Componentes.DevButton();
            this.txtCaminhoArquivo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btSelecionarArquivo);
            this.panel1.Controls.Add(this.txtCaminhoArquivo);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 80);
            this.panel1.TabIndex = 0;
            // 
            // devButton1
            // 
            this.devButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devButton1.GridControl = null;
            this.devButton1.GridControlType = null;
            this.devButton1.GridControlTypeParams = null;
            this.devButton1.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.devButton1.Location = new System.Drawing.Point(396, 98);
            this.devButton1.Name = "devButton1";
            this.devButton1.Size = new System.Drawing.Size(75, 23);
            this.devButton1.SubForm = null;
            this.devButton1.SubFormType = null;
            this.devButton1.SubFormTypeParams = null;
            this.devButton1.TabIndex = 13;
            this.devButton1.Text = "Gravar";
            this.devButton1.Click += new System.EventHandler(this.devButton1_Click);
            // 
            // devButton2
            // 
            this.devButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devButton2.GridControl = null;
            this.devButton2.GridControlType = null;
            this.devButton2.GridControlTypeParams = null;
            this.devButton2.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.devButton2.Location = new System.Drawing.Point(477, 98);
            this.devButton2.Name = "devButton2";
            this.devButton2.Size = new System.Drawing.Size(75, 23);
            this.devButton2.SubForm = null;
            this.devButton2.SubFormType = null;
            this.devButton2.SubFormTypeParams = null;
            this.devButton2.TabIndex = 14;
            this.devButton2.Text = "Cancelar";
            this.devButton2.Click += new System.EventHandler(this.devButton2_Click);
            // 
            // btSelecionarArquivo
            // 
            this.btSelecionarArquivo.GridControl = null;
            this.btSelecionarArquivo.GridControlType = null;
            this.btSelecionarArquivo.GridControlTypeParams = null;
            this.btSelecionarArquivo.Location = new System.Drawing.Point(500, 17);
            this.btSelecionarArquivo.Name = "btSelecionarArquivo";
            this.btSelecionarArquivo.Size = new System.Drawing.Size(24, 20);
            this.btSelecionarArquivo.SubForm = null;
            this.btSelecionarArquivo.SubFormType = null;
            this.btSelecionarArquivo.SubFormTypeParams = null;
            this.btSelecionarArquivo.TabIndex = 20;
            this.btSelecionarArquivo.Text = "...";
            this.btSelecionarArquivo.Click += new System.EventHandler(this.btSelecionarArquivo_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.CwkFuncaoValidacao = null;
            this.txtCaminhoArquivo.CwkMascara = null;
            this.txtCaminhoArquivo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCaminhoArquivo.Enabled = false;
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(70, 17);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Properties.MaxLength = 200;
            this.txtCaminhoArquivo.SelecionarTextoOnEnter = false;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(424, 20);
            this.txtCaminhoArquivo.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Arquivo:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 46);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(70, 43);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 200;
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(455, 20);
            this.txtDescricao.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormOrcamentoArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 133);
            this.Controls.Add(this.devButton1);
            this.Controls.Add(this.devButton2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrcamentoArquivo";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Cwork.Utilitarios.Componentes.DevButton devButton1;
        private Cwork.Utilitarios.Componentes.DevButton devButton2;
        private Cwork.Utilitarios.Componentes.DevButton btSelecionarArquivo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCaminhoArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}