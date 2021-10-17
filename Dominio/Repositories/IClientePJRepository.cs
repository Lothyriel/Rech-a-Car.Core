using Dominio.Repositories;
using Dominio.Shared;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClientePJRepository : IRepository<ClientePJ>
    {
        public IMotoristaRepository MotoristaRepository { get; }
        bool ExisteDocumento(string documento);
    }
}