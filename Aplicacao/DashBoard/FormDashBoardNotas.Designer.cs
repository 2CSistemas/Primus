
namespace Aplicacao.DashBoard
{
    partial class FormDashBoardNotas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalNotas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalNotasNFSeEmitidas = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTotalNotasNFCeEmitidas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalNotasNFeEmitidas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalNotasNFSeCanceladas = new System.Windows.Forms.Label();
            this.txtTotalNotasNFCeCanceladas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalNotasNFeCanceladas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalNotasNFSeNegadas = new System.Windows.Forms.Label();
            this.txtTotalNotasNFCeNegadas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalNotasNFeNegadas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalNotas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 118);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(179, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "000";
            // 
            // txtTotalNotas
            // 
            this.txtTotalNotas.AutoSize = true;
            this.txtTotalNotas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotas.Location = new System.Drawing.Point(172, 30);
            this.txtTotalNotas.Name = "txtTotalNotas";
            this.txtTotalNotas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotas.TabIndex = 3;
            this.txtTotalNotas.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade de Notas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notas - Total Geral";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(9, 30);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 34);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.txtTotalNotasNFSeEmitidas);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtTotalNotasNFCeEmitidas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTotalNotasNFeEmitidas);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(253, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 118);
            this.panel2.TabIndex = 5;
            // 
            // txtTotalNotasNFSeEmitidas
            // 
            this.txtTotalNotasNFSeEmitidas.AutoSize = true;
            this.txtTotalNotasNFSeEmitidas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFSeEmitidas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFSeEmitidas.Location = new System.Drawing.Point(163, 87);
            this.txtTotalNotasNFSeEmitidas.Name = "txtTotalNotasNFSeEmitidas";
            this.txtTotalNotasNFSeEmitidas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFSeEmitidas.TabIndex = 7;
            this.txtTotalNotasNFSeEmitidas.Text = "000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(117, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "NFSe:";
            // 
            // txtTotalNotasNFCeEmitidas
            // 
            this.txtTotalNotasNFCeEmitidas.AutoSize = true;
            this.txtTotalNotasNFCeEmitidas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFCeEmitidas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFCeEmitidas.Location = new System.Drawing.Point(163, 54);
            this.txtTotalNotasNFCeEmitidas.Name = "txtTotalNotasNFCeEmitidas";
            this.txtTotalNotasNFCeEmitidas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFCeEmitidas.TabIndex = 5;
            this.txtTotalNotasNFCeEmitidas.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "NFCe:";
            // 
            // txtTotalNotasNFeEmitidas
            // 
            this.txtTotalNotasNFeEmitidas.AutoSize = true;
            this.txtTotalNotasNFeEmitidas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFeEmitidas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFeEmitidas.Location = new System.Drawing.Point(163, 22);
            this.txtTotalNotasNFeEmitidas.Name = "txtTotalNotasNFeEmitidas";
            this.txtTotalNotasNFeEmitidas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFeEmitidas.TabIndex = 3;
            this.txtTotalNotasNFeEmitidas.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(91, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "NFe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Emitidas";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(14, 27);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(33, 34);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.panel3.Controls.Add(this.txtTotalNotasNFSeCanceladas);
            this.panel3.Controls.Add(this.txtTotalNotasNFCeCanceladas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTotalNotasNFeCanceladas);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Location = new System.Drawing.Point(494, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 118);
            this.panel3.TabIndex = 6;
            // 
            // txtTotalNotasNFSeCanceladas
            // 
            this.txtTotalNotasNFSeCanceladas.AutoSize = true;
            this.txtTotalNotasNFSeCanceladas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFSeCanceladas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFSeCanceladas.Location = new System.Drawing.Point(172, 85);
            this.txtTotalNotasNFSeCanceladas.Name = "txtTotalNotasNFSeCanceladas";
            this.txtTotalNotasNFSeCanceladas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFSeCanceladas.TabIndex = 12;
            this.txtTotalNotasNFSeCanceladas.Text = "000";
            // 
            // txtTotalNotasNFCeCanceladas
            // 
            this.txtTotalNotasNFCeCanceladas.AutoSize = true;
            this.txtTotalNotasNFCeCanceladas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFCeCanceladas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFCeCanceladas.Location = new System.Drawing.Point(173, 56);
            this.txtTotalNotasNFCeCanceladas.Name = "txtTotalNotasNFCeCanceladas";
            this.txtTotalNotasNFCeCanceladas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFCeCanceladas.TabIndex = 11;
            this.txtTotalNotasNFCeCanceladas.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "NFSe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "NFCe:";
            // 
            // txtTotalNotasNFeCanceladas
            // 
            this.txtTotalNotasNFeCanceladas.AutoSize = true;
            this.txtTotalNotasNFeCanceladas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFeCanceladas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFeCanceladas.Location = new System.Drawing.Point(172, 30);
            this.txtTotalNotasNFeCanceladas.Name = "txtTotalNotasNFeCanceladas";
            this.txtTotalNotasNFeCanceladas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFeCanceladas.TabIndex = 3;
            this.txtTotalNotasNFeCanceladas.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(84, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "NFe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Canceladas";
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(9, 30);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(33, 34);
            this.iconButton3.TabIndex = 1;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.txtTotalNotasNFSeNegadas);
            this.panel4.Controls.Add(this.txtTotalNotasNFCeNegadas);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtTotalNotasNFeNegadas);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Location = new System.Drawing.Point(733, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 118);
            this.panel4.TabIndex = 7;
            // 
            // txtTotalNotasNFSeNegadas
            // 
            this.txtTotalNotasNFSeNegadas.AutoSize = true;
            this.txtTotalNotasNFSeNegadas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFSeNegadas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFSeNegadas.Location = new System.Drawing.Point(172, 87);
            this.txtTotalNotasNFSeNegadas.Name = "txtTotalNotasNFSeNegadas";
            this.txtTotalNotasNFSeNegadas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFSeNegadas.TabIndex = 17;
            this.txtTotalNotasNFSeNegadas.Text = "000";
            // 
            // txtTotalNotasNFCeNegadas
            // 
            this.txtTotalNotasNFCeNegadas.AutoSize = true;
            this.txtTotalNotasNFCeNegadas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFCeNegadas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFCeNegadas.Location = new System.Drawing.Point(172, 57);
            this.txtTotalNotasNFCeNegadas.Name = "txtTotalNotasNFCeNegadas";
            this.txtTotalNotasNFCeNegadas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFCeNegadas.TabIndex = 16;
            this.txtTotalNotasNFCeNegadas.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(103, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "NFSe:";
            // 
            // txtTotalNotasNFeNegadas
            // 
            this.txtTotalNotasNFeNegadas.AutoSize = true;
            this.txtTotalNotasNFeNegadas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNotasNFeNegadas.ForeColor = System.Drawing.Color.White;
            this.txtTotalNotasNFeNegadas.Location = new System.Drawing.Point(172, 30);
            this.txtTotalNotasNFeNegadas.Name = "txtTotalNotasNFeNegadas";
            this.txtTotalNotasNFeNegadas.Size = new System.Drawing.Size(43, 24);
            this.txtTotalNotasNFeNegadas.TabIndex = 3;
            this.txtTotalNotasNFeNegadas.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(83, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "NFCe:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(73, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "NFe:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 24);
            this.label16.TabIndex = 1;
            this.label16.Text = "Negadas";
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(9, 30);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(33, 34);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(12, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(944, 458);
            this.panel5.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 87);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(937, 368);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 25);
            this.label17.TabIndex = 1;
            this.label17.Text = "ESTATÍSTICAS";
            // 
            // FormDashBoardNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 606);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormDashBoardNotas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtTotalNotas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTotalNotasNFeEmitidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtTotalNotasNFeCanceladas;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtTotalNotasNFeNegadas;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label txtTotalNotasNFSeEmitidas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtTotalNotasNFCeEmitidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtTotalNotasNFSeCanceladas;
        private System.Windows.Forms.Label txtTotalNotasNFCeCanceladas;
        private System.Windows.Forms.Label txtTotalNotasNFSeNegadas;
        private System.Windows.Forms.Label txtTotalNotasNFCeNegadas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
    }
}