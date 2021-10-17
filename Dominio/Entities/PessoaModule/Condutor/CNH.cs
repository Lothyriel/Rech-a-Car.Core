using Dominio.Shared;
using System;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule.Condutor
{
    public class CNH : Entidade
    {
        public CNH()
        {

        }
        public string NumeroCnh { get; init; }
        public TipoCNH TipoCnh { get; init; }

        public CNH(string numeroCnh, TipoCNH tipoCnh)
        {
            NumeroCnh = numeroCnh;
            TipoCnh = tipoCnh;
        }

        public override string Validar()
        {
            string validacao = string.Empty;
            Regex ValidarCNH = new(@"\b[0-9]{11}\b");

            if (!ValidarCNH.IsMatch(NumeroCnh))
                validacao = "CNH Inválida.\n";

            return validacao;
        }
        public bool PodeDirigir(TipoCNH tipo)
        {
            switch (TipoCnh)
            {
                case TipoCNH.A: return tipo == TipoCNH.A;
                case TipoCNH.B: return tipo == TipoCNH.B;
                default: return tipo <= TipoCnh;
            }
        }
    }
    public enum TipoCNH
    {
        A,
        B,
        AB,
        C,
        D,
        E
    }
}
