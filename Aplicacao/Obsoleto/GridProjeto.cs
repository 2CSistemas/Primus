using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Transactions;
using System.Data.Common;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using IsolationLevel = System.Data.IsolationLevel;

namespace Aplicacao
{
    public partial class GridProjeto : Aplicacao.Base.GridBase
    {
        public int cwIdPessoa { get; set; }
        public int OpcaoCarrega { get; set; }
        private BLL.Cotacao.Cotacao bllCotacao = new BLL.Cotacao.Cotacao();

        /// <summary>
        /// pOpcaoCarrega = 1 (Em digitacao, Aberto, Aprovado), pOpcaoCarrega = 2(Não Aprovado, Cancelado)
        /// , pOpcaoCarrega = 3(Concluido). Qualquer outro valor Trás todos os projeto.
        /// </summary>       
        /// <param name="pOpcaoCarrega"></param>
        public GridProjeto(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID, int pOpcaoCarrega)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "GridProjeto";
            this.Text = tabela;
            this.Name = tabela;
            OpcaoCarrega = pOpcaoCarrega;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            if (pdb != null)
                this.db = pdb;
            else
            {
                this.db = new Modelo.DataClassesDataContext();
                //this.db.ObjectTrackingEnabled = false;
            }
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";

            switch (OpcaoCarrega)
            {
                case 1:
                    break;
                case 2:
                    sbAprovar.Enabled = false;
                    sbDesaprovar.Enabled = false;
                    sbConcluir.Enabled = false;
                    btIncluir.Enabled = false;
                    break;
                default:
                    sbAprovar.Enabled = false;
                    btIncluir.Enabled = false;
                    btExcluir.Enabled = false;
                    sbDesaprovar.Enabled = false;
                    sbConcluir.Enabled = false;
                    sbMontarOrcamento.Enabled = false;
                    break;
            }
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;
            dataGridView1.Columns["ID"].Visible = true;
            dataGridView1.Columns["ID"].Width = 40;
            dataGridView1.Columns["ID"].Caption = "Código";
            dataGridView1.Columns["Status"].VisibleIndex = 0;
            dataGridView1.Columns["Status"].Width = 80;
            dataGridView1.Columns["Status"].VisibleIndex = 1;
            dataGridView1.Columns["Data"].Width = 70;
            dataGridView1.Columns["Data"].VisibleIndex = 2;
            dataGridView1.Columns["Cli"].Caption = "Cliente";
            dataGridView1.Columns["Cli"].Width = 270;
            dataGridView1.Columns["Cli"].VisibleIndex = 3;
            dataGridView1.Columns["Nome"].Width = 270;
            dataGridView1.Columns["Nome"].VisibleIndex = 4;
            dataGridView1.Columns["TotalProdutos"].Width = 85;
            dataGridView1.Columns["TotalProdutos"].VisibleIndex = 5;
            dataGridView1.Columns["TotalProdutos"].Caption = "Produtos";
            dataGridView1.Columns["TotalProdutos"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            dataGridView1.Columns["TotalProdutos"].DisplayFormat.FormatString = "C2";
            dataGridView1.Columns["TotalServicos"].Width = 85;
            dataGridView1.Columns["TotalServicos"].VisibleIndex = 6;
            dataGridView1.Columns["TotalServicos"].Caption = "Serviços";
            dataGridView1.Columns["TotalServicos"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            dataGridView1.Columns["TotalServicos"].DisplayFormat.FormatString = "C2";
            dataGridView1.Columns["TotalGeral"].Width = 90;
            dataGridView1.Columns["TotalGeral"].VisibleIndex = 7;
            dataGridView1.Columns["TotalGeral"].Caption = "Total";
            dataGridView1.Columns["TotalGeral"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            dataGridView1.Columns["TotalGeral"].DisplayFormat.FormatString = "C2";
            if (OpcaoCarrega == 2)
            {
                dataGridView1.Columns["TipoCancelamento"].Caption = "Tipo Cancelamento";
                dataGridView1.Columns["TipoCancelamento"].Width = 120;
            }
            else
                dataGridView1.Columns["TipoCancelamento"].Visible = false;

            CarregaLayoutSalvo();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
            {
                Modelo.Projeto projeto = new Modelo.Projeto();
                gridControl1.DataSource = projeto.getListaProjetos(context, OpcaoCarrega);
                OrdenaGrid("Data", DevExpress.Data.ColumnSortOrder.Ascending);
            }
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
            {
                FormManutProjeto form = new FormManutProjeto(context);
                form.cwAcao = pAcao;
                form.cwID = pID;
                form.cwTabela = "Projeto";
                form.ShowDialog();
            }
        }

        private void btRateio_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                FormConsultaCustoProjeto form = new FormConsultaCustoProjeto(id);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sbMontarOrcamento_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
                {
                    FormOrcamentoProjeto form = new FormOrcamentoProjeto(context, id, OpcaoCarrega);
                    if (cwkControleUsuario.Facade.ControleAcesso(form))
                    {
                        form.ShowDialog();
                    }
                    atualiza = true;
                }
                CarregarGrid("");
                SelecionaRegistroPorID(COLUNA_ID, id);
                dataGridView1.Focus();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAcompanhamentoProjeto_Click(object sender, EventArgs e)
        {
            using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
            {
                int id = RegistroSelecionado();
                if (id > 0)
                {
                    FormGridProjetoHistorico form = new FormGridProjetoHistorico(context, id, OpcaoCarrega);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btArquivoOrcamento_Click(object sender, EventArgs e)
        {
            using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
            {
                int id = RegistroSelecionado();
                if (id > 0)
                {
                    Modelo.Projeto objProjeto = context.Projetos.Where(p => p.ID == id).First();
                    if (!String.IsNullOrEmpty(objProjeto.CaminhoDocumento))
                    {
                        if (File.Exists(objProjeto.CaminhoDocumento))
                        {
                            Process.Start(objProjeto.CaminhoDocumento);
                            return;
                        }
                    }
                    MessageBox.Show("O registro selecionado não possui um arquivo de orçamento vinculado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void sbAprovar_Click(object sender, EventArgs e)
        {

            try
            {
                if (RegistroSelecionado() > 0)
                {
                    using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
                    {
                        if (context.Connection.State == ConnectionState.Closed)
                            context.Connection.Open();
                        DbTransaction trans = context.Connection.BeginTransaction();
                        context.Transaction = trans;
                        try
                        {
                            Modelo.Projeto objProjeto = (from c in context.Projetos
                                                         where c.ID == RegistroSelecionado()
                                                         select c).Single();

                            if (objProjeto.Banco == null || objProjeto.Acrescimo == null || objProjeto.Portador == null ||
                                objProjeto.Historico == null || objProjeto.PlanoConta == null ||
                                objProjeto.IDPlanoContaServico == null || objProjeto.Condicao == null)
                            {
                                throw new InvalidOperationException(
                                    "Projeto não contém acréscimo, banco, condição, histórico e/ou planos de contas.");
                            }

                            StringBuilder str = new StringBuilder();
                            Modelo.Configuracao objConfiguracao = Modelo.Configuracao.GetConfiguracao(context);

                            if (!objConfiguracao.IDTipoRequisicaoProduto.HasValue)
                                str.AppendLine("O tipo de requisição para produtos deve ser configurado.");
                            if (!objConfiguracao.IDTipoRequisicaoMaterial.HasValue)
                                str.AppendLine("O tipo de requisição para materiais deve ser configurado.");
                            if (objProjeto.Status != 1)
                                str.AppendLine("O projeto deve estar com o status Aberto.");
                            if (objProjeto.Projeto_Materials.Count == 0
                                && objProjeto.Projeto_ProdutoServicos.Count == 0)
                                str.AppendLine(
                                    "Devem ser cadastrados os produtos, serviços e/ou materiais para o projeto.");

                            if (str.Length > 0)
                            {
                                MessageBox.Show(
                                    "Antes de aprovar o projeto verifique as seguintes condições:" + Environment.NewLine +
                                    str.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            context.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, objProjeto);
                            //Requisição para produtos
                            Modelo.Pedido objRequisicao = BLL.OrdemProducao.GerarRequisicaoProdutos(context,
                                                                                                    objConfiguracao,
                                                                                                    objProjeto);
                            if (objRequisicao != null)
                            {
//Se necessário gera uma lista de cotação para os produtos
                                bllCotacao.GerarListaProjeto(context, objRequisicao);
                            }
                            //Requisição para materiais
                            objRequisicao = BLL.OrdemProducao.GerarRequisicaoMateriais(context, objConfiguracao,
                                                                                       objProjeto);
                            //Gera a ordem de produção para o projeto
                            BLL.OrdemProducao.GerarOrdemProducao(context, objProjeto);
                            //Altera o projeto e salva um histórico de projeto aprovado
                            objProjeto.Status = 2;
                            objProjeto.bCentroDeCusto = true;

                            FormManutAcompanhamentoProjeto form = new FormManutAcompanhamentoProjeto(1, 0, objProjeto.ID,
                                                                                                     "Projeto Aprovado: ");
                            form.SetDb(context);
                            form.ShowDialog();
                            if (form.Opcao)
                            {
                                context.SubmitChanges();
                                trans.Commit();

                                ApagaDocumentosAntigosInsereDocumentosNovos();


                                MessageBox.Show("Projeto aprovado com sucesso!", "Mensagem", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                            else
                            {
                                context.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, objProjeto);
                                throw new Exception("Não foi gravado nenhum acompanhamento do projeto.");
                            }
                        }
                        catch (InvalidOperationException ex)
                        {

                            MessageBox.Show("Erro ao gerar documentos do projeto: " + Environment.NewLine + ex.Message,
                                            "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            Modelo.MetodosEstaticos.DiscardInsertsAndDeletes(context);
                            trans.Rollback();
                            MessageBox.Show("Erro ao aprovar projeto: " + Environment.NewLine + ex.Message, "Atenção",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
 
                        }
                    }
                    AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum Registro Selecionado.", "Aviso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                new Aplicacao.Base.FormErro(ex).ShowDialog();
            }
        }

        private void ApagaDocumentosAntigosInsereDocumentosNovos()
        {


            long numeroDoc = DocumentoController.Instancia.GetNumeroDocumentoValido();
            Projeto objProjeto = ProjetoController.Instancia.LoadObjectById(RegistroSelecionado());
            if (objProjeto.Portador == null || objProjeto.Historico == null || objProjeto.PlanoConta == null || objProjeto.PlanoContaServico == null || objProjeto.Condicao == null)
            {
                throw new InvalidOperationException("Projeto não contém portador, histórico, condição e/ou planos de contas.");
            }

            IList<ProjetoParcela> parcelasH = ProjetoParcelaController.Instancia.GetParcelasPorProjeto(objProjeto);
            if (parcelasH.Count == 0) return;
            foreach (var parcela in parcelasH)
            {
                Documento doc = new Documento();
                doc.Codigo = DocumentoController.Instancia.GetNovoCodigoDocumento();
                doc.Tipo = TipoDocumentoType.Receber;
                doc.Filial = FilialController.Instancia.LoadObjectById(objProjeto.Filial.ID);
                doc.Pessoa = PessoaController.Instancia.LoadObjectById(objProjeto.Pessoa.ID);
                doc.TipoDocumento = TipoDocumentoController.Instancia.LoadObjectById(3); // TODO
                doc.Banco = objProjeto.Banco;
                doc.Portador = objProjeto.Portador;
                doc.Acrescimo = objProjeto.Acrescimo;
                doc.Dt = DateTime.Today; // TODO
                doc.DtDigitacao = DateTime.Today;
                doc.DtVencimento = parcela.Vencimento;
                doc.DtPrevisao = parcela.Vencimento;
                doc.NumDocumento = objProjeto.NumeroProposta;
                doc.NumRequisicao = objProjeto.NumeroProposta;
                doc.Condicao = objProjeto.Condicao;
                doc.Parcela = parcela.Parcela;
                doc.QtParcela = parcelasH.Count;
                doc.Valor = parcela.Valor;
                doc.ValorTotal = parcelasH.Sum(ppp => ppp.Valor);
                doc.Historico = objProjeto.Historico;
                doc.ComplementoHist = objProjeto.ComplementoHist;
                doc.Saldo = doc.Valor;
                doc.Situacao = "Norm";
                doc.DtUltimaBaixa = null;
                doc.IncData = DateTime.Now;
                doc.IncUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                doc.AltData = DateTime.Now;

                Movimento mov;
                Movimento mov1 = new Movimento();
                if (objProjeto.PlanoConta != null && objProjeto.TotalProdutos > 0)
                {
                    mov1.Documento = doc;
                    mov1.Dt = doc.Dt;
                    mov1.Operacao = OperacaoMovimentoType.Lancamento;
                    mov1.PlanoConta = objProjeto.PlanoConta;
                    mov1.Sequencia = 1;
                    mov1.Tipo = TipoMovimentoType.Documento;
                    mov1.Valor = Math.Round(parcela.Valor * Math.Round(objProjeto.TotalProdutos / objProjeto.TotalGeral, 2),2);

                    Rateio_Mov rateio = new Rateio_Mov();
                    rateio.Projeto = objProjeto;
                    rateio.Movimento = mov1;
                    rateio.Sequencia = 1;
                    rateio.Valor = mov1.Valor;
                    rateio.Movimento = mov1;
                    mov1.Rateio_Movs.Add(rateio);

                    doc.Movimentos.Add(mov1);
                }
                if (objProjeto.PlanoContaServico != null && objProjeto.TotalServicos > 0)
                {
                    mov = new Movimento();
                    mov.Documento = doc;
                    mov.Dt = doc.Dt;
                    mov.Operacao = OperacaoMovimentoType.Lancamento;
                    mov.PlanoConta = objProjeto.PlanoContaServico;
                    mov.Sequencia = 1;
                    mov.Tipo = TipoMovimentoType.Documento;
                    mov.Valor = Math.Round(parcela.Valor * Math.Round(objProjeto.TotalServicos / objProjeto.TotalGeral, 2),2);
                    mov.Valor += Math.Round(parcela.Valor - (mov.Valor + mov1.Valor),2);

                    Rateio_Mov rateio = new Rateio_Mov();
                    rateio.Projeto = objProjeto;
                    rateio.Movimento = mov;
                    rateio.Sequencia = 1;
                    rateio.Valor = mov.Valor;
                    rateio.Movimento = mov;
                    mov.Rateio_Movs.Add(rateio);

                    doc.Movimentos.Add(mov);
                }
                DocumentoController.Instancia.RegisterNewIntoTransaction(doc);
            }
            DocumentoController.Instancia.CommitUnitOfWorkTransaction();
        }

        private void AtualizaGrid()
        {
            int pos = dataGridView1.FocusedRowHandle;
            CarregarGrid("");
            if (!(dataGridView1.GetFocusedRow() == null || dataGridView1.FocusedRowHandle < 0))
            {
                SelecionaRegistroPorPos(pos);
            }
        }

        private void sbDesaprovar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja desaprovar este projeto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (RegistroSelecionado() > 0)
                {
                    using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
                    {
                        if (context.Connection.State == ConnectionState.Closed)
                            context.Connection.Open();
                        DbTransaction trans = context.Connection.BeginTransaction();
                        context.Transaction = trans;

                        try
                        {
                            Modelo.Projeto objProjeto = (from c in context.Projetos
                                                         where c.ID == RegistroSelecionado()
                                                         select c).Single();
                            string resultado = null;
                            if (objProjeto.Status == 2)
                            {
                                resultado = BLL.OrdemProducao.DeletarRequisicoesProjeto(context, objProjeto);
                                if (resultado == "")
                                {
                                    CriaHistoricoDesaprovaProjeto(objProjeto, context);

                                    objProjeto.Status = 1;
                                    objProjeto.bCentroDeCusto = false;
                                    if (DeletaDocumentosRelacionadoAoProjeto(objProjeto))
                                    {
                                        context.SubmitChanges();
                                        trans.Commit();
                                        MessageBox.Show("Operação efetuada com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        Modelo.MetodosEstaticos.DiscardInsertsAndDeletes(context);
                                        trans.Rollback();
                                        MessageBox.Show("Operação inválida: Os documentos do projeto possuem movimentação.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }



                                    
                                }
                                else
                                {
                                    Modelo.MetodosEstaticos.DiscardInsertsAndDeletes(context);
                                    trans.Rollback();
                                    MessageBox.Show(resultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Este projeto ainda não foi aprovado.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            if (context.Connection.State == ConnectionState.Open)
                                context.Connection.Close();
                        }
                    }
                    AtualizaGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum Registro Selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool DeletaDocumentosRelacionadoAoProjeto(Modelo.Projeto objProjeto)
        {
            var listaDocumentos = DocumentoController.Instancia.GetPorProjeto(ProjetoController.Instancia.LoadObjectById(objProjeto.ID));
            foreach (var doc in listaDocumentos)
            {
                if(doc.Situacao != "Norm")
                {
                    DocumentoController.Instancia.RollBackUnitOfWorkTransaction();
                    return false;
                }
                DocumentoController.Instancia.RegisterDeleteIntoTransaction(doc);
            }
            DocumentoController.Instancia.CommitUnitOfWorkTransaction();
            return true;

        }

        private void CriaHistoricoDesaprovaProjeto(Modelo.Projeto pObjProjeto, Modelo.DataClassesDataContext context)
        {
            Modelo.ProjetoHistorico proj = new Modelo.ProjetoHistorico();
            proj.IDProjeto = pObjProjeto.ID;
            proj.IncData = DateTime.Now;
            proj.IncHora = DateTime.Now;
            proj.IncUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
            proj.Descricao = "Projeto Desaprovado";
            proj.Data = DateTime.Now;
            context.ProjetoHistoricos.InsertOnSubmit(proj);
        }

        private void sbConcluir_Click(object sender, EventArgs e)
        {
            int id = RegistroSelecionado();
            if (id > 0)
            {
                using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
                {
                    Modelo.Projeto objProjeto = (from c in context.Projetos
                                                 where c.ID == id
                                                 select c).Single();

                    //Projeto deve estar aprovado
                    if (objProjeto.Status == 5)
                    {
                        MessageBox.Show("O projeto selecionado já está concluído.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (objProjeto.Status != 2)
                    {
                        MessageBox.Show("Só é permitido concluir projetos aprovados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FormManutAcompanhamentoProjeto form = new FormManutAcompanhamentoProjeto(1, 0, objProjeto.ID, "Projeto Concluído: ");
                    form.ShowDialog();
                    if (form.Opcao)
                    {
                        objProjeto.Status = 5;
                        context.SubmitChanges();
                        MessageBox.Show("Projeto concluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaGrid();
                    }
                    else
                    {
                        context.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, objProjeto);
                        Modelo.MetodosEstaticos.DiscardInsertsAndDeletes(context);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum Registro Selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
