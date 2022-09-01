using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormProdutoSKU : Aplicacao.IntermediariasTela.FormManutProdutoSKUIntermediaria
    {
        public FormProdutoSKU()
        {
        }

        public FormProdutoSKU(ProdutoSKU prodSKU)
        {
            Selecionado = prodSKU;
        }

		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (Operacao == (Acao)28 || Operacao == (Acao)31)
            {
                IList<ProdutoSKU> listaSKU = ProdutoSKUController.Instancia.GetProdutoPorSKU(txtSKU.Text);

                if (listaSKU.Count > 0)
                {
                    MessageBox.Show("Operação não permitida. SKU já foi cadastrado anteriormente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            base.sbGravar_Click(sender, e);
        }
    }
}
