using Autofac;
using DependencyInjector;
using Dominio.ParceiroModule;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.CupomModule
{
    [TestClass]
    public class ParceiroORMTest
    {
        Parceiro parceiro;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserindo()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            parceiro = new Parceiro("Desconto do Deko");
            new ParceiroORM(ctx).Inserir(parceiro);
        }

        [TestMethod]
        public void Deve_inserir_Parceiro()
        {
            new ParceiroORM(ctx).Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_editar_Parceiro()
        {
            var parceiroAnterior = parceiro.Nome;
            parceiro.Nome = "Nome editado";
            new ParceiroORM(ctx).Editar(parceiro.Id, parceiro);
            new ParceiroORM(ctx).GetById(parceiro.Id).Nome.Should().NotBe(parceiroAnterior);
        }

        [TestMethod]
        public void Deve_excluir_Parceiro()
        {
            new ParceiroORM(ctx).Excluir(parceiro.Id);
            new ParceiroORM(ctx).Registros.Count.Should().Be(0);
        }


        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBParceiro"));
            lsp.Dispose();
        }
    }
}
