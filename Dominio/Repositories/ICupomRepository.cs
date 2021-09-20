using Dominio.Shared;
using System.Collections.Generic;

namespace Dominio.CupomModule
{
    public interface ICupomRepository : IRepository<Cupom>
    {
        Cupom GetByName(string nomeCupom);
        List<Cupom> OrdenadoPorUsos();
    }
}
