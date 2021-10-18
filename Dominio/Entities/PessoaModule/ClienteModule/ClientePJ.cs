using System.Collections.Generic;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : Cliente
    {
        public virtual List<Motorista> Motoristas { get; set; } = new List<Motorista>();
        public override TipoPessoa TipoPessoa { get; init; }

        public ClientePJ(string nome, string telefone, string endereco, string documento, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Email = email;
            TipoPessoa = new CNPJ(documento);
        }
        public ClientePJ()
        {

        }
    }
}