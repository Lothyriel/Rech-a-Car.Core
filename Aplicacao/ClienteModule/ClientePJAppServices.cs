using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;

namespace Aplicacao.ClienteModule
{
    public class ClientePJAppServices : EntidadeAppServices<ClientePJ>
    {
        public ICnhRepository CnhRepository { get; }

        public ClientePJAppServices(IRepository<ClientePJ> repositorio)
        {
            Repositorio = repositorio;

        }
        protected override IRepository<ClientePJ> Repositorio { get; }
    }
}
