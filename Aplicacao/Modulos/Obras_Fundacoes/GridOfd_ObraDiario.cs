using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class GridOfd_ObraDiario : Aplicacao.IntermediariasTela.GridOfd_ObraDiarioIntermediaria
    {
        private Ofd_Obra obra;

        public GridOfd_ObraDiario(Ofd_Obra obra, IFormManut<Ofd_ObraDiario> formManut)
            : base(obra.Diarios.ToList(), formManut, false)
        {
            InitializeComponent();
            this.obra = obra;
            this.Text += String.Format(" [{0} - {1}]", obra.Descricao, obra.Status.ToString());
        }

        protected override Ofd_ObraDiario InstanciarNovoSelecionado()
        {
            var diario = new Ofd_ObraDiario { Obra = obra };
            if (obra.Diarios.Count > 0)
                diario.Sequencia = obra.Diarios.Max(d => d.Sequencia) + 1;
            else
                diario.Sequencia = 1;
            return diario;
        }
    }
}
