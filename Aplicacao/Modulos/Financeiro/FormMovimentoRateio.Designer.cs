namespace Aplicacao
{
    partial class FormMovimentoRateio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimentoRateio));
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gcRateio_Movs = new DevExpress.XtraGrid.GridControl();
            this.gvRateio_Movs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaSequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkpPlanoConta = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPlanoConta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.btIncluir = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterar = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluir = new Cwork.Utilitarios.Componentes.DevButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRateio_Movs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRateio_Movs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 375);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(487, 375);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(568, 375);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.btExcluir);
            this.tpPrincipal.Controls.Add(this.btAlterar);
            this.tpPrincipal.Controls.Add(this.btIncluir);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.lkbPlanoConta);
            this.tpPrincipal.Controls.Add(this.lkpPlanoConta);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.gcRateio_Movs);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Size = new System.Drawing.Size(625, 351);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(631, 357);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(10, 55);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(173, 18);
            this.labelControl11.TabIndex = 5;
            this.labelControl11.Text = "Rateio Centro de Custo";
            // 
            // gcRateio_Movs
            // 
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcRateio_Movs.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcRateio_Movs.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcRateio_Movs.Location = new System.Drawing.Point(10, 79);
            this.gcRateio_Movs.MainView = this.gvRateio_Movs;
            this.gcRateio_Movs.Name = "gcRateio_Movs";
            this.gcRateio_Movs.Size = new System.Drawing.Size(605, 233);
            this.gcRateio_Movs.TabIndex = 6;
            this.gcRateio_Movs.UseEmbeddedNavigator = true;
            this.gcRateio_Movs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRateio_Movs});
            // 
            // gvRateio_Movs
            // 
            this.gvRateio_Movs.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.Empty.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRateio_Movs.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRateio_Movs.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRateio_Movs.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRateio_Movs.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRateio_Movs.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRateio_Movs.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRateio_Movs.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRateio_Movs.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRateio_Movs.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRateio_Movs.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvRateio_Movs.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.Preview.Options.UseFont = true;
            this.gvRateio_Movs.Appearance.Preview.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRateio_Movs.Appearance.Row.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvRateio_Movs.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRateio_Movs.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRateio_Movs.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRateio_Movs.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvRateio_Movs.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRateio_Movs.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvRateio_Movs.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvRateio_Movs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ColunaSequencia,
            this.ColunaProjeto,
            this.ColunaValor});
            this.gvRateio_Movs.GridControl = this.gcRateio_Movs;
            this.gvRateio_Movs.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvRateio_Movs.Name = "gvRateio_Movs";
            this.gvRateio_Movs.OptionsBehavior.Editable = false;
            this.gvRateio_Movs.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvRateio_Movs.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRateio_Movs.OptionsView.EnableAppearanceOddRow = true;
            this.gvRateio_Movs.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvRateio_Movs_CustomDrawGroupPanel);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // ColunaSequencia
            // 
            this.ColunaSequencia.Caption = "Seq.";
            this.ColunaSequencia.FieldName = "Sequencia";
            this.ColunaSequencia.Name = "ColunaSequencia";
            this.ColunaSequencia.Visible = true;
            this.ColunaSequencia.VisibleIndex = 0;
            // 
            // ColunaProjeto
            // 
            this.ColunaProjeto.Caption = "Projeto";
            this.ColunaProjeto.FieldName = "Projeto";
            this.ColunaProjeto.Name = "ColunaProjeto";
            this.ColunaProjeto.Visible = true;
            this.ColunaProjeto.VisibleIndex = 1;
            // 
            // ColunaValor
            // 
            this.ColunaValor.Caption = "Valor";
            this.ColunaValor.FieldName = "Valor";
            this.ColunaValor.Name = "ColunaValor";
            this.ColunaValor.Visible = true;
            this.ColunaValor.VisibleIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Plano Conta:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Valor:";
            // 
            // lkpPlanoConta
            // 
            this.lkpPlanoConta.ButtonLookup = this.lkbPlanoConta;
            this.lkpPlanoConta.CamposPesquisa = new string[] {
        "Classificacao",
        "Nome",
        "Codigo"};
            this.lkpPlanoConta.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoConta.CamposRestricoesAND")));
            this.lkpPlanoConta.CamposRestricoesNOT = null;
            this.lkpPlanoConta.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoConta.CamposRestricoesOR")));
            this.lkpPlanoConta.ColunaDescricao = new string[] {
        "Classificação",
        "Nome",
        "Codigo"};
            this.lkpPlanoConta.ColunaTamanho = new string[] {
        "100",
        "120",
        "90"};
            this.lkpPlanoConta.ContextoLinq = null;
            this.lkpPlanoConta.CwkFuncaoValidacao = null;
            this.lkpPlanoConta.CwkMascara = null;
            this.lkpPlanoConta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPlanoConta.Exemplo = null;
            this.lkpPlanoConta.ID = 0;
            this.lkpPlanoConta.Join = null;
            this.lkpPlanoConta.Key = System.Windows.Forms.Keys.F5;
            this.lkpPlanoConta.Location = new System.Drawing.Point(78, 3);
            this.lkpPlanoConta.Name = "lkpPlanoConta";
            this.lkpPlanoConta.OnIDChanged = null;
            this.lkpPlanoConta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPlanoConta.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPlanoConta.SelecionarTextoOnEnter = false;
            this.lkpPlanoConta.Size = new System.Drawing.Size(507, 20);
            this.lkpPlanoConta.Tabela = null;
            this.lkpPlanoConta.TabIndex = 1;
            this.lkpPlanoConta.TituloTelaPesquisa = null;
            this.lkpPlanoConta.ToolTip = "Campos pesquisados: Classificacao, Nome, Codigo.";
            this.lkpPlanoConta.Where = null;
            // 
            // lkbPlanoConta
            // 
            this.lkbPlanoConta.Location = new System.Drawing.Point(591, 3);
            this.lkbPlanoConta.Lookup = null;
            this.lkbPlanoConta.Name = "lkbPlanoConta";
            this.lkbPlanoConta.Size = new System.Drawing.Size(24, 20);
            this.lkbPlanoConta.SubForm = null;
            this.lkbPlanoConta.SubFormType = null;
            this.lkbPlanoConta.SubFormTypeParams = null;
            this.lkbPlanoConta.TabIndex = 2;
            this.lkbPlanoConta.TabStop = false;
            this.lkbPlanoConta.Text = "...";
            this.lkbPlanoConta.Click += new System.EventHandler(this.lkbPlanoConta_Click);
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtValor.Location = new System.Drawing.Point(78, 29);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            // 
            // btIncluir
            // 
            this.btIncluir.GridControl = null;
            this.btIncluir.GridControlType = null;
            this.btIncluir.GridControlTypeParams = null;
            this.btIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluir.Location = new System.Drawing.Point(10, 318);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.SubForm = null;
            this.btIncluir.SubFormType = null;
            this.btIncluir.SubFormTypeParams = null;
            this.btIncluir.TabIndex = 7;
            this.btIncluir.TabStop = false;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.GridControl = null;
            this.btAlterar.GridControlType = null;
            this.btAlterar.GridControlTypeParams = null;
            this.btAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterar.Location = new System.Drawing.Point(91, 318);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.SubForm = null;
            this.btAlterar.SubFormType = null;
            this.btAlterar.SubFormTypeParams = null;
            this.btAlterar.TabIndex = 8;
            this.btAlterar.TabStop = false;
            this.btAlterar.Text = "Alterar";
            // 
            // btExcluir
            // 
            this.btExcluir.GridControl = null;
            this.btExcluir.GridControlType = null;
            this.btExcluir.GridControlTypeParams = null;
            this.btExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluir.Location = new System.Drawing.Point(172, 318);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.SubForm = null;
            this.btExcluir.SubFormType = null;
            this.btExcluir.SubFormTypeParams = null;
            this.btExcluir.TabIndex = 9;
            this.btExcluir.TabStop = false;
            this.btExcluir.Text = "Excluir";
            // 
            // FormMovimentoRateio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(655, 410);
            this.Name = "FormMovimentoRateio";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRateio_Movs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRateio_Movs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraGrid.GridControl gcRateio_Movs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRateio_Movs;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaSequencia;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaProjeto;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaValor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.Lookup lkpPlanoConta;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPlanoConta;
        private Cwork.Utilitarios.Componentes.DevButton btExcluir;
        private Cwork.Utilitarios.Componentes.DevButton btAlterar;
        private Cwork.Utilitarios.Componentes.DevButton btIncluir;
    }
}
