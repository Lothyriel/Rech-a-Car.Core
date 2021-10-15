using Dominio.AluguelModule;
using Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.DAO.ORM.Repositories
{
    public class VeiculoORM : BaseORM<Veiculo>, IVeiculoRepository
    {
        public VeiculoORM(rech_a_carDbContext context) : base(context)
        {
        }

        public void AdicionarQuilometragem(Veiculo veiculo, int kmRodados)
        {
            veiculo.Quilometragem += kmRodados;
            Context.Update(veiculo);
            Context.SaveChanges();
        }

        public List<Veiculo> GetDisponiveis()
        {
            var carrosAlugados = Context.Set<Aluguel>().Where(a => a.DataDevolucao > DateTime.Today).Select(a => a.Veiculo);
            return Context.Set<Veiculo>().Except(carrosAlugados).ToList();
        }
    }
}
