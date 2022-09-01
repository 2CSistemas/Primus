using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Modulos.Telefonia;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormTel_ClienteServico : Aplicacao.IntermediariasTela.FormManutTel_ClienteServicoIntermediaria
    {
        public FormTel_ClienteServico()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            lkpServico.Exemplo = new Tel_Servico();
            lkpServico.OnIDChanged += lkpServico_IDChanged;
            //lkbServico.SubForm = new FormTel_Servico();
            lkbServico.SubFormType = typeof(FormTel_Servico);
		}

        private void lkpServico_IDChanged(object sender, EventArgs e)
        {
            if (lkpServico.Selecionado != null)
            {
                var servico = (Tel_Servico)lkpServico.Selecionado;
                txtValor.EditValue = servico.Valor;
                cbOperacao.SelectedIndex = servico.Operacao;
            }
        }
    }
}
