using Applicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Join.ClienteModule;

namespace Applicacao.ClienteModule
{
    public class ClienteAppServices : EntidadeAppServices<ICliente>
    {
        protected override ClienteJoinRepository Repositorio { get; }

        public IClientePFRepository RepositorioClientePF { get; }
        public IClientePJRepository RepositorioClientePJ { get; }

        public ClienteAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;

            var pfRepo = dependencyResolver.Resolve<IClientePFRepository>();
            var pjRepo = dependencyResolver.Resolve<IClientePJRepository>();

            Repositorio = new ClienteJoinRepository(pfRepo, pjRepo);
        }
    }
}
