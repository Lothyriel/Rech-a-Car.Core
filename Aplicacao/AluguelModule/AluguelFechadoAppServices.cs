using Aplicacao.Shared;
using Dominio.AluguelModule;
using Dominio.Shared;
using Dominio.VeiculoModule;

namespace Aplicacao.AluguelModule
{
    public class AluguelFechadoAppServices : EntidadeAppServices<AluguelFechado>
    {
        public override IEntidadeRepository<AluguelFechado> Repositorio { get; }
        public IVeiculoRepository RepositorioVeiculo { get; }
        public AluguelFechadoAppServices(IEntidadeRepository<AluguelFechado> repositorio, IVeiculoRepository repositorioVeiculo)
        {
            RepositorioVeiculo = repositorioVeiculo;
            Repositorio = repositorio;
        }
    }
}
