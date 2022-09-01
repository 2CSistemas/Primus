namespace Aplicacao
{
    public partial class FormServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServico));
            this.tcItems = new DevExpress.XtraTab.XtraTabControl();
            this.tabServico = new DevExpress.XtraTab.XtraTabPage();
            this.btnlkpPlanoConta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPlanoDeContas = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelPlanoContas = new DevExpress.XtraEditors.LabelControl();
            this.cbIncentivoFiscal = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoObra = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtArt = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbExigibilidadeISS = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoTributacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoItemListaServico = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.btConsultarImposto = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcServicoImpostos = new DevExpress.XtraGrid.GridControl();
            this.gvServicoImpostos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btExcluirImposto = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirImposto = new Cwork.Utilitarios.Componentes.DevButton();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabExtra = new DevExpress.XtraTab.XtraTabPage();
            this.btConsultarMaterial = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirMaterial = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirMaterial = new Cwork.Utilitarios.Componentes.DevButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gcMateriais = new DevExpress.XtraGrid.GridControl();
            this.gvMateriais = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtInformacoesAdicionais = new System.Windows.Forms.RichTextBox();
            this.tabImagem = new DevExpress.XtraTab.XtraTabPage();
            this.sbExcluirImagem = new DevExpress.XtraEditors.SimpleButton();
            this.sbDiretorio = new DevExpress.XtraEditors.SimpleButton();
            this.pbCaminhoImagem = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcItems)).BeginInit();
            this.tcItems.SuspendLayout();
            this.tabServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoDeContas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIncentivoFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoObra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExigibilidadeISS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoTributacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoItemListaServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicoImpostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicoImpostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.tabExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMateriais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriais)).BeginInit();
            this.tabImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 437);
            this.sbAjuda.TabIndex = 2;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(418, 437);
            this.sbGravar.TabIndex = 15;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(499, 437);
            this.sbCancelar.TabIndex = 16;
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
            this.tpPrincipal.Controls.Add(this.tcItems);
            this.tpPrincipal.Size = new System.Drawing.Size(556, 413);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(562, 419);
            // 
            // tcItems
            // 
            this.tcItems.Location = new System.Drawing.Point(3, 3);
            this.tcItems.Name = "tcItems";
            this.tcItems.SelectedTabPage = this.tabServico;
            this.tcItems.Size = new System.Drawing.Size(550, 408);
            this.tcItems.TabIndex = 92;
            this.tcItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabServico,
            this.tabExtra,
            this.tabImagem});
            this.tcItems.TabStop = false;
            // 
            // tabServico
            // 
            this.tabServico.Controls.Add(this.btnlkpPlanoConta);
            this.tabServico.Controls.Add(this.lkpPlanoDeContas);
            this.tabServico.Controls.Add(this.labelPlanoContas);
            this.tabServico.Controls.Add(this.cbIncentivoFiscal);
            this.tabServico.Controls.Add(this.labelControl5);
            this.tabServico.Controls.Add(this.txtCodigoObra);
            this.tabServico.Controls.Add(this.txtArt);
            this.tabServico.Controls.Add(this.labelControl4);
            this.tabServico.Controls.Add(this.labelControl2);
            this.tabServico.Controls.Add(this.cbExigibilidadeISS);
            this.tabServico.Controls.Add(this.labelControl1);
            this.tabServico.Controls.Add(this.txtDescricao);
            this.tabServico.Controls.Add(this.label4);
            this.tabServico.Controls.Add(this.cbTipoTributacao);
            this.tabServico.Controls.Add(this.labelControl9);
            this.tabServico.Controls.Add(this.txtCodigoItemListaServico);
            this.tabServico.Controls.Add(this.label3);
            this.tabServico.Controls.Add(this.btConsultarImposto);
            this.tabServico.Controls.Add(this.btExcluirImposto);
            this.tabServico.Controls.Add(this.btIncluirImposto);
            this.tabServico.Controls.Add(this.gcServicoImpostos);
            this.tabServico.Controls.Add(this.txtValor);
            this.tabServico.Controls.Add(this.labelControl3);
            this.tabServico.Controls.Add(this.txtNome);
            this.tabServico.Controls.Add(this.txtCodigo);
            this.tabServico.Controls.Add(this.label2);
            this.tabServico.Controls.Add(this.label1);
            this.tabServico.Name = "tabServico";
            this.tabServico.Size = new System.Drawing.Size(544, 382);
            this.tabServico.Text = "Serviço";
            // 
            // btnlkpPlanoConta
            // 
            this.btnlkpPlanoConta.Location = new System.Drawing.Point(517, 171);
            this.btnlkpPlanoConta.Lookup = null;
            this.btnlkpPlanoConta.Name = "btnlkpPlanoConta";
            this.btnlkpPlanoConta.Size = new System.Drawing.Size(24, 20);
            this.btnlkpPlanoConta.SubForm = null;
            this.btnlkpPlanoConta.TabIndex = 118;
            this.btnlkpPlanoConta.TabStop = false;
            this.btnlkpPlanoConta.Text = "...";
            // 
            // lkpPlanoDeContas
            // 
            this.lkpPlanoDeContas.ButtonLookup = this.btnlkpPlanoConta;
            this.lkpPlanoDeContas.CamposPesquisa = new string[] {
        "Nome",
        "Classificacao",
        "Codigo"};
            this.lkpPlanoDeContas.CamposRestricoesAND = null;
            this.lkpPlanoDeContas.CamposRestricoesNOT = null;
            this.lkpPlanoDeContas.CamposRestricoesOR = null;
            this.lkpPlanoDeContas.ColunaDescricao = new string[] {
        "Nome",
        "Classificação",
        "Código"};
            this.lkpPlanoDeContas.ColunaTamanho = new string[] {
        "100",
        "70",
        "50"};
            this.lkpPlanoDeContas.ContextoLinq = null;
            this.lkpPlanoDeContas.CwkFuncaoValidacao = null;
            this.lkpPlanoDeContas.CwkMascara = null;
            this.lkpPlanoDeContas.CwkValidacao = null;
            this.lkpPlanoDeContas.Exemplo = null;
            this.lkpPlanoDeContas.ID = 0;
            this.lkpPlanoDeContas.Join = null;
            this.lkpPlanoDeContas.Key = System.Windows.Forms.Keys.F5;
            this.lkpPlanoDeContas.Location = new System.Drawing.Point(332, 171);
            this.lkpPlanoDeContas.Name = "lkpPlanoDeContas";
            this.lkpPlanoDeContas.OnIDChanged = null;
            this.lkpPlanoDeContas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPlanoDeContas.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPlanoDeContas.SelecionarTextoOnEnter = true;
            this.lkpPlanoDeContas.Size = new System.Drawing.Size(179, 20);
            this.lkpPlanoDeContas.Tabela = null;
            this.lkpPlanoDeContas.TabIndex = 104;
            this.lkpPlanoDeContas.TituloTelaPesquisa = null;
            this.lkpPlanoDeContas.ToolTip = "Campos pesquisados: Nome, Classificacao, Codigo.";
            this.lkpPlanoDeContas.Where = null;
            // 
            // labelPlanoContas
            // 
            this.labelPlanoContas.Location = new System.Drawing.Point(244, 174);
            this.labelPlanoContas.Name = "labelPlanoContas";
            this.labelPlanoContas.Size = new System.Drawing.Size(82, 13);
            this.labelPlanoContas.TabIndex = 117;
            this.labelPlanoContas.Text = "Plano de Contas:";
            // 
            // cbIncentivoFiscal
            // 
            this.cbIncentivoFiscal.EditValue = "1 | Sim";
            this.cbIncentivoFiscal.Location = new System.Drawing.Point(122, 171);
            this.cbIncentivoFiscal.Name = "cbIncentivoFiscal";
            this.cbIncentivoFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIncentivoFiscal.Properties.Items.AddRange(new object[] {
            "1 | Sim",
            "2 | Não"});
            this.cbIncentivoFiscal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbIncentivoFiscal.Size = new System.Drawing.Size(116, 20);
            this.cbIncentivoFiscal.TabIndex = 103;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(39, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 116;
            this.labelControl5.Text = "Incentivo Fiscal:";
            // 
            // txtCodigoObra
            // 
            this.txtCodigoObra.CwkFuncaoValidacao = null;
            this.txtCodigoObra.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtCodigoObra.CwkValidacao = null;
            this.txtCodigoObra.Location = new System.Drawing.Point(332, 145);
            this.txtCodigoObra.Name = "txtCodigoObra";
            this.txtCodigoObra.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoObra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigoObra.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtCodigoObra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigoObra.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigoObra.Properties.MaxLength = 10;
            this.txtCodigoObra.SelecionarTextoOnEnter = false;
            this.txtCodigoObra.Size = new System.Drawing.Size(207, 20);
            this.txtCodigoObra.TabIndex = 102;
            // 
            // txtArt
            // 
            this.txtArt.CwkFuncaoValidacao = null;
            this.txtArt.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtArt.CwkValidacao = null;
            this.txtArt.Location = new System.Drawing.Point(122, 145);
            this.txtArt.Name = "txtArt";
            this.txtArt.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtArt.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtArt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtArt.Properties.Mask.ShowPlaceHolders = false;
            this.txtArt.Properties.MaxLength = 10;
            this.txtArt.SelecionarTextoOnEnter = false;
            this.txtArt.Size = new System.Drawing.Size(116, 20);
            this.txtArt.TabIndex = 101;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(97, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 13);
            this.labelControl4.TabIndex = 115;
            this.labelControl4.Text = "Art:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(244, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 114;
            this.labelControl2.Text = "Cod. da Obra:";
            // 
            // cbExigibilidadeISS
            // 
            this.cbExigibilidadeISS.EditValue = "1 | Exigível";
            this.cbExigibilidadeISS.Location = new System.Drawing.Point(123, 119);
            this.cbExigibilidadeISS.Name = "cbExigibilidadeISS";
            this.cbExigibilidadeISS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbExigibilidadeISS.Properties.Items.AddRange(new object[] {
            "1 | Exigível",
            "2 | Não incidência",
            "3 | Isenção",
            "4 | Exportação",
            "5 | Imunidade",
            "6 | Exigibilidade Suspensa por Decisão Judicial ",
            "7 | Exigibilidade Suspensa por Processo Administrativo"});
            this.cbExigibilidadeISS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbExigibilidadeISS.Size = new System.Drawing.Size(416, 20);
            this.cbExigibilidadeISS.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 113;
            this.labelControl1.Text = "ExigibilidadeISS:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(122, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 80;
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(417, 20);
            this.txtDescricao.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Descrição Serviço:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbTipoTributacao
            // 
            this.cbTipoTributacao.EditValue = "1 | Isenta de ISS ";
            this.cbTipoTributacao.Location = new System.Drawing.Point(123, 91);
            this.cbTipoTributacao.Name = "cbTipoTributacao";
            this.cbTipoTributacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoTributacao.Properties.Items.AddRange(new object[] {
            "1 | Isenta de ISS ",
            "2 | Imune ",
            "3 | Não Incidência no Município ",
            "4 | Não Tributável ",
            "5 | Retida ",
            "6 | Tributável dentro do município ",
            "7 | Tributável fora do município"});
            this.cbTipoTributacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoTributacao.Size = new System.Drawing.Size(416, 20);
            this.cbTipoTributacao.TabIndex = 99;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(39, 94);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 13);
            this.labelControl9.TabIndex = 111;
            this.labelControl9.Text = "Tipo Tributacao:";
            // 
            // txtCodigoItemListaServico
            // 
            this.txtCodigoItemListaServico.CwkFuncaoValidacao = null;
            this.txtCodigoItemListaServico.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtCodigoItemListaServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigoItemListaServico.Location = new System.Drawing.Point(401, 9);
            this.txtCodigoItemListaServico.Name = "txtCodigoItemListaServico";
            this.txtCodigoItemListaServico.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoItemListaServico.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigoItemListaServico.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtCodigoItemListaServico.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigoItemListaServico.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigoItemListaServico.Properties.MaxLength = 10;
            this.txtCodigoItemListaServico.SelecionarTextoOnEnter = false;
            this.txtCodigoItemListaServico.Size = new System.Drawing.Size(138, 20);
            this.txtCodigoItemListaServico.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Cód. Lista Serviço:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btConsultarImposto
            // 
            this.btConsultarImposto.GridControl = this.gcServicoImpostos;
            this.btConsultarImposto.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarImposto.Location = new System.Drawing.Point(307, 348);
            this.btConsultarImposto.Name = "btConsultarImposto";
            this.btConsultarImposto.Size = new System.Drawing.Size(75, 23);
            this.btConsultarImposto.SubForm = null;
            this.btConsultarImposto.TabIndex = 105;
            this.btConsultarImposto.Text = "&Consultar";
            this.btConsultarImposto.Click += new System.EventHandler(this.btConsultarImposto_Click);
            // 
            // gcServicoImpostos
            // 
            this.gcServicoImpostos.Location = new System.Drawing.Point(22, 200);
            this.gcServicoImpostos.MainView = this.gvServicoImpostos;
            this.gcServicoImpostos.Name = "gcServicoImpostos";
            this.gcServicoImpostos.Size = new System.Drawing.Size(517, 142);
            this.gcServicoImpostos.TabIndex = 109;
            this.gcServicoImpostos.TabStop = false;
            this.gcServicoImpostos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServicoImpostos});
            // 
            // gvServicoImpostos
            // 
            this.gvServicoImpostos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.Empty.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicoImpostos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicoImpostos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicoImpostos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicoImpostos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicoImpostos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicoImpostos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicoImpostos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicoImpostos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicoImpostos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicoImpostos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvServicoImpostos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.Preview.Options.UseFont = true;
            this.gvServicoImpostos.Appearance.Preview.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoImpostos.Appearance.Row.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvServicoImpostos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicoImpostos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicoImpostos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvServicoImpostos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvServicoImpostos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvServicoImpostos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvServicoImpostos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvServicoImpostos.BestFitMaxRowCount = 5;
            this.gvServicoImpostos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvServicoImpostos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvServicoImpostos.GridControl = this.gcServicoImpostos;
            this.gvServicoImpostos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvServicoImpostos.Name = "gvServicoImpostos";
            this.gvServicoImpostos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvServicoImpostos.OptionsBehavior.Editable = false;
            this.gvServicoImpostos.OptionsBehavior.ReadOnly = true;
            this.gvServicoImpostos.OptionsCustomization.AllowGroup = false;
            this.gvServicoImpostos.OptionsDetail.EnableMasterViewMode = false;
            this.gvServicoImpostos.OptionsView.ColumnAutoWidth = false;
            this.gvServicoImpostos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvServicoImpostos.OptionsView.EnableAppearanceOddRow = true;
            this.gvServicoImpostos.OptionsView.ShowAutoFilterRow = true;
            this.gvServicoImpostos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "BaseRetencaoImposto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // btExcluirImposto
            // 
            this.btExcluirImposto.GridControl = this.gcServicoImpostos;
            this.btExcluirImposto.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirImposto.Location = new System.Drawing.Point(464, 348);
            this.btExcluirImposto.Name = "btExcluirImposto";
            this.btExcluirImposto.Size = new System.Drawing.Size(75, 23);
            this.btExcluirImposto.SubForm = null;
            this.btExcluirImposto.TabIndex = 108;
            this.btExcluirImposto.Text = "&Excluir";
            this.btExcluirImposto.Click += new System.EventHandler(this.btExcluirImposto_Click);
            // 
            // btIncluirImposto
            // 
            this.btIncluirImposto.GridControl = this.gcServicoImpostos;
            this.btIncluirImposto.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirImposto.Location = new System.Drawing.Point(385, 348);
            this.btIncluirImposto.Name = "btIncluirImposto";
            this.btIncluirImposto.Size = new System.Drawing.Size(75, 23);
            this.btIncluirImposto.SubForm = null;
            this.btIncluirImposto.TabIndex = 106;
            this.btIncluirImposto.Text = "&Incluir";
            this.btIncluirImposto.Click += new System.EventHandler(this.btIncluirImposto_Click);
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtValor.Location = new System.Drawing.Point(401, 35);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(138, 20);
            this.txtValor.TabIndex = 97;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(367, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 107;
            this.labelControl3.Text = "Valor:";
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(63, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 80;
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 96;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(63, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.Properties.MaxLength = 10;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabExtra
            // 
            this.tabExtra.Controls.Add(this.btConsultarMaterial);
            this.tabExtra.Controls.Add(this.btExcluirMaterial);
            this.tabExtra.Controls.Add(this.btIncluirMaterial);
            this.tabExtra.Controls.Add(this.label6);
            this.tabExtra.Controls.Add(this.gcMateriais);
            this.tabExtra.Controls.Add(this.label5);
            this.tabExtra.Controls.Add(this.rtxtInformacoesAdicionais);
            this.tabExtra.Name = "tabExtra";
            this.tabExtra.Size = new System.Drawing.Size(544, 382);
            this.tabExtra.Text = "Extra";
            // 
            // btConsultarMaterial
            // 
            this.btConsultarMaterial.GridControl = this.gcServicoImpostos;
            this.btConsultarMaterial.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarMaterial.Location = new System.Drawing.Point(299, 169);
            this.btConsultarMaterial.Name = "btConsultarMaterial";
            this.btConsultarMaterial.Size = new System.Drawing.Size(75, 23);
            this.btConsultarMaterial.SubForm = null;
            this.btConsultarMaterial.TabIndex = 115;
            this.btConsultarMaterial.Text = "&Consultar";
            this.btConsultarMaterial.Click += new System.EventHandler(this.btConsultarMaterial_Click);
            // 
            // btExcluirMaterial
            // 
            this.btExcluirMaterial.GridControl = this.gcServicoImpostos;
            this.btExcluirMaterial.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirMaterial.Location = new System.Drawing.Point(461, 169);
            this.btExcluirMaterial.Name = "btExcluirMaterial";
            this.btExcluirMaterial.Size = new System.Drawing.Size(75, 23);
            this.btExcluirMaterial.SubForm = null;
            this.btExcluirMaterial.TabIndex = 114;
            this.btExcluirMaterial.Text = "&Excluir";
            this.btExcluirMaterial.Click += new System.EventHandler(this.btExcluirMaterial_Click);
            // 
            // btIncluirMaterial
            // 
            this.btIncluirMaterial.GridControl = this.gcServicoImpostos;
            this.btIncluirMaterial.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirMaterial.Location = new System.Drawing.Point(380, 169);
            this.btIncluirMaterial.Name = "btIncluirMaterial";
            this.btIncluirMaterial.Size = new System.Drawing.Size(75, 23);
            this.btIncluirMaterial.SubForm = null;
            this.btIncluirMaterial.TabIndex = 113;
            this.btIncluirMaterial.Text = "&Incluir";
            this.btIncluirMaterial.Click += new System.EventHandler(this.btIncluirMaterial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Materiais:";
            // 
            // gcMateriais
            // 
            this.gcMateriais.Location = new System.Drawing.Point(93, 14);
            this.gcMateriais.MainView = this.gvMateriais;
            this.gcMateriais.Name = "gcMateriais";
            this.gcMateriais.Size = new System.Drawing.Size(443, 149);
            this.gcMateriais.TabIndex = 110;
            this.gcMateriais.TabStop = false;
            this.gcMateriais.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMateriais});
            // 
            // gvMateriais
            // 
            this.gvMateriais.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvMateriais.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvMateriais.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvMateriais.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvMateriais.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.Empty.Options.UseBackColor = true;
            this.gvMateriais.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvMateriais.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvMateriais.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMateriais.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvMateriais.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvMateriais.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvMateriais.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMateriais.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMateriais.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvMateriais.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvMateriais.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvMateriais.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriais.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMateriais.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvMateriais.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriais.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriais.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMateriais.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvMateriais.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvMateriais.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvMateriais.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvMateriais.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvMateriais.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvMateriais.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvMateriais.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvMateriais.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvMateriais.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvMateriais.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvMateriais.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMateriais.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvMateriais.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvMateriais.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvMateriais.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriais.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMateriais.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvMateriais.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.OddRow.Options.UseBackColor = true;
            this.gvMateriais.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.OddRow.Options.UseForeColor = true;
            this.gvMateriais.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvMateriais.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.Preview.Options.UseFont = true;
            this.gvMateriais.Appearance.Preview.Options.UseForeColor = true;
            this.gvMateriais.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvMateriais.Appearance.Row.Options.UseBackColor = true;
            this.gvMateriais.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvMateriais.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvMateriais.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriais.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvMateriais.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvMateriais.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvMateriais.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvMateriais.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvMateriais.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvMateriais.BestFitMaxRowCount = 5;
            this.gvMateriais.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.Nome});
            this.gvMateriais.GridControl = this.gcMateriais;
            this.gvMateriais.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvMateriais.Name = "gvMateriais";
            this.gvMateriais.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvMateriais.OptionsCustomization.AllowGroup = false;
            this.gvMateriais.OptionsDetail.EnableMasterViewMode = false;
            this.gvMateriais.OptionsView.ColumnAutoWidth = false;
            this.gvMateriais.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMateriais.OptionsView.EnableAppearanceOddRow = true;
            this.gvMateriais.OptionsView.ShowAutoFilterRow = true;
            this.gvMateriais.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.ReadOnly = true;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.OptionsColumn.ReadOnly = true;
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 1;
            this.Nome.Width = 345;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Inf. Adicionais:";
            // 
            // rtxtInformacoesAdicionais
            // 
            this.rtxtInformacoesAdicionais.Location = new System.Drawing.Point(93, 208);
            this.rtxtInformacoesAdicionais.MaxLength = 1000;
            this.rtxtInformacoesAdicionais.Name = "rtxtInformacoesAdicionais";
            this.rtxtInformacoesAdicionais.Size = new System.Drawing.Size(443, 171);
            this.rtxtInformacoesAdicionais.TabIndex = 0;
            this.rtxtInformacoesAdicionais.Text = "";
            // 
            // tabImagem
            // 
            this.tabImagem.Controls.Add(this.sbExcluirImagem);
            this.tabImagem.Controls.Add(this.sbDiretorio);
            this.tabImagem.Controls.Add(this.pbCaminhoImagem);
            this.tabImagem.Name = "tabImagem";
            this.tabImagem.Size = new System.Drawing.Size(544, 382);
            this.tabImagem.Text = "Imagem";
            // 
            // sbExcluirImagem
            // 
            this.sbExcluirImagem.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluirImagem.Location = new System.Drawing.Point(183, 323);
            this.sbExcluirImagem.Name = "sbExcluirImagem";
            this.sbExcluirImagem.Size = new System.Drawing.Size(108, 23);
            this.sbExcluirImagem.TabIndex = 39;
            this.sbExcluirImagem.Text = "Excluir Imagem";
            this.sbExcluirImagem.Click += new System.EventHandler(this.sbExcluirImagem_Click);
            // 
            // sbDiretorio
            // 
            this.sbDiretorio.Location = new System.Drawing.Point(17, 323);
            this.sbDiretorio.Name = "sbDiretorio";
            this.sbDiretorio.Size = new System.Drawing.Size(160, 23);
            this.sbDiretorio.TabIndex = 38;
            this.sbDiretorio.Text = "Selecionar Imagem Existente";
            this.sbDiretorio.Click += new System.EventHandler(this.sbDiretorio_Click);
            // 
            // pbCaminhoImagem
            // 
            this.pbCaminhoImagem.BackColor = System.Drawing.Color.Transparent;
            this.pbCaminhoImagem.ErrorImage = null;
            this.pbCaminhoImagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCaminhoImagem.InitialImage")));
            this.pbCaminhoImagem.Location = new System.Drawing.Point(17, 13);
            this.pbCaminhoImagem.Name = "pbCaminhoImagem";
            this.pbCaminhoImagem.Size = new System.Drawing.Size(510, 295);
            this.pbCaminhoImagem.TabIndex = 37;
            this.pbCaminhoImagem.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(586, 472);
            this.Name = "FormServico";
            this.Shown += new System.EventHandler(this.FormServico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcItems)).EndInit();
            this.tcItems.ResumeLayout(false);
            this.tabServico.ResumeLayout(false);
            this.tabServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoDeContas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIncentivoFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoObra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExigibilidadeISS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoTributacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoItemListaServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicoImpostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicoImpostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.tabExtra.ResumeLayout(false);
            this.tabExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMateriais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriais)).EndInit();
            this.tabImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhoImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcItems;
        private DevExpress.XtraTab.XtraTabPage tabServico;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpPlanoConta;
        private Cwork.Utilitarios.Componentes.Lookup lkpPlanoDeContas;
        private DevExpress.XtraEditors.LabelControl labelPlanoContas;
        private DevExpress.XtraEditors.ComboBoxEdit cbIncentivoFiscal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigoObra;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtArt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbExigibilidadeISS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoTributacao;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigoItemListaServico;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarImposto;
        private DevExpress.XtraGrid.GridControl gcServicoImpostos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServicoImpostos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirImposto;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirImposto;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabPage tabExtra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtInformacoesAdicionais;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl gcMateriais;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriais;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirMaterial;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirMaterial;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraTab.XtraTabPage tabImagem;
        private System.Windows.Forms.PictureBox pbCaminhoImagem;
        private DevExpress.XtraEditors.SimpleButton sbExcluirImagem;
        private DevExpress.XtraEditors.SimpleButton sbDiretorio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;



    }
}
