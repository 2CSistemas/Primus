namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaDeliveryMonitor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TXT_Filtro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMB_TipoFiltro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CKB_FINALIZADO = new System.Windows.Forms.CheckBox();
            this.CKB_CANCELADO = new System.Windows.Forms.CheckBox();
            this.CKB_ENTREGA = new System.Windows.Forms.CheckBox();
            this.CKB_PREPARACAO = new System.Windows.Forms.CheckBox();
            this.CKB_PENDENTE = new System.Windows.Forms.CheckBox();
            this.CKB_ABERTO = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_FIM = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_INICIO = new System.Windows.Forms.DateTimePicker();
            this.sbPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LayoutContorl = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_Fechar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.TXT_Filtro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CMB_TipoFiltro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CKB_FINALIZADO);
            this.groupBox1.Controls.Add(this.CKB_CANCELADO);
            this.groupBox1.Controls.Add(this.CKB_ENTREGA);
            this.groupBox1.Controls.Add(this.CKB_PREPARACAO);
            this.groupBox1.Controls.Add(this.CKB_PENDENTE);
            this.groupBox1.Controls.Add(this.CKB_ABERTO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_FIM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_INICIO);
            this.groupBox1.Controls.Add(this.sbPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 109);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(799, 67);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(73, 30);
            this.simpleButton1.TabIndex = 54;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "LIMPAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TXT_Filtro
            // 
            this.TXT_Filtro.Location = new System.Drawing.Point(298, 68);
            this.TXT_Filtro.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TXT_Filtro.Name = "TXT_Filtro";
            this.TXT_Filtro.Size = new System.Drawing.Size(498, 29);
            this.TXT_Filtro.TabIndex = 53;
            this.TXT_Filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_Filtro_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Filtro:";
            // 
            // CMB_TipoFiltro
            // 
            this.CMB_TipoFiltro.FormattingEnabled = true;
            this.CMB_TipoFiltro.Items.AddRange(new object[] {
            "Cliente",
            "Entregador",
            "Todos"});
            this.CMB_TipoFiltro.Location = new System.Drawing.Point(96, 67);
            this.CMB_TipoFiltro.Name = "CMB_TipoFiltro";
            this.CMB_TipoFiltro.Size = new System.Drawing.Size(141, 30);
            this.CMB_TipoFiltro.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tipo:";
            // 
            // CKB_FINALIZADO
            // 
            this.CKB_FINALIZADO.AutoSize = true;
            this.CKB_FINALIZADO.Checked = true;
            this.CKB_FINALIZADO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_FINALIZADO.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_FINALIZADO.Location = new System.Drawing.Point(707, 42);
            this.CKB_FINALIZADO.Name = "CKB_FINALIZADO";
            this.CKB_FINALIZADO.Size = new System.Drawing.Size(87, 22);
            this.CKB_FINALIZADO.TabIndex = 49;
            this.CKB_FINALIZADO.Text = "Finalizado";
            this.CKB_FINALIZADO.UseVisualStyleBackColor = true;
            // 
            // CKB_CANCELADO
            // 
            this.CKB_CANCELADO.AutoSize = true;
            this.CKB_CANCELADO.Checked = true;
            this.CKB_CANCELADO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_CANCELADO.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_CANCELADO.Location = new System.Drawing.Point(707, 21);
            this.CKB_CANCELADO.Name = "CKB_CANCELADO";
            this.CKB_CANCELADO.Size = new System.Drawing.Size(89, 22);
            this.CKB_CANCELADO.TabIndex = 48;
            this.CKB_CANCELADO.Text = "Cancelado";
            this.CKB_CANCELADO.UseVisualStyleBackColor = true;
            // 
            // CKB_ENTREGA
            // 
            this.CKB_ENTREGA.AutoSize = true;
            this.CKB_ENTREGA.Checked = true;
            this.CKB_ENTREGA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_ENTREGA.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_ENTREGA.Location = new System.Drawing.Point(584, 42);
            this.CKB_ENTREGA.Name = "CKB_ENTREGA";
            this.CKB_ENTREGA.Size = new System.Drawing.Size(95, 22);
            this.CKB_ENTREGA.TabIndex = 47;
            this.CKB_ENTREGA.Text = "Em Entrega";
            this.CKB_ENTREGA.UseVisualStyleBackColor = true;
            // 
            // CKB_PREPARACAO
            // 
            this.CKB_PREPARACAO.AutoSize = true;
            this.CKB_PREPARACAO.Checked = true;
            this.CKB_PREPARACAO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_PREPARACAO.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_PREPARACAO.Location = new System.Drawing.Point(584, 21);
            this.CKB_PREPARACAO.Name = "CKB_PREPARACAO";
            this.CKB_PREPARACAO.Size = new System.Drawing.Size(117, 22);
            this.CKB_PREPARACAO.TabIndex = 46;
            this.CKB_PREPARACAO.Text = "Em Preparação";
            this.CKB_PREPARACAO.UseVisualStyleBackColor = true;
            // 
            // CKB_PENDENTE
            // 
            this.CKB_PENDENTE.AutoSize = true;
            this.CKB_PENDENTE.Checked = true;
            this.CKB_PENDENTE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_PENDENTE.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_PENDENTE.Location = new System.Drawing.Point(493, 42);
            this.CKB_PENDENTE.Name = "CKB_PENDENTE";
            this.CKB_PENDENTE.Size = new System.Drawing.Size(85, 22);
            this.CKB_PENDENTE.TabIndex = 45;
            this.CKB_PENDENTE.Text = "Pendente";
            this.CKB_PENDENTE.UseVisualStyleBackColor = true;
            // 
            // CKB_ABERTO
            // 
            this.CKB_ABERTO.AutoSize = true;
            this.CKB_ABERTO.Checked = true;
            this.CKB_ABERTO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_ABERTO.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_ABERTO.Location = new System.Drawing.Point(493, 21);
            this.CKB_ABERTO.Name = "CKB_ABERTO";
            this.CKB_ABERTO.Size = new System.Drawing.Size(68, 22);
            this.CKB_ABERTO.TabIndex = 44;
            this.CKB_ABERTO.Text = "Aberto";
            this.CKB_ABERTO.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Status:";
            // 
            // TXT_FIM
            // 
            this.TXT_FIM.CalendarFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_FIM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXT_FIM.Location = new System.Drawing.Point(280, 31);
            this.TXT_FIM.Name = "TXT_FIM";
            this.TXT_FIM.Size = new System.Drawing.Size(141, 29);
            this.TXT_FIM.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Período:";
            // 
            // TXT_INICIO
            // 
            this.TXT_INICIO.CalendarFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXT_INICIO.Location = new System.Drawing.Point(96, 31);
            this.TXT_INICIO.Name = "TXT_INICIO";
            this.TXT_INICIO.Size = new System.Drawing.Size(141, 29);
            this.TXT_INICIO.TabIndex = 34;
            // 
            // sbPesquisar
            // 
            this.sbPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbPesquisar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbPesquisar.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbPesquisar.Appearance.BorderColor = System.Drawing.Color.Green;
            this.sbPesquisar.Appearance.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.sbPesquisar.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbPesquisar.Appearance.Options.UseBackColor = true;
            this.sbPesquisar.Appearance.Options.UseBorderColor = true;
            this.sbPesquisar.Appearance.Options.UseFont = true;
            this.sbPesquisar.Appearance.Options.UseForeColor = true;
            this.sbPesquisar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbPesquisar.Location = new System.Drawing.Point(986, 20);
            this.sbPesquisar.Name = "sbPesquisar";
            this.sbPesquisar.Size = new System.Drawing.Size(160, 80);
            this.sbPesquisar.TabIndex = 33;
            this.sbPesquisar.TabStop = false;
            this.sbPesquisar.Text = "PESQUISAR";
            this.sbPesquisar.Click += new System.EventHandler(this.sbPesquisar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.LayoutContorl);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1155, 502);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RELAÇÃO DE PEDIDOS DO DELIVERY";
            // 
            // LayoutContorl
            // 
            this.LayoutContorl.AutoScroll = true;
            this.LayoutContorl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutContorl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutContorl.Location = new System.Drawing.Point(3, 25);
            this.LayoutContorl.Name = "LayoutContorl";
            this.LayoutContorl.Size = new System.Drawing.Size(1149, 474);
            this.LayoutContorl.TabIndex = 0;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton5.Location = new System.Drawing.Point(338, 635);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(156, 33);
            this.simpleButton5.TabIndex = 41;
            this.simpleButton5.TabStop = false;
            this.simpleButton5.Text = "FINALIZAR";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.Location = new System.Drawing.Point(176, 635);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(156, 33);
            this.simpleButton2.TabIndex = 42;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "IMPRIMIR";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton3.Location = new System.Drawing.Point(14, 635);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(156, 33);
            this.simpleButton3.TabIndex = 43;
            this.simpleButton3.TabStop = false;
            this.simpleButton3.Text = "ENVIAR NFC-E";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BTN_Fechar
            // 
            this.BTN_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Fechar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.BTN_Fechar.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.BTN_Fechar.Appearance.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.BTN_Fechar.Appearance.ForeColor = System.Drawing.Color.White;
            this.BTN_Fechar.Appearance.Options.UseBackColor = true;
            this.BTN_Fechar.Appearance.Options.UseFont = true;
            this.BTN_Fechar.Appearance.Options.UseForeColor = true;
            this.BTN_Fechar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.BTN_Fechar.Location = new System.Drawing.Point(1011, 635);
            this.BTN_Fechar.Name = "BTN_Fechar";
            this.BTN_Fechar.Size = new System.Drawing.Size(156, 33);
            this.BTN_Fechar.TabIndex = 44;
            this.BTN_Fechar.TabStop = false;
            this.BTN_Fechar.Text = "FECHAR";
            this.BTN_Fechar.Click += new System.EventHandler(this.BTN_Fechar_Click);
            // 
            // FormFrenteCaixaDeliveryMonitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 680);
            this.Controls.Add(this.BTN_Fechar);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFrenteCaixaDeliveryMonitor";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONITORAMENTO DOS PEDIDOS DELIVERY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbPesquisar;
        private System.Windows.Forms.FlowLayoutPanel LayoutContorl;
        private System.Windows.Forms.DateTimePicker TXT_FIM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TXT_INICIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CKB_PENDENTE;
        private System.Windows.Forms.CheckBox CKB_ABERTO;
        private System.Windows.Forms.CheckBox CKB_ENTREGA;
        private System.Windows.Forms.CheckBox CKB_PREPARACAO;
        private System.Windows.Forms.CheckBox CKB_FINALIZADO;
        private System.Windows.Forms.CheckBox CKB_CANCELADO;
        private System.Windows.Forms.ComboBox CMB_TipoFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Filtro;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton BTN_Fechar;
    }
}