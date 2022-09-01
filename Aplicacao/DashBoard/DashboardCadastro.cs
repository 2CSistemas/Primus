using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cwkGestao.Negocio;
using cwkGestao.Integracao;

namespace Aplicacao.DashBoard
{
    class DashboardCadastro
    {
        private int count;
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
        public string Vendedor { get; set; }

        public  DashboardCadastro() {}
        public DashboardCadastro(string cliente, string produto, string fornecedor, string vendedor)
        {
            Cliente = cliente;
            Produto = produto;
            Fornecedor = fornecedor;
            Vendedor = vendedor;
        }

        public DashboardCadastro(int count)
        {
            this.count = count;
        }
        public List<DashboardCadastro> DadosCadastros(string cliente)
        {
            var dadoscadastro = new List<DashboardCadastro>();
            dadoscadastro.Add(new DashboardCadastro(PessoaController.Instancia.GetAllClientes().Count));
            return dadoscadastro;
        }
    }
}
