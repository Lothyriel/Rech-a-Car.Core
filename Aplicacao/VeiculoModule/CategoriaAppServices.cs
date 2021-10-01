using Aplicacao.Shared;
using Dominio.Shared;
using Dominio.VeiculoModule;

namespace Aplicacao.VeiculoModule
{
    public class CategoriaAppServices : EntidadeAppServices<Categoria>
    {
        public CategoriaAppServices(IRepository<Categoria> repositorio)
        {
            Repositorio = repositorio;
        }
        protected override IRepository<Categoria> Repositorio { get; }
    }
}
