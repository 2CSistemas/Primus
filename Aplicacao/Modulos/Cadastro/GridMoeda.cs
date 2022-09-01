using Aplicacao.Modulos.Cadastro;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridMoeda : Form
    {
        public Moeda Selecionado = null;
        public bool VemDeSelecao = false;
        public FormCotacaoDeMoedas form = null;

        private void AtualizarGrid()
        {
            var lista = MoedaController.Instancia.GetTodasMoedas();
            ovGRD_Moeda.DataSource = lista;
            ovGRD_Moeda.RefreshDataSource();
            ovGRD_Moeda.Refresh();
        }

        public GridMoeda(bool VemDeSelecao = false, FormCotacaoDeMoedas form = null)
        {
            InitializeComponent();
            this.VemDeSelecao = VemDeSelecao;
            this.form = form;
            sbSelecionar.Visible = VemDeSelecao;

            AtualizarGrid();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            FormCadMoeda Form = new FormCadMoeda(null, cwkGestao.Modelo.Acao.Incluir);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            FormCadMoeda Form = new FormCadMoeda((Moeda)ovGV_Moeda.GetFocusedRow(), cwkGestao.Modelo.Acao.Alterar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MoedaController.Instancia.RegisterDeleteIntoTransaction((Moeda)ovGV_Moeda.GetFocusedRow());
                MoedaController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            FormCadMoeda Form = new FormCadMoeda((Moeda)ovGV_Moeda.GetFocusedRow(), cwkGestao.Modelo.Acao.Consultar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void ovGRD_Moeda_DoubleClick(object sender, EventArgs e)
        {
            if (VemDeSelecao)
                sbSelecionar_Click(sender, e);
            else
                btn_Alterar_Click(sender, e);
        }

        private void GridMoeda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                this.Close();
        }

        private void sbSelecionar_Click(object sender, EventArgs e)
        {
            Selecionado = (Moeda)ovGV_Moeda.GetFocusedRow();
            form.SelecionarMoeda(Selecionado);
            Close();
        }
    }
}