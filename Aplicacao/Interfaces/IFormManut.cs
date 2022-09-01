using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacao.Interfaces
{
    public interface IFormManut<T>
    {
        T Selecionado { get; set; }
        System.Windows.Forms.DialogResult ShowDialog();
        cwkGestao.Modelo.Acao Operacao { get; set; }

        
    }
}
