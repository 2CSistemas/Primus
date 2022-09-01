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
    public partial class FormNCM : Aplicacao.IntermediariasTela.FormManutNCMIntermediaria
    {
        public FormNCM()
        {

        }
        public void CarregarCampos()
        {
            if (Selecionado.CST_Cofins == 0)
            {
                cbeCST_Cofins.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < cbeCST_Cofins.Properties.Items.Count; i++)
                {
                    int cst = Convert.ToInt32(((string)cbeCST_Cofins.Properties.Items[i]).Substring(0, 2));
                    if (cst == Selecionado.CST_Cofins)
                    {
                        cbeCST_Cofins.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (Selecionado.CST_Ipi == 0)
            {
                cbeCST_IPI.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < cbeCST_IPI.Properties.Items.Count; i++)
                {
                    int cst = Convert.ToInt32(((string)cbeCST_IPI.Properties.Items[i]).Substring(0, 2));
                    if (cst == Selecionado.CST_Ipi)
                    {
                        cbeCST_IPI.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (Selecionado.CST_Pis == 0)
            {
                cbeCST_Pis.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < cbeCST_Pis.Properties.Items.Count; i++)
                {
                    int cst = Convert.ToInt32(((string)cbeCST_Pis.Properties.Items[i]).Substring(0, 2));
                    if (cst == Selecionado.CST_Pis)
                    {
                        cbeCST_Pis.SelectedIndex = i;
                        break;
                    }
                }
            }

            txtCofins.EditValue = Selecionado.Cofins;
            txtEnqGeral.EditValue = Selecionado.EnqGeral;
            txtIpi.EditValue = Selecionado.Ipi;
            txtPis.EditValue = Selecionado.Pis;
            txtCest.EditValue = Selecionado.Cest;

            txtNacionalFederal.EditValue = Selecionado.NacionalFederal;
            txtImportadosFederal.EditValue = Selecionado.ImportadosFederal;
            txtEstadual.EditValue = Selecionado.Estadual;
            txtMunicipal.EditValue = Selecionado.Municipal;

            txtDtRevogacao.EditValue = Selecionado.DtRevogacao;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            object[] parms = new[] { new NCMItem() { NCM = Selecionado } };
            Type formType = typeof(FormNCMItem);

            btIncluirNCMItens.SubFormType = btAlterarNCMItens.SubFormType = btExcluirNCMItens.SubFormType = btConsultarNCMItens.SubFormType = formType;
            btIncluirNCMItens.SubFormTypeParams = btAlterarNCMItens.SubFormTypeParams = btExcluirNCMItens.SubFormTypeParams = btConsultarNCMItens.SubFormTypeParams = parms;

            //var formNCMItem = new FormNCMItem() { Selecionado = new NCMItem() { NCM = Selecionado } };
            //btIncluirNCMItens.SubForm = formNCMItem;
            //btAlterarNCMItens.SubForm = formNCMItem;
            //btExcluirNCMItens.SubForm = formNCMItem;
            //btConsultarNCMItens.SubForm = formNCMItem;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (Obrigatório() == false)
            {
                return;
            }

            if (cbeCST_Cofins.EditValue != null)
            {
                Selecionado.CST_Cofins = Convert.ToInt32(cbeCST_Cofins.EditValue.ToString().Substring(0, 2));
                Selecionado.Cofins = Convert.ToDecimal(txtCofins.EditValue);
            }

            if (cbeCST_IPI.EditValue != null)
            {
                Selecionado.CST_Ipi = Convert.ToInt32(cbeCST_IPI.EditValue.ToString().Substring(0, 2));
                Selecionado.EnqGeral = Convert.ToInt32(txtEnqGeral.EditValue);
                Selecionado.Ipi = Convert.ToDecimal(txtIpi.EditValue);
            }

            if (cbeCST_Pis.EditValue != null)
            {
                Selecionado.CST_Pis = Convert.ToInt32(cbeCST_Pis.EditValue.ToString().Substring(0, 2));
                Selecionado.Pis = Convert.ToDecimal(txtPis.EditValue);
            }

            if (txtCest.EditValue != null)
                Selecionado.Cest = txtCest.Text.Replace(".", "");

            Selecionado.NacionalFederal = Convert.ToDecimal(txtNacionalFederal.EditValue);
            Selecionado.ImportadosFederal = Convert.ToDecimal(txtImportadosFederal.EditValue);
            Selecionado.Estadual = Convert.ToDecimal(txtEstadual.EditValue);
            Selecionado.Municipal = Convert.ToDecimal(txtMunicipal.EditValue);
            Selecionado.DtRevogacao = Convert.ToDateTime(txtDtRevogacao.EditValue);

            base.sbGravar_Click(sender, e);
        }

        private bool Obrigatório()
        {
            if (txtEnqGeral.Text.Length == 0 || Convert.ToInt32(txtEnqGeral.Text) == 0)
            {
                dxErroProvider.SetError(txtEnqGeral, "Valor não pode ser nulo ou igual a 0 ");
                return false;
            }

            return true;
        }

        private void FormNCM_Load(object sender, EventArgs e)
        {
            CarregarCampos();
        }

        private void TxtEnqGeral_Enter(object sender, EventArgs e)
        {
            dxErroProvider.ClearErrors();
        }
    }
}
