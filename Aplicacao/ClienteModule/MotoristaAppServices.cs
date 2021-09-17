using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.Shared;

namespace Aplicacao.ClienteModule
{
    public class MotoristaAppServices : EntidadeAppServices<Motorista>
    {
        public override IRepository<Motorista> Repositorio { get; }

        public MotoristaAppServices(IRepository<Motorista> repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
