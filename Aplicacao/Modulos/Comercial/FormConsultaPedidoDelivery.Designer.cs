namespace Aplicacao.Modulos.Comercial
{
    partial class FormConsultaPedidoDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_FINAL_PERIODO = new System.Windows.Forms.Label();
            this.TXT_INICIO_PERIODO = new System.Windows.Forms.Label();
            this.TXT_BAIRRO = new System.Windows.Forms.Label();
            this.TXT_ENDERECO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grid_Pagamentos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ovGRD_Itens = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TXT_TOTAL = new System.Windows.Forms.Label();
            this.TXT_DESCONTO = new System.Windows.Forms.Label();
            this.TXT_TROCO = new System.Windows.Forms.Label();
            this.TXT_TAXAENTREGA = new System.Windows.Forms.Label();
            this.TXT_VALORITENS = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TXT_OBSERVACAOPEDIDO = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pagamentos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Itens)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(1011, 568);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(127, 33);
            this.simpleButton1.TabIndex = 42;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "FECHAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.TXT_FINAL_PERIODO);
            this.groupBox1.Controls.Add(this.TXT_INICIO_PERIODO);
            this.groupBox1.Controls.Add(this.TXT_BAIRRO);
            this.groupBox1.Controls.Add(this.TXT_ENDERECO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 222);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMAÇÕES GERAIS";
            // 
            // TXT_FINAL_PERIODO
            // 
            this.TXT_FINAL_PERIODO.AutoSize = true;
            this.TXT_FINAL_PERIODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_FINAL_PERIODO.Location = new System.Drawing.Point(120, 169);
            this.TXT_FINAL_PERIODO.Name = "TXT_FINAL_PERIODO";
            this.TXT_FINAL_PERIODO.Size = new System.Drawing.Size(161, 18);
            this.TXT_FINAL_PERIODO.TabIndex = 8;
            this.TXT_FINAL_PERIODO.Text = "TXT_FINAL_PERIODO";
            // 
            // TXT_INICIO_PERIODO
            // 
            this.TXT_INICIO_PERIODO.AutoSize = true;
            this.TXT_INICIO_PERIODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_INICIO_PERIODO.Location = new System.Drawing.Point(154, 145);
            this.TXT_INICIO_PERIODO.Name = "TXT_INICIO_PERIODO";
            this.TXT_INICIO_PERIODO.Size = new System.Drawing.Size(164, 18);
            this.TXT_INICIO_PERIODO.TabIndex = 7;
            this.TXT_INICIO_PERIODO.Text = "TXT_INICIO_PERIODO";
            // 
            // TXT_BAIRRO
            // 
            this.TXT_BAIRRO.AutoSize = true;
            this.TXT_BAIRRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_BAIRRO.Location = new System.Drawing.Point(72, 62);
            this.TXT_BAIRRO.Name = "TXT_BAIRRO";
            this.TXT_BAIRRO.Size = new System.Drawing.Size(100, 18);
            this.TXT_BAIRRO.TabIndex = 6;
            this.TXT_BAIRRO.Text = "TXT_BAIRRO";
            // 
            // TXT_ENDERECO
            // 
            this.TXT_ENDERECO.AutoSize = true;
            this.TXT_ENDERECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ENDERECO.Location = new System.Drawing.Point(94, 39);
            this.TXT_ENDERECO.Name = "TXT_ENDERECO";
            this.TXT_ENDERECO.Size = new System.Drawing.Size(130, 18);
            this.TXT_ENDERECO.TabIndex = 5;
            this.TXT_ENDERECO.Text = "TXT_ENDERECO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Finalização:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Início do Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tempo Decorrido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bairro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Grid_Pagamentos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 154);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAGAMENTOS";
            // 
            // Grid_Pagamentos
            // 
            this.Grid_Pagamentos.AllowUserToAddRows = false;
            this.Grid_Pagamentos.AllowUserToDeleteRows = false;
            this.Grid_Pagamentos.AllowUserToOrderColumns = true;
            this.Grid_Pagamentos.AllowUserToResizeRows = false;
            this.Grid_Pagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Pagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Pagamentos.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Pagamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Pagamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Pagamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid_Pagamentos.ColumnHeadersHeight = 28;
            this.Grid_Pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Pagamentos.DefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_Pagamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid_Pagamentos.EnableHeadersVisualStyles = false;
            this.Grid_Pagamentos.GridColor = System.Drawing.Color.White;
            this.Grid_Pagamentos.Location = new System.Drawing.Point(6, 28);
            this.Grid_Pagamentos.MultiSelect = false;
            this.Grid_Pagamentos.Name = "Grid_Pagamentos";
            this.Grid_Pagamentos.ReadOnly = true;
            this.Grid_Pagamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid_Pagamentos.RowHeadersVisible = false;
            this.Grid_Pagamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Pagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Pagamentos.ShowCellErrors = false;
            this.Grid_Pagamentos.ShowEditingIcon = false;
            this.Grid_Pagamentos.ShowRowErrors = false;
            this.Grid_Pagamentos.Size = new System.Drawing.Size(532, 120);
            this.Grid_Pagamentos.TabIndex = 2;
            this.Grid_Pagamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Grid_Pagamentos_CellFormatting);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ovGRD_Itens);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(349, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 222);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRODUTOS";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ovGRD_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ovGRD_Itens.ColumnHeadersHeight = 28;
            this.ovGRD_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ovGRD_Itens.DefaultCellStyle = dataGridViewCellStyle8;
            this.ovGRD_Itens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ovGRD_Itens.EnableHeadersVisualStyles = false;
            this.ovGRD_Itens.GridColor = System.Drawing.Color.White;
            this.ovGRD_Itens.Location = new System.Drawing.Point(6, 28);
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
            this.ovGRD_Itens.Size = new System.Drawing.Size(777, 188);
            this.ovGRD_Itens.TabIndex = 1;
            this.ovGRD_Itens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ovGRD_Itens_CellFormatting);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.TXT_TOTAL);
            this.groupBox4.Controls.Add(this.TXT_DESCONTO);
            this.groupBox4.Controls.Add(this.TXT_TROCO);
            this.groupBox4.Controls.Add(this.TXT_TAXAENTREGA);
            this.groupBox4.Controls.Add(this.TXT_VALORITENS);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(562, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 154);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TOTALIZADORES";
            // 
            // TXT_TOTAL
            // 
            this.TXT_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TOTAL.Location = new System.Drawing.Point(242, 122);
            this.TXT_TOTAL.Name = "TXT_TOTAL";
            this.TXT_TOTAL.Size = new System.Drawing.Size(162, 20);
            this.TXT_TOTAL.TabIndex = 14;
            this.TXT_TOTAL.Text = "TXT_TOTAL";
            // 
            // TXT_DESCONTO
            // 
            this.TXT_DESCONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DESCONTO.Location = new System.Drawing.Point(242, 97);
            this.TXT_DESCONTO.Name = "TXT_DESCONTO";
            this.TXT_DESCONTO.Size = new System.Drawing.Size(162, 20);
            this.TXT_DESCONTO.TabIndex = 13;
            this.TXT_DESCONTO.Text = "TXT_DESCONTO";
            // 
            // TXT_TROCO
            // 
            this.TXT_TROCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TROCO.Location = new System.Drawing.Point(242, 74);
            this.TXT_TROCO.Name = "TXT_TROCO";
            this.TXT_TROCO.Size = new System.Drawing.Size(168, 20);
            this.TXT_TROCO.TabIndex = 12;
            this.TXT_TROCO.Text = "TXT_TROCO";
            // 
            // TXT_TAXAENTREGA
            // 
            this.TXT_TAXAENTREGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TAXAENTREGA.Location = new System.Drawing.Point(242, 51);
            this.TXT_TAXAENTREGA.Name = "TXT_TAXAENTREGA";
            this.TXT_TAXAENTREGA.Size = new System.Drawing.Size(162, 20);
            this.TXT_TAXAENTREGA.TabIndex = 11;
            this.TXT_TAXAENTREGA.Text = "TXT_TAXAENTREGA";
            // 
            // TXT_VALORITENS
            // 
            this.TXT_VALORITENS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VALORITENS.Location = new System.Drawing.Point(242, 28);
            this.TXT_VALORITENS.Name = "TXT_VALORITENS";
            this.TXT_VALORITENS.Size = new System.Drawing.Size(162, 20);
            this.TXT_VALORITENS.TabIndex = 10;
            this.TXT_VALORITENS.Text = "TXT_VALORITENS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(17, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "TOTAL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label11.Location = new System.Drawing.Point(17, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Desconto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(17, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Troco:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(17, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tx. Entrega:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(17, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Valor Itens:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.SteelBlue;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.Location = new System.Drawing.Point(879, 568);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(127, 33);
            this.simpleButton2.TabIndex = 47;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "EDITAR PEDIDO";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.TXT_OBSERVACAOPEDIDO);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 400);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1126, 162);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OBSERVAÇÃO";
            // 
            // TXT_OBSERVACAOPEDIDO
            // 
            this.TXT_OBSERVACAOPEDIDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_OBSERVACAOPEDIDO.Location = new System.Drawing.Point(6, 22);
            this.TXT_OBSERVACAOPEDIDO.Name = "TXT_OBSERVACAOPEDIDO";
            this.TXT_OBSERVACAOPEDIDO.Size = new System.Drawing.Size(1114, 132);
            this.TXT_OBSERVACAOPEDIDO.TabIndex = 12;
            // 
            // FormConsultaPedidoDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 613);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaPedidoDelivery";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALHE DO PEDIDO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pagamentos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Itens)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TXT_ENDERECO;
        private System.Windows.Forms.Label TXT_BAIRRO;
        private System.Windows.Forms.Label TXT_FINAL_PERIODO;
        private System.Windows.Forms.Label TXT_INICIO_PERIODO;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TXT_TAXAENTREGA;
        private System.Windows.Forms.Label TXT_VALORITENS;
        private System.Windows.Forms.Label TXT_TOTAL;
        private System.Windows.Forms.Label TXT_DESCONTO;
        private System.Windows.Forms.Label TXT_TROCO;
        private System.Windows.Forms.DataGridView ovGRD_Itens;
        private System.Windows.Forms.DataGridView Grid_Pagamentos;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label TXT_OBSERVACAOPEDIDO;
    }
}