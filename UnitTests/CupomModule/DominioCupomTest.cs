using Dominio.CupomModule;
using Dominio.ParceiroModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.CupomModule
{
    [TestClass]
    public class DominioCupomTest
    {
        [TestMethod]
        public void Deve_retornar_clientePJ_valido()
        {
            Parceiro parceiro = new Parceiro("Deko");
            Cupom cupomValido = new Cupom("DEKO-1563", 0, 120, DateTime.Today.AddDays(2), parceiro, 200, 0);
            cupomValido.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_Cupom_invalido()
        {
            Cupom cupomValido = new Cupom(string.Empty, int.MinValue, double.MinValue, DateTime.MinValue, null, double.MinValue, 0);
            cupomValido.Validar().Should().NotBe(string.Empty);
        }

        [TestMethod]
        public void Deve_Retornar_ValorPercentual_Invalido()
        {
            Parceiro parceiro = new Parceiro("Deko");
            Cupom cupons = new Cupom("DEKO1", -1, 120, DateTime.Today.AddDays(2), parceiro, 1200, 0);
            Assert.AreEqual("Valor Percentual não pode ser menor que Zero.\n", cupons.Validar());
        }

        [TestMethod]
        public void Deve_Retornar_Nome_Invalido()
        {
            Parceiro parceiro = new Parceiro("Deko");
            Cupom cupons = new Cupom("", 0, 120, DateTime.Today.AddDays(2), parceiro, 1200, 0);
            Assert.AreEqual("O campo nome é obrigatório e não pode ser vazio.\n", cupons.Validar());
        }

        [TestMethod]
        public void Deve_Retornar_valorFixo_Invalido()
        {
            Parceiro parceiro = new Parceiro("Deko");
            Cupom cupons = new Cupom("deko03", 0, -120, DateTime.Today.AddDays(2), parceiro, 1200, 0);
            Assert.AreEqual("Valor Fixo não pode ser Menor que Zero.\n", cupons.Validar());
        }

        [TestMethod]
        public void Deve_Retornar_valorPercentual_Invalido_maior_que_cem()
        {
            Parceiro parceiro = new Parceiro("Deko");
            Cupom cupons = new Cupom("deko03", 110, 0, DateTime.Today.AddDays(2), parceiro, 1200, 0);
            Assert.AreEqual("Valor Percentual não pode ser Maior que Cem.\n", cupons.Validar());
        }

        [TestMethod]
        public void Deve_Retornar_Data_Invalido()
        {
            Parceiro parceiro = new Parceiro("Deko");
            Cupom cupons = new Cupom("deko03", 90, 0, DateTime.MinValue, parceiro, 250, 0);
            Assert.AreEqual("A data Invalida, Insira uma data valida.\n", cupons.Validar());
        }

        [TestMethod]
        public void Deve_Retornar_Parceiro_Invalido()
        {
            Cupom cupons = new Cupom("deko03", 90, 0, DateTime.Today.AddDays(2), null, 250, 0);
            Assert.AreEqual("O campo Parceiro é obrigatório e não pode ser vazio.\n", cupons.Validar());
        }

        [TestMethod]
        public void Deve_Retornar_ValorDesconto_Invalido()
        {
            Parceiro parceiro = new Parceiro("Deko");
            Cupom cupons = new Cupom("deko03", 0, 350, DateTime.Today.AddDays(2), parceiro, 25, 0);
            Assert.AreEqual("O valor Minimo não pode ser menor que o valor de Desconto.\n", cupons.Validar());
        }
    }
}
