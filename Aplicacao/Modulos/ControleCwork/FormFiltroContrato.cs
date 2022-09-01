using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormFiltroContrato : Form
    {
        IEnumerable<Contrato> contratos;

        public FormFiltroContrato(IEnumerable<Contrato> contratosSelecionados)
        {
            InitializeComponent();

            contratos = contratosSelecionados;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void sbFaturar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtData.Text))
            {
                MessageBox.Show("Digite uma data de vencimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Erros = "Contratos com erros:";
            bool Sucesso = true;

            foreach (var item in contratos)
            {
                Contrato contrato = ContratoController.Instancia.LoadObjectById(item.ID);

                if (ContratoController.Instancia.GerarNotaContrato(contrato, (DateTime)txtData.EditValue) != null)
                {
                    Erros += ContratoController.Instancia.GerarNotaContrato(contrato, (DateTime)txtData.EditValue);
                    Sucesso = false;
                }
            }

            if (Sucesso)
                MessageBox.Show("Nota(s) gerada(s) com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Erros, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
