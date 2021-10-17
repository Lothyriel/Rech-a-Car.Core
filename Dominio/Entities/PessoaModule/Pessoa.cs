using Dominio.Shared;

namespace Dominio.PessoaModule
{
    public abstract class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public abstract TipoPessoa TipoPessoa { get; }

        public override string Validar()
        {
            string validador = string.Empty;

            if (Nome == string.Empty)
                validador = "Insira um Nome.\n";
            if (Telefone.Length != 11)
                validador += "Telefone inválido.\n";
            if (Endereco == string.Empty)
                validador += "Insira um endereço.\n";

            validador += TipoPessoa.Validar();

            return validador;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
