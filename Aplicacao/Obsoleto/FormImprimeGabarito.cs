using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormImprimeGabarito : Form
    {
        public FormImprimeGabarito()
        {
            InitializeComponent();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (txtQtdLinhas.Value == 0)
            {
                erros.AppendLine("Qtd. Linhas: A quantidade de linhas deve ser maior que zero.");
            }
            if (rgLpi.SelectedIndex == -1)
            {
                erros.AppendLine("Lpi: Selecione o lpi.");
            }
            if (String.IsNullOrEmpty((string)txtCaminho.EditValue))
            {
                erros.AppendLine("Caminho: Digite o caminho para a impressora.");
            }

            if (erros.Length == 0)
            {
                BLL.Gabarito.ImprimeGabarito((int)txtQtdLinhas.Value, (bool)chbCondensado.EditValue
                    , (int)rgLpi.EditValue, (string)txtCaminho.EditValue);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente:\n\n" + erros.ToString());
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
