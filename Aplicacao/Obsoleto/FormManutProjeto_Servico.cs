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
    public partial class FormManutProjeto_Servico : Aplicacao.Base.ManutBase
    {
        private Modelo.Projeto_ProdutoServico objProjeto_ProdutoServico;
        private Modelo.Projeto objProjeto;

        public FormManutProjeto_Servico(Modelo.DataClassesDataContext pDb, Modelo.Projeto pProjeto)
        {
            InitializeComponent();
            this.Name = "FormManutProjeto_Servico";
            db = pDb;
            lkServico.ContextoLinq = db;
            objProjeto = pProjeto;
            lkServico.OnIDChanged += new EventHandler(lkServico_IDChanged);
        }

        public override void CarregaObjeto()
        {
            if (cwAcao == 1)
            {
                objProjeto_ProdutoServico = new Modelo.Projeto_ProdutoServico();
            }
            else
            {
                objProjeto_ProdutoServico = objProjeto.Projeto_ProdutoServicos.Where(p => p.IDServico == cwID).First();
                txtQuantidade.Value = objProjeto_ProdutoServico.Quantidade;
                lkServico.ID = objProjeto_ProdutoServico.IDServico.Value;
                lkServico.Localizar(lkServico.ID);
                lkServico.Properties.ReadOnly = true;
                lkbServico.Enabled = false;
                txtValorUnitario.Value = objProjeto_ProdutoServico.ValorUnitario;
            }
        }

        public override Dictionary<string, string> Salvar()
        {
            if (cwAcao != 3)
            {
                objProjeto_ProdutoServico.IDServico = lkServico.ID;
                objProjeto_ProdutoServico.Quantidade = txtQuantidade.Value;
                objProjeto_ProdutoServico.ValorUnitario = txtValorUnitario.Value;
            }

            return BLL.Projeto.SalvarServicoItem(db, objProjeto, objProjeto_ProdutoServico, cwAcao);
        }

        private void lkServico_IDChanged(object sender, EventArgs e)
        {
            if (lkServico.ID > 0)
            {
                var servico = cwkGestao.Negocio.ServicoController.Instancia.LoadObjectById(lkServico.ID);
                txtValorUnitario.Value = servico.Valor;
            }
        }

        private void lkbProduto_Click(object sender, EventArgs e)
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

        private void txtValorUnitario_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void txtQuantidade_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void AtualizarValorTotal()
        {
            txtValorTotal.Value = txtValorUnitario.Value * txtQuantidade.Value;
        }
    }
}
