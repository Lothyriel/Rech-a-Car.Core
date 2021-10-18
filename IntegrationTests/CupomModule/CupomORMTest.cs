using Autofac;
using DependencyInjector;
using Dominio.CupomModule;
using Dominio.ParceiroModule;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IntegrationTests.CupomModule
{
    [TestClass]
    public class CupomORMTest
    {
        Cupom cupom1;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;


        [TestInitialize]
        public void Inserir_Cupom()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            var parceiro = new Parceiro("Nome Cupom");
            cupom1 = new Cupom("Deko", 50, 0, new DateTime(2021, 08, 26), parceiro, 230, 0);
            new ParceiroORM(ctx).Inserir(parceiro);
            new CupomORM(ctx).Inserir(cupom1);
        }

        public void Deve_Inserir_Novo_Cupom()
        {
            cupom1.Id.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_Atualizar_Cupom()
        {
            string cupomMudar = cupom1.Nome;
            cupom1.Nome = "Dekodiferente";
            new CupomORM(ctx).Editar(cupom1.Id,cupom1);
            new CupomORM(ctx).GetById(cupom1.Id).Nome.Should().NotBe(cupomMudar);
        }

        [TestMethod]
        public void Deve_Excluir_Cupons()
        {
            new CupomORM(ctx).Excluir(cupom1.Id);
            new CupomORM(ctx).Existe(cupom1.Id).Should().BeFalse();
        }

        [TestCleanup]
        public void Limpar()
        {
            Db.Delete(TestExtensions.ResetId("TBCupom"));
        }
    }
}
