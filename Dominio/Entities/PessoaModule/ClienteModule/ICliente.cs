using Dominio.Shared;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface ICliente : IEntidade
    {
        string Nome { get; set; }
        string Telefone { get; set; }
        string Endereco { get; set; }
        string Documento { get; set; }
        string Email { get; set; }

        public static string ValidarEmail(string email)
        {
            Regex ValidarEmail = new Regex(@"[a-z0-9.]+@[a-z0-9.]+\.[a-z0-9.]+[a-z]+", RegexOptions.IgnoreCase);

            if (!ValidarEmail.IsMatch(email))
                return "Email inválido\n";
            return string.Empty;
        }
    }
}
