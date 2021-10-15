using Dominio.Repositories;
using Dominio.Shared;
using System;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClientePJRepository : IRepository<ClientePJ>
    {
        public IMotoristaRepository MotoristaRepository { get; }
        bool ExisteDocumento(string documento, Type type);
    }
}