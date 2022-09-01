namespace Aplicacao.Modulos.Comercial.ControlUser
{
    partial class UC_PedidoDelivery
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TXT_VENDEDOR = new System.Windows.Forms.Label();
            this.TXT_NOTAFISCAL = new System.Windows.Forms.Label();
            this.TXT_DATAHORA = new System.Windows.Forms.Label();
            this.TXT_VALOR = new System.Windows.Forms.Label();
            this.TXT_SAIUENTREGA = new System.Windows.Forms.Label();
            this.TXT_TEMPORIZADOR = new System.Windows.Forms.Label();
            this.TXT_ENTREGADOR = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sbFinalizar = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimr = new DevExpress.XtraEditors.SimpleButton();
            this.TXT_STATUS = new System.Windows.Forms.Label();
            this.sbAtualizarStatus = new DevExpress.XtraEditors.SimpleButton();
            this.sbNFCe = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_CHEGADAENTREGA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TXT_CODIGO = new System.Windows.Forms.Label();
            this.CKB_Selecionado = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_VENDEDOR
            // 
            this.TXT_VENDEDOR.AutoSize = true;
            this.TXT_VENDEDOR.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VENDEDOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_VENDEDOR.Location = new System.Drawing.Point(105, 26);
            this.TXT_VENDEDOR.Name = "TXT_VENDEDOR";
            this.TXT_VENDEDOR.Size = new System.Drawing.Size(72, 17);
            this.TXT_VENDEDOR.TabIndex = 1;
            this.TXT_VENDEDOR.Text = "VENDEDOR";
            this.TXT_VENDEDOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_NOTAFISCAL
            // 
            this.TXT_NOTAFISCAL.AutoSize = true;
            this.TXT_NOTAFISCAL.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOTAFISCAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_NOTAFISCAL.Location = new System.Drawing.Point(114, 45);
            this.TXT_NOTAFISCAL.Name = "TXT_NOTAFISCAL";
            this.TXT_NOTAFISCAL.Size = new System.Drawing.Size(82, 17);
            this.TXT_NOTAFISCAL.TabIndex = 3;
            this.TXT_NOTAFISCAL.Text = "NOTA FISCAL";
            this.TXT_NOTAFISCAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_DATAHORA
            // 
            this.TXT_DATAHORA.AutoSize = true;
            this.TXT_DATAHORA.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DATAHORA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_DATAHORA.Location = new System.Drawing.Point(394, 27);
            this.TXT_DATAHORA.Name = "TXT_DATAHORA";
            this.TXT_DATAHORA.Size = new System.Drawing.Size(77, 17);
            this.TXT_DATAHORA.TabIndex = 4;
            this.TXT_DATAHORA.Text = "DATA/HORA";
            this.TXT_DATAHORA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_VALOR
            // 
            this.TXT_VALOR.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VALOR.ForeColor = System.Drawing.Color.Green;
            this.TXT_VALOR.Location = new System.Drawing.Point(944, 15);
            this.TXT_VALOR.Name = "TXT_VALOR";
            this.TXT_VALOR.Size = new System.Drawing.Size(150, 48);
            this.TXT_VALOR.TabIndex = 6;
            this.TXT_VALOR.Text = "VALOR";
            this.TXT_VALOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_SAIUENTREGA
            // 
            this.TXT_SAIUENTREGA.AutoSize = true;
            this.TXT_SAIUENTREGA.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SAIUENTREGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_SAIUENTREGA.Location = new System.Drawing.Point(414, 44);
            this.TXT_SAIUENTREGA.Name = "TXT_SAIUENTREGA";
            this.TXT_SAIUENTREGA.Size = new System.Drawing.Size(89, 17);
            this.TXT_SAIUENTREGA.TabIndex = 7;
            this.TXT_SAIUENTREGA.Text = "SAIUENTREGA";
            this.TXT_SAIUENTREGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_TEMPORIZADOR
            // 
            this.TXT_TEMPORIZADOR.AutoSize = true;
            this.TXT_TEMPORIZADOR.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TEMPORIZADOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_TEMPORIZADOR.Location = new System.Drawing.Point(826, 44);
            this.TXT_TEMPORIZADOR.Name = "TXT_TEMPORIZADOR";
            this.TXT_TEMPORIZADOR.Size = new System.Drawing.Size(99, 17);
            this.TXT_TEMPORIZADOR.TabIndex = 8;
            this.TXT_TEMPORIZADOR.Text = "TEMPORIZADOR";
            this.TXT_TEMPORIZADOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_ENTREGADOR
            // 
            this.TXT_ENTREGADOR.AutoSize = true;
            this.TXT_ENTREGADOR.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ENTREGADOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_ENTREGADOR.Location = new System.Drawing.Point(611, 27);
            this.TXT_ENTREGADOR.Name = "TXT_ENTREGADOR";
            this.TXT_ENTREGADOR.Size = new System.Drawing.Size(87, 17);
            this.TXT_ENTREGADOR.TabIndex = 9;
            this.TXT_ENTREGADOR.Text = "ENTREGADOR";
            this.TXT_ENTREGADOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sbFinalizar
            // 
            this.sbFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFinalizar.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.sbFinalizar.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.sbFinalizar.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.sbFinalizar.Appearance.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbFinalizar.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbFinalizar.Appearance.Options.UseBackColor = true;
            this.sbFinalizar.Appearance.Options.UseBorderColor = true;
            this.sbFinalizar.Appearance.Options.UseFont = true;
            this.sbFinalizar.Appearance.Options.UseForeColor = true;
            this.sbFinalizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbFinalizar.Location = new System.Drawing.Point(362, 66);
            this.sbFinalizar.Name = "sbFinalizar";
            this.sbFinalizar.Size = new System.Drawing.Size(122, 21);
            this.sbFinalizar.TabIndex = 39;
            this.sbFinalizar.TabStop = false;
            this.sbFinalizar.Text = "FINALIZAR PEDIDO";
            this.sbFinalizar.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // sbImprimr
            // 
            this.sbImprimr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimr.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.sbImprimr.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.sbImprimr.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.sbImprimr.Appearance.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbImprimr.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbImprimr.Appearance.Options.UseBackColor = true;
            this.sbImprimr.Appearance.Options.UseBorderColor = true;
            this.sbImprimr.Appearance.Options.UseFont = true;
            this.sbImprimr.Appearance.Options.UseForeColor = true;
            this.sbImprimr.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbImprimr.Location = new System.Drawing.Point(489, 66);
            this.sbImprimr.Name = "sbImprimr";
            this.sbImprimr.Size = new System.Drawing.Size(122, 21);
            this.sbImprimr.TabIndex = 38;
            this.sbImprimr.TabStop = false;
            this.sbImprimr.Text = "IMPRIMIR PEDIDO";
            this.sbImprimr.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // TXT_STATUS
            // 
            this.TXT_STATUS.AutoSize = true;
            this.TXT_STATUS.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_STATUS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_STATUS.Location = new System.Drawing.Point(84, 67);
            this.TXT_STATUS.Name = "TXT_STATUS";
            this.TXT_STATUS.Size = new System.Drawing.Size(72, 17);
            this.TXT_STATUS.TabIndex = 37;
            this.TXT_STATUS.Text = "VENDEDOR";
            this.TXT_STATUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbAtualizarStatus
            // 
            this.sbAtualizarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAtualizarStatus.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.sbAtualizarStatus.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.sbAtualizarStatus.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.sbAtualizarStatus.Appearance.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAtualizarStatus.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbAtualizarStatus.Appearance.Options.UseBackColor = true;
            this.sbAtualizarStatus.Appearance.Options.UseBorderColor = true;
            this.sbAtualizarStatus.Appearance.Options.UseFont = true;
            this.sbAtualizarStatus.Appearance.Options.UseForeColor = true;
            this.sbAtualizarStatus.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbAtualizarStatus.Location = new System.Drawing.Point(814, 66);
            this.sbAtualizarStatus.Name = "sbAtualizarStatus";
            this.sbAtualizarStatus.Size = new System.Drawing.Size(126, 21);
            this.sbAtualizarStatus.TabIndex = 36;
            this.sbAtualizarStatus.TabStop = false;
            this.sbAtualizarStatus.Text = "ATUALIZAR STATUS";
            this.sbAtualizarStatus.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // sbNFCe
            // 
            this.sbNFCe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbNFCe.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.sbNFCe.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.sbNFCe.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.sbNFCe.Appearance.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbNFCe.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbNFCe.Appearance.Options.UseBackColor = true;
            this.sbNFCe.Appearance.Options.UseBorderColor = true;
            this.sbNFCe.Appearance.Options.UseFont = true;
            this.sbNFCe.Appearance.Options.UseForeColor = true;
            this.sbNFCe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbNFCe.Location = new System.Drawing.Point(745, 66);
            this.sbNFCe.Name = "sbNFCe";
            this.sbNFCe.Size = new System.Drawing.Size(63, 21);
            this.sbNFCe.TabIndex = 35;
            this.sbNFCe.TabStop = false;
            this.sbNFCe.Text = "NFC-e";
            this.sbNFCe.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.sbCancelar.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.sbCancelar.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.sbCancelar.Appearance.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCancelar.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbCancelar.Appearance.Options.UseBackColor = true;
            this.sbCancelar.Appearance.Options.UseBorderColor = true;
            this.sbCancelar.Appearance.Options.UseFont = true;
            this.sbCancelar.Appearance.Options.UseForeColor = true;
            this.sbCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbCancelar.Location = new System.Drawing.Point(617, 66);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(122, 21);
            this.sbCancelar.TabIndex = 34;
            this.sbCancelar.TabStop = false;
            this.sbCancelar.Text = "CANCELAR PEDIDO";
            this.sbCancelar.Click += new System.EventHandler(this.sbPesquisar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(24, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Status:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(763, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tempo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_CHEGADAENTREGA
            // 
            this.TXT_CHEGADAENTREGA.AutoSize = true;
            this.TXT_CHEGADAENTREGA.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CHEGADAENTREGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_CHEGADAENTREGA.Location = new System.Drawing.Point(611, 44);
            this.TXT_CHEGADAENTREGA.Name = "TXT_CHEGADAENTREGA";
            this.TXT_CHEGADAENTREGA.Size = new System.Drawing.Size(146, 17);
            this.TXT_CHEGADAENTREGA.TabIndex = 15;
            this.TXT_CHEGADAENTREGA.Text = "TXT_CHEGADAENTREGA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(537, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chegada:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(24, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nota Fiscal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(307, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Saida Entrega:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(520, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Entregador:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(307, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data/Hora:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.TXT_CODIGO);
            this.panel1.Controls.Add(this.sbFinalizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sbImprimr);
            this.panel1.Controls.Add(this.TXT_DATAHORA);
            this.panel1.Controls.Add(this.TXT_STATUS);
            this.panel1.Controls.Add(this.TXT_VENDEDOR);
            this.panel1.Controls.Add(this.sbAtualizarStatus);
            this.panel1.Controls.Add(this.TXT_VALOR);
            this.panel1.Controls.Add(this.sbNFCe);
            this.panel1.Controls.Add(this.TXT_ENTREGADOR);
            this.panel1.Controls.Add(this.sbCancelar);
            this.panel1.Controls.Add(this.TXT_NOTAFISCAL);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TXT_CHEGADAENTREGA);
            this.panel1.Controls.Add(this.TXT_SAIUENTREGA);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TXT_TEMPORIZADOR);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(22, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 92);
            this.panel1.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(946, 66);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 21);
            this.simpleButton1.TabIndex = 41;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "DETALHAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // TXT_CODIGO
            // 
            this.TXT_CODIGO.AutoSize = true;
            this.TXT_CODIGO.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CODIGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_CODIGO.Location = new System.Drawing.Point(11, -3);
            this.TXT_CODIGO.Name = "TXT_CODIGO";
            this.TXT_CODIGO.Size = new System.Drawing.Size(85, 20);
            this.TXT_CODIGO.TabIndex = 40;
            this.TXT_CODIGO.Text = "Vendedor:";
            this.TXT_CODIGO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CKB_Selecionado
            // 
            this.CKB_Selecionado.AutoSize = true;
            this.CKB_Selecionado.Location = new System.Drawing.Point(5, 42);
            this.CKB_Selecionado.Name = "CKB_Selecionado";
            this.CKB_Selecionado.Size = new System.Drawing.Size(15, 14);
            this.CKB_Selecionado.TabIndex = 14;
            this.CKB_Selecionado.UseVisualStyleBackColor = true;
            // 
            // UC_PedidoDelivery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CKB_Selecionado);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1100, 200);
            this.MinimumSize = new System.Drawing.Size(1100, 0);
            this.Name = "UC_PedidoDelivery";
            this.Size = new System.Drawing.Size(1100, 98);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TXT_VENDEDOR;
        private System.Windows.Forms.Label TXT_NOTAFISCAL;
        private System.Windows.Forms.Label TXT_DATAHORA;
        private System.Windows.Forms.Label TXT_VALOR;
        private System.Windows.Forms.Label TXT_SAIUENTREGA;
        private System.Windows.Forms.Label TXT_TEMPORIZADOR;
        private System.Windows.Forms.Label TXT_ENTREGADOR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TXT_CHEGADAENTREGA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraEditors.SimpleButton sbAtualizarStatus;
        private DevExpress.XtraEditors.SimpleButton sbNFCe;
        private System.Windows.Forms.Label TXT_STATUS;
        private DevExpress.XtraEditors.SimpleButton sbImprimr;
        private DevExpress.XtraEditors.SimpleButton sbFinalizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TXT_CODIGO;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public System.Windows.Forms.CheckBox CKB_Selecionado;
    }
}
