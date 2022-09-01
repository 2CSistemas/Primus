using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Interfaces;
using System.Linq;
using Cwork.Utilitarios.Componentes;
using Aplicacao.Base;
namespace Aplicacao
{
    public partial class FormOfd_AgendamentoMaquina : Aplicacao.IntermediariasTela.FormManutOfd_AgendamentoMaquinaIntermediaria
    {
        public IList<Ofd_AgendamentoMaquina> agendamentos;
        public FormOfd_AgendamentoMaquina(IList<Ofd_AgendamentoMaquina> Agendamentos)
        {
            agendamentos = Agendamentos;
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            lkpOperador1.Exemplo = new Pessoa() { BFuncionario = true };
            lkpOperador1.CamposRestricoesAND = new List<string>() { "BFuncionario" };

            lkpOperador2.Exemplo = new Pessoa() { BFuncionario = true };
            lkpOperador2.CamposRestricoesAND = new List<string>() { "BFuncionario" };

            lkpOfd_Maquina.Exemplo = new Ofd_Maquinas();
            lkpOfd_Obra.Exemplo = new Ofd_Obra();

            //FormOfd_AgendamentoMaquinaOcorrencia form = new FormOfd_AgendamentoMaquinaOcorrencia();
            //btAlterar.SubForm = btConsultar.SubForm = btIncluir.SubForm = btExcluir.SubForm = form;

            btAlterar.SubFormType = btConsultar.SubFormType = btIncluir.SubFormType = btExcluir.SubFormType = typeof(FormOfd_AgendamentoMaquinaOcorrencia);

            btAlterar.GridControl = btConsultar.GridControl = btIncluir.GridControl = btExcluir.GridControl = gcOcorrencias;

            gcOcorrencias.DataSource = Selecionado.Ocorrencias;
		}

        public void TratarTela()
        {
            base.TratarTela();
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();

            if (txtHoraSaida.Time == new DateTime(1,1,1))
            {
                txtHoraSaida.EditValue = Selecionado.Data.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            }

            if (txtData.EditValue == null)
            {
                dxErroProvider.SetError(txtData, "A data de um agendamento é obrigatória. Verifique.");
            }
            if (txtHoraEntrada.EditValue == null)
            {
                dxErroProvider.SetError(txtHoraEntrada, "A Hora de início de um agendamento é obrigatória. Verifique.");
            }
            if (lkpOfd_Maquina.Selecionado == null)
            {
                dxErroProvider.SetError(lkpOfd_Maquina, "A alocação de uma máquina em um agendamento é obrigatória. Verifique.");
            }

            
            if (Selecionado.HoraEntrada.HasValue && Selecionado.HoraSaida.HasValue)
            {
                if (Selecionado.HoraSaida.Value < Selecionado.HoraEntrada.Value)
                {
                    dxErroProvider.SetError(txtHoraEntrada, "A Hora de Entrada não pode ser maior que a Hora de Saída. Verifique.");
                    dxErroProvider.SetError(txtHoraSaida, "A Hora de Entrada não pode ser maior que a Hora de Saída. Verifique.");
                }
            }
            if ((lkpOperador1.Selecionado != null) && (lkpOperador2.Selecionado != null))
            {
                if (((Pessoa)lkpOperador1.Selecionado).ID == ((Pessoa)lkpOperador2.Selecionado).ID)
                {
                    dxErroProvider.SetError(lkpOperador1, "Os operadores não podem ser os mesmos. Verifique.");
                    dxErroProvider.SetError(lkpOperador2, "Os operadores não podem ser os mesmos. Verifique.");
                }
            }
            if (VerificaConflitoAgendamentos((Ofd_Maquinas)lkpOfd_Maquina.Selecionado, txtData.DateTime, txtHoraEntrada.Time, txtHoraSaida.Time, agendamentos))
            {
                dxErroProvider.SetError(lkpOfd_Maquina, "Já existe um agendamento para esta máquina neste horário. Verifique.");
                dxErroProvider.SetError(txtHoraEntrada, "Já existe um agendamento para esta máquina neste horário. Verifique.");
            }
            return !dxErroProvider.HasErrors;
        }

