using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;

namespace Aplicacao.ClienteModule
{
    public class ClienteAppServices : EntidadeAppServices<ICliente>
    {
        protected override ClienteJoinRepository Repositorio { get; }

        public ClienteAppServices(ClienteJoinRepository repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
