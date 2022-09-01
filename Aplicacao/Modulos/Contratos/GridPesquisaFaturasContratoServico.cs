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
using cwkGestao.Negocio.Contratos;
using DevExpress.XtraPrinting;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Aplicacao.Modulos.Contratos
{
    public partial class GridPesquisaFaturasContratoServico : Form
    {
        public string referencia;
        public bool aumentar30Dias = false;

        public string Ref
        {
            get { return referencia; }
            set { referencia = value; }
        }
        //
        ContratoController contratoController = ContratoController.Instancia;
        ContratoServicoController contratoServicoController = ContratoServicoController.Instancia;

        FaturadorContratoServico faturadorContratoServico;
        IList<ContratoServico> listaContratosServicoParaFaturar, listaContratoServicoSelecionados;

        PrintableComponentLink printableComponentLink1;
        public GridPesquisaFaturasContratoServico(DateTime vencimento, TipoNota tipoNotaServico, string reference, bool diaVenc, bool Aumentar30Dias, bool GerarComDataDoDia)
        {
            InitializeComponent();
            InicializarListasContratosServicos();
            aumentar30Dias = Aumentar30Dias;
            faturadorContratoServico = new FaturadorContratoServico(reference, vencimento, tipoNotaServico, diaVenc, Aumentar30Dias, GerarComDataDoDia);

            IEnumerable<IGrouping<int, ContratoServico>> grupoContrato = faturadorContratoServico.ListaContratosServico.GroupBy(s => s.Contrato.ID).ToList();

            IList<pxyContratoServico> listaContratosServico = new List<pxyContratoServico>();
            foreach (var grupo in grupoContrato)
            {
                IList<ContratoServico> lstContratoServico = grupo.Select(s => s).ToList();
                ContratoServico primeiroContratoServico = lstContratoServico.FirstOrDefault();
                Contrato contrato = primeiroContratoServico.Contrato;

                var Ref = Convert.ToDateTime(reference);
                if (Aumentar30Dias)
                    Ref = new DateTime(Ref.Year, Ref.Month, DateTime.DaysInMonth(Ref.Year, Ref.Month)).AddMonths(1);

                if (diaVenc == false)
                {
                    Ref = new DateTime(Ref.Year, Ref.Month, lstContratoServico[0].DiaVencimento);
                }

                pxyContratoServico proxy = new pxyContratoServico(grupo.Key, lstContratoServico, contrato.Pessoa.Nome, (diaVenc ? vencimento.ToShortDateString() : Ref.ToShortDateString()), lstContratoServico.Sum(s => s.Total), contrato.Observacao);
                int idcontrato = proxy.IDContrato;
                Contrato ct = ContratoController.Instancia.GetContratoPorID(idcontrato);
                if (ct != null && tipoNotaServico != null && ct.TipoNota.ID == tipoNotaServico.ID)
                {
                    listaContratosServico.Add(proxy);
                }
            }
            gcContratoServicos.DataSource = listaContratosServico;
        }
        private void AlterarSelecaoPedidos(bool? selecionado)
        {
            var lista = gcContratoServicos.DataSource;
            if (lista != null)
            {
                foreach (var itemSelecionado in (List<pxyContratoServico>)lista)
                {
                    if (selecionado.HasValue)
                    {
                        itemSelecionado.Selecionado = selecionado.Value;
                    }
                    else
                    {
                        itemSelecionado.Selecionado = !itemSelecionado.Selecionado;
                    }
                }
            }
            gcContratoServicos.RefreshDataSource();
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(false);
        }

        private void sbInverterSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(null);
        }


        private void sbImprimirFiltro_Click(object sender, EventArgs e)
        {
            printableComponentLink1 = new PrintableComponentLink(new PrintingSystem());
            printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            printableComponentLink1.Component = gcContratoServicos;
            printableComponentLink1.CreateMarginalHeaderArea += printableComponentLink1_CreateMarginalHeaderArea;
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }
        private void printableComponentLink1_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TelasUtil.CriaHeaderImpressaoFiltro(e, this.gvContratoServicos, ref printableComponentLink1, this.Text);
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }
        private void FecharTela()
        {
            this.Close();
        }
        public Boolean ValidarTela()
        {
            if (listaContratoServicoSelecionados.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("É preciso Selecionar ao menos um Contrato", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }
        private void btGerarContratos_Click(object sender, EventArgs e)
        {
            StringBuilder sbMensagemErroFatura;

            gcContratoServicos.DataSource = gcContratoServicos.DataSource == null ? new List<pxyContratoServico>() : gcContratoServicos.DataSource;
            listaContratoServicoSelecionados = ((List<pxyContratoServico>)gcContratoServicos.DataSource).Where(px => px.Selecionado).SelectMany(s => s.ContratoServico).ToList();
            if (ValidarTela())
            {
                bool sucesso = false;
                sbMensagemErroFatura = faturadorContratoServico.Faturar(ref sucesso, listaContratoServicoSelecionados);

                if (sbMensagemErroFatura.Length > 0)
                {
                    FormAviso form = new FormAviso("Processo de Geração de Faturas finalizado, algumas das faturas não puderam ser geradas", sbMensagemErroFatura.ToString());
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Processo de Geração de Faturas finalizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FecharTela();
            }
        }

        private void InicializarListasContratosServicos()
        {
            listaContratoServicoSelecionados = listaContratosServicoParaFaturar = new List<ContratoServico>();
        }
    }
}
