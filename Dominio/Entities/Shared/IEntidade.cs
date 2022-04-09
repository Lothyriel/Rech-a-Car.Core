using FluentValidation.Results;

namespace Dominio.Shared
{
    public interface IEntidade
    {
        int Id { get; set; }
        abstract ValidationResult Validar { get; }
    }
}
