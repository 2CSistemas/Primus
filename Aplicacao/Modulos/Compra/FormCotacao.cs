using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormCotacao : Aplicacao.IntermediariasTela.FormManutCotacaoIntermediaria
    {
        private bool carregado = false;
        private IList<Pessoa> fornecedores;
        private readonly List<Componentes.devexpress.cwk_DevLookup> combosFornecedores = new List<Componentes.devexpress.cwk_DevLookup>();

        private IEnumerable<int> IDsSelecionados(int indiceAtual)
        {
            for (int i = 0; i <= indiceAtual; i++)
            {
                yield return (int)combosFornecedores[i].EditValue;
            }
        }

        public FormCotacao()
        {
        }

        private void DiscriminaTabs()
        {
            tpPrincipal.Tag = Selecionado;
            tcCadastro.Tag = Selecionado;
            tpDados.Tag = Selecionado;
            tpFornecedores.Tag = Selecionado;
        }

        protected override void SelecionadoValueChanged()
        {
            base.SelecionadoValueChanged();
            if (Selecionado != null) 
            Selecionado.CotacaoProdutos = Selecionado.CotacaoProdutos.Distinct().ToList();
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            combosFornecedores.Clear();
            combosFornecedores.AddRange
            (
                (from Control c in tpFornecedores.Controls
                 where c.Name.Contains("cbIDFornecedor")
                 && c.GetType().Equals(typeof(Componentes.devexpress.cwk_DevLookup))
                 orderby c.TabIndex
                 select (Componentes.devexpress.cwk_DevLookup)c)
            );

            DiscriminaTabs();

            //var formCotacaoProduto = new FormCotacaoProduto() { Selecionado = new CotacaoProduto { Cotacao = Selecionado } };
            //btAlterar.SubForm = formCotacaoProduto;
            //btConsultar.SubForm = formCotacaoProduto;
            //btExcluir.SubForm = formCotacaoProduto;
            //btIncluir.SubForm = formCotacaoProduto;

            //lkbFilial.SubForm = new FormFilial();

            object[] parms = new[] { new CotacaoProduto { Cotacao = Selecionado } };
            Type formType = typeof(FormCotacaoProduto);

            btAlterar.SubFormType = btConsultar.SubFormType = btExcluir.SubFormType = btIncluir.SubFormType = formType;
            btAlterar.SubFormTypeParams = btConsultar.SubFormTypeParams = btExcluir.SubFormTypeParams = btIncluir.SubFormTypeParams = parms;

            //lkbFilial.SubForm = new FormFilial();
            lkbFilial.SubFormType = typeof(FormFilial);
        }

        public object[] retornaListaParametros()
        {
            IList<object> parametrosList = new List<object>();
            parametrosList.Add(Selecionado);
            return parametrosList.ToArray();
        }
        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            DiscriminaTabs();
            cbTipoCotacao.Enabled = true;
            fornecedores = cwkGestao.Negocio.PessoaController.Instancia.GetAllFornecedores();
            cbIDFornecedor_01.Properties.DataSource = fornecedores;
            carregado = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //A atribuição dos valores deve ser feita na ordem correta 
            //para que os combos fiquem habilitados corretamente
            foreach (var combo in combosFornecedores)
            {
                combo.EditValue = null;
                if (!combo.Equals(cbIDFornecedor_01))
                    combo.Enabled = combo.ButtonLookup.Enabled = false;
            }

            if (cbTipoCotacao.SelectedIndex == 1 && Operacao == Acao.Alterar)
                cbTipoCotacao.Enabled = false;

            carregado = true;
            cbIDFornecedor_01.EditValue = Selecionado.IDFornecedor_01;
            cbIDFornecedor_02.EditValue = Selecionado.IDFornecedor_02;
            cbIDFornecedor_03.EditValue = Selecionado.IDFornecedor_03;
            cbIDFornecedor_04.EditValue = Selecionado.IDFornecedor_04;
            cbIDFornecedor_05.EditValue = Selecionado.IDFornecedor_05;
            cbIDFornecedor_06.EditValue = Selecionado.IDFornecedor_06;
        }

        private void cbIDFornecedor_EditValueChanged(object sender, EventArgs e)
        {
            if (carregado && sender.GetType().Equals(typeof(Componentes.devexpress.cwk_DevLookup)))
            {
                var comboAtual = (Componentes.devexpress.cwk_DevLookup)sender;
                var indice = combosFornecedores.IndexOf(comboAtual);
                var proximoIndice = indice + 1;

                if (indice > -1 && proximoIndice < combosFornecedores.Count)
                {
                    var proximoCombo = combosFornecedores[proximoIndice];
                    if (combosFornecedores[indice].EditValue != null && (int)combosFornecedores[indice].EditValue > 0)
                    {
                        proximoCombo.Enabled = proximoCombo.ButtonLookup.Enabled = true;
                        proximoCombo.Properties.DataSource = fornecedores.Where(f => !IDsSelecionados(indice).Contains(f.ID)).ToList();
                    }
                    else
                    {
                        proximoCombo.Enabled = proximoCombo.ButtonLookup.Enabled = false;
                        proximoCombo.Properties.DataSource = null;
                    }
                    proximoCombo.EditValue = 0;
                }
            }
        }

        private void cbTipoCotacao_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTipoCotacao.SelectedIndex == 0)
            {
                if (tcCadastro.TabPages.Contains(tpFornecedores))
                    tcCadastro.TabPages.Remove(tpFornecedores);
            }
            else if (cbTipoCotacao.SelectedIndex == 1)
            {
                if (!tcCadastro.TabPages.Contains(tpFornecedores))
                    tcCadastro.TabPages.Add(tpFornecedores);
            }
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            var ret = base.ObjetoPraTela(pai);

            return ret;
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            if (pai.Equals(tpDados))
                Selecionado.TipoCotacao = (TipoCotacao)cbTipoCotacao.SelectedIndex;

            if (pai.Equals(tpFornecedores))
            {
                Selecionado.IDFornecedor_01 = (int)cbIDFornecedor_01.EditValue;
                Selecionado.IDFornecedor_02 = (int)cbIDFornecedor_02.EditValue;
                Selecionado.IDFornecedor_03 = (int)cbIDFornecedor_03.EditValue;
                Selecionado.IDFornecedor_04 = (int)cbIDFornecedor_04.EditValue;
                Selecionado.IDFornecedor_05 = (int)cbIDFornecedor_05.EditValue;
                Selecionado.IDFornecedor_06 = (int)cbIDFornecedor_06.EditValue;
            }

            if (Operacao == Acao.Incluir)
            {
                Selecionado.Dt = DateTime.Today;
            }
        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            var botao = (Componentes.devexpress.cwk_DevButton)sender;
            var combo = combosFornecedores.Where(c => c.ButtonLookup.Equals(botao)).First();

            Pessoa selecionado = null;
            if ((int)combo.EditValue > 0)
                selecionado = PessoaController.Instancia.LoadObjectById((int)combo.EditValue);

            var grid = new GridCliente((IList<Pessoa>)combo.Properties.DataSource, new FormPessoa(), selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
                combo.EditValue = grid.Selecionado.ID;
        }

        protected override bool ValidarFormulario()
        {
            bool ret = base.ValidarFormulario();

            if (cbTipoCotacao.SelectedIndex == 1)
            {
                if (cbIDFornecedor_01.EditValue == null || (int)cbIDFornecedor_01.EditValue == 0)
                {
                    dxErroProvider.SetError(cbIDFornecedor_01, "Campo obrigatório.");
                    ret = false;
                }
            }

            return ret;
        }

        protected override void OK()
        {
            if (String.IsNullOrEmpty(txtObservacao.Text))
                txtObservacao.Text = "";

            base.OK();
        }
    }
}
