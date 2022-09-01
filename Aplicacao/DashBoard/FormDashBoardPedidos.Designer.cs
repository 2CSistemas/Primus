
namespace Aplicacao.DashBoard
{
    partial class FormDashBoardPedidos
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalOrcamentosAberto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPedidosAberto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalOrcamentosFaturados = new System.Windows.Forms.Label();
            this.txtTotalPedidosFaturados = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalPedidos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalOrcamentos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalPedidosOrcamentos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(12, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(944, 458);
            this.panel5.TabIndex = 14;
            // 
            // chart1
            // 
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 39);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(934, 407);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.txtTotalOrcamentosAberto);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtTotalPedidosAberto);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Location = new System.Drawing.Point(733, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 93);
            this.panel4.TabIndex = 13;
            // 
            // txtTotalOrcamentosAberto
            // 
            this.txtTotalOrcamentosAberto.AutoSize = true;
            this.txtTotalOrcamentosAberto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrcamentosAberto.ForeColor = System.Drawing.Color.White;
            this.txtTotalOrcamentosAberto.Location = new System.Drawing.Point(174, 63);
            this.txtTotalOrcamentosAberto.Name = "txtTotalOrcamentosAberto";
            this.txtTotalOrcamentosAberto.Size = new System.Drawing.Size(43, 24);
            this.txtTotalOrcamentosAberto.TabIndex = 6;
            this.txtTotalOrcamentosAberto.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Orçamentos:";
            // 
            // txtTotalPedidosAberto
            // 
            this.txtTotalPedidosAberto.AutoSize = true;
            this.txtTotalPedidosAberto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedidosAberto.ForeColor = System.Drawing.Color.White;
            this.txtTotalPedidosAberto.Location = new System.Drawing.Point(173, 29);
            this.txtTotalPedidosAberto.Name = "txtTotalPedidosAberto";
            this.txtTotalPedidosAberto.Size = new System.Drawing.Size(43, 24);
            this.txtTotalPedidosAberto.TabIndex = 3;
            this.txtTotalPedidosAberto.Text = "000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(48, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Pedidos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(2, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 24);
            this.label16.TabIndex = 1;
            this.label16.Text = "Em Aberto";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTotalOrcamentosFaturados);
            this.panel3.Controls.Add(this.txtTotalPedidosFaturados);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Location = new System.Drawing.Point(494, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 93);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orçamentos:";
            // 
            // txtTotalOrcamentosFaturados
            // 
            this.txtTotalOrcamentosFaturados.AutoSize = true;
            this.txtTotalOrcamentosFaturados.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrcamentosFaturados.ForeColor = System.Drawing.Color.White;
            this.txtTotalOrcamentosFaturados.Location = new System.Drawing.Point(173, 63);
            this.txtTotalOrcamentosFaturados.Name = "txtTotalOrcamentosFaturados";
            this.txtTotalOrcamentosFaturados.Size = new System.Drawing.Size(43, 24);
            this.txtTotalOrcamentosFaturados.TabIndex = 4;
            this.txtTotalOrcamentosFaturados.Text = "000";
            // 
            // txtTotalPedidosFaturados
            // 
            this.txtTotalPedidosFaturados.AutoSize = true;
            this.txtTotalPedidosFaturados.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedidosFaturados.ForeColor = System.Drawing.Color.White;
            this.txtTotalPedidosFaturados.Location = new System.Drawing.Point(173, 33);
            this.txtTotalPedidosFaturados.Name = "txtTotalPedidosFaturados";
            this.txtTotalPedidosFaturados.Size = new System.Drawing.Size(43, 24);
            this.txtTotalPedidosFaturados.TabIndex = 3;
            this.txtTotalPedidosFaturados.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(58, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Pedidos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Faturados";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.txtTotalPedidos);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTotalOrcamentos);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(253, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 93);
            this.panel2.TabIndex = 11;
            // 
            // txtTotalPedidos
            // 
            this.txtTotalPedidos.AutoSize = true;
            this.txtTotalPedidos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedidos.ForeColor = System.Drawing.Color.White;
            this.txtTotalPedidos.Location = new System.Drawing.Point(146, 12);
            this.txtTotalPedidos.Name = "txtTotalPedidos";
            this.txtTotalPedidos.Size = new System.Drawing.Size(43, 24);
            this.txtTotalPedidos.TabIndex = 5;
            this.txtTotalPedidos.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pedidos";
            // 
            // txtTotalOrcamentos
            // 
            this.txtTotalOrcamentos.AutoSize = true;
            this.txtTotalOrcamentos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrcamentos.ForeColor = System.Drawing.Color.White;
            this.txtTotalOrcamentos.Location = new System.Drawing.Point(177, 62);
            this.txtTotalOrcamentos.Name = "txtTotalOrcamentos";
            this.txtTotalOrcamentos.Size = new System.Drawing.Size(43, 24);
            this.txtTotalOrcamentos.TabIndex = 3;
            this.txtTotalOrcamentos.Text = "000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Orçamentos";
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
            this.iconButton2.Location = new System.Drawing.Point(9, 30);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(33, 34);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.txtTotalPedidosOrcamentos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 93);
            this.panel1.TabIndex = 10;
            // 
            // txtTotalPedidosOrcamentos
            // 
            this.txtTotalPedidosOrcamentos.AutoSize = true;
            this.txtTotalPedidosOrcamentos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedidosOrcamentos.ForeColor = System.Drawing.Color.White;
            this.txtTotalPedidosOrcamentos.Location = new System.Drawing.Point(181, 63);
            this.txtTotalPedidosOrcamentos.Name = "txtTotalPedidosOrcamentos";
            this.txtTotalPedidosOrcamentos.Size = new System.Drawing.Size(43, 24);
            this.txtTotalPedidosOrcamentos.TabIndex = 3;
            this.txtTotalPedidosOrcamentos.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Geral:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedidos/Orçamentos";
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
            // FormDashBoardPedidos
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
            this.KeyPreview = true;
            this.Name = "FormDashBoardPedidos";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtTotalPedidosAberto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtTotalPedidosFaturados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTotalOrcamentos;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTotalPedidosOrcamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label txtTotalOrcamentosFaturados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotalOrcamentosAberto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotalPedidos;
        private System.Windows.Forms.Label label4;
    }
}