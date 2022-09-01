using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Util;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormApontamentoHoraServico : IntermediariasTela.FormManutBancoIntermediaria
    {
        public class DadosApontamentoHoraServico
        {
            public PessoaFuncionario Funcionario { get; set; }
            public OrdemProducao OrdemProducao { get; set; }
            private DateTime data = DateTime.Today;
            public DateTime Data
            {
                get { return data; }
                set 
                {
                    data = value;
                    horaInicio = value.AddHours(horaInicio.Hour).AddMinutes(horaInicio.Minute);
                    horaFim = value.AddHours(horaFim.Hour).AddMinutes(horaFim.Minute);
                }
            }

            public Servico Servico { get; set; }
            private DateTime horaInicio = DateTime.Today;
            public DateTime HoraInicio
            {
                get { return horaInicio; }
                set
                {
                    //if (horaFim.Year > 1 && value >= horaFim) throw new InvalidOperationException("Hora inválida");
                    horaInicio = new DateTime(data.Year, data.Month, data.Day, value.Hour, value.Minute, 0);
                    
                }
            }

            private DateTime horaFim = DateTime.Today;
            public DateTime HoraFim
            {
                get { return horaFim; }
                set
                {
                    //if (horaInicio.Year > 1 && value <= horaInicio) throw new InvalidOperationException("Hora inválida");
                    horaFim = new DateTime(data.Year, data.Month, data.Day, value.Hour, value.Minute, 0);
                }
            }

            public bool ProntoPraSalvar
            {
                get
                {
                    return Data.Year > 1800 && HoraFim.Year > 1800 && HoraInicio.Year > 1800 && HoraFim > HoraInicio &&
                           Servico != null && OrdemProducao != null;
                }
            }
        }
        private readonly List<DadosApontamentoHoraServico> apontamentos = new List<DadosApontamentoHoraServico>();

        #region Overrides

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            gcApontamentos.DataSource = apontamentos;
            lkpFuncionario.Exemplo = new Pessoa() { BFuncionario = true };
            lkpFuncionario.CamposRestricoesAND = new List<String> { "bFuncionario" };


        }
        protected override void ConfiguraGrid(DevExpress.XtraGrid.GridControl gridControl)
        {

        }
        protected override void OK()
        {
            int count = 0;
            if (VerificaRefs().Trim().Length > 0)
            {
                new FormErro(new Exception(VerificaRefs())).ShowDialog();
                return;
            }
            IList<OrdemProducaoExecucao> opes = new List<OrdemProducaoExecucao>();
            foreach (DadosApontamentoHoraServico dadosApontamentoHoraServico in apontamentos)
            {

                count++;
                opes.Add(new OrdemProducaoExecucao()
                             {
                                 Descricao = dadosApontamentoHoraServico.Servico.Nome,
                                 Quantidade = (decimal)dadosApontamentoHoraServico.HoraFim.TimeOfDay.Subtract(dadosApontamentoHoraServico.HoraInicio.TimeOfDay).TotalHours,
                                 OrdemProducao = dadosApontamentoHoraServico.OrdemProducao,
                                 Servico = dadosApontamentoHoraServico.Servico,
                                 Funcionario = dadosApontamentoHoraServico.Funcionario,
                                 DataInicio =
                                     dadosApontamentoHoraServico.Data.Add(
                                         dadosApontamentoHoraServico.HoraInicio.TimeOfDay),
                                 DataTermino =
                                     dadosApontamentoHoraServico.Data.Add(dadosApontamentoHoraServico.HoraFim.TimeOfDay),
                                 Sequencia = count
                             });

            }
            OrdemProducaoExecucaoController.Instancia.RegisterNewIntoTransaction(opes);
            OrdemProducaoExecucaoController.Instancia.CommitUnitOfWorkTransaction();
            MessageBox.Show(this,"Ordens de produção criadas com sucesso.","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            apontamentos.Clear();
            gvApontamentos.RefreshData();

        }

        private String VerificaRefs()
        {
            StringBuilder ret = new StringBuilder();
            gvApontamentos.ClearColumnErrors();
            var apontamentosBanco =
                OrdemProducaoExecucaoController.Instancia.GetApontamentos(
                    ((Pessoa) lkpFuncionario.Selecionado).PessoaFuncionarios.First());
            foreach (var y in apontamentos)
            {
                gvApontamentos.FocusedRowHandle = apontamentos.IndexOf(y);
                if (apontamentosBanco.Where(apo => (((y.HoraInicio >= apo.DataInicio && y.HoraInicio <= apo.DataTermino)
                                                            || (y.HoraFim >= apo.DataInicio && y.HoraFim <= apo.DataTermino)))).Count() > 0)
                {
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[4], "Já existem apontamentos salvos nesta faixa de horário.");
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[3], "Já existem apontamentos salvos nesta faixa de horário.");
                    ret.Append("Erro na linha " + (apontamentos.IndexOf(y) + 1 )+ ": já existem apontamentos salvos nesta faixa de horário;" + Environment.NewLine);
                }
            }

            foreach (var y in apontamentos)//.Where(ap => !ap.ProntoPraSalvar))
            {
                gvApontamentos.FocusedRowHandle = apontamentos.IndexOf(y);
                if(!y.ProntoPraSalvar)ret.Append("Erro na linha " + (apontamentos.IndexOf(y) + 1) + ": ");
                if (y.Servico == null)
                {
                    ret.Append(" selecione um serviço;");

                    gvApontamentos.SetColumnError(gvApontamentos.Columns[2], "Selecione um serviço");
                }
                if (y.OrdemProducao == null)
                {
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[0], "Selecione uma OS");
                    ret.Append(" selecione uma OS;");
                }
                if (y.Data.Year < 1800)
                {
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[1], "Selecione uma data válida");
                    ret.Append(" selecione uma data válida;");
                }
                if (y.HoraInicio >= y.HoraFim)
                {
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[4], "Selecione um horário válido");
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[3], "Selecione um horário válido");
                    ret.Append(" selecione um horário válido;");
                }
                if (apontamentos.Where(apo => apo != y &&    (((y.HoraInicio >= apo.HoraInicio && y.HoraInicio <= apo.HoraFim)
                                                            || (y.HoraFim >= apo.HoraInicio && y.HoraFim <= apo.HoraFim)))).Count() > 0)
                {
                    ret.Append("Erro na linha " + (apontamentos.IndexOf(y) + 1) + ": ");
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[4], "Existem conflitos nesta faixa de horário.");
                    gvApontamentos.SetColumnError(gvApontamentos.Columns[3], "Existem conflitos nesta faixa de horário.");
                    ret.Append(" existem conflitos em uma faixa de horário;");
                }

                ret.Append(Environment.NewLine);
            }
            gvApontamentos.RefreshData();
            
            return ret.ToString();
        }



        #endregion

        #region Eventos da Grid

        private void gvApontamentos_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName.Equals("OSCod"))
                gvApontamentos_OSColumn(sender, e);
            else if (e.Column.FieldName.Equals("ServicoCod"))
                gvApontamentos_ServicoColumn(sender, e);
        }

        private void gvApontamentos_OSColumn(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            DadosApontamentoHoraServico dahs = gvApontamentos.GetRow(e.ListSourceRowIndex) as DadosApontamentoHoraServico;
            if (e.IsGetData)
            {
                e.Value = dahs == null || dahs.OrdemProducao == null ? 0 : dahs.OrdemProducao.Codigo;
            }
            else
            {
                if (dahs != null)
                {
                    try { dahs.OrdemProducao = OrdemProducaoController.Instancia.GetByCodigo((int)e.Value); if (dahs.OrdemProducao == null) throw new InvalidOperationException(); }
                    catch (InvalidOperationException exc) { throw new InvalidOperationException("OS não encontrada.", exc); }
                }
            }
        }

        private void gvApontamentos_ServicoColumn(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            DadosApontamentoHoraServico dahs = gvApontamentos.GetRow(e.ListSourceRowIndex) as DadosApontamentoHoraServico;
            if (e.IsGetData)
            {
                e.Value = dahs == null || dahs.Servico == null ? "0" : (dahs.Servico.Codigo + " - " + dahs.Servico.Nome);
            }
            else
            {
                if (dahs != null)
                {
                    try { dahs.Servico = ServicoController.Instancia.GetByCodigo((int)e.Value); if (dahs.Servico == null) throw new InvalidOperationException(); }
                    catch (InvalidOperationException exc) { throw new InvalidOperationException("Serviço não encontrado.", exc); }
                }
            }
        }

        private void gvApontamentos_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            switch (e.KeyData)
            {
                case Keys.Insert:
                    InsereNovaLinha();
                    break;
              
                default:
                    gcApontamentos_EditorKeyUp(sender, e);
                    break;
            }

        }

        private void InsereNovaLinha()
        {
            if (lkpFuncionario.Selecionado == null)
            {
                MessageBox.Show("Selecione um funcionário.");
                return;
            }
            apontamentos.Add(new DadosApontamentoHoraServico { Funcionario = ((Pessoa)lkpFuncionario.Selecionado).PessoaFuncionarios[0] });
            gvApontamentos.Focus();
            gvApontamentos.RefreshData();
            gvApontamentos.MoveLastVisible();
            gvApontamentos.FocusedColumn = gvApontamentos.Columns[0];
            SendKeys.Send("{ENTER}");
        }


        private void gcApontamentos_EditorKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                if (gvApontamentos.FocusedColumn.FieldName.Equals("OSCod"))
                {
                    SetOs();
                }
                else if (gvApontamentos.FocusedColumn.FieldName.Equals("ServicoCod"))
                {
                    SetServico();
                }
                gvApontamentos.RefreshData();
            }
            else if (e.Control && e.KeyCode == Keys.Delete)
            {
                apontamentos.Remove((DadosApontamentoHoraServico)gvApontamentos.GetRow(gvApontamentos.GetSelectedRows()[0]));
                gvApontamentos.RefreshData();
                gvApontamentos.MoveLastVisible();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                if (lkpFuncionario.Selecionado == null)
                {
                    MessageBox.Show("Selecione um funcionário.");
                    return;
                }
                apontamentos.Add(new DadosApontamentoHoraServico { Funcionario = ((Pessoa)lkpFuncionario.Selecionado).PessoaFuncionarios[0], HoraInicio = new DateTime(1, 1, 1), HoraFim = new DateTime(1, 1, 1) });
                gvApontamentos.RefreshData();
                gvApontamentos.MoveLastVisible();
                //gvApontamentos.FocusedColumn = gvApontamentos.Columns[1];
                gvApontamentos.FocusedColumn = gvApontamentos.Columns[0];
                //SendKeys.Send("{ENTER}");
            }
            e.Handled = true;

        }

        #endregion

        #region Evento dos Botoes
        private void lkbFuncionario_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpFuncionario, PessoaController.Instancia.GetAllFuncionarios(), "Funcionário", typeof(FormPessoa));
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            InsereNovaLinha();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gvApontamentos.Focus();
            gvApontamentos.FocusedColumn = gvApontamentos.Columns[0];
            SendKeys.Send("{ENTER}");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            gcApontamentos_EditorKeyUp(null, new KeyEventArgs(Keys.Delete | Keys.Control));
        }
        #endregion

        #region Metodos

        private void SetOs()
        {
            MessageBox.Show("Tela não implementada no hibernate");
            /*GridGenerica<OrdemProducao> grid = new GridGenerica<OrdemProducao>(OrdemProducaoController.Instancia.GetAll(), null) { Selecionando = true };
            grid.ShowDialog();
            if (grid.Selecionado != null)
                ((DadosApontamentoHoraServico)gvApontamentos.GetRow(gvApontamentos.GetSelectedRows()[0])).OrdemProducao =
                    grid.Selecionado;*/
        }

        private void SetServico()
        {
            GridGenerica<Servico> grid = new GridGenerica<Servico>(ServicoController.Instancia.GetAll(), new FormServico(), false) { Selecionando = true };
            grid.RemoveColuna("Valor");
            grid.ShowDialog();
            if (grid.Selecionado != null)
                ((DadosApontamentoHoraServico)gvApontamentos.GetRow(gvApontamentos.GetSelectedRows()[0])).Servico =
                    grid.Selecionado;
        }

        #endregion

        private void gvApontamentos_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void FormApontamentoHoraServico_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //retorno = "";
                    this.Close();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Apontamento");
                    break;
            }
        }
    }
}
