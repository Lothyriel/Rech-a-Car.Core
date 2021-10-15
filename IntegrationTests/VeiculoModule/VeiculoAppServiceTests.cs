using Aplicacao.Shared;
using Aplicacao.VeiculoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace IntegrationTests.VeiculoModule
{
    [TestClass]
    public class AppService_Veiculo_Test
    {
        Mock<Veiculo> veiculoMock;
        Veiculo veiculo;
        Mock<IVeiculoRepository> mockrepoVeiculo;
        Mock<IRepository<Categoria>> mockrepoCategoria;
        VeiculoAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            veiculoMock = new();
            veiculoMock.Setup(x => x.Validar()).Returns("");

            veiculo = veiculoMock.Object;


            mockrepoVeiculo = new();
            mockrepoCategoria = new();
            sut = new VeiculoAppServices();
        }
        [TestMethod]
        public void Deve_inserir_veiculo()
        {
            sut.Inserir(veiculo).Resultado.Should().Be(EnumResultado.Sucesso);
            mockrepoVeiculo.Verify(x => x.Inserir(veiculo));
        }
        [TestMethod]
        public void Nao_deve_inserir_veiculo()
        {
            veiculoMock.Setup(x => x.Validar()).Returns("sexo");
            veiculo = veiculoMock.Object;

            sut.Inserir(veiculo).Resultado.Should().Be(EnumResultado.Falha);
            mockrepoVeiculo.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_veiculo()
        {
            sut.Excluir(veiculo.Id);
            mockrepoVeiculo.Verify(x => x.Excluir(veiculo.Id, null));
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
            sut.Editar(veiculo.Id, veiculo);
            mockrepoVeiculo.Verify(x => x.Editar(veiculo.Id, veiculo));
        }
    }
}

