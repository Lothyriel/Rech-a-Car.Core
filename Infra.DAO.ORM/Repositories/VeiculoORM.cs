using Dominio.AluguelModule;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return Context.Set<Aluguel>().Where(a => a.DataDevolucao < DateTime.Today).Select(a => a.Veiculo).ToList();
        }
    }
}
