using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Tests.Shared;

namespace Tests.FuncionarioModule
{
    [TestClass]
    public class ControladorFuncionariotTest
    {
        ControladorFuncionario controlador = new ControladorFuncionario();
        Image imagem = Image.FromFile(@"..\..\..\Resources\user.png");
        Funcionario funcionario;

        [TestInitialize]
        public void Inserindo()
        {
            funcionario = new Funcionario("Nome", "49999155922", "Endereço", "13130847983", Cargo.Vendedor, imagem, "user_teste", "senha12345678");
            controlador.Inserir(funcionario);
        }
        [TestMethod]
        public void Deve_inserir_funcionario()
        {
            controlador.Registros.Count.Should().Be(1);
        }
        [TestMethod]
        public void Deve_editar_funcionario()
        {
            string nomeAntigo = funcionario.Nome;
            funcionario.Nome = "nomeEditado";
            controlador.Editar(funcionario.Id, funcionario);
            controlador.GetById(funcionario.Id).Nome.Should().NotBe(nomeAntigo);
        }
        [TestMethod]
        public void Deve_excluir_funcionario()
        {
            controlador.Excluir(funcionario.Id);
            controlador.Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBFuncionario"));
        }
    }
}
