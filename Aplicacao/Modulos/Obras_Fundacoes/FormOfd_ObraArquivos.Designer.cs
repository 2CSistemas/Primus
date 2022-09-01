namespace Aplicacao.Modulos.Obras_Fundacoes
{
    partial class FormOfd_ObraArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfd_ObraArquivos));
            this.btSelecionarArquivo = new Cwork.Utilitarios.Componentes.DevButton();
            this.txtCaminhoArquivo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtVersaoArquivo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoArquivo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.sbAbrirArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersaoArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 138);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(391, 138);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(472, 138);
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
            this.tpPrincipal.Controls.Add(this.btSelecionarArquivo);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.txtCaminhoArquivo);
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.txtVersaoArquivo);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.cbTipoArquivo);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Size = new System.Drawing.Size(526, 111);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(535, 120);
            // 
            // btSelecionarArquivo
            // 
            this.btSelecionarArquivo.GridControl = null;
            this.btSelecionarArquivo.Location = new System.Drawing.Point(494, 30);
            this.btSelecionarArquivo.Name = "btSelecionarArquivo";
            this.btSelecionarArquivo.Size = new System.Drawing.Size(24, 20);
            this.btSelecionarArquivo.SubForm = null;
            this.btSelecionarArquivo.TabIndex = 15;
            this.btSelecionarArquivo.Text = "...";
            this.btSelecionarArquivo.Click += new System.EventHandler(this.btSelecionarArquivo_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.CwkFuncaoValidacao = null;
            this.txtCaminhoArquivo.CwkMascara = null;
            this.txtCaminhoArquivo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(64, 30);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Properties.MaxLength = 200;
            this.txtCaminhoArquivo.SelecionarTextoOnEnter = false;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(424, 20);
            this.txtCaminhoArquivo.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Arquivo:";
            // 
            // txtVersaoArquivo
            // 
            this.txtVersaoArquivo.CwkFuncaoValidacao = null;
            this.txtVersaoArquivo.CwkMascara = null;
            this.txtVersaoArquivo.CwkValidacao = null;
            this.txtVersaoArquivo.EditValue = 0;
            this.txtVersaoArquivo.Location = new System.Drawing.Point(64, 82);
            this.txtVersaoArquivo.Name = "txtVersaoArquivo";
            this.txtVersaoArquivo.Properties.Mask.EditMask = "d";
            this.txtVersaoArquivo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVersaoArquivo.SelecionarTextoOnEnter = false;
            this.txtVersaoArquivo.Size = new System.Drawing.Size(80, 20);
            this.txtVersaoArquivo.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Versão:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(309, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Tipo Arquivo:";
            // 
            // cbTipoArquivo
            // 
            this.cbTipoArquivo.EditValue = "Word";
            this.cbTipoArquivo.Location = new System.Drawing.Point(379, 82);
            this.cbTipoArquivo.Name = "cbTipoArquivo";
            this.cbTipoArquivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoArquivo.Properties.ImmediatePopup = true;
            this.cbTipoArquivo.Properties.Items.AddRange(new object[] {
            "Word",
            "Excel",
            "Imagem",
            "PDF",
            "CAD"});
            this.cbTipoArquivo.Properties.Tag = "";
            this.cbTipoArquivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoArquivo.Size = new System.Drawing.Size(140, 20);
            this.cbTipoArquivo.TabIndex = 21;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(64, 56);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 200;
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(455, 20);
            this.txtDescricao.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Descrição:";
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtSequencia.EditValue = 0;
            this.txtSequencia.Location = new System.Drawing.Point(64, 4);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Mask.EditMask = "d";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(80, 20);
            this.txtSequencia.TabIndex = 12;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 7);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Sequência:";
            // 
            // sbAbrirArquivo
            // 
            this.sbAbrirArquivo.Image = global::Aplicacao.Properties.Resources.folder1;
            this.sbAbrirArquivo.Location = new System.Drawing.Point(93, 138);
            this.sbAbrirArquivo.Name = "sbAbrirArquivo";
            this.sbAbrirArquivo.Size = new System.Drawing.Size(116, 23);
            this.sbAbrirArquivo.TabIndex = 5;
            this.sbAbrirArquivo.Text = "&Abrir Arquivo";
            this.sbAbrirArquivo.Click += new System.EventHandler(this.sbAbrirArquivo_Click);
            // 
            // FormOfd_ObraArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(559, 173);
            this.Controls.Add(this.sbAbrirArquivo);
            this.Name = "FormOfd_ObraArquivos";
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            this.Controls.SetChildIndex(this.sbAbrirArquivo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersaoArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevButton btSelecionarArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCaminhoArquivo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtVersaoArquivo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbAbrirArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
