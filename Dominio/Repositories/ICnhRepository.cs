using Dominio.PessoaModule;

namespace Dominio.Repositories
{
    public interface ICnhRepository
    {
        void Inserir(CNH cnh);
        void Editar(int id, CNH cnh);
        CNH GetById(int idCnh);
        void Excluir(int idCnh);
    }
}
