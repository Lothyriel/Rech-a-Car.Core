using Aplicacao.Shared;
using Dominio.Shared;
using Dominio.VeiculoModule;
using System.Collections.Generic;

namespace Aplicacao.VeiculoModule
{
    public class VeiculoAppServices : EntidadeAppServices<Veiculo>
    {
        public VeiculoAppServices(IVeiculoRepository repositorio, IRepository<Categoria> repositorioCategoria)
        {
            Repositorio = repositorio;
            RepositorioCategoria = repositorioCategoria;
        }

        protected override IVeiculoRepository Repositorio { get; }
        public IRepository<Categoria> RepositorioCategoria { get; }
        public List<Veiculo> GetDisponiveis() { return Repositorio.GetDisponiveis(); }
    }
}
