using Dominio.Shared;
using System.Collections.Generic;

namespace Dominio.VeiculoModule
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        void AdicionarQuilometragem(Veiculo veiculo, int kmRodados);
        List<Veiculo> GetDisponiveis();
    }
}
