using Dominio.Shared;
using System.IO;

namespace Dominio.AluguelModule
{
    public class RelatorioAluguel : EnvioEmail
    {
        public RelatorioAluguel()
        {
        }

        public RelatorioAluguel(Aluguel aluguel, MemoryStream relatorioStream)
        {
            Aluguel = aluguel;
            StreamAttachment = relatorioStream;
        }
        public virtual Aluguel Aluguel { get; }

        public override MemoryStream StreamAttachment { get; }

        public override string Validar()
        {
            return "";
        }
    }
}
