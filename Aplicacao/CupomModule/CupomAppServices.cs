using Aplicacao.Shared;
using Dominio.CupomModule;

namespace Aplicacao.CupomModule
{
    public class CupomAppServices : EntidadeAppServices<Cupom>
    {
        protected override ICupomRepository Repositorio { get; }

        public CupomAppServices(ICupomRepository repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
