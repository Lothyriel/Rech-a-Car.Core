using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;

namespace Infra.DAO.ORM.Repositories
{
    public class VeiculoORM : BaseRepository<Veiculo>, IVeiculoRepository
    {
        public void AdicionarQuilometragem(Veiculo veiculo, int kmRodados)
        {
            
        }

        public List<Veiculo> GetDisponiveis()
        {
            throw new NotImplementedException();
        }
    }
}
