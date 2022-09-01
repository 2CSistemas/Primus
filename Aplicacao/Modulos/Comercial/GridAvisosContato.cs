using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Modulos.Telefonia.Impressao;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using System.IO;
using Ionic.Zip;
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridAvisosContato : Form
    {
        IList<pxyAvisos> DadosAviso = new List<pxyAvisos>();
        pxyAvisos primeiroAviso;
        public GridAvisosContato(IList<pxyAvisos> dadosAviso)
        {
            InitializeComponent();
            AtualizarInformaçõesGrid(dadosAviso);
        }

        public void AtualizarInformaçõesGrid(IList<pxyAvisos> dadosAviso)
        {
            DadosAviso = dadosAviso;
            if (DadosAviso != null && DadosAviso.Count > 0)
            {
                primeiroAviso = DadosAviso.FirstOrDefault();
                lbcAgendaPassado.Text = Convert.ToString(primeiroAviso.Passados);
                lbcAgendaOntem.Text = Convert.ToString(primeiroAviso.Ontem);
                lbcAgendaHoje.Text = Convert.ToString(primeiroAviso.Hoje);
                lbcAgendaAmanha.Text = Convert.ToString(primeiroAviso.Amanha);
                lbcAgendaFuturo.Text = Convert.ToString(primeiroAviso.Proximos);
                gcDadosUltimoAviso.DataSource = DadosAviso;
            }
        }

        public GridAvisosContato()
        {
            InitializeComponent();
        }

        private void gcDadosUltimoAviso_MouseClick(object sender, MouseEventArgs e)
        {
            CarregarFormContatoDetalhe();
        }

        private void CarregarFormContatoDetalhe()
        {
            ContatoDetalhe contatoDet = ContatoDetalheController.Instancia.LoadObjectById(((pxyAvisos)gvDadosUltimoAviso.GetRegistroSelecionado()).IDContatoDetalhe);
            FormContatoDetalhe form = new FormContatoDetalhe(contatoDet);
            form.ShowDialog();
        }
    }
}
