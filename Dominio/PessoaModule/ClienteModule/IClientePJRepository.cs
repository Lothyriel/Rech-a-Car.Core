using Dominio.Shared;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClientePJRepository : IEntidadeRepository<ClientePJ>
    {
        public IEntidadeRepository<Motorista> MotoristaRepository { get; }
    }
}