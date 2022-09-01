namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaPedidosDelivery
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
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Pedidos)).BeginInit();
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
            this.ovGRD_Pedidos.Location = new System.Drawing.Point(12, 12);
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
            this.ovGRD_Pedidos.Size = new System.Drawing.Size(960, 617);
            this.ovGRD_Pedidos.TabIndex = 1;
            this.ovGRD_Pedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ovGRD_Pedidos_CellFormatting);
            this.ovGRD_Pedidos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ovGRD_Pedidos_CellMouseDoubleClick);
            // 
            // FormFrenteCaixaPedidosDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.ovGRD_Pedidos);
            this.MinimizeBox = false;
            this.Name = "FormFrenteCaixaPedidosDelivery";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA DE PEDIDOS";
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ovGRD_Pedidos;
    }
}