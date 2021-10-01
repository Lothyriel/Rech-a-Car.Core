using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.ServicoModule;

namespace Aplicacao.ClienteModule
{
    public class ClienteAppServices : EntidadeAppServices<ICliente>
    {
        protected override IClienteRepository Repositorio { get; }

        public ClienteAppServices(IClienteRepository repositorio, ICnhRepository cnhRepository)
        {
            Repositorio = repositorio;

        }
    }
}
