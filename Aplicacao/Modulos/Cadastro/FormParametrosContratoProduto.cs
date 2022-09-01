using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes;
using cwkGestao.Negocio;
using Aplicacao.Base;
using System.Windows.Forms;
using cwkGestao.Integracao.Magento.Exportacao;
using System.Threading;
using Aplicacao.Util;
using System.IO;
using System.Xml.Linq;
using Aplicacao.Util.Telas;
using Cwork.Utilitarios.Componentes.Mascaras;
using System.Drawing;

namespace Aplicacao
{
    public partial class FormParametrosContratoProduto : IntermediariasTela.FormManutParametrosContratoProdutoIntermediaria
    {
        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkbFilial.SubFormType = typeof(FormFilial);

            lkbTipoNota.SubFormType = typeof(FormTipoNota);
            lkpTipoNota.Exemplo = new TipoNota { Categoria = TipoNota.CategoriaMovimentacao.Produtos };
            lkpTipoNota.CamposRestricoesAND = new List<string> { "Categoria" };

            lkbTipoPedido.SubFormType = typeof(FormTipoPedido);
            lkbTabelaPreco.SubFormType = typeof(FormTabelaPreco);
           
            lkbTipoNotaServico.SubFormType = typeof(FormTipoNota);
            lkpTipoNotaServico.Exemplo = new TipoNota { Categoria = TipoNota.CategoriaMovimentacao.Servicos };
            lkpTipoNotaServico.CamposRestricoesAND = new List<string> { "Categoria" };

            lkbEquipamento.SubFormType = typeof(FormOSEquipamento);

            lkbVendedor.SubFormType = typeof(FormPessoa);
            lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };

            tabProduto.Tag = Selecionado;
            tabServicos.Tag = Selecionado;

        }

        private void FormParametrosContratoProduto_Load(object sender, EventArgs e)
        {
            if (lkpTipoNota.EditValue != null)
            {
                lkpTipoNota.Localizar(Selecionado.TipoNota.ID);
                lkpTipoNotaServico.Localizar(Selecionado.TipoNotaServico.ID);
            }
        }


        protected override void TelaProObjeto(Control pai)
        {
            Selecionado.TipoNota = (TipoNota)lkpTipoNota.Selecionado;
            Selecionado.TipoNotaServico = (TipoNota)lkpTipoNotaServico.Selecionado;
            base.TelaProObjeto(pai);
        }
    }
}
