using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System;

namespace Infra.DAO.ORM.Repositories
{
    public class ClientePJORM : BaseRepository<ClientePJ>, IClientePJRepository
    {
        public IRepository<Motorista> MotoristaRepository => new BaseRepository<Motorista>();

        public bool ExisteDocumento(string documento, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
