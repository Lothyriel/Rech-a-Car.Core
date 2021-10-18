using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;

namespace Dominio.Repositories
{
    public interface IClientePFRepository : IRepository<ClientePF>
    {
        bool ExisteDocumento(string documento);
    }
}