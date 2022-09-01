using Aplicacao.Relatorios;
using cwkGestao.Modelo;
using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaDelievryMonitorStatus : Form
    {
        public cwkGestao.Modelo.Pedido Pedido = null;

        public FormFrenteCaixaDelievryMonitorStatus(cwkGestao.Modelo.Pedido Ped)
        {
            InitializeComponent();
            Pedido = Ped;

            Inicializar();
        }

        private void Inicializar()
        {
            switch (Pedido.StatusDelivery)
            {
                case StatusPedidoDelivery.Aberto:
                    CKB_ABERTO.Checked = true;
                    break;
                case StatusPedidoDelivery.Cancelado:
                    CKB_CANCELADO.Checked = true;
                    break;
                case StatusPedidoDelivery.EmEntrega:
                    CKB_ENTREGA.Checked = true;
                    break;
                case StatusPedidoDelivery.Finalizado:
                    CKB_FINALIZADO.Checked = true;
                    break;
                case StatusPedidoDelivery.Pendente:
                    CKB_PENDENTE.Checked = true;
                    break;
                case StatusPedidoDelivery.EmPreparacao:
                    CKB_PREPARACAO.Checked = true;
                    break;
            }
        }

        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (CKB_ABERTO.Checked)
                Pedido.StatusDelivery = StatusPedidoDelivery.Aberto;

            if (CKB_CANCELADO.Checked)
            {
                if (Pedido.DataSaidaEntrega == null)
                    Pedido.DataSaidaEntrega = DateTime.Now;

                Pedido.DataChegadaEntrega = DateTime.Now;

                Pedido.StatusDelivery = StatusPedidoDelivery.Cancelado;
            }

            if (CKB_ENTREGA.Checked)
                Pedido.StatusDelivery = StatusPedidoDelivery.EmEntrega;

            if (CKB_FINALIZADO.Checked)
            {
                if (Pedido.DataSaidaEntrega == null)
                    Pedido.DataSaidaEntrega = DateTime.Now;

                Pedido.DataChegadaEntrega = DateTime.Now;
                Pedido.StatusDelivery = StatusPedidoDelivery.Finalizado;
            }

            if (CKB_PENDENTE.Checked)
                Pedido.StatusDelivery = StatusPedidoDelivery.Pendente;

            if (CKB_PREPARACAO.Checked)
                Pedido.StatusDelivery = StatusPedidoDelivery.EmPreparacao;

            Close();
        }
    }
}