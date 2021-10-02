using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System;

namespace Dominio.Repositories
{
    public interface IClientePFRepository : IRepository<ClientePF>
    {
        bool ExisteDocumento(string documento, Type type);
    }
}