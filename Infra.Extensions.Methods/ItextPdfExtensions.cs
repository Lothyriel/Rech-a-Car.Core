using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Infra.Extensions.Methods
{
    public static class ItextPdfExtensions
    {
        public static Document ToPdf(this MemoryStream ms)
        {
            var pdfReader = new PdfReader(ms);
            var pdfWriter = new PdfWriter(ms);
            var pdfDocument = new PdfDocument(pdfReader, pdfWriter);
            return new Document(pdfDocument);
        }
        public static MemoryStream ToMemoryStream(this byte[] bytes)
        {
            var ms = new MemoryStream();
            ms.Write(bytes);
            ms.Position = 0;
            return ms;
        }
        public static iText.Layout.Element.Image ToItextImage(this Image imagem)
        {
            var byteArray = imagem.ToByteArray(ImageFormat.Bmp);

            ImageData imageData = ImageDataFactory.Create(byteArray);
            return new iText.Layout.Element.Image(imageData);
        }
    }
}
