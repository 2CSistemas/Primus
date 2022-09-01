using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormOrcamentoProjeto : Form
    {
        private List<ProjetoParcela> _parcelas;
        private bool naoAtualizarParcelas = true;
        private bool parcelasRecalculadas = false;
        private IList<ProjetoParcela> parcelasH = new List<ProjetoParcela>();

        private List<ProjetoParcela> Parcelas
        {
            set
            {
                _parcelas = value;
                gcParcelas.DataSource = value;
                gvParcelas.RefreshData();
            }
        }

        public FormOrcamentoProjeto(Modelo.DataClassesDataContext pDb, int idProjeto, int pTipo)
        {

            InitializeComponent();

            InitializeLookups();

            Parcelas = new List<ProjetoParcela>();


            db = pDb;
            this.Name = "FormOrcamentoProjeto";
            objProjeto = db.Projetos.Where(p => p.ID == idProjeto).First();

            foreach (var parc in ProjetoParcelaController.Instancia.GetParcelasPorProjeto(
                ProjetoController.Instancia.LoadObjectById(idProjeto)))
                _parcelas.Add(parc);

            Parcelas = _parcelas;
            if (objProjeto.Status == 2)
                cbStatus.Enabled = false;

            lkpPortador.EditValue = cwkGestao.Negocio.PortadorController.Instancia.LoadObjectById(objProjeto.IDPortador ?? 0);
            lkpPlanoContaServico.EditValue = cwkGestao.Negocio.PlanoContaController.Instancia.LoadObjectById(objProjeto.IDPlanoContaServico ?? 0);
            lkpPlanoConta.EditValue = cwkGestao.Negocio.PlanoContaController.Instancia.LoadObjectById(objProjeto.IDPlanoConta ?? 0);
            lkpHistorico.EditValue = cwkGestao.Negocio.HistoricoController.Instancia.LoadObjectById(objProjeto.IDHistorico ?? 0);
            lkpCondicao.EditValue = cwkGestao.Negocio.CondicaoController.Instancia.LoadObjectById(objProjeto.IDCondicao ?? 0);
            lkpBanco.EditValue = cwkGestao.Negocio.BancoController.Instancia.LoadObjectById(objProjeto.IDBanco ?? 0);
            lkpAcrescimo.EditValue = cwkGestao.Negocio.AcrescimoController.Instancia.LoadObjectById(objProjeto.IDAcrescimo ?? 0);
            txtHistoricoCompl.EditValue = objProjeto.HistoricoComplemento;

            txtCliente.Text = objProjeto.Pessoa.Nome;
            txtNome.Text = objProjeto.Nome;
            cbTipoPreco.SelectedIndex = objProjeto.TipoPreco == null ? 0 : (int)objProjeto.TipoPreco;
            cbStatus.SelectedIndex = objProjeto.Status == null ? 0 : (int)objProjeto.Status;
            txtValorDescontoProd.EditValue = objProjeto.ValorDescontoProduto;
            txtPorcentagemDescontoProd.EditValue = objProjeto.PercDescontoProduto;
            txtValorDescontoServ.EditValue = objProjeto.ValorDescontoMaoObra;
            txtPorcentagemDescontoServ.EditValue = objProjeto.PercDescontoMaoObra;
            txtMarLucroProduto.EditValue = objProjeto.MarLucroProduto;
            txtMarLucroMaoObra.EditValue = objProjeto.MarLucroMaoObra;
            txtInstrucoesProducao.EditValue = objProjeto.InstrucoesProducao;
            txtDescricao.EditValue = objProjeto.Descricao;
            txtNumeroProposta.EditValue = objProjeto.NumeroProposta;
            AtualizaProdutos();
            AtualizaServicos();
            AtualizaMateriais();
            if (objProjeto.TotalGeral > 0)
            {
                txtTotalGeral.Value = objProjeto.TotalGeral.Value;
            }

            if (objProjeto.Status == 5)
            {
                MessageBox.Show("O projeto selecionado não pode mais ser alterado pois já está concluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DesabilitarAlteracoes();
            }
            else if (objProjeto.Status == 2)
            {
                MessageBox.Show("O projeto selecionado não pode mais ser alterado pois já foi aprovado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DesabilitarAlteracoes();
            }

            carregado = true;
            if (pTipo == 3 || pTipo == 2)
                sbGravar.Enabled = false;
        }

        private void DesabilitarAlteracoes()
        {
            sbGravar.Enabled = false;
            sbGravar.Visible = false;
            btIncluirMaterial.Enabled = false;
            btAlterarMaterial.Enabled = false;
            btExcluirMaterial.Enabled = false;
            btIncluirProduto.Enabled = false;
            btAlterarProduto.Enabled = false;
            btExcluirProduto.Enabled = false;

            btIncluirServico.Enabled = false;
            btAlterarServico.Enabled = false;
            btExcluirServico.Enabled = false;
        }

        private void InitializeLookups()
        {
            lkpPortador.Sessao =
                lkpPlanoContaServico.Sessao =
                lkpPlanoConta.Sessao = lkpHistorico.Sessao = lkpCondicao.Sessao = lkpBanco.Sessao = lkpAcrescimo.Sessao = cwkGestao.Negocio.ProjetoController.Instancia.getSession();

            lkpPortador.Exemplo = new Portador();
            lkpPlanoContaServico.Exemplo = new PlanoConta();
            lkpPlanoConta.Exemplo = new PlanoConta();
            lkpHistorico.Exemplo = new Historico();
            lkpCondicao.Exemplo = new Condicao();
            lkpBanco.Exemplo = new Banco();
            lkpAcrescimo.Exemplo = new Acrescimo();

        }

        #region Atributos

        private Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        private Modelo.Projeto objProjeto;
        private decimal totalProdutos, totalServicos, totalMateriais, subTotalProdutos, subTotalServicos;
        private bool carregado = false;
        private object lockerDesconto = new object();
        private bool atualizaDesconto = true;
        private StringBuilder message = new StringBuilder();
        private Dictionary<string, string> _erro = new Dictionary<string, string>();
        public Dictionary<string, string> cwErro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        #endregion

        #region Calculos

        private void AtualizaTotalProduto()
        {
            totalProdutos = subTotalProdutos + (subTotalProdutos * System.Math.Round(txtMarLucroProduto.Value / 100, 4));
            totalProdutos = System.Math.Round((totalProdutos - txtValorDescontoProd.Value), 2);
            txtTotalProd.EditValue = totalProdutos;
        }

        private void AtualizaTotalServico()
        {
            totalServicos = subTotalServicos + (subTotalServicos * System.Math.Round(txtMarLucroMaoObra.Value / 100, 4));
            totalServicos = System.Math.Round((totalServicos - txtValorDescontoServ.Value), 2);
            txtTotalServ.EditValue = totalServicos;
        }

        public void AlteraValorDescontoProduto()
        {
            txtValorDescontoProd.Value = System.Math.Round((subTotalProdutos * txtPorcentagemDescontoProd.Value) / 100, 2);
        }

        public void AlteraPercDescontoProduto()
        {
            txtPorcentagemDescontoProd.Value = System.Math.Round(((subTotalProdutos > 0) ? (decimal)(txtValorDescontoProd.Value / subTotalProdutos * 100) : 0), 4);
        }

        public void AlteraValorDescontoServico()
        {
            txtValorDescontoServ.Value = System.Math.Round((subTotalServicos * txtPorcentagemDescontoServ.Value) / 100, 2);
        }

        public void AlteraPercDescontoServico()
        {
            txtPorcentagemDescontoServ.Value = System.Math.Round(((subTotalServicos > 0) ? (decimal)(txtValorDescontoServ.Value / subTotalServicos * 100) : 0), 4);
        }

        #endregion

        #region Eventos

        private void sbGravar_Click(object sender, EventArgs e)
        {
            if (txtValorDescontoProd.Value > subTotalProdutos || txtValorDescontoServ.Value > subTotalServicos)
            {
                StringBuilder mensagem = new StringBuilder();
                if (txtValorDescontoProd.Value > subTotalProdutos)
                {
                    mensagem.AppendLine("Desconto Produtos: O valor do desconto não pode ser maior do que o valor total do orçamento.");
                    dxErrorProvider1.SetError(txtValorDescontoProd, "O valor do desconto não pode ser maior do que o valor total do orçamento.");
                }

                if (txtValorDescontoServ.Value > subTotalServicos)
                {
                    mensagem.AppendLine("Desconto Serviços: O valor do desconto não pode ser maior do que o valor total do orçamento.");
                    dxErrorProvider1.SetError(txtValorDescontoServ, "O valor do desconto não pode ser maior do que o valor total do orçamento.");
                }

                MessageBox.Show("Verifique Anomalias.\n\n" + mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (cbStatus.SelectedIndex == 2 && objProjeto.Status_Ant != 2)
            {
                dxErrorProvider1.SetError(cbStatus, "A aprovação do projeto deve ser feita na tela anterior.");
                MessageBox.Show("Verifique Anomalias.\n\n" + "Status: A aprovação do projeto deve ser feita na tela anterior.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (cbStatus.SelectedIndex == 5 && objProjeto.Status_Ant != 5)
            {
                dxErrorProvider1.SetError(cbStatus, "A conclusão do projeto deve ser feita na tela anterior.");
                MessageBox.Show("Verifique Anomalias.\n\n" + "Status: A conclusão do projeto deve ser feita na tela anterior.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtTotalGeral.Value != PegaValorColunaValor() && lkpCondicao.Selecionado != null)
            {
                dxErrorProvider1.SetError(txtTotalGeral, "O valor total não pode ser diferente do total das parcelas.");
                MessageBox.Show("Verifique Anomalias.\n\n" + "Total: O valor total não pode ser diferente do total das parcelas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    sbGravar.Enabled = false;
                    sbCancelar.Enabled = false;
                    cwErro = Salvar();
                    if (cwErro == null || cwErro.Count == 0)
                    {
                        if (parcelasRecalculadas)
                        {
                            ApagaParcelasAntigasInsereParcelasNovas();
                            ProjetoParcelaController.Instancia.CommitUnitOfWorkTransaction();
                        }
                        this.Close();
                    }
                    else
                    {
                        message.Remove(0, message.Length);
                        setErro(this.Controls);
                        if (!String.IsNullOrEmpty(message.ToString()))
                            MessageBox.Show("Verifique Anomalias.\n\n" + message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Problema com o banco de dados: \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                finally
                {
                    sbGravar.Enabled = true;
                    sbCancelar.Enabled = true;
                }
            }
        }

        private void ApagaParcelasAntigasInsereParcelasNovas()
        {

            Banco bancoH = objProjeto.Banco != null ? BancoController.Instancia.LoadObjectById(objProjeto.Banco.ID) : null;
            Portador portadorH = objProjeto.Portador != null ? portadorH = PortadorController.Instancia.LoadObjectById(objProjeto.Portador.ID) : null;
            Projeto projetoH = ProjetoController.Instancia.LoadObjectById(objProjeto.ID);
            parcelasH.Clear();
            foreach (var pedidoParcela in _parcelas)
            {
                parcelasH.Add(new ProjetoParcela(pedidoParcela)
                                 {
                                     Projeto = projetoH,
                                     Banco = bancoH,
                                     Portador = portadorH,
                                 });
            }
            ProjetoParcelaController.Instancia.RegisterNewIntoTransaction(parcelasH);
            ProjetoParcelaController.Instancia.RegisterDeleteIntoTransaction(ProjetoParcelaController.Instancia.GetParcelasPorProjeto(projetoH));
        }

        private Dictionary<string, string> Salvar()
        {
            dxErrorProvider1.SetError(txtValorDescontoProd, String.Empty);
            objProjeto.TipoPreco = cbTipoPreco.SelectedIndex;
            objProjeto.Status = cbStatus.SelectedIndex;


            List<ProjetoServicogrid> servicos = (List<ProjetoServicogrid>)gcServicos.DataSource ?? new List<ProjetoServicogrid>();

            if (objProjeto.Status == 4 || objProjeto.Status == 3)
            {
                if (objProjeto.MotivoCancelamento == null
                    || (objProjeto.Status_Ant != 3 && objProjeto.Status == 3)
                    || (objProjeto.Status_Ant != 4 && objProjeto.Status == 4))
                {
                    FormMotivoCancProjeto formMotivo = new FormMotivoCancProjeto();
                    formMotivo.ShowDialog();
                    objProjeto.MotivoCancelamento = formMotivo.motivo;
                }
            }
            else
                objProjeto.MotivoCancelamento = null;

            objProjeto.Condicao = db.Condicaos.FirstOrDefault(cond => cond.ID == lkpCondicao.ID);
            objProjeto.Banco = db.Bancos.FirstOrDefault(cond => cond.ID == lkpBanco.ID);
            objProjeto.Portador = db.Portadors.FirstOrDefault(cond => cond.ID == lkpPortador.ID);
            objProjeto.Historico = db.Historicos.FirstOrDefault(cond => cond.ID == lkpHistorico.ID);
            objProjeto.Acrescimo = db.Acrescimos.FirstOrDefault(cond => cond.ID == lkpAcrescimo.ID);
            objProjeto.PlanoConta = db.PlanoContas.FirstOrDefault(cond => cond.ID == lkpPlanoConta.ID);
            objProjeto.HistoricoComplemento = txtHistoricoCompl.Text;
            objProjeto.NumeroProposta = txtNumeroProposta.Text;

            var xlckm = db.PlanoContas.FirstOrDefault(cond => cond.ID == lkpPlanoContaServico.ID);
            objProjeto.IDPlanoContaServico = xlckm == null ? 0 : xlckm.ID;

            objProjeto.InstrucoesProducao = txtInstrucoesProducao.Text;
            objProjeto.ValorDescontoProduto = txtValorDescontoProd.Value;
            objProjeto.PercDescontoProduto = txtPorcentagemDescontoProd.Value;
            objProjeto.ValorDescontoMaoObra = txtValorDescontoServ.Value;
            objProjeto.PercDescontoMaoObra = txtPorcentagemDescontoServ.Value;
            objProjeto.MarLucroMaoObra = txtMarLucroMaoObra.Value;
            objProjeto.MarLucroProduto = txtMarLucroProduto.Value;
            objProjeto.TotalProdutos = txtTotalProd.Value;
            objProjeto.TotalServicos = txtTotalServ.Value;
            objProjeto.TotalGeral = txtTotalGeral.Value;
            return BLL.Projeto.Salvar(db, objProjeto);
        }

        protected void setErro(Control.ControlCollection pControles)
        {
            string label = "";

            //}
            //foreach (Control ctr in pControles)
            //{
            Control ctr;
            for (int i = 0; i < pControles.Count; i++)
            {
                ctr = pControles[i];

                if ((ctr is DevExpress.XtraTab.XtraTabControl) || (ctr is DevExpress.XtraTab.XtraTabPage) || (ctr is DevExpress.XtraEditors.GroupControl))
                {
                    setErro(ctr.Controls);
                }
                else
                {
                    if ((ctr is DevExpress.XtraEditors.LabelControl) || (ctr is DevExpress.XtraEditors.SimpleButton))
                    {
                        continue;
                    }

                    //errorProvider1.SetError(ctr, "");                    
                    dxErrorProvider1.SetError(ctr, "");
                    label = "";
                    foreach (KeyValuePair<string, string> erro in cwErro)
                    {
                        if (ctr.Name.ToLower() == erro.Key.ToLower())
                        {
                            dxErrorProvider1.SetError(ctr, erro.Value);

                            label = EncontraLabel(pControles, ctr);
                            if (label.Length != 0)
                                message.AppendLine(label + " " + erro.Value);
                            break;
                        }
                    }
                }
            }
        }
        private string EncontraLabel(Control.ControlCollection pControles, Control pControle)
        {
            string label = "";

            Control ctr;
            for (int i = 0; i < pControles.Count; i++)
            {
                ctr = pControles[i];
                if ((ctr is DevExpress.XtraTab.XtraTabControl) || (ctr is DevExpress.XtraTab.XtraTabPage) || (ctr is DevExpress.XtraEditors.GroupControl))
                {
                    EncontraLabel(ctr.Controls, pControle);
                }
                else
                {
                    if (ctr.TabIndex == pControle.TabIndex - 1)
                    {
                        label = ctr.Text;
                        break;
                    }
                }
            }

            return label;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOrcamentoProjeto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    if (Form.ModifierKeys == Keys.Control)
                        cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Orçamento Projeto");
                    break;
            }

        }

        #endregion

        #region Desconto e Lucro

        private void txtPorcentagemDescontoProd_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (carregado == true)
            {
                try
                {
                    if (txtPorcentagemDescontoProd.Value > 100)
                    {
                        txtPorcentagemDescontoProd.EditValue = 0;
                    }
                    else
                    {
                        lock (lockerDesconto)
                        {
                            if (atualizaDesconto)
                            {
                                atualizaDesconto = false;
                                AlteraValorDescontoProduto();
                            }
                            else
                                atualizaDesconto = true;
                        }
                    }
                    AtualizaTotalProduto();
                }
                catch (Exception)
                {
                    txtPorcentagemDescontoProd.EditValue = objProjeto.PercDescontoProduto;
                }
            }
        }

        private void txtValorDescontoProd_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (carregado == true)
            {
                try
                {
                    if (txtValorDescontoProd.Value > subTotalProdutos)
                    {
                        txtValorDescontoProd.EditValue = 0;
                    }
                    else
                    {
                        lock (lockerDesconto)
                        {
                            if (atualizaDesconto)
                            {
                                atualizaDesconto = false;
                                AlteraPercDescontoProduto();
                            }
                            else
                                atualizaDesconto = true;
                        }
                    }
                    AtualizaTotalProduto();
                }
                catch (Exception)
                {
                    txtValorDescontoProd.EditValue = objProjeto.ValorDescontoProduto;
                }
            }
        }

        private void txtPorcentagemDescontoServ_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (carregado == true)
            {
                try
                {
                    if (txtPorcentagemDescontoServ.Value > 100)
                    {
                        txtPorcentagemDescontoServ.EditValue = 0;
                    }
                    else
                    {
                        lock (lockerDesconto)
                        {
                            if (atualizaDesconto)
                            {
                                atualizaDesconto = false;
                                AlteraValorDescontoServico();
                            }
                            else
                                atualizaDesconto = true;
                        }
                    }
                    AtualizaTotalProduto();
                }
                catch (Exception)
                {
                    txtPorcentagemDescontoServ.EditValue = objProjeto.PercDescontoMaoObra;
                }
            }
        }

        private void txtValorDescontoServ_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (carregado == true)
            {
                try
                {
                    if (txtValorDescontoServ.Value > subTotalServicos)
                    {
                        txtValorDescontoServ.EditValue = 0;
                    }
                    else
                    {
                        lock (lockerDesconto)
                        {
                            if (atualizaDesconto)
                            {
                                atualizaDesconto = false;
                                AlteraPercDescontoServico();
                            }
                            else
                                atualizaDesconto = true;
                        }
                    }
                    AtualizaTotalServico();
                }
                catch (Exception)
                {
                    txtValorDescontoServ.EditValue = objProjeto.ValorDescontoMaoObra;
                }
            }
        }

        private void txtMarLucroProdutos_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizaTotalProduto();
        }

        private void txtMarLucroMaoObra_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizaTotalServico();
        }

        #endregion

        #region Produtos

        private void AtualizaProdutos()
        {
            List<ProjetoProdutoGrid> aux = (from p in objProjeto.Projeto_ProdutoServicos
                                            where p.IDProduto > 0
                                            select new ProjetoProdutoGrid
                                            {
                                                Codigo = p.Produto.Codigo,
                                                Nome = p.Produto.Nome,
                                                Preco = p.ValorUnitario,
                                                Quantidade = p.Quantidade,
                                                Total = p.ValorUnitario * p.Quantidade,
                                                IDProduto = p.Produto.ID
                                            }).ToList();
            gcProdutos.DataSource = aux;
            subTotalProdutos = aux.Sum(a => a.Total);
            AtualizaTotalProduto();
        }

        public int ProdutoSelecionado()
        {
            int id;
            try
            {
                id = (int)gvProdutos.GetFocusedRowCellValue("IDProduto");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void ManutencaoProduto(int pAcao, int pID)
        {
            if (pAcao == 1 || pID > 0)
            {
                try
                {
                    FormManutProjeto_Produto form = new FormManutProjeto_Produto(db, objProjeto);
                    form.cwAcao = pAcao;
                    form.cwID = pID;
                    form.cwTabela = "Produto em Projeto";
                    form.ShowDialog();
                    if (pAcao != 4)
                    {
                        int pos = gvProdutos.FocusedRowHandle;
                        AtualizaProdutos();
                        if (pAcao == 2 && (!(gvProdutos.GetFocusedRow() == null || gvProdutos.FocusedRowHandle < 0)))
                        {
                            SelecionaRegistroPorPos(pos, gvProdutos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btConsultarProduto_Click(object sender, EventArgs e)
        {
            ManutencaoProduto(4, ProdutoSelecionado());
        }

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            ManutencaoProduto(1, 0);
        }

        private void btAlterarProduto_Click(object sender, EventArgs e)
        {
            ManutencaoProduto(2, ProdutoSelecionado());
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            ManutencaoProduto(3, ProdutoSelecionado());
        }

        private void gcProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (btAlterarProduto.Enabled)
                        btAlterarProduto_Click(sender, e);
                    break;
            }
        }

        private void gcProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (btAlterarProduto.Enabled)
                btAlterarProduto_Click(sender, e);
        }

        #endregion

        #region Servicos



        private void AtualizaServicos()
        {
            var aux = (from p in objProjeto.Projeto_ProdutoServicos
                       join s in db.Servicos on p.IDServico equals s.id
                       where p.IDServico > 0
                       select new
                                  {
                                      Codigo = s.codigo,
                                      Nome = s.nome,
                                      Preco = p.ValorUnitario,
                                      Quantidade = p.Quantidade,
                                      Total = p.ValorUnitario*p.Quantidade,
                                      IDServico = p.IDServico,
                                      Agrupamento = Math.Max(p.Agrupamento, 1)
                       }).ToList();
            
            
            cbAgrupamentoServico.Items.Clear();
            List<ProjetoServicogrid> servicos = new List<ProjetoServicogrid>();
            List<ProjetoServicogrid> old = (List<ProjetoServicogrid>) gcServicos.DataSource ?? new List<ProjetoServicogrid>();
            foreach (var algo in aux)
            {
                if (old.Where(kc => kc.IDServico == algo.IDServico && kc.Agrupamento == algo.Agrupamento).Count() == 0)
                {
                    servicos.Add(new ProjetoServicogrid
                                     {
                                         Agrupamento = algo.Agrupamento,
                                         Codigo = algo.Codigo,
                                         IDServico = algo.IDServico.Value,
                                         Nome = algo.Nome,
                                         Preco = algo.Preco,
                                         Quantidade = algo.Quantidade,
                                         Total = algo.Total
                                     });
                }
                else
                {
                    servicos.Add(old.Where(kc => kc.IDServico == algo.IDServico && kc.Agrupamento == algo.Agrupamento).First());

                }
                
            }
            foreach(var algo in servicos)
            {
                if (!cbAgrupamentoServico.Items.Contains(algo.Agrupamento))
                    cbAgrupamentoServico.Items.Add(algo.Agrupamento);
            }

            gcServicos.DataSource = servicos;
            gvServicos.RefreshData();
            
            if (servicos.Count > 0)
            {
                int i = 1;
                
                while (cbAgrupamentoServico.Items.Contains(i)) i++;
                
                cbAgrupamentoServico.Items.Add(i);
            }
            else
                cbAgrupamentoServico.Items.Add(1);
            subTotalServicos = aux.Sum(a => a.Total);
            AtualizaTotalServico();
        }

        public int ServicoSelecionado()
        {
            int id;
            try
            {
                id = (int)gvServicos.GetFocusedRowCellValue("IDServico");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void ManutencaoServico(int pAcao, int pID)
        {
            if (pAcao == 1 || pID > 0)
            {
                try
                {
                    FormManutProjeto_Servico form = new FormManutProjeto_Servico(db, objProjeto);
                    form.cwAcao = pAcao;
                    form.cwID = pID;
                    form.cwTabela = "Serviço em Projeto";
                    form.ShowDialog();
                    if (pAcao != 4)
                    {
                        int pos = gvServicos.FocusedRowHandle;
                        AtualizaServicos();
                        if (pAcao == 2 && (!(gvServicos.GetFocusedRow() == null || gvServicos.FocusedRowHandle < 0)))
                        {
                            SelecionaRegistroPorPos(pos, gvServicos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btConsultarServico_Click(object sender, EventArgs e)
        {
            ManutencaoServico(4, ServicoSelecionado());
        }

        private void btIncluirServico_Click(object sender, EventArgs e)
        {
            ManutencaoServico(1, 0);
        }

        private void cbAgrupamentoServico_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            ProjetoServicogrid bla = (ProjetoServicogrid) gvServicos.GetRow(gvServicos.GetSelectedRows()[0]);

            if(((List<ProjetoServicogrid>)gcServicos.DataSource).Where(psg => psg.IDServico == bla.IDServico && psg.Agrupamento == Convert.ToInt32(e.NewValue)).Count() > 0)
            {
                MessageBox.Show("Já existe este serviço no agrupamento escolhido.","Ops!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.Cancel = true;
            }else
            {
                var algo = objProjeto.Projeto_ProdutoServicos.FirstOrDefault(
                    blaz => blaz.Agrupamento == bla.Agrupamento && blaz.IDServico == bla.IDServico);
                if (algo != null) 
                {
                    algo.Agrupamento = Convert.ToInt32(e.NewValue);
                    BLL.Projeto.SalvarServicoItem(db, objProjeto, algo,2 );
                }
                bla.Agrupamento = Convert.ToInt32(e.NewValue);
                
            }
           
        }

        private void btAlterarServico_Click(object sender, EventArgs e)
        {
            ManutencaoServico(2, ServicoSelecionado());
        }

        private void btExcluirServico_Click(object sender, EventArgs e)
        {
            ManutencaoServico(3, ServicoSelecionado());
        }

        private void gcServicos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (btAlterarServico.Enabled)
                        btAlterarServico_Click(sender, e);
                    break;
            }
        }

        private void gcServicos_DoubleClick(object sender, EventArgs e)
        {
            if (btAlterarServico.Enabled)
                btAlterarServico_Click(sender, e);
        }

        #endregion

        #region Materiais

        private void AtualizaMateriais()
        {
            var aux = (from p in objProjeto.Projeto_Materials
                       select new
                       {
                           Codigo = p.Produto.Codigo,
                           Nome = p.Produto.Nome,
                           Valor = p.ValorUnitario,
                           Quantidade = p.Quantidade,
                           Total = p.ValorUnitario * p.Quantidade,
                           IDProduto = p.Produto.ID
                       }).ToList();
            gcMateriais.DataSource = aux;
            totalMateriais = aux.Sum(a => a.Total);
        }

        public int MaterialSelecionado()
        {
            int id;
            try
            {
                id = (int)gvMateriais.GetFocusedRowCellValue("IDProduto");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void ManutencaoMaterial(int pAcao, int pID)
        {
            if (pAcao == 1 || pID > 0)
            {
                try
                {
                    FormManutProjeto_Material form = new FormManutProjeto_Material(db, objProjeto);
                    form.cwAcao = pAcao;
                    form.cwID = pID;
                    form.cwTabela = "Material em Projeto";
                    form.ShowDialog();
                    if (pAcao != 4)
                    {
                        int pos = gvMateriais.FocusedRowHandle;
                        AtualizaMateriais();
                        if (pAcao == 2 && (!(gvMateriais.GetFocusedRow() == null || gvMateriais.FocusedRowHandle < 0)))
                        {
                            SelecionaRegistroPorPos(pos, gvMateriais);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btConsultarMaterial_Click(object sender, EventArgs e)
        {
            ManutencaoMaterial(4, MaterialSelecionado());
        }

        private void btIncluirMaterial_Click(object sender, EventArgs e)
        {
            ManutencaoMaterial(1, 0);
        }

        private void btAlterarMaterial_Click(object sender, EventArgs e)
        {
            ManutencaoMaterial(2, MaterialSelecionado());
        }

        private void btExcluirMaterial_Click(object sender, EventArgs e)
        {
            ManutencaoMaterial(3, MaterialSelecionado());
        }

        private void gcMateriais_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (btAlterarMaterial.Enabled)
                        btAlterarMaterial_Click(sender, e);
                    break;
            }
        }

        private void gcMateriais_DoubleClick(object sender, EventArgs e)
        {
            if (btAlterarMaterial.Enabled)
                btAlterarMaterial_Click(sender, e);
        }

        #endregion

        private void txtTotalProd_EditValueChanged(object sender, EventArgs e)
        {
            AtualizaTotalGeral();
        }

        private void txtTotalServ_EditValueChanged(object sender, EventArgs e)
        {
            AtualizaTotalGeral();
        }

        private void AtualizaTotalGeral()
        {
            txtTotalGeral.Value = txtTotalProd.Value + txtTotalServ.Value;
        }

        public void SelecionaRegistroPorPos(int posicao, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            if (posicao >= 0)
            {
                if (posicao > gridView.RowCount - 1)
                {
                    posicao = gridView.RowCount - 1;
                }
                gridView.FocusedRowHandle = posicao;
                gridView.SelectRow(posicao);
            }
            else
            {
                gridView.ClearSelection();
                gridView.SelectRow(0);
                gridView.FocusedRowHandle = 0;
            }
        }

        private void FormOrcamentoProjeto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (objProjeto.ID > 0)
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.Projetos);
            db.SubmitChanges();
        }

        private void cbTipoPreco_SelectedIndexChanged(object sender, EventArgs e)
        {
            objProjeto.TipoPreco = cbTipoPreco.SelectedIndex;
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Condicao>(lkpCondicao, typeof(FormCondicao));
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            GeraParcelas();
        }

        private void GeraParcelas()
        {
            if (naoAtualizarParcelas) return;
            parcelasRecalculadas = true;
            var condicaoController = cwkGestao.Negocio.CondicaoController.Instancia;
            if (lkpCondicao.ID > 0 && txtTotalGeral.Value > 0m)
            {
                var condicao = condicaoController.LoadObjectById(lkpCondicao.ID);
                var parcelas = condicaoController.GerarParcelasPedido<ProjetoParcela>(condicao, txtTotalGeral.Value, DateTime.Today);
                parcelas.ForEach(bla => bla.TipoDocumento = condicao.CondicaoParcelas[bla.Parcela - 1].TipoDocumento);
                Parcelas = parcelas;
            }
        }

        private void txtTotalGeral_EditValueChanged(object sender, EventArgs e)
        {
            GeraParcelas();
        }

        private void FormOrcamentoProjeto_Shown(object sender, EventArgs e)
        {
            naoAtualizarParcelas = false;
        }

        private void gvParcelas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _parcelas[e.RowHandle].BAlterado = true;

            objProjeto.TotalGeral = txtTotalGeral.Value;

            lkpCondicao.EditValue = CondicaoController.Instancia.LoadObjectById(((Condicao)lkpCondicao.Selecionado).ID);

            CondicaoController.Instancia.AtualizaParcelas(_parcelas, (Condicao) lkpCondicao.Selecionado, DateTime.Today,
                                                          objProjeto.TotalGeral.Value);
            Parcelas = _parcelas;
            parcelasRecalculadas = true;
        }

        private void lkbBanco_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Banco>(lkpBanco, typeof(FormBanco));
        }

        private void lkbPortador_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Portador>(lkpPortador, typeof(FormPortador));
        }

        private void lkbHistorico_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Historico>(lkpHistorico, typeof(FormHistorico));
        }

        private void lkbAcrescimo_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Acrescimo>(lkpAcrescimo, typeof(FormAcrescimo));
        }

        private void lkbPlanoConta_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.PlanoConta>(lkpPlanoConta, typeof(FormPlanoConta));
        }

        private void lkbPlanoContaServico_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.PlanoConta>(lkpPlanoContaServico, typeof(FormPlanoConta));
        }

        private void gvServicos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Caption == "Agrupamento")
            {
                List<ProjetoServicogrid> servicos = (List<ProjetoServicogrid>)gcServicos.DataSource ?? new List<ProjetoServicogrid>();
                if(servicos.Where(blz => blz.Agrupamento == Convert.ToInt32(cbAgrupamentoServico.Items[cbAgrupamentoServico.Items.Count-1])).Count()> 0)
                    cbAgrupamentoServico.Items.Add((servicos.OrderBy(blz => blz.Agrupamento).Last().Agrupamento + 1));
            }
        }

        private decimal PegaValorColunaValor()
        {
            decimal ValorTotal = 0;

            for (int i = 0; i < gvParcelas.RowCount; i++)
            {
                ValorTotal += Convert.ToDecimal(gvParcelas.GetRowCellValue(i, "Valor"));
            }

            return ValorTotal;
        }
    }

    public class ProjetoProdutoGrid
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Total { get; set; }
        public int IDProduto { get; set; }
    }

    public class ProjetoServicogrid
    {
        public ProjetoServicogrid()
        {
            Agrupamento = 1;
        }

        public int Codigo { get; set; }
        public String Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Total { get; set; }
        public int IDServico { get; set; }
        public int Agrupamento { get; set; }




    }
}