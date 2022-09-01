namespace Aplicacao
{
    partial class FormTabelaPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaPreco));
            this.chkBAtiva = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtSugestaoMargemLucro = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtSugestaoPDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSugestaoPAcrescimo = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPromocional = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBAtiva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSugestaoMargemLucro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSugestaoPDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSugestaoPAcrescimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPromocional.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 121);
            this.sbAjuda.TabIndex = 21;
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(435, 121);
            this.sbGravar.TabIndex = 19;
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(516, 121);
            this.sbCancelar.TabIndex = 20;
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
            this.tpPrincipal.Controls.Add(this.chkPromocional);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.txtSugestaoPAcrescimo);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.txtSugestaoPDesconto);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.txtSugestaoMargemLucro);
            this.tpPrincipal.Controls.Add(this.chkBAtiva);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Size = new System.Drawing.Size(573, 97);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(579, 103);
            // 
            // chkBAtiva
            // 
            this.chkBAtiva.Location = new System.Drawing.Point(157, 3);
            this.chkBAtiva.Name = "chkBAtiva";
            this.chkBAtiva.Properties.Caption = "Ativa";
            this.chkBAtiva.Size = new System.Drawing.Size(60, 19);
            this.chkBAtiva.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Margem Lucro:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(56, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(504, 20);
            this.txtNome.TabIndex = 15;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = null;
            this.txtCodigo.Location = new System.Drawing.Point(56, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(95, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtSugestaoMargemLucro
            // 
            this.txtSugestaoMargemLucro.Location = new System.Drawing.Point(91, 55);
            this.txtSugestaoMargemLucro.Name = "txtSugestaoMargemLucro";
            this.txtSugestaoMargemLucro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSugestaoMargemLucro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSugestaoMargemLucro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSugestaoMargemLucro.Properties.Mask.EditMask = "P4";
            this.txtSugestaoMargemLucro.Properties.Mask.IgnoreMaskBlank = false;
            this.txtSugestaoMargemLucro.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSugestaoMargemLucro.Properties.Precision = 4;
            this.txtSugestaoMargemLucro.Size = new System.Drawing.Size(100, 20);
            this.txtSugestaoMargemLucro.TabIndex = 16;
            // 
            // txtSugestaoPDesconto
            // 
            this.txtSugestaoPDesconto.Location = new System.Drawing.Point(271, 55);
            this.txtSugestaoPDesconto.Name = "txtSugestaoPDesconto";
            this.txtSugestaoPDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSugestaoPDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSugestaoPDesconto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSugestaoPDesconto.Properties.Mask.EditMask = "P4";
            this.txtSugestaoPDesconto.Properties.Mask.IgnoreMaskBlank = false;
            this.txtSugestaoPDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSugestaoPDesconto.Properties.Precision = 4;
            this.txtSugestaoPDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtSugestaoPDesconto.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Desconto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSugestaoPAcrescimo
            // 
            this.txtSugestaoPAcrescimo.Location = new System.Drawing.Point(442, 55);
            this.txtSugestaoPAcrescimo.Name = "txtSugestaoPAcrescimo";
            this.txtSugestaoPAcrescimo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSugestaoPAcrescimo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSugestaoPAcrescimo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSugestaoPAcrescimo.Properties.Mask.EditMask = "P4";
            this.txtSugestaoPAcrescimo.Properties.Mask.IgnoreMaskBlank = false;
            this.txtSugestaoPAcrescimo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSugestaoPAcrescimo.Properties.Precision = 4;
            this.txtSugestaoPAcrescimo.Size = new System.Drawing.Size(118, 20);
            this.txtSugestaoPAcrescimo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Acrescimo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkPromocional
            // 
            this.chkPromocional.Location = new System.Drawing.Point(271, 4);
            this.chkPromocional.Name = "chkPromocional";
            this.chkPromocional.Properties.Caption = "Promocional";
            this.chkPromocional.Size = new System.Drawing.Size(90, 19);
            this.chkPromocional.TabIndex = 22;
            // 
            // FormTabelaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(603, 156);
            this.Name = "FormTabelaPreco";
            this.Shown += new System.EventHandler(this.FormTabelaPreco_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkBAtiva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSugestaoMargemLucro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSugestaoPDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSugestaoPAcrescimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPromocional.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkBAtiva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtSugestaoPAcrescimo;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtSugestaoPDesconto;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtSugestaoMargemLucro;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.CheckEdit chkPromocional;
    }
}
