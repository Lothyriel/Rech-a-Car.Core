using Dominio.AluguelModule;
using iText.Layout;
using System.IO;

namespace EmailAluguelPDF
{
    public class EnvioEmail
    {
        public EnvioEmail(Aluguel aluguel, Document pdf)
        {
            Aluguel = aluguel;
            Pdf = pdf;
        }

        public EnvioEmail(Aluguel aluguel, MemoryStream streamPdf)
        {
            Aluguel = aluguel;
            StreamPdf = streamPdf;
        }
        public Aluguel Aluguel { get; }
        public Document Pdf { get; }
        public MemoryStream StreamPdf { get; }
        public int Id { get; set; }
    }
}