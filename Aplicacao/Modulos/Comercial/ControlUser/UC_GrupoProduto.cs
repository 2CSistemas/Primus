using System;
using System.Drawing;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial.ControlUser
{
    public partial class UC_GrupoProduto : UserControl
    {
        public Grupo1 Grupo = null;
        public UC_GrupoProduto(Grupo1 _Grupo)
        {
            InitializeComponent();
            Grupo = _Grupo;

            TXT_GrupoProduto.Text = Grupo.Nome;
        }

        private void ovTXT_GrupoProduto_MouseHover(object sender, EventArgs e)
        {
            ColocaHover();
        }

        private void ovTXT_GrupoProduto_MouseLeave(object sender, EventArgs e)
        {
            RemoveHover();
        }

        private void ovTXT_GrupoProduto_MouseEnter(object sender, EventArgs e)
        {
            ColocaHover();
        }

        private void ColocaHover()
        {
            TXT_GrupoProduto.BackColor = Color.LightGray;
        }

        private void RemoveHover()
        {
            TXT_GrupoProduto.BackColor = Color.Silver;
        }

        private void ovTXT_GrupoProduto_Click(object sender, EventArgs e)
        {
            (ParentForm as FormFrenteCaixaDelivery).CarregarProdutosPorGrupo(Grupo);
        }
    }
}