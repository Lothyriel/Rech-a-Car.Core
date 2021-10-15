using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using System;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class ClientePFORM : BaseORM<ClientePF>, IClientePFRepository
    {
        public ClientePFORM(rech_a_carDbContext context) : base(context)
        {
        }

        public bool ExisteDocumento(string documento, Type type)
        {
            return Context.Set<ClientePJ>().Where(c => c.Documento == documento).Any();
        }
    }
}
