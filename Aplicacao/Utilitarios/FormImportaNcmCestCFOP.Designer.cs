namespace Aplicacao.Utilitarios
{
    partial class FormImportaNcmCestCFOP
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
            this.cboTipoRegistro = new System.Windows.Forms.ComboBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnProcurarArquivo = new System.Windows.Forms.Button();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtRegistros = new System.Windows.Forms.Label();
            this.lblNumeroRegistros = new System.Windows.Forms.Label();
            this.btnImportarRegistros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoRegistro
            // 
            this.cboTipoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRegistro.FormattingEnabled = true;
            this.cboTipoRegistro.Items.AddRange(new object[] {
            "CEST",
            "CFOP",
            "NCM"});
            this.cboTipoRegistro.Location = new System.Drawing.Point(12, 12);
            this.cboTipoRegistro.Name = "cboTipoRegistro";
            this.cboTipoRegistro.Size = new System.Drawing.Size(121, 21);
            this.cboTipoRegistro.TabIndex = 1;
            // 
            // btnExibir
            // 
            this.btnExibir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibir.Location = new System.Drawing.Point(785, 10);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(115, 26);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "Exibir Todos";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnProcurarArquivo
            // 
            this.btnProcurarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarArquivo.Location = new System.Drawing.Point(664, 10);
            this.btnProcurarArquivo.Name = "btnProcurarArquivo";
            this.btnProcurarArquivo.Size = new System.Drawing.Size(115, 26);
            this.btnProcurarArquivo.TabIndex = 4;
            this.btnProcurarArquivo.Text = "Procurar Arquivo";
            this.btnProcurarArquivo.UseVisualStyleBackColor = true;
            this.btnProcurarArquivo.Click += new System.EventHandler(this.btnProcurarArquivo_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(139, 12);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(519, 21);
            this.txtCaminhoArquivo.TabIndex = 6;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(10, 42);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(890, 452);
            this.dgvDados.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = global::Aplicacao.Properties.Resources.Sair_do_Sistema_copy;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(785, 502);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 26);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtRegistros
            // 
            this.txtRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegistros.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRegistros.Location = new System.Drawing.Point(111, 502);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.Size = new System.Drawing.Size(94, 26);
            this.txtRegistros.TabIndex = 13;
            this.txtRegistros.Text = "0";
            this.txtRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumeroRegistros.AutoSize = true;
            this.lblNumeroRegistros.Location = new System.Drawing.Point(11, 509);
            this.lblNumeroRegistros.Name = "lblNumeroRegistros";
            this.lblNumeroRegistros.Size = new System.Drawing.Size(94, 13);
            this.lblNumeroRegistros.TabIndex = 12;
            this.lblNumeroRegistros.Text = "Número Registros:";
            // 
            // btnImportarRegistros
            // 
            this.btnImportarRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarRegistros.Location = new System.Drawing.Point(664, 502);
            this.btnImportarRegistros.Name = "btnImportarRegistros";
            this.btnImportarRegistros.Size = new System.Drawing.Size(115, 26);
            this.btnImportarRegistros.TabIndex = 10;
            this.btnImportarRegistros.Text = "Importar Registros";
            this.btnImportarRegistros.UseVisualStyleBackColor = true;
            this.btnImportarRegistros.Click += new System.EventHandler(this.btnImportarRegistros_Click);
            // 
            // FormImportaNcmCestCFOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 537);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.lblNumeroRegistros);
            this.Controls.Add(this.btnImportarRegistros);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnProcurarArquivo);
            this.Controls.Add(this.cboTipoRegistro);
            this.Name = "FormImportaNcmCestCFOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importa NCM Cest CFOP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoRegistro;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnProcurarArquivo;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label txtRegistros;
        private System.Windows.Forms.Label lblNumeroRegistros;
        private System.Windows.Forms.Button btnImportarRegistros;
    }
}