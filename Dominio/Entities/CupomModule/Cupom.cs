using Dominio.ParceiroModule;
using Dominio.Shared;
using System;

namespace Dominio.CupomModule
{
    public class Cupom : Entidade
    {
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
        public Cupom()
        {

        }

        public string Nome { get; }
        public int ValorPercentual { get; }
        public double ValorFixo { get; }
        public DateTime DataValidade { get; }
        public Parceiro Parceiro { get; }
        public double ValorMinimo { get; }
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

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao += "O campo nome é obrigatório e não pode ser vazio.";

            if (ValorPercentual < 0)
                resultadoValidacao += "Valor Percentual não pode ser menor que Zero.";

            if (ValorFixo < 0)
                resultadoValidacao += "Valor Fixo não pode ser Menor que Zero.";

            if (ValorPercentual > 100)
                resultadoValidacao += "Valor Percentual não pode ser Maior que Cem.";

            if (DataValidade == DateTime.MinValue || DataValidade == DateTime.MaxValue)
                resultadoValidacao += "A data Invalida, Insira uma data valida";

            if (Parceiro == null)
                resultadoValidacao += "O campo Parceiro é obrigatório e não pode ser vazio.";

            if (ValorMinimo < 0)
                resultadoValidacao += "O campo Valor Minimo não pode ser menor que Zero.";

            if (ValorFixo > ValorMinimo)
                resultadoValidacao += "O valor Minimo não pode ser menor que o valor de Desconto";

            return resultadoValidacao;

        }
    }
}
