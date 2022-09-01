using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormBanco : Aplicacao.IntermediariasTela.FormManutBancoIntermediaria
    {
        public FormBanco()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }

        private void SelecionaArquivo(DevExpress.XtraEditors.TextEdit txt, string tipoArquivo)
        {
            openFileDialog1.Filter = tipoArquivo;
            if (!String.IsNullOrEmpty(txt.Text))
            {
                openFileDialog1.FileName = txt.Text;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt.Text = openFileDialog1.FileName;
            }
        }

        private void btArquivoDeLicenca_Click(object sender, EventArgs e)
        {
            SelecionaArquivo(txtArquivoDeLicenca, "Arquivo de Licença |*.conf"); 
        }

        private void btCaminhoImagens_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCaminhoImagens.Text))
            {
                folderBrowserDialog1.SelectedPath = txtCaminhoImagens.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoImagens.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void btCaminhoLayoutBoleto_Click(object sender, EventArgs e)
        {
            SelecionaArquivo(txtCaminhoLayoutBoleto, "Modelo de Boleto |*.html");
        }

        private void btLogotipo_Click(object sender, EventArgs e)
        {
            SelecionaArquivo(txtLogotipo, "Arquivo de Imagem |*.*");
        }
    }
}
