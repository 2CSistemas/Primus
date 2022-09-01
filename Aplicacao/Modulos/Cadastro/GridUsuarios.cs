using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class GridUsuarios : Aplicacao.IntermediariasTela.GridUsuarioIntermediaria
    {
        public GridUsuarios(IList<Cw_usuario> lista)
            : base(lista, null, null, false)
        {
            Selecionando = true;
            InitializeComponent();
            RemoverBotoesPrimeiraLinha();
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
    }
}
