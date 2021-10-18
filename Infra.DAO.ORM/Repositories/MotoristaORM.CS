using Dominio.PessoaModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class MotoristaORM : BaseORM<Motorista>, IMotoristaRepository
    {
        public MotoristaORM(Rech_a_carDbContext context) : base(context)
        {
        }
    }
}
