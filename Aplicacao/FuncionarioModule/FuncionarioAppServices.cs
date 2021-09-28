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

        public override ResultadoOperacao Inserir(Funcionario funcionario)
        {
            if (Repositorio.ExisteUsuario(funcionario.NomeUsuario))
                return new ResultadoOperacao("Nome de usuário já está cadastrado", EnumResultado.Falha);

            return base.Inserir(funcionario);
        }
    }
}
