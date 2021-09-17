using Dominio.Shared;

namespace Dominio.PessoaModule.ClienteModule
{
    public interface IClienteRepository : IRepository<ICliente>
    {
        public IRepository<ClientePF> RepositorioClientePF { get; }
        public IClientePJRepository RepositorioClientePJ { get; }
    }
}
