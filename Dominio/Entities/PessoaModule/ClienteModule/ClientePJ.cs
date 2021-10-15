using System.Collections.Generic;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public virtual List<Motorista> Motoristas { get; set; } = new List<Motorista>();
        public string Email { get; set; }

        public ClientePJ(string nome, string telefone, string endereco, string documento, string email)
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
        public override string Validar()
        {
            string validacao = base.Validar();

            validacao += ICliente.ValidarEmail(Email);

            return validacao;
        }
    }
}