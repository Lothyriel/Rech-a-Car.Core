using Dominio.Shared;

namespace Dominio.CupomModule
{
    public interface ICupomRepository : IRepository<Cupom>
    {
        Cupom GetByName(string nomeCupom);
    }
}
