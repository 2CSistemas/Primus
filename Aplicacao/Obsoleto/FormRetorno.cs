using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Aplicacao.Modulos.Financeiro;

using cwkGestao.Integracao.ACBr.Boleto;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Financeiro;

using DBUtils.Classes;

using DevExpress.XtraEditors;

using Remessa = cwkGestao.Modelo.Remessa;

namespace Aplicacao
{
    public partial class FormRetorno : Form
    {
        private readonly StringBuilder Err = new StringBuilder();
        private StringBuilder Mensagem = new StringBuilder();
        private DocumentoController DocumentoController = DocumentoController.Instancia;
        private readonly RemessaController RemessaController = RemessaController.Instancia;
        public Documento DocumentoABaixar { get; set; }

        public FormRetorno()
        {
            InitializeComponent();

            lkRemessa.Sessao = RemessaController.Instancia.getSession();
            lkRemessa.Exemplo = new Remessa();
        }

        private void SelecionaArquivo(TextEdit txt, string tipoArquivo)
        {
            openFileDialog1.Filter = tipoArquivo;
            if (!string.IsNullOrEmpty(txt.Text)) openFileDialog1.FileName = txt.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) txt.Text = openFileDialog1.FileName;
        }

        private void btnArqRetorno_Click(object sender, EventArgs e)
        {
            SelecionaArquivo(txtArqRetorno, "(*.*)|*.*");
        }
        
        private void sbGravar_Click(object sender, EventArgs e)
        {
            Remessa remessaselecionada = (Remessa)lkRemessa.Selecionado;
            if (MessageBox.Show("Deseja Baixar os Documentos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Baixar(remessaselecionada.UtilizaDataCredito);
        }

        private void Baixar(bool UtilizaDataCredito)
        {
            if (ValidaTela())
            {
                var InfoArquivo = new FileInfo(txtArqRetorno.Text);

                Boleto b = new Boleto();
                b.LerRetorno(InfoArquivo.DirectoryName, InfoArquivo.Name);

                var ArquivoIni = new IniFile(InfoArquivo.DirectoryName + "\\Retorno.ini");
                var DadosRetorno = new Retorno().PreencheDadosRetorno(ArquivoIni);

                if (DadosRetorno.Count == 0)
                    MessageBox.Show("Arquivo de retorno com dados inválidos ou inexistentes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Cursor = Cursors.WaitCursor;
                BaixaDocumentoRetorno baixa = new BaixaDocumentoRetorno(DadosRetorno, (Remessa)lkRemessa.Selecionado);
                baixa.BaixarDocumentos(UtilizaDataCredito);
                Cursor = Cursors.Default;
                var form = new GridLogRetornoDetalhe(baixa.logRetorno);
                form.Show();
            }
            else
            {
                MessageBox.Show(Err.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Err.Remove(0, Err.Length);
        }

        private bool ValidaTela()
        {
            bool Flag = true;

            if (string.IsNullOrEmpty(txtArqRetorno.Text.Trim()))
            {
                dxErroProvider.SetError(txtArqRetorno, "Campo Obrigatório");
                Err.Append("Por favor escolha um arquivo de retorno.\n");
                Flag = false;
            }
            else if (!ValidaExistencia(txtArqRetorno.Text))
            {
                dxErroProvider.SetError(txtArqRetorno, "Caminho Inválido");
                Err.Append("Por favor indique um caminho válido para Arquivo retorno.\n");
                Flag = false;
            }
            else
            {
                dxErroProvider.SetError(txtArqRetorno, "");
            }

            if (string.IsNullOrEmpty(lkRemessa.Text.Trim()))
            {
                dxErroProvider.SetError(lkRemessa, "Campo Obrigatório");
                Err.Append("Por favor escolha uma remessa.\n");
                Flag = false;
            }
            //else if (!ValidaExistencia(((Remessa) lkRemessa.Selecionado).ArquivoDeLicensa))
            //{
            //    dxErroProvider.SetError(lkRemessa, "Caminho Inválido");
            //    Err.Append("Por favor indique um caminho válido para Arquivo de licensa na remessa.\n");
            //    Flag = false;
            //}
            else
            {
                dxErroProvider.SetError(lkRemessa, "");
            }

            return Flag;
        }

        private void FormRetorno_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    sbGravar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidaExistencia(string pArq)
        {
            FileInfo ArqInfo = new FileInfo(pArq);
            return ArqInfo.Exists;
        }

        private void btnRemessa_Click(object sender, EventArgs e)
        {
            GridGenerica<Remessa> grid = new GridGenerica<Remessa>(RemessaController.GetAll(), new FormRemessa(), (Remessa)lkRemessa.Selecionado, false) { Selecionando = true };
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkRemessa.Localizar(Convert.ToInt32(grid.Selecionado.ID));

            lkRemessa.Focus();
        }
    }
}