using Aplicacao.Shared;
using Dominio.CupomModule;

namespace Aplicacao.CupomModule
{
    public class CupomAppServices : EntidadeAppServices<Cupom>
    {
        public override ICupomRepository Repositorio { get; }

        public CupomAppServices(ICupomRepository repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
