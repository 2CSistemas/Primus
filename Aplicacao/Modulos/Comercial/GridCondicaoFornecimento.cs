using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridCondicaoFornecimento : Form
    {
        private void AtualizarGrid()
        {

            var lista = CondicaoFornecimentoController.Instancia.GetTodasCondicaoFornecimento();
            ovGRD_CondicaoFornecimento.DataSource = lista;
            ovGRD_CondicaoFornecimento.RefreshDataSource();
            ovGRD_CondicaoFornecimento.Refresh();
        }
        public GridCondicaoFornecimento()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            FormCondicaoFornecimento Form = new FormCondicaoFornecimento(null, Acao.Incluir);
            Form.ShowDialog(this);
            AtualizarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            FormCondicaoFornecimento Form = new FormCondicaoFornecimento((CondicaoFornecimento)ovGV_CondicaoFornecimento.GetFocusedRow(), Acao.Alterar);
            Form.ShowDialog(this);
            AtualizarGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CondicaoFornecimentoController.Instancia.RegisterDeleteIntoTransaction((CondicaoFornecimento)ovGV_CondicaoFornecimento.GetFocusedRow());
                CondicaoFornecimentoController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            FormCondicaoFornecimento Form = new FormCondicaoFornecimento((CondicaoFornecimento)ovGV_CondicaoFornecimento.GetFocusedRow(), Acao.Consultar);
            Form.ShowDialog(this);
            AtualizarGrid();
        }

        private void ovGRD_CondicaoFornecimento_DoubleClick(object sender, EventArgs e)
        {
            btn_Alterar_Click(sender, e);
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
