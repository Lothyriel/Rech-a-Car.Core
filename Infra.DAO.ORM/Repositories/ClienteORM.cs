using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using System;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class ClienteORM : BaseRepository<ICliente>, IClienteRepository
    {
        public IClientePFRepository RepositorioClientePF => new ClientePFORM();
        public IClientePJRepository RepositorioClientePJ => new ClientePJORM();

        public bool ExisteDocumento(string documento, Type type)
        {
            return Set<ICliente>().Where(x=>x.Documento==documento).Count() != 0;
        }
    }
}
