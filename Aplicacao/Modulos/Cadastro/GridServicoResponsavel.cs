using System;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class GridServicoResponsavel : Form
    {
        public ServicoResponsavel Selecionado = null;
        public bool VemDeSelecao = false;

        private void AtualizarGrid()
        {
            var lista = ServicoResponsavelController.Instancia.GetAll();
            ovGRD_ServicoResponsavel.DataSource = lista;
            ovGRD_ServicoResponsavel.RefreshDataSource();
            ovGRD_ServicoResponsavel.Refresh();
        }

        public GridServicoResponsavel(bool VemDeSelecao = false)
        {
            InitializeComponent();
            this.VemDeSelecao = VemDeSelecao;
            sbSelecionar.Visible = VemDeSelecao;
            AtualizarGrid();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            FormCadServicoResponsavel Form = new FormCadServicoResponsavel(null, cwkGestao.Modelo.Acao.Incluir);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            FormCadServicoResponsavel Form = new FormCadServicoResponsavel((ServicoResponsavel)ovGV_ServicoResponsavel.GetFocusedRow(), cwkGestao.Modelo.Acao.Alterar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ServicoResponsavelController.Instancia.RegisterDeleteIntoTransaction((ServicoResponsavel)ovGV_ServicoResponsavel.GetFocusedRow());
                ServicoResponsavelController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbSelecionar_Click(object sender, EventArgs e)
        {
            Selecionado = (ServicoResponsavel)ovGV_ServicoResponsavel.GetFocusedRow();
            Close();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            FormCadServicoResponsavel Form = new FormCadServicoResponsavel((ServicoResponsavel)ovGV_ServicoResponsavel.GetFocusedRow(), cwkGestao.Modelo.Acao.Consultar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void ovGRD_ServicoResponsavel_DoubleClick(object sender, EventArgs e)
        {
            if (VemDeSelecao)
                sbSelecionar_Click(sender, e);
            else
                btn_Alterar_Click(sender, e);
        }

        private void GridServicoResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}