using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormTel_Servico : Aplicacao.IntermediariasTela.FormManutTel_Servico
    {
        public FormTel_Servico()
        {            
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
        }

        protected override void OK()
        {
            var tel_servico = Tel_ServicoController.Instancia.LoadObjectById(Selecionado.ID);
            if (Decimal.Parse(txtValor.EditValue.ToString()) != tel_servico.Valor)
            {
                if (MessageBox.Show("Deseja atualizar o valor dos serviços de todos os clientes?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if ((MessageBox.Show("Deseja mesmo efetuar essa alteração?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        try
                        {
                            Tel_ClienteServicoController.Instancia.AtualizaValorServicoCliente(Selecionado.ID, Decimal.Parse(txtValor.EditValue.ToString()));
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                } 
            }
            base.OK();
        }
    }
}
