using Dominio.Shared;
using System;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule
{
    public class CNH : Entidade
    {
        public string NumeroCnh { get; set; }

        public TipoCNH TipoCnh { get; set; }

        Regex ValidarCNH = new Regex(@"\b[0-9]{11}\b");

        public CNH(string numeroCnh, TipoCNH tipoCnh)
        {
            NumeroCnh = numeroCnh;
            TipoCnh = tipoCnh;
        }

        public override string Validar()
        {
            string validacao = String.Empty;

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
