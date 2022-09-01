using System;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class GridFabricante : Form
    {
        public Fabricante Selecionado = null;
        public bool VemDeSelecao = false;
        public FormFabricante form = null;

        public GridFabricante(bool VemDeSelecao = false, FormFabricante form = null)
        {
            InitializeComponent();
            this.VemDeSelecao = VemDeSelecao;
            this.form = form;
            sbSelecionar.Visible = VemDeSelecao;

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            var lista = FabricanteController.Instancia.GetAll();
            ovGRD_Fabricante.DataSource = lista;
            ovGRD_Fabricante.RefreshDataSource();
            ovGRD_Fabricante.Refresh();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbSelecionar_Click(object sender, EventArgs e)
        {
            // Selecionar
            Selecionado = (Fabricante)ovGV_Fabricante.GetFocusedRow();
            //form.SelecionarFabricante(Selecionado);
            Close();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            // Consultar
            FormFabricante Form = new FormFabricante((Fabricante)ovGV_Fabricante.GetFocusedRow(), cwkGestao.Modelo.Acao.Consultar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            // Incluir
            FormFabricante Form = new FormFabricante(null, cwkGestao.Modelo.Acao.Incluir);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // Alterar
            FormFabricante Form = new FormFabricante((Fabricante)ovGV_Fabricante.GetFocusedRow(), cwkGestao.Modelo.Acao.Alterar);
            Form.ShowDialog();
            AtualizarGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // Excluir
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FabricanteController.Instancia.RegisterDeleteIntoTransaction((Fabricante)ovGV_Fabricante.GetFocusedRow());
                FabricanteController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }

        private void ovGRD_Fabricante_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (VemDeSelecao)
                sbSelecionar_Click(sender, e);
            else
                btn_Alterar_Click(sender, e);
        }

        private void GridFabricante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                this.Close();
        }
    }
}
