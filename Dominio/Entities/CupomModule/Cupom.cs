using Dominio.ParceiroModule;
using Dominio.Shared;
using FluentValidation;
using System;

namespace Dominio.CupomModule
{
    public class Cupom : Entidade
    {
        public static Cupom Invalido = new("", 0, 0, DateTime.MinValue, null, 0, 0);
        public Cupom(string nome, int valorPercentual, double valorFixo, DateTime dataValidade, Parceiro parceiro, double valorMInimo, int usos)
        {
            Nome = nome;
            ValorPercentual = valorPercentual;
            ValorFixo = valorFixo;
            DataValidade = dataValidade;
            Parceiro = parceiro;
            ValorMinimo = valorMInimo;
            Usos = usos;
        }
        public Cupom() { }
        public string Nome { get; set; }
        public int ValorPercentual { get; set; }
        public double ValorFixo { get; set; }
        public DateTime DataValidade { get; set; }
        public virtual Parceiro Parceiro { get; set; }
        public double ValorMinimo { get; set; }
        public int Usos { get; set; }

        public double CalcularDesconto(double valorTotal)
        {
            double valor = 0;

            if (valorTotal <= ValorMinimo)
                valor = 0;

            else if (ValorFixo > 0)
                valor = ValorFixo;

            else if (ValorPercentual > 0)
                valor = (valorTotal / 100) * ValorPercentual;

            return valor;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
    public class CupomParceiro : AbstractValidator<Cupom>
    {
        public CupomParceiro()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O {PropertyName} do cupom é obrigatório e não pode ser vazio")
                .Length(2, 200).WithMessage("O {PropertyName} do cupom precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(x => x.DataValidade)
                .LessThan(DateTime.Today).WithMessage("A Data de Validade do cupom deve ser maior que a data de hoje")
                .NotEqual(DateTime.MinValue).WithMessage("A Data de Validade do cupom está inválida")
                .NotEqual(DateTime.MaxValue).WithMessage("A Data de Validade do cupom está inválida");

            RuleFor(x => x.Parceiro)
                .NotNull().WithMessage("O Parceiro do Cupom é obrigatório e não pode ser vazio");

            RuleFor(x => x.ValorFixo)
                .LessThan(0).WithMessage("Valor Fixo não pode ser menor que {ComparisonValue}")
                .GreaterThan(x => x.ValorMinimo).WithMessage("O Valor Fixo do Cupom não pode ser maior que {ComparisonValue}");

            RuleFor(x => x.ValorPercentual)
                .LessThan(0).WithMessage("Valor Percentual não pode ser menor que {ComparisonValue}")
                .GreaterThan(x => (int?)x.ValorMinimo).WithMessage("Valor Percentual não pode ser maior que {ComparisonValue}");

            RuleFor(x => x.ValorMinimo)
                .LessThan(0).WithMessage("Valor Percentual não pode ser menor que {ComparisonValue}")
                .GreaterThan(100).WithMessage("Valor Percentual não pode ser maior que {ComparisonValue}");
        }
    }
}
