namespace Aplicacao.Modulos.Telefonia
{
    partial class FormTel_TipoLigacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTel_TipoLigacao));
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResumoFatura = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.btIncluirPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.btConsultarPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcTipoLigacaoPrecos = new DevExpress.XtraGrid.GridControl();
            this.gvTipoLigacaoPrecos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.chbLigacaoLocal = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResumoFatura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoLigacaoPrecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoLigacaoPrecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLigacaoLocal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 296);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(508, 296);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(589, 296);
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
            this.tpPrincipal.Controls.Add(this.chbLigacaoLocal);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.btIncluirPreco);
            this.tpPrincipal.Controls.Add(this.btAlterarPreco);
            this.tpPrincipal.Controls.Add(this.btExcluirPreco);
            this.tpPrincipal.Controls.Add(this.btConsultarPreco);
            this.tpPrincipal.Controls.Add(this.gcTipoLigacaoPrecos);
            this.tpPrincipal.Controls.Add(this.txtResumoFatura);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(643, 269);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(652, 278);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(70, 32);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 60;
            this.txtDescricao.SelecionarTextoOnEnter = true;
            this.txtDescricao.Size = new System.Drawing.Size(566, 20);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeralInteiro;
            this.txtCodigo.Location = new System.Drawing.Point(70, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtResumoFatura
            // 
            this.txtResumoFatura.CwkFuncaoValidacao = null;
            this.txtResumoFatura.CwkMascara = null;
            this.txtResumoFatura.CwkValidacao = null;
            this.txtResumoFatura.Location = new System.Drawing.Point(265, 6);
            this.txtResumoFatura.Name = "txtResumoFatura";
            this.txtResumoFatura.Properties.MaxLength = 30;
            this.txtResumoFatura.SelecionarTextoOnEnter = true;
            this.txtResumoFatura.Size = new System.Drawing.Size(273, 20);
            this.txtResumoFatura.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resumo Fatura:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btIncluirPreco
            // 
            this.btIncluirPreco.GridControl = null;
            this.btIncluirPreco.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirPreco.Location = new System.Drawing.Point(399, 242);
            this.btIncluirPreco.Name = "btIncluirPreco";
            this.btIncluirPreco.Size = new System.Drawing.Size(75, 23);
            this.btIncluirPreco.SubForm = null;
            this.btIncluirPreco.TabIndex = 10;
            this.btIncluirPreco.TabStop = false;
            this.btIncluirPreco.Text = "&Incluir";
            // 
            // btAlterarPreco
            // 
            this.btAlterarPreco.GridControl = null;
            this.btAlterarPreco.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarPreco.Location = new System.Drawing.Point(480, 242);
            this.btAlterarPreco.Name = "btAlterarPreco";
            this.btAlterarPreco.Size = new System.Drawing.Size(75, 23);
            this.btAlterarPreco.SubForm = null;
            this.btAlterarPreco.TabIndex = 11;
            this.btAlterarPreco.TabStop = false;
            this.btAlterarPreco.Text = "&Alterar";
            // 
            // btExcluirPreco
            // 
            this.btExcluirPreco.GridControl = null;
            this.btExcluirPreco.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirPreco.Location = new System.Drawing.Point(561, 242);
            this.btExcluirPreco.Name = "btExcluirPreco";
            this.btExcluirPreco.Size = new System.Drawing.Size(75, 23);
            this.btExcluirPreco.SubForm = null;
            this.btExcluirPreco.TabIndex = 12;
            this.btExcluirPreco.TabStop = false;
            this.btExcluirPreco.Text = "&Excluir";
            // 
            // btConsultarPreco
            // 
            this.btConsultarPreco.GridControl = null;
            this.btConsultarPreco.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarPreco.Location = new System.Drawing.Point(318, 242);
            this.btConsultarPreco.Name = "btConsultarPreco";
            this.btConsultarPreco.Size = new System.Drawing.Size(75, 23);
            this.btConsultarPreco.SubForm = null;
            this.btConsultarPreco.TabIndex = 9;
            this.btConsultarPreco.TabStop = false;
            this.btConsultarPreco.Text = "&Consultar";
            // 
            // gcTipoLigacaoPrecos
            // 
            this.gcTipoLigacaoPrecos.EmbeddedNavigator.Name = "";
            this.gcTipoLigacaoPrecos.Location = new System.Drawing.Point(70, 58);
            this.gcTipoLigacaoPrecos.MainView = this.gvTipoLigacaoPrecos;
            this.gcTipoLigacaoPrecos.Name = "gcTipoLigacaoPrecos";
            this.gcTipoLigacaoPrecos.Size = new System.Drawing.Size(566, 178);
            this.gcTipoLigacaoPrecos.TabIndex = 8;
            this.gcTipoLigacaoPrecos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoLigacaoPrecos});
            // 
            // gvTipoLigacaoPrecos
            // 
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoLigacaoPrecos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoLigacaoPrecos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoLigacaoPrecos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacaoPrecos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacaoPrecos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacaoPrecos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoLigacaoPrecos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoLigacaoPrecos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoLigacaoPrecos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacaoPrecos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoLigacaoPrecos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoLigacaoPrecos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.Preview.Options.UseFont = true;
            this.gvTipoLigacaoPrecos.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacaoPrecos.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoLigacaoPrecos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacaoPrecos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoLigacaoPrecos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoLigacaoPrecos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoLigacaoPrecos.GridControl = this.gcTipoLigacaoPrecos;
            this.gvTipoLigacaoPrecos.GroupPanelText = " ";
            this.gvTipoLigacaoPrecos.Name = "gvTipoLigacaoPrecos";
            this.gvTipoLigacaoPrecos.OptionsBehavior.Editable = false;
            this.gvTipoLigacaoPrecos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTipoLigacaoPrecos.OptionsCustomization.AllowGroup = false;
            this.gvTipoLigacaoPrecos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoLigacaoPrecos.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoLigacaoPrecos.OptionsView.ShowGroupPanel = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preços:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbLigacaoLocal
            // 
            this.chbLigacaoLocal.Location = new System.Drawing.Point(544, 7);
            this.chbLigacaoLocal.Name = "chbLigacaoLocal";
            this.chbLigacaoLocal.Properties.Caption = "Ligação Local";
            this.chbLigacaoLocal.Size = new System.Drawing.Size(92, 19);
            this.chbLigacaoLocal.TabIndex = 4;
            // 
            // FormTel_TipoLigacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 331);
            this.Name = "FormTel_TipoLigacao";
            this.Text = "FormTel_TipoLigacao";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResumoFatura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoLigacaoPrecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoLigacaoPrecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLigacaoLocal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtResumoFatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirPreco;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarPreco;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirPreco;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarPreco;
        public DevExpress.XtraGrid.GridControl gcTipoLigacaoPrecos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTipoLigacaoPrecos;
        private DevExpress.XtraEditors.CheckEdit chbLigacaoLocal;
    }
}