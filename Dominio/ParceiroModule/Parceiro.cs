﻿using Dominio.Shared;

namespace Dominio.ParceiroModule
{
    public class Parceiro : Entidade
    {
        public Parceiro(string parceiro)
        {
            this.nome = parceiro;
        }

        public string nome { get; set; }
        public override string Validar()
        {
            string resultadoValidacao = "";
            if (string.IsNullOrEmpty(nome))
                resultadoValidacao = "O Nome do Parceiro é obrigatório.";

            return resultadoValidacao;
        }
        public override string ToString()
        {
            return nome;
        }
    }
}
