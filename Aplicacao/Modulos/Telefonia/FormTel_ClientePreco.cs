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
    public partial class FormTel_ClientePreco : Aplicacao.IntermediariasTela.FormManutTel_ClientePreco
    {
        public FormTel_ClientePreco() { }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbTipoLigacao.SubForm = new FormTel_TipoLigacao();
            lkbTipoLigacao.SubFormType = typeof(FormTel_TipoLigacao);
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

        protected override bool ValidacoesAdicionais()
        {
            if (Convert.ToInt32(txtArea_Inicial.EditValue) > Convert.ToInt32(txtArea_Final.EditValue))
                dxErroProvider.SetError(txtArea_Inicial, "Valor da área inicial não pode ser maior que área final");

            if (Convert.ToInt32(txtPrefixo_Inicial.EditValue) > Convert.ToInt32(txtPrefixo_Final.EditValue))
                dxErroProvider.SetError(txtPrefixo_Inicial, "Valor do prefixo inicial não pode ser maior que o prefixo final");

            if (Convert.ToInt32(txtRange_Inicial.EditValue) > Convert.ToInt32(txtRange_Final.EditValue))
                dxErroProvider.SetError(txtRange_Inicial, "Valor do range inicial não pode ser maior que o range final");

            return !dxErroProvider.HasErrors;
        }
    }
}
