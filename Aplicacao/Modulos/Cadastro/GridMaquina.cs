using System;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class GridMaquina : Form
    {
        public Maquina Selecionado = null;
        public bool VemDeSelecao = false;
        public FormPedidoMaquina form = null;
        public FormOrdemServicoMaquina formOS = null;

        private void AtualizarGrid()
        {
            var lista = MaquinaController.Instancia.GetAll();

            foreach (Maquina Maq in lista)
                if (Maq.IDFabricante.HasValue)
                    Maq.Fabricante = FabricanteController.Instancia.LoadObjectById(Maq.IDFabricante.Value).Descricao;

            ovGRD_Maquina.DataSource = lista;
            ovGRD_Maquina.RefreshDataSource();
            ovGRD_Maquina.Refresh();
        }

        public GridMaquina(bool VemDeSelecao = false, FormPedidoMaquina form = null, FormOrdemServicoMaquina formos = null)
        {
            InitializeComponent();
            this.VemDeSelecao = VemDeSelecao;
            this.form = form;
            this.formOS = formos;
            sbSelecionar.Visible = VemDeSelecao;

            AtualizarGrid();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbSelecionar_Click(object sender, EventArgs e)
        {
            // Selecionar
            Selecionado = (Maquina)ovGV_Maquina.GetFocusedRow();

            form?.SelecionarMaquina(Selecionado);
            formOS?.SelecionarMaquina(Selecionado);

            Close();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            // Consultar
            FormMaquina Form = new FormMaquina((Maquina)ovGV_Maquina.GetFocusedRow(), cwkGestao.Modelo.Acao.Consultar);
            Form.ShowDialog(this);
            AtualizarGrid();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            // Incluir
            FormMaquina Form = new FormMaquina(null, cwkGestao.Modelo.Acao.Incluir);
            Form.ShowDialog(this);
            AtualizarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // Alterar
            FormMaquina Form = new FormMaquina((Maquina)ovGV_Maquina.GetFocusedRow(), cwkGestao.Modelo.Acao.Alterar);
            Form.ShowDialog(this);
            AtualizarGrid();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // Excluir
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MaquinaController.Instancia.RegisterDeleteIntoTransaction((Maquina)ovGV_Maquina.GetFocusedRow());
                MaquinaController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }

        private void ovGRD_Maquina_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (VemDeSelecao)
                sbSelecionar_Click(sender, e);
            else
                btn_Alterar_Click(sender, e);
        }
    }
}
