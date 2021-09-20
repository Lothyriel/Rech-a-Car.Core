using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Aplicacao.Shared;
using Dominio.CupomModule;
using Aplicacao.CupomModule;
using Dominio.PessoaModule.ClienteModule;
using Aplicacao.ClienteModule;

namespace IntegrationTests.ClientePJ_Module
{
    [TestClass]
    public class ClientePJ_AppServiceTests
    {
        Mock<ClientePJ> clientePJ_Mock;
        ClientePJ clientePJ;
        Mock<IClientePJRepository> mockClientePJ;
        ClientePJAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            clientePJ_Mock = new();
            clientePJ_Mock.Setup(x => x.Validar()).Returns("");

            clientePJ = clientePJ_Mock.Object;

            mockClientePJ = new();
            sut = new ClientePJAppServices(mockClientePJ.Object);
        }
        [TestMethod]
        public void Deve_inserir_cupom()
        {
            sut.Inserir(clientePJ).Resultado.Should().Be(EnumResultado.Sucesso);
            mockClientePJ.Verify(x => x.Inserir(clientePJ));
        }
        [TestMethod]
        public void Nao_deve_inserir_cupom()
        {
            clientePJ_Mock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            clientePJ = clientePJ_Mock.Object;

            sut.Inserir(clientePJ).Resultado.Should().Be(EnumResultado.Falha);
            mockClientePJ.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_cupom()
        {
            sut.Excluir(clientePJ.Id);
            mockClientePJ.Verify(x => x.Excluir(clientePJ.Id, null));
        }
        [TestMethod]
        public void Deve_editar_cupom()
        {
            sut.Editar(clientePJ.Id, clientePJ);
            mockClientePJ.Verify(x => x.Editar(clientePJ.Id, clientePJ));
        }


    }
}
