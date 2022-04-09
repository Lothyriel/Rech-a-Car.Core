using Dominio.Shared;
using FluentValidation;
using FluentValidation.Results;
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

        public override ValidationResult Validar => new RelatorioAluguelValidator().Validate(this);
    }

    public class RelatorioAluguelValidator : AbstractValidator<RelatorioAluguel>
    {
        public RelatorioAluguelValidator()
        {
        }
    }
}
