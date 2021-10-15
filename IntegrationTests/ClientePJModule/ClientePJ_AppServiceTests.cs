using Aplicacao.ClienteModule;
using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace IntegrationTests.ClientePJ_Module
{
    [TestClass]
    public class ClientePJ_AppServiceTests
    {
        Mock<ClientePJ> clientePJ_Mock;
        ClientePJ clientePJ;
        Mock<IClientePJRepository> mockClientePJ_Repo;
        ClientePJAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            clientePJ_Mock = new();
            clientePJ_Mock.Setup(x => x.Validar()).Returns("");

            clientePJ = clientePJ_Mock.Object;

            mockClientePJ_Repo = new();
            sut = new ClientePJAppServices();
        }
        [TestMethod]
        public void Deve_inserir_cupom()
        {
            sut.Inserir(clientePJ).Resultado.Should().Be(EnumResultado.Sucesso);
            mockClientePJ_Repo.Verify(x => x.Inserir(clientePJ));
        }
        [TestMethod]
        public void Nao_deve_inserir_cupom()
        {
            clientePJ_Mock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            clientePJ = clientePJ_Mock.Object;

            sut.Inserir(clientePJ).Resultado.Should().Be(EnumResultado.Falha);
            mockClientePJ_Repo.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_cupom()
        {
            sut.Excluir(clientePJ.Id);
            mockClientePJ_Repo.Verify(x => x.Excluir(clientePJ.Id, null));
        }
        [TestMethod]
        public void Deve_editar_cupom()
        {
            sut.Editar(clientePJ.Id, clientePJ);
            mockClientePJ_Repo.Verify(x => x.Editar(clientePJ.Id, clientePJ));
        }


    }
}
