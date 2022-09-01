using System;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class GridResponsavel : Form
    {
        public Responsavel Selecionado = null;
        public bool VemDeSelecao = false;

        private void AtualizarGrid()
        {
            var lista = ResponsavelController.Instancia.GetAll();
            ovGRD_Responsavel.DataSource = lista;
            ovGRD_Responsavel.RefreshDataSource();
            ovGRD_Responsavel.Refresh();
        }

        public GridResponsavel(bool VemDeSelecao = false)
        {
            InitializeComponent();
            this.VemDeSelecao = VemDeSelecao;
            sbSelecionar.Visible = VemDeSelecao;
            AtualizarGrid();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            FormCadResponsavel Form = new FormCadResponsavel(null, cwkGestao.Modelo.Acao.Incluir);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            FormCadResponsavel Form = new FormCadResponsavel((Responsavel)ovGV_Responsavel.GetFocusedRow(), cwkGestao.Modelo.Acao.Alterar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResponsavelController.Instancia.RegisterDeleteIntoTransaction((Responsavel)ovGV_Responsavel.GetFocusedRow());
                ResponsavelController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbSelecionar_Click(object sender, EventArgs e)
        {
            Selecionado = (Responsavel)ovGV_Responsavel.GetFocusedRow();
            Close();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            FormCadResponsavel Form = new FormCadResponsavel((Responsavel)ovGV_Responsavel.GetFocusedRow(), cwkGestao.Modelo.Acao.Consultar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void ovGRD_Responsavel_DoubleClick(object sender, EventArgs e)
        {
            if (VemDeSelecao)
                sbSelecionar_Click(sender, e);
            else
                btn_Alterar_Click(sender, e);
        }

        private void GridResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}