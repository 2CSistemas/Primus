using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormOSAcompanhamento : Aplicacao.IntermediariasTela.FormManutOSAcompanhamentoIntermediaria
    {
        public FormOSAcompanhamento()
        {
            
        }

        protected override void InitializeChildComponents()
        {
            this.Operacao = Acao.Alterar ^ Acao.NaoPersistir;
            InitializeComponent();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            this.Operacao = Acao.Alterar ^ Acao.NaoPersistir;
            sbGravar.Enabled = !Selecionado.EhAutomatica;
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            txtData.EditValue = Selecionado.DataHora.Date;
            txtHora.EditValue = Selecionado.DataHora.ToShortTimeString();
            return base.ObjetoPraTela(pai);
        }

        protected override void TelaProObjeto(Control pai)
        {
            Selecionado.DataHora = Convert.ToDateTime(txtData.EditValue);

            string[] splitHora = txtHora.Text.Split(':');
            Selecionado.DataHora = Selecionado.DataHora.AddHours(Convert.ToInt32(splitHora[0]));
            Selecionado.DataHora = Selecionado.DataHora.AddMinutes(Convert.ToInt32(splitHora[1]));

            base.TelaProObjeto(pai);
        }

        private void FormOSAcompanhamento_Shown(object sender, EventArgs e)
        {
            txtUsuario.Properties.ReadOnly = true;
        }

        protected override bool ValidarFormulario()
        {
            DateTime data = Convert.ToDateTime(txtData.EditValue);
            if (data.Year < 1950 || data.Year > 2200)
                dxErroProvider.SetError(txtData, "Data inválida");   
            else
                dxErroProvider.SetError(txtData, "");

            return base.ValidarFormulario() && (data.Year > 1950 && data.Year < 2200);
        }


    }
}
