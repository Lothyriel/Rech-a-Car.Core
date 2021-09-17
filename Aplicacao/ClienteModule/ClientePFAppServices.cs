using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;

namespace Aplicacao.ClienteModule
{
    public class ClientePFAppServices : EntidadeAppServices<ClientePF>
    {
        public ClientePFAppServices(IEntidadeRepository<ClientePF> repositorio)
        {
            Repositorio = repositorio;
        }
        public override IEntidadeRepository<ClientePF> Repositorio { get; }
    }
}
