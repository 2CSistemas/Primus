using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes.Mascaras;
using cwkGestao.Negocio;

namespace Aplicacao.Relatorios
{
    public partial class ClientePorVendedor : Aplicacao.Relatorios.Base.FormBase
    {
        public ClientePorVendedor()
        {
            InitializeComponent();
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
            cbVendedor.Sessao = PessoaController.Instancia.getSession();
            cbVendedor.Exemplo = new cwkGestao.Modelo.Pessoa() { BVendedor = true };
            cbVendedor.CamposRestricoesAND = new List<String>() { "bVendedor" };
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected override bool GerarRelatorio()
        {           
            if (ValidaRelatorio())
            {
                return GerarRelatorio("rptClientePorVendedor.rdlc");
            }
            else
            {
                return false;
            }
        }

        private bool ValidaRelatorio()
        {
            int erros = 0;
            if (gvPrincipal.SelectedRowsCount <= 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dxErroProvider.SetError(cbGrupo, "Campo obrigatório.");
                erros++;
            }
            else
            {
                dxErroProvider.SetError(cbGrupo, "");
            }
            if (!chbVendedor.Checked && cbVendedor.ID <= 0)
            {
                dxErroProvider.SetError(cbVendedor, "Campo obrigatório.");
                erros++;
            }
            else
            {
                dxErroProvider.SetError(cbVendedor, "");
            }

            if (erros > 0)
                return false;
            else
                return true;
        }
        private bool GerarRelatorio(string pRelNome)
        {
            var resultado = PessoaVendedorController.Instancia.GetListaClientePorVendedor((chbVendedor.Checked ? null : cbVendedor.ID.ToString()), txtLetraInicial.Text, txtLetraFinal.Text, MontaStringEmpresa());
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            parametros.Add(p1);
            nomeRelatorio = pRelNome;
            dataSet = "cwkGestaoDataSet_RelClientePorVendedor";
            VisualizarRelatorio(resultado, parametros);
            return true;
        }

        private string MontaStringEmpresa()
        {
            int[] posicoes;
            StringBuilder empresas = new StringBuilder();
            empresas.Append("('");
            posicoes = gvPrincipal.GetSelectedRows();
            foreach (int item in posicoes)
            {
                empresas.Append(gvPrincipal.GetRowCellValue(item, "ID").ToString());
                empresas.Append("', '");
            }
            empresas.Append(" 0')");
            return empresas.ToString();
        }


        private void VisualizarRelatorio(IList<object> resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }

        private void chbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVendedor.Checked)
            {
                cbVendedor.ID = 0;
                cbVendedor.Enabled = false;
                btnVendedor.Enabled = false;
            }
            else
            {
                cbVendedor.Enabled = true;
                btnVendedor.Enabled = true;
            }
        }

        private void txtLetraInicial_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtLetraInicial.Text != "")
                {
                    if (!Char.IsLetter(Convert.ToChar(txtLetraInicial.Text)))
                        throw new Exception("Caracter Inválido.");
                    else
                    {
                        if (txtLetraFinal.Text != "" && txtLetraInicial.Text != "")
                        {
                            if (Convert.ToChar(txtLetraFinal.Text) < Convert.ToChar(txtLetraInicial.Text))
                                throw new Exception("A Letra Inicial deve ser menor que a final.");
                        }
                    }
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLetraInicial.Text = "";
                txtLetraInicial.Focus();
            }
        }

        private void txtLetraFinal_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtLetraFinal.Text != "")
                {
                    if (!Char.IsLetter(Convert.ToChar(txtLetraFinal.Text)))
                        throw new Exception("Caracter Inválido.");
                    else
                    {
                        if (txtLetraFinal.Text != "" && txtLetraInicial.Text != "")
                        {
                            if (Convert.ToChar(txtLetraFinal.Text) < Convert.ToChar(txtLetraInicial.Text))
                                throw new Exception("A Letra Final deve ser maior que a inicial.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLetraFinal.Text = "";
                txtLetraFinal.Focus();
            }
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(cwkGestao.Negocio.PessoaController.Instancia.GetAllVendedores(), new FormPessoa(), false);
            grid.Selecionando = true;
            grid.ShowDialog();            
            cbVendedor.EditValue = grid.Selecionado;
        }

    }
}
