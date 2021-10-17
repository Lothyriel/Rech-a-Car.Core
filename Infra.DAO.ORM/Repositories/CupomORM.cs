using Dominio.CupomModule;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class CupomORM : BaseORM<Cupom>, ICupomRepository
    {
        public CupomORM(Rech_a_carDbContext context) : base(context)
        {
        }

        public Cupom GetByName(string nomeCupom)
        {
            return Context.Set<Cupom>().Where(x => x.Nome == nomeCupom).FirstOrDefault<Cupom>();
        }
    }
}
