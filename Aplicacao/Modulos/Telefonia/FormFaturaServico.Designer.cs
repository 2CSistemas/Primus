namespace Aplicacao.Modulos.Telefonia
{
    partial class FormFaturaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturaServico));
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorUnitario = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lkbServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbOperacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOperacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 141);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(350, 141);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(431, 141);
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
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.labelControl9);
            this.tpPrincipal.Controls.Add(this.cbOperacao);
            this.tpPrincipal.Controls.Add(this.lkbServico);
            this.tpPrincipal.Controls.Add(this.lkpServico);
            this.tpPrincipal.Controls.Add(this.txtTotal);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.txtQuantidade);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.txtValorUnitario);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(487, 116);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(494, 123);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeralInteiro;
            this.txtSequencia.Location = new System.Drawing.Point(80, 6);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSequencia.Properties.Appearance.Options.UseBackColor = true;
            this.txtSequencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSequencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSequencia.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSequencia.Properties.Mask.ShowPlaceHolders = false;
            this.txtSequencia.Properties.ReadOnly = true;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(105, 20);
            this.txtSequencia.TabIndex = 1;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(21, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sequência:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.CwkFuncaoValidacao = null;
            this.txtValorUnitario.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorUnitario.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtValorUnitario.Location = new System.Drawing.Point(80, 58);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtValorUnitario.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorUnitario.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorUnitario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorUnitario.Properties.Mask.EditMask = "c2";
            this.txtValorUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorUnitario.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorUnitario.SelecionarTextoOnEnter = false;
            this.txtValorUnitario.Size = new System.Drawing.Size(105, 20);
            this.txtValorUnitario.TabIndex = 8;
            this.txtValorUnitario.Leave += new System.EventHandler(this.txtValorUnitario_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Valor Unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtQuantidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtQuantidade.Location = new System.Drawing.Point(343, 58);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Properties.Appearance.Options.UseBackColor = true;
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtQuantidade.Properties.Mask.ShowPlaceHolders = false;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(105, 20);
            this.txtQuantidade.TabIndex = 10;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(277, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Quantidade:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(80, 84);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.txtTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTotal.Properties.DisplayFormat.FormatString = "C2";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.Precision = 2;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(105, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(46, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Total:";
            // 
            // lkbServico
            // 
            this.lkbServico.Location = new System.Drawing.Point(454, 32);
            this.lkbServico.Lookup = null;
            this.lkbServico.Name = "lkbServico";
            this.lkbServico.Size = new System.Drawing.Size(24, 20);
            this.lkbServico.SubForm = null;
            this.lkbServico.TabIndex = 6;
            this.lkbServico.TabStop = false;
            this.lkbServico.Text = "...";
            // 
            // lkpServico
            // 
            this.lkpServico.ButtonLookup = this.lkbServico;
            this.lkpServico.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpServico.CamposRestricoesAND = null;
            this.lkpServico.CamposRestricoesNOT = null;
            this.lkpServico.CamposRestricoesOR = null;
            this.lkpServico.ColunaDescricao = new string[] {
        "Descrição",
        "Código"};
            this.lkpServico.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpServico.ContextoLinq = null;
            this.lkpServico.CwkFuncaoValidacao = null;
            this.lkpServico.CwkMascara = null;
            this.lkpServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpServico.Exemplo = null;
            this.lkpServico.ID = 0;
            this.lkpServico.Join = null;
            this.lkpServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpServico.Location = new System.Drawing.Point(80, 32);
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.OnIDChanged = null;
            this.lkpServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpServico.SelecionarTextoOnEnter = true;
            this.lkpServico.Size = new System.Drawing.Size(368, 20);
            this.lkpServico.Tabela = "Tel_Servico";
            this.lkpServico.TabIndex = 5;
            this.lkpServico.TituloTelaPesquisa = "Pesquisa - Serviços";
            this.lkpServico.ToolTip = "Campos pesquisados: Descricao, Codigo.";
            this.lkpServico.Where = null;
            this.lkpServico.Leave += new System.EventHandler(this.lkpServico_Leave);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(286, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Operação:";
            // 
            // cbOperacao
            // 
            this.cbOperacao.EditValue = "1 | Débito";
            this.cbOperacao.Location = new System.Drawing.Point(343, 6);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOperacao.Properties.ImmediatePopup = true;
            this.cbOperacao.Properties.Items.AddRange(new object[] {
            "0 | Crédito",
            "1 | Débito"});
            this.cbOperacao.Properties.Tag = "";
            this.cbOperacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbOperacao.Size = new System.Drawing.Size(105, 20);
            this.cbOperacao.TabIndex = 3;
            this.cbOperacao.SelectedIndexChanged += new System.EventHandler(this.cbOperacao_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Serviço:";
            // 
            // FormFaturaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 176);
            this.Name = "FormFaturaServico";
            this.Text = "FormFaturaServico";
            this.Shown += new System.EventHandler(this.FormFaturaServico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOperacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorUnitario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.LookupButton lkbServico;
        private Cwork.Utilitarios.Componentes.Lookup lkpServico;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cbOperacao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}