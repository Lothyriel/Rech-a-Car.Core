using Aplicacao.ClienteModule;
using Aplicacao.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.Shared;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace IntegrationTests.ClientePF_Module
{
    [TestClass]
    public class ClientePF_AppServiceTest
    {
        Mock<ClientePF> clientePF_Mock;
        Mock<CNH> cnh_Mock;
        ClientePF clientePF;
        CNH cnh;
        Mock<IClientePFRepository> mockClientePF_Repo;
        Mock<ICnhRepository> mockCnh_Repo;
        ClientePFAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            clientePF_Mock = new();
            cnh_Mock = new();

            clientePF_Mock.Setup(x => x.Validar()).Returns("");
            cnh_Mock.Setup(x => x.Validar()).Returns("");

            clientePF = clientePF_Mock.Object;
            cnh = cnh_Mock.Object;

            mockClientePF_Repo = new();
            mockCnh_Repo = new();

            sut = new ClientePFAppServices();
        }
        [TestMethod]
        public void Deve_inserir_ClientePF()
        {
            sut.Inserir(clientePF).Resultado.Should().Be(EnumResultado.Sucesso);
            mockClientePF_Repo.Verify(x => x.Inserir(clientePF));
        }
        [TestMethod]
        public void Nao_deve_inserir_ClientePF()
        {
            clientePF_Mock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            clientePF = clientePF_Mock.Object;

            sut.Inserir(clientePF).Resultado.Should().Be(EnumResultado.Falha);
            mockClientePF_Repo.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_ClientePF()
        {
            sut.Excluir(clientePF.Id);
            mockClientePF_Repo.Verify(x => x.Excluir(clientePF.Id, null));
        }
        [TestMethod]
        public void Deve_editar_ClientePF()
        {
            sut.Editar(clientePF.Id, clientePF);
            mockClientePF_Repo.Verify(x => x.Editar(clientePF.Id, clientePF));
        }
    }
}
