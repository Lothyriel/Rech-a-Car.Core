using Dominio.Shared;
using System;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClientePJRepository : IRepository<ClientePJ>
    {
        public IRepository<Motorista> MotoristaRepository { get; }
        bool ExisteDocumento(string documento, Type type);
    }
}