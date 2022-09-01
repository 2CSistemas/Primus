using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.IntermediariasTela;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Correios;

namespace Aplicacao.Modulos.Estoque
{
    public partial class GridRastreamentoCorreio : Aplicacao.IntermediariasTela.Grid_RastreamentoCorreioIntermediaria
    {
        public GridRastreamentoCorreio(IList<RastreamentoCorreio> lista, RastreamentoCorreio Selecionado, Func<IList<RastreamentoCorreio>> atualizador, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, Selecionado, atualizador, adicionarFiltro, formManut, parametros)
        {            
            InitializeComponent();
            ConfiguraBotaoSolicitaEtiquetas();
        }

        private void ConfiguraBotaoSolicitaEtiquetas()
        {
            sbFuncao10.Text = "Solicitar Etiq. Correios";
            sbFuncao10.Visible = true;
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            sbFuncao10.Size = new Size(150, 23);
            sbFuncao10.Enabled = true;
            sbFuncao10.Location = new Point(12,392);
            sbFuncao10.Refresh();
        }

        public static GridRastreamentoCorreio Get()
        {
            Func<IList<RastreamentoCorreio>> atualizador = () => RastreamentoCorreioController.Instancia.GetAll();
            var grid = new GridRastreamentoCorreio(atualizador(), null, atualizador, false, typeof(FormRastreamentoCorreio));
            return grid;
        }

        protected override void Incluir()
        {
            base.Incluir();
            AtualizarGrid();
        }

        protected override void MontarColunas()
        { 
            base.MontarColunas();
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            FormSolicitaEtiquetasCorreios form = new FormSolicitaEtiquetasCorreios();
            form.ShowDialog();

            AtualizarGrid();
        }
    }
}
