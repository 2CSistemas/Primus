using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using Aplicacao.Modulos.Contratos;
using System.Collections;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.Data;
using DevExpress.XtraGrid;	

namespace Aplicacao
{
    public partial class FormAtendimento : Aplicacao.IntermediariasTela.FormManutAtendimentoIntermediaria
    {

        private IList<Atendimento> Atendimentos;
        private Atendimento AtendimentoSelecionado;
        private IList<Pessoa> Clientes;
        private IList<StatusAtendimento> ListaStatus;
        private Cw_usuario AnalistaSelecionado;
        private Cw_usuario AnalistaLogado;
        private bool habilitaIncluir;
        private bool habilitaExcluir;
        private bool habilitaLiberarFaturamento;
        protected string textoFiltroCabecalhoRel { get; set; }
        private bool habilitaFaturamento;

        public FormAtendimento()
        {
            Atendimentos = new List<Atendimento>();
            Clientes = PessoaController.Instancia.GetAllClientes();
            ListaStatus = StatusAtendimentoController.Instancia.GetAll();

            int id = cwkControleUsuario.Facade.getUsuarioLogado.Id;
            AnalistaSelecionado = Cw_usuarioController.Instancia.LoadObjectById(id);
            AnalistaLogado = Cw_usuarioController.Instancia.LoadObjectById(id);
            if (AnalistaSelecionado == null)
            {
                AnalistaSelecionado = Cw_usuarioController.Instancia.FindByLogin("admin");
                AnalistaLogado = Cw_usuarioController.Instancia.FindByLogin("admin");
            }
            lkpAnalista.Exemplo = new Cw_usuario();
            lkpAnalista.CamposRestricoesAND = new List<string>();
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
        }

        #region Eventos

        #region Grid

        private void gvAtendimentos_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            TimeSpan retorno;
            if (e.Row == null)
            {
                e.Valid = false;
                return;
            }
            GridView gv = (GridView)sender;
            
            gv.ClearColumnErrors();
            Atendimento AtendimentoSelecionado = GetAtendimentosSelecionados().FirstOrDefault();

            if (AtendimentoSelecionado.Entrada_1 == TimeSpan.Zero &&
                AtendimentoSelecionado.Saida_1 == TimeSpan.Zero &&
                AtendimentoSelecionado.Entrada_2 == TimeSpan.Zero &&
                AtendimentoSelecionado.Saida_2 == TimeSpan.Zero)
            {
                gv.SetColumnError(gclEnt1, "É obrigatória a indicação de pelo menos um período de Atedimento. Verifique.");
                gv.SetColumnError(gclSai1, "É obrigatória a indicação de pelo menos um período de Atedimento. Verifique.");
            }

            if (AtendimentoSelecionado.TotalHoras.TotalHours > 24)
            {
                gv.SetColumnError(gclEnt1, "Um atendimento não pode possuir mais de 24 horas. Verifique.");
                gv.SetColumnError(gclSai1, "Um atendimento não pode possuir mais de 24 horas. Verifique.");
                gv.SetColumnError(gclEnt2, "Um atendimento não pode possuir mais de 24 horas. Verifique.");
                gv.SetColumnError(gclSai2, "Um atendimento não pode possuir mais de 24 horas. Verifique.");
            }

            if (String.IsNullOrEmpty(AtendimentoSelecionado.Descricao))
            {
                gv.SetColumnError(gclDescricao, "A Descrição do atendimento é obrigatória. Verifique");
            }

            if (AtendimentoSelecionado.Cliente == null)
            {
                gv.SetColumnError(gclCliente, "Cliente é obrigatório. Verifique");
            }

            if (AtendimentoSelecionado.Status == null)
            {
                gv.SetColumnError(gclStatusAtendimento, "Status do Atendimento é obrigatório. Verifique");
            }

