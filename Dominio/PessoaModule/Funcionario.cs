using System.Drawing;

namespace Dominio.PessoaModule
{
    public class Funcionario : PessoaFisica, Usuario
    {
        public Funcionario(string nome, string telefone, string endereco, string documento, Cargo cargo, Image foto, string usuario, string senha = null)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Cargo = cargo;
            Foto = foto;
            NomeUsuario = usuario;
            Senha = senha;
        }
        public Image Foto { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public Cargo Cargo { get; set; }

        public override string Validar()
        {
            var validacao = base.Validar();

            if (NomeUsuario.Length < 5)
                validacao += "Nome de usuário inválido\n";
            if (Senha?.Length < 8)
                validacao += "Senha precisa ter no mínimo 8 caracteres";

            return validacao;
        }
    }
    public enum Cargo { SysAdmin, Vendedor }
}
