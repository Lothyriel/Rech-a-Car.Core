using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.PessoaModule
{
    [TestClass]
    public class Motorista_Test
    {
        Motorista motorista;
        CNH cnh = new CNH("36510896881", TipoCNH.AB);
        ClientePJ cliente = new ClientePJ("nome", "99999999999", "endereco", "99999999999999", "email@teste.com");

        [TestMethod]
        public void Deve_retornar_motorista_valido()
        {
            motorista = new Motorista("Nome", "49999155922", "Rua dos testes", "01310847983", cnh, cliente);
            motorista.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_motorista_invvalido()
        {
            motorista = new Motorista(string.Empty, string.Empty, string.Empty, string.Empty, cnh, cliente);
            motorista.Validar().Should().NotBe(string.Empty);
        }
    }
}
