using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using cwkGestao.Integracao.Sped.Fiscal;
using cwkGestao.Negocio.Padroes;
using System.Linq;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormNotaInutilizada : Aplicacao.IntermediariasTela.FormManutNotaInutilizadaIntermediaria
    {
        private Filial filial;

        public FormNotaInutilizada(Filial pFilial)
        {
            InitializeComponent();

            filial = pFilial;
        }

        private bool ValidaFormulario()
        {
            if (filial.FormaEmissao != 1)
            {
                MessageBox.Show("Para Inutilizar Faixa de NFe a Forma de Emissão no cadastro de empresa deve ser igual a \"1 | Normal\"");
                return false;
            }

            dxErroProvider.ClearErrors();

            if (String.IsNullOrEmpty(txtSerie.Text))
                dxErroProvider.SetError(txtSerie,"Campo obrigatório");
            if (String.IsNullOrEmpty(txtAno.Text))
                dxErroProvider.SetError(txtAno, "Campo obrigatório");
            if (String.IsNullOrEmpty(txtNumIni.Text))
                dxErroProvider.SetError(txtNumIni, "Campo obrigatório");
            if (String.IsNullOrEmpty(txtNumFim.Text))
                dxErroProvider.SetError(txtNumFim, "Campo obrigatório");
            if (String.IsNullOrEmpty(txtJustificativa.Text))
                dxErroProvider.SetError(txtJustificativa, "Campo obrigatório");

            return !dxErroProvider.HasErrors;

        }
        protected override void OK()
        {
            NotaInutilizada inu = new NotaInutilizada();
            string ret = String.Empty;
            string cnpj = filial.CNPJ.Replace(".","").Replace("/","").Replace("-","");

            if(ValidaFormulario())
            {
                if (ConversorComboBox.tpModeloNotaSelected(cbModeloNota.SelectedIndex) == 55)
                {
                    ret = NotaInutilizadaController.Instancia.InutilizaFaixaNFe(filial,txtAno.Text, cnpj,
                    txtSerie.Text, txtNumIni.Text, txtNumFim.Text, txtJustificativa.Text);
                }
                else
                {
                    ConfiguracaoManager configManager = ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault();
                    ret = cwkGestao.NFe.NFeController.InutilizarNFce(configManager, txtAno.Text,
                    txtSerie.Text, txtNumIni.Text, txtNumFim.Text, txtJustificativa.Text, cnpj);
                }

                if (ret == "102")
                {
                    inu.Filial = filial;
                    inu.Serie = Convert.ToInt32(txtSerie.Text);
                    inu.NumeroInicio = Convert.ToInt32(txtNumIni.Text);
                    inu.NumeroFim = Convert.ToInt32(txtNumFim.Text);
                    inu.Justificativa = txtJustificativa.Text;
                    inu.Data = DateTime.Now;
                    inu.Ano = txtAno.Text;
                    inu.ModeloNota = ConversorComboBox.tpModeloNotaSelected(cbModeloNota.SelectedIndex);

                    NotaInutilizadaController.Instancia.Salvar(inu, Acao.Incluir);

                    MessageBox.Show("Operação realizada com sucesso !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(ret, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            
        }

        private void FormNotaInutilizada_Load(object sender, EventArgs e)
        {
                cbModeloNota.SelectedIndex = 0;
        }
    }
}