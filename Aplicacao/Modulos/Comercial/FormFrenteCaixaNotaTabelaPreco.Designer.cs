
namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaNotaTabelaPreco
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 24;
            this.ListBox.Location = new System.Drawing.Point(23, 63);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(505, 508);
            this.ListBox.TabIndex = 0;
            this.ListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ListBox_Format);
            this.ListBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            this.ListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyUp);
            // 
            // FormFrenteCaixaNotaTabelaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 613);
            this.Controls.Add(this.ListBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFrenteCaixaNotaTabelaPreco";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Tabela de Preço Produto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
    }
}