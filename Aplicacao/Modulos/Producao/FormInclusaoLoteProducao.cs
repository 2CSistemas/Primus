using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using System.Collections.Generic;

namespace Aplicacao.Modulos.Producao
{
    public partial class FormInclusaoLoteProducao : Form
    {
        private bool bAlteracao = false;
        private int idParaAlteracao = 0;
        private PCP_Lote lote = new PCP_Lote();

        public FormInclusaoLoteProducao()
        {
            InitializeComponent();
            txtData.DateTime = DateTime.Today;
        }

        public FormInclusaoLoteProducao(bool alteracao, PCP_Lote pcp_lote)
        {
            InitializeComponent();
            txtCodigo.EditValue = pcp_lote.Codigo;
            txtDescricao.EditValue = pcp_lote.Descricao;
            txtData.EditValue = pcp_lote.Data;
            idParaAlteracao = pcp_lote.ID;
            bAlteracao = alteracao;
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (txtCodigo.EditValue == null)
                dxErrorProvider.SetError(txtCodigo, "Campo obrigatório");
            if (txtDescricao.EditValue == null)
                dxErrorProvider.SetError(txtDescricao, "Campo obrigatório");
            if (txtData.EditValue == null)
                dxErrorProvider.SetError(txtData, "Campo obrigatório");


            return !dxErrorProvider.HasErrors;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Sair()
        {
            this.Close();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void sbOk_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                lote.Codigo = Convert.ToInt32(txtCodigo.EditValue);
                lote.Descricao = Convert.ToString(txtDescricao.EditValue);
                lote.Data = txtData.DateTime;

                if (bAlteracao)
                {
                    lote.ID = idParaAlteracao;
                    
                    PCP_LoteController.Instancia.Salvar(lote, Acao.Alterar);
                    this.Close();
                }
                else
                {
                    PCP_LoteController.Instancia.Salvar(lote, Acao.Incluir);
                    this.Close();
                }
            }
        }

        public PCP_Lote retornaPCP_Lote()
        {
            return lote;
        }
    }
}
