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
    public partial class FormOfd_PropostaMedicaoOcorrencias : Aplicacao.IntermediariasTela.FormManutOfd_PropostaMedicaoOcorrenciasIntermediaria
    {
        Acao acao;
        public FormOfd_PropostaMedicaoOcorrencias(Ofd_PropostaMedicaoOcorrencias PropostaMedicaoOcorrencias, Acao Acao)
        {
            if (PropostaMedicaoOcorrencias != null)
            {
                Selecionado = PropostaMedicaoOcorrencias;
                this.acao = Acao;    
            }
            else
            {
                Selecionado = new Ofd_PropostaMedicaoOcorrencias();
            }
            if (acao != null)
            {
                this.acao = acao;
            }
            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            lkpOcorrencia.Sessao = Ofd_OcorrenciasController.Instancia.getSession();
            lkpOcorrencia.Exemplo = new Ofd_Ocorrencias();
		}

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                Selecionado.Ocorrencia = (Ofd_Ocorrencias)lkpOcorrencia.Selecionado;
                Selecionado.TempoOcorrencia = DateTime.Parse(txtTempoOcorrencia.Text);
                Selecionado.Observacao = txtObservacaoOcorrencia.Text;
                this.Close();
            }
        }
        
        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();
            if (lkpOcorrencia.EditValue == null)
                dxErroProvider.SetError(lkpOcorrencia, "Campo obrigatório");
            if (txtTempoOcorrencia.Text == null)
                dxErroProvider.SetError(txtTempoOcorrencia, "Campo obrigatório");
            if (txtObservacaoOcorrencia.Text == null)
                dxErroProvider.SetError(txtObservacaoOcorrencia, "Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        private void FormOfd_PropostaMedicaoOcorrencias_Shown(object sender, EventArgs e)
        {
            if (Selecionado != null && (acao == Acao.Alterar || acao == Acao.Consultar))
            {
                lkpOcorrencia.EditValue = Selecionado.Ocorrencia;
                txtTempoOcorrencia.EditValue = Selecionado.TempoOcorrencia;
                txtObservacaoOcorrencia.EditValue = Selecionado.Observacao;
            }
            if (acao == Acao.Consultar)
            {
                lkpOcorrencia.Enabled = false;
                txtTempoOcorrencia.Enabled = false;
                txtObservacaoOcorrencia.Enabled = false;
                sbGravar.Enabled = false;
            }

        }

        private void btnlkpOcorrencia_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Ofd_Ocorrencias> grid = new GridGenerica<cwkGestao.Modelo.Ofd_Ocorrencias>(Ofd_OcorrenciasController.Instancia.GetAll(), new FormOfd_Ocorrencias(), (cwkGestao.Modelo.Ofd_Ocorrencias)lkpOcorrencia.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpOcorrencia.EditValue = grid.Selecionado;
        }


    }
}
