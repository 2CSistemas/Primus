using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;

namespace Aplicacao.Util
{
    public class FormProdutoFactory
    {
        public static IFormManut<Produto> GetFormProduto()
        {
            return new FormProduto();
        }
    }
}
