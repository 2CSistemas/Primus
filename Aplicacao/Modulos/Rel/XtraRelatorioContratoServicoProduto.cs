using cwkGestao.Modelo;
using cwkGestao.Negocio;

using System;
using System.Data;
using System.Linq;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioContratoServicoProduto : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioContratoServicoProduto()
        {
            InitializeComponent();
        }

        public XtraRelatorioContratoServicoProduto(DataTable dt, DateTime dtInicial, DateTime dtFinal)
        {
            InitializeComponent();

            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            TXT_Empresa.Text = objConfiguracao.FilialFrenteCaixa.Nome.ToUpper();
            TXT_Emissao.Text = DateTime.Now.ToString();

            dt.TableName = "DADOS";
            ovDS_Dados.Tables.Clear();
            ovDS_Dados.Tables.Add(dt);

            TXT_PeriodoRelatorio.Text = $"{dtInicial.ToString("dd/MM/yyyy")} até {dtFinal.ToString("dd/MM/yyyy")}";
            TXT_QtdeServicos.Text = dt.AsEnumerable().Where(o => o["TIPO"].ToString().Equals("SERVIÇO")).Count().ToString();
            TXT_QtdeProdutos.Text = dt.AsEnumerable().Where(o => o["TIPO"].ToString().Equals("PRODUTO")).Count().ToString();
        }
    }
}
