namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaNotaCarregarPedidoPorFluxoCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ovGRD_Pedidos = new System.Windows.Forms.DataGridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_Pesquisa = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.SbQuantidade = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Pesquisa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ovGRD_Pedidos
            // 
            this.ovGRD_Pedidos.AllowUserToAddRows = false;
            this.ovGRD_Pedidos.AllowUserToDeleteRows = false;
            this.ovGRD_Pedidos.AllowUserToOrderColumns = true;
            this.ovGRD_Pedidos.AllowUserToResizeRows = false;
            this.ovGRD_Pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_Pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ovGRD_Pedidos.BackgroundColor = System.Drawing.Color.White;
            this.ovGRD_Pedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ovGRD_Pedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ovGRD_Pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ovGRD_Pedidos.ColumnHeadersHeight = 28;
            this.ovGRD_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ovGRD_Pedidos.DefaultCellStyle = dataGridViewCellStyle8;
            this.ovGRD_Pedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ovGRD_Pedidos.EnableHeadersVisualStyles = false;
            this.ovGRD_Pedidos.GridColor = System.Drawing.Color.White;
            this.ovGRD_Pedidos.Location = new System.Drawing.Point(23, 99);
            this.ovGRD_Pedidos.MultiSelect = false;
            this.ovGRD_Pedidos.Name = "ovGRD_Pedidos";
            this.ovGRD_Pedidos.ReadOnly = true;
            this.ovGRD_Pedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ovGRD_Pedidos.RowHeadersVisible = false;
            this.ovGRD_Pedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ovGRD_Pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ovGRD_Pedidos.ShowCellErrors = false;
            this.ovGRD_Pedidos.ShowEditingIcon = false;
            this.ovGRD_Pedidos.ShowRowErrors = false;
            this.ovGRD_Pedidos.Size = new System.Drawing.Size(954, 437);
            this.ovGRD_Pedidos.TabIndex = 2;
            this.ovGRD_Pedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ovGRD_Pedidos_CellFormatting);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseImageAlign = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 120;
            this.labelControl2.Text = "Pesquisa:";
            // 
            // TXT_Pesquisa
            // 
            this.TXT_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Pesquisa.CwkFuncaoValidacao = null;
            this.TXT_Pesquisa.CwkMascara = null;
            this.TXT_Pesquisa.CwkValidacao = null;
            this.TXT_Pesquisa.Location = new System.Drawing.Point(111, 63);
            this.TXT_Pesquisa.Name = "TXT_Pesquisa";
            this.TXT_Pesquisa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Pesquisa.Properties.Appearance.Options.UseFont = true;
            this.TXT_Pesquisa.SelecionarTextoOnEnter = true;
            this.TXT_Pesquisa.Size = new System.Drawing.Size(866, 30);
            this.TXT_Pesquisa.TabIndex = 119;
            // 
            // SbQuantidade
            // 
            this.SbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SbQuantidade.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.SbQuantidade.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.SbQuantidade.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbQuantidade.Appearance.ForeColor = System.Drawing.Color.White;
            this.SbQuantidade.Appearance.Options.UseBackColor = true;
            this.SbQuantidade.Appearance.Options.UseFont = true;
            this.SbQuantidade.Appearance.Options.UseForeColor = true;
            this.SbQuantidade.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.SbQuantidade.Location = new System.Drawing.Point(494, 542);
            this.SbQuantidade.Name = "SbQuantidade";
            this.SbQuantidade.Size = new System.Drawing.Size(135, 35);
            this.SbQuantidade.TabIndex = 121;
            this.SbQuantidade.TabStop = false;
            this.SbQuantidade.Text = "FECHAR";
            this.SbQuantidade.Click += new System.EventHandler(this.SbQuantidade_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(635, 542);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 35);
            this.simpleButton1.TabIndex = 122;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "IMPRIMIR PEDIDO";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.Location = new System.Drawing.Point(809, 542);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(168, 35);
            this.simpleButton2.TabIndex = 123;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "IMPRIMIR NFC-E";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FormFrenteCaixaNotaCarregarPedidoPorFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SbQuantidade);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TXT_Pesquisa);
            this.Controls.Add(this.ovGRD_Pedidos);
            this.Name = "FormFrenteCaixaNotaCarregarPedidoPorFluxoCaixa";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Pedidos do Fluxo de Caixa";
            this.Shown += new System.EventHandler(this.FormFrenteCaixaNotaCarregarPedido_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Pesquisa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ovGRD_Pedidos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_Pesquisa;
        private DevExpress.XtraEditors.SimpleButton SbQuantidade;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}