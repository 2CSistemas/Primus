namespace Aplicacao.UserControls
{
    partial class UCFiltroGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._deDataFinal = new DevExpress.XtraEditors.DateEdit();
            this.lbDataInicial = new DevExpress.XtraEditors.LabelControl();
            this.lbDataFinal = new DevExpress.XtraEditors.LabelControl();
            this._sbFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this._deDataInicial = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this._deDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deDataInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _deDataFinal
            // 
            this._deDataFinal.EditValue = null;
            this._deDataFinal.Location = new System.Drawing.Point(254, 7);
            this._deDataFinal.Name = "_deDataFinal";
            this._deDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this._deDataFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this._deDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._deDataFinal.Size = new System.Drawing.Size(119, 20);
            this._deDataFinal.TabIndex = 2;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.Location = new System.Drawing.Point(8, 10);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(57, 13);
            this.lbDataInicial.TabIndex = 10;
            this.lbDataInicial.Text = "Data Inicial:";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.Location = new System.Drawing.Point(196, 10);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(52, 13);
            this.lbDataFinal.TabIndex = 9;
            this.lbDataFinal.Text = "Data Final:";
            // 
            // _sbFiltrar
            // 
            this._sbFiltrar.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this._sbFiltrar.Location = new System.Drawing.Point(379, 6);
            this._sbFiltrar.Name = "_sbFiltrar";
            this._sbFiltrar.Size = new System.Drawing.Size(75, 21);
            this._sbFiltrar.TabIndex = 3;
            this._sbFiltrar.Text = "Filtrar";
            this._sbFiltrar.Click += new System.EventHandler(this._sbFiltrar_Click);
            // 
            // _deDataInicial
            // 
            this._deDataInicial.EditValue = null;
            this._deDataInicial.Location = new System.Drawing.Point(71, 7);
            this._deDataInicial.Name = "_deDataInicial";
            this._deDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._deDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this._deDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this._deDataInicial.Size = new System.Drawing.Size(119, 20);
            this._deDataInicial.TabIndex = 1;
            // 
            // UCFiltroGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._deDataFinal);
            this.Controls.Add(this.lbDataInicial);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this._sbFiltrar);
            this.Controls.Add(this._deDataInicial);
            this.Name = "UCFiltroGrid";
            this.Size = new System.Drawing.Size(815, 33);
            ((System.ComponentModel.ISupportInitialize)(this._deDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deDataInicial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit _deDataFinal;
        private DevExpress.XtraEditors.LabelControl lbDataInicial;
        private DevExpress.XtraEditors.LabelControl lbDataFinal;
        private DevExpress.XtraEditors.SimpleButton _sbFiltrar;
        private DevExpress.XtraEditors.DateEdit _deDataInicial;


    }
}
