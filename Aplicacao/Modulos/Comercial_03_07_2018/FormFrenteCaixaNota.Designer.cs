namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrenteCaixaNota));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripAlteraQuantidadeProduto = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDescartarUltimoItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCarregarProdutos = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCarregarClientes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCarregarVendedores = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFinalizarVenda = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dxErroProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.devMemoListaItens = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.txtSubTotal = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.imagemProduto = new DevExpress.XtraEditors.PictureEdit();
            this.lkpProduto = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtNomeProduto = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPreco = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPercDesconto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sbFinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.sbCliente = new DevExpress.XtraEditors.SimpleButton();
            this.sbDescartar = new DevExpress.XtraEditors.SimpleButton();
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.sbVendedor = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbPreco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.SbQuantidade = new DevExpress.XtraEditors.SimpleButton();
            this.sbCPF = new DevExpress.XtraEditors.SimpleButton();
            this.imagemEmpresa = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblData = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemoListaItens.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemEmpresa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAlteraQuantidadeProduto,
            this.toolStripDescartarUltimoItem,
            this.toolStripStatusLabel1,
            this.toolStripCarregarProdutos,
            this.toolStripStatusLabel2,
            this.toolStripCarregarClientes,
            this.toolStripCarregarVendedores,
            this.toolStripFinalizarVenda,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripAlteraQuantidadeProduto
            // 
            this.toolStripAlteraQuantidadeProduto.Name = "toolStripAlteraQuantidadeProduto";
            this.toolStripAlteraQuantidadeProduto.Size = new System.Drawing.Size(137, 17);
            this.toolStripAlteraQuantidadeProduto.Text = "Alterar Qtd. Produto (F2)";
            // 
            // toolStripDescartarUltimoItem
            // 
            this.toolStripDescartarUltimoItem.Name = "toolStripDescartarUltimoItem";
            this.toolStripDescartarUltimoItem.Size = new System.Drawing.Size(144, 17);
            this.toolStripDescartarUltimoItem.Text = "Descartar último Item (F3)";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel1.Text = "Consulta Preço (F4)";
            // 
            // toolStripCarregarProdutos
            // 
            this.toolStripCarregarProdutos.Name = "toolStripCarregarProdutos";
            this.toolStripCarregarProdutos.Size = new System.Drawing.Size(126, 17);
            this.toolStripCarregarProdutos.Text = "Carregar Produtos (F5)";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel2.Text = "Informar CPF (F6)";
            // 
            // toolStripCarregarClientes
            // 
            this.toolStripCarregarClientes.Name = "toolStripCarregarClientes";
            this.toolStripCarregarClientes.Size = new System.Drawing.Size(120, 17);
            this.toolStripCarregarClientes.Text = "Carregar Clientes (F7)";
            // 
            // toolStripCarregarVendedores
            // 
            this.toolStripCarregarVendedores.Name = "toolStripCarregarVendedores";
            this.toolStripCarregarVendedores.Size = new System.Drawing.Size(139, 17);
            this.toolStripCarregarVendedores.Text = "Carregar Vendedores (F8)";
            // 
            // toolStripFinalizarVenda
            // 
            this.toolStripFinalizarVenda.Name = "toolStripFinalizarVenda";
            this.toolStripFinalizarVenda.Size = new System.Drawing.Size(114, 17);
            this.toolStripFinalizarVenda.Text = "Finalizar Venda (F12)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl1.Location = new System.Drawing.Point(9, 219);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(179, 32);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "VALOR TOTAL";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // devMemoListaItens
            // 
            this.devMemoListaItens.Cursor = System.Windows.Forms.Cursors.No;
            this.devMemoListaItens.Location = new System.Drawing.Point(623, 73);
            this.devMemoListaItens.Name = "devMemoListaItens";
            this.devMemoListaItens.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.devMemoListaItens.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devMemoListaItens.Properties.Appearance.Options.UseBackColor = true;
            this.devMemoListaItens.Properties.Appearance.Options.UseFont = true;
            this.devMemoListaItens.Properties.Appearance.Options.UseTextOptions = true;
            this.devMemoListaItens.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.devMemoListaItens.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.devMemoListaItens.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.devMemoListaItens.Properties.ReadOnly = true;
            this.devMemoListaItens.Size = new System.Drawing.Size(547, 594);
            this.devMemoListaItens.TabIndex = 2;
            this.devMemoListaItens.TabStop = false;
            this.devMemoListaItens.EditValueChanged += new System.EventHandler(this.devMemoListaItens_EditValueChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.CwkFuncaoValidacao = null;
            this.txtSubTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtSubTotal.CwkValidacao = null;
            this.txtSubTotal.Location = new System.Drawing.Point(9, 257);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtSubTotal.Properties.Appearance.Options.UseFont = true;
            this.txtSubTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtSubTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSubTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.txtSubTotal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtSubTotal.Properties.Mask.EditMask = "c2";
            this.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSubTotal.Properties.ReadOnly = true;
            this.txtSubTotal.SelecionarTextoOnEnter = false;
            this.txtSubTotal.Size = new System.Drawing.Size(492, 54);
            this.txtSubTotal.TabIndex = 3;
            this.txtSubTotal.TabStop = false;
            // 
            // imagemProduto
            // 
            this.imagemProduto.Location = new System.Drawing.Point(54, 323);
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imagemProduto.Properties.Appearance.Options.UseBackColor = true;
            this.imagemProduto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.imagemProduto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imagemProduto.Size = new System.Drawing.Size(396, 181);
            this.imagemProduto.TabIndex = 4;
            this.imagemProduto.EditValueChanged += new System.EventHandler(this.imagemProduto_EditValueChanged);
            // 
            // lkpProduto
            // 
            this.lkpProduto.CwkFuncaoValidacao = null;
            this.lkpProduto.CwkMascara = null;
            this.lkpProduto.CwkValidacao = null;
            this.lkpProduto.EnterMoveNextControl = true;
            this.lkpProduto.Location = new System.Drawing.Point(39, 30);
            this.lkpProduto.Name = "lkpProduto";
            this.lkpProduto.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpProduto.Properties.Appearance.Options.UseFont = true;
            this.lkpProduto.SelecionarTextoOnEnter = false;
            this.lkpProduto.Size = new System.Drawing.Size(462, 28);
            this.lkpProduto.TabIndex = 6;
            this.lkpProduto.Leave += new System.EventHandler(this.lkpProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.CwkFuncaoValidacao = null;
            this.txtNomeProduto.CwkMascara = null;
            this.txtNomeProduto.CwkValidacao = null;
            this.txtNomeProduto.Location = new System.Drawing.Point(39, 93);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeProduto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtNomeProduto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtNomeProduto.Properties.ReadOnly = true;
            this.txtNomeProduto.SelecionarTextoOnEnter = false;
            this.txtNomeProduto.Size = new System.Drawing.Size(460, 28);
            this.txtNomeProduto.TabIndex = 8;
            this.txtNomeProduto.TabStop = false;
            this.txtNomeProduto.Leave += new System.EventHandler(this.txtNomeProduto_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtQuantidade.CwkValidacao = null;
            this.txtQuantidade.EnterMoveNextControl = true;
            this.txtQuantidade.Location = new System.Drawing.Point(39, 151);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtQuantidade.Properties.Mask.EditMask = "N4";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(107, 28);
            this.txtQuantidade.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl3.Location = new System.Drawing.Point(39, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 17);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Quantidade";
            // 
            // txtPreco
            // 
            this.txtPreco.CwkFuncaoValidacao = null;
            this.txtPreco.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtPreco.CwkValidacao = null;
            this.txtPreco.EnterMoveNextControl = true;
            this.txtPreco.Location = new System.Drawing.Point(189, 151);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Properties.Appearance.Options.UseFont = true;
            this.txtPreco.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPreco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPreco.Properties.Mask.EditMask = "c2";
            this.txtPreco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPreco.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPreco.SelecionarTextoOnEnter = false;
            this.txtPreco.Size = new System.Drawing.Size(120, 28);
            this.txtPreco.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl4.Location = new System.Drawing.Point(189, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(100, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Valor Unitário";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.CwkFuncaoValidacao = null;
            this.txtPercDesconto.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtPercDesconto.CwkValidacao = null;
            this.txtPercDesconto.EnterMoveNextControl = true;
            this.txtPercDesconto.Location = new System.Drawing.Point(351, 151);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtPercDesconto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPercDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPercDesconto.Properties.Mask.EditMask = "N4";
            this.txtPercDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPercDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercDesconto.SelecionarTextoOnEnter = false;
            this.txtPercDesconto.Size = new System.Drawing.Size(104, 28);
            this.txtPercDesconto.TabIndex = 14;
            this.txtPercDesconto.Leave += new System.EventHandler(this.txtPercDesconto_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl5.Location = new System.Drawing.Point(351, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(99, 17);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Desconto (%):";
            // 
            // sbFinalizarVenda
            // 
            this.sbFinalizarVenda.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbFinalizarVenda.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbFinalizarVenda.Appearance.BorderColor = System.Drawing.Color.Green;
            this.sbFinalizarVenda.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbFinalizarVenda.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbFinalizarVenda.Appearance.Options.UseBackColor = true;
            this.sbFinalizarVenda.Appearance.Options.UseBorderColor = true;
            this.sbFinalizarVenda.Appearance.Options.UseFont = true;
            this.sbFinalizarVenda.Appearance.Options.UseForeColor = true;
            this.sbFinalizarVenda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbFinalizarVenda.Location = new System.Drawing.Point(407, 625);
            this.sbFinalizarVenda.Name = "sbFinalizarVenda";
            this.sbFinalizarVenda.Size = new System.Drawing.Size(193, 45);
            this.sbFinalizarVenda.TabIndex = 18;
            this.sbFinalizarVenda.TabStop = false;
            this.sbFinalizarVenda.Text = "F12 - Finalizar Venda";
            this.sbFinalizarVenda.Click += new System.EventHandler(this.sbFinalizarVenda_Click);
            // 
            // sbCliente
            // 
            this.sbCliente.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbCliente.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbCliente.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCliente.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbCliente.Appearance.Options.UseBackColor = true;
            this.sbCliente.Appearance.Options.UseFont = true;
            this.sbCliente.Appearance.Options.UseForeColor = true;
            this.sbCliente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbCliente.Location = new System.Drawing.Point(407, 577);
            this.sbCliente.Name = "sbCliente";
            this.sbCliente.Size = new System.Drawing.Size(193, 42);
            this.sbCliente.TabIndex = 16;
            this.sbCliente.TabStop = false;
            this.sbCliente.Text = "F7 - Cliente";
            this.sbCliente.Click += new System.EventHandler(this.sbCliente_Click);
            // 
            // sbDescartar
            // 
            this.sbDescartar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbDescartar.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbDescartar.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbDescartar.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbDescartar.Appearance.Options.UseBackColor = true;
            this.sbDescartar.Appearance.Options.UseFont = true;
            this.sbDescartar.Appearance.Options.UseForeColor = true;
            this.sbDescartar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbDescartar.Location = new System.Drawing.Point(208, 523);
            this.sbDescartar.Name = "sbDescartar";
            this.sbDescartar.Size = new System.Drawing.Size(193, 45);
            this.sbDescartar.TabIndex = 17;
            this.sbDescartar.TabStop = false;
            this.sbDescartar.Text = "F3 - Descarta Item";
            this.sbDescartar.Click += new System.EventHandler(this.sbDescartar_Click);
            // 
            // lkbProduto
            // 
            this.lkbProduto.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.lkbProduto.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.lkbProduto.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbProduto.Appearance.ForeColor = System.Drawing.Color.White;
            this.lkbProduto.Appearance.Options.UseBackColor = true;
            this.lkbProduto.Appearance.Options.UseFont = true;
            this.lkbProduto.Appearance.Options.UseForeColor = true;
            this.lkbProduto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lkbProduto.Location = new System.Drawing.Point(9, 574);
            this.lkbProduto.Lookup = null;
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(193, 45);
            this.lkbProduto.SubForm = null;
            this.lkbProduto.SubFormType = null;
            this.lkbProduto.SubFormTypeParams = null;
            this.lkbProduto.TabIndex = 7;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "F5 - Produtos";
            this.lkbProduto.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // sbVendedor
            // 
            this.sbVendedor.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbVendedor.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbVendedor.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbVendedor.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbVendedor.Appearance.Options.UseBackColor = true;
            this.sbVendedor.Appearance.Options.UseFont = true;
            this.sbVendedor.Appearance.Options.UseForeColor = true;
            this.sbVendedor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbVendedor.Location = new System.Drawing.Point(9, 625);
            this.sbVendedor.Name = "sbVendedor";
            this.sbVendedor.Size = new System.Drawing.Size(193, 42);
            this.sbVendedor.TabIndex = 15;
            this.sbVendedor.TabStop = false;
            this.sbVendedor.Text = "F8 - Vendedor";
            this.sbVendedor.Click += new System.EventHandler(this.sbVendedor_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl2.Location = new System.Drawing.Point(208, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 18);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Descrição";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // sbPreco
            // 
            this.sbPreco.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbPreco.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbPreco.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbPreco.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbPreco.Appearance.Options.UseBackColor = true;
            this.sbPreco.Appearance.Options.UseFont = true;
            this.sbPreco.Appearance.Options.UseForeColor = true;
            this.sbPreco.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbPreco.Location = new System.Drawing.Point(407, 523);
            this.sbPreco.Lookup = null;
            this.sbPreco.Name = "sbPreco";
            this.sbPreco.Size = new System.Drawing.Size(193, 45);
            this.sbPreco.SubForm = null;
            this.sbPreco.SubFormType = null;
            this.sbPreco.SubFormTypeParams = null;
            this.sbPreco.TabIndex = 20;
            this.sbPreco.TabStop = false;
            this.sbPreco.Text = "F4 - Consulta Preço";
            this.sbPreco.Click += new System.EventHandler(this.sbPreco_Click);
            // 
            // SbQuantidade
            // 
            this.SbQuantidade.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.SbQuantidade.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.SbQuantidade.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbQuantidade.Appearance.ForeColor = System.Drawing.Color.White;
            this.SbQuantidade.Appearance.Options.UseBackColor = true;
            this.SbQuantidade.Appearance.Options.UseFont = true;
            this.SbQuantidade.Appearance.Options.UseForeColor = true;
            this.SbQuantidade.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.SbQuantidade.Location = new System.Drawing.Point(9, 523);
            this.SbQuantidade.Name = "SbQuantidade";
            this.SbQuantidade.Size = new System.Drawing.Size(193, 45);
            this.SbQuantidade.TabIndex = 21;
            this.SbQuantidade.TabStop = false;
            this.SbQuantidade.Text = "F2 - Quantidade";
            this.SbQuantidade.Click += new System.EventHandler(this.SbQuantidade_Click);
            // 
            // sbCPF
            // 
            this.sbCPF.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbCPF.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.sbCPF.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCPF.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbCPF.Appearance.Options.UseBackColor = true;
            this.sbCPF.Appearance.Options.UseFont = true;
            this.sbCPF.Appearance.Options.UseForeColor = true;
            this.sbCPF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbCPF.Location = new System.Drawing.Point(208, 574);
            this.sbCPF.Name = "sbCPF";
            this.sbCPF.Size = new System.Drawing.Size(193, 45);
            this.sbCPF.TabIndex = 22;
            this.sbCPF.TabStop = false;
            this.sbCPF.Text = "F6 - Informar CPF";
            this.sbCPF.Click += new System.EventHandler(this.sbCPF_Click);
            // 
            // imagemEmpresa
            // 
            this.imagemEmpresa.Location = new System.Drawing.Point(522, 154);
            this.imagemEmpresa.Name = "imagemEmpresa";
            this.imagemEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imagemEmpresa.Properties.Appearance.Options.UseBackColor = true;
            this.imagemEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.imagemEmpresa.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imagemEmpresa.Size = new System.Drawing.Size(67, 63);
            this.imagemEmpresa.TabIndex = 23;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl6.Location = new System.Drawing.Point(623, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 15);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Vendedor:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(696, 16);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(0, 16);
            this.labelControl7.TabIndex = 25;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(696, 50);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(0, 16);
            this.labelControl8.TabIndex = 26;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl9.LineVisible = true;
            this.labelControl9.Location = new System.Drawing.Point(696, 33);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(0, 16);
            this.labelControl9.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl10.Location = new System.Drawing.Point(623, 28);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(26, 15);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "CPF:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl11.Location = new System.Drawing.Point(623, 8);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 15);
            this.labelControl11.TabIndex = 29;
            this.labelControl11.Text = "Cliente:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.lblData.Location = new System.Drawing.Point(911, 47);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(17, 18);
            this.lblData.TabIndex = 30;
            this.lblData.Text = "a";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(208, 625);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(193, 45);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "Botão Teste";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl12.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl12.Location = new System.Drawing.Point(218, 5);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(54, 18);
            this.labelControl12.TabIndex = 32;
            this.labelControl12.Text = "Código";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.lblHora.Location = new System.Drawing.Point(1066, 48);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(17, 18);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "a";
            // 
            // FormFrenteCaixaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicacao.Properties.Resources.Cwork_Gestão_Light__Tela_2_2019;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1188, 697);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.imagemEmpresa);
            this.Controls.Add(this.sbCPF);
            this.Controls.Add(this.SbQuantidade);
            this.Controls.Add(this.sbPreco);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.sbVendedor);
            this.Controls.Add(this.txtPercDesconto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.sbCliente);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.sbDescartar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lkbProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sbFinalizarVenda);
            this.Controls.Add(this.lkpProduto);
            this.Controls.Add(this.imagemProduto);
            this.Controls.Add(this.devMemoListaItens);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFrenteCaixaNota";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frente de Caixa";
            this.Load += new System.EventHandler(this.FormFrenteCaixaNota_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFrenteCaixaNota_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemoListaItens.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemEmpresa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErroProvider;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAlteraQuantidadeProduto;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCarregarProdutos;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCarregarVendedores;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCarregarClientes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDescartarUltimoItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFinalizarVenda;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.DevMemoEdit devMemoListaItens;
        private DevExpress.XtraEditors.SimpleButton sbVendedor;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPercDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton sbCliente;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPreco;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbDescartar;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNomeProduto;
        private DevExpress.XtraEditors.SimpleButton sbFinalizarVenda;
        private Cwork.Utilitarios.Componentes.DevTextEdit lkpProduto;
        private DevExpress.XtraEditors.PictureEdit imagemProduto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton sbPreco;
        private DevExpress.XtraEditors.PictureEdit imagemEmpresa;
        private DevExpress.XtraEditors.SimpleButton sbCPF;
        private DevExpress.XtraEditors.SimpleButton SbQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
    }
}