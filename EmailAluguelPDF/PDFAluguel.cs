using Dominio.AluguelModule;
using ExtensionsModule;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Drawing.Imaging;
using System.IO;

namespace EmailAluguelPDF
{
    public class PDFAluguel
    {
        public static void CriaEnvioEmail(Aluguel aluguel)
        {
            #region Estilos
            Style helvetica32b = new Style();
            PdfFont fontHeader = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            helvetica32b.SetFont(fontHeader).SetFontSize(32);

            Style helvetica14r = new Style();
            PdfFont fontCorpo = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            helvetica14r.SetFont(fontCorpo).SetFontSize(14);

            SolidLine linha = new(1f);
            LineSeparator separador = new(linha);
            #endregion

            var ms = new MemoryStream();
            var writer = new PdfWriter(ms);
            writer.SetCloseStream(false);
            var pdfDocument = new PdfDocument(writer);
            var pdf = new Document(pdfDocument);

            Paragraph header = new Paragraph("RECH-A-CAR").SetTextAlignment(TextAlignment.CENTER).AddStyle(helvetica32b);
            pdf.Add(header);

            pdf.Add(separador);

            Paragraph body_aluguel = new Paragraph().SetTextAlignment(TextAlignment.LEFT).AddStyle(helvetica14r);
            body_aluguel.Add(new Text($"\nOlá, {aluguel.Cliente}. aqui está o resumo do seu mais novo aluguel na Rech-a-car!\n"));
            body_aluguel.Add(new Text($"     Veículo: {aluguel.Veiculo}\n"));
            body_aluguel.Add(new Text($"     Data de Aluguel: {aluguel.DataAluguel:d}\n"));
            body_aluguel.Add(new Text($"     Data de Devolução: {aluguel.DataDevolucao:d}\n"));
            body_aluguel.Add(new Text($"     Total Parcial R$: {aluguel.CalcularTotal()}\n\n"));
            pdf.Add(body_aluguel);

            pdf.Add(separador);

            if (aluguel.Servicos.Count > 0)
            {
                Paragraph body_servicos = new Paragraph().SetTextAlignment(TextAlignment.LEFT).AddStyle(helvetica14r);
                body_servicos.Add(new Text($"\nServiços alugados:"));
                aluguel.Servicos.ForEach(s => body_servicos.Add(new Text($"     {s}\n")));
                body_servicos.Add(new Text($"\n"));
                pdf.Add(body_servicos);
                pdf.Add(separador);
            }

            Paragraph body_imagem = new Paragraph().SetTextAlignment(TextAlignment.CENTER).AddStyle(helvetica14r);
            body_imagem.Add(ImagemItextImage(aluguel.Veiculo.Foto));
            pdf.Add(body_imagem);

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
