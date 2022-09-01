namespace Aplicacao.Modulos.Telefonia
{
    partial class FormTel_ClientePreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTel_ClientePreco));
            this.txtArea_Inicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea_Final = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrefixo_Final = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefixo_Inicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRange_Final = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRange_Inicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.chbBDentro = new DevExpress.XtraEditors.CheckEdit();
            this.chbBFora = new DevExpress.XtraEditors.CheckEdit();
            this.txtValor = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTipoLigacao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoLigacao = new Cwork.Utilitarios.Componentes.Lookup();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBDentro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBFora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoLigacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 137);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(291, 137);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(372, 137);
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
            this.tpPrincipal.Controls.Add(this.label7);
            this.tpPrincipal.Controls.Add(this.lkbTipoLigacao);
            this.tpPrincipal.Controls.Add(this.lkpTipoLigacao);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.chbBFora);
            this.tpPrincipal.Controls.Add(this.chbBDentro);
            this.tpPrincipal.Controls.Add(this.txtRange_Final);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.txtRange_Inicial);
            this.tpPrincipal.Controls.Add(this.label6);
            this.tpPrincipal.Controls.Add(this.txtPrefixo_Final);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.txtPrefixo_Inicial);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.txtArea_Final);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.txtArea_Inicial);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(426, 110);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(435, 119);
            // 
            // txtArea_Inicial
            // 
            this.txtArea_Inicial.CwkFuncaoValidacao = null;
            this.txtArea_Inicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtArea_Inicial.CwkValidacao = null;
            this.txtArea_Inicial.Location = new System.Drawing.Point(84, 6);
            this.txtArea_Inicial.Name = "txtArea_Inicial";
            this.txtArea_Inicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArea_Inicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtArea_Inicial.Properties.Mask.EditMask = "\\d{0,2}";
            this.txtArea_Inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtArea_Inicial.Properties.Mask.ShowPlaceHolders = false;
            this.txtArea_Inicial.SelecionarTextoOnEnter = true;
            this.txtArea_Inicial.Size = new System.Drawing.Size(56, 20);
            this.txtArea_Inicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtArea_Final
            // 
            this.txtArea_Final.CwkFuncaoValidacao = null;
            this.txtArea_Final.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtArea_Final.CwkValidacao = null;
            this.txtArea_Final.Location = new System.Drawing.Point(185, 6);
            this.txtArea_Final.Name = "txtArea_Final";
            this.txtArea_Final.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArea_Final.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtArea_Final.Properties.Mask.EditMask = "\\d{0,2}";
            this.txtArea_Final.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtArea_Final.Properties.Mask.ShowPlaceHolders = false;
            this.txtArea_Final.SelecionarTextoOnEnter = true;
            this.txtArea_Final.Size = new System.Drawing.Size(56, 20);
            this.txtArea_Final.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "  até  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrefixo_Final
            // 
            this.txtPrefixo_Final.CwkFuncaoValidacao = null;
            this.txtPrefixo_Final.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtPrefixo_Final.CwkValidacao = null;
            this.txtPrefixo_Final.Location = new System.Drawing.Point(185, 32);
            this.txtPrefixo_Final.Name = "txtPrefixo_Final";
            this.txtPrefixo_Final.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrefixo_Final.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrefixo_Final.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtPrefixo_Final.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrefixo_Final.Properties.Mask.ShowPlaceHolders = false;
            this.txtPrefixo_Final.SelecionarTextoOnEnter = true;
            this.txtPrefixo_Final.Size = new System.Drawing.Size(56, 20);
            this.txtPrefixo_Final.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "  até  ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrefixo_Inicial
            // 
            this.txtPrefixo_Inicial.CwkFuncaoValidacao = null;
            this.txtPrefixo_Inicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtPrefixo_Inicial.CwkValidacao = null;
            this.txtPrefixo_Inicial.Location = new System.Drawing.Point(84, 32);
            this.txtPrefixo_Inicial.Name = "txtPrefixo_Inicial";
            this.txtPrefixo_Inicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrefixo_Inicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrefixo_Inicial.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtPrefixo_Inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrefixo_Inicial.Properties.Mask.ShowPlaceHolders = false;
            this.txtPrefixo_Inicial.SelecionarTextoOnEnter = true;
            this.txtPrefixo_Inicial.Size = new System.Drawing.Size(56, 20);
            this.txtPrefixo_Inicial.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prefixo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRange_Final
            // 
            this.txtRange_Final.CwkFuncaoValidacao = null;
            this.txtRange_Final.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtRange_Final.CwkValidacao = null;
            this.txtRange_Final.Location = new System.Drawing.Point(185, 58);
            this.txtRange_Final.Name = "txtRange_Final";
            this.txtRange_Final.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRange_Final.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRange_Final.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtRange_Final.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRange_Final.Properties.Mask.ShowPlaceHolders = false;
            this.txtRange_Final.SelecionarTextoOnEnter = true;
            this.txtRange_Final.Size = new System.Drawing.Size(56, 20);
            this.txtRange_Final.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "  até  ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRange_Inicial
            // 
            this.txtRange_Inicial.CwkFuncaoValidacao = null;
            this.txtRange_Inicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtRange_Inicial.CwkValidacao = null;
            this.txtRange_Inicial.Location = new System.Drawing.Point(84, 58);
            this.txtRange_Inicial.Name = "txtRange_Inicial";
            this.txtRange_Inicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRange_Inicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRange_Inicial.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtRange_Inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRange_Inicial.Properties.Mask.ShowPlaceHolders = false;
            this.txtRange_Inicial.SelecionarTextoOnEnter = true;
            this.txtRange_Inicial.Size = new System.Drawing.Size(56, 20);
            this.txtRange_Inicial.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Range:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbBDentro
            // 
            this.chbBDentro.Location = new System.Drawing.Point(313, 6);
            this.chbBDentro.Name = "chbBDentro";
            this.chbBDentro.Properties.Caption = "Dentro";
            this.chbBDentro.Size = new System.Drawing.Size(75, 19);
            this.chbBDentro.TabIndex = 12;
            // 
            // chbBFora
            // 
            this.chbBFora.Location = new System.Drawing.Point(313, 32);
            this.chbBFora.Name = "chbBFora";
            this.chbBFora.Properties.Caption = "Fora";
            this.chbBFora.Size = new System.Drawing.Size(75, 19);
            this.chbBFora.TabIndex = 13;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(315, 58);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValor.Properties.DisplayFormat.FormatString = "c2";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.EditFormat.FormatString = "c2";
            this.txtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.PlaceHolder = '0';
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.Properties.Precision = 2;
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 15;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(281, 61);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(28, 13);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "Valor:";
            // 
            // lkbTipoLigacao
            // 
            this.lkbTipoLigacao.Location = new System.Drawing.Point(397, 84);
            this.lkbTipoLigacao.Lookup = null;
            this.lkbTipoLigacao.Name = "lkbTipoLigacao";
            this.lkbTipoLigacao.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoLigacao.SubForm = null;
            this.lkbTipoLigacao.TabIndex = 18;
            this.lkbTipoLigacao.TabStop = false;
            this.lkbTipoLigacao.Text = "...";
            // 
            // lkpTipoLigacao
            // 
            this.lkpTipoLigacao.ButtonLookup = this.lkbTipoLigacao;
            this.lkpTipoLigacao.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpTipoLigacao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoLigacao.CamposRestricoesAND")));
            this.lkpTipoLigacao.CamposRestricoesNOT = null;
            this.lkpTipoLigacao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoLigacao.CamposRestricoesOR")));
            this.lkpTipoLigacao.ColunaDescricao = new string[] {
        "Descrição",
        "Código"};
            this.lkpTipoLigacao.ColunaTamanho = new string[] {
        "300",
        "100"};
            this.lkpTipoLigacao.ContextoLinq = null;
            this.lkpTipoLigacao.CwkFuncaoValidacao = null;
            this.lkpTipoLigacao.CwkMascara = null;
            this.lkpTipoLigacao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoLigacao.Exemplo = null;
            this.lkpTipoLigacao.ID = 0;
            this.lkpTipoLigacao.Join = null;
            this.lkpTipoLigacao.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoLigacao.Location = new System.Drawing.Point(84, 84);
            this.lkpTipoLigacao.Name = "lkpTipoLigacao";
            this.lkpTipoLigacao.OnIDChanged = null;
            this.lkpTipoLigacao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoLigacao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoLigacao.SelecionarTextoOnEnter = false;
            this.lkpTipoLigacao.Size = new System.Drawing.Size(307, 20);
            this.lkpTipoLigacao.Tabela = null;
            this.lkpTipoLigacao.TabIndex = 17;
            this.lkpTipoLigacao.TituloTelaPesquisa = null;
            this.lkpTipoLigacao.ToolTip = "Campos pesquisados: Descricao, Codigo.";
            this.lkpTipoLigacao.Where = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo Ligação:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormTel_ClientePreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 172);
            this.Name = "FormTel_ClientePreco";
            this.Text = "Cliente Preço";
            this.Shown += new System.EventHandler(this.FormTel_TipoLigacaoPreco_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBDentro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBFora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoLigacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtArea_Inicial;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtArea_Final;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPrefixo_Final;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPrefixo_Inicial;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRange_Final;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRange_Inicial;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.CheckEdit chbBDentro;
        private DevExpress.XtraEditors.CheckEdit chbBFora;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoLigacao;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoLigacao;
        private System.Windows.Forms.Label label7;

    }
}