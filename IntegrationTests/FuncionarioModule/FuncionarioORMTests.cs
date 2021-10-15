using Autofac;
using DependencyInjector;
using Dominio.PessoaModule;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace IntegrationTests.FuncionarioModule
{
    [TestClass]
    public class FuncionarioORMTests
    {
        Funcionario funcionario1;
        ILifetimeScope lsp;
        rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserindo()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            var imagem = Image.FromFile(@"..\..\..\Resources\user.png");
            funcionario1 = new Funcionario("Nome", "49999155922", "Endereço", "13130847983", Cargo.Vendedor, imagem, "user_teste", "senha12345678");
            new FuncionarioORM(ctx).Inserir(funcionario1);
        }
        [TestMethod]
        public void Deve_inserir_funcionario()
        {
            new FuncionarioORM(ctx).Registros.Count.Should().Be(1);
        }
        [TestMethod]
        public void Deve_editar_funcionario()
        {
            string nomeAntigo = funcionario1.Nome;
            funcionario1.Nome = "nomeEditado";
            new FuncionarioORM(ctx).Editar(funcionario1.Id, funcionario1);
            new FuncionarioORM(ctx).GetById(funcionario1.Id).Nome.Should().NotBe(nomeAntigo);
        }
        [TestMethod]
        public void Deve_excluir_funcionario()
        {
            new FuncionarioORM(ctx).Excluir(funcionario1.Id);
            new FuncionarioORM(ctx).Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBFuncionario"));
            lsp.Dispose();
        }
    }
}