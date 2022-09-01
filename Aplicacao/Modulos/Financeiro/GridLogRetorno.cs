using System;
using cwkGestao.Negocio;
using Aplicacao.IntermediariasTela;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class GridLogRetorno : GridLogRetornoIntermediaria
    {
        public GridLogRetorno() : base(LogRetornoController.Instancia.GetAll(), null, false)
        {
            InitializeComponent();
        }

        protected override void GridGenerica_Shown(object sender, EventArgs e)
        {
            base.GridGenerica_Shown(sender, e);
        }

        protected override void Consultar()
        {
            var registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado == null)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var form = new GridLogRetornoDetalhe(registroSelecionado);
                form.Show();
            }
        }
    }
}


