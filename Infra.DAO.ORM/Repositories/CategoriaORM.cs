using Dominio.Repositories;
using Dominio.VeiculoModule;

namespace Infra.DAO.ORM.Repositories
{
    public class CategoriaORM : BaseORM<Categoria>, ICategoriaRepository
    {
        public CategoriaORM(Rech_a_carDbContext context) : base(context)
        {
        }
    }
}
