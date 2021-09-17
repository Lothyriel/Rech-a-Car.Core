using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;

namespace Aplicacao.ClienteModule
{
    public class ClientePFAppServices : EntidadeAppServices<ClientePF>
    {
        public ClientePFAppServices(IRepository<ClientePF> repositorio)
        {
            Repositorio = repositorio;
        }
        public override IRepository<ClientePF> Repositorio { get; }
    }
}
