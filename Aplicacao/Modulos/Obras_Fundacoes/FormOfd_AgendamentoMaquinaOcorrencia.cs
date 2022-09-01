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
    public partial class FormOfd_AgendamentoMaquinaOcorrencia : Aplicacao.IntermediariasTela.FormManutOfd_AgendamentoMaquinaOcorrenciaIntermediaria
    {
        Acao acao;
        public FormOfd_AgendamentoMaquinaOcorrencia()
        {
        }
        public FormOfd_AgendamentoMaquinaOcorrencia(Ofd_AgendamentoMaquinaOcorrencia AgendamentoMaquinaOcorrencias, Acao Acao)
        {
            if (AgendamentoMaquinaOcorrencias != null)
            {
                Selecionado = AgendamentoMaquinaOcorrencias;
                this.acao = Acao;    
            }
            else
            {
                Selecionado = new Ofd_AgendamentoMaquinaOcorrencia();
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
                Selecionado.Observacao = txtObservacao.Text;
                this.Close();
            }
        }
            
        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();
            if (lkpOcorrencia.EditValue == null)
                dxErroProvider.SetError(lkpOcorrencia, "Campo obrigatório");
            if (String.IsNullOrEmpty(txtTempoOcorrencia.Text))
                dxErroProvider.SetError(txtTempoOcorrencia, "Campo obrigatório");
            if (String.IsNullOrEmpty(txtObservacao.Text))
                dxErroProvider.SetError(txtObservacao, "Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        private void FormOfd_AgendamentoMaquinaOcorrencia_Shown(object sender, EventArgs e)
        {
            ObjetoPraTela(this);
            //if (Selecionado != null && (acao == Acao.Alterar || acao == Acao.Consultar))
            //{
            //    lkpOcorrencia.EditValue = Selecionado.Ocorrencia;
            //    txtTempoOcorrencia.EditValue = Selecionado.TempoOcorrencia;
            //    txtObservacao.EditValue = Selecionado.Observacao;
            //}
            if (acao == Acao.Consultar)
            {
                lkpOcorrencia.Enabled = false;
                txtTempoOcorrencia.Enabled = false;
                txtObservacao.Enabled = false;
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
