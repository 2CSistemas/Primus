
namespace Aplicacao.DashBoard
{
    partial class FormMenuDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuDashBoard));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.icoSair = new FontAwesome.Sharp.IconButton();
            this.icoPDV = new FontAwesome.Sharp.IconButton();
            this.icoOrdemServico = new FontAwesome.Sharp.IconButton();
            this.icoPedidos = new FontAwesome.Sharp.IconButton();
            this.icoEmissaoNotas = new FontAwesome.Sharp.IconButton();
            this.icoDelivery = new FontAwesome.Sharp.IconButton();
            this.icoContasFinanceiras = new FontAwesome.Sharp.IconButton();
            this.icoCadastros = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labTexto = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.labDashboard = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMenu.Controls.Add(this.icoSair);
            this.pnlMenu.Controls.Add(this.icoPDV);
            this.pnlMenu.Controls.Add(this.icoOrdemServico);
            this.pnlMenu.Controls.Add(this.icoPedidos);
            this.pnlMenu.Controls.Add(this.icoEmissaoNotas);
            this.pnlMenu.Controls.Add(this.icoDelivery);
            this.pnlMenu.Controls.Add(this.icoContasFinanceiras);
            this.pnlMenu.Controls.Add(this.icoCadastros);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 705);
            this.pnlMenu.TabIndex = 0;
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
            this.icoSair.Location = new System.Drawing.Point(0, 662);
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
            // icoCadastros
            // 
            this.icoCadastros.BackColor = System.Drawing.SystemColors.Highlight;
            this.icoCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.icoCadastros.FlatAppearance.BorderSize = 0;
            this.icoCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoCadastros.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoCadastros.ForeColor = System.Drawing.Color.White;
            this.icoCadastros.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.icoCadastros.IconColor = System.Drawing.Color.White;
            this.icoCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoCadastros.Location = new System.Drawing.Point(0, 100);
            this.icoCadastros.Name = "icoCadastros";
            this.icoCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icoCadastros.Size = new System.Drawing.Size(230, 43);
            this.icoCadastros.TabIndex = 1;
            this.icoCadastros.Text = "   Cadastros";
            this.icoCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoCadastros.UseVisualStyleBackColor = false;
            this.icoCadastros.Click += new System.EventHandler(this.icoCadastros_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Controls.Add(this.labTexto);
            this.pnlTitulo.Controls.Add(this.iconButton4);
            this.pnlTitulo.Controls.Add(this.iconButton3);
            this.pnlTitulo.Controls.Add(this.iconButton2);
            this.pnlTitulo.Controls.Add(this.labDashboard);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(230, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(984, 60);
            this.pnlTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // labTexto
            // 
            this.labTexto.AutoSize = true;
            this.labTexto.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTexto.Location = new System.Drawing.Point(159, 9);
            this.labTexto.Name = "labTexto";
            this.labTexto.Size = new System.Drawing.Size(18, 25);
            this.labTexto.TabIndex = 5;
            this.labTexto.Text = ".";
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(934, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(36, 23);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(893, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(36, 23);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.JournalWhills;
            this.iconButton2.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(852, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 23);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // labDashboard
            // 
            this.labDashboard.AutoSize = true;
            this.labDashboard.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDashboard.Location = new System.Drawing.Point(6, 9);
            this.labDashboard.Name = "labDashboard";
            this.labDashboard.Size = new System.Drawing.Size(118, 25);
            this.labDashboard.TabIndex = 0;
            this.labDashboard.Text = "Dashboard";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPrincipal.Location = new System.Drawing.Point(230, 60);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(929, 645);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // FormMenuDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 705);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMenuDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenuDashBoard_KeyDown);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlPrincipal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton icoCadastros;
        private FontAwesome.Sharp.IconButton icoSair;
        private FontAwesome.Sharp.IconButton icoPDV;
        private FontAwesome.Sharp.IconButton icoOrdemServico;
        private FontAwesome.Sharp.IconButton icoPedidos;
        private FontAwesome.Sharp.IconButton icoEmissaoNotas;
        private FontAwesome.Sharp.IconButton icoDelivery;
        private FontAwesome.Sharp.IconButton icoContasFinanceiras;
        private System.Windows.Forms.Label labDashboard;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label labTexto;
        private System.Windows.Forms.Label label1;
    }
}