
namespace Aplicacao.DashBoard
{
    partial class FormDashBoardCadastrosComparativo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashBoardCadastrosComparativo));
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPercentualVendedor = new System.Windows.Forms.Label();
            this.txtTotalVendedoresMes02 = new System.Windows.Forms.Label();
            this.txtTotalVendedoresMes01 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPercentualFornecedor = new System.Windows.Forms.Label();
            this.txtTotalFornecedoresMes02 = new System.Windows.Forms.Label();
            this.txtTotalFornecedoresMes01 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPercentualProduto = new System.Windows.Forms.Label();
            this.txtTotalProdutosMes02 = new System.Windows.Forms.Label();
            this.txtTotalProdutosMes01 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPercentualCliente = new System.Windows.Forms.Label();
            this.txtTotalClientesMes02 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalClientesMes01 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dashBoardCadastro = new Aplicacao.BancoDemoDataSet();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashBoardCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Location = new System.Drawing.Point(12, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(944, 443);
            this.panel5.TabIndex = 26;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(10, 8);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(925, 427);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtPercentualVendedor);
            this.panel4.Controls.Add(this.txtTotalVendedoresMes02);
            this.panel4.Controls.Add(this.txtTotalVendedoresMes01);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Location = new System.Drawing.Point(730, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 133);
            this.panel4.TabIndex = 25;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(150, 82);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(80, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mês 02";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(80, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mês 01";
            // 
            // txtPercentualVendedor
            // 
            this.txtPercentualVendedor.AutoSize = true;
            this.txtPercentualVendedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPercentualVendedor.Location = new System.Drawing.Point(8, 106);
            this.txtPercentualVendedor.Name = "txtPercentualVendedor";
            this.txtPercentualVendedor.Size = new System.Drawing.Size(32, 20);
            this.txtPercentualVendedor.TabIndex = 10;
            this.txtPercentualVendedor.Text = "0%";
            // 
            // txtTotalVendedoresMes02
            // 
            this.txtTotalVendedoresMes02.AutoSize = true;
            this.txtTotalVendedoresMes02.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVendedoresMes02.ForeColor = System.Drawing.Color.Black;
            this.txtTotalVendedoresMes02.Location = new System.Drawing.Point(172, 78);
            this.txtTotalVendedoresMes02.Name = "txtTotalVendedoresMes02";
            this.txtTotalVendedoresMes02.Size = new System.Drawing.Size(43, 24);
            this.txtTotalVendedoresMes02.TabIndex = 4;
            this.txtTotalVendedoresMes02.Text = "000";
            // 
            // txtTotalVendedoresMes01
            // 
            this.txtTotalVendedoresMes01.AutoSize = true;
            this.txtTotalVendedoresMes01.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVendedoresMes01.ForeColor = System.Drawing.Color.Black;
            this.txtTotalVendedoresMes01.Location = new System.Drawing.Point(172, 43);
            this.txtTotalVendedoresMes01.Name = "txtTotalVendedoresMes01";
            this.txtTotalVendedoresMes01.Size = new System.Drawing.Size(43, 24);
            this.txtTotalVendedoresMes01.TabIndex = 3;
            this.txtTotalVendedoresMes01.Text = "000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(8, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cadastro Vendedores";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Turquoise;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(8, 43);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(33, 34);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtPercentualFornecedor);
            this.panel3.Controls.Add(this.txtTotalFornecedoresMes02);
            this.panel3.Controls.Add(this.txtTotalFornecedoresMes01);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Location = new System.Drawing.Point(495, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 133);
            this.panel3.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(151, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(63, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mês 02";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(63, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mês 01";
            // 
            // txtPercentualFornecedor
            // 
            this.txtPercentualFornecedor.AutoSize = true;
            this.txtPercentualFornecedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPercentualFornecedor.Location = new System.Drawing.Point(7, 106);
            this.txtPercentualFornecedor.Name = "txtPercentualFornecedor";
            this.txtPercentualFornecedor.Size = new System.Drawing.Size(41, 20);
            this.txtPercentualFornecedor.TabIndex = 9;
            this.txtPercentualFornecedor.Text = "15%";
            // 
            // txtTotalFornecedoresMes02
            // 
            this.txtTotalFornecedoresMes02.AutoSize = true;
            this.txtTotalFornecedoresMes02.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFornecedoresMes02.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFornecedoresMes02.Location = new System.Drawing.Point(173, 78);
            this.txtTotalFornecedoresMes02.Name = "txtTotalFornecedoresMes02";
            this.txtTotalFornecedoresMes02.Size = new System.Drawing.Size(43, 24);
            this.txtTotalFornecedoresMes02.TabIndex = 4;
            this.txtTotalFornecedoresMes02.Text = "000";
            // 
            // txtTotalFornecedoresMes01
            // 
            this.txtTotalFornecedoresMes01.AutoSize = true;
            this.txtTotalFornecedoresMes01.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFornecedoresMes01.ForeColor = System.Drawing.Color.Black;
            this.txtTotalFornecedoresMes01.Location = new System.Drawing.Point(173, 43);
            this.txtTotalFornecedoresMes01.Name = "txtTotalFornecedoresMes01";
            this.txtTotalFornecedoresMes01.Size = new System.Drawing.Size(43, 24);
            this.txtTotalFornecedoresMes01.TabIndex = 3;
            this.txtTotalFornecedoresMes01.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(7, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Cadastro Fornecedores";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Turquoise;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(7, 43);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(33, 34);
            this.iconButton3.TabIndex = 1;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPercentualProduto);
            this.panel2.Controls.Add(this.txtTotalProdutosMes02);
            this.panel2.Controls.Add(this.txtTotalProdutosMes01);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(260, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 133);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(151, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mês 02";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(60, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mês 01";
            // 
            // txtPercentualProduto
            // 
            this.txtPercentualProduto.AutoSize = true;
            this.txtPercentualProduto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPercentualProduto.Location = new System.Drawing.Point(11, 106);
            this.txtPercentualProduto.Name = "txtPercentualProduto";
            this.txtPercentualProduto.Size = new System.Drawing.Size(41, 20);
            this.txtPercentualProduto.TabIndex = 8;
            this.txtPercentualProduto.Text = "50%";
            // 
            // txtTotalProdutosMes02
            // 
            this.txtTotalProdutosMes02.AutoSize = true;
            this.txtTotalProdutosMes02.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProdutosMes02.ForeColor = System.Drawing.Color.Black;
            this.txtTotalProdutosMes02.Location = new System.Drawing.Point(173, 78);
            this.txtTotalProdutosMes02.Name = "txtTotalProdutosMes02";
            this.txtTotalProdutosMes02.Size = new System.Drawing.Size(43, 24);
            this.txtTotalProdutosMes02.TabIndex = 4;
            this.txtTotalProdutosMes02.Text = "000";
            // 
            // txtTotalProdutosMes01
            // 
            this.txtTotalProdutosMes01.AutoSize = true;
            this.txtTotalProdutosMes01.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProdutosMes01.ForeColor = System.Drawing.Color.Black;
            this.txtTotalProdutosMes01.Location = new System.Drawing.Point(173, 43);
            this.txtTotalProdutosMes01.Name = "txtTotalProdutosMes01";
            this.txtTotalProdutosMes01.Size = new System.Drawing.Size(43, 24);
            this.txtTotalProdutosMes01.TabIndex = 3;
            this.txtTotalProdutosMes01.Text = "000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cadastro Produtos";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Turquoise;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(11, 43);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(33, 34);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtPercentualCliente);
            this.panel1.Controls.Add(this.txtTotalClientesMes02);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotalClientesMes01);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 133);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtPercentualCliente
            // 
            this.txtPercentualCliente.AutoSize = true;
            this.txtPercentualCliente.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPercentualCliente.Location = new System.Drawing.Point(8, 106);
            this.txtPercentualCliente.Name = "txtPercentualCliente";
            this.txtPercentualCliente.Size = new System.Drawing.Size(41, 20);
            this.txtPercentualCliente.TabIndex = 7;
            this.txtPercentualCliente.Text = "70%";
            // 
            // txtTotalClientesMes02
            // 
            this.txtTotalClientesMes02.AutoSize = true;
            this.txtTotalClientesMes02.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalClientesMes02.ForeColor = System.Drawing.Color.Black;
            this.txtTotalClientesMes02.Location = new System.Drawing.Point(185, 78);
            this.txtTotalClientesMes02.Name = "txtTotalClientesMes02";
            this.txtTotalClientesMes02.Size = new System.Drawing.Size(43, 24);
            this.txtTotalClientesMes02.TabIndex = 6;
            this.txtTotalClientesMes02.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(76, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mês 02";
            // 
            // txtTotalClientesMes01
            // 
            this.txtTotalClientesMes01.AutoSize = true;
            this.txtTotalClientesMes01.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalClientesMes01.ForeColor = System.Drawing.Color.Black;
            this.txtTotalClientesMes01.Location = new System.Drawing.Point(185, 43);
            this.txtTotalClientesMes01.Name = "txtTotalClientesMes01";
            this.txtTotalClientesMes01.Size = new System.Drawing.Size(43, 24);
            this.txtTotalClientesMes01.TabIndex = 3;
            this.txtTotalClientesMes01.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mês 01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro Clientes";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Turquoise;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(8, 41);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 34);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // dashBoardCadastro
            // 
            this.dashBoardCadastro.DataSetName = "DashBoardCadastro";
            this.dashBoardCadastro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormDashBoardCadastrosComparativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 606);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashBoardCadastrosComparativo";
            this.Text = "FormDashBoardCadastrosComparativo";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashBoardCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtTotalVendedoresMes01;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtTotalFornecedoresMes01;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTotalProdutosMes01;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTotalClientesMes01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private BancoDemoDataSet dashBoardCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotalClientesMes02;
        private System.Windows.Forms.Label txtPercentualCliente;
        private System.Windows.Forms.Label txtTotalVendedoresMes02;
        private System.Windows.Forms.Label txtTotalFornecedoresMes02;
        private System.Windows.Forms.Label txtTotalProdutosMes02;
        private System.Windows.Forms.Label txtPercentualVendedor;
        private System.Windows.Forms.Label txtPercentualFornecedor;
        private System.Windows.Forms.Label txtPercentualProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}