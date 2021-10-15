using Applicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.Repositories;
using Dominio.Shared;
using Dominio.VeiculoModule;
using System.Collections.Generic;

namespace Applicacao.VeiculoModule
{
    public class VeiculoAppServices : EntidadeAppServices<Veiculo>
    {
        public VeiculoAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;

            Repositorio = dependencyResolver.Resolve<IVeiculoRepository>();
            RepositorioCategoria = dependencyResolver.Resolve<ICategoriaRepository>();
        }

        protected override IVeiculoRepository Repositorio { get; }
        public ICategoriaRepository RepositorioCategoria { get; }
        public List<Veiculo> GetDisponiveis()
        {
            return Repositorio.GetDisponiveis();
        }
    }
}
