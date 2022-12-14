namespace Aplicacao
{
    partial class FormOSAgendamento
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSAgendamento));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnCancelarAgendamento = new DevExpress.XtraEditors.SimpleButton();
            this.pnlNaoValidar = new System.Windows.Forms.Panel();
            this.btnAvancar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRetroceder = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoListagem = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.gridAgendamentos = new DevExpress.XtraScheduler.SchedulerControl();
            this.stoAgendamentos = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.btnAgendar = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFim = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDt = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lkbTecnico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTecnico = new Cwork.Utilitarios.Componentes.Lookup();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInicio = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbOS = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpOS = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblBanco = new System.Windows.Forms.Label();
            this.pnlNaoValidar2 = new System.Windows.Forms.Panel();
            this.btnAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.pnlNaoValidar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoListagem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTecnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOS.Properties)).BeginInit();
            this.pnlNaoValidar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(970, 525);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnCancelarAgendamento);
            this.xtraTabPage1.Controls.Add(this.pnlNaoValidar);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.cbTipoListagem);
            this.xtraTabPage1.Controls.Add(this.gridAgendamentos);
            this.xtraTabPage1.Controls.Add(this.btnAgendar);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtFim);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtDt);
            this.xtraTabPage1.Controls.Add(this.lkbTecnico);
            this.xtraTabPage1.Controls.Add(this.lkpTecnico);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtInicio);
            this.xtraTabPage1.Controls.Add(this.lkbOS);
            this.xtraTabPage1.Controls.Add(this.lkpOS);
            this.xtraTabPage1.Controls.Add(this.lblBanco);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(964, 519);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // btnCancelarAgendamento
            // 
            this.btnCancelarAgendamento.ImageOptions.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.btnCancelarAgendamento.Location = new System.Drawing.Point(874, 490);
            this.btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            this.btnCancelarAgendamento.Size = new System.Drawing.Size(84, 23);
            this.btnCancelarAgendamento.TabIndex = 21;
            this.btnCancelarAgendamento.Text = "&Cancelar";
            this.btnCancelarAgendamento.Click += new System.EventHandler(this.btnCancelarAgendamento_Click);
            // 
            // pnlNaoValidar
            // 
            this.pnlNaoValidar.Controls.Add(this.btnAvancar);
            this.pnlNaoValidar.Controls.Add(this.btnRetroceder);
            this.pnlNaoValidar.Controls.Add(this.btnAtualizar);
            this.pnlNaoValidar.Location = new System.Drawing.Point(6, 55);
            this.pnlNaoValidar.Name = "pnlNaoValidar";
            this.pnlNaoValidar.Size = new System.Drawing.Size(958, 27);
            this.pnlNaoValidar.TabIndex = 20;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(868, 2);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(84, 23);
            this.btnAvancar.TabIndex = 19;
            this.btnAvancar.Text = ">>";
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(778, 2);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(84, 23);
            this.btnRetroceder.TabIndex = 18;
            this.btnRetroceder.Text = "<<";
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(52, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(84, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Listagem:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbTipoListagem
            // 
            this.cbTipoListagem.EditValue = "Semanal";
            this.cbTipoListagem.Location = new System.Drawing.Point(541, 29);
            this.cbTipoListagem.Name = "cbTipoListagem";
            this.cbTipoListagem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbTipoListagem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoListagem.Properties.Items.AddRange(new object[] {
            "1 dia",
            "3 dias",
            "Semanal"});
            this.cbTipoListagem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoListagem.Size = new System.Drawing.Size(74, 20);
            this.cbTipoListagem.TabIndex = 15;
            this.cbTipoListagem.EditValueChanged += new System.EventHandler(this.cbStatus_EditValueChanged);
            // 
            // gridAgendamentos
            // 
            this.gridAgendamentos.DataStorage = this.stoAgendamentos;
            this.gridAgendamentos.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.gridAgendamentos.Location = new System.Drawing.Point(6, 88);
            this.gridAgendamentos.Name = "gridAgendamentos";
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentMultiSelect = false;
            this.gridAgendamentos.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.gridAgendamentos.ResourceNavigator.Visibility = DevExpress.XtraScheduler.ResourceNavigatorVisibility.Always;
            this.gridAgendamentos.Size = new System.Drawing.Size(952, 396);
            this.gridAgendamentos.Start = new System.DateTime(2011, 6, 21, 0, 0, 0, 0);
            this.gridAgendamentos.TabIndex = 18;
            this.gridAgendamentos.Text = "schedulerControl1";
            this.gridAgendamentos.Views.DayView.DayCount = 7;
            timeRuler1.TimeZoneId = "Central Brazilian Standard Time";
            timeRuler1.UseClientTimeZone = false;
            this.gridAgendamentos.Views.DayView.TimeRulers.Add(timeRuler1);
            this.gridAgendamentos.Views.DayView.VisibleTime = new DevExpress.XtraScheduler.TimeOfDayInterval(System.TimeSpan.Parse("06:00:00"), System.TimeSpan.Parse("22:00:00"));
            this.gridAgendamentos.Views.DayView.WorkTime = new DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("18:00:00"));
            this.gridAgendamentos.Views.MonthView.Enabled = false;
            this.gridAgendamentos.Views.TimelineView.Enabled = false;
            this.gridAgendamentos.Views.WeekView.Enabled = false;
            this.gridAgendamentos.Views.WorkWeekView.Enabled = false;
            timeRuler2.TimeZoneId = "Central Brazilian Standard Time";
            timeRuler2.UseClientTimeZone = false;
            this.gridAgendamentos.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.gridAgendamentos.DoubleClick += new System.EventHandler(this.gridAgendamentos_DoubleClick);
            // 
            // stoAgendamentos
            // 
            this.stoAgendamentos.TimeZoneId = "Central Brazilian Standard Time";
            // 
            // btnAgendar
            // 
            this.btnAgendar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnAgendar.Location = new System.Drawing.Point(361, 29);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(84, 23);
            this.btnAgendar.TabIndex = 13;
            this.btnAgendar.Text = "&Agendar";
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fim:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFim
            // 
            this.txtFim.CwkFuncaoValidacao = null;
            this.txtFim.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtFim.CwkValidacao = null;
            this.txtFim.Location = new System.Drawing.Point(301, 30);
            this.txtFim.Name = "txtFim";
            this.txtFim.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFim.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFim.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFim.SelecionarTextoOnEnter = true;
            this.txtFim.Size = new System.Drawing.Size(54, 20);
            this.txtFim.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Início:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDt
            // 
            this.txtDt.EditValue = null;
            this.txtDt.Location = new System.Drawing.Point(58, 29);
            this.txtDt.Name = "txtDt";
            this.txtDt.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDt.Size = new System.Drawing.Size(84, 20);
            this.txtDt.TabIndex = 7;
            // 
            // lkbTecnico
            // 
            this.lkbTecnico.Location = new System.Drawing.Point(934, 3);
            this.lkbTecnico.Lookup = null;
            this.lkbTecnico.Name = "lkbTecnico";
            this.lkbTecnico.Size = new System.Drawing.Size(24, 20);
            this.lkbTecnico.SubForm = null;
            this.lkbTecnico.SubFormType = null;
            this.lkbTecnico.SubFormTypeParams = null;
            this.lkbTecnico.TabIndex = 5;
            this.lkbTecnico.TabStop = false;
            this.lkbTecnico.Text = "...";
            this.lkbTecnico.Click += new System.EventHandler(this.lkbTecnico_Click);
            // 
            // lkpTecnico
            // 
            this.lkpTecnico.ButtonLookup = this.lkbTecnico;
            this.lkpTecnico.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTecnico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTecnico.CamposRestricoesAND")));
            this.lkpTecnico.CamposRestricoesNOT = null;
            this.lkpTecnico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTecnico.CamposRestricoesOR")));
            this.lkpTecnico.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTecnico.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpTecnico.ContextoLinq = null;
            this.lkpTecnico.CwkFuncaoValidacao = null;
            this.lkpTecnico.CwkMascara = null;
            this.lkpTecnico.CwkValidacao = null;
            this.lkpTecnico.Exemplo = null;
            this.lkpTecnico.ID = 0;
            this.lkpTecnico.Join = null;
            this.lkpTecnico.Key = System.Windows.Forms.Keys.F5;
            this.lkpTecnico.Location = new System.Drawing.Point(541, 3);
            this.lkpTecnico.Name = "lkpTecnico";
            this.lkpTecnico.OnIDChanged = null;
            this.lkpTecnico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTecnico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTecnico.SelecionarTextoOnEnter = true;
            this.lkpTecnico.Size = new System.Drawing.Size(387, 20);
            this.lkpTecnico.Tabela = null;
            this.lkpTecnico.TabIndex = 4;
            this.lkpTecnico.TituloTelaPesquisa = null;
            this.lkpTecnico.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpTecnico.Where = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Técnico:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtInicio
            // 
            this.txtInicio.CwkFuncaoValidacao = null;
            this.txtInicio.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtInicio.CwkValidacao = null;
            this.txtInicio.Location = new System.Drawing.Point(208, 29);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtInicio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtInicio.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtInicio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtInicio.SelecionarTextoOnEnter = true;
            this.txtInicio.Size = new System.Drawing.Size(54, 20);
            this.txtInicio.TabIndex = 10;
            // 
            // lkbOS
            // 
            this.lkbOS.Location = new System.Drawing.Point(451, 3);
            this.lkbOS.Lookup = null;
            this.lkbOS.Name = "lkbOS";
            this.lkbOS.Size = new System.Drawing.Size(24, 20);
            this.lkbOS.SubForm = null;
            this.lkbOS.SubFormType = null;
            this.lkbOS.SubFormTypeParams = null;
            this.lkbOS.TabIndex = 2;
            this.lkbOS.TabStop = false;
            this.lkbOS.Text = "...";
            this.lkbOS.Click += new System.EventHandler(this.lkbOS_Click);
            // 
            // lkpOS
            // 
            this.lkpOS.ButtonLookup = this.lkbOS;
            this.lkpOS.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpOS.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOS.CamposRestricoesAND")));
            this.lkpOS.CamposRestricoesNOT = null;
            this.lkpOS.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOS.CamposRestricoesOR")));
            this.lkpOS.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpOS.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpOS.ContextoLinq = null;
            this.lkpOS.CwkFuncaoValidacao = null;
            this.lkpOS.CwkMascara = null;
            this.lkpOS.CwkValidacao = null;
            this.lkpOS.Exemplo = null;
            this.lkpOS.ID = 0;
            this.lkpOS.Join = null;
            this.lkpOS.Key = System.Windows.Forms.Keys.F5;
            this.lkpOS.Location = new System.Drawing.Point(58, 3);
            this.lkpOS.Name = "lkpOS";
            this.lkpOS.OnIDChanged = null;
            this.lkpOS.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpOS.Properties.Appearance.Options.UseBackColor = true;
            this.lkpOS.SelecionarTextoOnEnter = true;
            this.lkpOS.Size = new System.Drawing.Size(387, 20);
            this.lkpOS.Tabela = null;
            this.lkpOS.TabIndex = 1;
            this.lkpOS.TituloTelaPesquisa = null;
            this.lkpOS.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpOS.Where = null;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(27, 6);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(25, 13);
            this.lblBanco.TabIndex = 0;
            this.lblBanco.Text = "OS:";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlNaoValidar2
            // 
            this.pnlNaoValidar2.Controls.Add(this.btnAjuda);
            this.pnlNaoValidar2.Controls.Add(this.simpleButton1);
            this.pnlNaoValidar2.Location = new System.Drawing.Point(0, 536);
            this.pnlNaoValidar2.Name = "pnlNaoValidar2";
            this.pnlNaoValidar2.Size = new System.Drawing.Size(991, 26);
            this.pnlNaoValidar2.TabIndex = 21;
            // 
            // btnAjuda
            // 
            this.btnAjuda.ImageOptions.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.btnAjuda.Location = new System.Drawing.Point(12, 2);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(84, 23);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "A&juda";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.simpleButton1.Location = new System.Drawing.Point(893, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "&Fechar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            this.schedulerDataStorage1.TimeZoneId = "Central Brazilian Standard Time";
            // 
            // FormOSAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 566);
            this.Controls.Add(this.pnlNaoValidar2);
            this.Controls.Add(this.xtraTabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormOSAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos - Orçamento de Serviço";
            this.Shown += new System.EventHandler(this.FormOSAgendamento_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOSAgendamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.pnlNaoValidar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoListagem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTecnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOS.Properties)).EndInit();
            this.pnlNaoValidar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTecnico;
        private Cwork.Utilitarios.Componentes.Lookup lkpTecnico;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtInicio;
        private Cwork.Utilitarios.Componentes.LookupButton lkbOS;
        private Cwork.Utilitarios.Componentes.Lookup lkpOS;
        private System.Windows.Forms.Label lblBanco;
        private DevExpress.XtraEditors.SimpleButton btnAgendar;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDt;
        private DevExpress.XtraScheduler.SchedulerControl gridAgendamentos;
        private DevExpress.XtraScheduler.SchedulerStorage stoAgendamentos;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipoListagem;
        private System.Windows.Forms.Panel pnlNaoValidar;
        private DevExpress.XtraEditors.SimpleButton btnAvancar;
        private DevExpress.XtraEditors.SimpleButton btnRetroceder;
        private DevExpress.XtraEditors.SimpleButton btnAtualizar;
        private DevExpress.XtraEditors.SimpleButton btnCancelarAgendamento;
        private System.Windows.Forms.Panel pnlNaoValidar2;
        private DevExpress.XtraEditors.SimpleButton btnAjuda;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
    }
}