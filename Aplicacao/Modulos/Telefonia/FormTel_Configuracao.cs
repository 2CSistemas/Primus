using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Util;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormTel_Configuracao : Aplicacao.IntermediariasTela.FormManutTel_Configuracao
    {
        public FormTel_Configuracao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            SetupSubForms();
        }

        private void SetupSubForms()
        {
            lkpPlanoConta.Exemplo = new PlanoConta() { BTitulo = false };
            lkpPlanoConta.CamposRestricoesAND = new List<string>() { "btitulo" };
            lkbPlanoConta.SubFormType = typeof(FormPlanoConta);
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbAcrescimo.SubFormType = typeof(FormAcrescimo);
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbHistorico.SubFormType = typeof(FormHistorico);
            lkbPortador.SubFormType = typeof(FormPortador);
            lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);
            lkbServicoJuros.SubFormType = typeof(FormTel_Servico);
            lkbServicoMulta.SubFormType = typeof(FormTel_Servico);
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            chbSolicitaConfirmaEmailTelefonia.Checked = Selecionado.SolicitaConfirmaEmailTelefonia;

            return base.ObjetoPraTela(pai);
        }
        protected override void OK()
        {
            if (cbFixos.Checked)
            {
                Selecionado.ConsideraFixo = true;
            }
            else
            {
                Selecionado.ConsideraFixo = false;
            }

            Selecionado.SolicitaConfirmaEmailTelefonia = chbSolicitaConfirmaEmailTelefonia.Checked;

            base.OK();
        }

        private void FormTel_Configuracao_Shown(object sender, EventArgs e)
        {
            if (Selecionado.ConsideraFixo)
            {
                cbFixos.Checked = true;
            }else{
                cbFixos.Checked = false;
            }
        }
    }
}
