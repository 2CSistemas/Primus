using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormInformacoesAdicionais : Form
    {
        public Modelo.ItensOrcamento objItem { get; set; }
        private PedidoItem pedidoItem;
        public bool retorno { get; set; }
        public FormInformacoesAdicionais(Modelo.ItensOrcamento pItem)
        {
            InitializeComponent();
            objItem = pItem;
            CarregaTela();
        }

        public FormInformacoesAdicionais(PedidoItem _pedidoItem)
        {
            InitializeComponent();
            pedidoItem = _pedidoItem;
            CarregaTela();
        }
        public void CarregaTela()
        {
            try
            {
                txtSequencia.Text = objItem.Sequencia.ToString();
                txtDescricao.Text = objItem.Descricao;
                txtInformacoes.Text = objItem.InformacoesAdicionais;
                txtAplicacao.Text = objItem.AplicacaoCompra;
                txtICMSCompra.EditValue = objItem.ICMSCompra;
                txtIPICompra.EditValue = objItem.IPICompra;
            }
            catch
            {
                txtSequencia.Text = pedidoItem.Sequencia.ToString();
                txtDescricao.Text = pedidoItem.ProdutoNome;
                txtInformacoes.Text = pedidoItem.InformacoesAdicionais;
                txtAplicacao.Text = pedidoItem.AplicacaoCompra;
                txtICMSCompra.EditValue = pedidoItem.ICMSCompra;
                txtIPICompra.EditValue = pedidoItem.IPICompra;
            }
        }
        public void CarregaObjeto()
        {
            try
            {
                objItem.InformacoesAdicionais = txtInformacoes.Text;
                objItem.AplicacaoCompra = txtAplicacao.Text;
                objItem.ICMSCompra = Convert.ToDecimal(txtICMSCompra.EditValue);
                objItem.IPICompra = Convert.ToDecimal(txtIPICompra.EditValue);
            }
            catch
            {
                pedidoItem.InformacoesAdicionais = txtInformacoes.Text;
                pedidoItem.AplicacaoCompra = txtAplicacao.Text;
                pedidoItem.ICMSCompra = Convert.ToDecimal(txtICMSCompra.EditValue);
                pedidoItem.IPICompra = Convert.ToDecimal(txtIPICompra.EditValue);
            }
        }

        private void sbOk_Click(object sender, EventArgs e)
        {
            retorno = true;
            CarregaObjeto();
            this.Close();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            retorno = false;
            this.Close();
        }

        private void FormInformacoesAdicionais_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    sbOk.Focus();
                    sbOk_Click(sender, e);
                    break;
                case Keys.Escape:
                    sbCancelar.Focus();
                    sbCancelar_Click(sender, e);
                    break;
            }
        }
    }
}
