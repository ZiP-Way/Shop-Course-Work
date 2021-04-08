using System.Drawing;
using System.IO;

namespace Shop.Tools
{
    class ImageConverter
    {
        public static byte[] ConvertImgToByte(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            MemoryStream ms = new MemoryStream();

            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imgBytes = ms.ToArray();

            return imgBytes;
        }

        public static Image ConvertBytesToImg(byte[] binaryImg)
        {
            MemoryStream ms = new MemoryStream(binaryImg);
            Image img = Image.FromStream(ms);

            return img;
        }
    }
}
