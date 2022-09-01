namespace Aplicacao
{
    public partial class FormNotaServicoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaServicoItem));
            this.txtTotal = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtServicoDescricao = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblServico = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValorUnitario = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 191);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(618, 191);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(699, 191);
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
            this.tpPrincipal.Controls.Add(this.txtValorUnitario);
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.txtQuantidade);
            this.tpPrincipal.Controls.Add(this.lkpServico);
            this.tpPrincipal.Controls.Add(this.btnlkpServico);
            this.tpPrincipal.Controls.Add(this.txtTotal);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtServicoDescricao);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.lblServico);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(753, 164);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(762, 173);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(74, 133);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotal.Properties.DisplayFormat.FormatString = "c2";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.Mask.EditMask = "c2";
            this.txtTotal.Properties.Precision = 2;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Total:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Vlr. Unitário:";
            // 
            // txtServicoDescricao
            // 
            this.txtServicoDescricao.Location = new System.Drawing.Point(74, 55);
            this.txtServicoDescricao.Name = "txtServicoDescricao";
            this.txtServicoDescricao.Properties.MaxLength = 100;
            this.txtServicoDescricao.Size = new System.Drawing.Size(666, 20);
            this.txtServicoDescricao.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 84);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Quantidade:";
            // 
            // lblServico
            // 
            this.lblServico.Location = new System.Drawing.Point(29, 32);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(39, 13);
            this.lblServico.TabIndex = 2;
            this.lblServico.Text = "Serviço:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sequencia:";
            // 
            // btnlkpServico
            // 
            this.btnlkpServico.Location = new System.Drawing.Point(716, 29);
            this.btnlkpServico.Lookup = null;
            this.btnlkpServico.Name = "btnlkpServico";
            this.btnlkpServico.Size = new System.Drawing.Size(24, 20);
            this.btnlkpServico.SubForm = null;
            this.btnlkpServico.TabIndex = 4;
            this.btnlkpServico.TabStop = false;
            this.btnlkpServico.Text = "...";
            // 
            // lkpServico
            // 
            this.lkpServico.ButtonLookup = this.btnlkpServico;
            this.lkpServico.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpServico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesAND")));
            this.lkpServico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesOR")));
            this.lkpServico.ColunaDescricao = new string[] {
        "Nome",
        "Codigo",
        null,
        null,
        null};
            this.lkpServico.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpServico.ContextoLinq = null;
            this.lkpServico.CwkFuncaoValidacao = null;
            this.lkpServico.CwkMascara = null;
            this.lkpServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpServico.Exemplo = null;
            this.lkpServico.ID = 0;
            this.lkpServico.Join = null;
            this.lkpServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpServico.Location = new System.Drawing.Point(74, 29);
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.OnIDChanged = null;
            this.lkpServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpServico.Size = new System.Drawing.Size(636, 20);
            this.lkpServico.Tabela = null;
            this.lkpServico.TabIndex = 3;
            this.lkpServico.TituloTelaPesquisa = null;
            this.lkpServico.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpServico.Where = null;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.QTD;
            this.txtQuantidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtQuantidade.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQuantidade.Location = new System.Drawing.Point(74, 81);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "N4";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.Validated += new System.EventHandler(this.txtQuantidade_Validated);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtSequencia.Location = new System.Drawing.Point(74, 3);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSequencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSequencia.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSequencia.Properties.Mask.ShowPlaceHolders = false;
            this.txtSequencia.Size = new System.Drawing.Size(100, 20);
            this.txtSequencia.TabIndex = 1;
            this.txtSequencia.TabStop = false;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(74, 107);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorUnitario.Properties.DisplayFormat.FormatString = "c2";
            this.txtValorUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorUnitario.Properties.Mask.EditMask = "c2";
            this.txtValorUnitario.Properties.Precision = 2;
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtValorUnitario.TabIndex = 9;
            this.txtValorUnitario.Enter += new System.EventHandler(this.txtValorUnitario_Enter);
            this.txtValorUnitario.Validated += new System.EventHandler(this.txtValorUnitario_Validated);
            // 
            // FormNotaServicoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(786, 226);
            this.Name = "FormNotaServicoItem";
            this.Shown += new System.EventHandler(this.FormNotaServicoItem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtServicoDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblServico;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpServico;
        private Cwork.Utilitarios.Componentes.Lookup lkpServico;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValorUnitario;


    }
}
