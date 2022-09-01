namespace Aplicacao
{
    partial class FormAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtendimento));
            this.gcAtendimentos = new DevExpress.XtraGrid.GridControl();
            this.gvAtendimentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gclDtAtendimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deDtAtendimento = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gclEnt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teEntrada_1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gclSai1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teSaida_1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gclEnt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teEntrada_2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gclSai2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teSaida_2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gclDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meDescricao = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gclAnalista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTotalHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclTotalHorasFat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teHorasFaturar = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gclCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpCliente = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gclDtConferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deDtConferencia = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gclFaturar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chbFaturar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gclObservacoes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meObservacoes = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gclStatusAtendimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gclNumeroNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chbConsiderarFaturado = new DevExpress.XtraEditors.CheckEdit();
            this.deDataFinal = new DevExpress.XtraEditors.DateEdit();
            this.lbDataInicial = new DevExpress.XtraEditors.LabelControl();
            this.lbDataFinal = new DevExpress.XtraEditors.LabelControl();
            this.sbFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.deDataInicial = new DevExpress.XtraEditors.DateEdit();
            this.lkbAnalista = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpAnalista = new Cwork.Utilitarios.Componentes.Lookup();
            this.sbImprimirOS = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimirFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.sbConferirAtendimentos = new DevExpress.XtraEditors.SimpleButton();
            this.sbLiberarFaturamento = new DevExpress.XtraEditors.SimpleButton();
            this.sbFaturar = new DevExpress.XtraEditors.SimpleButton();
            this.sbIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcDocumentosENotas = new DevExpress.XtraGrid.GridControl();
            this.gvDocumentosENotas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.dataDeVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.razaoSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numDocFinanceiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emailExibicao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataEmailEnviado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemResourcesComboBox1 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.sbCarregarDocumentos = new DevExpress.XtraEditors.SimpleButton();
            this.txtDataInicio = new DevExpress.XtraEditors.DateEdit();
            this.txtDataFim = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookup1 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lookupButton1 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemResourcesComboBox2 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRichTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.sbSelecionarFaturamento = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAtendimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtendimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtAtendimento.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEntrada_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSaida_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEntrada_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSaida_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHorasFaturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtConferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtConferencia.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFaturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meObservacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbConsiderarFaturado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpAnalista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentosENotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentosENotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 473);
            this.sbAjuda.Visible = false;
            // 
            // sbGravar
            // 
            this.sbGravar.Enabled = false;
            this.sbGravar.Location = new System.Drawing.Point(908, 473);
            this.sbGravar.Visible = false;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(989, 473);
            this.sbCancelar.Text = "&Fechar";
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
            this.tpPrincipal.Controls.Add(this.panelControl1);
            this.tpPrincipal.Controls.Add(this.panelControl2);
            this.tpPrincipal.Size = new System.Drawing.Size(1050, 449);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(1056, 455);
            // 
            // gcAtendimentos
            // 
            this.gcAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAtendimentos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcAtendimentos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcAtendimentos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcAtendimentos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcAtendimentos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcAtendimentos.Location = new System.Drawing.Point(2, 2);
            this.gcAtendimentos.MainView = this.gvAtendimentos;
            this.gcAtendimentos.Name = "gcAtendimentos";
            this.gcAtendimentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deDtAtendimento,
            this.teEntrada_1,
            this.teEntrada_2,
            this.teSaida_1,
            this.teSaida_2,
            this.deDtConferencia,
            this.chbFaturar,
            this.lkpStatus,
            this.meDescricao,
            this.meObservacoes,
            this.lkpCliente,
            this.teHorasFaturar});
            this.gcAtendimentos.Size = new System.Drawing.Size(1046, 388);
            this.gcAtendimentos.TabIndex = 28;
            this.gcAtendimentos.UseEmbeddedNavigator = true;
            this.gcAtendimentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAtendimentos});
            this.gcAtendimentos.Leave += new System.EventHandler(this.gcAtendimentos_Leave);
            // 
            // gvAtendimentos
            // 
            this.gvAtendimentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAtendimentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAtendimentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAtendimentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.RoyalBlue;
            this.gvAtendimentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAtendimentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAtendimentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAtendimentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAtendimentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAtendimentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvAtendimentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvAtendimentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.Preview.Options.UseFont = true;
            this.gvAtendimentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAtendimentos.Appearance.Row.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.Row.Options.UseTextOptions = true;
            this.gvAtendimentos.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvAtendimentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvAtendimentos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAtendimentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAtendimentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvAtendimentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvAtendimentos.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gvAtendimentos.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvAtendimentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gclDtAtendimento,
            this.gclEnt1,
            this.gclSai1,
            this.gclEnt2,
            this.gclSai2,
            this.gclDescricao,
            this.gclAnalista,
            this.gclTotalHoras,
            this.gclTotalHorasFat,
            this.gclCliente,
            this.gclDtConferencia,
            this.gclFaturar,
            this.gclObservacoes,
            this.gclStatusAtendimento,
            this.gclNumeroNota});
            this.gvAtendimentos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvAtendimentos.GridControl = this.gcAtendimentos;
            this.gvAtendimentos.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvAtendimentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvAtendimentos.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvAtendimentos.Name = "gvAtendimentos";
            this.gvAtendimentos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvAtendimentos.OptionsCustomization.AllowGroup = false;
            this.gvAtendimentos.OptionsDetail.EnableMasterViewMode = false;
            this.gvAtendimentos.OptionsSelection.MultiSelect = true;
            this.gvAtendimentos.OptionsView.ColumnAutoWidth = false;
            this.gvAtendimentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAtendimentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvAtendimentos.OptionsView.RowAutoHeight = true;
            this.gvAtendimentos.OptionsView.ShowAutoFilterRow = true;
            this.gvAtendimentos.OptionsView.ShowFooter = true;
            this.gvAtendimentos.OptionsView.ShowGroupPanel = false;
            this.gvAtendimentos.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvAtendimentos_SelectionChanged);
            this.gvAtendimentos.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvAtendimentos_ShowingEditor);
            this.gvAtendimentos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvAtendimentos_CellValueChanged);
            this.gvAtendimentos.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvAtendimentos_InvalidRowException);
            this.gvAtendimentos.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvAtendimentos_ValidateRow);
            // 
            // gclDtAtendimento
            // 
            this.gclDtAtendimento.AppearanceCell.Options.UseTextOptions = true;
            this.gclDtAtendimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclDtAtendimento.AppearanceHeader.Options.UseTextOptions = true;
            this.gclDtAtendimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclDtAtendimento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclDtAtendimento.Caption = "Data de Atendimento";
            this.gclDtAtendimento.ColumnEdit = this.deDtAtendimento;
            this.gclDtAtendimento.DisplayFormat.FormatString = "dd/MM/yyyy - dddd";
            this.gclDtAtendimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gclDtAtendimento.FieldName = "DtAtendimento";
            this.gclDtAtendimento.Name = "gclDtAtendimento";
            this.gclDtAtendimento.Visible = true;
            this.gclDtAtendimento.VisibleIndex = 0;
            this.gclDtAtendimento.Width = 196;
            // 
            // deDtAtendimento
            // 
            this.deDtAtendimento.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDtAtendimento.AutoHeight = false;
            this.deDtAtendimento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDtAtendimento.Name = "deDtAtendimento";
            this.deDtAtendimento.NullText = "Data (Obrigatório)";
            this.deDtAtendimento.NullValuePrompt = "Data (Obrigatório)";
            this.deDtAtendimento.NullValuePromptShowForEmptyValue = true;
            this.deDtAtendimento.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gclEnt1
            // 
            this.gclEnt1.AppearanceCell.Options.UseTextOptions = true;
            this.gclEnt1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclEnt1.AppearanceHeader.Options.UseTextOptions = true;
            this.gclEnt1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclEnt1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclEnt1.Caption = "Entrada 01";
            this.gclEnt1.ColumnEdit = this.teEntrada_1;
            this.gclEnt1.DisplayFormat.FormatString = "t";
            this.gclEnt1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gclEnt1.FieldName = "Ent1";
            this.gclEnt1.Name = "gclEnt1";
            this.gclEnt1.Visible = true;
            this.gclEnt1.VisibleIndex = 1;
            // 
            // teEntrada_1
            // 
            this.teEntrada_1.AutoHeight = false;
            this.teEntrada_1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teEntrada_1.Mask.EditMask = "t";
            this.teEntrada_1.Name = "teEntrada_1";
            // 
            // gclSai1
            // 
            this.gclSai1.AppearanceCell.Options.UseTextOptions = true;
            this.gclSai1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSai1.AppearanceHeader.Options.UseTextOptions = true;
            this.gclSai1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSai1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclSai1.Caption = "Saída 01";
            this.gclSai1.ColumnEdit = this.teSaida_1;
            this.gclSai1.FieldName = "Sai1";
            this.gclSai1.Name = "gclSai1";
            this.gclSai1.Visible = true;
            this.gclSai1.VisibleIndex = 2;
            // 
            // teSaida_1
            // 
            this.teSaida_1.AutoHeight = false;
            this.teSaida_1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teSaida_1.Mask.EditMask = "t";
            this.teSaida_1.Name = "teSaida_1";
            // 
            // gclEnt2
            // 
            this.gclEnt2.AppearanceCell.Options.UseTextOptions = true;
            this.gclEnt2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclEnt2.AppearanceHeader.Options.UseTextOptions = true;
            this.gclEnt2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclEnt2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclEnt2.Caption = "Entrada 02";
            this.gclEnt2.ColumnEdit = this.teEntrada_2;
            this.gclEnt2.FieldName = "Ent2";
            this.gclEnt2.Name = "gclEnt2";
            this.gclEnt2.Visible = true;
            this.gclEnt2.VisibleIndex = 3;
            // 
            // teEntrada_2
            // 
            this.teEntrada_2.AutoHeight = false;
            this.teEntrada_2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teEntrada_2.Mask.EditMask = "t";
            this.teEntrada_2.Name = "teEntrada_2";
            // 
            // gclSai2
            // 
            this.gclSai2.AppearanceCell.Options.UseTextOptions = true;
            this.gclSai2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSai2.AppearanceHeader.Options.UseTextOptions = true;
            this.gclSai2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclSai2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclSai2.Caption = "Saída 02";
            this.gclSai2.ColumnEdit = this.teSaida_2;
            this.gclSai2.FieldName = "Sai2";
            this.gclSai2.Name = "gclSai2";
            this.gclSai2.Visible = true;
            this.gclSai2.VisibleIndex = 4;
            // 
            // teSaida_2
            // 
            this.teSaida_2.AutoHeight = false;
            this.teSaida_2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teSaida_2.Mask.EditMask = "t";
            this.teSaida_2.Name = "teSaida_2";
            // 
            // gclDescricao
            // 
            this.gclDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.gclDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclDescricao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclDescricao.Caption = "Descrição";
            this.gclDescricao.ColumnEdit = this.meDescricao;
            this.gclDescricao.FieldName = "Descricao";
            this.gclDescricao.Name = "gclDescricao";
            this.gclDescricao.Visible = true;
            this.gclDescricao.VisibleIndex = 5;
            this.gclDescricao.Width = 286;
            // 
            // meDescricao
            // 
            this.meDescricao.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.meDescricao.MaxLength = 1000;
            this.meDescricao.Name = "meDescricao";
            this.meDescricao.NullText = "Descrição (Obrigatório)";
            this.meDescricao.NullValuePrompt = "Descrição (Obrigatório)";
            this.meDescricao.NullValuePromptShowForEmptyValue = true;
            // 
            // gclAnalista
            // 
            this.gclAnalista.AppearanceCell.Options.UseTextOptions = true;
            this.gclAnalista.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclAnalista.AppearanceHeader.Options.UseTextOptions = true;
            this.gclAnalista.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclAnalista.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclAnalista.Caption = "Analista";
            this.gclAnalista.FieldName = "Analista";
            this.gclAnalista.Name = "gclAnalista";
            this.gclAnalista.OptionsColumn.AllowEdit = false;
            this.gclAnalista.OptionsColumn.AllowFocus = false;
            this.gclAnalista.OptionsColumn.ReadOnly = true;
            this.gclAnalista.Visible = true;
            this.gclAnalista.VisibleIndex = 6;
            this.gclAnalista.Width = 100;
            // 
            // gclTotalHoras
            // 
            this.gclTotalHoras.AppearanceCell.Options.UseTextOptions = true;
            this.gclTotalHoras.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTotalHoras.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTotalHoras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTotalHoras.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclTotalHoras.Caption = "Total de Horas";
            this.gclTotalHoras.FieldName = "TotHoras";
            this.gclTotalHoras.Name = "gclTotalHoras";
            this.gclTotalHoras.OptionsColumn.AllowEdit = false;
            this.gclTotalHoras.OptionsColumn.AllowFocus = false;
            this.gclTotalHoras.OptionsColumn.ReadOnly = true;
            this.gclTotalHoras.Visible = true;
            this.gclTotalHoras.VisibleIndex = 7;
            this.gclTotalHoras.Width = 100;
            // 
            // gclTotalHorasFat
            // 
            this.gclTotalHorasFat.AppearanceCell.Options.UseTextOptions = true;
            this.gclTotalHorasFat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTotalHorasFat.AppearanceHeader.Options.UseTextOptions = true;
            this.gclTotalHorasFat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclTotalHorasFat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclTotalHorasFat.Caption = "Total de Horas Fat";
            this.gclTotalHorasFat.ColumnEdit = this.teHorasFaturar;
            this.gclTotalHorasFat.DisplayFormat.FormatString = "HH:mm";
            this.gclTotalHorasFat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gclTotalHorasFat.FieldName = "TotHorasFat";
            this.gclTotalHorasFat.Name = "gclTotalHorasFat";
            this.gclTotalHorasFat.OptionsColumn.AllowEdit = false;
            this.gclTotalHorasFat.OptionsColumn.AllowFocus = false;
            this.gclTotalHorasFat.OptionsColumn.ReadOnly = true;
            this.gclTotalHorasFat.Visible = true;
            this.gclTotalHorasFat.VisibleIndex = 8;
            this.gclTotalHorasFat.Width = 100;
            // 
            // teHorasFaturar
            // 
            this.teHorasFaturar.AutoHeight = false;
            this.teHorasFaturar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teHorasFaturar.Mask.EditMask = "t";
            this.teHorasFaturar.Name = "teHorasFaturar";
            // 
            // gclCliente
            // 
            this.gclCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.gclCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclCliente.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclCliente.Caption = "Cliente";
            this.gclCliente.ColumnEdit = this.lkpCliente;
            this.gclCliente.FieldName = "Cliente";
            this.gclCliente.Name = "gclCliente";
            this.gclCliente.Visible = true;
            this.gclCliente.VisibleIndex = 9;
            this.gclCliente.Width = 250;
            // 
            // lkpCliente
            // 
            this.lkpCliente.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lkpCliente.AutoHeight = false;
            this.lkpCliente.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkpCliente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpCliente.ImmediatePopup = true;
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.NullText = "Cliente";
            this.lkpCliente.NullValuePrompt = "Cliente";
            this.lkpCliente.NullValuePromptShowForEmptyValue = true;
            this.lkpCliente.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lkpCliente.PopupFormMinSize = new System.Drawing.Size(620, 200);
            this.lkpCliente.View = this.gridView1;
            this.lkpCliente.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome/Razão Social";
            this.gridColumn2.FieldName = "Nome";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 250;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fantasia";
            this.gridColumn3.FieldName = "Fantasia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 250;
            // 
            // gclDtConferencia
            // 
            this.gclDtConferencia.AppearanceCell.Options.UseTextOptions = true;
            this.gclDtConferencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclDtConferencia.AppearanceHeader.Options.UseTextOptions = true;
            this.gclDtConferencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclDtConferencia.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclDtConferencia.Caption = "Data de Conferência";
            this.gclDtConferencia.ColumnEdit = this.deDtConferencia;
            this.gclDtConferencia.FieldName = "DtConferencia";
            this.gclDtConferencia.Name = "gclDtConferencia";
            this.gclDtConferencia.OptionsColumn.AllowEdit = false;
            this.gclDtConferencia.OptionsColumn.AllowFocus = false;
            this.gclDtConferencia.Visible = true;
            this.gclDtConferencia.VisibleIndex = 10;
            this.gclDtConferencia.Width = 125;
            // 
            // deDtConferencia
            // 
            this.deDtConferencia.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.deDtConferencia.AutoHeight = false;
            this.deDtConferencia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDtConferencia.Name = "deDtConferencia";
            this.deDtConferencia.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gclFaturar
            // 
            this.gclFaturar.AppearanceCell.Options.UseTextOptions = true;
            this.gclFaturar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclFaturar.AppearanceHeader.Options.UseTextOptions = true;
            this.gclFaturar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclFaturar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclFaturar.Caption = "Faturar?";
            this.gclFaturar.ColumnEdit = this.chbFaturar;
            this.gclFaturar.FieldName = "Faturar";
            this.gclFaturar.Name = "gclFaturar";
            this.gclFaturar.OptionsColumn.AllowEdit = false;
            this.gclFaturar.OptionsColumn.AllowFocus = false;
            this.gclFaturar.Visible = true;
            this.gclFaturar.VisibleIndex = 11;
            // 
            // chbFaturar
            // 
            this.chbFaturar.AutoHeight = false;
            this.chbFaturar.Name = "chbFaturar";
            // 
            // gclObservacoes
            // 
            this.gclObservacoes.AppearanceHeader.Options.UseTextOptions = true;
            this.gclObservacoes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclObservacoes.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclObservacoes.Caption = "Observações";
            this.gclObservacoes.ColumnEdit = this.meObservacoes;
            this.gclObservacoes.FieldName = "Observacoes";
            this.gclObservacoes.Name = "gclObservacoes";
            this.gclObservacoes.Visible = true;
            this.gclObservacoes.VisibleIndex = 12;
            this.gclObservacoes.Width = 250;
            // 
            // meObservacoes
            // 
            this.meObservacoes.MaxLength = 1000;
            this.meObservacoes.Name = "meObservacoes";
            this.meObservacoes.NullText = "Observação (Opcional)";
            this.meObservacoes.NullValuePrompt = "Observação (Opcional)";
            // 
            // gclStatusAtendimento
            // 
            this.gclStatusAtendimento.AppearanceCell.Options.UseTextOptions = true;
            this.gclStatusAtendimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclStatusAtendimento.AppearanceHeader.Options.UseTextOptions = true;
            this.gclStatusAtendimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclStatusAtendimento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclStatusAtendimento.Caption = "Status";
            this.gclStatusAtendimento.ColumnEdit = this.lkpStatus;
            this.gclStatusAtendimento.FieldName = "Status";
            this.gclStatusAtendimento.Name = "gclStatusAtendimento";
            this.gclStatusAtendimento.Visible = true;
            this.gclStatusAtendimento.VisibleIndex = 13;
            // 
            // lkpStatus
            // 
            this.lkpStatus.AutoHeight = false;
            this.lkpStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", 100, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", 150, "Descrição")});
            this.lkpStatus.Name = "lkpStatus";
            this.lkpStatus.NullText = "Status";
            this.lkpStatus.NullValuePrompt = "Status";
            this.lkpStatus.NullValuePromptShowForEmptyValue = true;
            // 
            // gclNumeroNota
            // 
            this.gclNumeroNota.AppearanceCell.Options.UseTextOptions = true;
            this.gclNumeroNota.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gclNumeroNota.AppearanceHeader.Options.UseTextOptions = true;
            this.gclNumeroNota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclNumeroNota.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gclNumeroNota.Caption = "Numero Nota";
            this.gclNumeroNota.FieldName = "NumeroNota";
            this.gclNumeroNota.Name = "gclNumeroNota";
            this.gclNumeroNota.OptionsColumn.AllowEdit = false;
            this.gclNumeroNota.OptionsColumn.AllowFocus = false;
            this.gclNumeroNota.OptionsColumn.ReadOnly = true;
            this.gclNumeroNota.Visible = true;
            this.gclNumeroNota.VisibleIndex = 14;
            this.gclNumeroNota.Width = 100;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcAtendimentos);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1050, 392);
            this.panelControl1.TabIndex = 29;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.chbConsiderarFaturado);
            this.panelControl2.Controls.Add(this.deDataFinal);
            this.panelControl2.Controls.Add(this.lbDataInicial);
            this.panelControl2.Controls.Add(this.lbDataFinal);
            this.panelControl2.Controls.Add(this.sbFiltrar);
            this.panelControl2.Controls.Add(this.deDataInicial);
            this.panelControl2.Controls.Add(this.lkbAnalista);
            this.panelControl2.Controls.Add(this.lkpAnalista);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1050, 57);
            this.panelControl2.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Analista:";
            // 
            // chbConsiderarFaturado
            // 
            this.chbConsiderarFaturado.Location = new System.Drawing.Point(429, 5);
            this.chbConsiderarFaturado.Name = "chbConsiderarFaturado";
            this.chbConsiderarFaturado.Properties.Caption = "Considerar Faturados";
            this.chbConsiderarFaturado.Size = new System.Drawing.Size(129, 19);
            this.chbConsiderarFaturado.TabIndex = 4;
            // 
            // deDataFinal
            // 
            this.deDataFinal.EditValue = null;
            this.deDataFinal.Location = new System.Drawing.Point(193, 31);
            this.deDataFinal.Name = "deDataFinal";
            this.deDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDataFinal.Size = new System.Drawing.Size(119, 20);
            this.deDataFinal.TabIndex = 12;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.Location = new System.Drawing.Point(10, 34);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(40, 13);
            this.lbDataInicial.TabIndex = 15;
            this.lbDataInicial.Text = "Período:";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.Location = new System.Drawing.Point(181, 34);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(6, 13);
            this.lbDataFinal.TabIndex = 14;
            this.lbDataFinal.Text = "à";
            // 
            // sbFiltrar
            // 
            this.sbFiltrar.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbFiltrar.Location = new System.Drawing.Point(318, 30);
            this.sbFiltrar.Name = "sbFiltrar";
            this.sbFiltrar.Size = new System.Drawing.Size(75, 21);
            this.sbFiltrar.TabIndex = 13;
            this.sbFiltrar.Text = "Filtrar";
            this.sbFiltrar.Click += new System.EventHandler(this.sbFiltrar_Click);
            // 
            // deDataInicial
            // 
            this.deDataInicial.EditValue = null;
            this.deDataInicial.Location = new System.Drawing.Point(56, 31);
            this.deDataInicial.Name = "deDataInicial";
            this.deDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDataInicial.Size = new System.Drawing.Size(119, 20);
            this.deDataInicial.TabIndex = 11;
            // 
            // lkbAnalista
            // 
            this.lkbAnalista.Location = new System.Drawing.Point(399, 5);
            this.lkbAnalista.Lookup = this.lkpAnalista;
            this.lkbAnalista.Name = "lkbAnalista";
            this.lkbAnalista.Size = new System.Drawing.Size(24, 20);
            this.lkbAnalista.SubForm = null;
            this.lkbAnalista.SubFormType = null;
            this.lkbAnalista.SubFormTypeParams = null;
            this.lkbAnalista.TabIndex = 3;
            this.lkbAnalista.TabStop = false;
            this.lkbAnalista.Text = "...";
            this.lkbAnalista.Click += new System.EventHandler(this.lkbAnalista_Click);
            // 
            // lkpAnalista
            // 
            this.lkpAnalista.ButtonLookup = this.lkbAnalista;
            this.lkpAnalista.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpAnalista.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpAnalista.CamposRestricoesAND")));
            this.lkpAnalista.CamposRestricoesNOT = null;
            this.lkpAnalista.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpAnalista.CamposRestricoesOR")));
            this.lkpAnalista.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpAnalista.ColunaTamanho = new string[] {
        "100",
        "250"};
            this.lkpAnalista.ContextoLinq = null;
            this.lkpAnalista.CwkFuncaoValidacao = null;
            this.lkpAnalista.CwkMascara = null;
            this.lkpAnalista.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpAnalista.Exemplo = null;
            this.lkpAnalista.ID = 0;
            this.lkpAnalista.Join = null;
            this.lkpAnalista.Key = System.Windows.Forms.Keys.F5;
            this.lkpAnalista.Location = new System.Drawing.Point(56, 5);
            this.lkpAnalista.Name = "lkpAnalista";
            this.lkpAnalista.OnIDChanged = null;
            this.lkpAnalista.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpAnalista.Properties.Appearance.Options.UseBackColor = true;
            this.lkpAnalista.SelecionarTextoOnEnter = true;
            this.lkpAnalista.Size = new System.Drawing.Size(337, 20);
            this.lkpAnalista.Tabela = "Ofd_Ocorrencias";
            this.lkpAnalista.TabIndex = 2;
            this.lkpAnalista.TituloTelaPesquisa = null;
            this.lkpAnalista.ToolTip = "Campos pesquisados: Código, Descrição";
            this.lkpAnalista.Where = null;
            this.lkpAnalista.Leave += new System.EventHandler(this.lkpAnalista_Leave);
            // 
            // sbImprimirOS
            // 
            this.sbImprimirOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbImprimirOS.Image = global::Aplicacao.Properties.Resources.Importação_de_Bilhetes_copy;
            this.sbImprimirOS.Location = new System.Drawing.Point(12, 473);
            this.sbImprimirOS.Name = "sbImprimirOS";
            this.sbImprimirOS.Size = new System.Drawing.Size(95, 23);
            this.sbImprimirOS.TabIndex = 4;
            this.sbImprimirOS.Text = "Imprimir OS";
            this.sbImprimirOS.Click += new System.EventHandler(this.sbImprimirOS_Click);
            // 
            // sbImprimirFiltro
            // 
            this.sbImprimirFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbImprimirFiltro.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimirFiltro.Location = new System.Drawing.Point(113, 473);
            this.sbImprimirFiltro.Name = "sbImprimirFiltro";
            this.sbImprimirFiltro.Size = new System.Drawing.Size(105, 23);
            this.sbImprimirFiltro.TabIndex = 5;
            this.sbImprimirFiltro.Text = "Imprimir Filtro";
            this.sbImprimirFiltro.Click += new System.EventHandler(this.sbImprimirFiltro_Click);
            // 
            // sbConferirAtendimentos
            // 
            this.sbConferirAtendimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbConferirAtendimentos.Image = global::Aplicacao.Properties.Resources.Modify;
            this.sbConferirAtendimentos.Location = new System.Drawing.Point(224, 473);
            this.sbConferirAtendimentos.Name = "sbConferirAtendimentos";
            this.sbConferirAtendimentos.Size = new System.Drawing.Size(145, 23);
            this.sbConferirAtendimentos.TabIndex = 6;
            this.sbConferirAtendimentos.Text = "Conferir Atendimentos";
            this.sbConferirAtendimentos.Click += new System.EventHandler(this.sbConferirAtendimentos_Click);
            // 
            // sbLiberarFaturamento
            // 
            this.sbLiberarFaturamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLiberarFaturamento.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbLiberarFaturamento.Location = new System.Drawing.Point(375, 473);
            this.sbLiberarFaturamento.Name = "sbLiberarFaturamento";
            this.sbLiberarFaturamento.Size = new System.Drawing.Size(127, 23);
            this.sbLiberarFaturamento.TabIndex = 7;
            this.sbLiberarFaturamento.Text = "Liberar Faturamento";
            this.sbLiberarFaturamento.Click += new System.EventHandler(this.sbLiberarFaturamento_Click);
            // 
            // sbFaturar
            // 
            this.sbFaturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFaturar.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbFaturar.Location = new System.Drawing.Point(635, 473);
            this.sbFaturar.Name = "sbFaturar";
            this.sbFaturar.Size = new System.Drawing.Size(85, 23);
            this.sbFaturar.TabIndex = 8;
            this.sbFaturar.Text = "Faturar";
            this.sbFaturar.Click += new System.EventHandler(this.sbFaturar_Click);
            // 
            // sbIncluir
            // 
            this.sbIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluir.Location = new System.Drawing.Point(726, 473);
            this.sbIncluir.Name = "sbIncluir";
            this.sbIncluir.Size = new System.Drawing.Size(85, 23);
            this.sbIncluir.TabIndex = 9;
            this.sbIncluir.Text = "Incluir";
            this.sbIncluir.Click += new System.EventHandler(this.sbIncluir_Click);
            // 
            // sbExcluir
            // 
            this.sbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluir.Location = new System.Drawing.Point(817, 473);
            this.sbExcluir.Name = "sbExcluir";
            this.sbExcluir.Size = new System.Drawing.Size(85, 23);
            this.sbExcluir.TabIndex = 10;
            this.sbExcluir.Text = "Excluir";
            this.sbExcluir.Click += new System.EventHandler(this.sbExcluir_Click);
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gcAtendimentos;
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(60, 60, 100, 60);
            this.printableComponentLink1.MinMargins = new System.Drawing.Printing.Margins(10, 10, 50, 10);
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "",
                "",
                "[Page # of Pages #]"}, new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near), null);
            this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            this.printableComponentLink1.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink1_CreateMarginalHeaderArea);
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpPessoa.CamposRestricoesAND = null;
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = null;
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(54, 12);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(742, 20);
            this.lkpPessoa.Tabela = "Pessoa";
            this.lkpPessoa.TabIndex = 6;
            this.lkpPessoa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpPessoa.Where = null;
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbPessoa.Location = new System.Drawing.Point(802, 12);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 20;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Cliente:";
            // 
            // gcDocumentosENotas
            // 
            this.gcDocumentosENotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDocumentosENotas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDocumentosENotas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDocumentosENotas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDocumentosENotas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDocumentosENotas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDocumentosENotas.Location = new System.Drawing.Point(4, 64);
            this.gcDocumentosENotas.MainView = this.gvDocumentosENotas;
            this.gcDocumentosENotas.Name = "gcDocumentosENotas";
            this.gcDocumentosENotas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemComboBox1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemResourcesComboBox1,
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemCheckEdit3});
            this.gcDocumentosENotas.Size = new System.Drawing.Size(822, 327);
            this.gcDocumentosENotas.TabIndex = 17;
            this.gcDocumentosENotas.UseEmbeddedNavigator = true;
            this.gcDocumentosENotas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocumentosENotas,
            this.cardView1});
            // 
            // gvDocumentosENotas
            // 
            this.gvDocumentosENotas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.Empty.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocumentosENotas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocumentosENotas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocumentosENotas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentosENotas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentosENotas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocumentosENotas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocumentosENotas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocumentosENotas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentosENotas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvDocumentosENotas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvDocumentosENotas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.Preview.Options.UseFont = true;
            this.gvDocumentosENotas.Appearance.Preview.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentosENotas.Appearance.Row.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvDocumentosENotas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvDocumentosENotas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvDocumentosENotas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvDocumentosENotas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvDocumentosENotas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.selecionado,
            this.dataDeVencimento,
            this.razaoSocial,
            this.fantasia,
            this.valor,
            this.numDocFinanceiro,
            this.emailExibicao,
            this.dataEmailEnviado,
            this.status});
            this.gvDocumentosENotas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvDocumentosENotas.GridControl = this.gcDocumentosENotas;
            this.gvDocumentosENotas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvDocumentosENotas.Name = "gvDocumentosENotas";
            this.gvDocumentosENotas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvDocumentosENotas.OptionsCustomization.AllowFilter = false;
            this.gvDocumentosENotas.OptionsCustomization.AllowSort = false;
            this.gvDocumentosENotas.OptionsDetail.EnableMasterViewMode = false;
            this.gvDocumentosENotas.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvDocumentosENotas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDocumentosENotas.OptionsView.EnableAppearanceOddRow = true;
            this.gvDocumentosENotas.OptionsView.ShowGroupPanel = false;
            // 
            // selecionado
            // 
            this.selecionado.Caption = "Selecionado";
            this.selecionado.ColumnEdit = this.repositoryItemCheckEdit3;
            this.selecionado.FieldName = "selecionado";
            this.selecionado.Name = "selecionado";
            this.selecionado.Visible = true;
            this.selecionado.VisibleIndex = 0;
            this.selecionado.Width = 70;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // dataDeVencimento
            // 
            this.dataDeVencimento.Caption = "Data de Vencimento";
            this.dataDeVencimento.FieldName = "dataDeVencimento";
            this.dataDeVencimento.Name = "dataDeVencimento";
            this.dataDeVencimento.OptionsColumn.ReadOnly = true;
            this.dataDeVencimento.Visible = true;
            this.dataDeVencimento.VisibleIndex = 1;
            this.dataDeVencimento.Width = 117;
            // 
            // razaoSocial
            // 
            this.razaoSocial.Caption = "Razão Social";
            this.razaoSocial.FieldName = "razaoSocial";
            this.razaoSocial.Name = "razaoSocial";
            this.razaoSocial.OptionsColumn.ReadOnly = true;
            this.razaoSocial.Visible = true;
            this.razaoSocial.VisibleIndex = 2;
            this.razaoSocial.Width = 100;
            // 
            // fantasia
            // 
            this.fantasia.Caption = "Fantasia";
            this.fantasia.FieldName = "fantasia";
            this.fantasia.Name = "fantasia";
            this.fantasia.OptionsColumn.ReadOnly = true;
            this.fantasia.Visible = true;
            this.fantasia.VisibleIndex = 3;
            // 
            // valor
            // 
            this.valor.Caption = "Valor";
            this.valor.DisplayFormat.FormatString = "c2";
            this.valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.valor.FieldName = "valor";
            this.valor.Name = "valor";
            this.valor.OptionsColumn.ReadOnly = true;
            this.valor.Visible = true;
            this.valor.VisibleIndex = 4;
            // 
            // numDocFinanceiro
            // 
            this.numDocFinanceiro.Caption = "Número do Documento";
            this.numDocFinanceiro.FieldName = "numDocFinanceiro";
            this.numDocFinanceiro.Name = "numDocFinanceiro";
            this.numDocFinanceiro.OptionsColumn.ReadOnly = true;
            this.numDocFinanceiro.Visible = true;
            this.numDocFinanceiro.VisibleIndex = 5;
            this.numDocFinanceiro.Width = 141;
            // 
            // emailExibicao
            // 
            this.emailExibicao.Caption = "Email";
            this.emailExibicao.FieldName = "emailExibicao";
            this.emailExibicao.Name = "emailExibicao";
            this.emailExibicao.OptionsColumn.ReadOnly = true;
            this.emailExibicao.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.emailExibicao.Visible = true;
            this.emailExibicao.VisibleIndex = 6;
            this.emailExibicao.Width = 82;
            // 
            // dataEmailEnviado
            // 
            this.dataEmailEnviado.Caption = "Data de envio do E-mail";
            this.dataEmailEnviado.DisplayFormat.FormatString = "g";
            this.dataEmailEnviado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dataEmailEnviado.FieldName = "dataEmailEnviado";
            this.dataEmailEnviado.Name = "dataEmailEnviado";
            this.dataEmailEnviado.OptionsColumn.ReadOnly = true;
            this.dataEmailEnviado.Visible = true;
            this.dataEmailEnviado.VisibleIndex = 7;
            this.dataEmailEnviado.Width = 208;
            // 
            // status
            // 
            this.status.Caption = "Status nota";
            this.status.FieldName = "status";
            this.status.Name = "status";
            this.status.OptionsColumn.ReadOnly = true;
            this.status.Visible = true;
            this.status.VisibleIndex = 8;
            this.status.Width = 119;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemResourcesComboBox1
            // 
            this.repositoryItemResourcesComboBox1.AutoHeight = false;
            this.repositoryItemResourcesComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemResourcesComboBox1.Name = "repositoryItemResourcesComboBox1";
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gcDocumentosENotas;
            this.cardView1.Name = "cardView1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Período:";
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(127, 397);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 17;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(4, 397);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 16;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            // 
            // sbCarregarDocumentos
            // 
            this.sbCarregarDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCarregarDocumentos.Location = new System.Drawing.Point(280, 38);
            this.sbCarregarDocumentos.Name = "sbCarregarDocumentos";
            this.sbCarregarDocumentos.Size = new System.Drawing.Size(121, 20);
            this.sbCarregarDocumentos.TabIndex = 15;
            this.sbCarregarDocumentos.Text = "Carregar Documentos";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.EditValue = null;
            this.txtDataInicio.Location = new System.Drawing.Point(54, 38);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicio.Size = new System.Drawing.Size(96, 20);
            this.txtDataInicio.TabIndex = 12;
            // 
            // txtDataFim
            // 
            this.txtDataFim.EditValue = null;
            this.txtDataFim.Location = new System.Drawing.Point(178, 38);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFim.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFim.Size = new System.Drawing.Size(96, 20);
            this.txtDataFim.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(156, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "até";
            // 
            // lookup1
            // 
            this.lookup1.ButtonLookup = this.lookupButton1;
            this.lookup1.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lookup1.CamposRestricoesAND = null;
            this.lookup1.CamposRestricoesNOT = null;
            this.lookup1.CamposRestricoesOR = null;
            this.lookup1.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lookup1.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lookup1.ContextoLinq = null;
            this.lookup1.CwkFuncaoValidacao = null;
            this.lookup1.CwkMascara = null;
            this.lookup1.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup1.Exemplo = null;
            this.lookup1.ID = 0;
            this.lookup1.Join = null;
            this.lookup1.Key = System.Windows.Forms.Keys.F5;
            this.lookup1.Location = new System.Drawing.Point(54, 12);
            this.lookup1.Name = "lookup1";
            this.lookup1.OnIDChanged = null;
            this.lookup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup1.Properties.Appearance.Options.UseBackColor = true;
            this.lookup1.SelecionarTextoOnEnter = true;
            this.lookup1.Size = new System.Drawing.Size(742, 20);
            this.lookup1.Tabela = "Pessoa";
            this.lookup1.TabIndex = 6;
            this.lookup1.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lookup1.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lookup1.Where = null;
            // 
            // lookupButton1
            // 
            this.lookupButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupButton1.Location = new System.Drawing.Point(802, 12);
            this.lookupButton1.Lookup = null;
            this.lookupButton1.Name = "lookupButton1";
            this.lookupButton1.Size = new System.Drawing.Size(24, 20);
            this.lookupButton1.SubForm = null;
            this.lookupButton1.SubFormType = null;
            this.lookupButton1.SubFormTypeParams = null;
            this.lookupButton1.TabIndex = 20;
            this.lookupButton1.TabStop = false;
            this.lookupButton1.Text = "...";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Cliente:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(4, 64);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit4,
            this.repositoryItemComboBox2,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemMemoEdit2,
            this.repositoryItemResourcesComboBox2,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemRichTextEdit2,
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(822, 327);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4,
            this.cardView2});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView4.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView4.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView4.Appearance.Empty.Options.UseBackColor = true;
            this.gridView4.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView4.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView4.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView4.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView4.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView4.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView4.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView4.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView4.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView4.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView4.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView4.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView4.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView4.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView4.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView4.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView4.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView4.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView4.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.Preview.Options.UseFont = true;
            this.gridView4.Appearance.Preview.Options.UseForeColor = true;
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView4.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView4.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView4.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView4.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView4.OptionsCustomization.AllowFilter = false;
            this.gridView4.OptionsCustomization.AllowSort = false;
            this.gridView4.OptionsDetail.EnableMasterViewMode = false;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView4.OptionsView.EnableAppearanceOddRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Selecionado";
            this.gridColumn4.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn4.FieldName = "selecionado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 70;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Data de Vencimento";
            this.gridColumn5.FieldName = "dataDeVencimento";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 117;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Razão Social";
            this.gridColumn6.FieldName = "razaoSocial";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Fantasia";
            this.gridColumn7.FieldName = "fantasia";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Valor";
            this.gridColumn8.DisplayFormat.FormatString = "c2";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "valor";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Número do Documento";
            this.gridColumn9.FieldName = "numDocFinanceiro";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 141;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Email";
            this.gridColumn10.FieldName = "emailExibicao";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 82;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Data de envio do E-mail";
            this.gridColumn11.DisplayFormat.FormatString = "g";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn11.FieldName = "dataEmailEnviado";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 208;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Status nota";
            this.gridColumn12.FieldName = "status";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 8;
            this.gridColumn12.Width = 119;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemResourcesComboBox2
            // 
            this.repositoryItemResourcesComboBox2.AutoHeight = false;
            this.repositoryItemResourcesComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemResourcesComboBox2.Name = "repositoryItemResourcesComboBox2";
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRichTextEdit2
            // 
            this.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2";
            this.repositoryItemRichTextEdit2.ShowCaretInReadOnly = false;
            // 
            // cardView2
            // 
            this.cardView2.FocusedCardTopFieldIndex = 0;
            this.cardView2.GridControl = this.gridControl1;
            this.cardView2.Name = "cardView2";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Período:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.simpleButton1.ImageIndex = 6;
            this.simpleButton1.Location = new System.Drawing.Point(127, 397);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 23);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "&Limpar Seleção";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.simpleButton2.ImageIndex = 6;
            this.simpleButton2.Location = new System.Drawing.Point(4, 397);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(120, 23);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "&Selecionar Todos";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Location = new System.Drawing.Point(280, 38);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(121, 20);
            this.simpleButton3.TabIndex = 15;
            this.simpleButton3.Text = "Carregar Documentos";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(54, 38);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(96, 20);
            this.dateEdit1.TabIndex = 12;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(178, 38);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(96, 20);
            this.dateEdit2.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(156, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(16, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "até";
            // 
            // sbSelecionarFaturamento
            // 
            this.sbSelecionarFaturamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarFaturamento.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarFaturamento.ImageIndex = 6;
            this.sbSelecionarFaturamento.Location = new System.Drawing.Point(508, 473);
            this.sbSelecionarFaturamento.Name = "sbSelecionarFaturamento";
            this.sbSelecionarFaturamento.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarFaturamento.TabIndex = 18;
            this.sbSelecionarFaturamento.Text = "&Selecionar Todos";
            this.sbSelecionarFaturamento.Click += new System.EventHandler(this.sbSelecionarFaturamento_Click);
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.sbCancelar;
            this.ClientSize = new System.Drawing.Size(1080, 508);
            this.Controls.Add(this.sbImprimirOS);
            this.Controls.Add(this.sbSelecionarFaturamento);
            this.Controls.Add(this.sbLiberarFaturamento);
            this.Controls.Add(this.sbConferirAtendimentos);
            this.Controls.Add(this.sbImprimirFiltro);
            this.Controls.Add(this.sbExcluir);
            this.Controls.Add(this.sbFaturar);
            this.Controls.Add(this.sbIncluir);
            this.MaximizeBox = true;
            this.Name = "FormAtendimento";
            this.Text = "Gerenciamento de Atendimentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormAtendimento_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAtendimento_KeyDown);
            this.Controls.SetChildIndex(this.sbIncluir, 0);
            this.Controls.SetChildIndex(this.sbFaturar, 0);
            this.Controls.SetChildIndex(this.sbExcluir, 0);
            this.Controls.SetChildIndex(this.sbImprimirFiltro, 0);
            this.Controls.SetChildIndex(this.sbConferirAtendimentos, 0);
            this.Controls.SetChildIndex(this.sbLiberarFaturamento, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            this.Controls.SetChildIndex(this.sbSelecionarFaturamento, 0);
            this.Controls.SetChildIndex(this.sbImprimirOS, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAtendimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtendimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtAtendimento.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEntrada_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSaida_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEntrada_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSaida_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHorasFaturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtConferencia.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDtConferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFaturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meObservacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbConsiderarFaturado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpAnalista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentosENotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentosENotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAtendimentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAtendimentos;
        private DevExpress.XtraGrid.Columns.GridColumn gclDtAtendimento;
        private DevExpress.XtraGrid.Columns.GridColumn gclEnt1;
        private DevExpress.XtraGrid.Columns.GridColumn gclSai1;
        private DevExpress.XtraGrid.Columns.GridColumn gclEnt2;
        private DevExpress.XtraGrid.Columns.GridColumn gclSai2;
        private DevExpress.XtraGrid.Columns.GridColumn gclDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn gclAnalista;
        private DevExpress.XtraGrid.Columns.GridColumn gclTotalHoras;
        private DevExpress.XtraGrid.Columns.GridColumn gclCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gclDtConferencia;
        private DevExpress.XtraGrid.Columns.GridColumn gclFaturar;
        private DevExpress.XtraGrid.Columns.GridColumn gclObservacoes;
        private DevExpress.XtraGrid.Columns.GridColumn gclStatusAtendimento;
        private DevExpress.XtraGrid.Columns.GridColumn gclNumeroNota;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton sbImprimirOS;
        private DevExpress.XtraEditors.SimpleButton sbImprimirFiltro;
        private DevExpress.XtraEditors.SimpleButton sbConferirAtendimentos;
        private DevExpress.XtraEditors.SimpleButton sbLiberarFaturamento;
        private DevExpress.XtraEditors.SimpleButton sbFaturar;
        private DevExpress.XtraEditors.SimpleButton sbIncluir;
        private DevExpress.XtraEditors.SimpleButton sbExcluir;
        private Cwork.Utilitarios.Componentes.LookupButton lkbAnalista;
        private Cwork.Utilitarios.Componentes.Lookup lkpAnalista;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chbConsiderarFaturado;
        private DevExpress.XtraEditors.DateEdit deDataFinal;
        private DevExpress.XtraEditors.LabelControl lbDataInicial;
        private DevExpress.XtraEditors.LabelControl lbDataFinal;
        private DevExpress.XtraEditors.SimpleButton sbFiltrar;
        private DevExpress.XtraEditors.DateEdit deDataInicial;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkpStatus;
        public DevExpress.XtraEditors.Repository.RepositoryItemDateEdit deDtConferencia;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chbFaturar;
        public DevExpress.XtraEditors.Repository.RepositoryItemDateEdit deDtAtendimento;
        public DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit teEntrada_1;
        public DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit teEntrada_2;
        public DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit teSaida_1;
        public DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit teSaida_2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit meDescricao;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit meObservacoes;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lkpCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcDocumentosENotas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDocumentosENotas;
        private DevExpress.XtraGrid.Columns.GridColumn selecionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn dataDeVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn razaoSocial;
        private DevExpress.XtraGrid.Columns.GridColumn fantasia;
        private DevExpress.XtraGrid.Columns.GridColumn valor;
        private DevExpress.XtraGrid.Columns.GridColumn numDocFinanceiro;
        private DevExpress.XtraGrid.Columns.GridColumn emailExibicao;
        private DevExpress.XtraGrid.Columns.GridColumn dataEmailEnviado;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox repositoryItemResourcesComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        private DevExpress.XtraEditors.SimpleButton sbCarregarDocumentos;
        private DevExpress.XtraEditors.DateEdit txtDataInicio;
        private DevExpress.XtraEditors.DateEdit txtDataFim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.Lookup lookup1;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox repositoryItemResourcesComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit2;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarFaturamento;
        private DevExpress.XtraGrid.Columns.GridColumn gclTotalHorasFat;
        public DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit teHorasFaturar;
    }
}
