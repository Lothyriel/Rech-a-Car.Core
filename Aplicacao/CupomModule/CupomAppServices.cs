using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.CupomModule;

namespace Aplicacao.CupomModule
{
    public class CupomAppServices : EntidadeAppServices<Cupom>
    {
        protected override ICupomRepository Repositorio { get; }

        public CupomAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;
            Repositorio = dependencyResolver.Resolve<ICupomRepository>();
        }
    }
}
