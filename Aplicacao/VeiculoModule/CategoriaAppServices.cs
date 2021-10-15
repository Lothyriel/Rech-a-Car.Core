using Applicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.Repositories;
using Dominio.Shared;
using Dominio.VeiculoModule;

namespace Applicacao.VeiculoModule
{
    public class CategoriaAppServices : EntidadeAppServices<Categoria>
    {
        public CategoriaAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;

            Repositorio = dependencyResolver.Resolve<ICategoriaRepository>();
        }
        protected override IRepository<Categoria> Repositorio { get; }
    }
}
