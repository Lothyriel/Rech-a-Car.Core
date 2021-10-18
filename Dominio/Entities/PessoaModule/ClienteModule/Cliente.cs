using System.Text.RegularExpressions;

namespace Dominio.PessoaModule.ClienteModule
{
    public abstract class Cliente : Pessoa
    {
        public string Email { get; set; }
        public override string Validar()
        {
            var validacao = base.Validar();

            Regex ValidarEmail = new Regex(@"[a-z0-9.]+@[a-z0-9.]+\.[a-z0-9.]+[a-z]+", RegexOptions.IgnoreCase);

            if (!ValidarEmail.IsMatch(Email))
                validacao += "Email inválido\n";

            return validacao;
        }
    }
}
