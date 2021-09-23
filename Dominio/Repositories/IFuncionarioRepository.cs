using Dominio.Shared;

namespace Dominio.PessoaModule
{
    public interface IFuncionarioRepository : IRepository<Funcionario>
    {
        bool ExisteUsuario(string usuario);
        Funcionario GetByUserName(string text);
    }
}
