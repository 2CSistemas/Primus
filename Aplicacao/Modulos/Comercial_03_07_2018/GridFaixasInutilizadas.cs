using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Aplicacao.IntermediariasTela;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridFaixasInutilizadas : Base.ManutBase
    {
        private int idFilial;

        public GridFaixasInutilizadas(int idFilial)
        {
            InitializeComponent();

            this.idFilial = idFilial;

            sbGravar.Visible = false;
            sbGravar.Enabled = false;

            gcFaixasInutilizadas.DataSource = NotaInutilizadaController.Instancia.GetAllByFilial(idFilial);
        }

        private void sbInutilizar_Click(object sender, EventArgs e)
        {
            Filial filial = FilialController.Instancia.LoadObjectById(idFilial);

            FormNotaInutilizada form = new FormNotaInutilizada(filial);
            form.ShowDialog();

            gcFaixasInutilizadas.DataSource = NotaInutilizadaController.Instancia.GetAllByFilial(idFilial);

            gcFaixasInutilizadas.Refresh();
            gcFaixasInutilizadas.RefreshDataSource();
            gvFaixasInutilizadas.RefreshData();
        }
    }
}