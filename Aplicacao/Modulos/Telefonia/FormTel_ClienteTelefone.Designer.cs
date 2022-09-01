namespace Aplicacao.Modulos.Telefonia
{
    partial class FormTel_ClienteTelefone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTel_ClienteTelefone));
            this.btBuscarGrupoClienteTelefone = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataAtivacao = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.chbBAgrupador = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContatoPediuDesligamento = new DevExpress.XtraEditors.TextEdit();
            this.txtMotivoDesligamento = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataDesligamento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.txtBuscaTelefone = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtLEN = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataAtivacao.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataAtivacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBAgrupador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContatoPediuDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataDesligamento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLEN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 164);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(303, 164);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(384, 164);
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
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.txtLEN);
            this.tpPrincipal.Controls.Add(this.txtBuscaTelefone);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.txtContatoPediuDesligamento);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.chbBAgrupador);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.txtMotivoDesligamento);
            this.tpPrincipal.Controls.Add(this.txtDataAtivacao);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label7);
            this.tpPrincipal.Controls.Add(this.dtDataDesligamento);
            this.tpPrincipal.Controls.Add(this.btBuscarGrupoClienteTelefone);
            this.tpPrincipal.Size = new System.Drawing.Size(441, 140);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(447, 146);
            // 
            // btBuscarGrupoClienteTelefone
            // 
            this.btBuscarGrupoClienteTelefone.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btBuscarGrupoClienteTelefone.Location = new System.Drawing.Point(288, 32);
            this.btBuscarGrupoClienteTelefone.Name = "btBuscarGrupoClienteTelefone";
            this.btBuscarGrupoClienteTelefone.Size = new System.Drawing.Size(145, 20);
            this.btBuscarGrupoClienteTelefone.TabIndex = 7;
            this.btBuscarGrupoClienteTelefone.TabStop = false;
            this.btBuscarGrupoClienteTelefone.Text = "Selecionar Telefone";
            this.btBuscarGrupoClienteTelefone.Click += new System.EventHandler(this.btBuscarGrupoClienteTelefone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Telefone:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDataAtivacao
            // 
            this.txtDataAtivacao.CwkFuncaoValidacao = null;
            this.txtDataAtivacao.CwkValidacao = null;
            this.txtDataAtivacao.EditValue = null;
            this.txtDataAtivacao.Location = new System.Drawing.Point(90, 6);
            this.txtDataAtivacao.Name = "txtDataAtivacao";
            this.txtDataAtivacao.Obrigatorio = true;
            this.txtDataAtivacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataAtivacao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataAtivacao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataAtivacao.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataAtivacao.Size = new System.Drawing.Size(100, 20);
            this.txtDataAtivacao.TabIndex = 1;
            this.txtDataAtivacao.Leave += new System.EventHandler(this.txtDataAtivacao_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Ativação:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbBAgrupador
            // 
            this.chbBAgrupador.Location = new System.Drawing.Point(196, 7);
            this.chbBAgrupador.Name = "chbBAgrupador";
            this.chbBAgrupador.Properties.Caption = "Piloto";
            this.chbBAgrupador.Size = new System.Drawing.Size(49, 19);
            this.chbBAgrupador.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contato Canc.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Motivo Canc.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContatoPediuDesligamento
            // 
            this.txtContatoPediuDesligamento.Location = new System.Drawing.Point(90, 110);
            this.txtContatoPediuDesligamento.Name = "txtContatoPediuDesligamento";
            this.txtContatoPediuDesligamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtContatoPediuDesligamento.Properties.Appearance.Options.UseBackColor = true;
            this.txtContatoPediuDesligamento.Properties.ReadOnly = true;
            this.txtContatoPediuDesligamento.Size = new System.Drawing.Size(343, 20);
            this.txtContatoPediuDesligamento.TabIndex = 13;
            this.txtContatoPediuDesligamento.TabStop = false;
            this.txtContatoPediuDesligamento.ToolTip = "Pessoa que pediu desligamento";
            // 
            // txtMotivoDesligamento
            // 
            this.txtMotivoDesligamento.Location = new System.Drawing.Point(90, 84);
            this.txtMotivoDesligamento.Name = "txtMotivoDesligamento";
            this.txtMotivoDesligamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.txtMotivoDesligamento.Properties.Appearance.Options.UseBackColor = true;
            this.txtMotivoDesligamento.Properties.ReadOnly = true;
            this.txtMotivoDesligamento.Size = new System.Drawing.Size(343, 20);
            this.txtMotivoDesligamento.TabIndex = 11;
            this.txtMotivoDesligamento.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Canc.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDataDesligamento
            // 
            this.dtDataDesligamento.CwkFuncaoValidacao = null;
            this.dtDataDesligamento.CwkValidacao = null;
            this.dtDataDesligamento.EditValue = null;
            this.dtDataDesligamento.Location = new System.Drawing.Point(90, 58);
            this.dtDataDesligamento.Name = "dtDataDesligamento";
            this.dtDataDesligamento.Obrigatorio = false;
            this.dtDataDesligamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.dtDataDesligamento.Properties.Appearance.Options.UseBackColor = true;
            this.dtDataDesligamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataDesligamento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtDataDesligamento.Properties.ReadOnly = true;
            this.dtDataDesligamento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtDataDesligamento.Size = new System.Drawing.Size(100, 20);
            this.dtDataDesligamento.TabIndex = 9;
            this.dtDataDesligamento.TabStop = false;
            // 
            // txtBuscaTelefone
            // 
            this.txtBuscaTelefone.CwkFuncaoValidacao = null;
            this.txtBuscaTelefone.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtBuscaTelefone.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtBuscaTelefone.Location = new System.Drawing.Point(90, 32);
            this.txtBuscaTelefone.Name = "txtBuscaTelefone";
            this.txtBuscaTelefone.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBuscaTelefone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtBuscaTelefone.Properties.Mask.EditMask = "[(](([1](([1-9][)]([9]([6-9][0-9]{3}|[0-9]{3})|[0-9]{4}))|[1-9][)][0-9]{4})|[2-9]" +
                "[1-9][)][0-9]{4}))[-][0-9]{4}";
            this.txtBuscaTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBuscaTelefone.Properties.Mask.ShowPlaceHolders = false;
            this.txtBuscaTelefone.Properties.MaxLength = 10;
            this.txtBuscaTelefone.SelecionarTextoOnEnter = true;
            this.txtBuscaTelefone.Size = new System.Drawing.Size(192, 20);
            this.txtBuscaTelefone.TabIndex = 6;
            this.txtBuscaTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtLEN
            // 
            this.txtLEN.CwkFuncaoValidacao = null;
            this.txtLEN.CwkMascara = null;
            this.txtLEN.CwkValidacao = null;
            this.txtLEN.Location = new System.Drawing.Point(288, 6);
            this.txtLEN.Name = "txtLEN";
            this.txtLEN.Properties.MaxLength = 50;
            this.txtLEN.SelecionarTextoOnEnter = false;
            this.txtLEN.Size = new System.Drawing.Size(145, 20);
            this.txtLEN.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "LEN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormTel_ClienteTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 199);
            this.Name = "FormTel_ClienteTelefone";
            this.Text = "Cliente Telefone";
            this.Load += new System.EventHandler(this.FormTel_ClienteTelefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDataAtivacao.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataAtivacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBAgrupador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContatoPediuDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataDesligamento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLEN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btBuscarGrupoClienteTelefone;
        private System.Windows.Forms.Label label7;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataAtivacao;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit chbBAgrupador;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.CwkDateEditor dtDataDesligamento;
        private DevExpress.XtraEditors.TextEdit txtContatoPediuDesligamento;
        private DevExpress.XtraEditors.TextEdit txtMotivoDesligamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBuscaTelefone;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLEN;
        private System.Windows.Forms.Label label5;

    }
}