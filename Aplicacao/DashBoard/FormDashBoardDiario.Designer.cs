namespace Aplicacao.DashBoard
{
    partial class FormDashBoardDiario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashBoardDiario));
            this.ct_pedidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.dashBoard = new Relatorio.DashBoard();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Relatorio.DashBoardTableAdapters.PessoaTableAdapter();
            this.notaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaTableAdapter = new Relatorio.DashBoardTableAdapters.NotaTableAdapter();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Relatorio.DashBoardTableAdapters.PedidoTableAdapter();
            this.documentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentoTableAdapter = new Relatorio.DashBoardTableAdapters.DocumentoTableAdapter();
            this.clientesCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesCompraTableAdapter = new Relatorio.DashBoardTableAdapters.ClientesCompraTableAdapter();
            this.produtosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosVendidosTableAdapter = new Relatorio.DashBoardTableAdapters.ProdutosVendidosTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Relatorio.DashBoardTableAdapters.ProdutoTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lv_Clientes = new System.Windows.Forms.ListView();
            this.clientesList = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimer_Dash = new System.Windows.Forms.DateTimePicker();
            this.lb_periodo_completo = new System.Windows.Forms.Label();
            this.lb_periodo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label15 = new System.Windows.Forms.Label();
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn_clientesA = new System.Windows.Forms.Panel();
            this.lb_clientesA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_boletos = new System.Windows.Forms.Panel();
            this.lb_ProdutosAtivos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_nfce = new System.Windows.Forms.Panel();
            this.lb_nfce = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_clientesN = new System.Windows.Forms.Panel();
            this.lb_clientesI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_pagamento = new System.Windows.Forms.Panel();
            this.lb_pagar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_recebimento = new System.Windows.Forms.Panel();
            this.lb_receber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pn_Pedidos = new System.Windows.Forms.Panel();
            this.lb_pedidos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_nfe = new System.Windows.Forms.Label();
            this.pn_nfe = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ct_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_clientesA.SuspendLayout();
            this.pn_boletos.SuspendLayout();
            this.pn_nfce.SuspendLayout();
            this.pn_clientesN.SuspendLayout();
            this.pn_pagamento.SuspendLayout();
            this.pn_recebimento.SuspendLayout();
            this.pn_Pedidos.SuspendLayout();
            this.pn_nfe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ct_pedidos
            // 
            this.ct_pedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ct_pedidos.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ct_pedidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ct_pedidos.Legends.Add(legend2);
            this.ct_pedidos.Location = new System.Drawing.Point(444, 298);
            this.ct_pedidos.Name = "ct_pedidos";
            this.ct_pedidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "Legend1";
            series5.Name = "NFCe";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Lime;
            series6.Legend = "Legend1";
            series6.Name = "NFe";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Yellow;
            series7.Legend = "Legend1";
            series7.Name = "RECEBER";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series8.Legend = "Legend1";
            series8.Name = "PAGAR";
            this.ct_pedidos.Series.Add(series5);
            this.ct_pedidos.Series.Add(series6);
            this.ct_pedidos.Series.Add(series7);
            this.ct_pedidos.Series.Add(series8);
            this.ct_pedidos.Size = new System.Drawing.Size(473, 315);
            this.ct_pedidos.TabIndex = 8;
            this.ct_pedidos.Text = "chart1";
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // dashBoard
            // 
            this.dashBoard.DataSetName = "DashBoard";
            this.dashBoard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.dashBoard;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // notaBindingSource
            // 
            this.notaBindingSource.DataMember = "Nota";
            this.notaBindingSource.DataSource = this.dashBoard;
            // 
            // notaTableAdapter
            // 
            this.notaTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.dashBoard;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // documentoBindingSource
            // 
            this.documentoBindingSource.DataMember = "Documento";
            this.documentoBindingSource.DataSource = this.dashBoard;
            // 
            // documentoTableAdapter
            // 
            this.documentoTableAdapter.ClearBeforeFill = true;
            // 
            // clientesCompraBindingSource
            // 
            this.clientesCompraBindingSource.DataMember = "ClientesCompra";
            this.clientesCompraBindingSource.DataSource = this.dashBoard;
            // 
            // clientesCompraTableAdapter
            // 
            this.clientesCompraTableAdapter.ClearBeforeFill = true;
            // 
            // produtosVendidosBindingSource
            // 
            this.produtosVendidosBindingSource.DataMember = "ProdutosVendidos";
            this.produtosVendidosBindingSource.DataSource = this.dashBoard;
            // 
            // produtosVendidosTableAdapter
            // 
            this.produtosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dashBoard;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoSize = true;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lv_Clientes);
            this.panel3.Controls.Add(this.clientesList);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(18, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 318);
            this.panel3.TabIndex = 11;
            // 
            // lv_Clientes
            // 
            this.lv_Clientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lv_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Clientes.HideSelection = false;
            this.lv_Clientes.Location = new System.Drawing.Point(3, 45);
            this.lv_Clientes.Name = "lv_Clientes";
            this.lv_Clientes.Size = new System.Drawing.Size(342, 25);
            this.lv_Clientes.TabIndex = 22;
            this.lv_Clientes.UseCompatibleStateImageBehavior = false;
            // 
            // clientesList
            // 
            this.clientesList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clientesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader11});
            this.clientesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesList.ForeColor = System.Drawing.Color.White;
            this.clientesList.HideSelection = false;
            this.clientesList.Location = new System.Drawing.Point(3, 45);
            this.clientesList.MultiSelect = false;
            this.clientesList.Name = "clientesList";
            this.clientesList.Scrollable = false;
            this.clientesList.Size = new System.Drawing.Size(342, 270);
            this.clientesList.TabIndex = 21;
            this.clientesList.UseCompatibleStateImageBehavior = false;
            this.clientesList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Width = 231;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Width = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "CURVA ABC CLIENTES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.dateTimer_Dash);
            this.panel2.Controls.Add(this.lb_periodo_completo);
            this.panel2.Controls.Add(this.lb_periodo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(18, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 52);
            this.panel2.TabIndex = 10;
            // 
            // dateTimer_Dash
            // 
            this.dateTimer_Dash.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimer_Dash.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimer_Dash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimer_Dash.Location = new System.Drawing.Point(968, 11);
            this.dateTimer_Dash.Name = "dateTimer_Dash";
            this.dateTimer_Dash.Size = new System.Drawing.Size(355, 29);
            this.dateTimer_Dash.TabIndex = 20;
            this.dateTimer_Dash.ValueChanged += new System.EventHandler(this.DateTimer_Dash_ValueChanged);
            // 
            // lb_periodo_completo
            // 
            this.lb_periodo_completo.AutoSize = true;
            this.lb_periodo_completo.BackColor = System.Drawing.Color.Transparent;
            this.lb_periodo_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_periodo_completo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_periodo_completo.Location = new System.Drawing.Point(686, 15);
            this.lb_periodo_completo.Name = "lb_periodo_completo";
            this.lb_periodo_completo.Size = new System.Drawing.Size(95, 24);
            this.lb_periodo_completo.TabIndex = 19;
            this.lb_periodo_completo.Text = "PERIODO";
            this.lb_periodo_completo.Visible = false;
            // 
            // lb_periodo
            // 
            this.lb_periodo.AutoSize = true;
            this.lb_periodo.BackColor = System.Drawing.Color.Transparent;
            this.lb_periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_periodo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_periodo.Location = new System.Drawing.Point(585, 14);
            this.lb_periodo.Name = "lb_periodo";
            this.lb_periodo.Size = new System.Drawing.Size(95, 24);
            this.lb_periodo.TabIndex = 18;
            this.lb_periodo.Text = "PERIODO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(6, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "DashBoard Diário";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lv_produtos);
            this.panel1.Location = new System.Drawing.Point(920, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 315);
            this.panel1.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(342, 25);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(13, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(301, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "PRODUTOS MAIS VENDIDOS";
            // 
            // lv_produtos
            // 
            this.lv_produtos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lv_produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_produtos.ForeColor = System.Drawing.Color.White;
            this.lv_produtos.HideSelection = false;
            this.lv_produtos.Location = new System.Drawing.Point(3, 42);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Scrollable = false;
            this.lv_produtos.Size = new System.Drawing.Size(342, 270);
            this.lv_produtos.TabIndex = 23;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 276;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 112;
            // 
            // pn_clientesA
            // 
            this.pn_clientesA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_clientesA.AutoSize = true;
            this.pn_clientesA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pn_clientesA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_clientesA.Controls.Add(this.pictureBox3);
            this.pn_clientesA.Controls.Add(this.lb_clientesA);
            this.pn_clientesA.Controls.Add(this.label1);
            this.pn_clientesA.Location = new System.Drawing.Point(686, 63);
            this.pn_clientesA.Name = "pn_clientesA";
            this.pn_clientesA.Size = new System.Drawing.Size(326, 95);
            this.pn_clientesA.TabIndex = 4;
            // 
            // lb_clientesA
            // 
            this.lb_clientesA.AutoSize = true;
            this.lb_clientesA.BackColor = System.Drawing.Color.Transparent;
            this.lb_clientesA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientesA.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_clientesA.Location = new System.Drawing.Point(229, 12);
            this.lb_clientesA.Name = "lb_clientesA";
            this.lb_clientesA.Size = new System.Drawing.Size(68, 26);
            this.lb_clientesA.TabIndex = 1;
            this.lb_clientesA.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(184, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes Ativos";
            // 
            // pn_boletos
            // 
            this.pn_boletos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_boletos.AutoSize = true;
            this.pn_boletos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pn_boletos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_boletos.Controls.Add(this.pictureBox8);
            this.pn_boletos.Controls.Add(this.lb_ProdutosAtivos);
            this.pn_boletos.Controls.Add(this.label2);
            this.pn_boletos.Location = new System.Drawing.Point(1018, 179);
            this.pn_boletos.Name = "pn_boletos";
            this.pn_boletos.Size = new System.Drawing.Size(326, 95);
            this.pn_boletos.TabIndex = 7;
            // 
            // lb_ProdutosAtivos
            // 
            this.lb_ProdutosAtivos.AutoSize = true;
            this.lb_ProdutosAtivos.BackColor = System.Drawing.Color.Transparent;
            this.lb_ProdutosAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProdutosAtivos.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_ProdutosAtivos.Location = new System.Drawing.Point(214, 10);
            this.lb_ProdutosAtivos.Name = "lb_ProdutosAtivos";
            this.lb_ProdutosAtivos.Size = new System.Drawing.Size(68, 26);
            this.lb_ProdutosAtivos.TabIndex = 13;
            this.lb_ProdutosAtivos.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(130, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total de Produtos Ativos";
            // 
            // pn_nfce
            // 
            this.pn_nfce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_nfce.AutoSize = true;
            this.pn_nfce.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pn_nfce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_nfce.Controls.Add(this.pictureBox4);
            this.pn_nfce.Controls.Add(this.lb_nfce);
            this.pn_nfce.Controls.Add(this.label6);
            this.pn_nfce.Location = new System.Drawing.Point(1018, 63);
            this.pn_nfce.Name = "pn_nfce";
            this.pn_nfce.Size = new System.Drawing.Size(326, 95);
            this.pn_nfce.TabIndex = 6;
            // 
            // lb_nfce
            // 
            this.lb_nfce.AutoSize = true;
            this.lb_nfce.BackColor = System.Drawing.Color.Transparent;
            this.lb_nfce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nfce.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nfce.Location = new System.Drawing.Point(213, 11);
            this.lb_nfce.Name = "lb_nfce";
            this.lb_nfce.Size = new System.Drawing.Size(68, 26);
            this.lb_nfce.TabIndex = 12;
            this.lb_nfce.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(175, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total NFc-e";
            // 
            // pn_clientesN
            // 
            this.pn_clientesN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_clientesN.AutoSize = true;
            this.pn_clientesN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pn_clientesN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_clientesN.Controls.Add(this.pictureBox7);
            this.pn_clientesN.Controls.Add(this.lb_clientesI);
            this.pn_clientesN.Controls.Add(this.label3);
            this.pn_clientesN.Location = new System.Drawing.Point(686, 179);
            this.pn_clientesN.Name = "pn_clientesN";
            this.pn_clientesN.Size = new System.Drawing.Size(326, 95);
            this.pn_clientesN.TabIndex = 5;
            // 
            // lb_clientesI
            // 
            this.lb_clientesI.AutoSize = true;
            this.lb_clientesI.BackColor = System.Drawing.Color.Transparent;
            this.lb_clientesI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientesI.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_clientesI.Location = new System.Drawing.Point(232, 10);
            this.lb_clientesI.Name = "lb_clientesI";
            this.lb_clientesI.Size = new System.Drawing.Size(68, 26);
            this.lb_clientesI.TabIndex = 12;
            this.lb_clientesI.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(184, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Clientes Inativos";
            // 
            // pn_pagamento
            // 
            this.pn_pagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_pagamento.AutoSize = true;
            this.pn_pagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pn_pagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_pagamento.Controls.Add(this.pictureBox6);
            this.pn_pagamento.Controls.Add(this.lb_pagar);
            this.pn_pagamento.Controls.Add(this.label7);
            this.pn_pagamento.Location = new System.Drawing.Point(354, 179);
            this.pn_pagamento.Name = "pn_pagamento";
            this.pn_pagamento.Size = new System.Drawing.Size(326, 95);
            this.pn_pagamento.TabIndex = 3;
            // 
            // lb_pagar
            // 
            this.lb_pagar.AutoSize = true;
            this.lb_pagar.BackColor = System.Drawing.Color.Transparent;
            this.lb_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pagar.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_pagar.Location = new System.Drawing.Point(212, 14);
            this.lb_pagar.Name = "lb_pagar";
            this.lb_pagar.Size = new System.Drawing.Size(68, 26);
            this.lb_pagar.TabIndex = 5;
            this.lb_pagar.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(213, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Paga Hoje";
            // 
            // pn_recebimento
            // 
            this.pn_recebimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_recebimento.AutoSize = true;
            this.pn_recebimento.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_recebimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_recebimento.Controls.Add(this.pictureBox5);
            this.pn_recebimento.Controls.Add(this.lb_receber);
            this.pn_recebimento.Controls.Add(this.label11);
            this.pn_recebimento.Location = new System.Drawing.Point(18, 179);
            this.pn_recebimento.Name = "pn_recebimento";
            this.pn_recebimento.Size = new System.Drawing.Size(330, 95);
            this.pn_recebimento.TabIndex = 1;
            // 
            // lb_receber
            // 
            this.lb_receber.AutoSize = true;
            this.lb_receber.BackColor = System.Drawing.Color.Transparent;
            this.lb_receber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_receber.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_receber.Location = new System.Drawing.Point(217, 14);
            this.lb_receber.Name = "lb_receber";
            this.lb_receber.Size = new System.Drawing.Size(68, 26);
            this.lb_receber.TabIndex = 11;
            this.lb_receber.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(196, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Receber Hoje";
            // 
            // pn_Pedidos
            // 
            this.pn_Pedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_Pedidos.AutoSize = true;
            this.pn_Pedidos.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_Pedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Pedidos.Controls.Add(this.pictureBox1);
            this.pn_Pedidos.Controls.Add(this.lb_pedidos);
            this.pn_Pedidos.Controls.Add(this.label14);
            this.pn_Pedidos.Location = new System.Drawing.Point(18, 63);
            this.pn_Pedidos.Name = "pn_Pedidos";
            this.pn_Pedidos.Size = new System.Drawing.Size(330, 95);
            this.pn_Pedidos.TabIndex = 0;
            // 
            // lb_pedidos
            // 
            this.lb_pedidos.AutoSize = true;
            this.lb_pedidos.BackColor = System.Drawing.Color.Transparent;
            this.lb_pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pedidos.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_pedidos.Location = new System.Drawing.Point(198, 9);
            this.lb_pedidos.Name = "lb_pedidos";
            this.lb_pedidos.Size = new System.Drawing.Size(68, 26);
            this.lb_pedidos.TabIndex = 14;
            this.lb_pedidos.Text = "Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(159, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "Total de Pedidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(213, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total NFe";
            // 
            // lb_nfe
            // 
            this.lb_nfe.AutoSize = true;
            this.lb_nfe.BackColor = System.Drawing.Color.Transparent;
            this.lb_nfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nfe.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nfe.Location = new System.Drawing.Point(211, 15);
            this.lb_nfe.Name = "lb_nfe";
            this.lb_nfe.Size = new System.Drawing.Size(68, 26);
            this.lb_nfe.TabIndex = 4;
            this.lb_nfe.Text = "Value";
            // 
            // pn_nfe
            // 
            this.pn_nfe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_nfe.AutoSize = true;
            this.pn_nfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pn_nfe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_nfe.Controls.Add(this.pictureBox2);
            this.pn_nfe.Controls.Add(this.lb_nfe);
            this.pn_nfe.Controls.Add(this.label5);
            this.pn_nfe.Location = new System.Drawing.Point(354, 63);
            this.pn_nfe.Name = "pn_nfe";
            this.pn_nfe.Size = new System.Drawing.Size(326, 94);
            this.pn_nfe.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(23, 10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 64);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(18, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(29, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormDashBoardDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_clientesA);
            this.Controls.Add(this.ct_pedidos);
            this.Controls.Add(this.pn_boletos);
            this.Controls.Add(this.pn_nfce);
            this.Controls.Add(this.pn_clientesN);
            this.Controls.Add(this.pn_pagamento);
            this.Controls.Add(this.pn_recebimento);
            this.Controls.Add(this.pn_nfe);
            this.Controls.Add(this.pn_Pedidos);
            this.KeyPreview = true;
            this.Name = "FormDashBoardDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Diário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashBoard_FormClosing);
            this.Load += new System.EventHandler(this.FormDashBoardDiario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDashBoardDiario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ct_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_clientesA.ResumeLayout(false);
            this.pn_clientesA.PerformLayout();
            this.pn_boletos.ResumeLayout(false);
            this.pn_boletos.PerformLayout();
            this.pn_nfce.ResumeLayout(false);
            this.pn_nfce.PerformLayout();
            this.pn_clientesN.ResumeLayout(false);
            this.pn_clientesN.PerformLayout();
            this.pn_pagamento.ResumeLayout(false);
            this.pn_pagamento.PerformLayout();
            this.pn_recebimento.ResumeLayout(false);
            this.pn_recebimento.PerformLayout();
            this.pn_Pedidos.ResumeLayout(false);
            this.pn_Pedidos.PerformLayout();
            this.pn_nfe.ResumeLayout(false);
            this.pn_nfe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Pedidos;
        private System.Windows.Forms.Panel pn_recebimento;
        private System.Windows.Forms.Panel pn_pagamento;
        private System.Windows.Forms.Panel pn_clientesN;
        private System.Windows.Forms.Panel pn_clientesA;
        private System.Windows.Forms.Panel pn_nfce;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_pedidos;
        private System.Windows.Forms.Panel pn_boletos;
        private System.Windows.Forms.Label lb_clientesA;
        private System.Windows.Forms.Label label1;
        private Relatorio.DashBoard dashBoard;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private Relatorio.DashBoardTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.Label lb_clientesI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_pagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_receber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_pedidos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource notaBindingSource;
        private Relatorio.DashBoardTableAdapters.NotaTableAdapter notaTableAdapter;
        private System.Windows.Forms.Label lb_nfce;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private Relatorio.DashBoardTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource documentoBindingSource;
        private Relatorio.DashBoardTableAdapters.DocumentoTableAdapter documentoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_periodo_completo;
        private System.Windows.Forms.Label lb_periodo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_Clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource clientesCompraBindingSource;
        private Relatorio.DashBoardTableAdapters.ClientesCompraTableAdapter clientesCompraTableAdapter;
        private System.Windows.Forms.ListView clientesList;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.BindingSource produtosVendidosBindingSource;
        private Relatorio.DashBoardTableAdapters.ProdutosVendidosTableAdapter produtosVendidosTableAdapter;
        private System.Windows.Forms.Label lb_ProdutosAtivos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private Relatorio.DashBoardTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimer_Dash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_nfe;
        private System.Windows.Forms.Panel pn_nfe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}