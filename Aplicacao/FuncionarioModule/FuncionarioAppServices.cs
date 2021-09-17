using Aplicacao.Shared;
using Dominio.PessoaModule;

namespace Aplicacao.FuncionarioModule
{
    public class FuncionarioAppServices : EntidadeAppServices<Funcionario>
    {
        public override IFuncionarioRepository Repositorio { get; }

        public FuncionarioAppServices(IFuncionarioRepository repositorio)
        {
            Repositorio = repositorio;
        }
    }
}
