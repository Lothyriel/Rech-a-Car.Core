using Dominio.Shared;
using System.IO;

namespace Dominio.AluguelModule
{
    public class RelatorioAluguel : EnvioEmail
    {
        public RelatorioAluguel(Aluguel aluguel, MemoryStream relatorioStream) : base(relatorioStream)
        {
            Aluguel = aluguel;
        }
        public Aluguel Aluguel { get; }

        public override string Validar()
        {
            return "";
        }
    }
}
