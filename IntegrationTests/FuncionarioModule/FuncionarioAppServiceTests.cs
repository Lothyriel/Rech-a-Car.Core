using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Dominio.Shared;
using Aplicacao.ServicosModule;
using Aplicacao.Shared;
using Dominio.ServicoModule;

namespace IntegrationTests.FuncionarioModule
{
    [TestClass]
    public class FuncionarioAppServiceTests
    {
        Mock<Servico> servicoMock;
        Servico servico;
        Mock<IServicoRepository> mockRepoServico;
        ServicosAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            servicoMock = new();
            servicoMock.Setup(x => x.Validar()).Returns("");

            servico = servicoMock.Object;


            mockRepoServico = new();
            sut = new ServicosAppServices(mockRepoServico.Object);
        }
        [TestMethod]
        public void Deve_inserir_veiculo()
        {
            sut.Inserir(servico).Resultado.Should().Be(EnumResultado.Sucesso);
            mockRepoServico.Verify(x => x.Inserir(servico));
        }
        [TestMethod]
        public void Nao_deve_inserir_veiculo()
        {
            servicoMock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            servico = servicoMock.Object;

            sut.Inserir(servico).Resultado.Should().Be(EnumResultado.Falha);
            mockRepoServico.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_veiculo()
        {
            sut.Excluir(servico.Id);
            mockRepoServico.Verify(x => x.Excluir(servico.Id, null));
        }
        // VERIFICAR DEPOIS
        //[TestMethod]
        //public void Nao_deve_remover_veiculo()
        //{
        //    sut.Excluir(543);
        //    mockrepoVeiculo.Verify(x => x.Excluir(veiculo.Id, null));
        //}
        [TestMethod]
        public void Deve_editar_veiculo()
        {
            sut.Editar(servico.Id, servico);
            mockRepoServico.Verify(x => x.Editar(servico.Id, servico));
        }
    }
}
