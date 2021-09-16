using iText.IO.Image;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Extensions
{
    public static class ImageExtensions
    {
        public static byte[] ToByteArray(this Image image, ImageFormat format = null)
        {
            format = format is null ? ImageFormat.Bmp : format;

            var stream = new MemoryStream();
            new Bitmap(image).Save(stream, format);
            stream.Position = 0;
            return stream.ToArray();
        }
        public static Image ToImage(this byte[] imageBytes)
        {
            using var ms = new MemoryStream(imageBytes);
            return Image.FromStream(ms);
        }
        public static iText.Layout.Element.Image ToItextImage(this Image imagem)
        {
            var byteArray = imagem.ToByteArray(ImageFormat.Bmp);

            ImageData imageData = ImageDataFactory.Create(byteArray);
            return new iText.Layout.Element.Image(imageData);
        }
    }
}
