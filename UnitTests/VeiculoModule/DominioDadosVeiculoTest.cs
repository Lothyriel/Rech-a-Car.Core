using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class DominioCategoriaTest
    {
        [TestMethod]
        public void Deve_retornar_dadosveiculo_valido()
        {
            Categoria categoria = new Categoria("Economico", 100, 10, 400, 800, TipoCNH.B);
            categoria.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_dadosveiculo_invalido()
        {
            Categoria categoria = new Categoria(string.Empty, -1, -1, -1, -1, TipoCNH.E);
            categoria.Validar().Should().NotBe(string.Empty);
        }
    }
}
