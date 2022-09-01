using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Util;
using System.Reflection;

namespace Aplicacao
{
    public partial class FormDadosFornecedor : Aplicacao.IntermediariasTela.FormManutDadosFornecedorCotacaoIntermediaria
    {
        private int FornecedorIndex = 0;
        public FormDadosFornecedor(int fornecedorIndex)
        {
            FornecedorIndex = fornecedorIndex;
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpCondicao.Exemplo = new Condicao();
            lkpCondicao.Sessao = CondicaoController.Instancia.getSession();
            Operacao = Acao.NaoPersistir ^ Acao.Alterar;
        }
        protected override void TelaProObjeto(Control pai)
        {
            SetPropertyValue("Desconto", txtDesconto.EditValue);
            SetPropertyValue("Frete", txtFrete.EditValue);
            SetPropertyValue("IPI", txtIPI.EditValue);
            SetPropertyValue("IDCondicao", lkpCondicao.ID);
            SetPropertyValue("PrazoEntrega", txtPrazo.EditValue);
        }
        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            Pessoa fornecedor = PessoaController.Instancia.LoadObjectById((int)Selecionado.GetType().GetProperty("IDFornecedor_0" + FornecedorIndex).GetValue(Selecionado, null));
            lblFornecedorNome.Text = fornecedor.Nome;
            txtCodigo.EditValue = Selecionado.Codigo;
            lkpCondicao.EditValue = CondicaoController.Instancia.LoadObjectById((int)GetPropertyValue("IDCondicao"));
            txtDesconto.EditValue = GetPropertyValue("Desconto");
            txtFrete.EditValue = GetPropertyValue("Frete");
            txtIPI.EditValue = GetPropertyValue("IPI");
            txtPrazo.EditValue = GetPropertyValue("PrazoEntrega");
            return new List<Exception>();
        }

        protected override void OK()
        {
            if (ValidarFormulario())
            {
                TelaProObjeto(null);
                Close();
            }
        }

        private object GetPropertyValue(string propriedade)
        {
            Type t = Selecionado.GetType();
            return t.GetProperty(propriedade + "_0" + FornecedorIndex).GetValue(Selecionado, null);
        }

        private void SetPropertyValue(string propriedade, object valor)
        {
            Type t = Selecionado.GetType();
            PropertyInfo property = t.GetProperty(propriedade + "_0" + FornecedorIndex);
            property.SetValue(Selecionado, Convert.ChangeType(valor,property.PropertyType),null);
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Condicao>(lkpCondicao, typeof(FormCondicao));
        }
    }
}
