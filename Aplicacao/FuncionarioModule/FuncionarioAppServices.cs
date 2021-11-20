using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.PessoaModule;
using Dominio.Repositories;

namespace Aplicacao.FuncionarioModule
{
    public class FuncionarioAppServices : EntidadeAppServices<Funcionario>
    {
        protected override IFuncionarioRepository Repositorio { get; }
        private ISenhaRepository RepositorioSenha { get; set; }

        public FuncionarioAppServices()
        {
            var dependencyResolver = DependencyInjection.Container;
            Repositorio = dependencyResolver.Resolve<IFuncionarioRepository>();

            RepositorioSenha = dependencyResolver.Resolve<ISenhaRepository>();
        }

        public override ResultadoOperacao Inserir(Funcionario funcionario)
        {
            if (Repositorio.ExisteUsuario(funcionario.Usuario))
                return new ResultadoOperacao("Nome de usuário já está cadastrado", EnumResultado.Falha);

            RepositorioSenha.Inserir(funcionario.Id, funcionario.Senha);

            return base.Inserir(funcionario);
        }

        public bool ExisteUsuario(string usuario)
        {
            return Repositorio.ExisteUsuario(usuario);
        }
        public bool SenhaCorreta(int id_funcionario, string senha)
        {
            return RepositorioSenha.SenhaCorreta(id_funcionario, senha);
        }
        public Funcionario GetByUserName(string userName)
        {
            return Repositorio.GetByUserName(userName);
        }
    }
}
