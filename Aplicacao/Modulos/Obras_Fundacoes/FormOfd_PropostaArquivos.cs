using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.IO;

namespace Aplicacao
{
    public partial class FormOfd_PropostaArquivos : Aplicacao.IntermediariasTela.FormManutOfd_PropostaArquivosIntermediaria
    {
        public FormOfd_PropostaArquivos()
        {
        }

        public FormOfd_PropostaArquivos(Ofd_PropostaArquivos proposta)
        {
            Selecionado = proposta;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void btSelecionarArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "openFileDialog1")
                openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivo.Text = openFileDialog1.FileName;                
                IdentificarTipoArquivo();
                SugerirDescricao();
            }
        }

        private void SugerirDescricao()
        {
            if (String.IsNullOrEmpty(txtDescricao.Text))
                txtDescricao.Text = Path.GetFileNameWithoutExtension(txtCaminhoArquivo.Text);
        }

        private void IdentificarTipoArquivo()
        {
            var extensao = txtCaminhoArquivo.Text.Split(new string[] { "." }, StringSplitOptions.None).LastOrDefault();
            if (extensao != null)
                cbTipoArquivo.SelectedIndex = Ofd_PropostaArquivosController.Instancia.GetTipoPorExtensao(extensao);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir) && Selecionado != null && Selecionado.Proposta != null)
            {
                if (Selecionado.Proposta.Arquivos.Count > 0)
                    txtSequencia.EditValue = Selecionado.Proposta.Arquivos.Max(c => c.Sequencia) + 1;
                else
                    txtSequencia.EditValue = 1;
            }
        }

        private void sbAbrirArquivo_Click(object sender, EventArgs e)
        {
            Ofd_PropostaArquivosController.Instancia.AbrirArquivo(txtCaminhoArquivo.Text);
        }
    }
}
