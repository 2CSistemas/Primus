namespace Aplicacao
{
    partial class FormManutServicoOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutServicoOS));
            this.txtTempoHoras = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbIdResponsavel = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataTermino = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicio = new DevExpress.XtraEditors.DateEdit();
            this.cbIdServico = new Componentes.devexpress.cwk_DevLookup();
            this.sbAdServico = new Componentes.devexpress.cwk_DevButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new DevExpress.XtraEditors.MemoEdit();
            this.txtResumo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoHoras.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoHoras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdResponsavel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResumo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(683, 264);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtTempoHoras);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.cbIdResponsavel);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtDataTermino);
            this.xtraTabPage1.Controls.Add(this.labelControl13);
            this.xtraTabPage1.Controls.Add(this.txtDataInicio);
            this.xtraTabPage1.Controls.Add(this.cbIdServico);
            this.xtraTabPage1.Controls.Add(this.sbAdServico);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.txtDescricao);
            this.xtraTabPage1.Controls.Add(this.txtResumo);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.txtCodigo);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Size = new System.Drawing.Size(674, 255);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(620, 282);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(539, 282);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 282);
            // 
            // txtTempoHoras
            // 
            this.txtTempoHoras.EditValue = null;
            this.txtTempoHoras.Location = new System.Drawing.Point(560, 199);
            this.txtTempoHoras.Name = "txtTempoHoras";
            this.txtTempoHoras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtTempoHoras.Properties.DisplayFormat.FormatString = "t";
            this.txtTempoHoras.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTempoHoras.Properties.EditFormat.FormatString = "t";
            this.txtTempoHoras.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTempoHoras.Properties.Mask.EditMask = "t";
            this.txtTempoHoras.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtTempoHoras.Size = new System.Drawing.Size(79, 20);
            this.txtTempoHoras.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(499, 202);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Tempo Hrs:";
            // 
            // cbIdResponsavel
            // 
            this.cbIdResponsavel.ButtonLookup = null;
            this.cbIdResponsavel.Key = System.Windows.Forms.Keys.F5;
            this.cbIdResponsavel.Location = new System.Drawing.Point(76, 225);
            this.cbIdResponsavel.Name = "cbIdResponsavel";
            this.cbIdResponsavel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdResponsavel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "Nome", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbIdResponsavel.Properties.DisplayMember = "nome";
            this.cbIdResponsavel.Properties.NullText = "";
            this.cbIdResponsavel.Properties.ValueMember = "id";
            this.cbIdResponsavel.Size = new System.Drawing.Size(563, 20);
            this.cbIdResponsavel.TabIndex = 16;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 228);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 13);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Responsável:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(259, 202);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Data Término:";
            // 
            // txtDataTermino
            // 
            this.txtDataTermino.EditValue = null;
            this.txtDataTermino.Location = new System.Drawing.Point(333, 199);
            this.txtDataTermino.Name = "txtDataTermino";
            this.txtDataTermino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataTermino.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataTermino.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataTermino.Size = new System.Drawing.Size(79, 20);
            this.txtDataTermino.TabIndex = 12;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(15, 202);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(55, 13);
            this.labelControl13.TabIndex = 9;
            this.labelControl13.Text = "Data Início:";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.EditValue = null;
            this.txtDataInicio.Location = new System.Drawing.Point(76, 199);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicio.Size = new System.Drawing.Size(79, 20);
            this.txtDataInicio.TabIndex = 10;
            // 
            // cbIdServico
            // 
            this.cbIdServico.ButtonLookup = this.sbAdServico;
            this.cbIdServico.Key = System.Windows.Forms.Keys.F5;
            this.cbIdServico.Location = new System.Drawing.Point(76, 35);
            this.cbIdServico.Name = "cbIdServico";
            this.cbIdServico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdServico.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbIdServico.Properties.DisplayMember = "Nome";
            this.cbIdServico.Properties.NullText = "";
            this.cbIdServico.Properties.ValueMember = "ID";
            this.cbIdServico.Size = new System.Drawing.Size(563, 20);
            this.cbIdServico.TabIndex = 3;
            // 
            // sbAdServico
            // 
            this.sbAdServico.Location = new System.Drawing.Point(645, 35);
            this.sbAdServico.Name = "sbAdServico";
            this.sbAdServico.Size = new System.Drawing.Size(24, 20);
            this.sbAdServico.TabIndex = 4;
            this.sbAdServico.TabStop = false;
            this.sbAdServico.Text = "...";
            this.sbAdServico.Click += new System.EventHandler(this.sbAdServico_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Serviço:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(20, 90);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(50, 13);
            this.labelControl10.TabIndex = 7;
            this.labelControl10.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(76, 87);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(563, 106);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(76, 61);
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(563, 20);
            this.txtResumo.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(28, 64);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Resumo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCodigo.Location = new System.Drawing.Point(76, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtCodigo.Properties.IsFloatValue = false;
            this.txtCodigo.Properties.Mask.EditMask = "N00";
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(33, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Código:";
            // 
            // FormManutServicoOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(707, 317);
            this.Name = "FormManutServicoOS";
            this.Text = "Serviço ";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoHoras.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempoHoras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdResponsavel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResumo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtTempoHoras;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Componentes.devexpress.cwk_DevLookup cbIdResponsavel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit txtDataTermino;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.DateEdit txtDataInicio;
        private Componentes.devexpress.cwk_DevLookup cbIdServico;
        private Componentes.devexpress.cwk_DevButton sbAdServico;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit txtDescricao;
        private DevExpress.XtraEditors.TextEdit txtResumo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
