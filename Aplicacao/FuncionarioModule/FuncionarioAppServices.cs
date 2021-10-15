using Aplicacao.Shared;
using Autofac;
using DependencyInjector;
using Dominio.PessoaModule;
using Dominio.Repositories;
using System;

namespace Aplicacao.FuncionarioModule
{
    public class FuncionarioAppServices : EntidadeAppServices<Funcionario>
    {
        protected override IFuncionarioRepository Repositorio { get; }
        public ISenhaRepository RepositorioSenha { get; set; }

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

        public override void Excluir(int id, Type tipo = null)
        {
            base.Excluir(id, tipo);
            //RepositorioSenha.Excluir(id); ATUALMENTE ISSO TA SENDO GARANTIDO PELAS CHAVES ESTRANGEIRAS NO BANCO, MAS PROVAVELMENTE TEM QUE MUDAR PQ NEM TODAS AS FORMAS DE PERMANCENCIA TEM CASCADE E FKs
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
