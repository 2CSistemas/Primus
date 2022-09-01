using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class GridOfd_ObraArquivos : Aplicacao.IntermediariasTela.GridOfd_ObraArquivosIntermediaria
    {
        private Ofd_Obra obra;

        public GridOfd_ObraArquivos(Ofd_Obra obra, IFormManut<Ofd_ObraArquivos> formManut)
            : base(obra.Arquivos, formManut, false)
        {
            InitializeComponent();
            this.obra = obra;
            this.Text += String.Format(" [{0} - {1}]", obra.Descricao, obra.Status.ToString());
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            var selecionado = GetRegistroSelecionado();
            if (selecionado != null)
                Ofd_PropostaArquivosController.Instancia.AbrirArquivo(selecionado.CaminhoArquivo);
        }

        protected override Ofd_ObraArquivos InstanciarNovoSelecionado()
        {
            var arquivo = new Ofd_ObraArquivos { Obra = obra };
            if (obra.Arquivos.Count > 0)
                arquivo.Sequencia = obra.Arquivos.Max(d => d.Sequencia) + 1;
            else
                arquivo.Sequencia = 1;
            return arquivo;
        }
    }
}
