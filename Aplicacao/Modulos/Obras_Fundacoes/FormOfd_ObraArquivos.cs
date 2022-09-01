using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class FormOfd_ObraArquivos : Aplicacao.IntermediariasTela.FormManutOfd_ObraArquivosIntermediaria
    {
        public FormOfd_ObraArquivos()
        {
        }

        public FormOfd_ObraArquivos(Ofd_ObraArquivos arquivos)
        {
            Selecionado = arquivos;
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
            txtDescricao.Text = Path.GetFileNameWithoutExtension(txtCaminhoArquivo.Text);
        }

        private void IdentificarTipoArquivo()
        {
            var extensao = txtCaminhoArquivo.Text.Split(new string[] { "." }, StringSplitOptions.None).LastOrDefault();
            if (extensao != null)
                cbTipoArquivo.SelectedIndex = Ofd_ObraArquivosController.Instancia.GetTipoPorExtensao(extensao);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir) && Selecionado != null && Selecionado.Obra != null)
            {
                if (Selecionado.Obra.Arquivos.Count > 0)
                    txtSequencia.EditValue = Selecionado.Obra.Arquivos.Max(c => c.Sequencia) + 1;
                else
                    txtSequencia.EditValue = 1;
            }
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            TelaProObjeto(tcPrincipal);
            base.btSubRegistro_Click(sender, e);
        }

        private void sbAbrirArquivo_Click(object sender, EventArgs e)
        {
            Ofd_ObraArquivosController.Instancia.AbrirArquivo(txtCaminhoArquivo.Text);
        }
    }
}
