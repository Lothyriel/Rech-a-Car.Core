using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.AluguelModule;
using System.IO;
using System.Drawing.Imaging;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using ExtensionsModule;

namespace EmailAluguelPDF
{
    public class PDFAluguel
    {
        public static void CriaEnvioEmail(Aluguel aluguel)
        {
            #region Estilos
            Style helvetica20b = new();
            PdfFont fontHeader = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            helvetica20b.SetFont(fontHeader).SetFontSize(20);

            Style helvetica14r = new();
            PdfFont fontCorpo = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            helvetica14r.SetFont(fontCorpo).SetFontSize(14);
            #endregion

            var ms = new MemoryStream();
            var writer = new PdfWriter(ms);
            writer.SetCloseStream(false);
            var pdfDocument = new PdfDocument(writer);
            var pdf = new Document(pdfDocument);

            Paragraph header = new Paragraph("RECH-A-CAR").SetTextAlignment(TextAlignment.CENTER).AddStyle(helvetica20b);
            pdf.Add(header);

            Paragraph corpo = new Paragraph().SetTextAlignment(TextAlignment.LEFT).AddStyle(helvetica14r);
            corpo.Add(new Text($"Olá {aluguel.Cliente} aqui está o resumo do seu mais novo aluguel na Rech-a-car"));
            corpo.Add(new Text($"Veículo: {aluguel.Veiculo}"));
            corpo.Add(new Text($"Data de Aluguel: {aluguel.DataAluguel:d}"));
            corpo.Add(new Text($"Data de Devolução: {aluguel.DataDevolucao:d}"));
            corpo.Add(new Text($"Total Parcial R$: {aluguel.CalcularTotal()}"));

            if (aluguel.Servicos.Count > 0)
            {
                corpo.Add(new Text($"Serviços alugados:"));
                aluguel.Servicos.ForEach(s => corpo.Add(new Text($"{s}")));
            }
            corpo.Add(ImagemItextImage(aluguel.Veiculo.Foto));

            pdf.Add(corpo);
            pdf.Close();
            ControladorEmail.InserirParaEnvio(aluguel, ms);
        }

        private static Image ImagemItextImage(System.Drawing.Image imagem)
        {
            var byteArray = imagem.ToByteArray(ImageFormat.Bmp);

            ImageData imageData = ImageDataFactory.Create(byteArray);
            return new Image(imageData);
        }
    }
}
