using Dominio.Entities.PessoaModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class SenhaORM : BaseRepository<Senha>, ISenhaRepository
    {
        public void Editar(int id_funcionario, string senha)
        {
            throw new System.NotImplementedException();
        }

        public Senha GetDadosSenha(int id_funcionario)
        {
            throw new System.NotImplementedException();
        }

        public void Inserir(int id_funcionario, string senha)
        {
            throw new System.NotImplementedException();
        }

        public bool SenhaCorreta(int id_funcionario, string senha)
        {
            throw new System.NotImplementedException();
        }
    }
}
