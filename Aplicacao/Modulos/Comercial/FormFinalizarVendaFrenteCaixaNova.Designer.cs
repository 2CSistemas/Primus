namespace Aplicacao.Modulos.Comercial
{
    partial class FormFinalizarVendaFrenteCaixaNova
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lkbCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblCondicao = new DevExpress.XtraEditors.LabelControl();
            this.lkbTipoPedido = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoPedido = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lkbVendedor = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpVendedor = new Cwork.Utilitarios.Componentes.Lookup();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTroco = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPago = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalProdutos = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalAPagar = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtPercDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.progressBarFinalizarVenda = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.btnCarneCompra = new DevExpress.XtraEditors.SimpleButton();
            this.dxErroProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProdutos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarFinalizarVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(26, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 224);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamentos";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 192);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lkbCondicao);
            this.groupBox2.Controls.Add(this.lkpCondicao);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.lblCondicao);
            this.groupBox2.Controls.Add(this.lkbTipoPedido);
            this.groupBox2.Controls.Add(this.lkpTipoPedido);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.lkbVendedor);
            this.groupBox2.Controls.Add(this.lkpVendedor);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parâmetros da Venda";
            // 
            // lkbCondicao
            // 
            this.lkbCondicao.Location = new System.Drawing.Point(472, 103);
            this.lkbCondicao.Lookup = null;
            this.lkbCondicao.Name = "lkbCondicao";
            this.lkbCondicao.Size = new System.Drawing.Size(31, 29);
            this.lkbCondicao.SubForm = null;
            this.lkbCondicao.SubFormType = null;
            this.lkbCondicao.SubFormTypeParams = null;
            this.lkbCondicao.TabIndex = 17;
            this.lkbCondicao.TabStop = false;
            this.lkbCondicao.Text = "...";
            this.lkbCondicao.Click += new System.EventHandler(this.lkbCondicao_Click);
            // 
            // lkpCondicao
            // 
            this.lkpCondicao.ButtonLookup = this.lkbCondicao;
            this.lkpCondicao.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpCondicao.CamposRestricoesAND = null;
            this.lkpCondicao.CamposRestricoesNOT = null;
            this.lkpCondicao.CamposRestricoesOR = null;
            this.lkpCondicao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCondicao.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpCondicao.ContextoLinq = null;
            this.lkpCondicao.CwkFuncaoValidacao = null;
            this.lkpCondicao.CwkMascara = null;
            this.lkpCondicao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCondicao.Exemplo = null;
            this.lkpCondicao.ID = 0;
            this.lkpCondicao.Join = null;
            this.lkpCondicao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCondicao.Location = new System.Drawing.Point(108, 102);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.Properties.Appearance.Options.UseFont = true;
            this.lkpCondicao.SelecionarTextoOnEnter = true;
            this.lkpCondicao.Size = new System.Drawing.Size(358, 30);
            this.lkpCondicao.Tabela = "Condicao";
            this.lkpCondicao.TabIndex = 3;
            this.lkpCondicao.TituloTelaPesquisa = "Pesquisa - Condição";
            this.lkpCondicao.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCondicao.Where = null;
            this.lkpCondicao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lkpCondicao_KeyUp);
            this.lkpCondicao.Leave += new System.EventHandler(this.lkpCondicao_Leave_1);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Appearance.Options.UseImageAlign = true;
            this.labelControl7.Location = new System.Drawing.Point(59, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 23);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Tipo:";
            // 
            // lblCondicao
            // 
            this.lblCondicao.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicao.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblCondicao.Appearance.Options.UseFont = true;
            this.lblCondicao.Appearance.Options.UseForeColor = true;
            this.lblCondicao.Location = new System.Drawing.Point(19, 105);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(83, 23);
            this.lblCondicao.TabIndex = 15;
            this.lblCondicao.Text = "Condição:";
            // 
            // lkbTipoPedido
            // 
            this.lkbTipoPedido.Location = new System.Drawing.Point(472, 68);
            this.lkbTipoPedido.Lookup = null;
            this.lkbTipoPedido.Name = "lkbTipoPedido";
            this.lkbTipoPedido.Size = new System.Drawing.Size(31, 29);
            this.lkbTipoPedido.SubForm = null;
            this.lkbTipoPedido.SubFormType = null;
            this.lkbTipoPedido.SubFormTypeParams = null;
            this.lkbTipoPedido.TabIndex = 14;
            this.lkbTipoPedido.TabStop = false;
            this.lkbTipoPedido.Text = "...";
            this.lkbTipoPedido.Click += new System.EventHandler(this.lkbTipoPedido_Click);
            // 
            // lkpTipoPedido
            // 
            this.lkpTipoPedido.ButtonLookup = this.lkbTipoPedido;
            this.lkpTipoPedido.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipoPedido.CamposRestricoesAND = null;
            this.lkpTipoPedido.CamposRestricoesNOT = null;
            this.lkpTipoPedido.CamposRestricoesOR = null;
            this.lkpTipoPedido.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoPedido.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoPedido.ContextoLinq = null;
            this.lkpTipoPedido.CwkFuncaoValidacao = null;
            this.lkpTipoPedido.CwkMascara = null;
            this.lkpTipoPedido.CwkValidacao = null;
            this.lkpTipoPedido.Exemplo = null;
            this.lkpTipoPedido.ID = 0;
            this.lkpTipoPedido.Join = "";
            this.lkpTipoPedido.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoPedido.Location = new System.Drawing.Point(108, 67);
            this.lkpTipoPedido.Name = "lkpTipoPedido";
            this.lkpTipoPedido.OnIDChanged = null;
            this.lkpTipoPedido.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoPedido.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lkpTipoPedido.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoPedido.Properties.Appearance.Options.UseFont = true;
            this.lkpTipoPedido.Properties.AutoHeight = false;
            this.lkpTipoPedido.SelecionarTextoOnEnter = true;
            this.lkpTipoPedido.Size = new System.Drawing.Size(358, 29);
            this.lkpTipoPedido.Tabela = "TipoPeddoa";
            this.lkpTipoPedido.TabIndex = 2;
            this.lkpTipoPedido.TituloTelaPesquisa = "Pesquisa - Tipo Orçamento";
            this.lkpTipoPedido.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoPedido.Where = null;
            this.lkpTipoPedido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lkpTipoPedido_KeyUp);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Appearance.Options.UseImageAlign = true;
            this.labelControl6.Location = new System.Drawing.Point(14, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 23);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Vendedor:";
            // 
            // lkbVendedor
            // 
            this.lkbVendedor.Location = new System.Drawing.Point(472, 32);
            this.lkbVendedor.Lookup = null;
            this.lkbVendedor.Name = "lkbVendedor";
            this.lkbVendedor.Size = new System.Drawing.Size(31, 30);
            this.lkbVendedor.SubForm = null;
            this.lkbVendedor.SubFormType = null;
            this.lkbVendedor.SubFormTypeParams = null;
            this.lkbVendedor.TabIndex = 11;
            this.lkbVendedor.TabStop = false;
            this.lkbVendedor.Text = "...";
            this.lkbVendedor.Click += new System.EventHandler(this.lkbVendedor_Click);
            // 
            // lkpVendedor
            // 
            this.lkpVendedor.ButtonLookup = this.lkbVendedor;
            this.lkpVendedor.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpVendedor.CamposRestricoesAND = null;
            this.lkpVendedor.CamposRestricoesNOT = null;
            this.lkpVendedor.CamposRestricoesOR = null;
            this.lkpVendedor.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpVendedor.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpVendedor.ContextoLinq = null;
            this.lkpVendedor.CwkFuncaoValidacao = null;
            this.lkpVendedor.CwkMascara = null;
            this.lkpVendedor.CwkValidacao = null;
            this.lkpVendedor.Exemplo = null;
            this.lkpVendedor.ID = 0;
            this.lkpVendedor.Join = "inner join PessoaVendedor on PessoaVendedor.IDPessoa = Pessoa.ID";
            this.lkpVendedor.Key = System.Windows.Forms.Keys.F5;
            this.lkpVendedor.Location = new System.Drawing.Point(108, 32);
            this.lkpVendedor.Name = "lkpVendedor";
            this.lkpVendedor.OnIDChanged = null;
            this.lkpVendedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpVendedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lkpVendedor.Properties.Appearance.Options.UseBackColor = true;
            this.lkpVendedor.Properties.Appearance.Options.UseFont = true;
            this.lkpVendedor.Properties.AutoHeight = false;
            this.lkpVendedor.SelecionarTextoOnEnter = true;
            this.lkpVendedor.Size = new System.Drawing.Size(358, 29);
            this.lkpVendedor.Tabela = "Pessoa";
            this.lkpVendedor.TabIndex = 1;
            this.lkpVendedor.TituloTelaPesquisa = "Pesquisa - Vendedor";
            this.lkpVendedor.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpVendedor.Where = null;
            this.lkpVendedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lkpVendedor_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTroco);
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.txtTotalPago);
            this.groupBox3.Controls.Add(this.labelControl2);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.txtTotalProdutos);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Controls.Add(this.txtTotalAPagar);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.txtValorDesconto);
            this.groupBox3.Controls.Add(this.txtPercDesconto);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(20, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 146);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total a Pagar";
            // 
            // txtTroco
            // 
            this.txtTroco.CwkFuncaoValidacao = null;
            this.txtTroco.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtTroco.CwkValidacao = null;
            this.txtTroco.Location = new System.Drawing.Point(285, 104);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTroco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtTroco.Properties.Appearance.Options.UseBackColor = true;
            this.txtTroco.Properties.Appearance.Options.UseFont = true;
            this.txtTroco.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTroco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTroco.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTroco.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTroco.Properties.Mask.EditMask = "c2";
            this.txtTroco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTroco.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTroco.Properties.ReadOnly = true;
            this.txtTroco.SelecionarTextoOnEnter = false;
            this.txtTroco.Size = new System.Drawing.Size(124, 30);
            this.txtTroco.TabIndex = 140;
            this.txtTroco.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImageAlign = true;
            this.labelControl1.Location = new System.Drawing.Point(225, 107);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 23);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Troco:";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.CwkFuncaoValidacao = null;
            this.txtTotalPago.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtTotalPago.CwkValidacao = null;
            this.txtTotalPago.Location = new System.Drawing.Point(95, 104);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtTotalPago.Properties.Appearance.Options.UseFont = true;
            this.txtTotalPago.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalPago.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalPago.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTotalPago.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTotalPago.Properties.Mask.EditMask = "c2";
            this.txtTotalPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalPago.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalPago.Properties.ReadOnly = true;
            this.txtTotalPago.SelecionarTextoOnEnter = false;
            this.txtTotalPago.Size = new System.Drawing.Size(124, 30);
            this.txtTotalPago.TabIndex = 140;
            this.txtTotalPago.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseImageAlign = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 23);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Pago:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseImageAlign = true;
            this.labelControl5.Location = new System.Drawing.Point(225, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 23);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Desc:";
            // 
            // txtTotalProdutos
            // 
            this.txtTotalProdutos.CwkFuncaoValidacao = null;
            this.txtTotalProdutos.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtTotalProdutos.CwkValidacao = null;
            this.txtTotalProdutos.Location = new System.Drawing.Point(95, 32);
            this.txtTotalProdutos.Name = "txtTotalProdutos";
            this.txtTotalProdutos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtTotalProdutos.Properties.Appearance.Options.UseFont = true;
            this.txtTotalProdutos.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalProdutos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalProdutos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTotalProdutos.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTotalProdutos.Properties.Mask.EditMask = "c2";
            this.txtTotalProdutos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalProdutos.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalProdutos.Properties.ReadOnly = true;
            this.txtTotalProdutos.SelecionarTextoOnEnter = false;
            this.txtTotalProdutos.Size = new System.Drawing.Size(124, 30);
            this.txtTotalProdutos.TabIndex = 140;
            this.txtTotalProdutos.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseImageAlign = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 23);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Produtos:";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.CwkFuncaoValidacao = null;
            this.txtTotalAPagar.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtTotalAPagar.CwkValidacao = null;
            this.txtTotalAPagar.Location = new System.Drawing.Point(95, 68);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtTotalAPagar.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAPagar.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalAPagar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalAPagar.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTotalAPagar.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTotalAPagar.Properties.Mask.EditMask = "c2";
            this.txtTotalAPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAPagar.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAPagar.Properties.ReadOnly = true;
            this.txtTotalAPagar.SelecionarTextoOnEnter = false;
            this.txtTotalAPagar.Size = new System.Drawing.Size(124, 30);
            this.txtTotalAPagar.TabIndex = 140;
            this.txtTotalAPagar.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseImageAlign = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 23);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "A Pagar:";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(278, 33);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtValorDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtValorDesconto.Properties.AutoHeight = false;
            this.txtValorDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorDesconto.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorDesconto.Properties.Precision = 2;
            this.txtValorDesconto.Size = new System.Drawing.Size(131, 29);
            this.txtValorDesconto.TabIndex = 91;
            this.txtValorDesconto.Leave += new System.EventHandler(this.txtValorDesconto_Leave);
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.Location = new System.Drawing.Point(415, 33);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPercDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtPercDesconto.Properties.AutoHeight = false;
            this.txtPercDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPercDesconto.Properties.DisplayFormat.FormatString = "F4";
            this.txtPercDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPercDesconto.Properties.Precision = 4;
            this.txtPercDesconto.Size = new System.Drawing.Size(98, 29);
            this.txtPercDesconto.TabIndex = 92;
            this.txtPercDesconto.Leave += new System.EventHandler(this.txtPercDesconto_Leave);
            // 
            // progressBarFinalizarVenda
            // 
            this.progressBarFinalizarVenda.Location = new System.Drawing.Point(20, 597);
            this.progressBarFinalizarVenda.Name = "progressBarFinalizarVenda";
            this.progressBarFinalizarVenda.Properties.ReadOnly = true;
            this.progressBarFinalizarVenda.Properties.ShowTitle = true;
            this.progressBarFinalizarVenda.Properties.Step = 1;
            this.progressBarFinalizarVenda.Size = new System.Drawing.Size(520, 29);
            this.progressBarFinalizarVenda.TabIndex = 16;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.btnVoltar.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.btnVoltar.Appearance.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Appearance.Options.UseBackColor = true;
            this.btnVoltar.Appearance.Options.UseFont = true;
            this.btnVoltar.Appearance.Options.UseForeColor = true;
            this.btnVoltar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnVoltar.Location = new System.Drawing.Point(216, 632);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 42);
            this.btnVoltar.TabIndex = 34;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "[F4] - Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenda.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.btnFinalizarVenda.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.btnFinalizarVenda.Appearance.BorderColor = System.Drawing.Color.Green;
            this.btnFinalizarVenda.Appearance.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Appearance.Options.UseBackColor = true;
            this.btnFinalizarVenda.Appearance.Options.UseBorderColor = true;
            this.btnFinalizarVenda.Appearance.Options.UseFont = true;
            this.btnFinalizarVenda.Appearance.Options.UseForeColor = true;
            this.btnFinalizarVenda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(338, 632);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(202, 42);
            this.btnFinalizarVenda.TabIndex = 35;
            this.btnFinalizarVenda.TabStop = false;
            this.btnFinalizarVenda.Text = "[F12] - Finalizar Venda";
            this.btnFinalizarVenda.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnCarneCompra
            // 
            this.btnCarneCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarneCompra.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.btnCarneCompra.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.btnCarneCompra.Appearance.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarneCompra.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCarneCompra.Appearance.Options.UseBackColor = true;
            this.btnCarneCompra.Appearance.Options.UseFont = true;
            this.btnCarneCompra.Appearance.Options.UseForeColor = true;
            this.btnCarneCompra.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCarneCompra.Location = new System.Drawing.Point(20, 632);
            this.btnCarneCompra.Name = "btnCarneCompra";
            this.btnCarneCompra.Size = new System.Drawing.Size(156, 42);
            this.btnCarneCompra.TabIndex = 36;
            this.btnCarneCompra.TabStop = false;
            this.btnCarneCompra.Text = "Carnê de Compra";
            this.btnCarneCompra.Visible = false;
            // 
            // dxErroProvider
            // 
            this.dxErroProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormFinalizarVendaFrenteCaixaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 697);
            this.Controls.Add(this.btnCarneCompra);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.progressBarFinalizarVenda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormFinalizarVendaFrenteCaixaNova";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Finalizar Venda";
            this.Shown += new System.EventHandler(this.FormFinalizarVendaFrenteCaixa_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTroco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProdutos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarFinalizarVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCondicao;
        private Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblCondicao;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoPedido;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoPedido;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.LookupButton lkbVendedor;
        private Cwork.Utilitarios.Componentes.Lookup lkpVendedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTotalProdutos;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTotalAPagar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValorDesconto;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPercDesconto;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTroco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTotalPago;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ProgressBarControl progressBarFinalizarVenda;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnFinalizarVenda;
        private DevExpress.XtraEditors.SimpleButton btnCarneCompra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErroProvider;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}