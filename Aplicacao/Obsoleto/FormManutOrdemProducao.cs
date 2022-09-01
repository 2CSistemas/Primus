using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Aplicacao.Util;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormManutOrdemProducao : Aplicacao.Base.ManutBase
    {
        private Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        private Modelo.Cliente objCliente = new Modelo.Cliente();
        private Modelo.Filial objFilial = new Modelo.Filial();
        private Modelo.Projeto objProjeto = new Modelo.Projeto();
        private Modelo.OrdemProducao objOrdemServico;
        private Modelo.OrdemProducaoHistorico objOrdemServicoHistorico;
        private Modelo.ClassificacaoOrdemProducao objClassificacaoOS = new Modelo.ClassificacaoOrdemProducao();
        private int IdClassificacao_Ant = 0;

        public FormManutOrdemProducao()
        {
            InitializeComponent();
            lkPessoa.OnIDChanged += new EventHandler(lkPessoa_IDChanged);
        }

        public override void CarregaObjeto()
        {
            lkFilial.ContextoLinq = db;
            lkPessoa.ContextoLinq = db;
            lkProjeto.ContextoLinq = db;
            lkClassificacao.ContextoLinq = db;
            switch (cwAcao)
            {
                case 1:
                    objOrdemServico = new Modelo.OrdemProducao();
                    txtCodigo.EditValue = objOrdemServico.RetornaMAXCodigo(db);                    
                    break;
                default:
                    objOrdemServico = db.OrdemProducaos.Where(p => p.ID == cwID).First();
                    txtCodigo.EditValue = objOrdemServico.Codigo;
                    IdClassificacao_Ant = Convert.ToInt32(objOrdemServico.IdClassificacaoOrdemProducao);
                    
                    lkPessoa.ID = objOrdemServico.IdCliente;
                    lkPessoa.Localizar(lkPessoa.ID);
                    lkFilial.ID = objOrdemServico.IdFilial;
                    lkFilial.Localizar(lkFilial.ID);
                    if (objOrdemServico.IdProjeto.HasValue)
                    {
                        lkProjeto.ID = objOrdemServico.IdProjeto.Value;
                        lkProjeto.Localizar(lkProjeto.ID);
                    }
                    if (objOrdemServico.IdClassificacaoOrdemProducao.HasValue)
                    {
                        lkClassificacao.ID = objOrdemServico.IdClassificacaoOrdemProducao.Value;
                        lkClassificacao.Localizar(lkClassificacao.ID);
                    }
                    lkProjeto.Properties.ReadOnly = true;
                    lkbProjeto.Enabled = false;
                    break;
            }
            txtDescricao.Text = objOrdemServico.Descricao;
            objOrdemServicoHistorico = new Modelo.OrdemProducaoHistorico();
            gridControl1.DataSource = objOrdemServicoHistorico.getLista(db, objOrdemServico.ID.ToString());
            var x = db.Projeto_ProdutoServicos.Where(pps => pps.IDOrdemProducao == objOrdemServico.ID);
            
            gcServicos.DataSource = x;
            txtProjetoAgrupamento.Text = objOrdemServico.IdProjeto + " - " + (x.FirstOrDefault() == null ? 0 : x.First().Agrupamento);
            base.CarregaObjeto();
        }

        public override Dictionary<string, string> Salvar()
        {            
            if ((lkClassificacao.ID == 0))
            {
                Dictionary<string, string> ret = new Dictionary<string, string>();
                ret.Add("", "");
                MessageBox.Show("É necessário preencher a classificação.");
                return ret;
            }
            else
            {
                objOrdemServico.ClassificacaoOrdemProducao = null;
                objOrdemServico.Codigo = 0;
                objOrdemServico.IdClassificacaoOrdemProducao = null;

                objOrdemServico.Codigo = Convert.ToInt32(txtCodigo.EditValue);

                if (lkClassificacao.ID > 0)
                {
                    //objOrdemServico.IdClassificacaoOrdemProducao = lkClassificacao.ID;
                    try
                    {
                        objOrdemServico.ClassificacaoOrdemProducao = (from c in db.ClassificacaoOrdemProducaos where c.ID == lkClassificacao.ID select c).Single();
                    }
                    catch (Exception ex)
                    {
                    }
                }

                objOrdemServico.IdCliente = lkPessoa.ID;
                objOrdemServico.IdFilial = lkFilial.ID;
                objOrdemServico.IdProjeto = lkProjeto.ID;

                if (IdClassificacao_Ant != objOrdemServico.IdClassificacaoOrdemProducao)
                {
                    objOrdemServicoHistorico.IdClassificacao = objOrdemServico.IdClassificacaoOrdemProducao;
                    objOrdemServicoHistorico.Sequencia = objOrdemServicoHistorico.RetornaMAXCodigo(db, objOrdemServico.ID);
                    objOrdemServicoHistorico.Data = DateTime.Now;
                }
                objOrdemServico.OrdemProducaoHistoricos.Add(objOrdemServicoHistorico);

                switch (cwAcao)
                {
                    case 1:
                        db.OrdemProducaos.InsertOnSubmit(objOrdemServico);
                        break;
                    case 3:
                        db.OrdemProducaos.DeleteOnSubmit(objOrdemServico);
                        break;
                }
                
                if (objOrdemServico.ClassificacaoOrdemProducao.Status == Modelo.StatusOPType.Fechadas && cwAcao == 1)
                {
                    MessageBox.Show("Não pode ser incluída uma ordem de produção com classificação fechada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Dictionary<string, string> ret = new Dictionary<string, string>();
                    ret.Add("", "");
                    return ret;
                }
                else
                {
                    if (objOrdemServico.ClassificacaoOrdemProducao != null)
                    {
                        if (objOrdemServico.ClassificacaoOrdemProducao.Status == Modelo.StatusOPType.Fechadas)
                        {
                            int cont = 0;
                            cont = (from o in db.OrdemProducaos where o.IdProjeto == objOrdemServico.IdProjeto 
                                                                && o.ClassificacaoOrdemProducao.Status != Modelo.StatusOPType.Fechadas
                                    select cont).Count();
                            if(cont <= 1)
                            {
                                Modelo.Projeto objProjeto = (from p in db.Projetos where p.ID == objOrdemServico.IdProjeto select p).Single();
                                objProjeto.Status = 5;
                                db.SubmitChanges();
                            }
                        }
                    }

                    return BLL.OrdemProducao.Salvar(db, objOrdemServico);
                }
            }
        }

        protected void GridSelecaoClassificacao(Base.GridBase pForm, string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.ClassificacaoOrdemProducao gl)
        {
            if (cwkControleUsuario.Facade.ControleAcesso(pForm))
            {
                pForm.ShowDialog();
                if (pForm.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pForm.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pForm.Retorno);
                }
            }
            pCb.Focus();
        }

        private void lkPessoa_IDChanged(object sender, EventArgs e)
        {
            //lkProjeto.ID = 0;
            //lkProjeto.Text = String.Empty;
            //if (lkPessoa.ID > 0)
            //{
            //    lkProjeto.Properties.ReadOnly = false;
            //    lkProjeto.Where = "Projeto.IDPessoa = " + lkPessoa.ID.ToString() + " AND";
            //}
            //else
            //{
            //    lkProjeto.Properties.ReadOnly = true;
            //    lkProjeto.Where = String.Empty;
            //}
            //lkbProjeto.Enabled = !lkProjeto.Properties.ReadOnly;
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkFilial, typeof(FormFilial));
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkPessoa, cwkGestao.Negocio.PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            GridSelecaoProjeto("Tabela de Centro de Custo", lkProjeto);
        }

        private void lkbClassificacao_Click(object sender, EventArgs e)
        {
            GridSelecaoClassificacao(lkClassificacao);
        }

        private void GridSelecaoProjeto(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
            {
                GridProjeto pGp = new GridProjeto(context, ptitulo, true, pLookup.ID, 1);
                if (cwkControleUsuario.Facade.ControleAcesso(pGp))
                {
                    pGp.cwIdPessoa = lkPessoa.ID;
                    pGp.ShowDialog();
                    if (pGp.Retorno.Length != 0)
                        pLookup.Localizar(int.Parse(pGp.Retorno));
                }
                pLookup.Focus();
            }
        }

        private void GridSelecaoClassificacao(Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            cwkGestao.Modelo.ClassificacaoOrdemProducao classificacaoOrdemProducaoSelecionado = null;
            if (pLookup.ID > 0)
                classificacaoOrdemProducaoSelecionado = cwkGestao.Negocio.ClassificacaoOrdemProducaoController.Instancia.LoadObjectById(pLookup.ID);

            GridGenerica<cwkGestao.Modelo.ClassificacaoOrdemProducao> grid = new GridGenerica<cwkGestao.Modelo.ClassificacaoOrdemProducao>(cwkGestao.Negocio.ClassificacaoOrdemProducaoController.Instancia.GetAll(), new FormClassificacaoOrdemProducao(), classificacaoOrdemProducaoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    pLookup.ID = grid.Selecionado.ID;
                    pLookup.Localizar(pLookup.ID);
                }
            }
            pLookup.Focus();
        }

        private void GridSelecao(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, pLookup.ID);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                    pLookup.Localizar(int.Parse(pGp.Retorno));
            }
            pLookup.Focus();
        }
    }
}
