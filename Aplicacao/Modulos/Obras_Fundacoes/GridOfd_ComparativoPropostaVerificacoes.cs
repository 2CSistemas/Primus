using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Views.Base;
using Relatorio.Relatorios;
using Relatorio.dsOfdComparativoPropostaVerificacoesTableAdapters;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class GridOfd_ComparativoPropostaVerificacoes : DevExpress.XtraEditors.XtraForm
    {
        private int idProposta;

        public GridOfd_ComparativoPropostaVerificacoes(int idProposta)
        {
            this.idProposta = idProposta;
            InitializeComponent();
            CarregarGrid();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarGrid()
        {
            dsOfdComparativoPropostaVerificacoesTableAdapter ds = new dsOfdComparativoPropostaVerificacoesTableAdapter();
            gcComparativo.DataSource = ds.GetData(idProposta);
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            rptOfdComparativoPropostaVerificacoes rel = new rptOfdComparativoPropostaVerificacoes(idProposta);
            rel.ShowPreview();
        }
    }
}