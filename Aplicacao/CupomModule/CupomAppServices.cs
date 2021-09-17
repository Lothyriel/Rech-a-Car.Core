using Aplicacao.Shared;
using Dominio.CupomModule;
using Dominio.Shared;

namespace Aplicacao.CupomModule
{
    public class CupomAppServices : EntidadeAppServices<Cupom>
    {
        public override IRepository<Cupom> Repositorio { get; }

        public CupomAppServices(IRepository<Cupom> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}

