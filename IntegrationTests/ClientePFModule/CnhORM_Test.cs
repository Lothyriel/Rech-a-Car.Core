using Autofac;
using DependencyInjector;
using Dominio.PessoaModule;
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

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class CnhORM_Test
    {
        CNH cnh;
        ILifetimeScope lsp;
        rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserir_Cnh()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            cnh = new CNH("1212120", TipoCNH.A);
            new CnhORM(ctx).Inserir(cnh);
        }

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            var cnhnova = new CNH("1212120", TipoCNH.C);
            new CnhORM(ctx).Inserir(cnhAnterior);
            new CnhORM(ctx).Editar(cnhAnterior.Id, cnhnova);

            new CnhORM(ctx).GetById(cnhAnterior.Id).TipoCnh.Should().Be(cnhnova.TipoCnh);
        }

        [TestMethod]
        public void Deve_Inserir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            new CnhORM(ctx).Inserir(cnhAnterior);
        }

        [TestMethod]
        public void Deve_Excluir_cnh_cliente()
        {
            var cnhAnterior = new CNH("1212120", TipoCNH.A);
            new CnhORM(ctx).Excluir(cnhAnterior.Id);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBCNH"));
            lsp.Dispose();
        }
    }
}
