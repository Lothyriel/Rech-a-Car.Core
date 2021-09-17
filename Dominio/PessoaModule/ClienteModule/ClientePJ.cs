using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public List<Motorista> Motoristas { get; set; } = new List<Motorista>();
        public string Email { get; set; }

        public ClientePJ(string nome, string telefone, string endereco, string documento, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Email = email;
        }
        public override string Validar()
        {
            string validacao = base.Validar();

            Regex ValidarEmail = new Regex(@"[a-z0-9._]+@[a-z0-9._]+\.[a-z0-9.]+[a-z]+", RegexOptions.IgnoreCase);

            if (!ValidarEmail.IsMatch(Email))
                validacao += "Email inválido\n";

            return validacao;
        }
    }
}