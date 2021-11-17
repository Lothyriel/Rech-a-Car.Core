using Autofac;
using DependencyInjector;
using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.Condutor;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class DadosCondutorORM_Test
    {
        DadosCondutor dados;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;
        DadosCondutorORM orm;

        [TestInitialize]
        public void Inserir_Cnh()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            dados = new DadosCondutor(new CNH("1212120", TipoCNH.A));
            orm = new DadosCondutorORM(ctx);
            orm.Inserir(dados);
        }

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            var cnhNova = new CNH("1212120", TipoCNH.C);
            dados.Cnh = cnhNova;

            orm.Editar(dados.Id, dados);

            orm.GetById(dados.Id).Cnh.TipoCnh.Should().Be(cnhNova.TipoCnh);
        }

        [TestMethod]
        public void Deve_Inserir_cnh_cliente()
        {
            orm.Inserir(dados);
            orm.Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_Excluir_cnh_cliente()
        {
            orm.Excluir(dados.Id);
            orm.Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            ctx.DeleteAll<DadosCondutor>();
            ctx.SaveChanges();
            lsp.Dispose();
        }
    }
}