using Aplicacao.Modulos.Comercial.ControlUser;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

using DBUtils.Classes;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaDeliveryMonitor : Form
    {
        private IList<Pessoa> _Entregadores { get; set; }
        private IList<Pessoa> Entregadores
        {
            get
            {
                if (_Entregadores == null)
                    _Entregadores = PessoaController.Instancia.GetAllEntregadores();

                return _Entregadores;
            }
        }

        private string NomeImpressora
        {
            get
            {
                IniFile ArquivoIni = new IniFile(CaminhoIni);
                return ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", ConfiguracaoController.Instancia.GetConfiguracao().NomeImpressora);
            }
        }

        private string CaminhoIni
        {
            get
            {
                return Debugger.IsAttached ?
                    $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini" :
                    $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";
            }
        }

        public FormFrenteCaixaDeliveryMonitor()
        {
            InitializeComponent();
            CMB_TipoFiltro.SelectedIndex = 0;
            SetarFiltros();
            Pesquisar();
        }

        private void SetarFiltros()
        {
            var objCfg = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();

            CKB_ABERTO.Checked = objCfg.BPedidoAberto == 1;
            CKB_CANCELADO.Checked = objCfg.BPedidoCancelado == 1;
            CKB_ENTREGA.Checked = objCfg.BPedidoEmEntrega == 1;
            CKB_PENDENTE.Checked = objCfg.BPedidoPendente == 1;
            CKB_FINALIZADO.Checked = objCfg.BPedidoFinalizado == 1;
            CKB_PREPARACAO.Checked = objCfg.BPedidoEmPreparacao == 1;
        }

        private List<StatusPedidoDelivery> GetStatusSelecionado()
        {
            List<StatusPedidoDelivery> Selecionados = new List<StatusPedidoDelivery>();

            if (CKB_ABERTO.Checked)
                Selecionados.Add(StatusPedidoDelivery.Aberto);

            if (CKB_CANCELADO.Checked)
                Selecionados.Add(StatusPedidoDelivery.Cancelado);

            if (CKB_ENTREGA.Checked)
                Selecionados.Add(StatusPedidoDelivery.EmEntrega);

            if (CKB_FINALIZADO.Checked)
                Selecionados.Add(StatusPedidoDelivery.Finalizado);

            if (CKB_PENDENTE.Checked)
                Selecionados.Add(StatusPedidoDelivery.Pendente);

            if (CKB_PREPARACAO.Checked)
                Selecionados.Add(StatusPedidoDelivery.EmPreparacao);

            return Selecionados;
        }

        private void sbPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            string Selecionado = CMB_TipoFiltro.SelectedItem?.ToString();

            LayoutContorl.Controls.Clear();

            var Pedidos = PedidoController.Instancia.GetPedidosDelivery().OrderByDescending(o => o.Dt).ToList();
            if (Pedidos != null)
            {
                Pedidos = Pedidos.Where(o => (o.Dt.Date >= TXT_INICIO.Value.Date && o.Dt.Date <= TXT_FIM.Value.Date) &&
                                             (GetStatusSelecionado().Contains(o.StatusDelivery))).ToList();
            }

            foreach (var item in Pedidos)
            {
                if (item.IDEntregador.HasValue)
                    item.Entregador = item.IDEntregador.HasValue ? Entregadores.Where(o => o.ID == item.IDEntregador.Value).FirstOrDefault()?.Nome : "";
            }

            Pedidos = GetFiltroPedido(Pedidos, Selecionado);

            foreach (var item in Pedidos)
            {
                UC_PedidoDelivery User = new UC_PedidoDelivery(item, Pedidos.IndexOf(item) % 2 == 0 ? ColorTranslator.FromHtml("#CAE6E6") : ColorTranslator.FromHtml("#FFF"), NomeImpressora);
                LayoutContorl.Controls.Add(User);
            }
        }

        private List<Pedido> GetFiltroPedido(List<Pedido> Pedidos, string Selecionado)
        {
            switch (Selecionado)
            {
                case "Cliente":
                    Pedidos = Pedidos.Where(o => o.Pessoa != null && o.Pessoa.Nome.ToUpper().Contains(TXT_Filtro.Text.ToUpper())).ToList();
                    break;
                case "Entregador":
                    Pedidos = Pedidos.Where(o => !string.IsNullOrEmpty(o.Entregador) && o.Entregador.ToUpper().Contains(TXT_Filtro.Text.ToUpper())).ToList();
                    break;
                case "Todos":
                    Pedidos = Pedidos.Where(o => (o.Pessoa != null && o.Pessoa.Nome.ToUpper().Contains(TXT_Filtro.Text.ToUpper())) ||
                                                 (!string.IsNullOrEmpty(o.Entregador) && o.Entregador.ToUpper().Contains(TXT_Filtro.Text.ToUpper()))).ToList();
                    break;
            }
            return Pedidos;
        }

        public bool FinalizarPedido(Pedido Ped)
        {
            var FrenteCaixa = FrenteCaixaNotaController.Instancia.GetAll().Where(o => o.IDPedido == Ped.ID).FirstOrDefault();
            var FluxoCaixa = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(Modelo.cwkGlobal.objUsuarioLogado.Id);

            IniFile ArquivoIni = new IniFile(CaminhoIni);
            var Serie = Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1"));

            Ped.Parcelas = PedidoParcelaController.Instancia.GetParcelasPedido(Ped);

            FormFrenteCaixaDeliveryFinalizar form = new FormFrenteCaixaDeliveryFinalizar(Ped, FrenteCaixa, Serie, FluxoCaixa, Ped.Pessoa, true, true);
            form.ShowDialog(this);
            if (form.Finalizou)
            {
                Ped.StatusDelivery = StatusPedidoDelivery.Finalizado;
                if (Ped.DataSaidaEntrega == null)
                    Ped.DataSaidaEntrega = DateTime.Now;

                Ped.DataChegadaEntrega = DateTime.Now;
                PedidoController.Instancia.SalvarDelivery(Ped, Acao.Alterar);
            }
            return true;
        }

        public bool CancelarPedido(Pedido Ped)
        {
            Ped.StatusDelivery = StatusPedidoDelivery.Cancelado;
            if (Ped.DataSaidaEntrega == null)
                Ped.DataSaidaEntrega = DateTime.Now;

            Ped.DataChegadaEntrega = DateTime.Now;
            PedidoController.Instancia.SalvarDelivery(Ped, Acao.Alterar);
            return true;
        }

        public Pedido AtualizarStatus(Pedido Ped)
        {
            FormFrenteCaixaDelievryMonitorStatus Status = new FormFrenteCaixaDelievryMonitorStatus(Ped);
            Status.ShowDialog(this);

            return Ped;
        }

        public bool EmitirNFCe(Pedido Ped)
        {
            if (Ped.StatusDelivery != StatusPedidoDelivery.Finalizado)
            {
                MessageBox.Show(this, "O Pedido deve estar finalizado para enviar a NFCe.", "ATENÇÃO!");
                return false;
            }

            var ArquivoIni = new IniFile(CaminhoIni);
            var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
            FormNFe frmNFe = new FormNFe(Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1")), Ped.Pessoa?.CNPJ_CPF);

            var NotaAutorizada = NotaController.Instancia.GetNotaAutorizadaPorPedido(Ped.Codigo, true).FirstOrDefault();
            if (NotaAutorizada != null)
            {
                if (MessageBox.Show("Deseja Imprimir a NFCe?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmNFe.IDNota = NotaAutorizada.ID;
                    frmNFe.FillObjNFe();
                    if (1 == Config?.VisualizarNFCe)
                        frmNFe.nfeController.VisualizarDANFE(false, NotaAutorizada.Filial?.CaminhoLogoNfe);
                    else
                        frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), NotaAutorizada.Filial?.CaminhoLogoNfe);
                }
            }
            else
            {
                if (MessageBox.Show("Deseja Enviar a NFCe?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var Nota = NotaController.Instancia.GetNotaAutorizadaPorPedido(Ped.Codigo, false).FirstOrDefault();
                    if (Nota != null)
                    {
                        Nota.ModeloDocto = 65;
                        Nota.Serie = ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1");
                        Nota.Numero = NotaController.Instancia.NovoNumeroSerie(Nota, Convert.ToInt32(Nota.Serie));
                        Nota.Dt = DateTime.Now;
                        Nota.DtDigitacao = DateTime.Now;

                        NotaController.Instancia.Salvar(Nota, Acao.Alterar);
                        frmNFe.IDNota = Nota.ID;

                        var NotaEnviada = frmNFe.ShowEnvia(false, Nota);
                        if (!string.IsNullOrEmpty(NotaEnviada.NumeroProtocolo))
                        {
                            if (1 == Config?.VisualizarNFCe)
                                frmNFe.nfeController.VisualizarDANFE(false, Nota.Filial?.CaminhoLogoNfe);
                            else
                                frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), Nota.Filial?.CaminhoLogoNfe);
                        }
                        else
                            frmNFe.ShowDialog(this);
                    }
                }
            }
            return true;
        }

        public bool EmitirNFCeSelecionadas(Pedido Ped)
        {
            var ArquivoIni = new IniFile(CaminhoIni);
            var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
            FormNFe frmNFe = new FormNFe(Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1")), Ped.Pessoa?.CNPJ_CPF);

            var NotaAutorizada = NotaController.Instancia.GetNotaAutorizadaPorPedido(Ped.Codigo, true).FirstOrDefault();
            if (NotaAutorizada != null)
                return false;

            var Nota = NotaController.Instancia.GetNotaAutorizadaPorPedido(Ped.Codigo, false).FirstOrDefault();
            Nota.ModeloDocto = 65;
            Nota.Serie = ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1");
            Nota.Numero = NotaController.Instancia.NovoNumeroSerie(Nota, Convert.ToInt32(Nota.Serie));
            Nota.Dt = DateTime.Now;
            Nota.DtDigitacao = DateTime.Now;

            NotaController.Instancia.Salvar(Nota, Acao.Alterar);
            frmNFe.IDNota = Nota.ID;

            var NotaEnviada = frmNFe.ShowEnvia(false, Nota);
            if (!string.IsNullOrEmpty(NotaEnviada.NumeroProtocolo))
            {
                if (1 == Config?.VisualizarNFCe)
                    frmNFe.nfeController.VisualizarDANFE(false, Nota.Filial?.CaminhoLogoNfe);
                else
                    frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), Nota.Filial?.CaminhoLogoNfe);
            }
            else
                frmNFe.ShowDialog(this);

            return true;
        }

        //public bool AlterarPedidoDelivery (Pedido Ped)
        //{
        //    //Editar Pedido Delivery


        //}       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TXT_Filtro.Text = string.Empty;
            Pesquisar();
        }

        private void TXT_Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // IMPRIMIR SELECIONADOS
            if (MessageBox.Show("Deseja Imprimir os Pedidos Selecionados?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (var Control in LayoutContorl.Controls)
                    if (((UC_PedidoDelivery)Control).CKB_Selecionado.Checked)
                    {
                        ((UC_PedidoDelivery)Control).ImprimirPedido();
                        ((UC_PedidoDelivery)Control).CKB_Selecionado.Checked = false;
                    }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // FINALIZAR SELECIONADOS
            if (MessageBox.Show("Deseja Finalizar os Pedidos Selecionados?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (var Control in LayoutContorl.Controls)
                {
                    if (((UC_PedidoDelivery)Control).CKB_Selecionado.Checked)
                    {
                        FinalizarPedido(((UC_PedidoDelivery)Control).Ped);
                        ((UC_PedidoDelivery)Control).Inicializar();
                        ((UC_PedidoDelivery)Control).CKB_Selecionado.Checked = false;
                    }
                }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // ENVIAR NFCE
            if (MessageBox.Show("Deseja Enviar as NFCe Selecionadas?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (var Control in LayoutContorl.Controls)
                {
                    if (((UC_PedidoDelivery)Control).CKB_Selecionado.Checked)
                    {
                        EmitirNFCeSelecionadas(((UC_PedidoDelivery)Control).Ped);
                        ((UC_PedidoDelivery)Control).Inicializar();
                        ((UC_PedidoDelivery)Control).CKB_Selecionado.Checked = false;
                    }
                }
        }

        private void BTN_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
