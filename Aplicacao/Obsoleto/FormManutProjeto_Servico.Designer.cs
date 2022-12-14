namespace Aplicacao
{
    partial class FormManutProjeto_Servico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutProjeto_Servico));
            this.lkbServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorTotal = new DevExpress.XtraEditors.CalcEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(572, 93);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtValorTotal);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtValorUnitario);
            this.xtraTabPage1.Controls.Add(this.txtQuantidade);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.lkbServico);
            this.xtraTabPage1.Controls.Add(this.lkServico);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Size = new System.Drawing.Size(563, 84);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(509, 111);
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
            this.sbGravar.Location = new System.Drawing.Point(428, 111);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 111);
            // 
            // lkbServico
            // 
            this.lkbServico.Location = new System.Drawing.Point(534, 6);
            this.lkbServico.Lookup = null;
            this.lkbServico.Name = "lkbServico";
            this.lkbServico.Size = new System.Drawing.Size(24, 20);
            this.lkbServico.SubForm = null;
            this.lkbServico.TabIndex = 2;
            this.lkbServico.TabStop = false;
            this.lkbServico.Text = "...";
            this.lkbServico.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // lkServico
            // 
            this.lkServico.ButtonLookup = this.lkbServico;
            this.lkServico.CamposPesquisa = new string[] {
        "nome",
        "=codigo"};
            this.lkServico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkServico.CamposRestricoesAND")));
            this.lkServico.CamposRestricoesNOT = null;
            this.lkServico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkServico.CamposRestricoesOR")));
            this.lkServico.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkServico.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkServico.ContextoLinq = null;
            this.lkServico.CwkFuncaoValidacao = null;
            this.lkServico.CwkMascara = null;
            this.lkServico.CwkValidacao = null;
            this.lkServico.Exemplo = null;
            this.lkServico.ID = 0;
            this.lkServico.Join = null;
            this.lkServico.Key = System.Windows.Forms.Keys.F5;
            this.lkServico.Location = new System.Drawing.Point(57, 6);
            this.lkServico.Name = "lkServico";
            this.lkServico.OnIDChanged = null;
            this.lkServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkServico.SelecionarTextoOnEnter = false;
            this.lkServico.Size = new System.Drawing.Size(471, 20);
            this.lkServico.Tabela = "Servico";
            this.lkServico.TabIndex = 1;
            this.lkServico.TituloTelaPesquisa = "Pesquisa - Serviço";
            this.lkServico.ToolTip = "Campos pesquisados: nome, codigo.";
            this.lkServico.Where = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviço:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quant.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(57, 32);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantidade.Properties.DisplayFormat.FormatString = "F4";
            this.txtQuantidade.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantidade.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantidade.Properties.MaxLength = 10;
            this.txtQuantidade.Properties.Precision = 4;
            this.txtQuantidade.Properties.EditValueChanged += new System.EventHandler(this.txtQuantidade_Properties_EditValueChanged);
            this.txtQuantidade.Size = new System.Drawing.Size(115, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(413, 58);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtValorTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtValorTotal.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorTotal.Properties.Precision = 2;
            this.txtValorTotal.Properties.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(115, 20);
            this.txtValorTotal.TabIndex = 8;
            this.txtValorTotal.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Unitário:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(413, 32);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorUnitario.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorUnitario.Properties.Precision = 2;
            this.txtValorUnitario.Properties.EditValueChanged += new System.EventHandler(this.txtValorUnitario_Properties_EditValueChanged);
            this.txtValorUnitario.Size = new System.Drawing.Size(115, 20);
            this.txtValorUnitario.TabIndex = 6;
            // 
            // FormManutProjeto_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(596, 146);
            this.Name = "FormManutProjeto_Servico";
            this.Text = "Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbServico;
        private Cwork.Utilitarios.Componentes.Lookup lkServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtQuantidade;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CalcEdit txtValorTotal;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CalcEdit txtValorUnitario;
    }
}
