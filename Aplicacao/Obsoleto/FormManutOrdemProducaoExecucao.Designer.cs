namespace Aplicacao
{
    partial class FormManutOrdemProducaoExecucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutOrdemProducaoExecucao));
            this.txtSequencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicio = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataTermino = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lkbServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkFuncionario = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFuncionario = new Cwork.Utilitarios.Componentes.LookupButton();
            this.timeDataInicio = new DevExpress.XtraEditors.TimeEdit();
            this.timeDataTermino = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataTermino.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(557, 170);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.timeDataTermino);
            this.xtraTabPage1.Controls.Add(this.timeDataInicio);
            this.xtraTabPage1.Controls.Add(this.lkbFuncionario);
            this.xtraTabPage1.Controls.Add(this.lkFuncionario);
            this.xtraTabPage1.Controls.Add(this.lkbServico);
            this.xtraTabPage1.Controls.Add(this.lkServico);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.txtDataTermino);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtDataInicio);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl23);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtQuantidade);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtDescricao);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtSequencia);
            this.xtraTabPage1.Size = new System.Drawing.Size(548, 161);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(494, 188);
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
            this.imageList1.Images.SetKeyName(7, "Selecionar.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(413, 188);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 188);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = null;
            this.txtSequencia.Location = new System.Drawing.Point(69, 4);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(100, 20);
            this.txtSequencia.TabIndex = 1;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sequência:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = null;
            this.txtDescricao.Location = new System.Drawing.Point(69, 56);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(446, 20);
            this.txtDescricao.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = null;
            this.txtQuantidade.CwkValidacao = null;
            this.txtQuantidade.Location = new System.Drawing.Point(69, 82);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Mask.EditMask = "n2";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(4, 111);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(59, 13);
            this.labelControl23.TabIndex = 9;
            this.labelControl23.Text = "Funcionário:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Serviço:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(34, 137);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Início:";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.EditValue = null;
            this.txtDataInicio.Location = new System.Drawing.Point(69, 134);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicio.Size = new System.Drawing.Size(80, 20);
            this.txtDataInicio.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(308, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Término:";
            // 
            // txtDataTermino
            // 
            this.txtDataTermino.EditValue = null;
            this.txtDataTermino.Location = new System.Drawing.Point(356, 134);
            this.txtDataTermino.Name = "txtDataTermino";
            this.txtDataTermino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataTermino.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataTermino.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataTermino.Size = new System.Drawing.Size(80, 20);
            this.txtDataTermino.TabIndex = 15;
            // 
            // lkbServico
            // 
            this.lkbServico.Location = new System.Drawing.Point(521, 30);
            this.lkbServico.Lookup = null;
            this.lkbServico.Name = "lkbServico";
            this.lkbServico.Size = new System.Drawing.Size(24, 20);
            this.lkbServico.SubForm = null;
            this.lkbServico.TabIndex = 4;
            this.lkbServico.TabStop = false;
            this.lkbServico.Text = "...";
            this.lkbServico.Click += new System.EventHandler(this.lkbServico_Click);
            // 
            // lkServico
            // 
            this.lkServico.ButtonLookup = this.lkbServico;
            this.lkServico.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
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
            this.lkServico.Location = new System.Drawing.Point(69, 30);
            this.lkServico.Name = "lkServico";
            this.lkServico.OnIDChanged = null;
            this.lkServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkServico.SelecionarTextoOnEnter = false;
            this.lkServico.Size = new System.Drawing.Size(446, 20);
            this.lkServico.Tabela = "Servico";
            this.lkServico.TabIndex = 3;
            this.lkServico.TituloTelaPesquisa = "Pesquisa - Serviço";
            this.lkServico.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkServico.Where = null;
            // 
            // lkFuncionario
            // 
            this.lkFuncionario.ButtonLookup = this.lkbFuncionario;
            this.lkFuncionario.CamposPesquisa = new string[] {
        "Pessoa.Nome",
        "=Pessoa.Codigo"};
            this.lkFuncionario.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkFuncionario.CamposRestricoesAND")));
            this.lkFuncionario.CamposRestricoesNOT = null;
            this.lkFuncionario.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkFuncionario.CamposRestricoesOR")));
            this.lkFuncionario.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkFuncionario.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkFuncionario.ContextoLinq = null;
            this.lkFuncionario.CwkFuncaoValidacao = null;
            this.lkFuncionario.CwkMascara = null;
            this.lkFuncionario.CwkValidacao = null;
            this.lkFuncionario.Exemplo = null;
            this.lkFuncionario.ID = 0;
            this.lkFuncionario.Join = "INNER JOIN Pessoa ON Pessoa.ID = PessoaFuncionario.IDPessoa";
            this.lkFuncionario.Key = System.Windows.Forms.Keys.F5;
            this.lkFuncionario.Location = new System.Drawing.Point(69, 108);
            this.lkFuncionario.Name = "lkFuncionario";
            this.lkFuncionario.OnIDChanged = null;
            this.lkFuncionario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkFuncionario.Properties.Appearance.Options.UseBackColor = true;
            this.lkFuncionario.SelecionarTextoOnEnter = false;
            this.lkFuncionario.Size = new System.Drawing.Size(446, 20);
            this.lkFuncionario.Tabela = "PessoaFuncionario";
            this.lkFuncionario.TabIndex = 10;
            this.lkFuncionario.TituloTelaPesquisa = "Pesquisa - Funcionário";
            this.lkFuncionario.ToolTip = "Campos pesquisados: Pessoa.Nome, Pessoa.Codigo.";
            this.lkFuncionario.Where = "Pessoa.bFuncionario = 1 and";
            // 
            // lkbFuncionario
            // 
            this.lkbFuncionario.Location = new System.Drawing.Point(521, 108);
            this.lkbFuncionario.Lookup = null;
            this.lkbFuncionario.Name = "lkbFuncionario";
            this.lkbFuncionario.Size = new System.Drawing.Size(24, 20);
            this.lkbFuncionario.SubForm = null;
            this.lkbFuncionario.TabIndex = 11;
            this.lkbFuncionario.TabStop = false;
            this.lkbFuncionario.Text = "...";
            this.lkbFuncionario.Click += new System.EventHandler(this.lkbFuncionario_Click);
            // 
            // timeDataInicio
            // 
            this.timeDataInicio.EditValue = new System.DateTime(2011, 6, 17, 0, 0, 0, 0);
            this.timeDataInicio.Location = new System.Drawing.Point(155, 134);
            this.timeDataInicio.Name = "timeDataInicio";
            this.timeDataInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeDataInicio.Size = new System.Drawing.Size(73, 20);
            this.timeDataInicio.TabIndex = 16;
            // 
            // timeDataTermino
            // 
            this.timeDataTermino.EditValue = new System.DateTime(2011, 6, 17, 0, 0, 0, 0);
            this.timeDataTermino.Location = new System.Drawing.Point(442, 134);
            this.timeDataTermino.Name = "timeDataTermino";
            this.timeDataTermino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeDataTermino.Size = new System.Drawing.Size(73, 20);
            this.timeDataTermino.TabIndex = 16;
            // 
            // FormManutOrdemProducaoExecucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(581, 223);
            this.Name = "FormManutOrdemProducaoExecucao";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataTermino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataTermino.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataTermino;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicio;
        private Cwork.Utilitarios.Componentes.LookupButton lkbServico;
        private Cwork.Utilitarios.Componentes.Lookup lkServico;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFuncionario;
        private Cwork.Utilitarios.Componentes.Lookup lkFuncionario;
        private DevExpress.XtraEditors.TimeEdit timeDataTermino;
        private DevExpress.XtraEditors.TimeEdit timeDataInicio;
    }
}
