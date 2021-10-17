using Dominio.Entities.PessoaModule;
using Dominio.Repositories;
using Microsoft.Data.SqlClient;

namespace Infra.DAO.ORM.Repositories
{
    public class SenhaORM : ISenhaRepository
    {
        private Rech_a_carDbContext Context { get; }

        public SenhaORM(Rech_a_carDbContext context)
        {
            Context = context;
        }

        public SenhaHashed GetSenhaHashed(int idFuncionario)
        {
            return Context.Set<SenhaHashed>().Find(idFuncionario);
        }

        public void Inserir(int idFuncionario, string senha)
        {
            Context.Set<SenhaHashed>().Add(SenhaHashed.GerarNovaSenhaHashed(senha));
            Context.SaveChanges();
        }

        public bool SenhaCorreta(int idFuncionario, string senha)
        {
            var hashed = GetSenhaHashed(idFuncionario);
            return SenhaHashed.SenhaCorreta(senha, hashed);
        }
        public bool Excluir(int idFuncionario)
        {
            var entidade = GetSenhaHashed(idFuncionario);
            try
            {
                Context.Remove(entidade);
                Context.SaveChanges();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
