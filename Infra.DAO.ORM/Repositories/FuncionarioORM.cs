using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Repositories
{
    class FuncionarioORM : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public bool ExisteUsuario(string usuario)
        {
            return Set<Funcionario>().Where(x => x.Nome == usuario).Count() != 0; 
        }

        public Funcionario GetByUserName(string usuario)
        {
            return Set<Funcionario>().Where(x => x.Nome == usuario).FirstOrDefault();
        }
    }
}
