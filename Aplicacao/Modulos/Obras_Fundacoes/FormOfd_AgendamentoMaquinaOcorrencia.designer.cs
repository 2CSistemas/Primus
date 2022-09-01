namespace Aplicacao
{
    partial class FormOfd_AgendamentoMaquinaOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_AgendamentoMaquinaOcorrencia));
            this.lblOcorrencia = new DevExpress.XtraEditors.LabelControl();
            this.txtTempoOcorrencia = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lblObservacaoOcorrencia = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpOcorrencia = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpOcorrencia = new Cwork.Utilitarios.Componentes.Lookup();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoOcorrencia.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoOcorrencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOcorrencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 137);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(408, 137);
            this.sbGravar.TabIndex = 4;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(489, 137);
            this.sbCancelar.TabIndex = 5;
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
            this.tpPrincipal.Controls.Add(this.btnlkpOcorrencia);
            this.tpPrincipal.Controls.Add(this.lkpOcorrencia);
            this.tpPrincipal.Controls.Add(this.lblObservacaoOcorrencia);
            this.tpPrincipal.Controls.Add(this.txtObservacao);
            this.tpPrincipal.Controls.Add(this.txtTempoOcorrencia);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.lblOcorrencia);
            this.tpPrincipal.Size = new System.Drawing.Size(546, 113);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(552, 119);
            // 
            // lblOcorrencia
            // 
            this.lblOcorrencia.Location = new System.Drawing.Point(33, 18);
            this.lblOcorrencia.Name = "lblOcorrencia";
            this.lblOcorrencia.Size = new System.Drawing.Size(56, 13);
            this.lblOcorrencia.TabIndex = 7;
            this.lblOcorrencia.Text = "Ocorrência:";
            // 
            // txtTempoOcorrencia
            // 
            this.txtTempoOcorrencia.CwkFuncaoValidacao = null;
            this.txtTempoOcorrencia.CwkValidacao = null;
            this.txtTempoOcorrencia.EditValue = null;
            this.txtTempoOcorrencia.Location = new System.Drawing.Point(100, 41);
            this.txtTempoOcorrencia.Name = "txtTempoOcorrencia";
            this.txtTempoOcorrencia.Obrigatorio = true;
            this.txtTempoOcorrencia.Properties.DisplayFormat.FormatString = "t";
            this.txtTempoOcorrencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTempoOcorrencia.Properties.EditFormat.FormatString = "t";
            this.txtTempoOcorrencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTempoOcorrencia.Properties.Mask.EditMask = "t";
            this.txtTempoOcorrencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtTempoOcorrencia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTempoOcorrencia.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtTempoOcorrencia.Size = new System.Drawing.Size(57, 20);
            this.txtTempoOcorrencia.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(3, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Tempo Ocorrência:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CwkFuncaoValidacao = null;
            this.txtObservacao.CwkMascara = null;
            this.txtObservacao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtObservacao.Location = new System.Drawing.Point(100, 71);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.MaxLength = 200;
            this.txtObservacao.SelecionarTextoOnEnter = false;
            this.txtObservacao.Size = new System.Drawing.Size(435, 20);
            this.txtObservacao.TabIndex = 3;
            // 
            // lblObservacaoOcorrencia
            // 
            this.lblObservacaoOcorrencia.Location = new System.Drawing.Point(32, 74);
            this.lblObservacaoOcorrencia.Name = "lblObservacaoOcorrencia";
            this.lblObservacaoOcorrencia.Size = new System.Drawing.Size(62, 13);
            this.lblObservacaoOcorrencia.TabIndex = 23;
            this.lblObservacaoOcorrencia.Text = "Observação:";
            // 
            // btnlkpOcorrencia
            // 
            this.btnlkpOcorrencia.Location = new System.Drawing.Point(511, 15);
            this.btnlkpOcorrencia.Lookup = this.lkpOcorrencia;
            this.btnlkpOcorrencia.Name = "btnlkpOcorrencia";
            this.btnlkpOcorrencia.Size = new System.Drawing.Size(24, 20);
            this.btnlkpOcorrencia.SubForm = null;
            this.btnlkpOcorrencia.SubFormType = null;
            this.btnlkpOcorrencia.SubFormTypeParams = null;
            this.btnlkpOcorrencia.TabIndex = 1;
            this.btnlkpOcorrencia.TabStop = false;
            this.btnlkpOcorrencia.Text = "...";
            this.btnlkpOcorrencia.Click += new System.EventHandler(this.btnlkpOcorrencia_Click);
            // 
            // lkpOcorrencia
            // 
            this.lkpOcorrencia.ButtonLookup = this.btnlkpOcorrencia;
            this.lkpOcorrencia.CamposPesquisa = new string[] {
        "ID",
        "Descricao"};
            this.lkpOcorrencia.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOcorrencia.CamposRestricoesAND")));
            this.lkpOcorrencia.CamposRestricoesNOT = null;
            this.lkpOcorrencia.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOcorrencia.CamposRestricoesOR")));
            this.lkpOcorrencia.ColunaDescricao = new string[] {
        "Nome",
        "Sigla",
        null,
        null,
        null};
            this.lkpOcorrencia.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpOcorrencia.ContextoLinq = null;
            this.lkpOcorrencia.CwkFuncaoValidacao = null;
            this.lkpOcorrencia.CwkMascara = null;
            this.lkpOcorrencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpOcorrencia.Exemplo = null;
            this.lkpOcorrencia.ID = 0;
            this.lkpOcorrencia.Join = null;
            this.lkpOcorrencia.Key = System.Windows.Forms.Keys.F5;
            this.lkpOcorrencia.Location = new System.Drawing.Point(100, 15);
            this.lkpOcorrencia.Name = "lkpOcorrencia";
            this.lkpOcorrencia.OnIDChanged = null;
            this.lkpOcorrencia.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpOcorrencia.Properties.Appearance.Options.UseBackColor = true;
            this.lkpOcorrencia.SelecionarTextoOnEnter = true;
            this.lkpOcorrencia.Size = new System.Drawing.Size(405, 20);
            this.lkpOcorrencia.Tabela = "Ofd_Ocorrencias";
            this.lkpOcorrencia.TabIndex = 0;
            this.lkpOcorrencia.TituloTelaPesquisa = null;
            this.lkpOcorrencia.ToolTip = "Campos pesquisados: Código, Descrição";
            this.lkpOcorrencia.Where = null;
            // 
            // FormOfd_AgendamentoMaquinaOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(576, 172);
            this.Name = "FormOfd_AgendamentoMaquinaOcorrencia";
            this.Text = "Tela de Proposta Medição Ocorrências";
            this.Shown += new System.EventHandler(this.FormOfd_AgendamentoMaquinaOcorrencia_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoOcorrencia.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoOcorrencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOcorrencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblOcorrencia;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtTempoOcorrencia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao;
        private DevExpress.XtraEditors.LabelControl lblObservacaoOcorrencia;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpOcorrencia;
        private Cwork.Utilitarios.Componentes.Lookup lkpOcorrencia;
    }
}
