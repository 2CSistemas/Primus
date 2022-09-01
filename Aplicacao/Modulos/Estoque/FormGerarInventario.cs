using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Util;
using Aplicacao.Base;
using cwkGestao.Negocio.ControleEstoque;

namespace Aplicacao.Modulos.Estoque
{
    public partial class FormGerarInventario : Form
    {
        public FormGerarInventario()
        {
            InitializeComponent();

            lkbFilial.SubFormType = typeof(FormFilial);
            lkpFilial.Sessao = FilialController.Instancia.getSession();
            lkpFilial.Exemplo = new Filial();
            lkpFilial.CamposRestricoesAND = new List<string>();

            txtData.DateTime = DateTime.Now.Date;
        }

        private void sbGerar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja gerar o Inventário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GerarInventario();
            }
        }

        private void GerarInventario()
        {
            try
            {
                if (CamposValidos())
                {
                    var gerador = new GeradorInventario((Filial)lkpFilial.Selecionado, txtData.DateTime, (TipoValorProduto)cbTipoPreco.SelectedIndex);

                    Cursor = Cursors.WaitCursor;
                    gerador.Gerar();
                    gerador.CommitarTransacao();
                    Cursor = Cursors.Default;

                    MessageBox.Show("Inventário gerado com sucesso.");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
        }

        private bool CamposValidos()
        {
            dxErrorProvider1.ClearErrors();

            if (lkpFilial.Selecionado == null)
                dxErrorProvider1.SetError(lkpFilial, "Campo obrigatório");
            if (txtData.EditValue == null)
                dxErrorProvider1.SetError(txtData, "Campo obrigatório");
            return !dxErrorProvider1.HasErrors;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkpFilial, typeof(FormFilial));
        }
    }
}
