
namespace Aplicacao.Modulos.Rel
{
    partial class FormRelatorioNcmCompleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioNcmCompleto));
            this.sbFechar = new System.Windows.Forms.Button();
            this.sbImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNcmInicial = new System.Windows.Forms.TextBox();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_CodigoInicial = new System.Windows.Forms.Label();
            this.txtNcmFinal = new System.Windows.Forms.TextBox();
            this.ckbTodosNCMs = new DevExpress.XtraEditors.CheckEdit();
            this.txt_CodigoFinal = new System.Windows.Forms.Label();
            this.chbSalvarFiltro = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTodosNCMs.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbFechar
            // 
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbFechar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sbFechar.Location = new System.Drawing.Point(436, 93);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(89, 23);
            this.sbFechar.TabIndex = 7;
            this.sbFechar.Text = "Cancelar";
            this.sbFechar.UseVisualStyleBackColor = true;
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // sbImprimir
            // 
            this.sbImprimir.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbImprimir.Location = new System.Drawing.Point(349, 93);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(81, 23);
            this.sbImprimir.TabIndex = 6;
            this.sbImprimir.Text = "OK";
            this.sbImprimir.UseVisualStyleBackColor = true;
            this.sbImprimir.Click += new System.EventHandler(this.sbImprimir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNcmInicial);
            this.panel1.Controls.Add(this.cbSituacao);
            this.panel1.Controls.Add(this.txt_CodigoInicial);
            this.panel1.Controls.Add(this.txtNcmFinal);
            this.panel1.Controls.Add(this.ckbTodosNCMs);
            this.panel1.Controls.Add(this.txt_CodigoFinal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 75);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Situação:";
            // 
            // txtNcmInicial
            // 
            this.txtNcmInicial.Location = new System.Drawing.Point(80, 12);
            this.txtNcmInicial.Name = "txtNcmInicial";
            this.txtNcmInicial.Size = new System.Drawing.Size(97, 20);
            this.txtNcmInicial.TabIndex = 49;
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(80, 38);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacao.Properties.ImmediatePopup = true;
            this.cbSituacao.Properties.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Revogados"});
            this.cbSituacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSituacao.Size = new System.Drawing.Size(97, 20);
            this.cbSituacao.TabIndex = 51;
            // 
            // txt_CodigoInicial
            // 
            this.txt_CodigoInicial.AutoSize = true;
            this.txt_CodigoInicial.Location = new System.Drawing.Point(10, 15);
            this.txt_CodigoInicial.Name = "txt_CodigoInicial";
            this.txt_CodigoInicial.Size = new System.Drawing.Size(64, 13);
            this.txt_CodigoInicial.TabIndex = 52;
            this.txt_CodigoInicial.Text = "NCM Inicial:";
            // 
            // txtNcmFinal
            // 
            this.txtNcmFinal.Location = new System.Drawing.Point(230, 12);
            this.txtNcmFinal.Name = "txtNcmFinal";
            this.txtNcmFinal.Size = new System.Drawing.Size(97, 20);
            this.txtNcmFinal.TabIndex = 50;
            // 
            // ckbTodosNCMs
            // 
            this.ckbTodosNCMs.Location = new System.Drawing.Point(376, 39);
            this.ckbTodosNCMs.Name = "ckbTodosNCMs";
            this.ckbTodosNCMs.Properties.Caption = "Todos NCMs";
            this.ckbTodosNCMs.Size = new System.Drawing.Size(88, 19);
            this.ckbTodosNCMs.TabIndex = 54;
            // 
            // txt_CodigoFinal
            // 
            this.txt_CodigoFinal.AutoSize = true;
            this.txt_CodigoFinal.Location = new System.Drawing.Point(198, 15);
            this.txt_CodigoFinal.Name = "txt_CodigoFinal";
            this.txt_CodigoFinal.Size = new System.Drawing.Size(13, 13);
            this.txt_CodigoFinal.TabIndex = 53;
            this.txt_CodigoFinal.Text = "à";
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.AutoSize = true;
            this.chbSalvarFiltro.Location = new System.Drawing.Point(12, 97);
            this.chbSalvarFiltro.Name = "chbSalvarFiltro";
            this.chbSalvarFiltro.Size = new System.Drawing.Size(81, 17);
            this.chbSalvarFiltro.TabIndex = 9;
            this.chbSalvarFiltro.Text = "Salvar Filtro";
            this.chbSalvarFiltro.UseVisualStyleBackColor = true;
            // 
            // FormRelatorioNcmCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 129);
            this.Controls.Add(this.chbSalvarFiltro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.sbImprimir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormRelatorioNcmCompleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de NCM Completo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRelatorioNcmCompleto_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTodosNCMs.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sbFechar;
        private System.Windows.Forms.Button sbImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNcmInicial;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private System.Windows.Forms.Label txt_CodigoInicial;
        private System.Windows.Forms.TextBox txtNcmFinal;
        private DevExpress.XtraEditors.CheckEdit ckbTodosNCMs;
        private System.Windows.Forms.Label txt_CodigoFinal;
        private System.Windows.Forms.CheckBox chbSalvarFiltro;
    }
}