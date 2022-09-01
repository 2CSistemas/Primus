using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Aplicacao
{
    public partial class FormManutOrdemProducaoExecucao : Aplicacao.Base.ManutBase
    {
        private Modelo.OrdemProducaoExecucao objOrdemProducaoExecucao = new Modelo.OrdemProducaoExecucao();
        private Modelo.Funcionario objFuncionario = new Modelo.Funcionario();
        private Modelo.Servico objServico = new Modelo.Servico();
        private int IdOrdemProducao = 0;

        public FormManutOrdemProducaoExecucao(Modelo.DataClassesDataContext db, int pIdOrdemServico)
        {
            InitializeComponent();
            IdOrdemProducao = pIdOrdemServico;
            if (db != null)
                this.db = db;
            else
                this.db = new Modelo.DataClassesDataContext();

            lkServico.ContextoLinq = this.db;
            lkFuncionario.ContextoLinq = this.db;
            this.lkServico.OnIDChanged += new System.EventHandler(this.lkServico_IDChanged);
        }

        private void lkServico_IDChanged(object sender, EventArgs e)
        {
            if (lkServico.Text.Contains('|'))
            {
                string[] aux = lkServico.Text.Split(new char[] { '|' });
                txtDescricao.EditValue = aux[0];
            }
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objOrdemProducaoExecucao = new Modelo.OrdemProducaoExecucao();
                    db.OrdemProducaoExecucaos.InsertOnSubmit(objOrdemProducaoExecucao);
                    txtSequencia.EditValue = objOrdemProducaoExecucao.RetornaMAXCodigo(db, IdOrdemProducao);
                    objOrdemProducaoExecucao.IdOrdemProducao = IdOrdemProducao;
                    break;
                default:
                    objOrdemProducaoExecucao = db.OrdemProducaoExecucaos.Where(p => p.ID == cwID).First();

                    if (cwAcao == 3)
                    {
                        db.OrdemProducaoExecucaos.DeleteOnSubmit(objOrdemProducaoExecucao);
                    }
                    txtSequencia.EditValue = objOrdemProducaoExecucao.Sequencia;
                    txtQuantidade.EditValue = objOrdemProducaoExecucao.Quantidade;
                    timeDataInicio.EditValue = objOrdemProducaoExecucao.DataInicio;
                    timeDataTermino.EditValue = objOrdemProducaoExecucao.DataTermino;
                    lkServico.ID = objOrdemProducaoExecucao.IdServico;
                    lkServico.Localizar(lkServico.ID);
                    txtDescricao.EditValue = objOrdemProducaoExecucao.Descricao;
                    if (objOrdemProducaoExecucao.IdFuncionario.HasValue)
                    {
                        lkFuncionario.ID = objOrdemProducaoExecucao.IdFuncionario.Value;
                        lkFuncionario.Localizar(lkFuncionario.ID);
                    }
                    if (objOrdemProducaoExecucao.DataInicio.HasValue)
                        txtDataInicio.DateTime = objOrdemProducaoExecucao.DataInicio.Value;
                    if (objOrdemProducaoExecucao.DataTermino.HasValue)
                        txtDataTermino.DateTime = objOrdemProducaoExecucao.DataTermino.Value;

                    if (cwAcao == 4)
                    {
                        sbGravar.Enabled = false;
                    }
                    break;
            }
            base.CarregaObjeto();
        }

        public override Dictionary<string, string> Salvar()
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if (lkFuncionario.ID == 0)
                objOrdemProducaoExecucao.IdFuncionario = null;
            else
                if (lkFuncionario.ID > 0)
                    objOrdemProducaoExecucao.IdFuncionario = lkFuncionario.ID;
            if (lkServico.ID > 0)
                objOrdemProducaoExecucao.IdServico = lkServico.ID;
            if (txtQuantidade.EditValue != null && Convert.ToDouble(txtQuantidade.EditValue) > 0)
                objOrdemProducaoExecucao.Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
            if (txtSequencia.EditValue != null && Convert.ToInt16(txtSequencia.EditValue) > 0)
                objOrdemProducaoExecucao.Sequencia = Convert.ToInt16(txtSequencia.EditValue);
            objOrdemProducaoExecucao.Descricao = txtDescricao.Text;

            objOrdemProducaoExecucao.DataInicio = txtDataInicio.EditValue != null ? (DateTime?)txtDataInicio.DateTime : null;
            objOrdemProducaoExecucao.DataTermino = txtDataTermino.EditValue != null ? (DateTime?)txtDataTermino.DateTime : null;

            ret = BLL.OrdemProducaoExecucao.Salvar(db, objOrdemProducaoExecucao);
            return ret;
        }

        private void lkbServico_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Servico servicoSelecionado = null;
            if (lkServico.ID > 0)
                servicoSelecionado = cwkGestao.Negocio.ServicoController.Instancia.LoadObjectById(lkServico.ID);

            GridGenerica<cwkGestao.Modelo.Servico> grid = new GridGenerica<cwkGestao.Modelo.Servico>(cwkGestao.Negocio.ServicoController.Instancia.GetAll(), new FormServico(), servicoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();
                
                if (grid.Selecionado != null)
                {
                    lkServico.Localizar(grid.Selecionado.ID);
                }
            }
            lkServico.Focus();
        }

        private void lkbFuncionario_Click(object sender, EventArgs e)
        {
            GridPadrao pGp = new GridPadrao("Tabela de Funcionário", true, lkFuncionario.ID);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                {
                    int id = Modelo.Funcionario.GetID(db, int.Parse(pGp.Retorno));
                    if (id > 0)
                        lkFuncionario.Localizar(id);
                }
            }
            lkFuncionario.Focus();
        }
    }
}
