namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaAlterarCondicaoPagamento
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
            this.lkbCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblCondicao = new DevExpress.XtraEditors.LabelControl();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lkbCondicao
            // 
            this.lkbCondicao.Location = new System.Drawing.Point(568, 13);
            this.lkbCondicao.Lookup = null;
            this.lkbCondicao.Name = "lkbCondicao";
            this.lkbCondicao.Size = new System.Drawing.Size(31, 29);
            this.lkbCondicao.SubForm = null;
            this.lkbCondicao.SubFormType = null;
            this.lkbCondicao.SubFormTypeParams = null;
            this.lkbCondicao.TabIndex = 36;
            this.lkbCondicao.TabStop = false;
            this.lkbCondicao.Text = "...";
            this.lkbCondicao.Click += new System.EventHandler(this.lkbCondicao_Click);
            // 
            // lkpCondicao
            // 
            this.lkpCondicao.ButtonLookup = this.lkbCondicao;
            this.lkpCondicao.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpCondicao.CamposRestricoesAND = null;
            this.lkpCondicao.CamposRestricoesNOT = null;
            this.lkpCondicao.CamposRestricoesOR = null;
            this.lkpCondicao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCondicao.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpCondicao.ContextoLinq = null;
            this.lkpCondicao.CwkFuncaoValidacao = null;
            this.lkpCondicao.CwkMascara = null;
            this.lkpCondicao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCondicao.Exemplo = null;
            this.lkpCondicao.ID = 0;
            this.lkpCondicao.Join = null;
            this.lkpCondicao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCondicao.Location = new System.Drawing.Point(228, 12);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.Properties.Appearance.Options.UseFont = true;
            this.lkpCondicao.SelecionarTextoOnEnter = true;
            this.lkpCondicao.Size = new System.Drawing.Size(334, 30);
            this.lkpCondicao.Tabela = "Condicao";
            this.lkpCondicao.TabIndex = 35;
            this.lkpCondicao.TituloTelaPesquisa = "Pesquisa - Condição";
            this.lkpCondicao.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCondicao.Where = null;
            // 
            // lblCondicao
            // 
            this.lblCondicao.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicao.Appearance.Options.UseFont = true;
            this.lblCondicao.Location = new System.Drawing.Point(12, 15);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(210, 23);
            this.lblCondicao.TabIndex = 34;
            this.lblCondicao.Text = "Condição de Pagamento:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.btnVoltar.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.btnVoltar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Appearance.Options.UseBackColor = true;
            this.btnVoltar.Appearance.Options.UseFont = true;
            this.btnVoltar.Appearance.Options.UseForeColor = true;
            this.btnVoltar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnVoltar.Location = new System.Drawing.Point(301, 52);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(146, 42);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenda.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.btnFinalizarVenda.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.btnFinalizarVenda.Appearance.BorderColor = System.Drawing.Color.Green;
            this.btnFinalizarVenda.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Appearance.Options.UseBackColor = true;
            this.btnFinalizarVenda.Appearance.Options.UseBorderColor = true;
            this.btnFinalizarVenda.Appearance.Options.UseFont = true;
            this.btnFinalizarVenda.Appearance.Options.UseForeColor = true;
            this.btnFinalizarVenda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(453, 52);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(146, 42);
            this.btnFinalizarVenda.TabIndex = 38;
            this.btnFinalizarVenda.TabStop = false;
            this.btnFinalizarVenda.Text = "Alterar";
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // FormFrenteCaixaAlterarCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 106);
            this.Controls.Add(this.lkbCondicao);
            this.Controls.Add(this.lkpCondicao);
            this.Controls.Add(this.lblCondicao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFinalizarVenda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFrenteCaixaAlterarCondicaoPagamento";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar Conidção de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbCondicao;
        private DevExpress.XtraEditors.LabelControl lblCondicao;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnFinalizarVenda;
        public Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
    }
}