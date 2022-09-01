using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio.Telefonia;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormImportacaoLigacoes : Form
    {
        private bool finalizou;
        private bool contemErros;
        private Thread threadImportacao;
        private ImportadorLigacoes importador;

        public FormImportacaoLigacoes()
        {
            InitializeComponent();
            txtReferencia.EditValue = String.Format("{0:00}/{1:0000}", DateTime.Today.Month, DateTime.Today.Year);
            lblInformacao.Text = String.Empty;
            progressBar.Properties.Step = 1;
            progressBar.Properties.PercentView = true;            
            progressBar.Visible = false;
            progressBarGravando.Visible = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        private void sbImportar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() && PodeImportar())
            {
                rgTipoArquivo.Visible = false;
                progressBar.Visible = true;
                lblInformacao.Text = "Lendo registros de ligação...";
                sbImportar.Enabled = false;
                sbCancelar.Enabled = false;
                btSelecionarArquivo.Enabled = false;
                xtraTabPage1.Refresh();

                InicializarThreadImportacao();
                AguardarImportacao();
            }
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();
            if (!File.Exists(txtArquivo.Text))
                dxErrorProvider.SetError(txtArquivo, "Arquivo não encontrado");

            if (txtArea.Visible && String.IsNullOrEmpty(txtArea.Text))
                dxErrorProvider.SetError(txtArea, "Campo obrigatório");

            if (txtRange.Visible && String.IsNullOrEmpty(txtRange.Text))
                dxErrorProvider.SetError(txtRange, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private bool PodeImportar()
        {
            return MessageBox.Show("Deseja realizar a importação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void InicializarThreadImportacao()
        {
            finalizou = false;
            contemErros = false;

            importador = new ImportadorLigacoes((TipoArquivoLigacoes)rgTipoArquivo.SelectedIndex, txtArquivo.Text, txtReferencia.Text
                                                , Convert.ToInt32(txtArea.EditValue), Convert.ToInt32(txtRange.EditValue));
            progressBar.Properties.Maximum = importador.GetQuantidadeRegistros();
            progressBar.Properties.Minimum = 0;
            importador.AvancarProgressBar = AvancarProgressBar;
            threadImportacao = new Thread(new ThreadStart(Importar));
            threadImportacao.Start();
        }

        private void AguardarImportacao()
        {
            while (!finalizou)
            {
                Thread.Sleep(60);
                Application.DoEvents();
            }

            if (contemErros)
            {
                lblInformacao.Text = String.Empty;
                progressBarGravando.Visible = false;
                progressBar.Visible = false;
                rgTipoArquivo.Visible = true;
                sbImportar.Enabled = true;
                sbCancelar.Enabled = true;
                btSelecionarArquivo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Importação realizada com sucesso.");
                this.Dispose();
            }
        }

        private void Importar()
        {
            try
            {
                var telConf = Tel_ConfiguracaoController.Instancia.GetConfiguracao();
                if (telConf.ConsideraFixo)
                {
                    importador.ImportarFixoECelular();
                }
                else
                {
                    importador.Importar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                threadImportacao.Abort();
                this.Close();
            }
            finally
            {
                finalizou = true;
            }

            finalizou = true;
        }

        private void AvancarProgressBar()
        {
            this.BeginInvoke((MethodInvoker)delegate 
            {
                progressBar.PerformStep();
                if (progressBar.EditValue.Equals(progressBar.Properties.Maximum))
                {
                    progressBarGravando.Visible = true;
                    progressBar.Visible = false;
                    lblInformacao.Text = "Gravando registro de ligação...";
                }
                progressBar.Update();                
            });
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormImportacaoLigacoes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Importação Ligações");
                    break;
            }
        }

        private void FormImportacaoLigacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadImportacao != null)
                threadImportacao.Abort();
        }

        private void SelecionarArquivo(DevExpress.XtraEditors.TextEdit txt, string tipoArquivo)
        {
            //openFileDialog.Filter = tipoArquivo;
            if (!String.IsNullOrEmpty(txt.Text))
            {
                openFileDialog.FileName = txt.Text;
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt.Text = openFileDialog.FileName;
            }
        }

        private void btSelecionarArquivo_Click(object sender, EventArgs e)
        {
            SelecionarArquivo(txtArquivo, GetTipoArquivo());
        }

        private string GetTipoArquivo()
        {
            switch (rgTipoArquivo.SelectedIndex)
            {
                case 0:
                    return "Microsoft Office Access |*.mdb";
                case 1:
                    return "Documentos de Texto |*.txt";
                case 2:
                    return "Documentos de Texto |*.txt";
                default:
                    return "Microsoft Office Excel |*.xls*.*";
            }

            //if (rgTipoArquivo.SelectedIndex == 0)
            //    return "Microsoft Office Access |*.mdb";
            //else
            //    return "Documentos de Texto |*.txt";
        }

        private void rgTipoArquivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarRangeEArea(rgTipoArquivo.SelectedIndex == 1 || rgTipoArquivo.SelectedIndex == 2);    
        }

        private void HabilitarRangeEArea(bool habilitar)
        {
            lblArea.Visible = habilitar;
            lblRange.Visible = habilitar;
            txtArea.Visible = habilitar;
            txtRange.Visible = habilitar;
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
