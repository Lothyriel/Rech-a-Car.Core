using Aplicacao.Shared;
using Dominio.Shared;
using Dominio.VeiculoModule;

namespace Aplicacao.VeiculoModule
{
    public class CategoriaAppServices : EntidadeAppServices<Categoria>
    {
        public CategoriaAppServices(IEntidadeRepository<Categoria> repositorio)
        {
            Repositorio = repositorio;
        }
        public override IEntidadeRepository<Categoria> Repositorio { get; }
    }
}
