using Dominio.AluguelModule;

namespace Infra.DAO.ORM.Repositories
{
    public class AluguelORM : BaseORM<Aluguel>, IAluguelRepository
    {
        public AluguelORM(Rech_a_carDbContext context) : base(context)
        {
        }
    }
}
