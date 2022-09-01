using System;
using System.Data;
using System.Linq;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioContratoServicoProdutoValor : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioContratoServicoProdutoValor()
        {
            InitializeComponent();
        }

        public XtraRelatorioContratoServicoProdutoValor(DataTable dt, DateTime dtInicial, DateTime dtFinal, string Empresa)
        {
            InitializeComponent();

            dt.TableName = "DADOS";
            ovDS_Dados.Tables.Clear();
            ovDS_Dados.Tables.Add(dt);

            TXT_Empresa.Text = Empresa;
            TXT_Emissao.Text = DateTime.Now.ToString();
            TXT_PeriodoRelatorio.Text = $"{dtInicial.ToString("dd/MM/yyyy")} até {dtFinal.ToString("dd/MM/yyyy")}";

            TXT_QtdeServicos.Text = dt.AsEnumerable().Count(o => o["TIPO"].ToString().Equals("SERVIÇO")).ToString();
            TXT_QtdeProdutos.Text = dt.AsEnumerable().Count(o => o["TIPO"].ToString().Equals("PRODUTO")).ToString();
            TXT_QuantidadeClientes.Text = dt.AsEnumerable().Select(o => o["CPF_CNPJ"]).Distinct().Count().ToString();
        }
    }
}
