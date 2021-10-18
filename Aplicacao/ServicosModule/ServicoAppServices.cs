using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.ServicoModule;

namespace Aplicacao.ServicosModule
{
    public class ServicoAppServices : EntidadeAppServices<Servico>
    {
        protected override IServicoRepository Repositorio { get; }

        public ServicoAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;

            Repositorio = dependencyResolver.Resolve<IServicoRepository>();
        }
    }
}
