using Dominio.Entities.PessoaModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class SenhaORM : BaseORM<Senha>, ISenhaRepository
    {
        public void Editar(int id_funcionario, string senha)
        {
            Context.Update(senha);
            Context.SaveChanges();
        }

        public Senha GetDadosSenha(int id_funcionario)
        {
            return Context.Set<Senha>().Find(id_funcionario);
        }

        public void Inserir(int id_funcionario, string senha)
        {
            var aa = Context.Set<Senha>(senha);
            Context.Add(aa);
            Context.SaveChanges();
        }

        public bool SenhaCorreta(int id_funcionario, string senha)
        {
            throw new System.NotImplementedException();
        }
    }
}
