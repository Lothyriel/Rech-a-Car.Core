using Aplicacao.ClienteModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Infra.DAO.PessoaModule;

namespace Infra.DAO.SQL.PessoaModule
{
    public class ClienteJoinDAO : ClienteJoinRepository
    {
        public override IClientePFRepository RepositorioClientePF => new ClientePFDAO();
        public override IClientePJRepository RepositorioClientePJ => new ClientePJDAO();
    }
}
