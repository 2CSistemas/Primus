namespace Aplicacao
{
    partial class FormOfd_Obra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_Obra));
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkbConstrutora = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpConstrutora = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblPessoa = new DevExpress.XtraEditors.LabelControl();
            this.txtResponsavelNaObra = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTelefoneResponsavelNaObra = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbAbrirArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpArquivos = new DevExpress.XtraTab.XtraTabPage();
            this.btAbrirArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.btConsultar = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluir = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterar = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluir = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcArquivos = new DevExpress.XtraGrid.GridControl();
            this.gvArquivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpServicos = new DevExpress.XtraTab.XtraTabPage();
            this.gcServicos = new DevExpress.XtraGrid.GridControl();
            this.gvServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpConstrutora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsavelNaObra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneResponsavelNaObra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpArquivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArquivos)).BeginInit();
            this.tpServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 393);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(403, 393);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(484, 393);
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
            this.tpPrincipal.Controls.Add(this.xtraTabControl1);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtTelefoneResponsavelNaObra);
            this.tpPrincipal.Controls.Add(this.cbStatus);
            this.tpPrincipal.Controls.Add(this.txtResponsavelNaObra);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.lkbConstrutora);
            this.tpPrincipal.Controls.Add(this.lkpConstrutora);
            this.tpPrincipal.Controls.Add(this.lblPessoa);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(541, 369);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(547, 375);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtCodigo.EditValue = 0;
            this.txtCodigo.Location = new System.Drawing.Point(77, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "d";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(77, 32);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 200;
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(455, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(21, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Descrição:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(34, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Código:";
            // 
            // lkbConstrutora
            // 
            this.lkbConstrutora.Location = new System.Drawing.Point(508, 58);
            this.lkbConstrutora.Lookup = null;
            this.lkbConstrutora.Name = "lkbConstrutora";
            this.lkbConstrutora.Size = new System.Drawing.Size(24, 20);
            this.lkbConstrutora.SubForm = null;
            this.lkbConstrutora.SubFormType = null;
            this.lkbConstrutora.SubFormTypeParams = null;
            this.lkbConstrutora.TabIndex = 8;
            this.lkbConstrutora.TabStop = false;
            this.lkbConstrutora.Text = "...";
            this.lkbConstrutora.Click += new System.EventHandler(this.lkbConstrutora_Click);
            // 
            // lkpConstrutora
            // 
            this.lkpConstrutora.ButtonLookup = this.lkbConstrutora;
            this.lkpConstrutora.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpConstrutora.CamposRestricoesAND = null;
            this.lkpConstrutora.CamposRestricoesNOT = null;
            this.lkpConstrutora.CamposRestricoesOR = null;
            this.lkpConstrutora.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpConstrutora.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpConstrutora.ContextoLinq = null;
            this.lkpConstrutora.CwkFuncaoValidacao = null;
            this.lkpConstrutora.CwkMascara = null;
            this.lkpConstrutora.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpConstrutora.Exemplo = null;
            this.lkpConstrutora.ID = 0;
            this.lkpConstrutora.Join = null;
            this.lkpConstrutora.Key = System.Windows.Forms.Keys.F5;
            this.lkpConstrutora.Location = new System.Drawing.Point(77, 58);
            this.lkpConstrutora.Name = "lkpConstrutora";
            this.lkpConstrutora.OnIDChanged = null;
            this.lkpConstrutora.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpConstrutora.Properties.Appearance.Options.UseBackColor = true;
            this.lkpConstrutora.SelecionarTextoOnEnter = true;
            this.lkpConstrutora.Size = new System.Drawing.Size(425, 20);
            this.lkpConstrutora.Tabela = "Pessoa";
            this.lkpConstrutora.TabIndex = 7;
            this.lkpConstrutora.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpConstrutora.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpConstrutora.Where = null;
            // 
            // lblPessoa
            // 
            this.lblPessoa.Location = new System.Drawing.Point(34, 61);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(38, 13);
            this.lblPessoa.TabIndex = 6;
            this.lblPessoa.Text = "Pessoa:";
            // 
            // txtResponsavelNaObra
            // 
            this.txtResponsavelNaObra.CwkFuncaoValidacao = null;
            this.txtResponsavelNaObra.CwkMascara = null;
            this.txtResponsavelNaObra.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtResponsavelNaObra.Location = new System.Drawing.Point(77, 84);
            this.txtResponsavelNaObra.Name = "txtResponsavelNaObra";
            this.txtResponsavelNaObra.Properties.MaxLength = 100;
            this.txtResponsavelNaObra.SelecionarTextoOnEnter = false;
            this.txtResponsavelNaObra.Size = new System.Drawing.Size(297, 20);
            this.txtResponsavelNaObra.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Responsável:";
            // 
            // cbStatus
            // 
            this.cbStatus.EditValue = "Aberto";
            this.cbStatus.Location = new System.Drawing.Point(415, 6);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.ImmediatePopup = true;
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Aberta",
            "Executando",
            "Pendente",
            "Medição",
            "Concluída",
            "Cancelada"});
            this.cbStatus.Properties.Tag = "";
            this.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatus.Size = new System.Drawing.Size(117, 20);
            this.cbStatus.TabIndex = 3;
            // 
            // txtTelefoneResponsavelNaObra
            // 
            this.txtTelefoneResponsavelNaObra.CwkFuncaoValidacao = null;
            this.txtTelefoneResponsavelNaObra.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.TELEFONE;
            this.txtTelefoneResponsavelNaObra.CwkValidacao = null;
            this.txtTelefoneResponsavelNaObra.Location = new System.Drawing.Point(432, 84);
            this.txtTelefoneResponsavelNaObra.Name = "txtTelefoneResponsavelNaObra";
            this.txtTelefoneResponsavelNaObra.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtTelefoneResponsavelNaObra.Properties.Mask.EditMask = "[(](([1](([1-9][)]([9]([6-9][0-9]{3}|[0-9]{3})|[0-9]{4}))|[1-9][)][0-9]{4})|[2-9]" +
    "[1-9][)][0-9]{4}))[-][0-9]{4}";
            this.txtTelefoneResponsavelNaObra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTelefoneResponsavelNaObra.Properties.Mask.ShowPlaceHolders = false;
            this.txtTelefoneResponsavelNaObra.SelecionarTextoOnEnter = false;
            this.txtTelefoneResponsavelNaObra.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneResponsavelNaObra.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(374, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Status:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(380, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Telefone:";
            // 
            // sbAbrirArquivo
            // 
            this.sbAbrirArquivo.ImageOptions.Image = global::Aplicacao.Properties.Resources.folder1;
            this.sbAbrirArquivo.Location = new System.Drawing.Point(105, 193);
            this.sbAbrirArquivo.Name = "sbAbrirArquivo";
            this.sbAbrirArquivo.Size = new System.Drawing.Size(116, 23);
            this.sbAbrirArquivo.TabIndex = 5;
            this.sbAbrirArquivo.Text = "&Abrir Arquivo";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 110);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpArquivos;
            this.xtraTabControl1.Size = new System.Drawing.Size(532, 253);
            this.xtraTabControl1.TabIndex = 24;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpArquivos,
            this.tpServicos});
            // 
            // tpArquivos
            // 
            this.tpArquivos.Controls.Add(this.btAbrirArquivo);
            this.tpArquivos.Controls.Add(this.btConsultar);
            this.tpArquivos.Controls.Add(this.btExcluir);
            this.tpArquivos.Controls.Add(this.btAlterar);
            this.tpArquivos.Controls.Add(this.btIncluir);
            this.tpArquivos.Controls.Add(this.gcArquivos);
            this.tpArquivos.Name = "tpArquivos";
            this.tpArquivos.Size = new System.Drawing.Size(526, 225);
            this.tpArquivos.Text = "Arquivos";
            // 
            // btAbrirArquivo
            // 
            this.btAbrirArquivo.ImageOptions.Image = global::Aplicacao.Properties.Resources.folder1;
            this.btAbrirArquivo.Location = new System.Drawing.Point(80, 193);
            this.btAbrirArquivo.Name = "btAbrirArquivo";
            this.btAbrirArquivo.Size = new System.Drawing.Size(116, 23);
            this.btAbrirArquivo.TabIndex = 5;
            this.btAbrirArquivo.Text = "&Abrir Arquivo";
            this.btAbrirArquivo.Click += new System.EventHandler(this.btAbrirArquivo_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.GridControl = null;
            this.btConsultar.GridControlType = null;
            this.btConsultar.GridControlTypeParams = null;
            this.btConsultar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultar.Location = new System.Drawing.Point(202, 193);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.SubForm = null;
            this.btConsultar.SubFormType = null;
            this.btConsultar.SubFormTypeParams = null;
            this.btConsultar.TabIndex = 6;
            this.btConsultar.TabStop = false;
            this.btConsultar.Text = "&Consultar";
            // 
            // btExcluir
            // 
            this.btExcluir.GridControl = null;
            this.btExcluir.GridControlType = null;
            this.btExcluir.GridControlTypeParams = null;
            this.btExcluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluir.Location = new System.Drawing.Point(445, 193);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.SubForm = null;
            this.btExcluir.SubFormType = null;
            this.btExcluir.SubFormTypeParams = null;
            this.btExcluir.TabIndex = 9;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "&Excluir";
            // 
            // btAlterar
            // 
            this.btAlterar.GridControl = null;
            this.btAlterar.GridControlType = null;
            this.btAlterar.GridControlTypeParams = null;
            this.btAlterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterar.Location = new System.Drawing.Point(364, 193);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.SubForm = null;
            this.btAlterar.SubFormType = null;
            this.btAlterar.SubFormTypeParams = null;
            this.btAlterar.TabIndex = 8;
            this.btAlterar.TabStop = false;
            this.btAlterar.Text = "&Alterar";
            // 
            // btIncluir
            // 
            this.btIncluir.GridControl = null;
            this.btIncluir.GridControlType = null;
            this.btIncluir.GridControlTypeParams = null;
            this.btIncluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluir.Location = new System.Drawing.Point(283, 193);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.SubForm = null;
            this.btIncluir.SubFormType = null;
            this.btIncluir.SubFormTypeParams = null;
            this.btIncluir.TabIndex = 7;
            this.btIncluir.TabStop = false;
            this.btIncluir.Text = "&Incluir";
            // 
            // gcArquivos
            // 
            this.gcArquivos.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcArquivos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcArquivos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcArquivos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcArquivos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcArquivos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcArquivos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcArquivos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcArquivos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcArquivos.Location = new System.Drawing.Point(3, 3);
            this.gcArquivos.MainView = this.gvArquivos;
            this.gcArquivos.Name = "gcArquivos";
            this.gcArquivos.Size = new System.Drawing.Size(517, 184);
            this.gcArquivos.TabIndex = 0;
            this.gcArquivos.UseEmbeddedNavigator = true;
            this.gcArquivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArquivos});
            // 
            // gvArquivos
            // 
            this.gvArquivos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArquivos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArquivos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.Empty.Options.UseBackColor = true;
            this.gvArquivos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArquivos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArquivos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArquivos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArquivos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArquivos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArquivos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArquivos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArquivos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArquivos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArquivos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArquivos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvArquivos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.Preview.Options.UseFont = true;
            this.gvArquivos.Appearance.Preview.Options.UseForeColor = true;
            this.gvArquivos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.Row.Options.UseBackColor = true;
            this.gvArquivos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArquivos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvArquivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvArquivos.GridControl = this.gcArquivos;
            this.gvArquivos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvArquivos.Name = "gvArquivos";
            this.gvArquivos.OptionsBehavior.Editable = false;
            this.gvArquivos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvArquivos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArquivos.OptionsView.EnableAppearanceOddRow = true;
            this.gvArquivos.OptionsView.ShowAutoFilterRow = true;
            this.gvArquivos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seq";
            this.gridColumn1.FieldName = "Sequencia";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descrição";
            this.gridColumn2.FieldName = "Descricao";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 459;
            // 
            // tpServicos
            // 
            this.tpServicos.Controls.Add(this.gcServicos);
            this.tpServicos.Name = "tpServicos";
            this.tpServicos.Size = new System.Drawing.Size(526, 225);
            this.tpServicos.Text = "Serviços";
            // 
            // gcServicos
            // 
            this.gcServicos.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcServicos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcServicos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcServicos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcServicos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcServicos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcServicos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcServicos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcServicos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcServicos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcServicos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcServicos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcServicos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcServicos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcServicos.Location = new System.Drawing.Point(5, 3);
            this.gcServicos.MainView = this.gvServicos;
            this.gcServicos.Name = "gcServicos";
            this.gcServicos.Size = new System.Drawing.Size(517, 221);
            this.gcServicos.TabIndex = 1;
            this.gcServicos.UseEmbeddedNavigator = true;
            this.gcServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServicos});
            // 
            // gvServicos
            // 
            this.gvServicos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvServicos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvServicos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.Empty.Options.UseBackColor = true;
            this.gvServicos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvServicos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvServicos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvServicos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvServicos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvServicos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvServicos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvServicos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvServicos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvServicos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Preview.Options.UseFont = true;
            this.gvServicos.Appearance.Preview.Options.UseForeColor = true;
            this.gvServicos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicos.Appearance.Row.Options.UseBackColor = true;
            this.gvServicos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvServicos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvServicos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvServicos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvServicos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvServicos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvServicos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvServicos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gvServicos.GridControl = this.gcServicos;
            this.gvServicos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvServicos.Name = "gvServicos";
            this.gvServicos.OptionsBehavior.Editable = false;
            this.gvServicos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvServicos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvServicos.OptionsView.EnableAppearanceOddRow = true;
            this.gvServicos.OptionsView.ShowAutoFilterRow = true;
            this.gvServicos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "Codigo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 50;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Serviço";
            this.gridColumn4.FieldName = "Nome";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 459;
            // 
            // FormOfd_Obra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(571, 428);
            this.Name = "FormOfd_Obra";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpConstrutora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsavelNaObra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneResponsavelNaObra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpArquivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArquivos)).EndInit();
            this.tpServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtResponsavelNaObra;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbConstrutora;
        private Cwork.Utilitarios.Componentes.Lookup lkpConstrutora;
        private DevExpress.XtraEditors.LabelControl lblPessoa;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTelefoneResponsavelNaObra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbAbrirArquivo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpArquivos;
        private DevExpress.XtraEditors.SimpleButton btAbrirArquivo;
        private Cwork.Utilitarios.Componentes.DevButton btConsultar;
        private Cwork.Utilitarios.Componentes.DevButton btExcluir;
        private Cwork.Utilitarios.Componentes.DevButton btAlterar;
        private Cwork.Utilitarios.Componentes.DevButton btIncluir;
        private DevExpress.XtraGrid.GridControl gcArquivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArquivos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraTab.XtraTabPage tpServicos;
        private DevExpress.XtraGrid.GridControl gcServicos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServicos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
