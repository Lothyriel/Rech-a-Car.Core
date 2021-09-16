using Dominio.PessoaModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using UnitTests.Properties;

namespace Tests.Tests.FuncionarioModule
{
    [TestClass]
    public class DominioFuncionario
    {
        Funcionario funcionario;
        Image imagem = Resources.rech;

        [TestMethod]
        public void Deve_retornar_funcionario_valido()
        {
            funcionario = new Funcionario("Nome", "49999155922", "Rua dos testes", "01310847983", Cargo.SysAdmin, imagem, "user_teste");
            funcionario.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_funcionario_invalido()
        {
            funcionario = new Funcionario("", "", "", "", Cargo.Vendedor, null, "");
            funcionario.Validar().Should().NotBe(string.Empty);
        }
    }
}
