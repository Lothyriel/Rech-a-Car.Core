using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;

namespace Aplicacao.ClienteModule
{
    public class ClientePJAppServices : EntidadeAppServices<ClientePJ>
    {
        public ClientePJAppServices(IRepository<ClientePJ> repositorio)
        {
            Repositorio = repositorio;
        }
        public override IRepository<ClientePJ> Repositorio { get; }
    }
}
