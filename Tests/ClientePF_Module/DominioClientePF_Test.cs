using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Tests.ClientePF_Module
{
    [TestClass]
    public class DominioClientePF_Test
    {
        [TestMethod]
        public void Deve_retornar_clientePF_valido()
        {
            CNH cnh = new CNH("36510896881", TipoCNH.C);
            ClientePF clienteValido = new ClientePF("nome", "99999999999", "endereco", "99999999999", cnh, new DateTime(2001, 04, 27), "email@teste.com");
            clienteValido.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_clientePF_invalido()
        {
            CNH cnh = new CNH("36510896881", TipoCNH.C);
            ClientePF clienteInvalido = new ClientePF(string.Empty, string.Empty, string.Empty, string.Empty, cnh, new DateTime(2001, 04, 27), "email@teste.com");
            clienteInvalido.Validar().Should().NotBe(string.Empty);
        }
    }
}
