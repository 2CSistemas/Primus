using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Linq;
using System.IO;
using cwkGestao.Modelo;


namespace Aplicacao
{
    public partial class FormTipoServicoTransporte : Aplicacao.IntermediariasTela.FormManutTipoServicoTransporteIntermediaria
    {
        int tamanho;
        public FormTipoServicoTransporte()
        {     

        }

        public FormTipoServicoTransporte(int tam)
        {
            tamanho = tam;
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            IList<ServicoEnvioCorreio> servicos =  ServicoEnvioCorreioController.Instancia.GetAll();
            lkpServicoCorreios.Properties.DataSource = servicos;
		}

        private void btSelecionarArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.FileName == "openFileDialog2")
                openFileDialog2.FileName = String.Empty;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivo.Text = openFileDialog2.FileName;
                //IdentificarTipoArquivo();
                //SugerirDescricao();
            }
        }

        protected override void OK()
        {
            if ((bool)chkCorreios.EditValue == true && lkpServicoCorreios.EditValue == null)
            {
                MessageBox.Show("Selecione um Código de Serviço de Correios antes de prosseguir com a operação.", 
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(ValidarFormulario())
            {
                PrencheObjeto();
                if (this.Text.Contains("Incluindo"))
                {
                    TipoServicoTransporteController.Instancia.Salvar(Selecionado, Acao.Incluir);
                }
                else if (this.Text.Contains("Alterando"))
                {
                    TipoServicoTransporteController.Instancia.Salvar(Selecionado, Acao.Alterar);
                }
                else if (this.Text.Contains("Excluindo"))
                {
                    TipoServicoTransporteController.Instancia.Salvar(Selecionado, Acao.Excluir);
                }
                this.Close();
            }
        }

        private void PrencheObjeto()
        {
            string acrescimoFrete = SubistuiPontoPorVirgula(txtAcrescimoFrete.EditValue.ToString());
            Selecionado.Codigo = Convert.ToInt32(txtCodigo.Text);
            Selecionado.Correios = (bool)chkCorreios.EditValue;
            Selecionado.ControleNumeracao = (bool)chkControleNumeracao.EditValue;
            Selecionado.Descricao = txtDescricao.Text;
            Selecionado.CaminhoImagem = txtCaminhoArquivo.Text;
            if (lkpServicoCorreios.EditValue != null)
            {
                Selecionado.CodigoServico = ((ServicoEnvioCorreio)lkpServicoCorreios.EditValue).Codigo;
                Selecionado.IDServicoEnvioCorreio = (ServicoEnvioCorreio)lkpServicoCorreios.EditValue;
            }
            if (!Selecionado.Correios)
            {
                Selecionado.IDServicoEnvioCorreio = null;
            }
            Selecionado.AcrescimoFrete = Convert.ToDecimal(acrescimoFrete);
        }

        private string SubistuiPontoPorVirgula(string acrescimo)
        {
            string retorno = acrescimo.Replace('.', ',');
            return retorno;
        }

        private void PrencheComponentes()
        {
            txtCodigo.Text = Selecionado.Codigo.ToString();
            chkCorreios.EditValue = (object)Selecionado.Correios;
            chkControleNumeracao.EditValue = (object)Selecionado.ControleNumeracao;
            txtDescricao.Text = Selecionado.Descricao;
            txtCaminhoArquivo.Text = Selecionado.CaminhoImagem;
            lkpServicoCorreios.EditValue = (object)Selecionado.IDServicoEnvioCorreio;
            txtAcrescimoFrete.EditValue = Selecionado.AcrescimoFrete.ToString();
        }

        private void FormTipoServicoTransporte_Shown(object sender, EventArgs e)
        {
            PrencheComponentes();

            HabilitaComboBoxTipoServico();
        }

        private void HabilitaComboBoxTipoServico()
        {            
            if (((bool)chkCorreios.EditValue) == true)
            {
                thirdPanel.Visible = true;
                thirdPanel.Enabled = true;
                this.Height = tamanho;
                this.tcPrincipal.Height = 127;
            }
            else
            {
                thirdPanel.Visible = false;
                thirdPanel.Visible = false;
                this.Height = tamanho - thirdPanel.Height;
                this.tcPrincipal.Height = 127 - thirdPanel.Height;
            }
        }

        private void chkCorreios_EditValueChanged_1(object sender, EventArgs e)
        {
            HabilitaComboBoxTipoServico();
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();
            if ((bool)chkCorreios.EditValue == true && lkpServicoCorreios.EditValue == null)
            {
                dxErroProvider.SetError(lkpServicoCorreios, "Selecione um Código de Serviço de Correios antes de prosseguir com a operação.");
            }
            string AcrescimoFreteStr = SubistuiPontoPorVirgula(txtAcrescimoFrete.Text);
            decimal valorAcrescimoFrete = Convert.ToDecimal(AcrescimoFreteStr);
            if ((valorAcrescimoFrete) > 100)
            {
                dxErroProvider.SetError(txtAcrescimoFrete, "A Porcentagem do Acréscimo de Frete não pode ser maior do que 100.");
            }
            return !dxErroProvider.HasErrors;
        }

        private void lkpServicoCorreios_EditValueChanged(object sender, EventArgs e)
        {
            if (lkpServicoCorreios.EditValue != null)
            {
                txtDescricao.Text = ((ServicoEnvioCorreio)lkpServicoCorreios.EditValue).Servico;
                txtCodigo.Text = ((ServicoEnvioCorreio)lkpServicoCorreios.EditValue).Codigo;
            }
        }
    }
}
