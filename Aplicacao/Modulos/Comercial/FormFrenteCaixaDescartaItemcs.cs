using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaDescartaItemcs : Form
    {
        private IList<FrenteCaixaNotaItem> lista = null;
        public FrenteCaixaNotaItem itemDescartar = null;

        public FormFrenteCaixaNota TelaFrenteCaixa;
        public FormFrenteCaixaDescartaItemcs(IList<FrenteCaixaNotaItem> _lista)
        {
            InitializeComponent();

            lista = _lista;
        }

        private void BtnDescartar_Click(object sender, EventArgs e)
        {
            Descartar();
        }

        private void Descartar()
        {
            int numero = 0;

            numero = int.Parse(this.txtNumero.Text);

            if (numero >= 1 && lista.Count() > 0)
            {
                itemDescartar = null;
                foreach (var item in lista)
                {
                    if (item.Sequencia == numero)
                    {
                        itemDescartar = item;
                        break;
                    }
                }
                if (itemDescartar != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Informe um número válido !", "Item não encontrado !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Focus();
                }
            }
            else
            {
                MessageBox.Show("Informe um número válido !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFrenteCaixaDescartaItemcs_Load(object sender, EventArgs e)
        {

        }

        private void FormFrenteCaixaDescartaItemcs_Shown(object sender, EventArgs e)
        {
            if (lista != null)
            {
                int numero = lista[lista.Count()-1].Sequencia;

                txtNumero.Text = numero.ToString();
            }
            txtNumero.Focus();
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Descartar();
            }
        }
    }
}
