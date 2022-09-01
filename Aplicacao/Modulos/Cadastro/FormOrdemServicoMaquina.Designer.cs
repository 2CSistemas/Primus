namespace Aplicacao.Modulos.Cadastro
{
    partial class FormOrdemServicoMaquina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdemServicoMaquina));
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lkbMaquina = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpMaquina = new Cwork.Utilitarios.Componentes.Lookup();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMaquina.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(305, 69);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Gravar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(224, 70);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Fechar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lkbMaquina);
            this.panel1.Controls.Add(this.lkpMaquina);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 51);
            this.panel1.TabIndex = 6;
            // 
            // lkbMaquina
            // 
            this.lkbMaquina.Location = new System.Drawing.Point(333, 15);
            this.lkbMaquina.Lookup = null;
            this.lkbMaquina.Name = "lkbMaquina";
            this.lkbMaquina.Size = new System.Drawing.Size(24, 20);
            this.lkbMaquina.SubForm = null;
            this.lkbMaquina.SubFormType = null;
            this.lkbMaquina.SubFormTypeParams = null;
            this.lkbMaquina.TabIndex = 112;
            this.lkbMaquina.TabStop = false;
            this.lkbMaquina.Text = "...";
            this.lkbMaquina.Click += new System.EventHandler(this.lkbMaquina_Click);
            // 
            // lkpMaquina
            // 
            this.lkpMaquina.ButtonLookup = this.lkbMaquina;
            this.lkpMaquina.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpMaquina.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpMaquina.CamposRestricoesAND")));
            this.lkpMaquina.CamposRestricoesNOT = null;
            this.lkpMaquina.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpMaquina.CamposRestricoesOR")));
            this.lkpMaquina.ColunaDescricao = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpMaquina.ColunaTamanho = new string[] {
        "350",
        "50"};
            this.lkpMaquina.ContextoLinq = null;
            this.lkpMaquina.CwkFuncaoValidacao = null;
            this.lkpMaquina.CwkMascara = null;
            this.lkpMaquina.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpMaquina.Exemplo = null;
            this.lkpMaquina.ID = 0;
            this.lkpMaquina.Join = null;
            this.lkpMaquina.Key = System.Windows.Forms.Keys.F5;
            this.lkpMaquina.Location = new System.Drawing.Point(68, 15);
            this.lkpMaquina.Name = "lkpMaquina";
            this.lkpMaquina.OnIDChanged = null;
            this.lkpMaquina.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpMaquina.Properties.Appearance.Options.UseBackColor = true;
            this.lkpMaquina.SelecionarTextoOnEnter = true;
            this.lkpMaquina.Size = new System.Drawing.Size(259, 20);
            this.lkpMaquina.Tabela = null;
            this.lkpMaquina.TabIndex = 111;
            this.lkpMaquina.TituloTelaPesquisa = null;
            this.lkpMaquina.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpMaquina.Where = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Maquina:";
            // 
            // FormOrdemServicoMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 104);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Name = "FormOrdemServicoMaquina";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Ordem de Serviço Máquina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMaquina.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbMaquina;
        private Cwork.Utilitarios.Componentes.Lookup lkpMaquina;
        private System.Windows.Forms.Label label3;
    }
}