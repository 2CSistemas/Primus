using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao.Modulos.Estoque
{
    public partial class FormRastreamentoStatus : Form
    {
        public FormRastreamentoStatus(ExpedicaoHistorico expedicaoHistorico, IList<ExpedicaoHistorico> historicos)
        {
            InitializeComponent();

            List<ExpedicaoHistorico> historico = historicos.Where(h => h.ExpedicaoRastreamento.IDRastreamento.Codigo == expedicaoHistorico.ExpedicaoRastreamento.IDRastreamento.Codigo).ToList();

            gcRastreamentos.DataSource = historico;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRastreamentoStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
