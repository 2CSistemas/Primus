using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Contratos;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormAlterandoRegistroFCI : Form
    {
        pxyProdutoFCI pxyRetornoFCI;
        pxyProdutoFCI pFCIcarregado = new pxyProdutoFCI();
        ProdutoFCI prodFCIParaGravacao;
        pxyProdutoFCI pFCI = new pxyProdutoFCI();
        Acao acaoExecutada;
        bool liberaBloqueiaCheckEdit;
        public FormAlterandoRegistroFCI(Acao acao, pxyProdutoFCI prodFCI)
        {
            InitializeComponent();
            pFCI = prodFCI;
            acaoExecutada = acao;
            if (acao  == Acao.Alterar)
            {
                liberaBloqueiaCheckEdit = true;
                LiberarBloquearCheckEdit(liberaBloqueiaCheckEdit, acao);
                CarregarObjetoParaTela(prodFCI);
            }
            else
            {
                liberaBloqueiaCheckEdit = false;
                LiberarBloquearCheckEdit(liberaBloqueiaCheckEdit, acao);
                CarregarObjetoParaTela(prodFCI);
            }
        }

        private void CarregarObjetoParaTela(pxyProdutoFCI pFCIcarregado)
        {
            cheAtivo.EditValue = pFCIcarregado.bAtivo;
            dtFCI.DateTime = pFCIcarregado.Data;
            txtCodFCI.EditValue = pFCIcarregado.FCI;
        }

        private void LiberarBloquearCheckEdit(bool liberaBloqueiaCheckEdit, Acao acao)
        {
            cheAtivo.Properties.ReadOnly = !liberaBloqueiaCheckEdit;
            if (acao == Acao.Consultar)
                sbOK.Visible = liberaBloqueiaCheckEdit;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            prodFCIParaGravacao = CarregarTelaParaObjeto(pFCI);
            pFCI.bAtivo = prodFCIParaGravacao.bAtivo;

            FecharTela();
        }

        private ProdutoFCI CarregarTelaParaObjeto(pxyProdutoFCI pFCI)
        {
            ProdutoFCI objRetorno = ProdutoFCIController.Instancia.LoadObjectById(pFCI.ID);
            objRetorno.bAtivo = (bool)cheAtivo.EditValue;
            return objRetorno;
        }

        public pxyProdutoFCI DevolvePXYFCIAtualizado()
        {
            return pFCI;         
        }

        public ProdutoFCI DevolveOBJFCIAtualizado() 
        { 
            return prodFCIParaGravacao;
        }

        private void FecharTela()
        {
            this.Close();
        }

    }

        
}
