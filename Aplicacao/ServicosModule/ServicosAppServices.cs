using Aplicacao.Shared;
using Dominio.ServicoModule;

namespace Aplicacao.ServicosModule
{
    public class ServicosAppServices : EntidadeAppServices<Servico>
    {
        protected override IServicoRepository Repositorio { get; }

        public ServicosAppServices(IServicoRepository repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
