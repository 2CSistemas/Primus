namespace Aplicacao.Relatorios
{
    partial class FormStatusMercadoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatusMercadoria));
            this.cbClienteTodos = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.cbTipo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFim = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtInicio = new DevExpress.XtraEditors.DateEdit();
            this.lkbTransportadora = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTransportadora = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbTransportadoraTodos = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClienteTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTransportadora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransportadoraTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(713, 266);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTransportadoraTodos);
            this.tabPage1.Controls.Add(this.lkbTransportadora);
            this.tabPage1.Controls.Add(this.lkpTransportadora);
            this.tabPage1.Controls.Add(this.labelControl6);
            this.tabPage1.Controls.Add(this.txtFim);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.txtInicio);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.cbTipo);
            this.tabPage1.Controls.Add(this.lkbCliente);
            this.tabPage1.Controls.Add(this.lkpCliente);
            this.tabPage1.Controls.Add(this.cbClienteTodos);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Size = new System.Drawing.Size(706, 259);
            this.tabPage1.Controls.SetChildIndex(this.gcEmpresas, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbClienteTodos, 0);
            this.tabPage1.Controls.SetChildIndex(this.lkpCliente, 0);
            this.tabPage1.Controls.SetChildIndex(this.lkbCliente, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbTipo, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtInicio, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl5, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl4, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtFim, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl6, 0);
            this.tabPage1.Controls.SetChildIndex(this.lkpTransportadora, 0);
            this.tabPage1.Controls.SetChildIndex(this.lkbTransportadora, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbTransportadoraTodos, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(571, 284);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(650, 284);
            // 
            // cbGrupo
            // 
            // 
            // gcEmpresas
            // 
            this.gcEmpresas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcEmpresas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcEmpresas.LookAndFeel.UseWindowsXPTheme = true;
            // 
            // gvEmpresas
            // 
            this.gvEmpresas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.Empty.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEmpresas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvEmpresas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEmpresas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvEmpresas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEmpresas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvEmpresas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvEmpresas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.Preview.Options.UseFont = true;
            this.gvEmpresas.Appearance.Preview.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvEmpresas.Appearance.Row.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvEmpresas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvEmpresas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEmpresas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvEmpresas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEmpresas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvEmpresas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvEmpresas.OptionsBehavior.Editable = false;
            this.gvEmpresas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvEmpresas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmpresas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEmpresas.OptionsView.ShowGroupPanel = false;
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 288);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 284);
            // 
            // cbClienteTodos
            // 
            this.cbClienteTodos.Location = new System.Drawing.Point(626, 182);
            this.cbClienteTodos.Name = "cbClienteTodos";
            this.cbClienteTodos.Properties.Caption = "Todos";
            this.cbClienteTodos.Size = new System.Drawing.Size(55, 19);
            this.cbClienteTodos.TabIndex = 7;
            this.cbClienteTodos.CheckedChanged += new System.EventHandler(this.cbClienteTodos_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cliente: ";
            // 
            // lkbCliente
            // 
            this.lkbCliente.Location = new System.Drawing.Point(596, 181);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.TabIndex = 6;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // lkpCliente
            // 
            this.lkpCliente.ButtonLookup = this.lkbCliente;
            this.lkpCliente.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpCliente.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesAND")));
            this.lkpCliente.CamposRestricoesNOT = null;
            this.lkpCliente.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesOR")));
            this.lkpCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpCliente.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpCliente.ContextoLinq = null;
            this.lkpCliente.CwkFuncaoValidacao = null;
            this.lkpCliente.CwkMascara = null;
            this.lkpCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCliente.Exemplo = null;
            this.lkpCliente.ID = 0;
            this.lkpCliente.Join = null;
            this.lkpCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpCliente.Location = new System.Drawing.Point(94, 181);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = true;
            this.lkpCliente.Size = new System.Drawing.Size(496, 20);
            this.lkpCliente.Tabela = null;
            this.lkpCliente.TabIndex = 5;
            this.lkpCliente.TituloTelaPesquisa = null;
            this.lkpCliente.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpCliente.Where = null;
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "Última Semana";
            this.cbTipo.Location = new System.Drawing.Point(94, 233);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.Items.AddRange(new object[] {
            "Última Semana",
            "Últimos 15 dias",
            "Últimos 30 dias",
            "Últimos 45 dias",
            "Específico"});
            this.cbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipo.Size = new System.Drawing.Size(179, 20);
            this.cbTipo.TabIndex = 13;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 236);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Tipo Período: ";
            // 
            // txtFim
            // 
            this.txtFim.EditValue = null;
            this.txtFim.Enabled = false;
            this.txtFim.Location = new System.Drawing.Point(450, 233);
            this.txtFim.Name = "txtFim";
            this.txtFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtFim.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFim.Size = new System.Drawing.Size(100, 20);
            this.txtFim.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(286, 236);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Período:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(438, 236);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(6, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "à";
            // 
            // txtInicio
            // 
            this.txtInicio.EditValue = null;
            this.txtInicio.Enabled = false;
            this.txtInicio.Location = new System.Drawing.Point(332, 233);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 15;
            // 
            // lkbTransportadora
            // 
            this.lkbTransportadora.Location = new System.Drawing.Point(596, 207);
            this.lkbTransportadora.Lookup = null;
            this.lkbTransportadora.Name = "lkbTransportadora";
            this.lkbTransportadora.Size = new System.Drawing.Size(24, 20);
            this.lkbTransportadora.SubForm = null;
            this.lkbTransportadora.TabIndex = 10;
            this.lkbTransportadora.TabStop = false;
            this.lkbTransportadora.Text = "...";
            this.lkbTransportadora.Click += new System.EventHandler(this.lkbTransportadora_Click);
            // 
            // lkpTransportadora
            // 
            this.lkpTransportadora.ButtonLookup = this.lkbTransportadora;
            this.lkpTransportadora.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpTransportadora.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTransportadora.CamposRestricoesAND")));
            this.lkpTransportadora.CamposRestricoesNOT = null;
            this.lkpTransportadora.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTransportadora.CamposRestricoesOR")));
            this.lkpTransportadora.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpTransportadora.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpTransportadora.ContextoLinq = null;
            this.lkpTransportadora.CwkFuncaoValidacao = null;
            this.lkpTransportadora.CwkMascara = null;
            this.lkpTransportadora.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTransportadora.Exemplo = null;
            this.lkpTransportadora.ID = 0;
            this.lkpTransportadora.Join = null;
            this.lkpTransportadora.Key = System.Windows.Forms.Keys.F5;
            this.lkpTransportadora.Location = new System.Drawing.Point(94, 207);
            this.lkpTransportadora.Name = "lkpTransportadora";
            this.lkpTransportadora.OnIDChanged = null;
            this.lkpTransportadora.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTransportadora.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTransportadora.SelecionarTextoOnEnter = true;
            this.lkpTransportadora.Size = new System.Drawing.Size(496, 20);
            this.lkpTransportadora.Tabela = null;
            this.lkpTransportadora.TabIndex = 9;
            this.lkpTransportadora.TituloTelaPesquisa = null;
            this.lkpTransportadora.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpTransportadora.Where = null;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 210);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Transportadora: ";
            // 
            // cbTransportadoraTodos
            // 
            this.cbTransportadoraTodos.Location = new System.Drawing.Point(626, 208);
            this.cbTransportadoraTodos.Name = "cbTransportadoraTodos";
            this.cbTransportadoraTodos.Properties.Caption = "Todos";
            this.cbTransportadoraTodos.Size = new System.Drawing.Size(55, 19);
            this.cbTransportadoraTodos.TabIndex = 11;
            this.cbTransportadoraTodos.CheckedChanged += new System.EventHandler(this.cbTransportadoraTodos_CheckedChanged);
            // 
            // FormStatusMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(737, 313);
            this.Name = "FormStatusMercadoria";
            this.Text = "Relatório de Status Mercadoria";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClienteTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTransportadora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransportadoraTodos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbClienteTodos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipo;
        private DevExpress.XtraEditors.DateEdit txtFim;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit txtInicio;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTransportadora;
        private Cwork.Utilitarios.Componentes.Lookup lkpTransportadora;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit cbTransportadoraTodos;
    }
}
