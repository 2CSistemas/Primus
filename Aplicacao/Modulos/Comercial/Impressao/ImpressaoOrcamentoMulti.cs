using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Relatorio.Relatorios;
using System.Data;
using System.Net.Mail;
using System.Net;
using cwkGestao.Modelo;
using System.IO;
using Aplicacao.Base;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Util;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoOrcamentoMulti : ImpressaoOrcamento
    {
        private string nomerel;
        private DateTime dataEntrega;
        private decimal desconto;
        private const int QtdRegistros = 16;
        public string Email;
        public string ObservacaoEmail;
        public DestinoImpressao DestinoImpressao;
        public bool EnvioEmailCancelado = false;
        private Aplicacao.InputBox input = new Aplicacao.InputBox();
        private string email;
        private string assuntoEmail;
        private string corpoEmail;


        private List<rptOrcamentoMulti> ListaDeOrcs = new List<rptOrcamentoMulti>();

        public ImpressaoOrcamentoMulti(cwkGestao.Modelo.Pedido objPedido) : base(objPedido) { }

        public override void Imprimir()
        {
            desconto = SetPercentualDesconto();
            dataEntrega = objPedido.DtPrazoEntrega;
            DestinoImpressao = new Aplicacao.DestinoImpressaoPedido().ShowDialog();
            ReparteQtdProdutos(objPedido.ID);
        }

        public override void Imprimir(bool a)
        {
            desconto = SetPercentualDesconto();
            dataEntrega = objPedido.DtPrazoEntrega;

            if (a)
                DestinoImpressao = DestinoImpressao.Impressora;

            ReparteQtdProdutos(objPedido.ID);
        }

        private void ReparteQtdProdutos(Int32 ID)
        {
            var Dados = new Relatorio.dsImpressaoOrdemServicoTableAdapters.RelOrcamentoTableAdapter().GetData(objPedido.ID);

            object TotalPedido = 0;
            object CodigoPedido = 0;

            Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable DadosParciais = new Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable();

            DataTableReader dr = Dados.CreateDataReader();
            #region Variaveis de controle de posição
            int pValorUnitario = dr.GetOrdinal("ValorUnitario");
            int pValorTotal = dr.GetOrdinal("ValorTotal");
            int pFantasia = dr.GetOrdinal("Fantasia");
            int pTotalPedido = dr.GetOrdinal("TotalPedido");
            int pCodigoPedido = dr.GetOrdinal("CodigoPedido");
            int pFrete = dr.GetOrdinal("Frete");
            int pValidadePedido = dr.GetOrdinal("ValidadePedido");
            int pTotalST = dr.GetOrdinal("TotalST");
            int qtdCampos = dr.FieldCount;
            #endregion
            while (dr.Read())
            {
                object[] a = new object[qtdCampos];

                dr.GetValues(a);

                if (objPedido.Pessoa.TipoPessoa == "Física")
                    a[pFantasia] = objPedido.Pessoa.Apelido + " (" + objPedido.Pessoa.Codigo + ")";

                DadosParciais.Rows.Add(a);

                if ((DadosParciais.Count % QtdRegistros) == 0)
                {
                    GeraRelatorio(DadosParciais, 0);
                    DadosParciais = new Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable();
                }
                TotalPedido = a[pTotalPedido];
                CodigoPedido = a[pCodigoPedido];
            }

            if (DadosParciais != null && DadosParciais.Count != 0)
            {
                while (DadosParciais.Count != QtdRegistros)
                {
                    object[] a = new object[qtdCampos];
                    a[pValorUnitario] = 0;
                    a[pValorTotal] = 0;
                    a[pFrete] = 0;
                    a[pValidadePedido] = 0;
                    a[pTotalST] = 0;
                    a[pTotalPedido] = TotalPedido;
                    a[pCodigoPedido] = CodigoPedido;
                    DadosParciais.Rows.Add(a);
                }
                GeraRelatorio(DadosParciais, 0);
            }

            DecideCaminhoImpressao();
        }

        private DevExpress.XtraReports.UI.XtraReport ImprimeRelatorio()
        {
            var Formas = objPedido?.Parcelas?.Select(o => o.TipoDocumento.FormaPagamento.Nome);

            rptOrcamentoMulti PrimeiroReport = new rptOrcamentoMulti(string.Join(",", Formas));

            PrimeiroReport.CreateDocument();

            foreach (var item in ListaDeOrcs)
            {
                item.CreateDocument();
                PrimeiroReport.Pages.Add(item.Pages[item.Pages.Count - 1]);
            }

            PrimeiroReport.PrintingSystem.ContinuousPageNumbering = true;

            return PrimeiroReport;
        }

        private void GeraRelatorio(Relatorio.dsImpressaoOrdemServico.RelOrcamentoDataTable Dados, int a)
        {
            var dataSet = new DataSet { DataSetName = "dsImpressaoOrdemServico" };
            dataSet.Tables.Add(Dados);

            var Formas = objPedido?.Parcelas?.Select(o => o.TipoDocumento.FormaPagamento.Nome);
            rptOrcamentoMulti form = new rptOrcamentoMulti(string.Join(",", Formas)) { DataSource = dataSet };
            ListaDeOrcs.Add(form);
        }

        private void DecideCaminhoImpressao()
        {
            try
            {
                switch (DestinoImpressao)
                {
                    case DestinoImpressao.Vídeo:
                        ImprimeRelatorio().ShowPreview();
                        objPedido.BImpressa = true;
                        cwkGestao.Negocio.PedidoController.Instancia.Salvar(objPedido, cwkGestao.Modelo.Acao.Alterar);
                        break;
                    case DestinoImpressao.Email:
                        FormEnviaEmailPedido form = new FormEnviaEmailPedido(objPedido);
                        form.ShowDialog();
                        break;
                    case DestinoImpressao.Impressora:
                        ImprimeRelatorio().PrintDialog();
                        objPedido.BImpressa = true;
                        cwkGestao.Negocio.PedidoController.Instancia.Salvar(objPedido, cwkGestao.Modelo.Acao.Alterar);
                        break;
                }
            }
            catch (Exception ex)
            {
                if (!EnvioEmailCancelado)
                    new FormErro(ex).ShowDialog();
            }
        }

    }
}
