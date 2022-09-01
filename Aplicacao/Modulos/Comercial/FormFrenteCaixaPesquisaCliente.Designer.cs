namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaPesquisaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ovGRD_Pessoas = new System.Windows.Forms.DataGridView();
            this.textoLeiTableAdapter1 = new Aplicacao.BancoDemoDataSetTableAdapters.TextoLeiTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_Pesquisa = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Pessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Pesquisa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ovGRD_Pessoas
            // 
            this.ovGRD_Pessoas.AllowUserToAddRows = false;
            this.ovGRD_Pessoas.AllowUserToDeleteRows = false;
            this.ovGRD_Pessoas.AllowUserToOrderColumns = true;
            this.ovGRD_Pessoas.AllowUserToResizeRows = false;
            this.ovGRD_Pessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_Pessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ovGRD_Pessoas.BackgroundColor = System.Drawing.Color.White;
            this.ovGRD_Pessoas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ovGRD_Pessoas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ovGRD_Pessoas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ovGRD_Pessoas.ColumnHeadersHeight = 28;
            this.ovGRD_Pessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ovGRD_Pessoas.DefaultCellStyle = dataGridViewCellStyle4;
            this.ovGRD_Pessoas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ovGRD_Pessoas.EnableHeadersVisualStyles = false;
            this.ovGRD_Pessoas.GridColor = System.Drawing.Color.White;
            this.ovGRD_Pessoas.Location = new System.Drawing.Point(12, 48);
            this.ovGRD_Pessoas.MultiSelect = false;
            this.ovGRD_Pessoas.Name = "ovGRD_Pessoas";
            this.ovGRD_Pessoas.ReadOnly = true;
            this.ovGRD_Pessoas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ovGRD_Pessoas.RowHeadersVisible = false;
            this.ovGRD_Pessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ovGRD_Pessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ovGRD_Pessoas.ShowCellErrors = false;
            this.ovGRD_Pessoas.ShowEditingIcon = false;
            this.ovGRD_Pessoas.ShowRowErrors = false;
            this.ovGRD_Pessoas.Size = new System.Drawing.Size(1160, 581);
            this.ovGRD_Pessoas.TabIndex = 1;
            this.ovGRD_Pessoas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ovGRD_Pedidos_CellFormatting);
            this.ovGRD_Pessoas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ovGRD_Pedidos_CellMouseDoubleClick);
            // 
            // textoLeiTableAdapter1
            // 
            this.textoLeiTableAdapter1.ClearBeforeFill = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseImageAlign = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 118;
            this.labelControl2.Text = "Pesquisa:";
            // 
            // TXT_Pesquisa
            // 
            this.TXT_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Pesquisa.CwkFuncaoValidacao = null;
            this.TXT_Pesquisa.CwkMascara = null;
            this.TXT_Pesquisa.CwkValidacao = null;
            this.TXT_Pesquisa.Location = new System.Drawing.Point(100, 12);
            this.TXT_Pesquisa.Name = "TXT_Pesquisa";
            this.TXT_Pesquisa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Pesquisa.Properties.Appearance.Options.UseFont = true;
            this.TXT_Pesquisa.SelecionarTextoOnEnter = true;
            this.TXT_Pesquisa.Size = new System.Drawing.Size(1072, 30);
            this.TXT_Pesquisa.TabIndex = 117;
            this.TXT_Pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_Pesquisa_KeyUp);
            // 
            // FormFrenteCaixaPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TXT_Pesquisa);
            this.Controls.Add(this.ovGRD_Pessoas);
            this.MinimizeBox = false;
            this.Name = "FormFrenteCaixaPesquisaCliente";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA DE PEDIDOS";
            this.Shown += new System.EventHandler(this.FormFrenteCaixaPesquisaCliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Pessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Pesquisa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ovGRD_Pessoas;
        private BancoDemoDataSetTableAdapters.TextoLeiTableAdapter textoLeiTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_Pesquisa;
    }
}