using Dominio.PessoaModule;
using Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Repositories
{
    class CnhORM : BaseRepository<CNH>, ICnhRepository

    {
        public void Excluir(int idCnh)
        {
            Remove(GetById(idCnh));
        }

        public CNH GetById(int idCnh)
        {
            return Set<CNH>().Find(idCnh);
        }
    }
}
