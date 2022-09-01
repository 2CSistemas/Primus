using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraPDVSangria : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraPDVSangria(FluxoCaixa Fluxo, SangriaCaixa Sangria, string Caixa)
        {
            InitializeComponent();

            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            TXT_Empresa.Text = objConfiguracao.FilialFrenteCaixa.Nome.ToUpper();
            TXT_Endereco.Text = $"{objConfiguracao.FilialFrenteCaixa.Endereco},{objConfiguracao.FilialFrenteCaixa.Numero}".ToUpper();
            TXT_Cidade.Text = $"{objConfiguracao.FilialFrenteCaixa.Cidade.UF}".ToUpper();
            TXT_Telefone.Text = objConfiguracao.FilialFrenteCaixa.Telefone.ToUpper();

            TXT_NumeroPedido.Text = Sangria.Retirada == 0 ? "RELATÓRIO DE SANGRIA" : "RELATÓRIO DE RETIRADA";

            ovTXT_UsuarioSangria.Text = Fluxo.IDUsuario.HasValue ? Cw_usuarioController.Instancia.LoadObjectById(Fluxo.IDUsuario.Value)?.Nome : "";
            ovTXT_NumeroPDV.Text = Caixa;
            ovTXT_DataHoraRetirada.Text = Sangria.DataSangria.ToString();
            ovTXT_ValorSangria.Text = Sangria.Valor == null ? "" : Sangria.Valor?.ToString("c2");
            ovTXT_Observacao.Text = Sangria.Observacao;
        }
    }
}
