using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using System.Collections;
using System.Linq;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Views.Grid;

namespace Aplicacao
{
    public partial class FormFaturamentoAtendimento : Aplicacao.IntermediariasTela.FormManutFaturamentoAtendimentoIntermediaria
    {
        private IList<FaturamentoAtendimento> faturamentos;
        public FormFaturamentoAtendimento(IList<FaturamentoAtendimento> fatAtendimentos)
        {
            faturamentos = fatAtendimentos;
            gcFaturamentoAtendimentos.DataSource = faturamentos;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            sbGravar.Text = "Confirmar";
            lkpServico.DataSource = ServicoController.Instancia.GetAll();
        }

        #region Eventos

        #region Grid

        private void gvFaturamentoAtendimentos_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row == null)
            {
                e.Valid = false;
                return;
            }

            GridView gv = (GridView)sender;
            gv.ClearColumnErrors();
            gv.CloseEditor();

            FaturamentoAtendimento fatSelecionado = GetRegistrosSelecionados().FirstOrDefault();

            if (fatSelecionado.Servico == null)
            {
                gvFaturamentoAtendimentos.SetColumnError(gclServico, "O Serviço é obrigatório. Verifique.");
            }
            if (fatSelecionado.Cliente.ValorHoraAtendimento <= 0)
            {
                gvFaturamentoAtendimentos.SetColumnError(gclCliente, "O Valor/Hora de Atendimento não pode ser zero. Verifique no cadastro do cliente.");
                gvFaturamentoAtendimentos.SetColumnError(gclValor, "O Valor/Hora de Atendimento não pode ser zero. Verifique no cadastro do cliente.");
            }

            e.Valid = !gv.HasColumnErrors;
        }

        private void gvFaturamentoAtendimentos_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            GridView gv = (GridView)sender;
            FaturamentoAtendimento fat = GetRegistrosSelecionados().FirstOrDefault();
            gvFaturamentoAtendimentos_ValidateRow(sender, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(e.RowHandle, fat));
            e.Allow = !gv.HasColumnErrors;
        }

        private void gcFaturamentoAtendimentos_Leave(object sender, EventArgs e)
        {
            faturamentos = (IList<FaturamentoAtendimento>)gcFaturamentoAtendimentos.DataSource;
            for (int i = 0; i < faturamentos.Count; i++)
            {
                FaturamentoAtendimento fat = faturamentos[i];
                gvFaturamentoAtendimentos_ValidateRow(gvFaturamentoAtendimentos, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(i, fat));
            }
        }

        private void gvFaturamentoAtendimentos_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        #endregion

        #endregion

        #region Métodos Auxiliares

        private IList<FaturamentoAtendimento> GetRegistrosSelecionados()
        {
            try
            {
                IList<FaturamentoAtendimento> retorno = new List<FaturamentoAtendimento>();
                int[] linhas = gvFaturamentoAtendimentos.GetSelectedRows();

                foreach (int linha in linhas)
                {
                    FaturamentoAtendimento objeto = ((FaturamentoAtendimento)gvFaturamentoAtendimentos.GetRow(linha));
                    retorno.Add(objeto);
                }
                if (retorno == null)
                {
                    retorno = new List<FaturamentoAtendimento>() { (FaturamentoAtendimento)gvFaturamentoAtendimentos.GetRow(0) };
                    gvFaturamentoAtendimentos.SelectRow(0);
                }
                else if (retorno.Count == 0 && gvFaturamentoAtendimentos.RowCount > 0)
                {
                    retorno.Add((FaturamentoAtendimento)gvFaturamentoAtendimentos.GetRow(0));
                    gvFaturamentoAtendimentos.SelectRow(0);
                }
                return retorno;
            }
            catch (Exception e)
            {
                if (gvFaturamentoAtendimentos.RowCount > 0)
                {
                    try
                    {
                        List<FaturamentoAtendimento> lista = new List<FaturamentoAtendimento>() { (FaturamentoAtendimento)gvFaturamentoAtendimentos.GetRow(0) };
                        gvFaturamentoAtendimentos.SelectRow(0);
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

        protected override bool ValidarFormulario()
        {
            IList<FaturamentoAtendimento> fats = (List<FaturamentoAtendimento>)gcFaturamentoAtendimentos.DataSource;
            for (int i = 0; i < fats.Count; i++)
            {
                gvFaturamentoAtendimentos_ValidateRow(gvFaturamentoAtendimentos, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(i, fats[i]));
            }
            return !gvFaturamentoAtendimentos.HasColumnErrors;
        }

        protected override void OK()
        {
            IList<FaturamentoAtendimento> fats = ((List<FaturamentoAtendimento>)gcFaturamentoAtendimentos.DataSource).Where(s => s.Selecionado == true).ToList();

            if (fats.Count == 0)
            {
                MessageBox.Show("Não há atendimentos selecionados para faturar. Verifique.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                  if (ValidarFormulario())
                  {
                      IList<FaturamentoAtendimento> fatsOK = new List<FaturamentoAtendimento>();
                      StringBuilder erros = new StringBuilder();
                      foreach (FaturamentoAtendimento item in fats)
                      {
                          try
                          {
                              FaturamentoAtendimentoController.Instancia.Salvar(item, Acao.Incluir);
                              fatsOK.Add(item);
                          }
                          catch (Exception e)
                          {
                              erros.AppendLine("Cliente: " + item.Cliente.Nome + " - " + e.Message);
                          }
                      }
                      try
                      {
                          //MessageBox.Show("Rotina de Faturamento Aqui.");
                          OSOrdemServicoController.Instancia.FaturarAtendimentos(ref fatsOK);
                      }
                      catch (Exception e)
                      {
                          erros.AppendLine(e.Message);
                      }
                      if (erros.Length > 0)
                      {
                          MessageBox.Show("Aconteceram erros na rotina de faturamento, e alguns Atendimentos não foram faturados:\r\n\r\n"
                              + erros.ToString() + "\r\n" + "Será necessário refazer a rotina.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          gcFaturamentoAtendimentos.DataSource = fatsOK.Where(w => w.ID == 0).ToList();
                          gcFaturamentoAtendimentos.RefreshDataSource();
                          return;
                      }
                  }
                this.Close();
            }
        }

        #endregion
    }
}