            e.Valid = !gv.HasColumnErrors;
            gv.CloseEditor();
            if (e.Valid)
            {
                try
                {
                    if (AtendimentoSelecionado.ID == 0)
                    {
                        //Código inserido porque algumas informações do Cliente não estão sendo carregadas
                        Pessoa cliente = PessoaController.Instancia.LoadObjectById(AtendimentoSelecionado.Cliente.ID);
                        if (cliente.bFaturarPorPadrao == true)
                            AtendimentoSelecionado.Faturar = true;
                        AtendimentoSelecionado.Cliente = cliente;
                        AtendimentoController.Instancia.Salvar(AtendimentoSelecionado, Acao.Incluir);
                    }
                    else
                    {
                        Pessoa clienteAntigo = AtendimentoController.Instancia.LoadObjectById(AtendimentoSelecionado.ID).Cliente;
                        AtendimentoSelecionado.Cliente = PessoaController.Instancia.LoadObjectById(AtendimentoSelecionado.Cliente.ID);
                        if (clienteAntigo.ID != AtendimentoSelecionado.Cliente.ID)
                        {
                            if (AtendimentoSelecionado.Cliente.bFaturarPorPadrao == true)
                                AtendimentoSelecionado.Faturar = true;
                        }

                        if ((AtendimentoSelecionado.FatAtendimento != null) && (AtendimentoSelecionado.FatAtendimento.ID == 0))
                        {
                            if (AtendimentoSelecionado.FatAtendimento.Servico == null)
                                AtendimentoSelecionado.FatAtendimento.Servico = clienteAntigo.ServicoAtendimento;
                            
                            FaturamentoAtendimentoController.Instancia.Salvar(AtendimentoSelecionado.FatAtendimento, Acao.Incluir);
                        }
                        
                        AtendimentoController.Instancia.Salvar(AtendimentoSelecionado, Acao.Alterar);
                    }
                }
                catch (Exception g)
                {
                    new Aplicacao.Base.FormErro(g).ShowDialog();
                }
            }
        }

