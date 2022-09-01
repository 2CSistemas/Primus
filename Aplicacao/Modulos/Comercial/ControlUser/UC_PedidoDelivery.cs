using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Comercial.ControlUser
{
    public partial class UC_PedidoDelivery : UserControl
    {
        private string NomeImpressora;
        public Pedido Ped = null;
        public UC_PedidoDelivery(Pedido _Ped, Color backColor, string NomeImpressora)
        {
            InitializeComponent();
            Ped = _Ped;
            BackColor = backColor;
            this.NomeImpressora = NomeImpressora;
            Inicializar();
        }

        public void Inicializar(bool Entregador = true)
        {
            TXT_VENDEDOR.Text = Ped.Vendedor.Nome;
            //TXT_NOTAFISCAL.Text = Ped.Numero.ToString();
            TXT_CODIGO.Text = $"CÓDIGO: {Ped.Codigo} - CLIENTE: " + Ped.Pessoa.Nome;

            TXT_DATAHORA.Text = Ped.Dt.ToString();
            TXT_VALOR.Text = Ped.TotalPedido.ToString("c2");

            var NotaAutorizada = NotaController.Instancia.GetNotaAutorizadaPorPedido(Ped.Codigo).FirstOrDefault();
            TXT_NOTAFISCAL.Text = NotaAutorizada != null ? NotaAutorizada.Numero.ToString() : "";
            if (NotaAutorizada != null)
            {
                sbNFCe.Enabled = true;
                sbNFCe.BackColor = Color.Green;
                sbNFCe.Appearance.BackColor = Color.Green;
                sbNFCe.Appearance.BackColor2 = Color.Green;
            }

            if (Entregador)
                TXT_ENTREGADOR.Text = Ped.Entregador;

            TXT_SAIUENTREGA.Text = Ped.DataSaidaEntrega != null ? Ped.DataSaidaEntrega.ToString() : "";
            TXT_CHEGADAENTREGA.Text = Ped.DataChegadaEntrega != null ? Ped.DataChegadaEntrega.ToString() : "";
            TXT_TEMPORIZADOR.Text = Ped.DataChegadaEntrega != null ? Ped.DataChegadaEntrega.ToString() : "CALCULAR";

            PreencheStatus(Ped.StatusDelivery);
            GerenciarBotoes();
        }

        private void GerenciarBotoes()
        {
            if (Ped.StatusDelivery == StatusPedidoDelivery.Finalizado || Ped.StatusDelivery == StatusPedidoDelivery.Cancelado)
            {
                sbFinalizar.Enabled = false;
                sbFinalizar.BackColor = Color.Gray;
                sbFinalizar.Appearance.BackColor = Color.Gray;
                sbFinalizar.Appearance.BackColor2 = Color.Gray;

                sbCancelar.Enabled = false;
                sbCancelar.BackColor = Color.Gray;
                sbCancelar.Appearance.BackColor = Color.Gray;
                sbCancelar.Appearance.BackColor2 = Color.Gray;

                sbAtualizarStatus.Enabled = false;
                sbAtualizarStatus.BackColor = Color.Gray;
                sbAtualizarStatus.Appearance.BackColor = Color.Gray;
                sbAtualizarStatus.Appearance.BackColor2 = Color.Gray;

                if (Ped.StatusDelivery == StatusPedidoDelivery.Cancelado)
                {
                    sbNFCe.Enabled = false;
                    sbNFCe.BackColor = Color.Gray;
                    sbNFCe.Appearance.BackColor = Color.Gray;
                    sbNFCe.Appearance.BackColor2 = Color.Gray;
                }
            }
        }

        private void PreencheStatus(StatusPedidoDelivery Status)
        {
            switch (Status)
            {
                case StatusPedidoDelivery.Aberto:
                    TXT_STATUS.Text = "EM ABERTO";
                    break;
                case StatusPedidoDelivery.Pendente:
                    TXT_STATUS.Text = "PENDENTE";
                    break;
                case StatusPedidoDelivery.EmPreparacao:
                    TXT_STATUS.Text = "EM PREPARAÇÃO";
                    break;
                case StatusPedidoDelivery.EmEntrega:
                    TXT_STATUS.Text = "EM ENTREGA";
                    break;
                case StatusPedidoDelivery.Finalizado:
                    TXT_STATUS.Text = "FINALIZADO";
                    break;
                case StatusPedidoDelivery.Cancelado:
                    TXT_STATUS.Text = "CANCELADO";
                    break;
                default:
                    TXT_STATUS.Text = "EM ABERTO";
                    break;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (Ped.DataChegadaEntrega.HasValue)
            {
                int QuantidadeDias = (Ped.DataChegadaEntrega.Value - Ped.DataSaidaEntrega.Value).Days;
                string DataFormatada = (Ped.DataChegadaEntrega.Value - Ped.DataSaidaEntrega.Value).ToString(@"hh\:mm\:ss");
                if (QuantidadeDias > 0)
                    DataFormatada = $"{QuantidadeDias}.{(Ped.DataChegadaEntrega.Value - Ped.DataSaidaEntrega.Value).ToString(@"hh\:mm\:ss")}";

                TXT_TEMPORIZADOR.Text = Ped.DataSaidaEntrega.HasValue ? DataFormatada : "00:00:00";
            }
            else
            {
                int QuantidadeDias = (System.DateTime.Now - Ped.DataSaidaEntrega.Value).Days;
                string DataFormatada = (System.DateTime.Now - Ped.DataSaidaEntrega.Value).ToString(@"hh\:mm\:ss");
                if (QuantidadeDias > 0)
                    DataFormatada = $"{QuantidadeDias}.{(System.DateTime.Now - Ped.DataSaidaEntrega.Value).ToString(@"hh\:mm\:ss")}";

                TXT_TEMPORIZADOR.Text = Ped.DataSaidaEntrega.HasValue ? DataFormatada : "00:00:00";
            }
        }

        private void simpleButton4_Click(object sender, System.EventArgs e)
        {
            // Finalizar Pedido
            if ((ParentForm as FormFrenteCaixaDeliveryMonitor).FinalizarPedido(Ped))
            {
                // Carergar o pedido e Atualizar em Tela 
                Ped = PedidoController.Instancia.GetPedidosDelivery().Where(o => o.ID == Ped.ID).First();
                Inicializar(false);
            }
        }

        private void simpleButton3_Click(object sender, System.EventArgs e)
        {
            // Imprimir Pedido
            ImprimirPedido();
        }

        public void ImprimirPedido()
        {
            XRReportPedidoDelivery RelatorioFluxoCaixa = new XRReportPedidoDelivery(Ped, PedidoController.Instancia.GetFrenteCaixaNotaPorPedido(Ped.ID)?.Troco ?? 0);
            ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);

            var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
            if (1 == Config?.VisualizarNFCe)
                tool.ShowPreviewDialog();
            else
                tool.Print(NomeImpressora);
        }

        private void sbPesquisar_Click(object sender, System.EventArgs e)
        {
            // Cancelar Pedido
            var CancelouPedido = CancelaPedido(Ped);
            if (CancelouPedido)
            {
                (ParentForm as FormFrenteCaixaDeliveryMonitor).CancelarPedido(Ped);

                // Carergar o pedido e Atualizar em Tela 
                Ped = PedidoController.Instancia.GetPedidosDelivery().Where(o => o.ID == Ped.ID).First();
                Inicializar(false);
            }
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            // NFCe
            if ((ParentForm as FormFrenteCaixaDeliveryMonitor).EmitirNFCe(Ped))
            {
                // Carergar o pedido e Atualizar em Tela 
                Ped = PedidoController.Instancia.GetPedidosDelivery().Where(o => o.ID == Ped.ID).First();
                Inicializar(false);
            }
        }

        private void simpleButton2_Click(object sender, System.EventArgs e)
        {
            Ped = (ParentForm as FormFrenteCaixaDeliveryMonitor).AtualizarStatus(Ped);

            /* FORMATO FEIO DE FAZER */

            // Atualizar Status
            //if (Ped.StatusDelivery == StatusPedidoDelivery.Cancelado)
            //{
            //    var CancelouPedido = CancelaPedido(Ped);
            //    if (CancelouPedido)
            //    {
            //        PedidoController.Instancia.SalvarDelivery(Ped, Acao.Alterar);
            //        Inicializar(false);
            //    }
            //}
            //else if (Ped.StatusDelivery == StatusPedidoDelivery.Finalizado)
            //{
            //    if ((ParentForm as FormFrenteCaixaDeliveryMonitor).FinalizarPedido(Ped))
            //    {
            //        // Carergar o pedido e Atualizar em Tela 
            //        Ped = PedidoController.Instancia.GetPedidosDelivery().Where(o => o.ID == Ped.ID).First();
            //        Inicializar(false);
            //    }
            //}
            //else
            //{
            //    PedidoController.Instancia.SalvarDelivery(Ped, Acao.Alterar);
            //    Inicializar(false);
            //}

            // FORMATO CERTO DE FAZER
            switch (Ped.StatusDelivery) // Pergunta: Qual o Status do Pedido Delivery?
            {
                case StatusPedidoDelivery.Cancelado: // Resposta A: Cancelado
                    var CancelouPedido = CancelaPedido(Ped);
                    if (CancelouPedido)
                    {
                        PedidoController.Instancia.SalvarDelivery(Ped, Acao.Alterar);
                        Inicializar(false);
                    }
                    break;
                case StatusPedidoDelivery.Finalizado: // Resposta B: Finalizado
                    if ((ParentForm as FormFrenteCaixaDeliveryMonitor).FinalizarPedido(Ped))
                    {
                        // Carergar o pedido e Atualizar em Tela 
                        Ped = PedidoController.Instancia.GetPedidosDelivery().Where(o => o.ID == Ped.ID).First();
                        Inicializar(false);
                    }
                    break;
                default: // Nenhuma das Anteriores
                    PedidoController.Instancia.SalvarDelivery(Ped, Acao.Alterar);
                    Inicializar(false);
                    break;
            }
        }

        private void simpleButton1_Click_1(object sender, System.EventArgs e)
        {
            // Consultar Pedido
            new FormConsultaPedidoDelivery(Ped, false).ShowDialog(this);
            Ped = PedidoController.Instancia.LoadObjectById(Ped.ID);

            Inicializar();
        }

        private bool CancelaPedido(Pedido p)
        {
            try
            {
                if (SHLUtil.UsarSHL())
                {
                    string retorno = SHLUtil.EnviarCancelamentoPedidoSHL(p);
                    if (retorno == "Sucesso")
                    {
                        return CancelarPedido(p);
                    }
                    else
                    {
                        if (p.CodShl != 0)
                        {
                            MessageBox.Show("Este pedido já foi cancelado no SHL e portanto não é possivel mudar seu status", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            return CancelarPedido(p);
                        }
                    }
                }
                else
                {
                    return CancelarPedido(p);
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool CancelarPedido(Pedido p)
        {
            if (p.Status != StatusOrcamento.Cancelado)
            {
                if (p.Status != StatusOrcamento.Fechado
                    && p.Status != StatusOrcamento.Faturado)
                {
                    string motivo;
                    string usuarioAlteracao = cwkControleUsuario.Facade.getUsuarioLogado.Nome;
                    DateTime dataAlteracao = DateTime.Now;

                    Aplicacao.InputBox ib = new InputBox();
                    ib.Show("Motivo do Cancelamento", "Informe o motivo do cancelamento:", out motivo);

                    if (ib.confirmado == true)
                    {
                        p.MotivoCancelamento = motivo;
                        p.UsuarioCancelamento = usuarioAlteracao;
                        p.DtCancelamento = dataAlteracao;
                        p.Status = StatusOrcamento.Cancelado;

                        PedidoController.Instancia.Salvar(p, Acao.Alterar);
                    }

                    return ib.confirmado;
                }
                else
                    MessageBox.Show("Não é possível cancelar este orçamento !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja mudar o status do orçamento", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (resultado == DialogResult.Yes)
                {
                    if (p.TipoPedido.Status == 0)
                        p.Status = (StatusOrcamento)1;
                    else
                        p.Status = (StatusOrcamento)p.TipoPedido.Status;

                    PedidoController.Instancia.Salvar(p, Acao.Alterar);
                }
            }

            var X = DocumentoController.Instancia.GetAll().Where(o => o.NumeroPedido == p.Numero).ToList();
            if (X != null)
                foreach (var item in X)
                    DocumentoController.Instancia.CancelarDocumentos(X);
            DocumentoController.Instancia.CommitUnitOfWorkTransaction();

            return true;
        }
    }
}
