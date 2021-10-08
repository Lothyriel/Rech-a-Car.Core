using Aplicacao.ClienteModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;

namespace Infra.DAO.ORM.Repositories
{
    public class ClienteJoinORM : ClienteJoinRepository
    {
        public override IClientePFRepository RepositorioClientePF => new ClientePFORM();
        public override IClientePJRepository RepositorioClientePJ => new ClientePJORM();
    }
}
