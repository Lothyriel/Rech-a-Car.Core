using Applicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.ParceiroModule;
using Dominio.Repositories;
using Dominio.Shared;

namespace Applicacao.CupomModule
{
    public class ParceiroAppServices : EntidadeAppServices<Parceiro>
    {
        protected override IParceiroRepository Repositorio { get; }

        public ParceiroAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;
            Repositorio = dependencyResolver.Resolve<IParceiroRepository>();
        }
    }
}
