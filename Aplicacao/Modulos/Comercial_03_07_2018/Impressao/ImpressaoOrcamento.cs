using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System.Net.Mail;
using System.Net;
using cwkGestao.Modelo.Exceptions;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public abstract class ImpressaoOrcamento
    {
        protected Impressora objImpressora;
        protected Pedido objPedido;

        protected ImpressaoOrcamento(Pedido pedido)
        {
            this.objPedido = pedido;
            this.objImpressora = objPedido.TipoPedido.Impressora;
        }

        public static ImpressaoOrcamento GetImpressaoOrcamento(Pedido pedido)
        {
            pedido = cwkGestao.Negocio.PedidoController.Instancia.LoadObjectById(pedido.ID);

            if (pedido.TipoPedido.Impressora != null)
                switch (pedido.TipoPedido.Impressora.Tipo)
                {
                    case true: //Matricial
                        return new ImpressaoOrcamentoMatricial(pedido);
                    case false: //Jato de Tinta
                        return GetImpressaoGrafica(pedido);
                }
            else
                throw new PrinterNotFoundException("Impressora não configurada no Tipo de Orçamento do Pedido.");
            return null;
        }

        private static ImpressaoOrcamento GetImpressaoGrafica(Pedido pedido)
        {
            cwkGestao.Modelo.Configuracao config = ConfiguracaoController.Instancia.GetConfiguracao();
            
            if (pedido.TipoPedido.Ent_Sai == 2)
            {
                switch (config.ModeloImpressaoGrafica)
                {
                    case ModeloImpressaoGraficaType.Modelo0:
                        return new ImpressaoOrcamentoJatoTinta(pedido);
                    case ModeloImpressaoGraficaType.Modelo1:
                        return new ImpressaoOrcamentoMulti(pedido);
                    case ModeloImpressaoGraficaType.Modelo2:
                        return new ImpressaoOrcamentoMeiaFolha(pedido);
                    case ModeloImpressaoGraficaType.Romaneio:
                        return new ImpressaoRomaneioMeiaFolha(pedido);
                    case ModeloImpressaoGraficaType.Modelo3:
                        return new ImpressaoOrcamentoModelo3(pedido);
                    case ModeloImpressaoGraficaType.Modelo4:
                        return new ImpressaoOrcamentoModelo4(pedido);
                    case ModeloImpressaoGraficaType.Iguatu:
                        return new ImpressaoOrcamentoIguatu(pedido);
                    case ModeloImpressaoGraficaType.Modelo5:
                        return new ImpressaoOrcamentoModelo5(pedido);
                    case ModeloImpressaoGraficaType.Modelo6:
                        return new ImpressaoOrcamentoModelo6(pedido);
                    case ModeloImpressaoGraficaType.DiMaggio:
                        return new ImpressaoOrcamentoDiMaggio(pedido);
                    case ModeloImpressaoGraficaType.Modelo7:
                        return new ImpressaoOrcamentoModelo7(pedido);
                }
            }
            else
            {
                switch (config.ModeloImpressaoPedidoCompra)
                {
                    case ModeloImpressaoPedidoCompraType.Modelo0:
                        return new ImpressaoOrcamentoJatoTinta(pedido);
                    case ModeloImpressaoPedidoCompraType.Modelo1:
                        return new ImpressaoPedidoCompra02(pedido);
                }
            }
            
            return null;
        }

        public abstract void Imprimir();

        public abstract void Imprimir(bool a);

        public decimal SetPercentualDesconto()
        {
            decimal desconto = 0M;
            decimal dividendo = objPedido.Items.Sum(s => (s.ValorCalculado * s.Quantidade)) + objPedido.ItemsServicos.Sum(s => (s.Valor * s.Quantidade));
            desconto = 100 - (((decimal)objPedido.TotalPedido / dividendo) * 100);
            return System.Math.Round(desconto, 2);
        }
    }
}
