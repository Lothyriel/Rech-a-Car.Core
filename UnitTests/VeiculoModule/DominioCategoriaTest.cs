using Dominio.PessoaModule;
using Dominio.PessoaModule.Condutor;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class DominioCategoriaTest
    {
        [TestMethod]
        public void Deve_retornar_grupo_valido()
        {
            var categoria = new Categoria("nome", 10, 10, 10, 10, TipoCNH.A);
            categoria.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_grupo_invalido()
        {
            var categoria = new Categoria("", -10, -10, -10, -10, TipoCNH.A);
            categoria.Validar().Should().NotBe(string.Empty);
        }
    }
}
