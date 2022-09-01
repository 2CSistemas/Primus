using System;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormPessoaEndereco : Aplicacao.IntermediariasTela.FormManutPessoaEnderecoIntermediaria
    {
        public FormPessoaEndereco()
        {
            
        }

        public FormPessoaEndereco(PessoaEndereco pEnd)
        {
            Selecionado = pEnd;
        }

        protected override void SetarMascaras()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            chbBPrincipal.Enabled = true;
            chbBPrincipal.Checked = false;
            //lkbCidade.SubForm = new FormCidade();
            lkbCidade.SubFormType = typeof(FormCidade);
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }

        private void ConsultarCep()
        {
            Pessoa pessoa = new Pessoa();
            pessoa = PessoaController.Instancia.LoadObjectById(Selecionado.ID);
            if (pessoa != null)
            {
                if (pessoa.PessoaEnderecos.Count > 0)
                {
                    if (pessoa.PessoaEnderecos.FirstOrDefault().CEP != txtCEP.Text.Replace("-", ""))
                    {
                        BuscaInformacoesEnderecos();
                    }
                }
                else
                {
                    BuscaInformacoesEnderecos();
                }
            }
            else
            {
                BuscaInformacoesEnderecos();
            }
        }

        private void BuscaInformacoesEnderecos()
        {
            string cepSemTraco = String.Empty;
            string logradouro = String.Empty;
            cepbr_endereco endereco = new cepbr_endereco();
            try
            {
                cepSemTraco = txtCEP.Text.Replace("-", "");
                endereco = cepbr_enderecoController.Instancia.BuscaInfEnderecos(cepSemTraco);
            }
            catch (Exception ex)
            {
                endereco = null;
            }
            if (endereco != null)
            {
                if (endereco.tipo_logradouro != String.Empty)
                    logradouro = endereco.tipo_logradouro + " " + endereco.logradouro;
                else
                    logradouro = endereco.logradouro;

                txtBairro.Text = endereco.cep_bairro.bairro;
                txtEndereco.Text = logradouro;
                txtComplemento.Text = endereco.complemento;
                lkpCidade.Localizar(endereco.cep_cidade.CidadeCwork.ID);
            }
        }

        private void btnConsultarCep_Click(object sender, EventArgs e)
        {
            ConsultarCep();
        }
    }
}
