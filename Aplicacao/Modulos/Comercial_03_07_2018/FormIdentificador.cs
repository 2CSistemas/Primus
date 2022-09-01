using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormIdentificador : Aplicacao.IntermediariasTela.FormManutIdentificadorIntermediaria
    {
        public FormIdentificador()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();            
        }

        protected override bool ValidacoesAdicionais()
        {
            if (Operacao == Acao.Excluir)
            {
                var notas = NotaItemController.Instancia.GetAll();
                foreach (var item in notas)
                {
                    if (item.ID.ToString() == Selecionado.Codigo)
                        return false;
                }
                base.OK();
            }
            return true;
        }
    }
}
