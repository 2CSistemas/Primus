using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormNotaServico : Aplicacao.IntermediariasTela.FormManutNotaServicoIntermediaria
    {
        decimal TotalProdutos;
        public FormNotaServico()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            object[] parms = new[] { new NotaServicoItem() { NotaServico = Selecionado } };
            Type formType = typeof(FormNotaServicoItem);

            btIncluirServicos.SubFormType = btAlterarServicos.SubFormType = btExcluirServicos.SubFormType = btConsultarServicos.SubFormType = formType;
            btIncluirServicos.SubFormTypeParams = btAlterarServicos.SubFormTypeParams = btExcluirServicos.SubFormTypeParams = btConsultarServicos.SubFormTypeParams = parms;

            //FormNotaServicoItem formNotaServicoItem = new FormNotaServicoItem() { Selecionado = new NotaServicoItem() { NotaServico = Selecionado } };
            //btIncluirServicos.SubForm = formNotaServicoItem;
            //btAlterarServicos.SubForm = formNotaServicoItem;
            //btExcluirServicos.SubForm = formNotaServicoItem;
            //btConsultarServicos.SubForm = formNotaServicoItem;
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e) //where U : ModeloBase, new()
        {
            TelaProObjeto(tcPrincipal);
            base.btSubRegistro_Click(sender, e);
        }

        protected override void OK()
        {
            try
            {
                Selecionado.ClienteCnpjCpf = ((Pessoa)lkpCliente.Selecionado).CNPJ_CPF;
                Selecionado.ClienteInscricao = ((Pessoa)lkpCliente.Selecionado).Inscricao;
                Selecionado.ClienteNome = ((Pessoa)lkpCliente.Selecionado).Nome;
                Selecionado.ClienteEndereco = (((Pessoa)lkpCliente.Selecionado).PessoaEnderecos).First().Endereco;
                Selecionado.ClienteBairro = (((Pessoa)lkpCliente.Selecionado).PessoaEnderecos).First().Bairro;
                Selecionado.ClienteCep = (((Pessoa)lkpCliente.Selecionado).PessoaEnderecos).First().CEP;
                Selecionado.ClienteCidade = (((Pessoa)lkpCliente.Selecionado).PessoaEnderecos).First().Cidade.Nome;
                Selecionado.ClienteUF = (((Pessoa)lkpCliente.Selecionado).PessoaEnderecos).First().Cidade.UF.Sigla;
                Selecionado.ClienteFone = (((Pessoa)lkpCliente.Selecionado).PessoaTelefones).First(p => p.BPrincipal == true).Numero;
            }
            catch
            {
            }
            base.OK();
        }

        private void gvNotaServicoItems_DataSourceChanged(object sender, EventArgs e)
        {
            TotalProdutos = 0;
            foreach (var item in Selecionado.NotaServicoItems)
            {
                TotalProdutos += item.Total;
            }            
            txtTotalProduto.EditValue = TotalProdutos;
            if(txtDesconto.EditValue != null && txtTotalProduto.EditValue != null)
                txtTotalNota.EditValue = (decimal)txtTotalProduto.EditValue - (decimal)txtDesconto.EditValue;
        }

        private void FormNotaServico_Shown(object sender, EventArgs e)
        {
            txtTotalProduto.Properties.ReadOnly = true;
            txtTotalNota.Properties.ReadOnly = true;
        }

        private void txtDesconto_EditValueChanged(object sender, EventArgs e)
        {
            if (txtDesconto.EditValue != null && txtTotalProduto.EditValue != null)
                txtTotalNota.EditValue = (decimal)txtTotalProduto.EditValue - (decimal)txtDesconto.EditValue;
        }

        private void btnlkpCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpCliente, cwkGestao.Negocio.PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));

            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAll(), (cwkGestao.Modelo.Pessoa)lkpCliente.Selecionado, null, false, null, null, null, typeof(FormPessoa));
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();
            lkpCliente.EditValue = grid.Selecionado;
        }

        private void btnlkpCondicao_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Condicao> grid = 
                new GridGenerica<cwkGestao.Modelo.Condicao>(CondicaoController.Instancia.GetAll(), 
                    (cwkGestao.Modelo.Condicao)lkpCondicao.Selecionado, null, false, 
                    null, null, null, typeof(FormCondicao));

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();
            lkpCondicao.EditValue = grid.Selecionado;
        }

        private void btnlkpFilial_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkpFilial, typeof(FormFilial));
        }
    }
}
