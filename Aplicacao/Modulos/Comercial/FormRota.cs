using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace Aplicacao
{
    public partial class FormRota : Aplicacao.IntermediariasTela.FormManutRotaIntermediaria
    {
        private IList<Pessoa> Clientes;
        private IList<Pessoa> Funcionarios;
        public FormRota(Rota selecionado)
        {
            Clientes = PessoaController.Instancia.GetAllClientes();
            Funcionarios = PessoaController.Instancia.GetAllFuncionarios();
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            atribuiLkps();
        }

        private void atribuiLkps()
        {
            //lkbFilial.SubForm = new FormFilial();
            //lkbResponsavel.SubForm = new FormPessoa();

            lkbFilial.SubFormType = typeof(FormFilial);
            lkbResponsavel.SubFormType = typeof(FormPessoa);

            lkpResponsavel.Exemplo = new Pessoa() { BFuncionario = true };
            lkpResponsavel.CamposRestricoesAND = new List<string>() { "bFuncionario" };
        }

        private void FormRota_Shown(object sender, EventArgs e)
        {
            lkpCliente.DataSource = Clientes;
            lkpOperador.DataSource = Funcionarios;

            AparenciaGrid();
            if (Selecionado.RotaDetalhes == null)
            {
                gvRotaDetalhes.ClearColumnErrors();
                IncluirRotaDetalhe();
                AtualizaGrid();
            }
            dtTxtDataStatus.DateTime = DateTime.Now;
            txtCBStatus.SelectedIndex = 0;
        }

        private void AparenciaGrid()
        {
            gvRotaDetalhes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.Empty.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.EvenRow.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.EvenRow.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.EvenRow.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            gvRotaDetalhes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            gvRotaDetalhes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            gvRotaDetalhes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.FilterPanel.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.FilterPanel.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.FixedLine.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(188)))), ((int)(((byte)(253)))));
            gvRotaDetalhes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.FocusedCell.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.FocusedCell.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            gvRotaDetalhes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            gvRotaDetalhes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.FocusedRow.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.FocusedRow.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.FocusedRow.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.FooterPanel.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.FooterPanel.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.FooterPanel.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.GroupButton.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.GroupButton.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.GroupFooter.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.GroupFooter.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.GroupFooter.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            gvRotaDetalhes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.GroupPanel.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.GroupPanel.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.GroupRow.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            gvRotaDetalhes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            gvRotaDetalhes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.HeaderPanel.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.HeaderPanel.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            gvRotaDetalhes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.OddRow.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.OddRow.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.OddRow.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            gvRotaDetalhes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.Preview.Options.UseFont = true;
            gvRotaDetalhes.Appearance.Preview.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            gvRotaDetalhes.Appearance.Row.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            gvRotaDetalhes.Appearance.RowSeparator.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            gvRotaDetalhes.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            gvRotaDetalhes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.SelectedRow.Options.UseBackColor = true;
            gvRotaDetalhes.Appearance.SelectedRow.Options.UseBorderColor = true;
            gvRotaDetalhes.Appearance.SelectedRow.Options.UseForeColor = true;
            gvRotaDetalhes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            gvRotaDetalhes.Appearance.TopNewRow.Options.UseBackColor = true;
            gvRotaDetalhes.BestFitMaxRowCount = 5;
            gvRotaDetalhes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gvRotaDetalhes.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            gvRotaDetalhes.OptionsView.EnableAppearanceEvenRow = true;
            gvRotaDetalhes.OptionsView.EnableAppearanceOddRow = true;
            gvRotaDetalhes.OptionsView.ShowAutoFilterRow = true;
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            IncluirRotaDetalhe();
            AtualizaGrid();
            SetaFocuUltimoReg();
        }

        private void IncluirRotaDetalhe()
        {
            if (!gvRotaDetalhes.HasColumnErrors)
            {
                if ((Selecionado.RotaDetalhes == null) || (Selecionado.RotaDetalhes.Count() == 0))
                {
                    Selecionado.RotaDetalhes = new List<RotaDetalhe>();
                    Selecionado.RotaDetalhes.Add(new RotaDetalhe()
                    {
                        Codigo = 1,
                        Sequencia = 1,
                        Rota = Selecionado
                    });
                }
                else
                {
                    Selecionado.RotaDetalhes.Add(new RotaDetalhe()
                    {
                        Codigo = Selecionado.RotaDetalhes.Max(x => x.Codigo + 1),
                        Sequencia = Selecionado.RotaDetalhes.Max(x => x.Sequencia + 1),
                        Rota = Selecionado
                    });
                }
            }
            else
            {
                MessageBox.Show("Complete os registros existentes antes de inserir um novo registro, Verifique!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetaFocuUltimoReg()
        {
            int qtdLinhas = gvRotaDetalhes.RowCount;
            gvRotaDetalhes.FocusedRowHandle = qtdLinhas - 1;
            gvRotaDetalhes.FocusedColumn = gvRotaDetalhes.VisibleColumns[1];
            gvRotaDetalhes.ShowEditor();
        }

        private void AtualizaGrid()
        {
            gcRotaDetalhes.DataSource = Selecionado.RotaDetalhes;
            gcRotaDetalhes.RefreshDataSource();
            gcRotaDetalhes.Refresh();
        }

        private void sbExcluir_Click(object sender, EventArgs e)
        {
            IList<RotaDetalhe> rotaDetalhesSelecionado = rotaDetalhesSelecionados();
            if (rotaDetalhesSelecionado.Count() == 0)
            {
                MessageBox.Show("Nenhum registro selecionado! Por favor selecione o registro a ser Excluído!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else 
            {
                string mensagem = "";
                if ((rotaDetalhesSelecionado.Count > 1) || rotaDetalhesSelecionado.FirstOrDefault().Cliente == null)
                {
                    mensagem = "Deseja realmente excluir os registros selecionado?";
                }
                else 
                {
                    mensagem = "Deseja excluir a rota para o cliente " + rotaDetalhesSelecionado.FirstOrDefault().Cliente.Nome + "?";
                }
                if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    foreach (RotaDetalhe registro in rotaDetalhesSelecionado)
                    {
                        Selecionado.RotaDetalhes.Remove(registro);
                    }
                    int seq = 0;
                    gvRotaDetalhes.Columns["Sequencia"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    foreach (RotaDetalhe rotaDetalhe in Selecionado.RotaDetalhes)
                    {
                        seq++;
                        rotaDetalhe.Sequencia = seq;
                    }
                    AtualizaGrid();
                }
            }
        }

        private IList<RotaDetalhe> rotaDetalhesSelecionados()
        {
            IList<RotaDetalhe> rotaDetalhesSelecionado = new List<RotaDetalhe>();
            int[] linhas = gvRotaDetalhes.GetSelectedRows();
            foreach (int linha in linhas)
            {
                rotaDetalhesSelecionado.Add((RotaDetalhe)gvRotaDetalhes.GetRow(linha));
            }
            return rotaDetalhesSelecionado;
        }

        private void gvRotaDetalhes_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gvRotaDetalhes_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row == null)
            {
                e.Valid = false;
                return;
            }
            GridView gv = (GridView)sender;

            gv.ClearColumnErrors();
            RotaDetalhe rotaDetalheSelecionada = rotaDetalhesSelecionados().FirstOrDefault();

            if (String.IsNullOrEmpty(rotaDetalheSelecionada.Codigo.ToString()) || rotaDetalheSelecionada.Codigo == 0)
            {
                gv.SetColumnError(gridColumnCodigo, "O Código deve ser diferente de vazio e maior que zero. Verifique");
            }

            if (rotaDetalheSelecionada.Cliente == null)
            {
                gv.SetColumnError(gridColumnCliente, "Cliente é obrigatório. Verifique");
            }

            if (rotaDetalheSelecionada.Operador == null)
            {
                gv.SetColumnError(gridColumnOperador, "Operador é obrigatório. Verifique");
            }

            if (String.IsNullOrEmpty(rotaDetalheSelecionada.Situacao.ToString()))
            {
                gv.SetColumnError(gridColumnSituacao, "Situação é obrigatório. Verifique");
            }

            if (String.IsNullOrEmpty(rotaDetalheSelecionada.Sequencia.ToString()) || rotaDetalheSelecionada.Sequencia == 0)
            {
                gv.SetColumnError(gridColumnCodigo, "A Sequência deve ser diferente de vazio e maior que zero. Verifique");
            }

            e.Valid = !gv.HasColumnErrors;
            gv.CloseEditor();
            if (e.Valid)
            {
                gv.ClearColumnErrors();
            }
        }

        private void gcRotaDetalhes_Leave(object sender, EventArgs e)
        {
            ValidaDadosGrid();
        }

        private void ValidaDadosGrid()
        {
            int[] rows = gvRotaDetalhes.GetSelectedRows();
            if (rows.Count() > 0)
            {
                foreach (int row in rows)
                {
                    RotaDetalhe rotaDetalheSelecionado = (RotaDetalhe)gvRotaDetalhes.GetRow(row);
                    gvRotaDetalhes_ValidateRow(gvRotaDetalhes, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(row, rotaDetalheSelecionado));
                }
            }
        }

        private void gvRotaDetalhes_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            GridView gv = (GridView)sender;
            RotaDetalhe rotaDetalheSelecionado = rotaDetalhesSelecionados().FirstOrDefault();
            gvRotaDetalhes_ValidateRow(sender, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(e.RowHandle, rotaDetalheSelecionado));
            e.Allow = !gv.HasColumnErrors;
        }

        private void btnAcima_Click(object sender, EventArgs e)
        {
            MovimentaLinha(-1);
        }

        private void MovimentaLinha(int posicao)
        {
            gvRotaDetalhes.ClearSorting();
            gvRotaDetalhes.Columns["Sequencia"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            int[] rows = gvRotaDetalhes.GetSelectedRows();
            if (rows.Count() != 0 && rows.FirstOrDefault() >= 0)
            {
                if ((posicao == -1 && rows.FirstOrDefault() > 0) || (posicao == 1 && rows.FirstOrDefault() < gvRotaDetalhes.RowCount-1))
                {
                    RotaDetalhe _selecionado = new RotaDetalhe();
                    _selecionado.Codigo = ((RotaDetalhe)gvRotaDetalhes.GetRow(rows.FirstOrDefault())).Codigo;
                    _selecionado.Sequencia = ((RotaDetalhe)gvRotaDetalhes.GetRow(rows.FirstOrDefault())).Sequencia;
                    RotaDetalhe _anterior = new RotaDetalhe();
                    _anterior.Codigo = ((RotaDetalhe)gvRotaDetalhes.GetRow(rows.FirstOrDefault() + (posicao))).Codigo;
                    _anterior.Sequencia = ((RotaDetalhe)gvRotaDetalhes.GetRow(rows.FirstOrDefault() + (posicao))).Sequencia;
                    Selecionado.RotaDetalhes.Where(x => x.Codigo == _selecionado.Codigo).FirstOrDefault().Sequencia = _anterior.Sequencia;
                    Selecionado.RotaDetalhes.Where(x => x.Codigo == _anterior.Codigo).FirstOrDefault().Sequencia = _selecionado.Sequencia;
                    AtualizaGrid();
                    gvRotaDetalhes.FocusedRowHandle = rows.FirstOrDefault() + (posicao);
                    gvRotaDetalhes.FocusedColumn = gvRotaDetalhes.VisibleColumns[2];
                    gvRotaDetalhes.ShowEditor();
                }
            }
            else
            {
                if (rows.Count() == 0 || rows.FirstOrDefault() < 0)
                {
                    MessageBox.Show("Nenhum registro selecionado! Por favor selecione o registro a ser alterada a ordem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (rows.Count() > 1)
                {
                    MessageBox.Show("Selecione apenas um registro por vez para ser reordenado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAbaixo_Click(object sender, EventArgs e)
        {
            MovimentaLinha(1);
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            bool erroValidacao = false;
            ValidaDadosGrid();
            if (Selecionado != null && Selecionado.RotaDetalhes == null)
            {
                MessageBox.Show("Altes de salvar deve ser informada pelo menos uma rota", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erroValidacao = true;
            }
            else
            {
                foreach (RotaDetalhe item in Selecionado.RotaDetalhes)
                {
                    if (Selecionado.RotaDetalhes.Where(x => x.Codigo == item.Codigo).Count() > 1)
                    {
                        MessageBox.Show("O código " + item.Codigo + " foi informado mais de uma vez na tabela de rota, Verifique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        erroValidacao = true;
                        break;
                    }
                }
            }
            if (gvRotaDetalhes.HasColumnErrors)
            {
                MessageBox.Show("Existe erro na tabela de rota, Verifique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erroValidacao = true;
            }

            if (erroValidacao == false)
            {
                base.sbGravar_Click(sender, e);
            }
            
        }

        private void gvRotaDetalhes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    sbIncluir.PerformClick();
                    break;
                case Keys.Delete:
                    sbExcluir.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            IList < RotaDetalhe > rotaDetalhesSelecionado = rotaDetalhesSelecionados();
            
            if (String.IsNullOrEmpty(txtCBStatus.Text) || String.IsNullOrEmpty(dtTxtDataStatus.Text))
            {
                string mensagem = "";
                if (String.IsNullOrEmpty(txtCBStatus.Text))
                {
                    mensagem = "Situação Status";
                }
                if (String.IsNullOrEmpty(dtTxtDataStatus.Text))
                {
                    if (!String.IsNullOrEmpty(mensagem))
                    {
                        mensagem = mensagem + "e Data Status";
                    }
                    else
                    {
                        mensagem = "Data Status não informada!";
                    }
                }
                mensagem = mensagem + " Deve ser informado para setar os campos dos registros selecionados!";
                if (!String.IsNullOrEmpty(mensagem))
                {
                    MessageBox.Show(mensagem);
                }
            }
            else {
                if (rotaDetalhesSelecionado == null)
                {
                    MessageBox.Show("Nenhum registro selecionado! Por favor selecione os registros a serem alterados!");
                }
                else
                {
                    string mensagem = "Deseja realmente repassar a Situação e Data para todos os registros selecionados?";

                    if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        foreach (RotaDetalhe rotaDetalhe in rotaDetalhesSelecionado)
                        {
                            rotaDetalhe.Situacao = txtCBStatus.SelectedIndex;
                            rotaDetalhe.Data = dtTxtDataStatus.DateTime;
                        }
                        AtualizaGrid();
                    }
                }
            }
        }

        private void gvRotaDetalhes_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
    }
}
