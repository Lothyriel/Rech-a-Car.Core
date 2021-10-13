using Dominio.CupomModule;
using Dominio.ParceiroModule;
using FluentAssertions;
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
        ParceiroORM parceiroORM = new();
        CupomORM cupomORM = new();


        [TestCleanup]
        public void Limpar()
        {
            Db.Delete(TestExtensions.ResetId("TBCupons"));
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
    }
}
