using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Rel
{
    public partial class XRRPdvSuprimento : DevExpress.XtraReports.UI.XtraReport
    {
        public XRRPdvSuprimento(FluxoCaixa Fluxo, SuprimentoCaixa Suprimento, string Caixa)
        {
            InitializeComponent();

            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            TXT_Empresa.Text = objConfiguracao.FilialFrenteCaixa.Nome.ToUpper();
            TXT_Endereco.Text = $"{objConfiguracao.FilialFrenteCaixa.Endereco},{objConfiguracao.FilialFrenteCaixa.Numero}".ToUpper();
            TXT_Cidade.Text = $"{objConfiguracao.FilialFrenteCaixa.Cidade.UF}".ToUpper();
            TXT_Telefone.Text = objConfiguracao.FilialFrenteCaixa.Telefone.ToUpper();


            ovTXT_UsuarioSuprimento.Text = Fluxo.IDUsuario.HasValue ? Cw_usuarioController.Instancia.LoadObjectById(Fluxo.IDUsuario.Value)?.Nome : "";
            ovTXT_NumeroPDV.Text = Caixa;
            ovTXT_DataHoraEntrada.Text = Suprimento.DataSuprimento.ToString();
            ovTXT_ValorSuprimento.Text = Suprimento.Valor == null ? "" : Suprimento.Valor?.ToString("c2");
            ovTXT_Observacao.Text = Suprimento.Observacao;
        }
    }
}
