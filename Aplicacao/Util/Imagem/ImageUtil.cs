using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace cwkGestao.Negocio.Utils
{
    public static class ImageUtil
    {
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            catch
            {
                return new byte[0];
            }
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
            {
                byteArrayIn = new byte[0];
            }
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage;
            try
            {
                returnImage = Image.FromStream(ms);
            }
            catch
            {
                returnImage = null;
            }
            return returnImage;
        }
    }
}
