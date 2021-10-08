using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class ClienteORM : IClienteRepository
    {
        public IClientePFRepository RepositorioClientePF => new ClientePFORM();
        public IClientePJRepository RepositorioClientePJ => new ClientePJORM();

        public List<ICliente> Registros => throw new NotImplementedException();

        public void Editar(int id, ICliente entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id, Type tipo = null)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int id, Type tipo = null)
        {
            throw new NotImplementedException();
        }

        public bool ExisteDocumento(string documento, Type type)
        {
            return Context.Set<ICliente>().Where(x => x.Documento == documento).Any();
        }

        public List<ICliente> FiltroGenerico(string filtro)
        {
            throw new NotImplementedException();
        }

        public ICliente GetById(int id, Type tipo = null)
        {
            throw new NotImplementedException();
        }

        public void Inserir(ICliente entidade)
        {
            throw new NotImplementedException();
        }
    }
}
