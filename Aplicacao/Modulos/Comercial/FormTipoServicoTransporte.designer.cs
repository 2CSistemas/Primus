namespace Aplicacao
{
    partial class FormTipoServicoTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoServicoTransporte));
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.chkControleNumeracao = new DevExpress.XtraEditors.CheckEdit();
            this.chkCorreios = new DevExpress.XtraEditors.CheckEdit();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.thirdPanel = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAcrescimoFrete = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkpServicoCorreios = new DevExpress.XtraEditors.LookUpEdit();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.btSelecionarArquivo = new Cwork.Utilitarios.Componentes.DevButton();
            this.txtCaminhoArquivo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            this.firstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkControleNumeracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCorreios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.thirdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcrescimoFrete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServicoCorreios.Properties)).BeginInit();
            this.secondPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 140);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(519, 140);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(600, 140);
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
            this.tpPrincipal.Controls.Add(this.secondPanel);
            this.tpPrincipal.Controls.Add(this.thirdPanel);
            this.tpPrincipal.Controls.Add(this.firstPanel);
            this.tpPrincipal.Size = new System.Drawing.Size(657, 121);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(663, 127);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // firstPanel
            // 
            this.firstPanel.Controls.Add(this.chkControleNumeracao);
            this.firstPanel.Controls.Add(this.chkCorreios);
            this.firstPanel.Controls.Add(this.txtDescricao);
            this.firstPanel.Controls.Add(this.labelControl8);
            this.firstPanel.Controls.Add(this.txtCodigo);
            this.firstPanel.Controls.Add(this.labelControl7);
            this.firstPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstPanel.Location = new System.Drawing.Point(0, 0);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(657, 57);
            this.firstPanel.TabIndex = 19;
            // 
            // chkControleNumeracao
            // 
            this.chkControleNumeracao.Location = new System.Drawing.Point(249, 7);
            this.chkControleNumeracao.Name = "chkControleNumeracao";
            this.chkControleNumeracao.Properties.Caption = "Controle Numeração";
            this.chkControleNumeracao.Size = new System.Drawing.Size(122, 19);
            this.chkControleNumeracao.TabIndex = 3;
            // 
            // chkCorreios
            // 
            this.chkCorreios.Location = new System.Drawing.Point(178, 7);
            this.chkCorreios.Name = "chkCorreios";
            this.chkCorreios.Properties.Caption = "Correios";
            this.chkCorreios.Size = new System.Drawing.Size(65, 19);
            this.chkCorreios.TabIndex = 2;
            this.chkCorreios.EditValueChanged += new System.EventHandler(this.chkCorreios_EditValueChanged_1);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(73, 32);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 60;
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(574, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(19, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtCodigo.EditValue = 0;
            this.txtCodigo.Location = new System.Drawing.Point(73, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "d";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Código:";
            // 
            // thirdPanel
            // 
            this.thirdPanel.Controls.Add(this.labelControl4);
            this.thirdPanel.Controls.Add(this.labelControl3);
            this.thirdPanel.Controls.Add(this.txtAcrescimoFrete);
            this.thirdPanel.Controls.Add(this.labelControl2);
            this.thirdPanel.Controls.Add(this.lkpServicoCorreios);
            this.thirdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.thirdPanel.Location = new System.Drawing.Point(0, 57);
            this.thirdPanel.Name = "thirdPanel";
            this.thirdPanel.Size = new System.Drawing.Size(657, 26);
            this.thirdPanel.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(622, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "%";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(454, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Acréscimo Frete:";
            // 
            // txtAcrescimoFrete
            // 
            this.txtAcrescimoFrete.CwkFuncaoValidacao = null;
            this.txtAcrescimoFrete.CwkMascara = null;
            this.txtAcrescimoFrete.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtAcrescimoFrete.Location = new System.Drawing.Point(541, 2);
            this.txtAcrescimoFrete.Name = "txtAcrescimoFrete";
            this.txtAcrescimoFrete.Properties.Mask.EditMask = "n";
            this.txtAcrescimoFrete.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAcrescimoFrete.Properties.MaxLength = 60;
            this.txtAcrescimoFrete.SelecionarTextoOnEnter = false;
            this.txtAcrescimoFrete.Size = new System.Drawing.Size(75, 20);
            this.txtAcrescimoFrete.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Cód. Serviço:";
            // 
            // lkpServicoCorreios
            // 
            this.lkpServicoCorreios.Location = new System.Drawing.Point(73, 3);
            this.lkpServicoCorreios.Name = "lkpServicoCorreios";
            this.lkpServicoCorreios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpServicoCorreios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", 50, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Servico", 200, "Serviço")});
            this.lkpServicoCorreios.Properties.NullText = "Escolha um serviço";
            this.lkpServicoCorreios.Size = new System.Drawing.Size(375, 20);
            this.lkpServicoCorreios.TabIndex = 5;
            this.lkpServicoCorreios.EditValueChanged += new System.EventHandler(this.lkpServicoCorreios_EditValueChanged);
            // 
            // secondPanel
            // 
            this.secondPanel.Controls.Add(this.btSelecionarArquivo);
            this.secondPanel.Controls.Add(this.txtCaminhoArquivo);
            this.secondPanel.Controls.Add(this.labelControl1);
            this.secondPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondPanel.Location = new System.Drawing.Point(0, 83);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(657, 34);
            this.secondPanel.TabIndex = 22;
            // 
            // btSelecionarArquivo
            // 
            this.btSelecionarArquivo.GridControl = null;
            this.btSelecionarArquivo.GridControlType = null;
            this.btSelecionarArquivo.GridControlTypeParams = null;
            this.btSelecionarArquivo.Location = new System.Drawing.Point(623, 4);
            this.btSelecionarArquivo.Name = "btSelecionarArquivo";
            this.btSelecionarArquivo.Size = new System.Drawing.Size(24, 20);
            this.btSelecionarArquivo.SubForm = null;
            this.btSelecionarArquivo.SubFormType = null;
            this.btSelecionarArquivo.SubFormTypeParams = null;
            this.btSelecionarArquivo.TabIndex = 23;
            this.btSelecionarArquivo.Text = "...";
            this.btSelecionarArquivo.Click += new System.EventHandler(this.btSelecionarArquivo_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.CwkFuncaoValidacao = null;
            this.txtCaminhoArquivo.CwkMascara = null;
            this.txtCaminhoArquivo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(73, 4);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Properties.MaxLength = 200;
            this.txtCaminhoArquivo.SelecionarTextoOnEnter = false;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(544, 20);
            this.txtCaminhoArquivo.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Imagem:";
            // 
            // FormTipoServicoTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 175);
            this.Name = "FormTipoServicoTransporte";
            this.Shown += new System.EventHandler(this.FormTipoServicoTransporte_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkControleNumeracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCorreios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.thirdPanel.ResumeLayout(false);
            this.thirdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcrescimoFrete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServicoCorreios.Properties)).EndInit();
            this.secondPanel.ResumeLayout(false);
            this.secondPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbTipoArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Panel firstPanel;
        private DevExpress.XtraEditors.CheckEdit chkControleNumeracao;
        private DevExpress.XtraEditors.CheckEdit chkCorreios;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Panel thirdPanel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtAcrescimoFrete;
        private System.Windows.Forms.Panel secondPanel;
        private Cwork.Utilitarios.Componentes.DevButton btSelecionarArquivo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCaminhoArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkpServicoCorreios;
    }
}
