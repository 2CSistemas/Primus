namespace Aplicacao.Modulos.Cadastro
{
    partial class FormCotacaoDeMoedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCotacaoDeMoedas));
            this.txtDataCotacao = new DevExpress.XtraEditors.DateEdit();
            this.txtValorVenda = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValorCompra = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValorCotacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbMoeda = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpMoeda = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbHabilitaCotacao = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCotacao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCotacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCotacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMoeda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbHabilitaCotacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 150);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(438, 150);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(519, 150);
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
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
            this.tpPrincipal.Controls.Add(this.chbHabilitaCotacao);
            this.tpPrincipal.Controls.Add(this.txtDataCotacao);
            this.tpPrincipal.Controls.Add(this.txtValorVenda);
            this.tpPrincipal.Controls.Add(this.txtValorCompra);
            this.tpPrincipal.Controls.Add(this.txtValorCotacao);
            this.tpPrincipal.Controls.Add(this.lkbMoeda);
            this.tpPrincipal.Controls.Add(this.lkpMoeda);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label6);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Size = new System.Drawing.Size(576, 126);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(582, 132);
            // 
            // txtDataCotacao
            // 
            this.txtDataCotacao.EditValue = null;
            this.txtDataCotacao.Location = new System.Drawing.Point(94, 39);
            this.txtDataCotacao.Name = "txtDataCotacao";
            this.txtDataCotacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataCotacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataCotacao.Size = new System.Drawing.Size(100, 20);
            this.txtDataCotacao.TabIndex = 99;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.CwkFuncaoValidacao = null;
            this.txtValorVenda.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorVenda.CwkValidacao = null;
            this.txtValorVenda.Location = new System.Drawing.Point(460, 91);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorVenda.Properties.Mask.EditMask = "c3";
            this.txtValorVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorVenda.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorVenda.SelecionarTextoOnEnter = false;
            this.txtValorVenda.Size = new System.Drawing.Size(101, 20);
            this.txtValorVenda.TabIndex = 108;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.CwkFuncaoValidacao = null;
            this.txtValorCompra.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorCompra.CwkValidacao = null;
            this.txtValorCompra.Location = new System.Drawing.Point(277, 91);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorCompra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorCompra.Properties.Mask.EditMask = "c3";
            this.txtValorCompra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorCompra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorCompra.SelecionarTextoOnEnter = false;
            this.txtValorCompra.Size = new System.Drawing.Size(101, 20);
            this.txtValorCompra.TabIndex = 106;
            // 
            // txtValorCotacao
            // 
            this.txtValorCotacao.CwkFuncaoValidacao = null;
            this.txtValorCotacao.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorCotacao.CwkValidacao = null;
            this.txtValorCotacao.Location = new System.Drawing.Point(94, 91);
            this.txtValorCotacao.Name = "txtValorCotacao";
            this.txtValorCotacao.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorCotacao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorCotacao.Properties.Mask.EditMask = "c3";
            this.txtValorCotacao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorCotacao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorCotacao.SelecionarTextoOnEnter = false;
            this.txtValorCotacao.Size = new System.Drawing.Size(101, 20);
            this.txtValorCotacao.TabIndex = 104;
            // 
            // lkbMoeda
            // 
            this.lkbMoeda.Location = new System.Drawing.Point(354, 65);
            this.lkbMoeda.Lookup = null;
            this.lkbMoeda.Name = "lkbMoeda";
            this.lkbMoeda.Size = new System.Drawing.Size(24, 20);
            this.lkbMoeda.SubForm = null;
            this.lkbMoeda.SubFormType = null;
            this.lkbMoeda.SubFormTypeParams = null;
            this.lkbMoeda.TabIndex = 102;
            this.lkbMoeda.TabStop = false;
            this.lkbMoeda.Text = "...";
            this.lkbMoeda.Click += new System.EventHandler(this.lkbMoeda_Click);
            // 
            // lkpMoeda
            // 
            this.lkpMoeda.ButtonLookup = this.lkbMoeda;
            this.lkpMoeda.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpMoeda.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpMoeda.CamposRestricoesAND")));
            this.lkpMoeda.CamposRestricoesNOT = null;
            this.lkpMoeda.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpMoeda.CamposRestricoesOR")));
            this.lkpMoeda.ColunaDescricao = new string[] {
        "Descricao",
        "Código"};
            this.lkpMoeda.ColunaTamanho = new string[] {
        "350",
        "50"};
            this.lkpMoeda.ContextoLinq = null;
            this.lkpMoeda.CwkFuncaoValidacao = null;
            this.lkpMoeda.CwkMascara = null;
            this.lkpMoeda.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpMoeda.Exemplo = null;
            this.lkpMoeda.ID = 0;
            this.lkpMoeda.Join = null;
            this.lkpMoeda.Key = System.Windows.Forms.Keys.F5;
            this.lkpMoeda.Location = new System.Drawing.Point(95, 65);
            this.lkpMoeda.Name = "lkpMoeda";
            this.lkpMoeda.OnIDChanged = null;
            this.lkpMoeda.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpMoeda.Properties.Appearance.Options.UseBackColor = true;
            this.lkpMoeda.SelecionarTextoOnEnter = true;
            this.lkpMoeda.Size = new System.Drawing.Size(253, 20);
            this.lkpMoeda.Tabela = null;
            this.lkpMoeda.TabIndex = 100;
            this.lkpMoeda.TituloTelaPesquisa = null;
            this.lkpMoeda.ToolTip = "Campos pesquisados: Descricao, Codigo.";
            this.lkpMoeda.Where = null;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(94, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(62, 21);
            this.txtCodigo.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Data Cotação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Valor Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Valor Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Moeda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Valor Cotação:";
            // 
            // chbHabilitaCotacao
            // 
            this.chbHabilitaCotacao.Location = new System.Drawing.Point(200, 40);
            this.chbHabilitaCotacao.Name = "chbHabilitaCotacao";
            this.chbHabilitaCotacao.Properties.Caption = "Habilita Cotação";
            this.chbHabilitaCotacao.Size = new System.Drawing.Size(111, 19);
            this.chbHabilitaCotacao.TabIndex = 112;
            // 
            // FormCotacaoDeMoedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 185);
            this.MinimizeBox = false;
            this.Name = "FormCotacaoDeMoedas";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cadastro de Cotação de Moedas";
            this.Shown += new System.EventHandler(this.FormCotacaoDeMoedas_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCotacaoDeMoedas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCotacao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCotacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCotacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMoeda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbHabilitaCotacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtDataCotacao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorVenda;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorCompra;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorCotacao;
        private Cwork.Utilitarios.Componentes.LookupButton lkbMoeda;
        private Cwork.Utilitarios.Componentes.Lookup lkpMoeda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CheckEdit chbHabilitaCotacao;
    }
}