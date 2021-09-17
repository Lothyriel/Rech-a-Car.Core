using Aplicacao.Shared;
using Dominio.ParceiroModule;
using Dominio.Shared;

namespace Aplicacao.CupomModule
{
    public class ParceiroAppServices : EntidadeAppServices<Parceiro>
    {
        public override IRepository<Parceiro> Repositorio { get; }

        public ParceiroAppServices(IRepository<Parceiro> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
