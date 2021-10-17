using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.Condutor;
using System;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePF : Cliente, ICondutor
    {
        public DateTime DataNascimento { get; set; }
        public override TipoPessoa TipoPessoa { get; } = TipoPessoa.PessoaFisica;
        public virtual DadosCondutor DadosCondutor { get; init; }

        public ClientePF(string nome, string telefone, string endereco, string documento, DadosCondutor dadosCondutor, DateTime dataNascimento, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            TipoPessoa.Documento = documento;
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