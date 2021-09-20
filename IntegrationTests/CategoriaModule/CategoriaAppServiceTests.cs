using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Aplicacao.Shared;
using Dominio.PessoaModule.ClienteModule;
using Aplicacao.ClienteModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using Aplicacao.VeiculoModule;

namespace IntegrationTests.CategoriaModule
{
    [TestClass]
    public class CategoriaAppServiceTests
    {
        Mock<Categoria> categoriaMock;
        Categoria categoria;
        Mock<IRepository<Categoria>> mockCategoria_Repo;
        CategoriaAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            categoriaMock = new();
            categoriaMock.Setup(x => x.Validar()).Returns("");

            categoria = categoriaMock.Object;

            mockCategoria_Repo = new();
            sut = new CategoriaAppServices(mockCategoria_Repo.Object);
        }
        [TestMethod]
        public void Deve_inserir_cupom()
        {
            sut.Inserir(categoria).Resultado.Should().Be(EnumResultado.Sucesso);
            mockCategoria_Repo.Verify(x => x.Inserir(categoria));
        }
        [TestMethod]
        public void Nao_deve_inserir_cupom()
        {
            categoriaMock.Setup(x => x.Validar()).Returns("INVÁLIDO");
            categoria = categoriaMock.Object;

            sut.Inserir(categoria).Resultado.Should().Be(EnumResultado.Falha);
            mockCategoria_Repo.VerifyNoOtherCalls();
        }
        [TestMethod]
        public void Deve_remover_cupom()
        {
            sut.Excluir(categoria.Id);
            mockCategoria_Repo.Verify(x => x.Excluir(categoria.Id, null));
        }
        [TestMethod]
        public void Deve_editar_cupom()
        {
            sut.Editar(categoria.Id, categoria);
            mockCategoria_Repo.Verify(x => x.Editar(categoria.Id, categoria));
        }


    }
}
