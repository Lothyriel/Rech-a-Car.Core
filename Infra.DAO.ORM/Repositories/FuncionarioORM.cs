using Dominio.PessoaModule;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class FuncionarioORM : BaseORM<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioORM(Rech_a_carDbContext context) : base(context)
        {
        }

        public bool ExisteUsuario(string usuario)
        {
            return Context.Set<Funcionario>().Where(x => x.Usuario == usuario).Any();
        }

        public Funcionario GetByUserName(string usuario)
        {
            return Context.Set<Funcionario>().Where(x => x.Usuario == usuario).FirstOrDefault();
        }
    }
}
