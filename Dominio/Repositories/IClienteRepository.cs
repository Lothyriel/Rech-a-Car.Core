using Dominio.Repositories;
using Dominio.Shared;
using System;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClienteRepository : IRepository<ICliente>
    {
        public IClientePFRepository RepositorioClientePF { get; }
        public IClientePJRepository RepositorioClientePJ { get; }

        bool ExisteDocumento(string documento, Type type);
    }
}
