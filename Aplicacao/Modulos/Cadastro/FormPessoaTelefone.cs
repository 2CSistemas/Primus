using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormPessoaTelefone : Aplicacao.IntermediariasTela.FormManutPessoaTelefoneIntermediaria
    {
        public FormPessoaTelefone()
        {
            
        }

        public FormPessoaTelefone(PessoaTelefone Tel)
        {
            Selecionado = Tel;
            if (Tel.Tipo == "Celular")
            {
                label1.Visible = true;
                cbOperadora.Visible = true;
            }
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            chbBPrincipal.Enabled = true;
            label1.Visible = false;
            cbOperadora.Visible = false;
        }

        protected override void SetarMascaras()
        {
        }

        protected override void OK()
        {
            this.Selecionado.Sequencia = this.Selecionado.Pessoa.PessoaTelefones.Count == 0 ? 2 : this.Selecionado.Pessoa.PessoaTelefones.Count + 1;
            base.OK();
            this.Selecionado.Tipo = cbTipo.Text;
        }

        private void cbTipo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue == "Celular")
            {
                label1.Visible = true;
                cbOperadora.Visible = true;
            }
            else
            {
                label1.Visible = false;
                cbOperadora.Visible = false;
            }
        }

    }
}
