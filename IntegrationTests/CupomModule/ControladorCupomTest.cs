using Controladores.CupomModule;
using Controladores.ParceiroModule;
using Controladores.Shared;
using Dominio.CupomModule;
using Dominio.ParceiroModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Shared;

namespace Tests.CupomModule
{
    [TestClass]
    public class ControladorCupomTest
    {
        ControladorParceiro controladorParceiro = new ControladorParceiro();
        ControladorCupom controladorCupom = new ControladorCupom();

        public ControladorCupomTest()
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
            controladorParceiro.Inserir(parceiro);
            controladorCupom.Inserir(cupom);

            //assert
            var cupomEncontrado = controladorCupom.GetById(cupom.Id);
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
            controladorParceiro.Inserir(parceiro);
            controladorCupom.Inserir(cupom);
            controladorCupom.Editar(cupom.Id, cupomAtualizado);

            //assert
            Cupom cuponsEditado = controladorCupom.GetById(cupom.Id);
            cuponsEditado.Should().Be(cupomAtualizado);
        }

        [TestMethod]
        public void Deve_Selecionar_Cupom_ValorPercentual()
        {
            //arrange
            var parceiro = new Parceiro("Desconto do Deko");
            var cupom = new Cupom("Deko-1236", 50, 0, new DateTime(2021, 08, 26), parceiro, 300);

            //action
            controladorParceiro.Inserir(parceiro);
            controladorCupom.Inserir(cupom);
            Cupom cupomEncontrado = controladorCupom.GetById(cupom.Id);

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
            controladorParceiro.Inserir(parceiro);
            controladorCupom.Inserir(cupom);
            Cupom cupomEncontrado = controladorCupom.GetById(cupom.Id);

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
            controladorParceiro.Inserir(parceiro);
            controladorCupom.Inserir(cupom);
            controladorCupom.Excluir(cupom.Id);

            //assert
            var cupomEncrontrado = controladorCupom.GetById(cupom.Id);
            cupomEncrontrado.Should().BeNull();
        }
    }
}
