using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Tests.ClientePJ_Module
{
    [TestClass]
    public class DominioClientePJ_Test
    {

        [TestMethod]
        public void Deve_retornar_clientePJ_valido()
        {

            ClientePJ clienteValido = new ClientePJ("nome", "99999999999", "endereco", "99999999999999", "email@teste.com");
            clienteValido.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_clientePJ_invalido()
        {
            ClientePJ clienteValido = new ClientePJ(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            clienteValido.Validar().Should().NotBe(string.Empty);
        }
    }
}
