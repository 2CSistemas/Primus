using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormProdutoMercadoLivre : Aplicacao.IntermediariasTela.FormManutProdutoMercadoLivreIntermediaria
    {
        public ProdutoMercadoLivre produtoSelecionado;
        Acao acao;

        public FormProdutoMercadoLivre(ProdutoMercadoLivre produto, Acao acao)
        {
            if (produto != null)
                produtoSelecionado = produto;
            else
                produtoSelecionado = new ProdutoMercadoLivre();
            if (acao != null)
                this.acao = acao;
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();

		}

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                produtoSelecionado.bAtivo = (bool)chbAtivo.EditValue;
                produtoSelecionado.Descricao = (string)txtTitulo.EditValue;
                produtoSelecionado.MercadoLivre = Int32.Parse(txtCodigo.EditValue.ToString());
                this.Close();
            }           
        }

        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();
            if (txtCodigo.EditValue == null)
                dxErroProvider.SetError(txtCodigo, "Campo obrigatório");
            if (txtTitulo.EditValue == null)
                dxErroProvider.SetError(txtTitulo, "Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        private void FormProdutoMercadoLivre_Shown(object sender, EventArgs e)
        {
            if (produtoSelecionado != null && (acao == Acao.Alterar || acao == Acao.Consultar))
            {
                txtCodigo.EditValue = produtoSelecionado.MercadoLivre;
                txtTitulo.EditValue = produtoSelecionado.Descricao;
                chbAtivo.EditValue = produtoSelecionado.bAtivo;
            }
            if (acao == Acao.Consultar)
            {
                txtTitulo.Enabled = false;
                txtCodigo.Enabled = false;
                chbAtivo.Enabled = false;
                sbGravar.Enabled = false;
            }

        }
    }
}
