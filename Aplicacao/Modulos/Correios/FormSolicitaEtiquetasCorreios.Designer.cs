namespace Aplicacao.Modulos.Correios
{
    partial class FormSolicitaEtiquetasCorreios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolicitaEtiquetasCorreios));
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTipoServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.DevTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(397, 102);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtQuantidade);
            this.xtraTabPage1.Controls.Add(this.lkpTipoServico);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.lkbTipoServico);
            this.xtraTabPage1.Controls.Add(this.lkbFilial);
            this.xtraTabPage1.Controls.Add(this.lkpFilial);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Size = new System.Drawing.Size(391, 96);
            this.xtraTabPage1.Text = "";
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(329, 115);
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
            this.sbGravar.Image = global::Aplicacao.Properties.Resources._1333658965_arrow_refresh;
            this.sbGravar.Location = new System.Drawing.Point(248, 115);
            this.sbGravar.Text = "Solicitar";
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(13, 115);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(355, 14);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.TabIndex = 6;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFilial.CamposRestricoesAND = null;
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = null;
            this.lkpFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(71, 14);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(278, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Empresa:";
            // 
            // lkbTipoServico
            // 
            this.lkbTipoServico.Location = new System.Drawing.Point(355, 40);
            this.lkbTipoServico.Lookup = this.lkpTipoServico;
            this.lkbTipoServico.Name = "lkbTipoServico";
            this.lkbTipoServico.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoServico.SubForm = null;
            this.lkbTipoServico.TabIndex = 8;
            this.lkbTipoServico.TabStop = false;
            this.lkbTipoServico.Text = "...";
            this.lkbTipoServico.Click += new System.EventHandler(this.lkbTipoServico_Click);
            // 
            // lkpTipoServico
            // 
            this.lkpTipoServico.ButtonLookup = this.lkbTipoServico;
            this.lkpTipoServico.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpTipoServico.CamposRestricoesAND = null;
            this.lkpTipoServico.CamposRestricoesNOT = null;
            this.lkpTipoServico.CamposRestricoesOR = null;
            this.lkpTipoServico.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoServico.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoServico.ContextoLinq = null;
            this.lkpTipoServico.CwkFuncaoValidacao = null;
            this.lkpTipoServico.CwkMascara = null;
            this.lkpTipoServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoServico.Exemplo = null;
            this.lkpTipoServico.ID = 0;
            this.lkpTipoServico.Join = null;
            this.lkpTipoServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoServico.Location = new System.Drawing.Point(71, 40);
            this.lkpTipoServico.Name = "lkpTipoServico";
            this.lkpTipoServico.OnIDChanged = null;
            this.lkpTipoServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoServico.SelecionarTextoOnEnter = true;
            this.lkpTipoServico.Size = new System.Drawing.Size(278, 20);
            this.lkpTipoServico.Tabela = "TipoServicoTransporte";
            this.lkpTipoServico.TabIndex = 2;
            this.lkpTipoServico.TituloTelaPesquisa = "Pesquisa - Tipo Servico Transporte";
            this.lkpTipoServico.ToolTip = "Campos pesquisados: Descricao, Codigo.";
            this.lkpTipoServico.Where = null;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Tipo Serviço:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtQuantidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtQuantidade.Location = new System.Drawing.Point(71, 68);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtQuantidade.Properties.Mask.ShowPlaceHolders = false;
            this.txtQuantidade.Properties.MaxLength = 5;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(94, 20);
            this.txtQuantidade.TabIndex = 11;
            // 
            // FormSolicitaEtiquetasCorreios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 145);
            this.Name = "FormSolicitaEtiquetasCorreios";
            this.Text = "Solicitando Etiquetas Correios";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoServico;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoServico;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtQuantidade;
    }
}