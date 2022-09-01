namespace Aplicacao.Relatorios
{
    partial class CReceberPorCentroCusto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CReceberPorCentroCusto));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.chbFiltraCC = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkbProjeto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpProjeto = new Cwork.Utilitarios.Componentes.Lookup();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFiltraCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(712, 399);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lkbProjeto);
            this.tabPage1.Controls.Add(this.lkpProjeto);
            this.tabPage1.Controls.Add(this.chbFiltraCC);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.cbSituacao);
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Size = new System.Drawing.Size(703, 390);
            this.tabPage1.Controls.SetChildIndex(this.labelControl10, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbSituacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl4, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl8, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbFiltraCC, 0);
            this.tabPage1.Controls.SetChildIndex(this.lkpProjeto, 0);
            this.tabPage1.Controls.SetChildIndex(this.lkbProjeto, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 417);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 417);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 421);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 417);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(597, 364);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(467, 364);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Período:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(1, 364);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Situação:";
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(52, 361);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacao.Properties.ImmediatePopup = true;
            this.cbSituacao.Properties.Items.AddRange(new object[] {
            "Aberto",
            "Norm",
            "BxP",
            "BxT",
            "TDesc",
            "Canc"});
            this.cbSituacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSituacao.Size = new System.Drawing.Size(128, 20);
            this.cbSituacao.TabIndex = 10;
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(607, 361);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 14;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(513, 361);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 12;
            // 
            // chbFiltraCC
            // 
            this.chbFiltraCC.Location = new System.Drawing.Point(50, 336);
            this.chbFiltraCC.Name = "chbFiltraCC";
            this.chbFiltraCC.Properties.Caption = "Filtrar por Centro de Custo";
            this.chbFiltraCC.Size = new System.Drawing.Size(153, 19);
            this.chbFiltraCC.TabIndex = 5;
            this.chbFiltraCC.CheckedChanged += new System.EventHandler(this.chbFiltraCC_CheckedChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(250, 339);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(83, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Centro de Custo:";
            // 
            // lkbProjeto
            // 
            this.lkbProjeto.Location = new System.Drawing.Point(663, 336);
            this.lkbProjeto.Lookup = null;
            this.lkbProjeto.Name = "lkbProjeto";
            this.lkbProjeto.Size = new System.Drawing.Size(24, 20);
            this.lkbProjeto.SubForm = null;
            this.lkbProjeto.TabIndex = 16;
            this.lkbProjeto.TabStop = false;
            this.lkbProjeto.Text = "...";
            this.lkbProjeto.Click += new System.EventHandler(this.lkbProjeto_Click);
            // 
            // lkpProjeto
            // 
            this.lkpProjeto.ButtonLookup = this.lkbProjeto;
            this.lkpProjeto.CamposPesquisa = new string[] {
        "Nome",
        "ID"};
            this.lkpProjeto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesAND")));
            this.lkpProjeto.CamposRestricoesNOT = null;
            this.lkpProjeto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesOR")));
            this.lkpProjeto.ColunaDescricao = new string[] {
        "Nome",
        "ID"};
            this.lkpProjeto.ColunaTamanho = new string[] {
        "80",
        "120",
        null,
        null,
        null};
            this.lkpProjeto.ContextoLinq = null;
            this.lkpProjeto.CwkFuncaoValidacao = null;
            this.lkpProjeto.CwkMascara = null;
            this.lkpProjeto.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpProjeto.Exemplo = null;
            this.lkpProjeto.ID = 0;
            this.lkpProjeto.Join = null;
            this.lkpProjeto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProjeto.Location = new System.Drawing.Point(339, 336);
            this.lkpProjeto.Name = "lkpProjeto";
            this.lkpProjeto.OnIDChanged = null;
            this.lkpProjeto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProjeto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProjeto.SelecionarTextoOnEnter = false;
            this.lkpProjeto.Size = new System.Drawing.Size(318, 20);
            this.lkpProjeto.Tabela = null;
            this.lkpProjeto.TabIndex = 15;
            this.lkpProjeto.TituloTelaPesquisa = null;
            this.lkpProjeto.ToolTip = "Campos pesquisados: Nome, ID.";
            this.lkpProjeto.Where = null;
            // 
            // CReceberPorCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 446);
            this.Name = "CReceberPorCentroCusto";
            this.Text = "Relatório de Conta a Receber por Período e Centro de Custo";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFiltraCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.CheckEdit chbFiltraCC;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProjeto;
        private Cwork.Utilitarios.Componentes.Lookup lkpProjeto;
    }
}
