using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Aplicacao.Util
{
    public class RedimensionaImagens
    {
        public PictureBox RedimensionarImagens(Image Foto, PictureBox pbCaminhoImagem, Int32 LarguraOriginal, Int32 AlturaOriginal)
        {
            if (Foto.Height < 130 || Foto.Width < 220)
            {
                pbCaminhoImagem.Height = 130;
                pbCaminhoImagem.Width = 220;

                Point Ponto = new Point((((LarguraOriginal / 2) + pbCaminhoImagem.Location.Y) - (pbCaminhoImagem.Width / 2)), (((AlturaOriginal / 2) + pbCaminhoImagem.Location.X) - (pbCaminhoImagem.Height / 2)));

                pbCaminhoImagem.Location = Ponto;

                pbCaminhoImagem.SizeMode = PictureBoxSizeMode.Zoom;
                return pbCaminhoImagem;

            }
            else if ((Foto.Height > 130 && Foto.Height < pbCaminhoImagem.Height) && (Foto.Width > 220 && Foto.Width < pbCaminhoImagem.Width))
            {
                pbCaminhoImagem.Height = Foto.Height;
                pbCaminhoImagem.Width = Foto.Width;

                Point Ponto = new Point((((LarguraOriginal / 2) + pbCaminhoImagem.Location.Y) - (pbCaminhoImagem.Width / 2)), (((AlturaOriginal / 2) + pbCaminhoImagem.Location.X) - (pbCaminhoImagem.Height / 2)));

                pbCaminhoImagem.Location = Ponto;

                pbCaminhoImagem.SizeMode = PictureBoxSizeMode.Normal;
                return pbCaminhoImagem;
            }
            else
                pbCaminhoImagem.SizeMode = PictureBoxSizeMode.Zoom;
            return pbCaminhoImagem;
        }
    }
}
