using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormTel_TipoLigacaoPreco : Aplicacao.IntermediariasTela.FormManutTel_TipoLigacaoPreco
    {
        public FormTel_TipoLigacaoPreco() { }

        public FormTel_TipoLigacaoPreco(Tel_TipoLigacaoPreco tipoLigacao)
        {
            Selecionado = tipoLigacao;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void FormTel_TipoLigacaoPreco_Shown(object sender, EventArgs e)
        {
            if (Operacao == (cwkGestao.Modelo.Acao)31)
            {
                txtArea_Final.EditValue = 99;
                txtPrefixo_Final.EditValue = 9999;
                txtRange_Final.EditValue = 9999;
            }
        }

        protected override bool ValidarFormulario()
        {
            bool retorno = base.ValidarFormulario();
            string mensagem = "Verificar Anomalias" + Environment.NewLine;

            if (Convert.ToInt32(txtArea_Inicial.EditValue) > Convert.ToInt32(txtArea_Final.EditValue))
            {
                retorno = false;
                dxErroProvider.SetError(txtArea_Inicial, "Valor da área inicial não pode ser maior que área final");
                mensagem += "[Área Inicial] = Valor maior que área final" + Environment.NewLine;
            }
            if (Convert.ToInt32(txtPrefixo_Inicial.EditValue) > Convert.ToInt32(txtPrefixo_Final.EditValue))
            {
                retorno = false;
                dxErroProvider.SetError(txtPrefixo_Inicial, "Valor do prefixo inicial não pode ser maior que o prefixo final");
                mensagem += "[Prefixo Inicial] = Valor maior que o prefixo final" + Environment.NewLine;
            }
            if (Convert.ToInt32(txtRange_Inicial.EditValue) > Convert.ToInt32(txtRange_Final.EditValue))
            {
                retorno = false;
                dxErroProvider.SetError(txtRange_Inicial, "Valor do range inicial não pode ser maior que o range final");
                mensagem += "[Range Inicial] = Valor maior que o range final" + Environment.NewLine;
            }

            if (retorno == false)
            {
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return retorno;
        }
    }
}
