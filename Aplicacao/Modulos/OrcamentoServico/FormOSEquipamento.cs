using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cwork.Utilitarios.Componentes.FuncoesValidacao;

namespace Aplicacao
{
    public partial class FormOSEquipamento : Aplicacao.IntermediariasTela.FormManutEquipamentoIntermediaria
    {
        Configuracao objConfiguracao;
        Size tamanhoInicialForm;
        public FormOSEquipamento()
        {
            
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            tamanhoInicialForm = this.Size;
            //lkbOSTipoEquipamento.SubForm = new FormOSTipoEquipamento();
            lkbOSTipoEquipamento.SubFormType = typeof(FormOSTipoEquipamento);

            pnlImei.Tag = Selecionado;
        }

        private void FormOSEquipamento_Shown(object sender, EventArgs e)
        {
            objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            txtCodigo.Properties.ReadOnly = true;
            pnlImei.Tag = Selecionado;
            VerificaUtilizacaoImei();
        }

        private void VerificaUtilizacaoImei()
        {
            if (objConfiguracao.UtilizaControleIMEI)
            {
                HabilitaDesabilitaNumSerie(false);

                if (!pnlImei.Visible)
                {
                    pnlImei.Visible = true;
                    this.Size = tamanhoInicialForm;
                }
            }
            else
            {
                Util.ControlUtil.LimparControles(pnlImei);
                HabilitaDesabilitaNumSerie(true);

                if (pnlImei.Visible)
                {
                    pnlImei.Visible = false;
                    this.Size = new Size(tamanhoInicialForm.Width, (tamanhoInicialForm.Height - pnlImei.Height));
                }
            }
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            ValidaCamposUtilizaImei();

            base.sbGravar_Click(sender, e);
        }

        private void ValidaCamposUtilizaImei()
        {
            if (objConfiguracao.UtilizaControleIMEI)
            {
                txtMarca.CwkValidacao = FuncaoValidacao.NaoNulo;
                txtModelo.CwkValidacao = FuncaoValidacao.NaoNulo;
            }
            else
            {
                txtMarca.CwkValidacao = null;
                txtModelo.CwkValidacao = null;
            }
        }

        private void HabilitaDesabilitaNumSerie(Boolean bValor)
        {
            if (!bValor)
                txtNumeroSerie.EditValue = null;

            txtNumeroSerie.Visible = bValor;
            lblNumeroSerie.Visible = bValor;
        }
    }
}
