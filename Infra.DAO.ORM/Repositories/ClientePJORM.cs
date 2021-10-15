using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;
using System;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class ClientePJORM : BaseORM<ClientePJ>, IClientePJRepository
    {
        public IMotoristaRepository MotoristaRepository => new MotoristaORM(Context);

        public ClientePJORM(rech_a_carDbContext context) : base(context)
        {
        }

        public bool ExisteDocumento(string documento, Type type)
        {
            return Context.Set<ClientePJ>().Where(c => c.Documento == documento).Any();
        }
    }
}
