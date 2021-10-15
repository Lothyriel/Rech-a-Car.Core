using Dominio.ParceiroModule;
using Dominio.Shared;
using System;

namespace Dominio.CupomModule
{
    public class Cupom : Entidade
    {
        public static Cupom Invalido = new Cupom("", 0, 0, DateTime.MinValue, null, 0, 0);
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

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao += "O campo nome é obrigatório e não pode ser vazio.\n";

            if (ValorPercentual < 0)
                resultadoValidacao += "Valor Percentual não pode ser menor que Zero.\n";

            if (ValorFixo < 0)
                resultadoValidacao += "Valor Fixo não pode ser Menor que Zero.\n";

            if (ValorPercentual > 100)
                resultadoValidacao += "Valor Percentual não pode ser Maior que Cem.\n";

            if (DataValidade < DateTime.Today)
                resultadoValidacao += "A data Invalida, Insira uma data valida.\n";

            if (Parceiro == null)
                resultadoValidacao += "O campo Parceiro é obrigatório e não pode ser vazio.\n";

            if (ValorMinimo < 0)
                resultadoValidacao += "O campo Valor Minimo não pode ser menor que Zero.\n";

            if (ValorFixo > ValorMinimo)
                resultadoValidacao += "O valor Minimo não pode ser menor que o valor de Desconto.\n";

            return resultadoValidacao;

        }
    }
}
