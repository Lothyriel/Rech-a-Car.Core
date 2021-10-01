using Aplicacao.CupomModule;
using Aplicacao.Shared;
using Dominio.ParceiroModule;
using Dominio.Shared;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace IntegrationTests.CupomModule
{
    [TestClass]
    public class ParceiroAppServiceTests
    {
        Mock<Parceiro> parceiroMock;
        Parceiro parceiro;
        Mock<IRepository<Parceiro>> mockParceiroRepo;
        ParceiroAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            parceiroMock = new();
            parceiroMock.Setup(x => x.Validar()).Returns("");

            parceiro = parceiroMock.Object;

            mockParceiroRepo = new();
            sut = new ParceiroAppServices(mockParceiroRepo.Object);
        }
        [TestMethod]
        public void Deve_inserir_parceiro()
        {
            sut.Inserir(parceiro).Resultado.Should().Be(EnumResultado.Sucesso);
            mockParceiroRepo.Verify(x => x.Inserir(parceiro));
        }
        [TestMethod]
        public void Nao_deve_inserir_parceiro()
        {
            parceiroMock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            parceiro = parceiroMock.Object;

            sut.Inserir(parceiro).Resultado.Should().Be(EnumResultado.Falha);
            mockParceiroRepo.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_parceiro()
        {
            sut.Excluir(parceiro.Id);
            mockParceiroRepo.Verify(x => x.Excluir(parceiro.Id, null));
        }
        [TestMethod]
        public void Deve_editar_parceiro()
        {
            sut.Editar(parceiro.Id, parceiro);
            mockParceiroRepo.Verify(x => x.Editar(parceiro.Id, parceiro));
        }


    }
}
