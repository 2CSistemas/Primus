namespace Aplicacao.Modulos.Comercial
{
    partial class FormEnviaEmail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviaEmail));
            this.ckbXML = new DevExpress.XtraEditors.CheckEdit();
            this.ckbPFD = new DevExpress.XtraEditors.CheckEdit();
            this.ckbBoletos = new DevExpress.XtraEditors.CheckEdit();
            this.lbCorpo = new DevExpress.XtraEditors.LabelControl();
            this.lbAssunto = new DevExpress.XtraEditors.LabelControl();
            this.txtRemetente = new DevExpress.XtraEditors.TextEdit();
            this.lbRemetente = new DevExpress.XtraEditors.LabelControl();
            this.txtCorpo = new DevExpress.XtraRichEdit.RichEditControl();
            this.lbAtributos = new DevExpress.XtraEditors.ListBoxControl();
            this.lbAtt = new DevExpress.XtraEditors.LabelControl();
            this.lbRemessa = new System.Windows.Forms.Label();
            this.lkpRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.sbDetalhes = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.txtAssunto = new DevExpress.XtraEditors.TextEdit();
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979 = new DevExpress.XtraEditors.ListBoxControl();
            this.txtDestinatario = new DevExpress.XtraEditors.TextEdit();
            this.lblDestinatario = new DevExpress.XtraEditors.LabelControl();
            this.pnlProgresso = new DevExpress.XtraEditors.PanelControl();
            this.lstbErros = new DevExpress.XtraEditors.ListBoxControl();
            this.lbNaoEnviados = new DevExpress.XtraEditors.LabelControl();
            this.lbEnviados = new DevExpress.XtraEditors.LabelControl();
            this.lbEnviar = new DevExpress.XtraEditors.LabelControl();
            this.lstbEnviados = new DevExpress.XtraEditors.ListBoxControl();
            this.lstbEnviar = new DevExpress.XtraEditors.ListBoxControl();
            this.pgbStatus = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbXML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbPFD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbBoletos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemetente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_e5db6065_7469_4ffa_9e6e_b487fa474979)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgresso)).BeginInit();
            this.pnlProgresso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbErros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbEnviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 542);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = global::Aplicacao.Properties.Resources._1371664476_14028;
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(527, 542);
            this.sbGravar.Text = "&Enviar";
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(608, 542);
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
            this.tpPrincipal.Controls.Add(this.pnlProgresso);
            this.tpPrincipal.Controls.Add(this.txtDestinatario);
            this.tpPrincipal.Controls.Add(this.lblDestinatario);
            this.tpPrincipal.Controls.Add(this.sbDetalhes);
            this.tpPrincipal.Controls.Add(this.lbStatus);
            this.tpPrincipal.Controls.Add(this.lkpRemessa);
            this.tpPrincipal.Controls.Add(this.lbRemessa);
            this.tpPrincipal.Controls.Add(this.lkbRemessa);
            this.tpPrincipal.Controls.Add(this.lbAtt);
            this.tpPrincipal.Controls.Add(this.lbAtributos);
            this.tpPrincipal.Controls.Add(this.txtCorpo);
            this.tpPrincipal.Controls.Add(this.ckbBoletos);
            this.tpPrincipal.Controls.Add(this.ckbXML);
            this.tpPrincipal.Controls.Add(this.ckbPFD);
            this.tpPrincipal.Controls.Add(this.lbCorpo);
            this.tpPrincipal.Controls.Add(this.txtAssunto);
            this.tpPrincipal.Controls.Add(this.lbAssunto);
            this.tpPrincipal.Controls.Add(this.txtRemetente);
            this.tpPrincipal.Controls.Add(this.lbRemetente);
            this.tpPrincipal.Size = new System.Drawing.Size(665, 518);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(671, 524);
            // 
            // ckbXML
            // 
            this.ckbXML.EditValue = true;
            this.ckbXML.Location = new System.Drawing.Point(152, 21);
            this.ckbXML.Name = "ckbXML";
            this.ckbXML.Properties.Caption = "XML Notas";
            this.ckbXML.Size = new System.Drawing.Size(75, 19);
            this.ckbXML.TabIndex = 1;
            // 
            // ckbPFD
            // 
            this.ckbPFD.EditValue = true;
            this.ckbPFD.Location = new System.Drawing.Point(71, 21);
            this.ckbPFD.Name = "ckbPFD";
            this.ckbPFD.Properties.Caption = "PDF Notas";
            this.ckbPFD.Size = new System.Drawing.Size(75, 19);
            this.ckbPFD.TabIndex = 0;
            // 
            // ckbBoletos
            // 
            this.ckbBoletos.EditValue = true;
            this.ckbBoletos.Location = new System.Drawing.Point(233, 21);
            this.ckbBoletos.Name = "ckbBoletos";
            this.ckbBoletos.Properties.Caption = "Boletos";
            this.ckbBoletos.Size = new System.Drawing.Size(75, 19);
            this.ckbBoletos.TabIndex = 0;
            this.ckbBoletos.CheckedChanged += new System.EventHandler(this.ckbBoletos_CheckedChanged);
            // 
            // lbCorpo
            // 
            this.lbCorpo.Location = new System.Drawing.Point(35, 136);
            this.lbCorpo.Name = "lbCorpo";
            this.lbCorpo.Size = new System.Drawing.Size(33, 13);
            this.lbCorpo.TabIndex = 15;
            this.lbCorpo.Text = "Corpo:";
            // 
            // lbAssunto
            // 
            this.lbAssunto.Location = new System.Drawing.Point(25, 101);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(43, 13);
            this.lbAssunto.TabIndex = 13;
            this.lbAssunto.Text = "Assunto:";
            // 
            // txtRemetente
            // 
            this.txtRemetente.Location = new System.Drawing.Point(74, 46);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(564, 20);
            this.txtRemetente.TabIndex = 12;
            // 
            // lbRemetente
            // 
            this.lbRemetente.Location = new System.Drawing.Point(12, 49);
            this.lbRemetente.Name = "lbRemetente";
            this.lbRemetente.Size = new System.Drawing.Size(57, 13);
            this.lbRemetente.TabIndex = 11;
            this.lbRemetente.Text = "Remetente:";
            // 
            // txtCorpo
            // 
            this.txtCorpo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtCorpo.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtCorpo.Location = new System.Drawing.Point(74, 136);
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(438, 322);
            this.txtCorpo.TabIndex = 19;
            this.txtCorpo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCorpo_DragDrop);
            this.txtCorpo.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtCorpo_DragEnter);
            this.txtCorpo.DragOver += new System.Windows.Forms.DragEventHandler(this.txtCorpo_DragOver);
            // 
            // lbAtributos
            // 
            this.lbAtributos.Location = new System.Drawing.Point(518, 156);
            this.lbAtributos.Name = "lbAtributos";
            this.lbAtributos.Size = new System.Drawing.Size(120, 302);
            this.lbAtributos.TabIndex = 20;
            this.lbAtributos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAtributos_MouseDown);
            // 
            // lbAtt
            // 
            this.lbAtt.Location = new System.Drawing.Point(518, 136);
            this.lbAtt.Name = "lbAtt";
            this.lbAtt.Size = new System.Drawing.Size(48, 13);
            this.lbAtt.TabIndex = 21;
            this.lbAtt.Text = "Atributos:";
            // 
            // lbRemessa
            // 
            this.lbRemessa.AutoSize = true;
            this.lbRemessa.Location = new System.Drawing.Point(314, 24);
            this.lbRemessa.Name = "lbRemessa";
            this.lbRemessa.Size = new System.Drawing.Size(54, 13);
            this.lbRemessa.TabIndex = 48;
            this.lbRemessa.Text = "Remessa:";
            // 
            // lkpRemessa
            // 
            this.lkpRemessa.ButtonLookup = this.lkbRemessa;
            this.lkpRemessa.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpRemessa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRemessa.CamposRestricoesAND")));
            this.lkpRemessa.CamposRestricoesNOT = null;
            this.lkpRemessa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRemessa.CamposRestricoesOR")));
            this.lkpRemessa.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkpRemessa.ColunaTamanho = new string[] {
        "100",
        "250"};
            this.lkpRemessa.ContextoLinq = null;
            this.lkpRemessa.CwkFuncaoValidacao = null;
            this.lkpRemessa.CwkMascara = null;
            this.lkpRemessa.CwkValidacao = null;
            this.lkpRemessa.Exemplo = null;
            this.lkpRemessa.ID = 0;
            this.lkpRemessa.Join = null;
            this.lkpRemessa.Key = System.Windows.Forms.Keys.F5;
            this.lkpRemessa.Location = new System.Drawing.Point(367, 21);
            this.lkpRemessa.Name = "lkpRemessa";
            this.lkpRemessa.OnIDChanged = null;
            this.lkpRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpRemessa.SelecionarTextoOnEnter = false;
            this.lkpRemessa.Size = new System.Drawing.Size(239, 20);
            this.lkpRemessa.Tabela = null;
            this.lkpRemessa.TabIndex = 47;
            this.lkpRemessa.TituloTelaPesquisa = null;
            this.lkpRemessa.ToolTip = "Campos pesquisados: Descricao, Codigo.";
            this.lkpRemessa.Where = null;
            // 
            // lkbRemessa
            // 
            this.lkbRemessa.Location = new System.Drawing.Point(614, 20);
            this.lkbRemessa.Lookup = null;
            this.lkbRemessa.Name = "lkbRemessa";
            this.lkbRemessa.Size = new System.Drawing.Size(24, 20);
            this.lkbRemessa.SubForm = null;
            this.lkbRemessa.SubFormType = null;
            this.lkbRemessa.SubFormTypeParams = null;
            this.lkbRemessa.TabIndex = 46;
            this.lkbRemessa.TabStop = false;
            this.lkbRemessa.Text = "...";
            this.lkbRemessa.Click += new System.EventHandler(this.btnRemessa_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbStatus.Appearance.Options.UseFont = true;
            this.lbStatus.Location = new System.Drawing.Point(102, 481);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(54, 13);
            this.lbStatus.TabIndex = 50;
            this.lbStatus.Text = "Enviando:";
            // 
            // sbDetalhes
            // 
            this.sbDetalhes.ImageOptions.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.sbDetalhes.Location = new System.Drawing.Point(21, 476);
            this.sbDetalhes.Name = "sbDetalhes";
            this.sbDetalhes.Size = new System.Drawing.Size(75, 23);
            this.sbDetalhes.TabIndex = 51;
            this.sbDetalhes.Text = "Detalhes";
            this.sbDetalhes.Click += new System.EventHandler(this.sbDetalhes_Click);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(74, 98);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(564, 20);
            this.txtAssunto.TabIndex = 14;
            // 
            // object_e5db6065_7469_4ffa_9e6e_b487fa474979
            // 
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.Appearance.ForeColor = System.Drawing.Color.Red;
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.Appearance.Options.UseFont = true;
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.Appearance.Options.UseForeColor = true;
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.HorizontalScrollbar = true;
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.Location = new System.Drawing.Point(311, 178);
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.Name = "object_e5db6065_7469_4ffa_9e6e_b487fa474979";
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.Size = new System.Drawing.Size(328, 260);
            this.object_e5db6065_7469_4ffa_9e6e_b487fa474979.TabIndex = 23;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(74, 72);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(564, 20);
            this.txtDestinatario.TabIndex = 24;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.Location = new System.Drawing.Point(6, 75);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(62, 13);
            this.lblDestinatario.TabIndex = 23;
            this.lblDestinatario.Text = "Destinatário:";
            // 
            // pnlProgresso
            // 
            this.pnlProgresso.Controls.Add(this.lstbErros);
            this.pnlProgresso.Controls.Add(this.lbNaoEnviados);
            this.pnlProgresso.Controls.Add(this.lbEnviados);
            this.pnlProgresso.Controls.Add(this.lbEnviar);
            this.pnlProgresso.Controls.Add(this.lstbEnviados);
            this.pnlProgresso.Controls.Add(this.lstbEnviar);
            this.pnlProgresso.Controls.Add(this.pgbStatus);
            this.pnlProgresso.Location = new System.Drawing.Point(3, 0);
            this.pnlProgresso.Name = "pnlProgresso";
            this.pnlProgresso.Size = new System.Drawing.Size(659, 512);
            this.pnlProgresso.TabIndex = 53;
            this.pnlProgresso.Visible = false;
            // 
            // lstbErros
            // 
            this.lstbErros.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstbErros.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lstbErros.Appearance.Options.UseFont = true;
            this.lstbErros.Appearance.Options.UseForeColor = true;
            this.lstbErros.HorizontalScrollbar = true;
            this.lstbErros.Location = new System.Drawing.Point(311, 178);
            this.lstbErros.Name = "lstbErros";
            this.lstbErros.Size = new System.Drawing.Size(328, 260);
            this.lstbErros.TabIndex = 27;
            // 
            // lbNaoEnviados
            // 
            this.lbNaoEnviados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbNaoEnviados.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbNaoEnviados.Appearance.Options.UseFont = true;
            this.lbNaoEnviados.Appearance.Options.UseForeColor = true;
            this.lbNaoEnviados.Location = new System.Drawing.Point(311, 159);
            this.lbNaoEnviados.Name = "lbNaoEnviados";
            this.lbNaoEnviados.Size = new System.Drawing.Size(74, 13);
            this.lbNaoEnviados.TabIndex = 26;
            this.lbNaoEnviados.Text = "Não Enviados";
            // 
            // lbEnviados
            // 
            this.lbEnviados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbEnviados.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lbEnviados.Appearance.Options.UseFont = true;
            this.lbEnviados.Appearance.Options.UseForeColor = true;
            this.lbEnviados.Location = new System.Drawing.Point(18, 159);
            this.lbEnviados.Name = "lbEnviados";
            this.lbEnviados.Size = new System.Drawing.Size(50, 13);
            this.lbEnviados.TabIndex = 25;
            this.lbEnviados.Text = "Enviados";
            // 
            // lbEnviar
            // 
            this.lbEnviar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbEnviar.Appearance.Options.UseFont = true;
            this.lbEnviar.Location = new System.Drawing.Point(18, 5);
            this.lbEnviar.Name = "lbEnviar";
            this.lbEnviar.Size = new System.Drawing.Size(35, 13);
            this.lbEnviar.TabIndex = 24;
            this.lbEnviar.Text = "Enviar";
            // 
            // lstbEnviados
            // 
            this.lstbEnviados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstbEnviados.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lstbEnviados.Appearance.Options.UseFont = true;
            this.lstbEnviados.Appearance.Options.UseForeColor = true;
            this.lstbEnviados.HorizontalScrollbar = true;
            this.lstbEnviados.Location = new System.Drawing.Point(18, 178);
            this.lstbEnviados.Name = "lstbEnviados";
            this.lstbEnviados.Size = new System.Drawing.Size(267, 260);
            this.lstbEnviados.TabIndex = 22;
            // 
            // lstbEnviar
            // 
            this.lstbEnviar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lstbEnviar.Appearance.Options.UseFont = true;
            this.lstbEnviar.HorizontalScrollbar = true;
            this.lstbEnviar.Location = new System.Drawing.Point(18, 23);
            this.lstbEnviar.Name = "lstbEnviar";
            this.lstbEnviar.Size = new System.Drawing.Size(621, 130);
            this.lstbEnviar.TabIndex = 21;
            // 
            // pgbStatus
            // 
            this.pgbStatus.Location = new System.Drawing.Point(18, 444);
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(621, 18);
            this.pgbStatus.TabIndex = 19;
            // 
            // FormEnviaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 577);
            this.Name = "FormEnviaEmail";
            this.Text = "Enviar Email";
            this.Shown += new System.EventHandler(this.FormEnviaEmail_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckbXML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbPFD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbBoletos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemetente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_e5db6065_7469_4ffa_9e6e_b487fa474979)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgresso)).EndInit();
            this.pnlProgresso.ResumeLayout(false);
            this.pnlProgresso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbErros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbEnviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit ckbXML;
        private DevExpress.XtraEditors.CheckEdit ckbPFD;
        private DevExpress.XtraEditors.CheckEdit ckbBoletos;
        private DevExpress.XtraEditors.LabelControl lbCorpo;
        private DevExpress.XtraEditors.LabelControl lbAssunto;
        private DevExpress.XtraEditors.TextEdit txtRemetente;
        private DevExpress.XtraEditors.LabelControl lbRemetente;
        private DevExpress.XtraRichEdit.RichEditControl txtCorpo;
        private DevExpress.XtraEditors.ListBoxControl lbAtributos;
        private DevExpress.XtraEditors.LabelControl lbAtt;
        private Cwork.Utilitarios.Componentes.Lookup lkpRemessa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbRemessa;
        private System.Windows.Forms.Label lbRemessa;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.SimpleButton sbDetalhes;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.TextEdit txtAssunto;
        private DevExpress.XtraEditors.ListBoxControl object_e5db6065_7469_4ffa_9e6e_b487fa474979;
        private DevExpress.XtraEditors.PanelControl pnlProgresso;
        private DevExpress.XtraEditors.LabelControl lbNaoEnviados;
        private DevExpress.XtraEditors.LabelControl lbEnviados;
        private DevExpress.XtraEditors.LabelControl lbEnviar;
        private DevExpress.XtraEditors.ListBoxControl lstbEnviados;
        private DevExpress.XtraEditors.ListBoxControl lstbEnviar;
        private DevExpress.XtraEditors.ProgressBarControl pgbStatus;
        private DevExpress.XtraEditors.TextEdit txtDestinatario;
        private DevExpress.XtraEditors.LabelControl lblDestinatario;
        private DevExpress.XtraEditors.ListBoxControl lstbErros;
    }
}