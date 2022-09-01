using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaçãoPrimus.BancoDados
{
    class Connect
    {
        public String ConexaoLocal()
        {
            string conexao = @"Data Source=.\SQLEXPRESS01;Initial Catalog=BancoDemo;Integrated Security=True;MultipleActiveResultSets=True";
            //string conexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=BancoDemo;Integrated Security=True;MultipleActiveResultSets=True";
            return conexao;

        }
    }
}
