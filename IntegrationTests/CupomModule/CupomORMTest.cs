using Autofac;
using DependencyInjector;
using Dominio.CupomModule;
using Dominio.ParceiroModule;
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

namespace IntegrationTests.CupomModule
{
    [TestClass]
    public class CupomORMTest
    {
        ParceiroORM parceiroORM;
        CupomORM cupomORM;

        Cupom cupom1;
        ILifetimeScope lsp;
        rech_a_carDbContext ctx;


        [TestInitialize]
        public void Inserir_Cupom()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            var parceiro = new Parceiro("Nome Cupom");
            cupom1 = new Cupom("Deko", 50, 0, new DateTime(2021, 08, 26), parceiro, 230, 0);
            new ParceiroORM(ctx).Inserir(parceiro);
            new CupomORM(ctx).Inserir(cupom1);
        }

        public void Deve_Inserir_Novo_Cupom()
        {
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko", 50, 0, new DateTime(2021, 08, 26), parceiro, 230, 0);

            //action
            parceiroORM.Inserir(parceiro);
            cupomORM.Inserir(cupom);

            //assert
            var cupomEncontrado = cupomORM.GetById(cupom.Id);
            cupomEncontrado.Should().Be(cupom);
        }
        [TestMethod]
        public void Deve_Atualizar_Cupom()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 50, 0, new DateTime(2021, 08, 26).Date, parceiro, 300, 0);
            var cupomAtualizado = new Cupom("Deko-5946", 10, 0, new DateTime(2021, 08, 26).Date, parceiro, 250, 0);

            //action
            parceiroORM.Inserir(parceiro);
            cupomORM.Inserir(cupom);
            cupomORM.Editar(cupom.Id, cupomAtualizado);

            //assert
            Cupom cuponsEditado = cupomORM.GetById(cupom.Id);
            cuponsEditado.Should().Be(cupomAtualizado);
        }
        [TestMethod]
        public void Deve_Selecionar_Cupom_ValorPercentual()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 50, 0, new DateTime(2021, 08, 26), parceiro, 300, 0);

            //action
            parceiroORM.Inserir(parceiro);
            cupomORM.Inserir(cupom);
            Cupom cupomEncontrado = cupomORM.GetById(cupom.Id);

            //assert
            cupomEncontrado.Should().NotBeNull();
        }
        [TestMethod]
        public void Deve_Selecionar_Cupom_ValorFixo()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 0, 50, new DateTime(2021, 08, 26), parceiro, 300, 0);

            //action
            parceiroORM.Inserir(parceiro);
            cupomORM.Inserir(cupom);
            Cupom cupomEncontrado = cupomORM.GetById(cupom.Id);

            //assert
            cupomEncontrado.Should().NotBeNull();
        }
        [TestMethod]
        public void Deve_Excluir_Cupons()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 50, 0, new DateTime(2021, 08, 26), parceiro, 300, 0);

            //action
            parceiroORM.Inserir(parceiro);
            cupomORM.Inserir(cupom);
            cupomORM.Excluir(cupom.Id);

            //assert
            var cupomEncrontrado = cupomORM.GetById(cupom.Id);
            cupomEncrontrado.Should().BeNull();
        }

        [TestMethod]
        public void Deve_Ordenar_Cupons()
        {


        }


        [TestCleanup]
        public void Limpar()
        {
            Db.Delete(TestExtensions.ResetId("TBCupons"));
        }
    }
}
