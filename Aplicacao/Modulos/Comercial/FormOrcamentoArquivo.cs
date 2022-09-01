using System.IO;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormOrcamentoArquivo : Form
    {
        public PedidoAnexo Arquivo;
        public Acao acao;
        public bool Salvou;


        public FormOrcamentoArquivo(PedidoAnexo Arq, Acao a)
        {
            InitializeComponent();
            Arquivo = Arq;
            acao = a;

            txtDescricao.Text = Arquivo.Descricao;
            txtCaminhoArquivo.Text = Arquivo.Caminho;
        }

        private void devButton2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void devButton1_Click(object sender, System.EventArgs e)
        {
            if (Arquivo.Anexo == null || string.IsNullOrEmpty(txtCaminhoArquivo.Text))
            {
                MessageBox.Show("Informe o Anexo.");
                return;
            }

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Informe a Descrição.");
                txtDescricao.Focus();
                return;
            }

            Arquivo.Descricao = txtDescricao.Text;
            Arquivo.Caminho = txtCaminhoArquivo.Text;

            Salvou = true;
            Close();
        }

        private void btSelecionarArquivo_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.FileName == "openFileDialog1")
                openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivo.Text = openFileDialog1.FileName;
                Arquivo.Anexo = File.ReadAllBytes(openFileDialog1.FileName);
                txtDescricao.Text = Path.GetFileNameWithoutExtension(txtCaminhoArquivo.Text);
            }
        }
    }
}
