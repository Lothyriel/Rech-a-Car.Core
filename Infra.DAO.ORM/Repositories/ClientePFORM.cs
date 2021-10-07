using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using System;

namespace Infra.DAO.ORM.Repositories
{
    public class ClientePFORM : BaseRepository<ClientePF>, IClientePFRepository
    {
        public bool ExisteDocumento(string documento, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
