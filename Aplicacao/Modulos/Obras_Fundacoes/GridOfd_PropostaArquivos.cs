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
    public partial class GridOfd_PropostaArquivos : Aplicacao.IntermediariasTela.GridOfd_PropostaArquivosIntermediaria
    {
        private Ofd_Proposta proposta;

        public GridOfd_PropostaArquivos(Ofd_Proposta proposta, IFormManut<Ofd_PropostaArquivos> formManut)
            : base(proposta.Arquivos, formManut, false)
        {
            InitializeComponent();
            this.proposta = proposta;
            this.Text += String.Format(" [{0} - {1}]", proposta.NomeObra, proposta.Status.ToString());
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            var selecionado = GetRegistroSelecionado();
            if (selecionado != null)
                Ofd_PropostaArquivosController.Instancia.AbrirArquivo(selecionado.CaminhoArquivo);
        }

        protected override Ofd_PropostaArquivos InstanciarNovoSelecionado()
        {
            var arquivo = new Ofd_PropostaArquivos { Proposta = proposta };
            if (proposta.Arquivos.Count > 0)
                arquivo.Sequencia = proposta.Arquivos.Max(d => d.Sequencia) + 1;
            else
                arquivo.Sequencia = 1;
            return arquivo;
        }
    }
}
