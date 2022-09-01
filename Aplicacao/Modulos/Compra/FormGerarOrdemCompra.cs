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
using Aplicacao.Util;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormGerarOrdemCompra : Form
    {
        private IList<Pessoa> fornecedores;
        private Cotacao cotacao;
        public FormGerarOrdemCompra(Cotacao _cotacao)
        {
            InitializeComponent();

            cotacao = CotacaoController.Instancia.LoadObjectById(_cotacao.ID);

            lkpCotacao.Sessao = CotacaoController.Instancia.getSession();
            lkpCotacao.Exemplo = new Cotacao() {TipoCotacao = TipoCotacao.Cotação};
            lkpCotacao.Localizar(cotacao.ID);

            fornecedores = new List<Pessoa>();
            if (cotacao.IDFornecedor_01 != 0) fornecedores.Add(PessoaController.Instancia.LoadObjectById(cotacao.IDFornecedor_01));
            if (cotacao.IDFornecedor_02 != 0) fornecedores.Add(PessoaController.Instancia.LoadObjectById(cotacao.IDFornecedor_02));
            if (cotacao.IDFornecedor_03 != 0) fornecedores.Add(PessoaController.Instancia.LoadObjectById(cotacao.IDFornecedor_03));
            if (cotacao.IDFornecedor_04 != 0) fornecedores.Add(PessoaController.Instancia.LoadObjectById(cotacao.IDFornecedor_04));
            if (cotacao.IDFornecedor_05 != 0) fornecedores.Add(PessoaController.Instancia.LoadObjectById(cotacao.IDFornecedor_05));
            if (cotacao.IDFornecedor_06 != 0) fornecedores.Add(PessoaController.Instancia.LoadObjectById(cotacao.IDFornecedor_06));

            lkpCotacao.Properties.ReadOnly = true;

            txtData.DateTime = DateTime.Today;
            txtValidade.DateTime = DateTime.Today;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkbCotacao_Click(object sender, EventArgs e)
        {
            if (!lkpCotacao.Properties.ReadOnly)
                LookupUtil.GridLookup<Cotacao>(lkpCotacao, typeof(FormCotacao));
        }

        private void btGerarOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                cotacao.DtBaixa = DateTime.Now;
                switch(cbTipo.SelectedIndex)
                {
                    case 0:
                        Pedido pedido = CotacaoController.Instancia.GerarPedidoMenorPrecoTotal((Cotacao) lkpCotacao.Selecionado, txtData.DateTime, txtValidade.DateTime);
                        PedidoController.Instancia.RegisterNewIntoTransaction(pedido);
                        CotacaoController.Instancia.RegisterNewIntoTransaction(cotacao);
                        PedidoController.Instancia.CommitUnitOfWorkTransaction();
                        MessageBox.Show("Pedido gerado com sucesso.", "Cwork Gestão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        IList<Pedido> pedidos = CotacaoController.Instancia.GerarPedidoMenorPrecoProduto((Cotacao) lkpCotacao.Selecionado, txtData.DateTime, txtValidade.DateTime);
                        PedidoController.Instancia.RegisterNewIntoTransaction(pedidos);
                        CotacaoController.Instancia.RegisterNewIntoTransaction(cotacao);
                        PedidoController.Instancia.CommitUnitOfWorkTransaction();
                        MessageBox.Show(String.Format("Pedidos gerado com sucesso.\nForam gerados {0} pedidos.", pedidos.Count), "Cwork Gestão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        Pedido pedidoForn = CotacaoController.Instancia.GerarPedidoDeFornecedor((Cotacao)lkpCotacao.Selecionado, (Pessoa) cbFornecedor.EditValue, txtData.DateTime, txtValidade.DateTime);
                        PedidoController.Instancia.RegisterNewIntoTransaction(pedidoForn);
                        CotacaoController.Instancia.RegisterNewIntoTransaction(cotacao);
                        PedidoController.Instancia.CommitUnitOfWorkTransaction();
                        MessageBox.Show("Pedido gerado com sucesso.", "Cwork Gestão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                this.Close();
            }
            catch (Exception exception)
            {
                PedidoController.Instancia.RollBackUnitOfWorkTransaction();
                new FormErro(exception).ShowDialog();
            }
        }

        private void FormGerarOrdemCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 2)
            {
                cbFornecedor.Properties.Items.AddRange(fornecedores.ToArray());
                cbFornecedor.SelectedIndex = 0;
                cbFornecedor.Enabled = true;
            }
            else
            {
                cbFornecedor.Properties.Items.Clear();
                cbFornecedor.SelectedIndex = -1;
                cbFornecedor.Enabled = false;
            }
        }



    }
}
