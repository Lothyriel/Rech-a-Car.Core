using Autofac;
using DependencyInjector;
using Dominio.PessoaModule.Condutor;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class CnhORM_Test
    {
        CNH cnh;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserir_Cnh()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            cnh = new CNH("1212120", TipoCNH.A);
            new DadosCondutorORM(ctx).Inserir(cnh);
        }

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            var cnhnova = new CNH("1212120", TipoCNH.C);
            new DadosCondutorORM(ctx).Inserir(cnhAnterior);
            new DadosCondutorORM(ctx).Editar(cnhAnterior.Id, cnhnova);

            new DadosCondutorORM(ctx).GetById(cnhAnterior.Id).TipoCnh.Should().Be(cnhnova.TipoCnh);
        }

        [TestMethod]
        public void Deve_Inserir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            new DadosCondutorORM(ctx).Inserir(cnhAnterior);
        }

        [TestMethod]
        public void Deve_Excluir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            new DadosCondutorORM(ctx).Excluir(cnhAnterior.Id);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBCNH"));
            lsp.Dispose();
        }
    }
}
