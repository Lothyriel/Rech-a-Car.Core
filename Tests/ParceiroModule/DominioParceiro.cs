using Dominio.ParceiroModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ParceiroModule
{
    [TestClass]
    public class DominioParceiro
    {
        Parceiro parceiro;

        [TestMethod]
        public void Deve_retornar_Parceiro_valido() 
        {
            parceiro = new Parceiro("Desconto do Deko");
            parceiro.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_funcionario_invalido()
        {
            parceiro = new Parceiro("");
            parceiro.Validar().Should().NotBe(string.Empty);
        }
    }
}