        private void gvAtendimentos_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gvAtendimentos_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            GridView gv = (GridView)sender;
            AtendimentoSelecionado = GetAtendimentosSelecionados().FirstOrDefault();
            gvAtendimentos_ValidateRow(sender, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(e.RowHandle, AtendimentoSelecionado));
            e.Allow = !gv.HasColumnErrors;
        }

        void ColumnEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            throw new NotImplementedException();
        }

        void SetarValorHoraFat(Atendimento AtendimentoSelecionado)
        {
            AtendimentoSelecionado.TotalHorasFat = AtendimentoSelecionado.TotalHoras;
        }
     
        private void gvAtendimentos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            GridView gv = (GridView)sender;
            if (gv.SelectedRowsCount > 1)
            {
                HabilitarBotoesMultiSelect(false);
            }
            else
            {
                HabilitarBotoesMultiSelect(true);
            }
        }

        private void gcAtendimentos_Leave(object sender, EventArgs e)
        {
            int[] rows = gvAtendimentos.GetSelectedRows();
            if (rows.Count() > 0)
            {
                foreach (int row in rows)
                {
                    AtendimentoSelecionado = (Atendimento)gvAtendimentos.GetRow(row);
                    gvAtendimentos_ValidateRow(gvAtendimentos, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(row, AtendimentoSelecionado));
                }
            }
        }

        private void gvAtendimentos_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                AtendimentoSelecionado = GetAtendimentosSelecionados().FirstOrDefault();
                Pessoa cliente = new Pessoa();
                if (AtendimentoSelecionado.Nota != null)
                {
                    //MessageBox.Show("Não é possível alterar um Atendimento já faturado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    if ((view.FocusedColumn != gclFaturar) && (AtendimentoSelecionado.Faturar))
                    {
                        if (AtendimentoSelecionado != null)
                        {
                            cliente = PessoaController.Instancia.LoadObjectById(AtendimentoSelecionado.Cliente.ID);
                            if (((view.FocusedColumn.FieldName == "DtConferencia") &&
                                 (cliente.bFaturarPorPadrao) &&
                                 (AnalistaLogado.Tipo != TipoUsuario.Operador)))
                            {
                                e.Cancel = false;
                            }
                            else
                            {
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Não é possível alterar um Atendimento marcado para faturamento. Verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                   
                }
                
            }
            catch (Exception f)
            {
                e.Cancel = false;
                throw f;
            }
        }

        #endregion

        #region Botões

        private void sbImprimirOS_Click(object sender, EventArgs e)
        {
            FormImprimiOS form = new FormImprimiOS();
            form.ShowDialog();
        }

        private void sbImprimirFiltro_Click(object sender, EventArgs e)
        {
            ImprimirFiltro();
        }

        private void sbConferirAtendimentos_Click(object sender, EventArgs e)
        {
            IList<GridColumn> colunas = new List<GridColumn>() { gclDtConferencia, gclDescricao };
            if (sbConferirAtendimentos.Text.ToLower().Contains("conferir"))
            {
                HabilitarColunas(colunas, true);
                sbConferirAtendimentos.Text = "Bloquear Conferência";
                sbConferirAtendimentos.Image = Aplicacao.Properties.Resources.cancelar_copy;
            }
            else
            {
                HabilitarColunas(colunas, false);
                sbConferirAtendimentos.Text = "Conferir Atendimentos";
                sbConferirAtendimentos.Image = Aplicacao.Properties.Resources.Modify;
            }
        }

        private void sbLiberarFaturamento_Click(object sender, EventArgs e)
        {
            IList<GridColumn> colunas = new List<GridColumn>() { gclFaturar };
            if (sbLiberarFaturamento.Text.ToLower().Contains("liberar"))
            {
                HabilitarColunas(colunas, true);
                sbLiberarFaturamento.Text = "Bloquear Faturamentos";
                sbLiberarFaturamento.Image = Aplicacao.Properties.Resources.cancelar_copy;
                sbSelecionarFaturamento.Enabled = true;
            }
            else
            {
                HabilitarColunas(colunas, false);
                sbLiberarFaturamento.Text = "Liberar Faturamentos";
                sbLiberarFaturamento.Image = Aplicacao.Properties.Resources.Selecionar_copy;
                sbSelecionarFaturamento.Enabled = false;
            }
        }

        private void sbFaturar_Click(object sender, EventArgs e)
        {
            Atendimentos = ((IList<Atendimento>)gcAtendimentos.DataSource).Where(n => n.Nota == null).ToList();
            IList<FaturamentoAtendimento> faturamentos = FaturamentoAtendimentoController.Instancia.GetFaturamentoAtendimentos(Atendimentos);

            if (Atendimentos == null)
            {
                MessageBox.Show("Não existem atendimentos filtrados para faturar. Verifique.", 
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((Atendimentos.Count == 0) || (faturamentos.Count == 0))
            {
                MessageBox.Show("Não existem atendimentos filtrados para faturar ou o cliente não possui serviço vinculado. Verifique.", 
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            for (int i = 0; i < Atendimentos.Count; i++)
            {
                gvAtendimentos_ValidateRow(gvAtendimentos, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(i, Atendimentos[i]));
            }
            if (gvAtendimentos.HasColumnErrors)
            {
                MessageBox.Show("Existem atendimentos incorretos na tabela. A correção é necessária antes de prosseguir com a rotina de faturamento. Verifique",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IList<Atendimento> AtendimentosSemDtConferencia = Atendimentos.Where(w => w.Faturar == true && w.DtConferencia == null).ToList();
            if (AtendimentosSemDtConferencia.Count > 0)
            {
                MessageBox.Show("Existem Atendimentos marcados para faturamento que não foram conferidos. Verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja faturar os Atendimentos filtrados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }

            FormFaturamentoAtendimento form = new FormFaturamentoAtendimento(faturamentos);
            form.ShowDialog();
            sbFiltrar_Click(sbFiltrar, new EventArgs());
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            if (Atendimentos == null)
            {
                Atendimentos = new List<Atendimento>();
            }
            Atendimentos.Add(new Atendimento() { Analista = AnalistaSelecionado == null ? AnalistaLogado : AnalistaSelecionado });
            AtualizaGrid();
        }

        private void sbExcluir_Click(object sender, EventArgs e)
        {
            AtendimentoSelecionado = GetAtendimentosSelecionados().FirstOrDefault();
            if (AtendimentoSelecionado == null)
            {
                MessageBox.Show("Selecione um Atendimento para excluir. Verifique.",
                    "Excluindo um Atendimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (AtendimentoSelecionado.Nota != null)
            {
                MessageBox.Show("O atendimento não pode ser excluído pois já foi faturado. Verifique.",
                    "Excluindo um Atendimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Você tem certeza que deseja excluir este atendimento?", "Excluindo um Atendimento", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }
            else
            {
                Atendimentos.Remove(AtendimentoSelecionado);
                if (AtendimentoSelecionado.ID > 0)
                {
                    AtendimentoController.Instancia.Salvar(AtendimentoSelecionado, Acao.Excluir);
                }
                AtualizaGrid();
            }
        }

        private void sbFiltrar_Click(object sender, EventArgs e)
        {
            dxErroProvider.ClearErrors();
            if (deDataInicial.DateTime > deDataFinal.DateTime)
            {
                dxErroProvider.SetError(deDataFinal, "A data final do período não pode ser menor que a data inicial. Verifique.");
                return;
            }
            Atendimentos = AtendimentoController.Instancia.GetAllByAnalistaPeriodoEFaturados(AnalistaSelecionado, 
                deDataInicial.DateTime, deDataFinal.DateTime, chbConsiderarFaturado.Checked);
            AtualizaGrid();
        }

        private void lkbAnalista_Click(object sender, EventArgs e)
        {
            if (AnalistaLogado.Tipo != TipoUsuario.Operador)
            {
                GridGenerica<Cw_usuario> grid = new GridGenerica<Cw_usuario>(Cw_usuarioController.Instancia.GetAll(), null, AnalistaLogado, false);
                grid.Selecionando = true;
                grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Incluir);
                grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Alterar);
                grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Excluir);
                grid.DesabilitarBotoes(GridGenerica<Cw_usuario>.Botao.Consultar);
                grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Incluir);
                grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Alterar);
                grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Excluir);
                grid.EsconderBotoes(GridGenerica<Cw_usuario>.Botao.Consultar);
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkpAnalista.EditValue = AnalistaSelecionado = Cw_usuarioController.Instancia.LoadObjectById(grid.Selecionado.ID);
                    lkpAnalista.Focus();
                }
            }
        }

        #endregion

        #region Tela

        private void FormAtendimento_Shown(object sender, EventArgs e)
        {
            // "workaround" necessário para resolver um bug de MDI Parent/Child
            // que não permite o form filho abrir maximizado dentro de um conteiner MDI 
            // (o MDI mostra maximizado, enquanto o form não está maximizado na verdade)
            // não remover a linha abaixo, à não ser que saia uma correção do framework para isso
            MaximizaForm();
            //
            lkpAnalista.EditValue = AnalistaSelecionado;
            if (AnalistaSelecionado.Tipo == TipoUsuario.Operador)
            {
                lkpAnalista.Enabled = lkbAnalista.Enabled = false;
            }
            deDataInicial.DateTime = DateTime.Now.AddMonths(-3);
            deDataFinal.DateTime = DateTime.Now;
            lkpCliente.DataSource = Clientes;
            lkpStatus.DataSource = ListaStatus;
            TratarTela();
            sbSelecionarFaturamento.Enabled = false;
            habilitaIncluir = sbIncluir.Enabled;
            habilitaExcluir = sbExcluir.Enabled;
            habilitaLiberarFaturamento = sbLiberarFaturamento.Enabled;
            //sbFaturar.Enabled = false; //retirar esta linha depois que a rotina de faturamento de atendimento estiver OK
            habilitaFaturamento = sbFaturar.Enabled;
            //sbFaturar.Visible = false;//retirar esta linha depois que a rotina de faturamento de atendimento estiver OK
        }

        private void FormAtendimento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, this.Text);
                    break;
                default:
                    break;
            }
        }

        private void lkpAnalista_Leave(object sender, EventArgs e)
        {
            AnalistaSelecionado = (Cw_usuario)lkpAnalista.Selecionado;
        }

        #endregion

        #endregion

        #region Métodos Auxiliares

        private void HabilitarBotoesMultiSelect(bool p)
        {
            // verifica se o botão não foi previamente desabilitado pelo controle de usuario
            // para não alterar conforme as seleções são realizadas
            if (habilitaIncluir)
            {
                sbIncluir.Enabled = p;                
            }
            if (habilitaExcluir)
            {
                sbExcluir.Enabled = p;
            }
            if (habilitaLiberarFaturamento)
            {
                sbLiberarFaturamento.Enabled = p;
            }
            if (habilitaFaturamento)
            {
                sbFaturar.Enabled = p;
            }
        }

        private void HabilitarColunas(IList<GridColumn> colunas, bool p)
        {
            foreach (GridColumn coluna in colunas)
            {
                coluna.OptionsColumn.AllowEdit = p;
                coluna.OptionsColumn.AllowFocus = p;
            }
        }

        protected override void TratarTela()
        {
            switch (AnalistaLogado.Tipo)
            {
                case TipoUsuario.Administrador:
                    TratamentoTelaAdministrador();
                    break;
                case TipoUsuario.Operador:
                    TratamentoTelaOperador();
                    break;
                case TipoUsuario.Gerente:
                    TratamentoTelaGerente();
                    break;
                default:
                    break;
            }
        }

        private void TratamentoTelaAdministrador()
        {
            gclTotalHorasFat.OptionsColumn.AllowEdit = true;
            gclTotalHorasFat.OptionsColumn.AllowFocus = true;
            gclTotalHorasFat.OptionsColumn.ReadOnly = false;        
        }

        private void TratamentoTelaGerente()
        {
            //tratamentos para permitir edição das colunas de "Data de Conferência" e "Faturar?"
            foreach (GridColumn item in gvAtendimentos.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
                item.OptionsColumn.AllowFocus = false;
                gclDtConferencia.OptionsColumn.AllowEdit = true;
                gclFaturar.OptionsColumn.AllowEdit = true;
                gclTotalHorasFat.OptionsColumn.AllowEdit = true;
                gclTotalHorasFat.OptionsColumn.AllowFocus = true;
                gclTotalHorasFat.OptionsColumn.ReadOnly = false;   
            }
        }

        private void TratamentoTelaOperador()
        {
            //adicionar tratamentos para não permitir edição das colunas de "Data de Conferência" e "Faturar?"
            lkpAnalista.Enabled = lkbAnalista.Enabled = false;
            gclDtConferencia.OptionsColumn.AllowEdit = false;
            gclDtConferencia.OptionsColumn.AllowFocus = false;
            gclFaturar.OptionsColumn.AllowEdit = false;
            gclFaturar.OptionsColumn.AllowFocus = false;
            gclTotalHorasFat.OptionsColumn.AllowEdit = false;
            gclTotalHorasFat.OptionsColumn.AllowFocus = false;
            gclTotalHorasFat.OptionsColumn.ReadOnly = true;
        }

        private void MaximizaForm()
        {
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
            this.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AtualizaGrid()
        {
            gcAtendimentos.DataSource = Atendimentos;
            gcAtendimentos.RefreshDataSource();
            gcAtendimentos.Refresh();
            gvAtendimentos.ClearColumnErrors();
        }

        private IList<Atendimento> GetAtendimentosSelecionados()
        {
            try
            {
                IList<Atendimento> retorno = new List<Atendimento>();
                int[] linhas = gvAtendimentos.GetSelectedRows();
                
                foreach (int linha in linhas)
                {
                    Atendimento objeto = ((Atendimento)gvAtendimentos.GetRow(linha));
                    retorno.Add(objeto);
                }
                if (retorno == null)
                {
                    retorno = new List<Atendimento>(){ (Atendimento)gvAtendimentos.GetRow(0) };
                    gvAtendimentos.SelectRow(0);
                }
                else if (retorno.Count == 0 && gvAtendimentos.RowCount > 0)
                {
                    retorno.Add((Atendimento)gvAtendimentos.GetRow(0));
                    gvAtendimentos.SelectRow(0);
                }
                return retorno;
            }
            catch (Exception e)
            {
                if (gvAtendimentos.RowCount > 0)
                {
                    try
                    {
                        List<Atendimento> lista =  new List<Atendimento>(){ (Atendimento)gvAtendimentos.GetRow(0) };
                        gvAtendimentos.SelectRow(0);
                        return lista;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    throw e;
                }
            }
        }

        #endregion

        #region Imprimir Filtro
        private void ImprimirFiltro()
        {
            printableComponentLink1.Landscape = true;
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }

        private void printableComponentLink1_CreateMarginalHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            DevExpress.XtraPrinting.TextBrick brick = new TextBrick();

            string dtInicialStr = deDataInicial == null ? "" : deDataInicial.Text;
            string dtFinalStr = deDataFinal == null ? "" : deDataInicial.Text;
            textoFiltroCabecalhoRel = (((Cw_usuario)lkpAnalista.Selecionado).Nome.ToUpper()) + "; " + dtInicialStr + " à " + dtFinalStr;
            string dataAtualStr = DateTime.Today.ToLongDateString();
            string[] rows = { this.Text, textoFiltroCabecalhoRel, dataAtualStr };

            for (int i = 0; i < rows.Count(); i++)
            {
                if (i == 0)
                {
                    brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(0, 0, 500, 40),
                                               DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 16);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Center);
                }
                else if (i == 1)
                {
                    string filtro = rows[i];
                    for (int contador = 0; contador < 7; contador++)
                    {
                        filtro = TrataFiltro(filtro);
                    }
                    brick = e.Graph.DrawString("Filtro: " + filtro, Color.Black, new RectangleF(0, 32, 800, 40),
                                               DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 9);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Near);
                }
                else if (i == 2)
                {
                    brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(750, 32, 230, 40),
                       DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 9);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Far);
                }
            }
        }

        private static string TrataFiltro(string filtro)
        {
            if (filtro.Contains("Like"))
            {
                filtro = filtro.Replace("Like", "contendo");
            }
            else if (filtro.Contains("Between"))
            {
                filtro = filtro.Replace("Between", "entre");
            }
            else if (filtro.Contains("Not"))
            {
                filtro = filtro.Replace("Not", "Sem");
            }
            else if (filtro.Contains("Is Null"))
            {
                filtro = filtro.Replace("Is Null", "é nulo");
            }
            else if (filtro.Contains("Is Not Null"))
            {
                filtro = filtro.Replace("Is Not Null", "não é nulo");
            }
            else if (filtro.Contains("In"))
            {
                filtro = filtro.Replace("In", "em");
            }
            else if (filtro.Contains("And"))
            {
                filtro = filtro.Replace("And", "e");
            }
            return filtro;
        }
        #endregion


        private void AlterarSelecaoAtendimentos(bool p)
        {
            var lista = gcAtendimentos.DataSource;
            if (lista != null)
            {
                if (p == true)
                {
                    foreach (var itemSelecionado in (List<Atendimento>)lista)
                    {
                        itemSelecionado.Faturar = true;
                    }
                }
                else
                {
                    foreach (var itemSelecionado in (List<Atendimento>)lista)
                    {
                        itemSelecionado.Faturar = false;
                    }
                }

            }
            gcAtendimentos.RefreshDataSource();
        }
       
        private void sbSelecionarFaturamento_Click(object sender, EventArgs e)
        {
            IList<GridColumn> colunas = new List<GridColumn>() { gclFaturar };
            if (sbSelecionarFaturamento.Text.ToLower().Contains("selecionar"))
            {
                AlterarSelecaoAtendimentos(true);
                sbSelecionarFaturamento.Text = "Desmarcar Todos";
                sbSelecionarFaturamento.Image = Aplicacao.Properties.Resources.cancelar_copy;
            }
            else
            {
                AlterarSelecaoAtendimentos(false);
                sbSelecionarFaturamento.Text = "Selecionar Todos";
                sbSelecionarFaturamento.Image = Aplicacao.Properties.Resources.Modify;
            }

        }

        private void gvAtendimentos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            TimeSpan tsAlterado = new TimeSpan();
            TimeSpan horarioCalculado = new TimeSpan();
            int handle = gvAtendimentos.GetSelectedRows().FirstOrDefault();
            switch (e.Column.Name)
            {
                case "gclEnt1":
                    if(TimeSpan.TryParse(Convert.ToDateTime(e.Value).ToLongTimeString(), out tsAlterado))
                    {
                        horarioCalculado = CalculaHorario(tsAlterado, AtendimentoSelecionado.Saida_1, AtendimentoSelecionado.Entrada_2, AtendimentoSelecionado.Saida_2);
                        AtendimentoSelecionado.TotalHoras = horarioCalculado;
                        AtendimentoSelecionado.TotalHorasFat = horarioCalculado;
                    }
                    break;
                case "gclEnt2":
                    if(TimeSpan.TryParse(Convert.ToDateTime(e.Value).ToLongTimeString(), out tsAlterado))
                    {
                        horarioCalculado = CalculaHorario(AtendimentoSelecionado.Entrada_1, AtendimentoSelecionado.Saida_1, tsAlterado, AtendimentoSelecionado.Saida_2);
                        AtendimentoSelecionado.TotalHoras = horarioCalculado;
                        AtendimentoSelecionado.TotalHorasFat = horarioCalculado;
                    }
                    break;
                case "gclSai1":
                    if(TimeSpan.TryParse(Convert.ToDateTime(e.Value).ToLongTimeString(), out tsAlterado))
                    {
                        horarioCalculado = CalculaHorario(AtendimentoSelecionado.Entrada_1, tsAlterado, AtendimentoSelecionado.Entrada_2, AtendimentoSelecionado.Saida_2);
                        AtendimentoSelecionado.TotalHoras = horarioCalculado;
                        AtendimentoSelecionado.TotalHorasFat = horarioCalculado;
                    }
                    break;
                case "gclSai2":
                    if(TimeSpan.TryParse(Convert.ToDateTime(e.Value).ToLongTimeString(), out tsAlterado))
                    {
                        horarioCalculado = CalculaHorario(AtendimentoSelecionado.Entrada_1, AtendimentoSelecionado.Saida_1, AtendimentoSelecionado.Entrada_2, tsAlterado);
                        AtendimentoSelecionado.TotalHoras = horarioCalculado;
                        AtendimentoSelecionado.TotalHorasFat = horarioCalculado;
                    }
                    break;
            }
        }

        public TimeSpan CalculaHorario(TimeSpan Entrada_1, TimeSpan Saida_1, TimeSpan Entrada_2, TimeSpan Saida_2)
        {
            TimeSpan horario01 = new TimeSpan();
            TimeSpan horario02 = new TimeSpan();
            TimeSpan e1 = new TimeSpan();
            TimeSpan e2 = new TimeSpan();
            TimeSpan s1 = new TimeSpan();
            TimeSpan s2 = new TimeSpan();
            if (Entrada_1 > Saida_1)
            {
                e1 = Entrada_1 - new TimeSpan(12, 00, 00);
                s1 = Saida_1 + new TimeSpan(12, 00, 00);
                horario01 = (s1.Duration() - e1.Duration());
            }
            else
            {
                horario01 = Saida_1 - Entrada_1;
            }

            if (Entrada_2 > Saida_2)
            {
                e2 = Entrada_2 - new TimeSpan(12, 00, 00);
                s2 = Saida_2 + new TimeSpan(12, 00, 00);
                horario02 = (s2.Duration() - e2.Duration());
            }
            else
            {
                horario02 = Saida_2 - Entrada_2;
            }

            return (horario01 + horario02);
        }

    }
}
