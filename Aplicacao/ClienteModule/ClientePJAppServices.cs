using Applicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;

namespace Applicacao.ClienteModule
{
    public class ClientePJAppServices : EntidadeAppServices<ClientePJ>
    {
        public ICnhRepository CnhRepository { get; }
        public IMotoristaRepository MotoristaRepository { get; }

        public ClientePJAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;
            Repositorio = dependencyResolver.Resolve<IClientePJRepository>();
            MotoristaRepository = dependencyResolver.Resolve<IMotoristaRepository>();
        }
        protected override IClientePJRepository Repositorio { get; }
        public override ResultadoOperacao Inserir(ClientePJ clientePJ)
        {
            if (Repositorio.ExisteDocumento(clientePJ.Documento, clientePJ.GetType()))
                return new ResultadoOperacao("Já existe um cliente com este Documento", EnumResultado.Falha);

            return base.Inserir(clientePJ);
        }
    }
}
