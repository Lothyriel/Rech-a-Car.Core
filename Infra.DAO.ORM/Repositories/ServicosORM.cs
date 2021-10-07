using Dominio.AluguelModule;
using Dominio.ServicoModule;
using Microsoft.EntityFrameworkCore;
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
            //ISSO AQUI PROVAVELMENTE ESTA ERRADO
            //var addServico = Context.Set<Servico>().Where(x => x.Aluguel != null);

            var addServico = Context.Set<Servico>().Find(id);

            Context.Add(addServico);

            Context.SaveChanges();
          
        }
        public void DesalugarServicosAlugados(int id)
        {
            var alugueis = Context.Set<Servico>().Where(x => x.Aluguel != null);

            Task.Run(async() => await alugueis.ForEachAsync(x => x.Aluguel = null));

            Context.UpdateRange(alugueis);

            Context.SaveChanges();
        }

        public List<Servico> ServicosDisponiveis()
        {
            return Context.Set<Servico>().AsNoTracking().Where(x => x.Aluguel == null).ToList();
        }
    }
}
