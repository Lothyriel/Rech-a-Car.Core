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

        public override ResultadoOperacao Inserir(Funcionario entidade)
        {
            var inserir = base.Inserir(entidade);

            if (inserir.Resultado == EnumResultado.Falha)
                return inserir;

            return inserir;
        }
    }
}
