using Dominio.Entities.PessoaModule;

namespace Dominio.Repositories
{
    public interface ISenhaRepository
    {
        SenhaHashed GetSenhaHashed(int id_funcionario);
        bool SenhaCorreta(int id_funcionario, string senha);
        void Inserir(int idFuncionario, string senha);
        bool Excluir(int idFuncionario);
    }
}
