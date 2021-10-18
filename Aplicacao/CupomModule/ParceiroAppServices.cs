using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.ParceiroModule;
using Dominio.Repositories;

namespace Aplicacao.CupomModule
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
