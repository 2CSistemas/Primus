using Aplicacao.Modulos.Cadastro;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridCotacaoDeMoedas : Form
    {           
        private void AtualizarGrid()
        {
            var lista = CotacaoMoedaController.Instancia.GetTodasCotacaoMoedas();
            foreach (CotacaoMoeda Cot in lista)
                if (Cot.IDMoeda.HasValue)
                    Cot.Moeda = MoedaController.Instancia.GetAll().Where(o => o.ID == Cot.IDMoeda.Value).FirstOrDefault()?.Descricao;

            ovGRD_CotacaoDeMoeda.DataSource = lista;
            ovGRD_CotacaoDeMoeda.RefreshDataSource();
            ovGRD_CotacaoDeMoeda.Refresh();
        }

        public GridCotacaoDeMoedas()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            FormCotacaoDeMoedas form = new FormCotacaoDeMoedas(null, Acao.Incluir);
            form.ShowDialog(this);
            AtualizarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            FormCotacaoDeMoedas form = new FormCotacaoDeMoedas((CotacaoMoeda)ovGV_CotacaoDeMoeda.GetFocusedRow(), Acao.Alterar);
            form.ShowDialog(this);
            AtualizarGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CotacaoMoedaController.Instancia.RegisterDeleteIntoTransaction((CotacaoMoeda)ovGV_CotacaoDeMoeda.GetFocusedRow());
                CotacaoMoedaController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }
        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            FormCotacaoDeMoedas Form = new FormCotacaoDeMoedas((CotacaoMoeda)ovGV_CotacaoDeMoeda.GetFocusedRow(), Acao.Consultar);
            Form.ShowDialog(this);
            AtualizarGrid();
        }

        private void ovGRD_CotacaoDeMoeda_DoubleClick(object sender, EventArgs e)
        {
            btn_Alterar_Click(sender, e);
        }

        private void GridCotacaoDeMoedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
            {
                this.Close();
            }
        }
    }
}