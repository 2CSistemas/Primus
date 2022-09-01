namespace Aplicacao.DashBoard
{
    partial class FormDashBoardComparativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashBoardComparativo));
            this.dateTime_MesInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTime_MesFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.icoSair = new FontAwesome.Sharp.IconButton();
            this.icoPDV = new FontAwesome.Sharp.IconButton();
            this.icoOrdemServico = new FontAwesome.Sharp.IconButton();
            this.icoPedidos = new FontAwesome.Sharp.IconButton();
            this.icoEmissaoNotas = new FontAwesome.Sharp.IconButton();
            this.icoDelivery = new FontAwesome.Sharp.IconButton();
            this.icoContasFinanceiras = new FontAwesome.Sharp.IconButton();
            this.icoCadastrosComparativo = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labTexto = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTime_MesInicial
            // 
            this.dateTime_MesInicial.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTime_MesInicial.CustomFormat = "MM/yyyy";
            this.dateTime_MesInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_MesInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_MesInicial.Location = new System.Drawing.Point(625, 11);
            this.dateTime_MesInicial.Name = "dateTime_MesInicial";
            this.dateTime_MesInicial.Size = new System.Drawing.Size(101, 29);
            this.dateTime_MesInicial.TabIndex = 3;
            // 
            // dateTime_MesFinal
            // 
            this.dateTime_MesFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTime_MesFinal.CustomFormat = "MM/yyyy";
            this.dateTime_MesFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_MesFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_MesFinal.Location = new System.Drawing.Point(864, 10);
            this.dateTime_MesFinal.Name = "dateTime_MesFinal";
            this.dateTime_MesFinal.Size = new System.Drawing.Size(101, 29);
            this.dateTime_MesFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mês Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mês Final:";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.icoSair);
            this.pnlMenu.Controls.Add(this.icoPDV);
            this.pnlMenu.Controls.Add(this.icoOrdemServico);
            this.pnlMenu.Controls.Add(this.icoPedidos);
            this.pnlMenu.Controls.Add(this.icoEmissaoNotas);
            this.pnlMenu.Controls.Add(this.icoDelivery);
            this.pnlMenu.Controls.Add(this.icoContasFinanceiras);
            this.pnlMenu.Controls.Add(this.icoCadastrosComparativo);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 666);
            this.pnlMenu.TabIndex = 2;
            // 
            // icoSair
            // 
            this.icoSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.icoSair.FlatAppearance.BorderSize = 0;
            this.icoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoSair.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoSair.ForeColor = System.Drawing.Color.White;
            this.icoSair.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.icoSair.IconColor = System.Drawing.Color.White;
            this.icoSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoSair.Location = new System.Drawing.Point(0, 623);
            this.icoSair.Name = "icoSair";
            this.icoSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.icoSair.Size = new System.Drawing.Size(230, 43);
            this.icoSair.TabIndex = 8;
            this.icoSair.Text = "   Sair Dashboard";
            this.icoSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoSair.UseVisualStyleBackColor = true;
            this.icoSair.Click += new System.EventHandler(this.icoSair_Click);
            // 
            // icoPDV
            // 
            this.icoPDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoPDV.FlatAppearance.BorderSize = 0;
            this.icoPDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoPDV.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoPDV.ForeColor = System.Drawing.Color.White;
            this.icoPDV.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.icoPDV.IconColor = System.Drawing.Color.White;
            this.icoPDV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoPDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoPDV.Location = new System.Drawing.Point(0, 358);
            this.icoPDV.Name = "icoPDV";
            this.icoPDV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoPDV.Size = new System.Drawing.Size(230, 43);
            this.icoPDV.TabIndex = 7;
            this.icoPDV.Text = "   PDV";
            this.icoPDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoPDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoPDV.UseVisualStyleBackColor = true;
            this.icoPDV.Click += new System.EventHandler(this.icoPDV_Click);
            // 
            // icoOrdemServico
            // 
            this.icoOrdemServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoOrdemServico.FlatAppearance.BorderSize = 0;
            this.icoOrdemServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoOrdemServico.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoOrdemServico.ForeColor = System.Drawing.Color.White;
            this.icoOrdemServico.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.icoOrdemServico.IconColor = System.Drawing.Color.White;
            this.icoOrdemServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoOrdemServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoOrdemServico.Location = new System.Drawing.Point(0, 315);
            this.icoOrdemServico.Name = "icoOrdemServico";
            this.icoOrdemServico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoOrdemServico.Size = new System.Drawing.Size(230, 43);
            this.icoOrdemServico.TabIndex = 6;
            this.icoOrdemServico.Text = "   Ordem Serviço";
            this.icoOrdemServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoOrdemServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoOrdemServico.UseVisualStyleBackColor = true;
            this.icoOrdemServico.Click += new System.EventHandler(this.icoOrdemServico_Click);
            // 
            // icoPedidos
            // 
            this.icoPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoPedidos.FlatAppearance.BorderSize = 0;
            this.icoPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoPedidos.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoPedidos.ForeColor = System.Drawing.Color.White;
            this.icoPedidos.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            this.icoPedidos.IconColor = System.Drawing.Color.White;
            this.icoPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoPedidos.Location = new System.Drawing.Point(0, 272);
            this.icoPedidos.Name = "icoPedidos";
            this.icoPedidos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoPedidos.Size = new System.Drawing.Size(230, 43);
            this.icoPedidos.TabIndex = 5;
            this.icoPedidos.Text = "   Emissão Pedidos";
            this.icoPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoPedidos.UseVisualStyleBackColor = true;
            this.icoPedidos.Click += new System.EventHandler(this.icoPedidos_Click);
            // 
            // icoEmissaoNotas
            // 
            this.icoEmissaoNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoEmissaoNotas.FlatAppearance.BorderSize = 0;
            this.icoEmissaoNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoEmissaoNotas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoEmissaoNotas.ForeColor = System.Drawing.Color.White;
            this.icoEmissaoNotas.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.icoEmissaoNotas.IconColor = System.Drawing.Color.White;
            this.icoEmissaoNotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoEmissaoNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoEmissaoNotas.Location = new System.Drawing.Point(0, 229);
            this.icoEmissaoNotas.Name = "icoEmissaoNotas";
            this.icoEmissaoNotas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoEmissaoNotas.Size = new System.Drawing.Size(230, 43);
            this.icoEmissaoNotas.TabIndex = 4;
            this.icoEmissaoNotas.Text = "   Emissão Notas";
            this.icoEmissaoNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoEmissaoNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoEmissaoNotas.UseVisualStyleBackColor = true;
            this.icoEmissaoNotas.Click += new System.EventHandler(this.icoEmissaoNotas_Click);
            // 
            // icoDelivery
            // 
            this.icoDelivery.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoDelivery.FlatAppearance.BorderSize = 0;
            this.icoDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoDelivery.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoDelivery.ForeColor = System.Drawing.Color.White;
            this.icoDelivery.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.icoDelivery.IconColor = System.Drawing.Color.White;
            this.icoDelivery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoDelivery.Location = new System.Drawing.Point(0, 186);
            this.icoDelivery.Name = "icoDelivery";
            this.icoDelivery.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoDelivery.Size = new System.Drawing.Size(230, 43);
            this.icoDelivery.TabIndex = 3;
            this.icoDelivery.Text = "   Delivery";
            this.icoDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoDelivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoDelivery.UseVisualStyleBackColor = true;
            this.icoDelivery.Click += new System.EventHandler(this.icoDelivery_Click);
            // 
            // icoContasFinanceiras
            // 
            this.icoContasFinanceiras.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoContasFinanceiras.FlatAppearance.BorderSize = 0;
            this.icoContasFinanceiras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoContasFinanceiras.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoContasFinanceiras.ForeColor = System.Drawing.Color.White;
            this.icoContasFinanceiras.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.icoContasFinanceiras.IconColor = System.Drawing.Color.White;
            this.icoContasFinanceiras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoContasFinanceiras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoContasFinanceiras.Location = new System.Drawing.Point(0, 143);
            this.icoContasFinanceiras.Name = "icoContasFinanceiras";
            this.icoContasFinanceiras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoContasFinanceiras.Size = new System.Drawing.Size(230, 43);
            this.icoContasFinanceiras.TabIndex = 2;
            this.icoContasFinanceiras.Text = "   Contas Financeiras";
            this.icoContasFinanceiras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoContasFinanceiras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoContasFinanceiras.UseVisualStyleBackColor = true;
            this.icoContasFinanceiras.Click += new System.EventHandler(this.icoContasFinanceiras_Click);
            // 
            // icoCadastrosComparativo
            // 
            this.icoCadastrosComparativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.icoCadastrosComparativo.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoCadastrosComparativo.FlatAppearance.BorderSize = 0;
            this.icoCadastrosComparativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoCadastrosComparativo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoCadastrosComparativo.ForeColor = System.Drawing.Color.White;
            this.icoCadastrosComparativo.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.icoCadastrosComparativo.IconColor = System.Drawing.Color.White;
            this.icoCadastrosComparativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoCadastrosComparativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoCadastrosComparativo.Location = new System.Drawing.Point(0, 100);
            this.icoCadastrosComparativo.Name = "icoCadastrosComparativo";
            this.icoCadastrosComparativo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoCadastrosComparativo.Size = new System.Drawing.Size(230, 43);
            this.icoCadastrosComparativo.TabIndex = 1;
            this.icoCadastrosComparativo.Text = "   Cadastros";
            this.icoCadastrosComparativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoCadastrosComparativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoCadastrosComparativo.UseVisualStyleBackColor = false;
            this.icoCadastrosComparativo.Click += new System.EventHandler(this.icoCadastrosComparativo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 100);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(194, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 23);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labTexto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTime_MesInicial);
            this.panel2.Controls.Add(this.dateTime_MesFinal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 56);
            this.panel2.TabIndex = 7;
            // 
            // labTexto
            // 
            this.labTexto.AutoSize = true;
            this.labTexto.BackColor = System.Drawing.Color.White;
            this.labTexto.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTexto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labTexto.Location = new System.Drawing.Point(15, 11);
            this.labTexto.Name = "labTexto";
            this.labTexto.Size = new System.Drawing.Size(18, 25);
            this.labTexto.TabIndex = 6;
            this.labTexto.Text = ".";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(230, 56);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(968, 610);
            this.pnlPrincipal.TabIndex = 8;
            // 
            // FormDashBoardComparativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 666);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormDashBoardComparativo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDashBoardComparativo_KeyDown);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTime_MesInicial;
        private System.Windows.Forms.DateTimePicker dateTime_MesFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton icoSair;
        private FontAwesome.Sharp.IconButton icoPDV;
        private FontAwesome.Sharp.IconButton icoOrdemServico;
        private FontAwesome.Sharp.IconButton icoPedidos;
        private FontAwesome.Sharp.IconButton icoEmissaoNotas;
        private FontAwesome.Sharp.IconButton icoDelivery;
        private FontAwesome.Sharp.IconButton icoContasFinanceiras;
        private FontAwesome.Sharp.IconButton icoCadastrosComparativo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labTexto;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}