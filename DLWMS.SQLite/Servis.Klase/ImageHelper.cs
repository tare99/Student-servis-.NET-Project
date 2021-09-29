using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.SQLite.DLWMS.Klase
{
    public class ImageHelper
    {
        public static Image FromByteToImage(byte[] nizBajtova)
        {
            MemoryStream ms = new MemoryStream(nizBajtova);
            return Image.FromStream(ms);
        }
        public static byte[] FromImageToByte(Image slika)
        {
            MemoryStream ms = new MemoryStream();
            slika.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

    }
}
