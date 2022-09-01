namespace Aplicacao.Modulos.Cadastro
{
    partial class FormProdutoVarejo
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
            this.groupCompPreco = new DevExpress.XtraEditors.GroupControl();
            this.txtQuantidadeFinal = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtPreco = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label19 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label17 = new System.Windows.Forms.Label();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuantidadeInicial = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCompPreco)).BeginInit();
            this.groupCompPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCompPreco
            // 
            this.groupCompPreco.Controls.Add(this.txtQuantidadeInicial);
            this.groupCompPreco.Controls.Add(this.txtQuantidadeFinal);
            this.groupCompPreco.Controls.Add(this.txtPreco);
            this.groupCompPreco.Controls.Add(this.label19);
            this.groupCompPreco.Controls.Add(this.labelControl1);
            this.groupCompPreco.Controls.Add(this.label17);
            this.groupCompPreco.Location = new System.Drawing.Point(12, 12);
            this.groupCompPreco.Name = "groupCompPreco";
            this.groupCompPreco.Size = new System.Drawing.Size(581, 65);
            this.groupCompPreco.TabIndex = 1;
            this.groupCompPreco.Text = "Composição do Preço";
            // 
            // txtQuantidadeFinal
            // 
            this.txtQuantidadeFinal.Location = new System.Drawing.Point(319, 29);
            this.txtQuantidadeFinal.Name = "txtQuantidadeFinal";
            this.txtQuantidadeFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantidadeFinal.Properties.Mask.EditMask = "N0";
            this.txtQuantidadeFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidadeFinal.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeFinal.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(469, 29);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPreco.Properties.Mask.EditMask = "C2";
            this.txtPreco.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(218, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Quantidade Final:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Quantidade Inicial:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(425, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Preço:";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.ImageOptions.ImageIndex = 2;
            this.simpleButton5.Location = new System.Drawing.Point(518, 83);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 6;
            this.simpleButton5.Text = "Cancelar";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton6.ImageOptions.ImageIndex = 5;
            this.simpleButton6.Location = new System.Drawing.Point(440, 83);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 23);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Gravar";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // txtQuantidadeInicial
            // 
            this.txtQuantidadeInicial.Location = new System.Drawing.Point(112, 29);
            this.txtQuantidadeInicial.Name = "txtQuantidadeInicial";
            this.txtQuantidadeInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantidadeInicial.Properties.Mask.EditMask = "N0";
            this.txtQuantidadeInicial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidadeInicial.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeInicial.TabIndex = 2;
            // 
            // FormProdutoVarejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 118);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.groupCompPreco);
            this.Name = "FormProdutoVarejo";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRODUTO VAREJO";
            ((System.ComponentModel.ISupportInitialize)(this.groupCompPreco)).EndInit();
            this.groupCompPreco.ResumeLayout(false);
            this.groupCompPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadeInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupCompPreco;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label17;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton5;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton6;
        public Cwork.Utilitarios.Componentes.DevCalcEdit txtQuantidadeFinal;
        public Cwork.Utilitarios.Componentes.DevCalcEdit txtPreco;
        public Cwork.Utilitarios.Componentes.DevCalcEdit txtQuantidadeInicial;
    }
}