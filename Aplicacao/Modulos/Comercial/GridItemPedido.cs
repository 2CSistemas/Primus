using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using System.Linq;

namespace Aplicacao
{
    public partial class GridItensPedido : Aplicacao.IntermediariasTela.GridPedidoItemIntermediaria
    {
        public IList<PedidoItem> itensSelecionados { get; set; }

        public GridItensPedido(IList<PedidoItem> lista)
            : base(lista, null, null, false)
        {
            Selecionando = true;
            InitializeComponent();
            RemoverBotoesPrimeiraLinha();
        }

        protected override void sbSelecionar_Click(object sender, EventArgs e)
        {
            itensSelecionados = ((IList<PedidoItem>)gcPrincipal.DataSource).Where(item => item.Selecionado).ToList();
            this.Close();
        }

        protected override void MontarColunas()
        {
            base.MontarColunas();
            var coluna = gvPrincipal.Columns["Selecionado"];
            if (coluna != null)
            {
                gvPrincipal.OptionsBehavior.Editable = true;
                coluna.OptionsColumn.AllowEdit = true;
                gcPrincipal.Refresh();
                gvPrincipal.RefreshData();
                gvPrincipal.RefreshEditor(false);

            }
        }

        protected override void sbFechar_Click(object sender, EventArgs e)
        {
            itensSelecionados = null;
            base.sbFechar_Click(sender, e);
        }
    }
}
