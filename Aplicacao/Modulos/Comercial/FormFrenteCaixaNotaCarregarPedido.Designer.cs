namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaNotaCarregarPedido
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
            this.ovGRD_Pedidos = new System.Windows.Forms.DataGridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_Pesquisa = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ovGRD_Pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ovGRD_Pedidos.ColumnHeadersHeight = 28;
            this.ovGRD_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ovGRD_Pedidos.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.ovGRD_Pedidos.Size = new System.Drawing.Size(954, 478);
            this.ovGRD_Pedidos.TabIndex = 2;
            this.ovGRD_Pedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ovGRD_Pedidos_CellFormatting);
            this.ovGRD_Pedidos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ovGRD_Pedidos_CellMouseDoubleClick);
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
            // FormFrenteCaixaNotaCarregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TXT_Pesquisa);
            this.Controls.Add(this.ovGRD_Pedidos);
            this.Name = "FormFrenteCaixaNotaCarregarPedido";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Carregar Pedidos";
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
    }
}