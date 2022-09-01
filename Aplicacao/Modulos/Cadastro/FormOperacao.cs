using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormOperacao : Aplicacao.IntermediariasTela.FormManutOperacaoIntermediaria
    {
        public FormOperacao()
        {
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            groupControl1.Tag = tpPrincipal.Tag;
            gcCFOPST.Tag = tpPrincipal.Tag;
            
            lkbCFOP_DEstado_ST.SubFormType
                = lkbCFOP_FEstado_C_ST.SubFormType
                = lkbCFOP_FEstado_NC_ST.SubFormType
                = lkbCFOP_DEstado.SubFormType
                = lkbCFOP_FEstado_C.SubFormType
                = lkbCFOP_FEstado_NC.SubFormType = typeof(FormTabelaCFOP);

            //lkbCFOP_DEstado_ST.SubForm
            //   = lkbCFOP_FEstado_C_ST.SubForm
            //   = lkbCFOP_FEstado_NC_ST.SubForm
            //   = lkbCFOP_DEstado.SubForm
            //   = lkbCFOP_FEstado_C.SubForm
            //   = lkbCFOP_FEstado_NC.SubForm = typeof(FormTabelaCFOP();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            groupControl1.Tag = tpPrincipal.Tag;
            gcCFOPST.Tag = tpPrincipal.Tag;

            base.AcoesAntesBase_Load(sender, e);
        }

        protected override void OnShown(EventArgs e)
        {
            lkpNatBcCred.Properties.DataSource = CodigoImpostoController.Instancia.GetAllPorTipoImposto("Base de Cálculo de Crédito");
            lkpNatBcCred.EditValue = Selecionado.NatBcCred;
            base.OnShown(e);
        }

        protected override void AcoesAntesSalvar()
        {
            Selecionado.NatBcCred = (CodigoImposto)lkpNatBcCred.EditValue;
            base.AcoesAntesSalvar();
        }

        private void lkpNatBcCred_EditValueChanged(object sender, EventArgs e)
        {
            if (lkpNatBcCred.EditValue != null)
            {
                Selecionado.NatBcCred = (CodigoImposto)lkpNatBcCred.EditValue;
            }
        }
    }
}
