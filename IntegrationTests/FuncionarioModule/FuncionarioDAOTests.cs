using Dominio.PessoaModule;
using FluentAssertions;
using Infra.DAO.PessoaModule;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace IntegrationTests.FuncionarioModule
{
    [TestClass]
    public class FuncionarioDAOTests
    {
        FuncionarioDAO FuncionarioDAO = new();
        Image imagem = Image.FromFile(@"..\..\..\Resources\user.png");
        Funcionario funcionario;

        [TestInitialize]
        public void Inserindo()
        {
            funcionario = new Funcionario("Nome", "49999155922", "Endereço", "13130847983", Cargo.Vendedor, imagem, "user_teste", "senha12345678");
            FuncionarioDAO.Inserir(funcionario);
        }
        [TestMethod]
        public void Deve_inserir_funcionario()
        {
            FuncionarioDAO.Registros.Count.Should().Be(1);
        }
        [TestMethod]
        public void Deve_editar_funcionario()
        {
            string nomeAntigo = funcionario.Nome;
            funcionario.Nome = "nomeEditado";
            FuncionarioDAO.Editar(funcionario.Id, funcionario);
            FuncionarioDAO.GetById(funcionario.Id).Nome.Should().NotBe(nomeAntigo);
        }
        [TestMethod]
        public void Deve_excluir_funcionario()
        {
            FuncionarioDAO.Excluir(funcionario.Id);
            FuncionarioDAO.Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBFuncionario"));
        }
    }
}
