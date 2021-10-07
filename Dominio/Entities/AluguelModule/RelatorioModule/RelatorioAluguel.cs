using Dominio.Shared;
using System;
using System.IO;

namespace Dominio.AluguelModule
{
    public class RelatorioAluguel : EnvioEmail
    {
        public DateTime? DataEnvio { get; set; }

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
