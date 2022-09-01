using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public class InputBox : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtInput;
        private Button cmdOK;
        private Button cmdCancel;
        private System.ComponentModel.Container components = null;
        public bool confirmado;

        public InputBox()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(16, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(256, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(124, 42);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(71, 26);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(201, 42);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(71, 26);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // InputBox
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(286, 81);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmdOK.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                cmdCancel.PerformClick();
        }

        public bool Show(string previewInput, out string input)
        {
            this.txtInput.Text = previewInput;
            base.ShowDialog();
            input = this.txtInput.Text;
            return this.confirmado;
        }

        public bool Show(string previewInput, string aTextoTela, out string input)
        {
            this.txtInput.Text = previewInput;
            this.Text = aTextoTela;
            base.ShowDialog();
            input = this.txtInput.Text;
            return this.confirmado;
        }

        public bool Show(out string input)
        {
            this.txtInput.Text = "";
            base.ShowDialog();
            input = this.txtInput.Text;
            return this.confirmado;
        }

        public bool ShowDialog(out string input)
        {
            return this.Show(out input);
        }

        public bool Show(IWin32Window owner, out string input)
        {
            this.txtInput.Text = "";
            base.ShowDialog(owner);
            input = this.txtInput.Text;
            return this.confirmado;
        }

        public bool ShowDialog(IWin32Window owner, out string input)
        {
            return this.Show(owner, out input);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.confirmado = false;
            txtInput.Text = "";
            this.Close();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "Motivo Cancelamento" && txtInput.Text.Trim().Length < 15)
            {
                MessageBox.Show("Motivo de Cancelamento deve ter no mínimo 15 caracteres");
                txtInput.Focus();
                return;
            }
            this.confirmado = true;
            this.Close();
        }
    }
}
