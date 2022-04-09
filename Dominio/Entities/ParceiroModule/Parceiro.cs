using Dominio.Shared;
using FluentValidation;
using FluentValidation.Results;

namespace Dominio.ParceiroModule
{
    public class Parceiro : Entidade
    {
        public Parceiro(string parceiro)
        {
            Nome = parceiro;
        }
        public Parceiro()
        {
        }

        public string Nome { get; set; }
        public override ValidationResult Validar => new ParceiroValidator().Validate(this); 
        public override string ToString()
        {
            return Nome;
        }
    }

    public class ParceiroValidator : AbstractValidator<Parceiro> 
    {
        public ParceiroValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().NotNull().WithMessage("O {PropertyName} do Parceiro é obrigatório")
                .Length(2, 200).WithMessage("O {PropertyName} do Parceiro precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
