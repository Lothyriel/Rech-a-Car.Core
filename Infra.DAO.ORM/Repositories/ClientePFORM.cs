using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class ClientePFORM : BaseORM<ClientePF>, IClientePFRepository
    {
        public ClientePFORM(Rech_a_carDbContext context) : base(context)
        {
        }

        public bool ExisteDocumento(string documento)
        {
            return Context.Set<ClientePF>().Where(c => c.Documento == documento).Any();
        }
    }
}
