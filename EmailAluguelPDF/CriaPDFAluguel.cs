using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.AluguelModule;
using System.IO;
using System.Drawing.Imaging;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace EmailAluguelPDF
{
    public class CriaPDFAluguel
    {
        public CriaPDFAluguel(Aluguel aluguel)
        {
            Document document = new Document();
            Page page = document.Pages.Add();

            page.Paragraphs.Add(new TextFragment($"Olá {aluguel.Cliente} aqui está o resumo do seu mais novo aluguel na Rech-a-car"));

            page.Paragraphs.Add(new TextFragment($"Veículo: {aluguel.Veiculo}"));

            page.Paragraphs.Add(new TextFragment($"Data de Aluguel: {aluguel.DataAluguel:d}"));
            page.Paragraphs.Add(new TextFragment($"Data de Devolução: {aluguel.DataDevolucao:d}"));
            page.Paragraphs.Add(new TextFragment($"Total Parcial R$: {aluguel.CalcularTotal()}"));

            if (aluguel.Servicos.Count > 0)
            {
                page.Paragraphs.Add(new TextFragment($"Serviços alugados:"));
                aluguel.Servicos.ForEach(s => page.Paragraphs.Add(new TextFragment($"{s}")));
            }

            page.Resources.Images.Add(ImagemParaStream(aluguel.Veiculo.Foto));

            page.Contents.Add(new Aspose.Pdf.Operators.GSave());

            Rectangle rectangle = new Rectangle(50, 0, 500, 500);
            Matrix matrix = new Matrix(new double[] { rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY });

            page.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(matrix));
            XImage ximage = page.Resources.Images[page.Resources.Images.Count];

            page.Contents.Add(new Aspose.Pdf.Operators.Do(ximage.Name));

            page.Contents.Add(new Aspose.Pdf.Operators.GRestore());

            new ControladorEmail().InserirParaEnvio(new EnvioEmail(aluguel, document));
        }

        private static MemoryStream ImagemParaStream(System.Drawing.Image imagem)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, ImageFormat.Bmp);
            return stream;
        }
    }
}
