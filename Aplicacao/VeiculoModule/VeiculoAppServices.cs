using Aplicacao.Shared;
using Dominio.Shared;
using Dominio.VeiculoModule;

namespace Aplicacao.VeiculoModule
{
    public class VeiculoAppServices : EntidadeAppServices<Veiculo>
    {
        public VeiculoAppServices(IVeiculoRepository repositorio, IEntidadeRepository<Categoria> repositorioCategoria)
        {
            Repositorio = repositorio;
            RepositorioCategoria = repositorioCategoria;
        }

        public override IVeiculoRepository Repositorio { get; }
        public IEntidadeRepository<Categoria> RepositorioCategoria { get; }
    }
}
