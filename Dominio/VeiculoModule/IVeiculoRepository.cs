using Dominio.Shared;

namespace Dominio.VeiculoModule
{
    public interface IVeiculoRepository : IEntidadeRepository<Veiculo>
    {
        void AdicionarQuilometragem(Veiculo veiculo, int kmRodados);
    }
}
