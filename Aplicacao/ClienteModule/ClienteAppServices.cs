using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System;

namespace Aplicacao.ClienteModule
{
    public class ClienteAppServices : EntidadeAppServices<ICliente>
    {
        public override IEntidadeRepository<ICliente> Repositorio { get; }

        public ClienteAppServices(IEntidadeRepository<ICliente> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
