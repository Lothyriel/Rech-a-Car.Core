using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.Repositories;

namespace Aplicacao.FuncionarioModule
{
    public class FuncionarioAppServices : EntidadeAppServices<Funcionario>
    {
        public override IFuncionarioRepository Repositorio { get; }
        public ISenhaRepository RepositorioSenha { get; set; }

        public FuncionarioAppServices(IFuncionarioRepository repositorio, ISenhaRepository senhaRepository)
        {
            Repositorio = repositorio;
            RepositorioSenha = senhaRepository;
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
