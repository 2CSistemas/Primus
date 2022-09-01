using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioDevolucaoPDV : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioDevolucaoPDV(Pedido Pedido, MovimentacaoCreditoPedido Movimento, Pessoa Pessoa)
        {
            InitializeComponent();


            Configuracao objconfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            TXT_Empresa.Text = objconfiguracao.Filial.Nome.ToUpper();
            TXT_Endereco.Text = objconfiguracao.Filial.Endereco.ToUpper();
            TXT_Cidade.Text = $"{objconfiguracao.Filial.Cidade.UF}".ToUpper();
            TXT_Telefone.Text = objconfiguracao.Filial.Telefone.ToUpper();

            ovTXT_CodigoDevolucao.Text = Pedido.Numero == 0 ? "COMPROVANTE DEVOLUÇÃO PDV" : "RELATÓRIO DE DEVOLUÇÃO";

            ovTXT_Cliente.Text = Pessoa.Nome.ToString();
            ovTXT_DataDevolucao.Text = Movimento.Data.ToString();
            ovTXT_MotivoDevolucao.Text = Movimento.MotivoDevolucao.ToString();
            ovTXT_Valor.Text = Movimento.Valor.ToString();

        }

    }
}
