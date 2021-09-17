using Dominio.Shared;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClienteRepository : IEntidadeRepository<ICliente>
    {
        public IEntidadeRepository<ClientePF> RepositorioClientePF { get; }
        public IEntidadeRepository<ClientePJ> RepositorioClientePJ { get; }
    }
}
