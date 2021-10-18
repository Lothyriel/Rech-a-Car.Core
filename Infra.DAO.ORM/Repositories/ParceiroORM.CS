using Dominio.ParceiroModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class ParceiroORM : BaseORM<Parceiro>, IParceiroRepository
    {
        public ParceiroORM(Rech_a_carDbContext context) : base(context)
        {
        }
    }
}
