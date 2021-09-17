using Dominio.Shared;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface ICliente : IEntidade
    {
        string Nome { get; set; }
        string Telefone { get; set; }
        string Endereco { get; set; }
        string Documento { get; set; }
        string Email { get; set; }

        static string sexo() { return ""; }
    }
}
