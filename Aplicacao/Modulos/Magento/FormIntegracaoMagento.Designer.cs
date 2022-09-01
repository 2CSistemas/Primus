namespace Aplicacao.Modulos.Utilitarios
{
    partial class FormIntegracaoMagento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntegracaoMagento));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbImportar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcModulos = new DevExpress.XtraEditors.GroupControl();
            this.txtPedido = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.chPedidoUnico = new DevExpress.XtraEditors.CheckEdit();
            this.lblPedido = new System.Windows.Forms.Label();
            this.chProduto = new DevExpress.XtraEditors.CheckEdit();
            this.chCliente = new DevExpress.XtraEditors.CheckEdit();
            this.chPedido = new DevExpress.XtraEditors.CheckEdit();
            this.progressBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.txtContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcModulos)).BeginInit();
            this.gcModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPedidoUnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 86);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbImportar
            // 
            this.sbImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImportar.Image = ((System.Drawing.Image)(resources.GetObject("sbImportar.Image")));
            this.sbImportar.ImageIndex = 1;
            this.sbImportar.Location = new System.Drawing.Point(384, 86);
            this.sbImportar.Name = "sbImportar";
            this.sbImportar.Size = new System.Drawing.Size(75, 23);
            this.sbImportar.TabIndex = 1;
            this.sbImportar.Text = "&Importar";
            this.sbImportar.Click += new System.EventHandler(this.sbImportar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(465, 86);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(528, 68);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcModulos);
            this.xtraTabPage1.Controls.Add(this.progressBar);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(522, 62);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcModulos
            // 
            this.gcModulos.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gcModulos.Appearance.Options.UseBackColor = true;
            this.gcModulos.Controls.Add(this.txtPedido);
            this.gcModulos.Controls.Add(this.chPedidoUnico);
            this.gcModulos.Controls.Add(this.lblPedido);
            this.gcModulos.Controls.Add(this.chProduto);
            this.gcModulos.Controls.Add(this.chCliente);
            this.gcModulos.Controls.Add(this.chPedido);
            this.gcModulos.Location = new System.Drawing.Point(5, 3);
            this.gcModulos.Name = "gcModulos";
            this.gcModulos.Size = new System.Drawing.Size(511, 52);
            this.gcModulos.TabIndex = 76;
            this.gcModulos.Text = "Módulos";
            // 
            // txtPedido
            // 
            this.txtPedido.CwkFuncaoValidacao = null;
            this.txtPedido.CwkMascara = null;
            this.txtPedido.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtPedido.Location = new System.Drawing.Point(423, 26);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Properties.MaxLength = 60;
            this.txtPedido.SelecionarTextoOnEnter = false;
            this.txtPedido.Size = new System.Drawing.Size(80, 20);
            this.txtPedido.TabIndex = 13;
            this.txtPedido.Visible = false;
            // 
            // chPedidoUnico
            // 
            this.chPedidoUnico.CausesValidation = false;
            this.chPedidoUnico.Location = new System.Drawing.Point(196, 27);
            this.chPedidoUnico.Name = "chPedidoUnico";
            this.chPedidoUnico.Properties.Caption = "Pedido único";
            this.chPedidoUnico.Size = new System.Drawing.Size(82, 19);
            this.chPedidoUnico.TabIndex = 12;
            this.chPedidoUnico.Visible = false;
            this.chPedidoUnico.Click += new System.EventHandler(this.chPedidoUnico_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(398, 29);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(21, 13);
            this.lblPedido.TabIndex = 10;
            this.lblPedido.Text = "ID:";
            this.lblPedido.Visible = false;
            // 
            // chProduto
            // 
            this.chProduto.CausesValidation = false;
            this.chProduto.Location = new System.Drawing.Point(7, 27);
            this.chProduto.Name = "chProduto";
            this.chProduto.Properties.Caption = "Produto";
            this.chProduto.Size = new System.Drawing.Size(61, 19);
            this.chProduto.TabIndex = 7;
            // 
            // chCliente
            // 
            this.chCliente.CausesValidation = false;
            this.chCliente.Location = new System.Drawing.Point(74, 27);
            this.chCliente.Name = "chCliente";
            this.chCliente.Properties.Caption = "Cliente";
            this.chCliente.Size = new System.Drawing.Size(57, 19);
            this.chCliente.TabIndex = 8;
            // 
            // chPedido
            // 
            this.chPedido.CausesValidation = false;
            this.chPedido.Location = new System.Drawing.Point(137, 27);
            this.chPedido.Name = "chPedido";
            this.chPedido.Properties.Caption = "Pedido";
            this.chPedido.Size = new System.Drawing.Size(60, 19);
            this.chPedido.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.EditValue = "Aguarde...";
            this.progressBar.Location = new System.Drawing.Point(5, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.progressBar.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.progressBar.Properties.EndColor = System.Drawing.Color.Lime;
            this.progressBar.Properties.MarqueeAnimationSpeed = 50;
            this.progressBar.Properties.ShowTitle = true;
            this.progressBar.Properties.StartColor = System.Drawing.Color.Lime;
            this.progressBar.Size = new System.Drawing.Size(511, 52);
            this.progressBar.TabIndex = 75;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // txtContador
            // 
            this.txtContador.AutoSize = true;
            this.txtContador.Location = new System.Drawing.Point(96, 91);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(0, 13);
            this.txtContador.TabIndex = 4;
            // 
            // FormIntegracaoMagento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 121);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbImportar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormIntegracaoMagento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integração Magento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIntegracaoMagento_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormIntegracaoMagento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcModulos)).EndInit();
            this.gcModulos.ResumeLayout(false);
            this.gcModulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPedidoUnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbImportar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.Label txtContador;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBar;
        private DevExpress.XtraEditors.GroupControl gcModulos;
        private DevExpress.XtraEditors.CheckEdit chPedidoUnico;
        private System.Windows.Forms.Label lblPedido;
        private DevExpress.XtraEditors.CheckEdit chProduto;
        private DevExpress.XtraEditors.CheckEdit chCliente;
        private DevExpress.XtraEditors.CheckEdit chPedido;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPedido;
    }
}