namespace Aplicacao
{
    partial class FormOSEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSEquipamento));
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroSerie = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lblNumeroSerie = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkpOSTipoEquipamento = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lkbOSTipoEquipamento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.pnlImei = new System.Windows.Forms.Panel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtModelo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOSTipoEquipamento.Properties)).BeginInit();
            this.pnlImei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 164);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(285, 164);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(366, 164);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.pnlImei);
            this.tpPrincipal.Controls.Add(this.lkbOSTipoEquipamento);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.lkpOSTipoEquipamento);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.lblNumeroSerie);
            this.tpPrincipal.Controls.Add(this.txtNumeroSerie);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Size = new System.Drawing.Size(423, 140);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(429, 146);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(116, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(55, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(73, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Código:";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.CwkFuncaoValidacao = null;
            this.txtNumeroSerie.CwkMascara = null;
            this.txtNumeroSerie.CwkValidacao = null;
            this.txtNumeroSerie.Location = new System.Drawing.Point(282, 3);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Properties.MaxLength = 50;
            this.txtNumeroSerie.SelecionarTextoOnEnter = true;
            this.txtNumeroSerie.Size = new System.Drawing.Size(129, 20);
            this.txtNumeroSerie.TabIndex = 3;
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.Location = new System.Drawing.Point(193, 6);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroSerie.TabIndex = 4;
            this.lblNumeroSerie.Text = "Número de Série:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(116, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 150;
            this.txtDescricao.SelecionarTextoOnEnter = true;
            this.txtDescricao.Size = new System.Drawing.Size(295, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(60, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Descrição:";
            // 
            // lkpOSTipoEquipamento
            // 
            this.lkpOSTipoEquipamento.ButtonLookup = this.lkbOSTipoEquipamento;
            this.lkpOSTipoEquipamento.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpOSTipoEquipamento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOSTipoEquipamento.CamposRestricoesAND")));
            this.lkpOSTipoEquipamento.CamposRestricoesNOT = null;
            this.lkpOSTipoEquipamento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOSTipoEquipamento.CamposRestricoesOR")));
            this.lkpOSTipoEquipamento.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkpOSTipoEquipamento.ColunaTamanho = new string[] {
        "100",
        "200"};
            this.lkpOSTipoEquipamento.ContextoLinq = null;
            this.lkpOSTipoEquipamento.CwkFuncaoValidacao = null;
            this.lkpOSTipoEquipamento.CwkMascara = null;
            this.lkpOSTipoEquipamento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpOSTipoEquipamento.Exemplo = null;
            this.lkpOSTipoEquipamento.ID = 0;
            this.lkpOSTipoEquipamento.Join = null;
            this.lkpOSTipoEquipamento.Key = System.Windows.Forms.Keys.F5;
            this.lkpOSTipoEquipamento.Location = new System.Drawing.Point(116, 55);
            this.lkpOSTipoEquipamento.Name = "lkpOSTipoEquipamento";
            this.lkpOSTipoEquipamento.OnIDChanged = null;
            this.lkpOSTipoEquipamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpOSTipoEquipamento.Properties.Appearance.Options.UseBackColor = true;
            this.lkpOSTipoEquipamento.SelecionarTextoOnEnter = true;
            this.lkpOSTipoEquipamento.Size = new System.Drawing.Size(265, 20);
            this.lkpOSTipoEquipamento.Tabela = null;
            this.lkpOSTipoEquipamento.TabIndex = 7;
            this.lkpOSTipoEquipamento.TituloTelaPesquisa = null;
            this.lkpOSTipoEquipamento.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpOSTipoEquipamento.Where = null;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tipo de Equipamento:";
            // 
            // lkbOSTipoEquipamento
            // 
            this.lkbOSTipoEquipamento.Location = new System.Drawing.Point(387, 55);
            this.lkbOSTipoEquipamento.Lookup = null;
            this.lkbOSTipoEquipamento.Name = "lkbOSTipoEquipamento";
            this.lkbOSTipoEquipamento.Size = new System.Drawing.Size(24, 20);
            this.lkbOSTipoEquipamento.SubForm = null;
            this.lkbOSTipoEquipamento.SubFormType = null;
            this.lkbOSTipoEquipamento.SubFormTypeParams = null;
            this.lkbOSTipoEquipamento.TabIndex = 9;
            this.lkbOSTipoEquipamento.TabStop = false;
            this.lkbOSTipoEquipamento.Text = "...";
            // 
            // pnlImei
            // 
            this.pnlImei.Controls.Add(this.labelControl6);
            this.pnlImei.Controls.Add(this.txtModelo);
            this.pnlImei.Controls.Add(this.labelControl5);
            this.pnlImei.Controls.Add(this.txtMarca);
            this.pnlImei.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlImei.Location = new System.Drawing.Point(0, 78);
            this.pnlImei.Name = "pnlImei";
            this.pnlImei.Size = new System.Drawing.Size(423, 62);
            this.pnlImei.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(77, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.CwkFuncaoValidacao = null;
            this.txtMarca.CwkMascara = null;
            this.txtMarca.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtMarca.Location = new System.Drawing.Point(116, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.MaxLength = 150;
            this.txtMarca.SelecionarTextoOnEnter = true;
            this.txtMarca.Size = new System.Drawing.Size(295, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(72, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.CwkFuncaoValidacao = null;
            this.txtModelo.CwkMascara = null;
            this.txtModelo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtModelo.Location = new System.Drawing.Point(116, 29);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.MaxLength = 150;
            this.txtModelo.SelecionarTextoOnEnter = true;
            this.txtModelo.Size = new System.Drawing.Size(295, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // FormOSEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(453, 199);
            this.Name = "FormOSEquipamento";
            this.Shown += new System.EventHandler(this.FormOSEquipamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOSTipoEquipamento.Properties)).EndInit();
            this.pnlImei.ResumeLayout(false);
            this.pnlImei.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImei;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtModelo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtMarca;
        private Cwork.Utilitarios.Componentes.LookupButton lkbOSTipoEquipamento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.Lookup lkpOSTipoEquipamento;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private DevExpress.XtraEditors.LabelControl lblNumeroSerie;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumeroSerie;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;


    }
}
