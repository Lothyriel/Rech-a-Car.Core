using Dominio.Entities.PessoaModule.Condutor;
using FluentValidation.Results;
using System;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePF : Cliente, ICondutor
    {
        public DateTime DataNascimento { get; set; }
        public virtual DadosCondutor DadosCondutor { get; init; }
        public override ETipoPessoa ETipoPessoa { get; init; } = ETipoPessoa.CPF;

        public ClientePF(string nome, string telefone, string endereco, string documento, DadosCondutor dadosCondutor, DateTime dataNascimento, string email) : base(nome, telefone, endereco, documento, email)
        {
            DadosCondutor = dadosCondutor;
            DataNascimento = dataNascimento;
            Email = email;
        }
        public ClientePF()
        {

        }
        public int GetIdade()
        {
            return (DateTime.Now - DataNascimento).Days / 365;
        }

        public override string Validar()
        {
            string validacao = base.Validar();

            if (GetIdade() < 18)
                validacao += "Idade mínima para dirigir é de 18 anos.\n";

            return validacao += DadosCondutor.Cnh.Validar();
        }
    }
}