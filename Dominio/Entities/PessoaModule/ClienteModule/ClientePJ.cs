using System.Collections.Generic;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : Cliente
    {
        public virtual List<Motorista> Motoristas { get; set; } = new List<Motorista>();
        public override ETipoPessoa ETipoPessoa { get; init; } = ETipoPessoa.CNPJ;

        public ClientePJ(string nome, string telefone, string endereco, string documento, string email) : base(nome, telefone, endereco, documento, email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Email = email;
        }
        public ClientePJ()
        {

        }
    }
}