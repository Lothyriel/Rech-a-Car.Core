using Dominio.Entities.PessoaModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class SenhaORM : BaseORM<SenhaHashed>, ISenhaRepository
    {
        public void Editar(int id_funcionario, string senha)
        {
            Context.Update(senha);
            Context.SaveChanges();
        }

        public SenhaHashed GetSenhaHashed(int id_funcionario)
        {
            return Context.Set<SenhaHashed>().Find(id_funcionario);
        }

        public void Inserir(int id_funcionario, string senha)
        {
            Context.Set<SenhaHashed>().Add(SenhaHashed.GerarNovaSenhaHashed(senha));
            Context.SaveChanges();
        }

        public bool SenhaCorreta(int id_funcionario, string senha)
        {
            var hashed = GetSenhaHashed(id_funcionario);
            return SenhaHashed.SenhaCorreta(senha, hashed);enha
        }
    }
}
