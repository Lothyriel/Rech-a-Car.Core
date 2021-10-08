using Dominio.AluguelModule;
using Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Repositories
{
    public class VeiculoORM : BaseORM<Veiculo>, IVeiculoRepository
    {
        public void AdicionarQuilometragem(Veiculo veiculo, int kmRodados)
        {
            veiculo.Quilometragem += kmRodados;
            Context.Update(veiculo);
            Context.SaveChanges();
        }

        public List<Veiculo> GetDisponiveis()
        {

          return Context.Set<Aluguel>().Where(x => x.DataDevolucao < DateTime.Now).Select(a => a.Veiculo).ToList();

        }
    }
}
