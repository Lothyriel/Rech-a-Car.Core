using Aplicacao.FuncionarioModule;
using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.Repositories;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace IntegrationTests.FuncionarioModule
{
    [TestClass]
    public class FuncionarioAppServiceTests
    {
        Mock<Funcionario> funcionarioMock;
        Funcionario funcionario;
        Mock<IFuncionarioRepository> mockRepoFuncionario;
        Mock<ISenhaRepository> mockRepoSenha;
        FuncionarioAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            funcionarioMock = new();
            mockRepoSenha = new();
            funcionarioMock.Setup(x => x.Validar()).Returns("");

            funcionario = funcionarioMock.Object;

            mockRepoFuncionario = new();
            sut = new FuncionarioAppServices(mockRepoFuncionario.Object, mockRepoSenha.Object);
        }
        [TestMethod]
        public void Deve_inserir_funcionario()
        {
            sut.Inserir(funcionario).Resultado.Should().Be(EnumResultado.Sucesso);
            mockRepoFuncionario.Verify(x => x.Inserir(funcionario));
        }
        [TestMethod]
        public void Nao_deve_inserir_funcionario()
        {
            funcionarioMock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            funcionario = funcionarioMock.Object;

            sut.Inserir(funcionario).Resultado.Should().Be(EnumResultado.Falha);
            mockRepoFuncionario.Verify(x => x.ExisteUsuario(funcionario.Nome));
        }
        [TestMethod]
        public void Deve_remover_funcionario()
        {
            sut.Excluir(funcionario.Id);
            mockRepoFuncionario.Verify(x => x.Excluir(funcionario.Id, null));
        }
        [TestMethod]
        public void Deve_editar_funcionario()
        {
            sut.Editar(funcionario.Id, funcionario);
            mockRepoFuncionario.Verify(x => x.Editar(funcionario.Id, funcionario));
        }
    }
}
