using Dominio.AluguelModule;
using Dominio.Shared;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace Dominio.ServicoModule
{
    public class Servico : Entidade
    {
        public Servico(string nome, double taxa, Aluguel aluguel)
        {
            Nome = nome;
            Taxa = taxa;
            Aluguel = aluguel;
        }
        public Servico()
        {
        }

        public string Nome { get; set; }
        public double Taxa { get; set; }
        public virtual Aluguel Aluguel { get; set; }
        public override string ToString()
        {
            return $"{Nome} | R${Taxa}";
        }
        public override ValidationResult Validar => new ServicoValidator().Validate(this);
    }

    public class ServicoValidator : AbstractValidator<Servico>
    {
        public ServicoValidator()
        {
            throw new NotImplementedException();

            //if (string.IsNullOrEmpty(Nome))
            //    resultadoValidacao = "O Campo Nome é Obrigatorio\n";

            //if (Taxa <= 0)
            //    resultadoValidacao += "O Campo Taxa está inválido";
        }
    }
}