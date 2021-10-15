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
    public class ServicoORM : BaseORM<Servico>, IServicoRepository
    {
        public ServicoORM(rech_a_carDbContext context) : base(context)
        {
        }

        public void AlugarServicos(int id, List<Servico> servicos)
        {
            var aluguel = Context.Set<Aluguel>().Find(id);
            var nServicos = Context.Set<Servico>().Where(s => servicos.Contains(s));

            nServicos.ToList().ForEach(s => s.Aluguel = aluguel);

            Context.UpdateRange(nServicos);

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
