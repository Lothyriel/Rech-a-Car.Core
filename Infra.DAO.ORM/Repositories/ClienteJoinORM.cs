using Aplicacao.ClienteModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class ClienteJoinORM : IClienteRepository
    {
        public IClientePFRepository RepositorioClientePF => new ClientePFORM();
        public IClientePJRepository RepositorioClientePJ => new ClientePJORM();
    }
}
