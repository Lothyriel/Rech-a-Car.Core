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
        Parceiro parceiro1;
        ILifetimeScope lsp;
        rech_a_carDbContext ctx;

        
        Parceiro parceiro;

        
        [TestInitialize]
        public void Inserindo()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();
            ParceiroORM ParceiroORM = new(ctx);

            parceiro = new Parceiro("Desconto do Deko");
            ParceiroORM.Inserir(parceiro);
        }

        [TestMethod]
        public void Deve_inserir_Parceiro()
        {
            using var lsp = DependencyInjection.Container.BeginLifetimeScope();
            var ctx = lsp.Resolve<rech_a_carDbContext>();

            new ParceiroORM(ctx).Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_editar_Parceiro()
        {
            using var lsp = DependencyInjection.Container.BeginLifetimeScope();
            var ctx = lsp.Resolve<rech_a_carDbContext>();

            var parceiroAnterior = parceiro.nome;
            parceiro.nome = "Nome editado";
            new ParceiroORM(ctx).Editar(parceiro.Id, parceiro);
            new ParceiroORM(ctx).GetById(parceiro.Id).nome.Should().NotBe(parceiroAnterior);
        }

        [TestMethod]
        public void Deve_excluir_Parceiro()
        {
            using var lsp = DependencyInjection.Container.BeginLifetimeScope();
            var ctx = lsp.Resolve<rech_a_carDbContext>();

            new ParceiroORM(ctx).Excluir(parceiro.Id);
            new ParceiroORM(ctx).Registros.Count.Should().Be(0);
        }


        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBParceiro"));
        }
    }
}
