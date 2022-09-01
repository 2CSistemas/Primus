namespace Aplicacao
{
    partial class FormOfd_PropostaRevisaoPerfuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_PropostaRevisaoPerfuracoes));
            this.txtRevisao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbRevisao = new DevExpress.XtraEditors.LabelControl();
            this.lbObservacao = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.btConsultarPerfuracao = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirPerfuracao = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarPerfuracao = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirPerfuracao = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcPerfuracoes = new DevExpress.XtraGrid.GridControl();
            this.gvPerfuracoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbPerfuracoes = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRevisao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPerfuracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPerfuracoes)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 359);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(693, 359);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(774, 359);
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
            this.tpPrincipal.Controls.Add(this.lbPerfuracoes);
            this.tpPrincipal.Controls.Add(this.btConsultarPerfuracao);
            this.tpPrincipal.Controls.Add(this.btExcluirPerfuracao);
            this.tpPrincipal.Controls.Add(this.lbObservacao);
            this.tpPrincipal.Controls.Add(this.btAlterarPerfuracao);
            this.tpPrincipal.Controls.Add(this.btIncluirPerfuracao);
            this.tpPrincipal.Controls.Add(this.txtObservacao);
            this.tpPrincipal.Controls.Add(this.lbRevisao);
            this.tpPrincipal.Controls.Add(this.gcPerfuracoes);
            this.tpPrincipal.Controls.Add(this.txtRevisao);
            this.tpPrincipal.Size = new System.Drawing.Size(831, 335);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(837, 341);
            // 
            // txtRevisao
            // 
            this.txtRevisao.CwkFuncaoValidacao = null;
            this.txtRevisao.CwkMascara = null;
            this.txtRevisao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtRevisao.Location = new System.Drawing.Point(96, 22);
            this.txtRevisao.Name = "txtRevisao";
            this.txtRevisao.Properties.MaxLength = 200;
            this.txtRevisao.SelecionarTextoOnEnter = false;
            this.txtRevisao.Size = new System.Drawing.Size(93, 20);
            this.txtRevisao.TabIndex = 15;
            // 
            // lbRevisao
            // 
            this.lbRevisao.Location = new System.Drawing.Point(48, 25);
            this.lbRevisao.Name = "lbRevisao";
            this.lbRevisao.Size = new System.Drawing.Size(42, 13);
            this.lbRevisao.TabIndex = 16;
            this.lbRevisao.Text = "Revisão:";
            // 
            // lbObservacao
            // 
            this.lbObservacao.Location = new System.Drawing.Point(28, 51);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(62, 13);
            this.lbObservacao.TabIndex = 18;
            this.lbObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CwkFuncaoValidacao = null;
            this.txtObservacao.CwkMascara = null;
            this.txtObservacao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtObservacao.Location = new System.Drawing.Point(96, 48);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.MaxLength = 200;
            this.txtObservacao.SelecionarTextoOnEnter = false;
            this.txtObservacao.Size = new System.Drawing.Size(704, 20);
            this.txtObservacao.TabIndex = 17;
            // 
            // btConsultarPerfuracao
            // 
            this.btConsultarPerfuracao.GridControl = null;
            this.btConsultarPerfuracao.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarPerfuracao.Location = new System.Drawing.Point(491, 295);
            this.btConsultarPerfuracao.Name = "btConsultarPerfuracao";
            this.btConsultarPerfuracao.Size = new System.Drawing.Size(75, 23);
            this.btConsultarPerfuracao.SubForm = null;
            this.btConsultarPerfuracao.TabIndex = 21;
            this.btConsultarPerfuracao.TabStop = false;
            this.btConsultarPerfuracao.Text = "&Consultar";
            // 
            // btExcluirPerfuracao
            // 
            this.btExcluirPerfuracao.GridControl = null;
            this.btExcluirPerfuracao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirPerfuracao.Location = new System.Drawing.Point(725, 295);
            this.btExcluirPerfuracao.Name = "btExcluirPerfuracao";
            this.btExcluirPerfuracao.Size = new System.Drawing.Size(75, 23);
            this.btExcluirPerfuracao.SubForm = null;
            this.btExcluirPerfuracao.TabIndex = 27;
            this.btExcluirPerfuracao.TabStop = false;
            this.btExcluirPerfuracao.Text = "&Excluir";
            // 
            // btAlterarPerfuracao
            // 
            this.btAlterarPerfuracao.GridControl = null;
            this.btAlterarPerfuracao.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarPerfuracao.Location = new System.Drawing.Point(647, 295);
            this.btAlterarPerfuracao.Name = "btAlterarPerfuracao";
            this.btAlterarPerfuracao.Size = new System.Drawing.Size(75, 23);
            this.btAlterarPerfuracao.SubForm = null;
            this.btAlterarPerfuracao.TabIndex = 25;
            this.btAlterarPerfuracao.TabStop = false;
            this.btAlterarPerfuracao.Text = "&Alterar";
            // 
            // btIncluirPerfuracao
            // 
            this.btIncluirPerfuracao.GridControl = null;
            this.btIncluirPerfuracao.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirPerfuracao.Location = new System.Drawing.Point(569, 295);
            this.btIncluirPerfuracao.Name = "btIncluirPerfuracao";
            this.btIncluirPerfuracao.Size = new System.Drawing.Size(75, 23);
            this.btIncluirPerfuracao.SubForm = null;
            this.btIncluirPerfuracao.TabIndex = 23;
            this.btIncluirPerfuracao.TabStop = false;
            this.btIncluirPerfuracao.Text = "&Incluir";
            // 
            // gcPerfuracoes
            // 
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcPerfuracoes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPerfuracoes.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPerfuracoes.Location = new System.Drawing.Point(96, 74);
            this.gcPerfuracoes.MainView = this.gvPerfuracoes;
            this.gcPerfuracoes.Name = "gcPerfuracoes";
            this.gcPerfuracoes.Size = new System.Drawing.Size(704, 215);
            this.gcPerfuracoes.TabIndex = 19;
            this.gcPerfuracoes.UseEmbeddedNavigator = true;
            this.gcPerfuracoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPerfuracoes});
            // 
            // gvPerfuracoes
            // 
            this.gvPerfuracoes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.Empty.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPerfuracoes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPerfuracoes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPerfuracoes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPerfuracoes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPerfuracoes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPerfuracoes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPerfuracoes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPerfuracoes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPerfuracoes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPerfuracoes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvPerfuracoes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.Preview.Options.UseFont = true;
            this.gvPerfuracoes.Appearance.Preview.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPerfuracoes.Appearance.Row.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvPerfuracoes.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPerfuracoes.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPerfuracoes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPerfuracoes.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvPerfuracoes.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPerfuracoes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPerfuracoes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPerfuracoes.GridControl = this.gcPerfuracoes;
            this.gvPerfuracoes.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPerfuracoes.Name = "gvPerfuracoes";
            this.gvPerfuracoes.OptionsBehavior.Editable = false;
            this.gvPerfuracoes.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPerfuracoes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPerfuracoes.OptionsView.EnableAppearanceOddRow = true;
            this.gvPerfuracoes.OptionsView.ShowAutoFilterRow = true;
            this.gvPerfuracoes.OptionsView.ShowGroupPanel = false;
            // 
            // lbPerfuracoes
            // 
            this.lbPerfuracoes.Location = new System.Drawing.Point(28, 74);
            this.lbPerfuracoes.Name = "lbPerfuracoes";
            this.lbPerfuracoes.Size = new System.Drawing.Size(62, 13);
            this.lbPerfuracoes.TabIndex = 19;
            this.lbPerfuracoes.Text = "Perfurações:";
            // 
            // FormOfd_PropostaRevisaoPerfuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(861, 394);
            this.Name = "FormOfd_PropostaRevisaoPerfuracoes";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRevisao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPerfuracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPerfuracoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRevisao;
        private DevExpress.XtraEditors.LabelControl lbObservacao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao;
        private DevExpress.XtraEditors.LabelControl lbRevisao;
        private DevExpress.XtraGrid.GridControl gcPerfuracoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPerfuracoes;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarPerfuracao;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirPerfuracao;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarPerfuracao;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirPerfuracao;
        private DevExpress.XtraEditors.LabelControl lbPerfuracoes;
    }
}
