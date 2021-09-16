using Aplicacao.Shared;
using Dominio.Shared;
using Dominio.VeiculoModule;

namespace Aplicacao.VeiculoModule
{
    public class VeiculoAppServices : EntidadeAppServices<Veiculo>
    {
        public VeiculoAppServices(IEntidadeRepository<Veiculo> repositorio)
        {
            Repositorio = repositorio;
        }

        public override IEntidadeRepository<Veiculo> Repositorio { get; }
    }
}
