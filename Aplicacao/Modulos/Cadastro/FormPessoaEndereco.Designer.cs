namespace Aplicacao
{
    partial class FormPessoaEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoaEndereco));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBairro = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.txtComplemento = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.chbBPrincipal = new DevExpress.XtraEditors.CheckEdit();
            this.chbBEntrega = new DevExpress.XtraEditors.CheckEdit();
            this.chbBCobranca = new DevExpress.XtraEditors.CheckEdit();
            this.chbBAtivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtContato = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtTelefone = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtNumero = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtEndereco = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lkbCidade = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCidade = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtCEP = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label22 = new System.Windows.Forms.Label();
            this.chbRemetenteDestinatario = new DevExpress.XtraEditors.CheckEdit();
            this.btnConsultarCep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBCobranca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBAtivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRemetenteDestinatario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 195);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(520, 195);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(601, 195);
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
            this.tpPrincipal.Controls.Add(this.btnConsultarCep);
            this.tpPrincipal.Controls.Add(this.chbRemetenteDestinatario);
            this.tpPrincipal.Controls.Add(this.txtCEP);
            this.tpPrincipal.Controls.Add(this.label22);
            this.tpPrincipal.Controls.Add(this.lkpCidade);
            this.tpPrincipal.Controls.Add(this.lkbCidade);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.txtBairro);
            this.tpPrincipal.Controls.Add(this.label21);
            this.tpPrincipal.Controls.Add(this.txtComplemento);
            this.tpPrincipal.Controls.Add(this.chbBPrincipal);
            this.tpPrincipal.Controls.Add(this.chbBEntrega);
            this.tpPrincipal.Controls.Add(this.chbBCobranca);
            this.tpPrincipal.Controls.Add(this.chbBAtivo);
            this.tpPrincipal.Controls.Add(this.txtContato);
            this.tpPrincipal.Controls.Add(this.txtTelefone);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.txtNumero);
            this.tpPrincipal.Controls.Add(this.txtEndereco);
            this.tpPrincipal.Controls.Add(this.label20);
            this.tpPrincipal.Controls.Add(this.label13);
            this.tpPrincipal.Controls.Add(this.label24);
            this.tpPrincipal.Controls.Add(this.label23);
            this.tpPrincipal.Controls.Add(this.label25);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(658, 171);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(664, 177);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Complemento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBairro
            // 
            this.txtBairro.CwkFuncaoValidacao = null;
            this.txtBairro.CwkMascara = null;
            this.txtBairro.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtBairro.Location = new System.Drawing.Point(337, 63);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.SelecionarTextoOnEnter = false;
            this.txtBairro.Size = new System.Drawing.Size(309, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(294, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Bairro:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CwkFuncaoValidacao = null;
            this.txtComplemento.CwkMascara = null;
            this.txtComplemento.CwkValidacao = null;
            this.txtComplemento.Location = new System.Drawing.Point(83, 63);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Properties.MaxLength = 200;
            this.txtComplemento.SelecionarTextoOnEnter = false;
            this.txtComplemento.Size = new System.Drawing.Size(205, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // chbBPrincipal
            // 
            this.chbBPrincipal.Location = new System.Drawing.Point(583, 11);
            this.chbBPrincipal.Name = "chbBPrincipal";
            this.chbBPrincipal.Properties.Caption = "Principal";
            this.chbBPrincipal.Size = new System.Drawing.Size(63, 19);
            this.chbBPrincipal.TabIndex = 23;
            this.chbBPrincipal.Visible = false;
            // 
            // chbBEntrega
            // 
            this.chbBEntrega.Location = new System.Drawing.Point(367, 11);
            this.chbBEntrega.Name = "chbBEntrega";
            this.chbBEntrega.Properties.Caption = "Entrega";
            this.chbBEntrega.Size = new System.Drawing.Size(61, 19);
            this.chbBEntrega.TabIndex = 21;
            // 
            // chbBCobranca
            // 
            this.chbBCobranca.Location = new System.Drawing.Point(292, 11);
            this.chbBCobranca.Name = "chbBCobranca";
            this.chbBCobranca.Properties.Caption = "Cobrança";
            this.chbBCobranca.Size = new System.Drawing.Size(69, 19);
            this.chbBCobranca.TabIndex = 20;
            // 
            // chbBAtivo
            // 
            this.chbBAtivo.Location = new System.Drawing.Point(239, 11);
            this.chbBAtivo.Name = "chbBAtivo";
            this.chbBAtivo.Properties.Caption = "Ativo";
            this.chbBAtivo.Size = new System.Drawing.Size(47, 19);
            this.chbBAtivo.TabIndex = 19;
            // 
            // txtContato
            // 
            this.txtContato.CwkFuncaoValidacao = null;
            this.txtContato.CwkMascara = null;
            this.txtContato.CwkValidacao = null;
            this.txtContato.Location = new System.Drawing.Point(243, 141);
            this.txtContato.Name = "txtContato";
            this.txtContato.SelecionarTextoOnEnter = false;
            this.txtContato.Size = new System.Drawing.Size(403, 20);
            this.txtContato.TabIndex = 18;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CwkFuncaoValidacao = null;
            this.txtTelefone.CwkMascara = null;
            this.txtTelefone.CwkValidacao = null;
            this.txtTelefone.Location = new System.Drawing.Point(83, 141);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Mask.EditMask = "[(][0-9]{2}[)][0-9]{4}-[0-9]{4,5}";
            this.txtTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTelefone.SelecionarTextoOnEnter = false;
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = null;
            this.txtDescricao.Location = new System.Drawing.Point(83, 115);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(563, 20);
            this.txtDescricao.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.CwkFuncaoValidacao = null;
            this.txtNumero.CwkMascara = null;
            this.txtNumero.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNumero.EditValue = "";
            this.txtNumero.Location = new System.Drawing.Point(581, 37);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.MaxLength = 6;
            this.txtNumero.SelecionarTextoOnEnter = false;
            this.txtNumero.Size = new System.Drawing.Size(65, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CwkFuncaoValidacao = null;
            this.txtEndereco.CwkMascara = null;
            this.txtEndereco.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtEndereco.Location = new System.Drawing.Point(83, 37);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.SelecionarTextoOnEnter = false;
            this.txtEndereco.Size = new System.Drawing.Size(463, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Endereço:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(552, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nº:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(190, 144);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Contato:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Cidade:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 144);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Telefone:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descrição:";
            // 
            // lkbCidade
            // 
            this.lkbCidade.Location = new System.Drawing.Point(622, 89);
            this.lkbCidade.Lookup = null;
            this.lkbCidade.Name = "lkbCidade";
            this.lkbCidade.Size = new System.Drawing.Size(24, 20);
            this.lkbCidade.SubForm = null;
            this.lkbCidade.SubFormType = null;
            this.lkbCidade.SubFormTypeParams = null;
            this.lkbCidade.TabIndex = 10;
            this.lkbCidade.TabStop = false;
            this.lkbCidade.Text = "...";
            // 
            // lkpCidade
            // 
            this.lkpCidade.ButtonLookup = this.lkbCidade;
            this.lkpCidade.CamposPesquisa = new string[] {
        "Nome",
        "UF.Sigla",
        "IBGE"};
            this.lkpCidade.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCidade.CamposRestricoesAND")));
            this.lkpCidade.CamposRestricoesNOT = null;
            this.lkpCidade.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCidade.CamposRestricoesOR")));
            this.lkpCidade.ColunaDescricao = new string[] {
        "Cidade",
        "UF",
        "IBGE"};
            this.lkpCidade.ColunaTamanho = new string[] {
        "100",
        "100",
        "100"};
            this.lkpCidade.ContextoLinq = null;
            this.lkpCidade.CwkFuncaoValidacao = null;
            this.lkpCidade.CwkMascara = null;
            this.lkpCidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCidade.Exemplo = null;
            this.lkpCidade.ID = 0;
            this.lkpCidade.Join = null;
            this.lkpCidade.Key = System.Windows.Forms.Keys.F5;
            this.lkpCidade.Location = new System.Drawing.Point(83, 89);
            this.lkpCidade.Name = "lkpCidade";
            this.lkpCidade.OnIDChanged = null;
            this.lkpCidade.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCidade.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCidade.SelecionarTextoOnEnter = false;
            this.lkpCidade.Size = new System.Drawing.Size(533, 20);
            this.lkpCidade.Tabela = null;
            this.lkpCidade.TabIndex = 9;
            this.lkpCidade.TituloTelaPesquisa = null;
            this.lkpCidade.ToolTip = "Campos pesquisados: Nome, UF, Pais.";
            this.lkpCidade.Where = null;
            // 
            // txtCEP
            // 
            this.txtCEP.CwkFuncaoValidacao = null;
            this.txtCEP.CwkMascara = null;
            this.txtCEP.CwkValidacao = null;
            this.txtCEP.Location = new System.Drawing.Point(83, 11);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d-\\d\\d\\d";
            this.txtCEP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCEP.SelecionarTextoOnEnter = false;
            this.txtCEP.Size = new System.Drawing.Size(60, 20);
            this.txtCEP.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(46, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "CEP:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbRemetenteDestinatario
            // 
            this.chbRemetenteDestinatario.Location = new System.Drawing.Point(434, 11);
            this.chbRemetenteDestinatario.Name = "chbRemetenteDestinatario";
            this.chbRemetenteDestinatario.Properties.Caption = "Remetente/Destinatário";
            this.chbRemetenteDestinatario.Size = new System.Drawing.Size(143, 19);
            this.chbRemetenteDestinatario.TabIndex = 22;
            // 
            // btnConsultarCep
            // 
            this.btnConsultarCep.Location = new System.Drawing.Point(149, 9);
            this.btnConsultarCep.Name = "btnConsultarCep";
            this.btnConsultarCep.Size = new System.Drawing.Size(84, 23);
            this.btnConsultarCep.TabIndex = 86;
            this.btnConsultarCep.Text = "Consultar CEP";
            this.btnConsultarCep.UseVisualStyleBackColor = true;
            this.btnConsultarCep.Click += new System.EventHandler(this.btnConsultarCep_Click);
            // 
            // FormPessoaEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(688, 230);
            this.Name = "FormPessoaEndereco";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBCobranca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBAtivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRemetenteDestinatario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtBairro;
        private System.Windows.Forms.Label label21;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtComplemento;
        private DevExpress.XtraEditors.CheckEdit chbBPrincipal;
        private DevExpress.XtraEditors.CheckEdit chbBEntrega;
        private DevExpress.XtraEditors.CheckEdit chbBCobranca;
        private DevExpress.XtraEditors.CheckEdit chbBAtivo;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtContato;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTelefone;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtDescricao;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNumero;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtEndereco;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCidade;
        private Cwork.Utilitarios.Componentes.Lookup lkpCidade;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtCEP;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.CheckEdit chbRemetenteDestinatario;
        private System.Windows.Forms.Button btnConsultarCep;
    }
}
