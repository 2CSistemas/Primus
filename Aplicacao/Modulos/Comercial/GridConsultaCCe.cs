using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Negocio;
using System.Linq;
using Modelo;
using cwkGestao.Modelo;
using Relatorio.Relatorios;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridConsultaCCe : Aplicacao.IntermediariasTela.FormManutCartaCorrecaoIntermediaria
    {
        private cwkGestao.Modelo.Nota _objnota;
        public GridConsultaCCe(cwkGestao.Modelo.Nota objNota)
        {
            InitializeComponent();
            sbGravar.Visible = false;
            _objnota = objNota;

            var GetCCe = (List<CartaCorrecao>)CartaCorrecaoController.Instancia.GetAll();

            List<CartaCorrecao> Carta = new List<CartaCorrecao>();

            foreach (var item in GetCCe)
            {
                if (item.Nota.ID == objNota.ID)
                    Carta.Add(item);
            }
            gcCCe.DataSource = Carta;

        }

        private void gcCCe_DoubleClick(object sender, EventArgs e)
        {
            int indiceCCeSelecionado = gvCCe.GetSelectedRows()[0];
            Selecionado = (CartaCorrecao)gvCCe.GetRow(indiceCCeSelecionado);
            Selecionado.Nota = _objnota;
            FormCartaCorrecao form = new FormCartaCorrecao(true, Selecionado, _objnota);
            form.ShowDialog();
        }

        private void btImprimirCCe_Click(object sender, EventArgs e)
        {
            if (gvCCe.RowCount != 0)
            {
                int indiceCCeSelecionado = gvCCe.GetSelectedRows()[0];
                var CCe = (CartaCorrecao)gvCCe.GetRow(indiceCCeSelecionado);
                rptCCEImpressao report = new rptCCEImpressao(CCe.ID);
                report.ShowPreview();
            }
            else
            {
                MessageBox.Show("Não há registros de cartas de correção.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
    }
}