namespace Aplicacao.Modulos.Cadastro
{
    partial class FormStatusOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatusOS));
            DevExpress.XtraEditors.CheckEdit chbBFechado;
            DevExpress.XtraEditors.CheckEdit chbBPermissaoGerente;
            DevExpress.XtraEditors.CheckEdit chbBFaturar;
            DevExpress.XtraEditors.CheckEdit chbBAgendar;
            DevExpress.XtraEditors.CheckEdit chbBPadrao;
            DevExpress.XtraEditors.CheckEdit chbEmailAutomatico;
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailAutomaticoAssunto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAtt = new DevExpress.XtraEditors.LabelControl();
            this.lbAtributos = new DevExpress.XtraEditors.ListBoxControl();
            this.txtEmailAutomaticoTexto = new DevExpress.XtraRichEdit.RichEditControl();
            chbBFechado = new DevExpress.XtraEditors.CheckEdit();
            chbBPermissaoGerente = new DevExpress.XtraEditors.CheckEdit();
            chbBFaturar = new DevExpress.XtraEditors.CheckEdit();
            chbBAgendar = new DevExpress.XtraEditors.CheckEdit();
            chbBPadrao = new DevExpress.XtraEditors.CheckEdit();
            chbEmailAutomatico = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chbBFechado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chbBPermissaoGerente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chbBFaturar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chbBAgendar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chbBPadrao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(chbEmailAutomatico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailAutomaticoAssunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAtributos)).BeginInit();
 //           ((System.ComponentModel.ISupportInitialize)(this.txtEmailAutomaticoTexto.Properties)).BeginInit();
 //           ((System.ComponentModel.ISupportInitialize)(this.txtEmailAutomaticoTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 376);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(656, 376);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(737, 376);
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
            this.tpPrincipal.Controls.Add(this.txtEmailAutomaticoTexto);
            this.tpPrincipal.Controls.Add(this.lbAtt);
            this.tpPrincipal.Controls.Add(this.lbAtributos);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.txtEmailAutomaticoAssunto);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(chbEmailAutomatico);
            this.tpPrincipal.Controls.Add(chbBPadrao);
            this.tpPrincipal.Controls.Add(chbBAgendar);
            this.tpPrincipal.Controls.Add(chbBFaturar);
            this.tpPrincipal.Controls.Add(chbBPermissaoGerente);
            this.tpPrincipal.Controls.Add(chbBFechado);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(794, 352);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(800, 358);
            // 
            // chbBFechado
            // 
            this.dxErroProvider.SetIconAlignment(chbBFechado, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            chbBFechado.Location = new System.Drawing.Point(67, 73);
            chbBFechado.Name = "chbBFechado";
            chbBFechado.Properties.Caption = "Fechado";
            chbBFechado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chbBFechado.Size = new System.Drawing.Size(65, 19);
            chbBFechado.TabIndex = 4;
            // 
            // chbBPermissaoGerente
            // 
            this.dxErroProvider.SetIconAlignment(chbBPermissaoGerente, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            chbBPermissaoGerente.Location = new System.Drawing.Point(274, 74);
            chbBPermissaoGerente.Name = "chbBPermissaoGerente";
            chbBPermissaoGerente.Properties.Caption = "Permissão de Gerente";
            chbBPermissaoGerente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chbBPermissaoGerente.Size = new System.Drawing.Size(132, 19);
            chbBPermissaoGerente.TabIndex = 7;
            // 
            // chbBFaturar
            // 
            this.dxErroProvider.SetIconAlignment(chbBFaturar, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            chbBFaturar.Location = new System.Drawing.Point(138, 74);
            chbBFaturar.Name = "chbBFaturar";
            chbBFaturar.Properties.Caption = "Faturar";
            chbBFaturar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chbBFaturar.Size = new System.Drawing.Size(60, 19);
            chbBFaturar.TabIndex = 5;
            // 
            // chbBAgendar
            // 
            this.dxErroProvider.SetIconAlignment(chbBAgendar, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            chbBAgendar.Location = new System.Drawing.Point(204, 74);
            chbBAgendar.Name = "chbBAgendar";
            chbBAgendar.Properties.Caption = "Agendar";
            chbBAgendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chbBAgendar.Size = new System.Drawing.Size(64, 19);
            chbBAgendar.TabIndex = 6;
            // 
            // chbBPadrao
            // 
            this.dxErroProvider.SetIconAlignment(chbBPadrao, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            chbBPadrao.Location = new System.Drawing.Point(177, 12);
            chbBPadrao.Name = "chbBPadrao";
            chbBPadrao.Properties.Caption = "Padrão";
            chbBPadrao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chbBPadrao.Size = new System.Drawing.Size(64, 19);
            chbBPadrao.TabIndex = 2;
            // 
            // chbEmailAutomatico
            // 
            this.dxErroProvider.SetIconAlignment(chbEmailAutomatico, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            chbEmailAutomatico.Location = new System.Drawing.Point(404, 74);
            chbEmailAutomatico.Name = "chbEmailAutomatico";
            chbEmailAutomatico.Properties.Caption = "E-mail Automático";
            chbEmailAutomatico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            chbEmailAutomatico.Size = new System.Drawing.Size(132, 19);
            chbEmailAutomatico.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(69, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.Mask.EditMask = "[0-9]{15}";
            this.txtDescricao.SelecionarTextoOnEnter = true;
            this.txtDescricao.Size = new System.Drawing.Size(474, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeralInteiro;
            this.txtCodigo.Location = new System.Drawing.Point(69, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmailAutomaticoAssunto
            // 
            this.txtEmailAutomaticoAssunto.CwkFuncaoValidacao = null;
            this.txtEmailAutomaticoAssunto.CwkMascara = null;
            this.txtEmailAutomaticoAssunto.CwkValidacao = null;
            this.txtEmailAutomaticoAssunto.Location = new System.Drawing.Point(140, 99);
            this.txtEmailAutomaticoAssunto.Name = "txtEmailAutomaticoAssunto";
            this.txtEmailAutomaticoAssunto.Properties.Mask.EditMask = "[0-9]{15}";
            this.txtEmailAutomaticoAssunto.SelecionarTextoOnEnter = true;
            this.txtEmailAutomaticoAssunto.Size = new System.Drawing.Size(403, 20);
            this.txtEmailAutomaticoAssunto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Assunto E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Texto E-mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbAtt
            // 
            this.lbAtt.Location = new System.Drawing.Point(549, 36);
            this.lbAtt.Name = "lbAtt";
            this.lbAtt.Size = new System.Drawing.Size(48, 13);
            this.lbAtt.TabIndex = 25;
            this.lbAtt.Text = "Atributos:";
            // 
            // lbAtributos
            // 
            this.lbAtributos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAtributos.Location = new System.Drawing.Point(549, 52);
            this.lbAtributos.Name = "lbAtributos";
            this.lbAtributos.Size = new System.Drawing.Size(229, 293);
            this.lbAtributos.TabIndex = 24;
            this.lbAtributos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAtributos_MouseDown);
            // 
            // txtEmailAutomaticoTexto
            // 
            this.txtEmailAutomaticoTexto.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtEmailAutomaticoTexto.Location = new System.Drawing.Point(140, 126);
            this.txtEmailAutomaticoTexto.Name = "txtEmailAutomaticoTexto";
            this.txtEmailAutomaticoTexto.Options.MailMerge.KeepLastParagraph = false;
            this.txtEmailAutomaticoTexto.Size = new System.Drawing.Size(403, 219);
            this.txtEmailAutomaticoTexto.TabIndex = 26;
            this.txtEmailAutomaticoTexto.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtEmailAutomaticoTexto_DragDrop);
            this.txtEmailAutomaticoTexto.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtEmailAutomaticoTexto_DragEnter);
            this.txtEmailAutomaticoTexto.DragOver += new System.Windows.Forms.DragEventHandler(this.txtEmailAutomaticoTexto_DragOver);
            // 
            // FormStatusOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 411);
            this.Name = "FormStatusOS";
            this.Text = "Cadastro de Status OS";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(chbBFechado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chbBPermissaoGerente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chbBFaturar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chbBAgendar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chbBPadrao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chbEmailAutomatico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailAutomaticoAssunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAtributos)).EndInit();
 //           ((System.ComponentModel.ISupportInitialize)(this.txtEmailAutomaticoTexto.Properties)).EndInit();
 //           ((System.ComponentModel.ISupportInitialize)(this.txtEmailAutomaticoTexto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEmailAutomaticoAssunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LabelControl lbAtt;
        private DevExpress.XtraEditors.ListBoxControl lbAtributos;
        private DevExpress.XtraRichEdit.RichEditControl txtEmailAutomaticoTexto;
    }
}