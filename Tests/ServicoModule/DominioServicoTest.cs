using Dominio.ServicoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Tests.ServicoModule
{
    [TestClass]
    public class DominioServicoTest
    {
        Servico servicoValido;
        [TestMethod]
        public void Deve_retornar_servico_valido()
        {
            servicoValido = new Servico("nome", 50);
            servicoValido.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_servico_invalido()
        {
            servicoValido = new Servico(string.Empty, 0);
            servicoValido.Validar().Should().NotBe(string.Empty);
        }
    }
}
