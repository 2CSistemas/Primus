using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormAtualizarProdutos : Aplicacao.IntermediariasTela.FormManutProdutoIntermediaria
    {
        public FormAtualizarProdutos()
        {

        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            sbGravar.Text = "OK";
            this.Text = "Atualizar Produtos";
            rgOpcao.SelectedIndex = 0;
            rgOpcao_SelectedIndexChanged(null, null);
        }

        private void rgOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgOpcao.SelectedIndex < 0) return;
            txtNCM.Enabled = rgOpcao.EditValue.Equals(0);
            if (!rgOpcao.EditValue.Equals(0))
                txtNCM.Text = String.Empty;
            txtCST.Enabled = rgOpcao.EditValue.Equals(1);
            txtCST.Visible = !rgOpcao.EditValue.Equals(2);
            txtCSOSN.Enabled = rgOpcao.EditValue.Equals(2);
            txtCSOSN.Visible = rgOpcao.EditValue.Equals(2);
            lblCSTCSOSN.Text = rgOpcao.EditValue.Equals(2) ? "CSOSN: " : "    CST: ";
        }

        protected override bool ValidarFormulario()
        {
            
            dxErroProvider.SetError(lkpGrupoEstoque, (lkpGrupoEstoque.Selecionado == null) ? "Campo obrigatório" : "");

            dxErroProvider.SetError(txtNCM, (txtNCM.Enabled && txtNCM.Text.Trim() == String.Empty) ? "Campo obrigatório" : "");

            dxErroProvider.SetError(txtCST, (txtCST.Enabled && txtCST.SelectedIndex < 0) ? "Campo obrigatório" : "");

            dxErroProvider.SetError(txtCSOSN, (txtCSOSN.Enabled && txtCSOSN.SelectedIndex < 0) ? "Campo obrigatório" : "");

            dxErroProvider.SetError(rgOpcao, rgOpcao.SelectedIndex < 0 ? "Selecione" : "");
            return !dxErroProvider.HasErrors;
        }


        protected override void OK()
        {
            if (ValidarFormulario())
            {
                if (MessageBox.Show(this, "Esta operação NÃO pode ser desfeita e alterará vários registros.\nDeseja Continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                try
                {
                    int alterados = 0;
                    switch (rgOpcao.SelectedIndex)
                    {
                        case 0:
                            alterados = ProdutoController.Instancia.AtualizaProdutos((GrupoEstoque)lkpGrupoEstoque.Selecionado, ProdutoController.NCMCST.NCM, txtNCM.Text);
                            break;
                        case 1:
                            alterados = ProdutoController.Instancia.AtualizaProdutos((GrupoEstoque)lkpGrupoEstoque.Selecionado, ProdutoController.NCMCST.CST, txtCST.SelectedIndex.ToString());
                            break;
                        case 2:
                            alterados = ProdutoController.Instancia.AtualizaProdutos((GrupoEstoque)lkpGrupoEstoque.Selecionado, ProdutoController.NCMCST.CSOSN, txtCSOSN.SelectedIndex.ToString());
                            break;
                    }
                    if (alterados > 0)
                        MessageBox.Show("Atualização realizada com sucesso.\nRegistros alterados: " + alterados, "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Nenhum produto neste grupo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro! " + MontaMensagemErro(e), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Verifique os campos indicados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lkbGrupo_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.GrupoEstoque> grid = new GridGenerica<cwkGestao.Modelo.GrupoEstoque>(GrupoEstoqueController.Instancia.GetAll(), new FormGrupoEstoque(), (cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoque.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpGrupoEstoque.EditValue = grid.Selecionado;
            lkpGrupoEstoque.Focus();
        }
    }
}
