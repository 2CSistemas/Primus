using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Aplicacao
{
    public partial class FormCapturaFoto : Form
    {
        public string NomeSubPastaSalvar { get; set; }
        public string NomeArquivoSalvar { get; set; }

        public DirectX.Capture.Filter Camera;
        public DirectX.Capture.Capture CaptureInfo;
        public DirectX.Capture.Filters CamContainer;
        Image capturaImagem;

        private FileInfo caminhoImagemSalva;

        public string ShowDialog(string nomeArquivoSalvar)
        {
            CaptureInfo = null;

            NomeArquivoSalvar = nomeArquivoSalvar;
            ShowDialog();
            if (this.caminhoImagemSalva != null)
                return this.caminhoImagemSalva.FullName;
            return String.Empty;
        }

        public FormCapturaFoto()
        {
            InitializeComponent();

            picCapture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CamContainer = new DirectX.Capture.Filters();
            try
            {
                int no_of_cam = CamContainer.VideoInputDevices.Count;

                for (int i = 0; i < no_of_cam; i++)
                {
                    try
                    {
                        // obtém o dispositivo de entrada do vídeo
                        Camera = CamContainer.VideoInputDevices[i];

                        // inicializa a Captura usando o dispositivo
                        CaptureInfo = new DirectX.Capture.Capture(Camera, null);

                        // Define a janela de visualização do vídeo
                        CaptureInfo.PreviewWindow = this.picCapture;

                        // Capturando o tratamento de evento
                        CaptureInfo.FrameCaptureComplete += AtualizaImagem;

                        // Captura o frame do dispositivo
                        CaptureInfo.CaptureFrame();

                        // Se o dispositivo foi encontrado e inicializado então sai sem checar o resto
                        break;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        public void AtualizaImagem(PictureBox frame)
        {
            try
            {
                capturaImagem = frame.Image;
                picCapture.Image = capturaImagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void sbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureInfo.CaptureFrame();
                picCapture.Image.Save(Modelo.cwkGlobal.DirApp + $@"\Imagens\{NomeArquivoSalvar}.jpg", ImageFormat.Jpeg);
                caminhoImagemSalva = new FileInfo(Modelo.cwkGlobal.DirApp + $@"\Imagens\{NomeArquivoSalvar}.jpg");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCapturaFoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            CaptureInfo?.DisposeCapture();
            Camera = null;
        }
    }
}
