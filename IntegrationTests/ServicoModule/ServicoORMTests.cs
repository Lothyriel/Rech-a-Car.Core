using Autofac;
using DependencyInjector;
using Dominio.ServicoModule;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ServicoModule
{
    [TestClass]
    public class ServicoORMTests
    {
        Servico servico1;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserindo_no_banco()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            servico1 = new("nomeServico", 10, null);
            new ServicoORM(ctx).Inserir(servico1);

        }
        [TestMethod]
        public void Deve_inserir_um_servico()
        {

            servico1.Id.Should().NotBe(0);
        }

        [TestMethod]
        public void Deve_editar_nome_servico()
        {

            string nomeAnterior = servico1.Nome;

            servico1.Nome = "novoNome";
            new ServicoORM(ctx).Editar(servico1.Id, servico1);
            new ServicoORM(ctx).GetById(servico1.Id).Nome.Should().NotBe(nomeAnterior);
        }

        [TestMethod]
        public void Deve_remover_servico()
        {
            new ServicoORM(ctx).Excluir(servico1.Id);
            new ServicoORM(ctx).Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            ctx.DeleteAll<Servico>();
            ctx.SaveChanges();
            lsp.Dispose();
        }
    }
}