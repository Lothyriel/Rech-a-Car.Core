using Dominio.CupomModule;
using Dominio.ParceiroModule;
using FluentAssertions;
using Infra.DAO.CupomModule;
using Infra.DAO.ParceiroModule;
using Infra.DAO.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Shared;

namespace Tests.CupomModule
{
    [TestClass]
    public class CupomDAOTest
    {
        ParceiroDAO ParceiroDAO = new ParceiroDAO();
        CupomDAO CupomDAO = new CupomDAO();

        public CupomDAOTest()
        {
            LimparTestes();
        }

        private void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBCupons"));
            Db.Delete(TestExtensions.ResetId("TBParceiro"));
        }

        [TestMethod]
        public void Deve_Inserir_Novo_Cupom()
        {
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko", 50, 0, new DateTime(2021, 08, 26), parceiro, 230);

            //action
            ParceiroDAO.Inserir(parceiro);
            CupomDAO.Inserir(cupom);

            //assert
            var cupomEncontrado = CupomDAO.GetById(cupom.Id);
            cupomEncontrado.Should().Be(cupom);
        }

        [TestMethod]
        public void Deve_Atualizar_Cupom()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 50, 0, new DateTime(2021, 08, 26).Date, parceiro, 300);
            var cupomAtualizado = new Cupom("Deko-5946", 10, 0, new DateTime(2021, 08, 26).Date, parceiro, 250);

            //action
            ParceiroDAO.Inserir(parceiro);
            CupomDAO.Inserir(cupom);
            CupomDAO.Editar(cupom.Id, cupomAtualizado);

            //assert
            Cupom cuponsEditado = CupomDAO.GetById(cupom.Id);
            cuponsEditado.Should().Be(cupomAtualizado);
        }

        [TestMethod]
        public void Deve_Selecionar_Cupom_ValorPercentual()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 50, 0, new DateTime(2021, 08, 26), parceiro, 300);

            //action
            ParceiroDAO.Inserir(parceiro);
            CupomDAO.Inserir(cupom);
            Cupom cupomEncontrado = CupomDAO.GetById(cupom.Id);

            //assert
            cupomEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void Deve_Selecionar_Cupom_ValorFixo()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 0, 50, new DateTime(2021, 08, 26), parceiro, 300);

            //action
            ParceiroDAO.Inserir(parceiro);
            CupomDAO.Inserir(cupom);
            Cupom cupomEncontrado = CupomDAO.GetById(cupom.Id);

            //assert
            cupomEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void Deve_Excluir_Cupons()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 50, 0, new DateTime(2021, 08, 26), parceiro, 300);

            //action
            ParceiroDAO.Inserir(parceiro);
            CupomDAO.Inserir(cupom);
            CupomDAO.Excluir(cupom.Id);

            //assert
            var cupomEncrontrado = CupomDAO.GetById(cupom.Id);
            cupomEncrontrado.Should().BeNull();
        }
    }
}
