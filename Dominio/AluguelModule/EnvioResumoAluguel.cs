using Dominio.Shared;
using System.IO;

namespace Dominio.AluguelModule
{
    public class EnvioResumoAluguel : EnvioEmail
    {
        public EnvioResumoAluguel(Aluguel aluguel, MemoryStream attachment) : base(attachment)
        {
            Aluguel = aluguel;
        }
        public Aluguel Aluguel { get; }
    }
}
