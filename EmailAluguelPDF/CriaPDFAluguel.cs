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

namespace EmailAluguelPDF
{
    public class CriaPDFAluguel
    {
        public CriaPDFAluguel(Aluguel aluguel)
        {
            #region Estilos
            Style helvetica20b = new Style();
            PdfFont fontHeader = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            helvetica20b.SetFont(fontHeader).SetFontSize(20);

            Style helvetica14r = new Style();
            PdfFont fontCorpo = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            helvetica14r.SetFont(fontCorpo).SetFontSize(14);
            #endregion

            PdfWriter writer = new PdfWriter("aluguel.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph header = new Paragraph("RECH-A-CAR").SetTextAlignment(TextAlignment.CENTER).AddStyle(helvetica20b);
            document.Add(header);

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

            corpo.Add(ImagemParaStream(aluguel.Veiculo.Foto));

            new ControladorEmail().InserirParaEnvio(new EnvioEmail(aluguel, document));
            document.Close();
        }

        private static Image ImagemParaStream(System.Drawing.Image imagem)
        {
            byte[] byteImage;
            using (var ms = new MemoryStream())
            {
                imagem.Save(ms, imagem.RawFormat);
                byteImage = ms.ToArray();
            }
            ImageData imageData = ImageDataFactory.Create(byteImage);
            Image imagemPDF = new(imageData);
            return imagemPDF;
        }
    }
}
