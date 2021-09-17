using Dominio.Shared;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClientePJRepository : IRepository<ClientePJ>
    {
        public IRepository<Motorista> MotoristaRepository { get; }
    }
}