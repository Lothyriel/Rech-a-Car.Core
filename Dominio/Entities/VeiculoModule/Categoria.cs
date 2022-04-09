using Dominio.PessoaModule.Condutor;
using Dominio.Shared;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace Dominio.VeiculoModule
{
    public class Categoria : Entidade
    {
        public Categoria(string nome, double diaria, double precoKm, int quilometragemFranquia, double precoLivre, TipoCNH tipoCnh)
        {
            Nome = nome;
            PrecoDiaria = diaria;
            PrecoKm = precoKm;
            PrecoLivre = precoLivre;
            QuilometragemFranquia = quilometragemFranquia;
            TipoDeCnh = tipoCnh;
        }

        public Categoria()
        {

        }
        public string Nome { get; set; }
        public double PrecoDiaria { get; set; }
        public double PrecoKm { get; set; }
        public double PrecoLivre { get; set; }
        public int QuilometragemFranquia { get; set; }
        public TipoCNH TipoDeCnh { get; set; }
        public override ValidationResult Validar => new CategoriaValidator().Validate(this);

        public override string ToString()
        {
            return Nome;
        }
    }

    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            throw new NotImplementedException();

            //if (Nome == string.Empty)
            //    validacao += "Valor da diária deve ser maior que 0\n";

            //if (PrecoDiaria <= 0)
            //    validacao += "Valor da diária deve ser maior que 0\n";
            //if (PrecoKm <= 0)
            //    validacao += "Valor do preço por Km deve ser maior que 0\n";
        }
    }
}
