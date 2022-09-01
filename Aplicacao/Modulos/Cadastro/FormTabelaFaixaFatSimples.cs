using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cwork.Utilitarios.Componentes;

namespace Aplicacao
{
    public partial class FormTabelaFaixaFatSimples : Aplicacao.IntermediariasTela.FormManutTabelaFaixaFatSimplesIntermediaria
    {
        

        public FormTabelaFaixaFatSimples()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            txtFaixa_I.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(ValidaCamposFaixaInicial);
            txtFaixa_F.CwkFuncaoValidacao = new CwkBaseEditor.FuncaoValidacaoDelegate(ValidaCamposFaixaFinal);
        }

        private string ValidaCamposFaixaInicial(object input)
        {
            decimal faixa = Convert.ToDecimal(input);
            
            decimal faixaI = Convert.ToDecimal(txtFaixa_I.EditValue);
            decimal faixaF = Convert.ToDecimal(txtFaixa_F.EditValue);

            if (faixaI >= faixaF)
            {
                return "Faixa Inicial tem que ser menor que a Faixa Final";
            }
            else
                return "";
        }

        private string ValidaCamposFaixaFinal(object input)
        {
            decimal faixa = Convert.ToDecimal(input);

            decimal faixaI = Convert.ToDecimal(txtFaixa_I.EditValue);
            decimal faixaF = Convert.ToDecimal(txtFaixa_F.EditValue);

            if (faixa > 0)
            {
                if (faixaI >= faixaF)
                {
                    return "Faixa de valores inválida.";
                }
                else
                    return "";
            }
            return "Faixa tem que ser maior que zero.";

        }
    }
}
