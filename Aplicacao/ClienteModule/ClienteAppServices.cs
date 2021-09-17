using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System;

namespace Aplicacao.ClienteModule
{
    public class ClienteAppServices : EntidadeAppServices<ICliente>
    {
        public override IClienteRepository Repositorio { get; }

        public ClienteAppServices(IClienteRepository repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
