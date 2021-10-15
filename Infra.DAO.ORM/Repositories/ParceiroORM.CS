using Dominio.ParceiroModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class ParceiroORM : BaseORM<Parceiro>, IParceiroRepository
    {
        public ParceiroORM(rech_a_carDbContext context) : base(context)
        {
        }
    }
}
