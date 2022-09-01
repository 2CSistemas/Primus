using System.Data;
using System.Linq;
using cwkGestao.Negocio;
using NHibernate.Linq;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioProdutosPorDataCadastro : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioProdutosPorDataCadastro()
        {
            InitializeComponent();
        }

        public XtraRelatorioProdutosPorDataCadastro(string Empresa)
        {
            InitializeComponent();
            TXT_Empresa.Text = Empresa;

            ovDS_Dados.Tables.Clear();
            
            var dt = new DataTable();
            dt.Columns.Add("descricao");
            dt.Columns.Add("codigo");
            dt.Columns.Add("datacadastro");
            dt.TableName = "DADOS";
            ProdutoController.Instancia.GetAll().OrderBy(o => o.Nome).ForEach(o =>
            {
                var dr = dt.NewRow();
                dr["descricao"] = o.Nome;
                dr["codigo"] = o.Codigo;
                dr["datacadastro"] = o.DtCadastroProduto?.ToString("dd/MM/yyyy");
                dt.Rows.Add(dr);
            });
            ovDS_Dados.Tables.Add(dt);

        }
    }
}
