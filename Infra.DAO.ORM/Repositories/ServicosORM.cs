using Dominio.ServicoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Repositories
{
    public class ServicosORM : BaseRepository<Servico>, IServicoRepository
    {
        public void AlugarServicos(int id, List<Servico> servicos)
        {
            throw new NotImplementedException();
        }

        public void DesalugarServicosAlugados(int id)
        {
            throw new NotImplementedException();
        }

        public List<Servico> ServicosDisponiveis(int id)
        {
            //return Set<Servico>().Find(id != 0);
            return Set<Servico>().Find(Id) != null;
        }
    }
}
