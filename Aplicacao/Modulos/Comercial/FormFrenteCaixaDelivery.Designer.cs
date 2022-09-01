namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbFinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.LBLRemovercliente = new System.Windows.Forms.Label();
            this.TXT_Cliente = new System.Windows.Forms.Label();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.ovGRD_Itens = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupPanel_Categorias = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupPanel_Produtos = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TXT_ValorTotal = new System.Windows.Forms.Label();
            this.TXT_QuantidadeItens = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TXT_Produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Itens)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(119, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 33);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "REMOVER ITEM";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sbFinalizarVenda
            // 
            this.sbFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFinalizarVenda.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbFinalizarVenda.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbFinalizarVenda.Appearance.BorderColor = System.Drawing.Color.Green;
            this.sbFinalizarVenda.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.sbFinalizarVenda.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbFinalizarVenda.Appearance.Options.UseBackColor = true;
            this.sbFinalizarVenda.Appearance.Options.UseBorderColor = true;
            this.sbFinalizarVenda.Appearance.Options.UseFont = true;
            this.sbFinalizarVenda.Appearance.Options.UseForeColor = true;
            this.sbFinalizarVenda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbFinalizarVenda.Location = new System.Drawing.Point(490, 188);
            this.sbFinalizarVenda.Name = "sbFinalizarVenda";
            this.sbFinalizarVenda.Size = new System.Drawing.Size(157, 33);
            this.sbFinalizarVenda.TabIndex = 32;
            this.sbFinalizarVenda.TabStop = false;
            this.sbFinalizarVenda.Text = "F12 - FINALIZAR VENDA";
            this.sbFinalizarVenda.Click += new System.EventHandler(this.sbFinalizarVenda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.simpleButton6);
            this.groupBox1.Controls.Add(this.LBLRemovercliente);
            this.groupBox1.Controls.Add(this.TXT_Cliente);
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Controls.Add(this.sbFinalizarVenda);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.ovGRD_Itens);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 227);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.simpleButton6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.simpleButton6.Appearance.BorderColor = System.Drawing.Color.Green;
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseBorderColor = true;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton6.Location = new System.Drawing.Point(653, 188);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(115, 33);
            this.simpleButton6.TabIndex = 40;
            this.simpleButton6.TabStop = false;
            this.simpleButton6.Text = "CTRL S - SAIR";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // LBLRemovercliente
            // 
            this.LBLRemovercliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLRemovercliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLRemovercliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRemovercliente.ForeColor = System.Drawing.Color.Gray;
            this.LBLRemovercliente.Location = new System.Drawing.Point(1029, 188);
            this.LBLRemovercliente.Name = "LBLRemovercliente";
            this.LBLRemovercliente.Size = new System.Drawing.Size(21, 33);
            this.LBLRemovercliente.TabIndex = 39;
            this.LBLRemovercliente.Text = "X";
            this.LBLRemovercliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBLRemovercliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_Cliente
            // 
            this.TXT_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXT_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_Cliente.Location = new System.Drawing.Point(743, 188);
            this.TXT_Cliente.Name = "TXT_Cliente";
            this.TXT_Cliente.Size = new System.Drawing.Size(280, 33);
            this.TXT_Cliente.TabIndex = 38;
            this.TXT_Cliente.Text = "TXT_Cliente";
            this.TXT_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TXT_Cliente.Click += new System.EventHandler(this.TXT_Cliente_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton5.Location = new System.Drawing.Point(352, 188);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(132, 33);
            this.simpleButton5.TabIndex = 37;
            this.simpleButton5.TabStop = false;
            this.simpleButton5.Text = "DADOS DO CLIENTE";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton3.Location = new System.Drawing.Point(6, 188);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(107, 33);
            this.simpleButton3.TabIndex = 35;
            this.simpleButton3.TabStop = false;
            this.simpleButton3.Text = "EDITAR ITEM";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.Location = new System.Drawing.Point(229, 188);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(117, 33);
            this.simpleButton2.TabIndex = 34;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "CANCELAR VENDA";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ovGRD_Itens
            // 
            this.ovGRD_Itens.AllowUserToAddRows = false;
            this.ovGRD_Itens.AllowUserToDeleteRows = false;
            this.ovGRD_Itens.AllowUserToOrderColumns = true;
            this.ovGRD_Itens.AllowUserToResizeRows = false;
            this.ovGRD_Itens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_Itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ovGRD_Itens.BackgroundColor = System.Drawing.Color.White;
            this.ovGRD_Itens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ovGRD_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ovGRD_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ovGRD_Itens.ColumnHeadersHeight = 28;
            this.ovGRD_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ovGRD_Itens.DefaultCellStyle = dataGridViewCellStyle2;
            this.ovGRD_Itens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ovGRD_Itens.EnableHeadersVisualStyles = false;
            this.ovGRD_Itens.GridColor = System.Drawing.Color.White;
            this.ovGRD_Itens.Location = new System.Drawing.Point(3, 19);
            this.ovGRD_Itens.MultiSelect = false;
            this.ovGRD_Itens.Name = "ovGRD_Itens";
            this.ovGRD_Itens.ReadOnly = true;
            this.ovGRD_Itens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ovGRD_Itens.RowHeadersVisible = false;
            this.ovGRD_Itens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ovGRD_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ovGRD_Itens.ShowCellErrors = false;
            this.ovGRD_Itens.ShowEditingIcon = false;
            this.ovGRD_Itens.ShowRowErrors = false;
            this.ovGRD_Itens.Size = new System.Drawing.Size(1044, 163);
            this.ovGRD_Itens.TabIndex = 0;
            this.ovGRD_Itens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ovGRD_Itens_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.GroupPanel_Categorias);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 355);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CATEGORIAS";
            // 
            // GroupPanel_Categorias
            // 
            this.GroupPanel_Categorias.AutoScroll = true;
            this.GroupPanel_Categorias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupPanel_Categorias.ColumnCount = 1;
            this.GroupPanel_Categorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GroupPanel_Categorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel_Categorias.Location = new System.Drawing.Point(3, 20);
            this.GroupPanel_Categorias.Name = "GroupPanel_Categorias";
            this.GroupPanel_Categorias.RowCount = 1;
            this.GroupPanel_Categorias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GroupPanel_Categorias.Size = new System.Drawing.Size(320, 332);
            this.GroupPanel_Categorias.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.GroupPanel_Produtos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(344, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 355);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRODUTOS DA CATEGORIA";
            // 
            // GroupPanel_Produtos
            // 
            this.GroupPanel_Produtos.AutoScroll = true;
            this.GroupPanel_Produtos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupPanel_Produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel_Produtos.Location = new System.Drawing.Point(3, 20);
            this.GroupPanel_Produtos.Name = "GroupPanel_Produtos";
            this.GroupPanel_Produtos.Padding = new System.Windows.Forms.Padding(3);
            this.GroupPanel_Produtos.Size = new System.Drawing.Size(901, 332);
            this.GroupPanel_Produtos.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.TXT_ValorTotal);
            this.groupBox5.Controls.Add(this.TXT_QuantidadeItens);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox5.Location = new System.Drawing.Point(1074, 453);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 227);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TOTALIZADOR";
            // 
            // TXT_ValorTotal
            // 
            this.TXT_ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ValorTotal.ForeColor = System.Drawing.Color.Green;
            this.TXT_ValorTotal.Location = new System.Drawing.Point(7, 119);
            this.TXT_ValorTotal.Name = "TXT_ValorTotal";
            this.TXT_ValorTotal.Size = new System.Drawing.Size(164, 102);
            this.TXT_ValorTotal.TabIndex = 1;
            this.TXT_ValorTotal.Text = "TXT_ValorTotal";
            this.TXT_ValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_QuantidadeItens
            // 
            this.TXT_QuantidadeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_QuantidadeItens.ForeColor = System.Drawing.Color.Blue;
            this.TXT_QuantidadeItens.Location = new System.Drawing.Point(5, 24);
            this.TXT_QuantidadeItens.Name = "TXT_QuantidadeItens";
            this.TXT_QuantidadeItens.Size = new System.Drawing.Size(169, 95);
            this.TXT_QuantidadeItens.TabIndex = 0;
            this.TXT_QuantidadeItens.Text = "TXT_QuantidadeItens";
            this.TXT_QuantidadeItens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.TXT_Produto);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1121, 73);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // TXT_Produto
            // 
            this.TXT_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Produto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TXT_Produto.ForeColor = System.Drawing.Color.Black;
            this.TXT_Produto.Location = new System.Drawing.Point(6, 16);
            this.TXT_Produto.Name = "TXT_Produto";
            this.TXT_Produto.Size = new System.Drawing.Size(1109, 22);
            this.TXT_Produto.TabIndex = 1;
            this.TXT_Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_Produto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.TXT_Produto.Leave += new System.EventHandler(this.TXT_Produto_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informe o Código de Barras ou a Descrição do Item...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1263, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel5.Text = "Abrir Caixa (F10)";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel6.Text = "Fechar Caixa (F11)";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel7.Text = "Sangria (CTRL + F10)";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabel8.Text = "Suprimento (CTRL + F11)";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(158, 17);
            this.toolStripStatusLabel1.Text = "Monitor Delivery (CTRL + M)";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel2.Text = "Fechar (CTRL + S)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabel3.Text = "Consulta de Produtos (F5)";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton4.Location = new System.Drawing.Point(1139, 22);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(109, 64);
            this.simpleButton4.TabIndex = 41;
            this.simpleButton4.TabStop = false;
            this.simpleButton4.Text = "PRODUTOS";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // FormFrenteCaixaDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 711);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FormFrenteCaixaDelivery";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRENTE DE CAIXA DELIVERY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFrenteCaixaDelivery_FormClosing);
            this.Shown += new System.EventHandler(this.FormFrenteCaixaDelivery_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Itens)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton sbFinalizarVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ovGRD_Itens;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label TXT_ValorTotal;
        private System.Windows.Forms.Label TXT_QuantidadeItens;
        private System.Windows.Forms.TableLayoutPanel GroupPanel_Categorias;
        private System.Windows.Forms.FlowLayoutPanel GroupPanel_Produtos;
        private System.Windows.Forms.Label TXT_Cliente;
        private System.Windows.Forms.Label LBLRemovercliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Produto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
    }
}