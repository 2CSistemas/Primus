using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormVersao : Aplicacao.IntermediariasTela.FormManutVersaoIntermediaria
    {
        public FormVersao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void btnBancoLimpo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipobanco.SelectedIndex >= 0)
                {
                    if (!String.IsNullOrEmpty(txtCaminhobancolimpo.Text))
                    {
                        openFileDialog1.InitialDirectory = (string)txtCaminhobancolimpo.EditValue;
                        openFileDialog1.FileName = "";
                    }
                    else
                    {
                        openFileDialog1.FileName = "";
                    }
                    if (cbTipobanco.SelectedIndex == 0)
                        openFileDialog1.Filter = "Arquivos Firebird(*.fdb)|*.fdb";
                    else
                        openFileDialog1.Filter = "Arquivos MS SQL Server(*.mdf)|*.mdf";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        txtCaminhobancolimpo.Text = openFileDialog1.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o tipo de banco.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Tipobanco = (short)cbTipobanco.SelectedIndex;
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> retorno = base.ObjetoPraTela(pai);
            cbTipobanco.SelectedIndex = (int)Selecionado.Tipobanco;
 
            return retorno;
        }

        private void FormVersao_Shown(object sender, EventArgs e)
        {
            txtCodigo.Properties.ReadOnly = true;
        }
    }
}
