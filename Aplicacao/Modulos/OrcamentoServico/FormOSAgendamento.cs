using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraScheduler;
using Modelo;
using Pessoa = cwkGestao.Modelo.Pessoa;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao
{
    public partial class FormOSAgendamento : Form
    {
        private OSAgendamentoController osAgendamentoController = OSAgendamentoController.Instancia;

        public OSOrdemServico OSOrdemServico { set { if (value != null) lkpOS.Localizar(value.ID); } }
        public Pessoa Tecnico { set { if (value != null) lkpTecnico.Localizar(value.ID); } }

        public FormOSAgendamento()
        {
            InitializeComponent();
            lkpTecnico.Sessao = osAgendamentoController.getSession();
            lkpTecnico.Exemplo = new Pessoa() { BFuncionario = true };
            lkpTecnico.CamposRestricoesAND = new List<string> { "BFuncionario" };

            lkpOS.Sessao = osAgendamentoController.getSession();
            lkpOS.CamposPesquisa = new string[] { "Codigo", "Cliente" };
            lkpOS.Exemplo = new OSOrdemServico() { Status = StatusOSController.Instancia.GetStatusTipoAgendamento() };
            lkpOS.CamposRestricoesAND = new List<string> { "Status" };

            txtDt.DateTime = DateTime.Today;

            stoAgendamentos.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("objeto", "objeto"));
            AtualizarGridSeguindoConfigTela();
        }

        private void TransformaAgendamentos(IList<OSAgendamento> agendamentos)
        {
            AdicionarResources(agendamentos);
            stoAgendamentos.Appointments.Clear();
            foreach (OSAgendamento osAgendamento in agendamentos)
            {
                Appointment apontamento = stoAgendamentos.CreateAppointment(AppointmentType.Normal);
                apontamento.Description = osAgendamento.OSOrdemServico.Cliente.Nome;
                apontamento.Subject = osAgendamento.OSOrdemServico.Equipamento.Descricao;
                apontamento.Start = osAgendamento.Inicio;
                apontamento.End = osAgendamento.Fim;
                apontamento.ResourceId = osAgendamento.Funcionario;
                apontamento.CustomFields["objeto"] = osAgendamento;
                stoAgendamentos.Appointments.Add(apontamento);

            }
            gridAgendamentos.RefreshData();
        }

        private void AdicionarResources(IList<OSAgendamento> agendamentos)
        {
            IList<PessoaFuncionario> pessoas = new List<PessoaFuncionario>();
            foreach (OSAgendamento osAgendamento in agendamentos)
            {
                if (!pessoas.Contains(osAgendamento.Funcionario))
                    pessoas.Add(osAgendamento.Funcionario);
            }

            stoAgendamentos.Resources.Clear();
            foreach (PessoaFuncionario pessoaFuncionario in pessoas)
            {
                Random randomGen = new Random();
                Resource resource = this.schedulerDataStorage1.CreateResource(pessoaFuncionario, pessoaFuncionario.Pessoa.Nome);
                resource.SetColor(Color.FromArgb(randomGen.Next(50) + 205, randomGen.Next(50) + 205, randomGen.Next(50) + 205));
                stoAgendamentos.Resources.Add(resource);
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cwkControleUsuario.Facade.ControleAcesso(this) && ValidaAgendamento())
                {
                    OSAgendamento agendamento = new OSAgendamento();
                    agendamento.Funcionario = ((Pessoa)lkpTecnico.Selecionado).PessoaFuncionarios[0];
                    agendamento.OSOrdemServico = (OSOrdemServico)lkpOS.Selecionado;

                    DateTime data = txtDt.DateTime.Date;
                    string[] horario = txtInicio.Text.Split(':');
                    int hora = Convert.ToInt32(horario[0]);
                    int minutos = Convert.ToInt32(horario[1]);

                    agendamento.Inicio = data.AddHours(hora).AddMinutes(minutos);

                    horario = txtFim.Text.Split(':');
                    hora = Convert.ToInt32(horario[0]);
                    minutos = Convert.ToInt32(horario[1]);

                    agendamento.Fim = data.AddHours(hora).AddMinutes(minutos);

                    ValidarHorariosAgendamento(agendamento);
                    osAgendamentoController.Salvar(agendamento, Acao.Incluir);

                    OSOrdemServico osOrdemServico = OSOrdemServicoController.Instancia.LoadObjectById(agendamento.OSOrdemServico.ID);
                    //osOrdemServico.Status = GetStatusOS((int)OSOrdemServico.StatusOS.AguardandoAnalise);
                    OSOrdemServicoController.Instancia.Salvar(osOrdemServico, Acao.Alterar);

                    AtualizarGridSeguindoConfigTela();
                    lkpOS.EditValue = null;
                }
            }
            catch (Exception exc)
            {
                new FormErro(exc).ShowDialog();
            }

        }

        private void ValidarHorariosAgendamento(OSAgendamento agendamento)
        {
            StringBuilder erros = new StringBuilder();

            if (agendamento.Inicio >= agendamento.Fim)
            {
                txtFim.Text = "";
                erros.AppendLine("- Horário de início deve ser menor que horário de fim.");
            }
            if (agendamento.Inicio.TimeOfDay.TotalHours < 6.0)
            {
                txtInicio.Text = "";
                erros.AppendLine("- Horário de início não pode ser menor do que 06:00 hrs.");
            }
            if (agendamento.Fim.TimeOfDay.TotalHours > 21.0)
            {
                txtFim.Text = "";
                erros.AppendLine("- Horário de fim não pode ser maior do que 21:00 hrs.");
            }

            if (erros.Length > 0)
                throw new Exception("Verifiquei os seguintes problemas no período de agendamento: " + Environment.NewLine + erros.ToString());
        }

        private bool ValidaAgendamento()
        {
            Exception exceptionPai = null;

            if (String.IsNullOrEmpty(txtFim.Text))
                exceptionPai = new Exception("Coloque uma hora de fim válida.", exceptionPai);

            if (String.IsNullOrEmpty(txtInicio.Text))
                exceptionPai = new Exception("Coloque uma hora de início válida.", exceptionPai);

            if (lkpTecnico.Selecionado == null)
                exceptionPai = new Exception("Selecione um Técnico.", exceptionPai);

            if (lkpOS.Selecionado == null)
                exceptionPai = new Exception("Selecione um Orçamento de Serviço.", exceptionPai);

            if (exceptionPai != null)
                throw exceptionPai;

            return true;
        }

        private void cbStatus_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarGridSeguindoConfigTela();
        }

        private void AtualizarGridSeguindoConfigTela()
        {
            OSAgendamentoController.TipoListagem tipoListagem = (OSAgendamentoController.TipoListagem)cbTipoListagem.SelectedIndex;

            gridAgendamentos.Views.DayView.DayCount = GetDiasMostrados(tipoListagem);

            TransformaAgendamentos(osAgendamentoController.GetAgendamentosDia(txtDt.DateTime, tipoListagem));

            DateTime inicio, fim;
            osAgendamentoController.SetPeriodos(tipoListagem, txtDt.DateTime, out inicio, out fim);
            gridAgendamentos.Start = inicio;
        }

        private int GetDiasMostrados(OSAgendamentoController.TipoListagem tipoListagem)
        {
            int diasMostrados;
            switch (tipoListagem)
            {
                case OSAgendamentoController.TipoListagem.UmDia:
                    diasMostrados = 1;
                    break;
                case OSAgendamentoController.TipoListagem.TresDias:
                    diasMostrados = 3;
                    break;
                case OSAgendamentoController.TipoListagem.Semanal:
                    diasMostrados = 7;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return diasMostrados;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGridSeguindoConfigTela();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            txtDt.DateTime = txtDt.DateTime + new TimeSpan(-GetDiasMostrados((OSAgendamentoController.TipoListagem)cbTipoListagem.SelectedIndex), 0, 0, 0, 0);
            AtualizarGridSeguindoConfigTela();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            txtDt.DateTime = txtDt.DateTime + new TimeSpan(GetDiasMostrados((OSAgendamentoController.TipoListagem)cbTipoListagem.SelectedIndex), 0, 0, 0, 0);
            AtualizarGridSeguindoConfigTela();
        }

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (cwkControleUsuario.Facade.ControleAcesso(this))
                {
                    OSAgendamento osAgendamento = (OSAgendamento)gridAgendamentos.SelectedAppointments.First().CustomFields["objeto"];
                    osAgendamentoController.Salvar(osAgendamento, Acao.Excluir);

                    OSOrdemServico osOrdemServico = OSOrdemServicoController.Instancia.LoadObjectById(osAgendamento.OSOrdemServico.ID);
                    osOrdemServico.Status = StatusOSController.Instancia.GetStatusTipoAgendamento();
                    OSOrdemServicoController.Instancia.Salvar(osOrdemServico, Acao.Alterar);

                    AtualizarGridSeguindoConfigTela();
                }
            }
            catch (InvalidOperationException)
            { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridAgendamentos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OSOrdemServico osOrdemServico = ((OSAgendamento)gridAgendamentos.SelectedAppointments.First().CustomFields["objeto"]).OSOrdemServico;

                new FormOSOrdemServico() { Selecionado = OSOrdemServicoController.Instancia.LoadObjectById(osOrdemServico.ID), Operacao = Acao.Alterar }.ShowDialog();
            }
            catch { }
        }

        private void lkbOS_Click(object sender, EventArgs e)
        {
            GridOSOrdemServicoGen gridOsOrdemServicoGen = new GridOSOrdemServicoGen(OSOrdemServicoController.Instancia.GetByExample(lkpOS.GetCriterion()), (OSOrdemServico)lkpOS.Selecionado, false, typeof(FormOSOrdemServico));
            gridOsOrdemServicoGen.Selecionando = true;
            gridOsOrdemServicoGen.ShowDialog();

            if (gridOsOrdemServicoGen.Selecionado != null)
            {
                lkpOS.Localizar(gridOsOrdemServicoGen.Selecionado.ID);
                lkpOS.Focus();
            }
        }

        private void lkbTecnico_Click(object sender, EventArgs e)
        {
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(cwkGestao.Negocio.PessoaController.Instancia.GetAllFuncionarios(), new FormPessoa(), (Pessoa)lkpTecnico.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpTecnico.Localizar(grid.Selecionado.ID);
            }
            lkpTecnico.Focus();
        }

        private void FormOSAgendamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, typeof(OSAgendamento).Name);
                    break;
            }
        }

        private void FormOSAgendamento_Shown(object sender, EventArgs e)
        {
            cwkControleUsuario.Facade.ControleAcesso(this);
        }
    }
}
