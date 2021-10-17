using System.Collections.Generic;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : Cliente
    {
        public virtual List<Motorista> Motoristas { get; set; } = new List<Motorista>();
        public override TipoPessoa TipoPessoa { get; } = TipoPessoa.PessoaJuridica;

        public ClientePJ(string nome, string telefone, string endereco, string documento, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            TipoPessoa.Documento = documento;
            Email = email;
        }
        public ClientePJ()
        {

        }
    }
}