        private bool VerificaConflitoAgendamentos(Ofd_Maquinas Maquina, DateTime Data, DateTime? HoraEntrada, DateTime? HoraSaida, IList<Ofd_AgendamentoMaquina> list)
        {
            DateTime dtInicio = new DateTime(Data.Year, Data.Month, Data.Day, 
                HoraEntrada.HasValue ? HoraEntrada.Value.Hour : 0, 
                HoraEntrada.HasValue ? HoraEntrada.Value.Minute : 0, 
                HoraEntrada.HasValue ? HoraEntrada.Value.Second : 0);

            DateTime dtFim = new DateTime(Data.Year, Data.Month, Data.Day,
                HoraSaida.HasValue ? HoraSaida.Value.Hour : 0,
                HoraSaida.HasValue ? HoraSaida.Value.Minute : 0,
                HoraSaida.HasValue ? HoraSaida.Value.Second : 0);

            if (list == null)
            {
                return false;
            }
            if (list.Count == 0)
            {
                return false;
            }
            try
            {
                var grupo = list.GroupBy(g => g.Ofd_Maquina.ID);
                var grp = grupo.FirstOrDefault(f => f.Key == Maquina.ID);
                if (grp != null)
                {
                    foreach (var item in grp)
                    {
                        if (!item.HoraEntrada.HasValue)
                        {
                            item.HoraEntrada = item.Data.Date;
                        }
                        if (!item.HoraSaida.HasValue)
                        {
                            item.HoraSaida = item.Data.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                        }
                        if (item.HoraEntrada.Value <= dtInicio && dtInicio <= item.HoraSaida.Value &&
                            (item.ID != Selecionado.ID))
                        {
                            return true;
                        }
                    }
                }
                return false;                
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }

        protected override void AcoesAntesSalvar()
        {
            Selecionado.Data = new DateTime(Selecionado.Data.Year, Selecionado.Data.Month, 
                Selecionado.Data.Day, Selecionado.HoraEntrada.Value.Hour, 
                Selecionado.HoraEntrada.Value.Minute, Selecionado.HoraEntrada.Value.Second);

            Selecionado.HoraEntrada = Selecionado.Data;
            Selecionado.HoraSaida = Selecionado.HoraSaida.HasValue ? 
                new DateTime(Selecionado.Data.Year, Selecionado.Data.Month, 
                Selecionado.Data.Day, Selecionado.HoraSaida.Value.Hour, 
                Selecionado.HoraSaida.Value.Minute, Selecionado.HoraSaida.Value.Second) :
                new DateTime(Selecionado.Data.Year, Selecionado.Data.Month, 
                Selecionado.Data.Day, 23,59, 59);


            base.AcoesAntesSalvar();
        }

        #region Eventos

        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);
            if (Operacao == Acao.Consultar || Operacao == Acao.Excluir)
            {
                LiberaCamposEdicao(tpPrincipal.Controls, false);
                txtData.Enabled = false;
                btAlterar.Enabled = btIncluir.Enabled = btConsultar.Enabled = btExcluir.Enabled = gcOcorrencias.Enabled = false;
            }
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                //DevButton botao = (DevButton)sender;
                //TelaProObjeto(tcPrincipal);
                //if (Selecionado.Ocorrencias != null)
                //    gcOcorrencias.DataSource = Selecionado.Ocorrencias;
                //else
                //    gcOcorrencias.DataSource = new List<Ofd_AgendamentoMaquinaOcorrencia>();
                //if (((FormManutBaseNew<Ofd_AgendamentoMaquinaOcorrencia>)botao.SubForm).Selecionado == null)
                //{
                //    ((FormManutBaseNew<Ofd_AgendamentoMaquinaOcorrencia>)botao.SubForm).Selecionado = (Ofd_AgendamentoMaquinaOcorrencia)gvOcorrencias.GetRow(gvOcorrencias.GetSelectedRows()[0]);
                //}
                //((FormManutBaseNew<Ofd_AgendamentoMaquinaOcorrencia>)botao.SubForm).Selecionado.Ofd_AgendamentoMaquina = Selecionado;

                base.btSubRegistro_Click(sender, e);
            }
            catch (Exception f)
            {
                throw f;
            }
            gcOcorrencias.RefreshDataSource();
        }
        
        private void lkbOfd_Maquina_Click(object sender, EventArgs e)
        {
            var listagem = Ofd_MaquinasController.Instancia.GetAll();
            var grid = new GridGenerica<Ofd_Maquinas>(listagem, new FormOfd_Maquinas(), (Ofd_Maquinas)lkpOfd_Maquina.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpOfd_Maquina.Localizar(grid.Selecionado.ID);
            }
            lkpOfd_Maquina.Focus();
        }

        private void lkbOfd_Obra_Click(object sender, EventArgs e)
        {
            var listagem = Ofd_ObraController.Instancia.GetAll();
            var grid = new GridGenerica<Ofd_Obra>(listagem, new FormOfd_Obra(), (Ofd_Obra)lkpOfd_Obra.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpOfd_Obra.Localizar(grid.Selecionado.ID);
            }
            lkpOfd_Obra.Focus();
        }

        private void lkbOperador1_Click(object sender, EventArgs e)
        {
            var pessoas = PessoaController.Instancia.GetAllFuncionarios();
            if (lkpOperador2.Selecionado != null)
            {
                pessoas = pessoas.Where(w => w.ID != ((Pessoa)lkpOperador2.Selecionado).ID).ToList<Pessoa>();
            }
            var grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpOperador1.Selecionado, "Funcionário", false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpOperador1.Localizar(grid.Selecionado.ID);
            }
            lkpOperador1.Focus();
        }

        private void lkbOperador2_Click(object sender, EventArgs e)
        {
            var pessoas = PessoaController.Instancia.GetAllFuncionarios();
            if (lkpOperador1.Selecionado != null)
            {
                pessoas = pessoas.Where(w => w.ID != ((Pessoa)lkpOperador1.Selecionado).ID).ToList<Pessoa>();
            }
            var grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpOperador2.Selecionado, "Funcionário", false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpOperador2.Localizar(grid.Selecionado.ID);
            }
            lkpOperador2.Focus();
        }

        private void FormOfd_AgendamentoMaquina_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Cancelar();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, this.Text);
                    break;
                default:
                    return;
            }
        }

        #endregion
    }
}
