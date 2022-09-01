namespace Aplicacao.Modulos.Rel
{
    partial class FormRelatorioLimitePorCliente
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
            this.btAdPessoa = new Componentes.devexpress.cwk_DevButton();
            this.cbPessoa = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.chbbTodos = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(708, 215);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbbTodos);
            this.tabPage1.Controls.Add(this.btAdPessoa);
            this.tabPage1.Controls.Add(this.cbPessoa);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Size = new System.Drawing.Size(702, 209);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl8, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.btAdPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbbTodos, 0);
            // 
            // btOk
            // 
            this.btOk.ImageOptions.ImageIndex = 0;
            this.btOk.Location = new System.Drawing.Point(566, 233);
            // 
            // btCancelar
            // 
            this.btCancelar.ImageOptions.ImageIndex = 1;
            this.btCancelar.Location = new System.Drawing.Point(645, 233);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 237);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.ImageIndex = 2;
            this.simpleButton2.Location = new System.Drawing.Point(12, 233);
            // 
            // btAdPessoa
            // 
            this.btAdPessoa.Location = new System.Drawing.Point(602, 181);
            this.btAdPessoa.Name = "btAdPessoa";
            this.btAdPessoa.Size = new System.Drawing.Size(24, 20);
            this.btAdPessoa.TabIndex = 16;
            this.btAdPessoa.TabStop = false;
            this.btAdPessoa.Text = "...";
            this.btAdPessoa.Click += new System.EventHandler(this.btAdPessoa_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.ButtonLookup = this.btAdPessoa;
            this.cbPessoa.Key = System.Windows.Forms.Keys.F5;
            this.cbPessoa.Location = new System.Drawing.Point(52, 181);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPessoa.Properties.NullText = "";
            this.cbPessoa.Size = new System.Drawing.Size(544, 20);
            this.cbPessoa.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(9, 184);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Cliente:";
            // 
            // chbbTodos
            // 
            this.chbbTodos.Location = new System.Drawing.Point(632, 182);
            this.chbbTodos.Name = "chbbTodos";
            this.chbbTodos.Properties.Caption = "Todos";
            this.chbbTodos.Size = new System.Drawing.Size(54, 19);
            this.chbbTodos.TabIndex = 24;
            this.chbbTodos.CheckedChanged += new System.EventHandler(this.chbbTodos_CheckedChanged);
            // 
            // FormRelatorioLimitePorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 268);
            this.Name = "FormRelatorioLimitePorCliente";
            this.Text = "Relatório Cliente Limite Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.devexpress.cwk_DevButton btAdPessoa;
        private Componentes.devexpress.cwk_DevLookup cbPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit chbbTodos;
    }
}