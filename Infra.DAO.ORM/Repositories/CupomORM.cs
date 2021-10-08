using Dominio.CupomModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Repositories
{
    public class CupomORM : BaseORM<Cupom>, ICupomRepository
    {
        public Cupom GetByName(string nomeCupom)
        {
            return Context.Set<Cupom>().Where(x=> x.Nome == nomeCupom).FirstOrDefault<Cupom>();
        }
    }
}
