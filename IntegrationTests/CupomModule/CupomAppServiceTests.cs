using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Aplicacao.ServicosModule;
using Aplicacao.Shared;
using Dominio.PessoaModule;
using Aplicacao.FuncionarioModule;
using Dominio.CupomModule;
using Aplicacao.CupomModule;

namespace IntegrationTests.CupomModule
{
    [TestClass]
    public class CupomAppServiceTests
    {
        Mock<Cupom> cupomMock;
        Cupom cupom;
        Mock<ICupomRepository> mockCupomRepo;
        CupomAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            cupomMock = new();
            cupomMock.Setup(x => x.Validar()).Returns("");

            cupom = cupomMock.Object;

            mockCupomRepo = new();
            sut = new CupomAppServices(mockCupomRepo.Object);
        }
        [TestMethod]
        public void Deve_inserir_cupom()
        {
            sut.Inserir(cupom).Resultado.Should().Be(EnumResultado.Sucesso);
            mockCupomRepo.Verify(x => x.Inserir(cupom));
        }
        [TestMethod]
        public void Nao_deve_inserir_cupom()
        {
            cupomMock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            cupom = cupomMock.Object;

            sut.Inserir(cupom).Resultado.Should().Be(EnumResultado.Falha);
            mockCupomRepo.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_cupom()
        {
            sut.Excluir(cupom.Id);
            mockCupomRepo.Verify(x => x.Excluir(cupom.Id, null));
        }
        [TestMethod]
        public void Deve_editar_cupom()
        {
            sut.Editar(cupom.Id, cupom);
            mockCupomRepo.Verify(x => x.Editar(cupom.Id, cupom));
        }





    }
}
