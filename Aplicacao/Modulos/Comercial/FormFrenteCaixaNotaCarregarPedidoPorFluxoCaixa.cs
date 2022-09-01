using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using Aplicacao.Modulos.Comercial.Impressao;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;

using DBUtils.Classes;

using DevExpress.XtraReports.UI;

using MetroFramework.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaNotaCarregarPedidoPorFluxoCaixa : MetroForm
    {
        private FluxoCaixa Fluxo = null;
        public IniFile ArquivoIni => new IniFile(Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini");
        public FormFrenteCaixaNotaCarregarPedidoPorFluxoCaixa(FluxoCaixa Fluxo)
        {
            InitializeComponent();
            this.Fluxo = Fluxo;
            InitGrid();
        }

        private void InitGrid()
        {
            ovGRD_Pedidos.DataSource = PedidoController.Instancia.GetListaPedidosFrenteCaixaParaCarregar(IDFluxoCaixa: Fluxo.ID);
            ovGRD_Pedidos.Refresh();
            AjustaHeaderItens();
        }

        private void AjustaHeaderItens()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Open Sans", 10, FontStyle.Regular);
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (DataGridViewColumn column in ovGRD_Pedidos.Columns)
            {
                switch (column.Name)
                {
                    case "Codigo":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.15);
                        column.HeaderText = "Código";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Dt":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.20);
                        column.HeaderText = "Data Cadastro";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "PessoaNome":
                        column.DisplayIndex = 2;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.45);
                        column.HeaderText = "Pessoa";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "TipoPedido":
                        column.DisplayIndex = 3;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.20);
                        column.HeaderText = "Tipo Pedido";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "TotalPedido":
                        column.DisplayIndex = 4;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.17);
                        column.HeaderText = "Total";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    default:
                        column.DisplayIndex = 0;
                        column.Visible = false;
                        break;
                }
            }
        }

        private void ovGRD_Pedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (ovGRD_Pedidos.Columns[e.ColumnIndex].Name)
            {
                case "TotalPedido":
                    e.Value = Convert.ToDecimal(e.Value).ToString("c2");
                    break;
                    //case "Status":
                    //    e.Value = "1".Equals(e.Value.ToString()) ? "Em Aberto" : "";
                    //    break;
            }
        }

        private void FormFrenteCaixaNotaCarregarPedido_Shown(object sender, EventArgs e)
        {
            TXT_Pesquisa.Focus();
        }

        private void SbQuantidade_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ImprimirPedido();
        }
        private string CaminhoIni => Debugger.IsAttached ?
            $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini" :
            $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";

        private string NomeImpressora
        {
            get
            {
                IniFile ArquivoIni = new IniFile(CaminhoIni);
                return ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", ConfiguracaoController.Instancia.GetConfiguracao().NomeImpressora);
            }
        }

        public void ImprimirNFCe()
        {
            pxyPedidoFrenteCaixaCarregar LinhaSelecionada = ovGRD_Pedidos.SelectedRows[0].DataBoundItem as pxyPedidoFrenteCaixaCarregar;
            Pedido Ped = PedidoController.Instancia.GetByCodigo(LinhaSelecionada.Codigo);
            var NotaAutorizada = NotaController.Instancia.GetNotaAutorizadaPorPedido(LinhaSelecionada.Codigo, true).FirstOrDefault();
            if (NotaAutorizada == null)
            {
                MessageBox.Show("Nenhuma NFCe encontrada para este pedido!", "ATENÇÃO");
                return;
            }

            var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
            FormNFe frmNFe = new FormNFe(Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1")), Ped.Pessoa?.CNPJ_CPF);

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

        public void ImprimirPedido()
        {
            pxyPedidoFrenteCaixaCarregar LinhaSelecionada = ovGRD_Pedidos.SelectedRows[0].DataBoundItem as pxyPedidoFrenteCaixaCarregar;
            var Ped = PedidoController.Instancia.GetByCodigo(LinhaSelecionada.Codigo);

            if (Ped.BDelivery == 1)
            {
                var RelatorioFluxoCaixa = new XRReportPedidoDelivery(Ped, PedidoController.Instancia.GetFrenteCaixaNotaPorPedido(LinhaSelecionada.ID)?.Troco ?? 0);
                var tool = new ReportPrintTool(RelatorioFluxoCaixa);

                var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
                if (1 == Config?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);
            }
            else
            {
                var _Ped = PedidoController.Instancia.GetFrenteCaixaNotaPorPedido(LinhaSelecionada.ID);
                var RelatorioFluxoCaixa = new XRReportPedidoVenda(null, Ped, _Ped?.Troco ?? 0, _Ped?.TotalPago ?? 0);
                var tool = new ReportPrintTool(RelatorioFluxoCaixa);

                var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
                if (1 == Config?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //NFCe
            ImprimirNFCe();
        }
    }
}
