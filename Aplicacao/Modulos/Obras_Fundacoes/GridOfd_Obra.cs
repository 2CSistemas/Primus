using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class GridOfd_Obra : Aplicacao.IntermediariasTela.GridOfd_ObraIntermediaria
    {
        public GridOfd_Obra(IList<Ofd_Obra> lista, IFormManut<Ofd_Obra> formManut, bool adicionarFiltro)
            : this(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_Obra(IList<Ofd_Obra> lista, IFormManut<Ofd_Obra> formManut, Ofd_Obra selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {
            InitializeComponent();
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            var obra = GetRegistroSelecionado();
            if (obra != null)
            {
                var gridDiarios = new GridOfd_ObraDiario(Ofd_ObraController.Instancia.LoadObjectById(obra.ID), new FormOfd_ObraDiario());
                gridDiarios.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        
        private void sbFuncao11_Click(object sender, EventArgs e)
        {
            var obra = GetRegistroSelecionado();
            if (obra != null)
            {
                var grid = new GridOfd_Proposta(Ofd_PropostaController.Instancia.GetAllByObra(obra), false, typeof(FormOfd_Proposta));
                grid.DesabilitarBotoes(GridGenerica<Ofd_Proposta>.Botao.Incluir | GridGenerica<Ofd_Proposta>.Botao.Excluir);
                grid.sbFuncao11.Visible = false;
                grid.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void sbFuncao12_Click(object sender, EventArgs e)
        {
            var obra = GetRegistroSelecionado();
            if (obra != null)
            {
                var grid = new GridOfd_ObraArquivos(Ofd_ObraController.Instancia.LoadObjectById(obra.ID), new FormOfd_ObraArquivos());
                grid.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }

        private void sbFuncao22_Click(object sender, EventArgs e)
        {
            var obra = GetRegistroSelecionado();
            var obraAux = Ofd_ObraController.Instancia.LoadObjectById(obra.ID);
            if (obraAux != null)
            {

                var grid = new GridOfd_PropostaMedicao(Ofd_PropostaMedicaoController.Instancia.GetByObra(obraAux), new FormOfd_PropostaMedicao(obra));
                grid.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.");
        }
    }
}
