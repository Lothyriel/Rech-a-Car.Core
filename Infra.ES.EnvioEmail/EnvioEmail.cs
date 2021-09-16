using Dominio.AluguelModule;
using iText.Layout;

namespace EmailAluguelPDF
{
    public class EnvioEmail
    {
        public EnvioEmail(Aluguel aluguel, Document pdf)
        {
            Aluguel = aluguel;
            Pdf = pdf;
        }
        public Aluguel Aluguel { get; }
        public Document Pdf { get; }
        public int Id { get; set; }
    }
}