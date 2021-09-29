using Aplicacao.AluguelModule;
using Aplicacao.ClienteModule;
using Aplicacao.FuncionarioModule;
using Aplicacao.Shared;
using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.ParceiroModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.AluguelModule
{   
    [TestClass]
    public class AluguelAppServiceTests
    {
        Mock<Aluguel> aluguelMock;
        Aluguel aluguel;

        Mock<IAluguelRepository> mockRepoAluguel;
        Mock<IRelatorioAluguel> mock_Relatorio;
        Mock<IRelatorioRepository> mock_Relatorio_Repo;
        Mock<IServicoRepository> mock_Servico_Repo;
        Mock<ICupomRepository> mock_Cupom_Repo;

        AluguelAppServices sut;

        [TestInitialize]
        public void InicializarClasse()
        {
            aluguelMock = new();
            aluguelMock.Setup(x => x.Validar()).Returns("");

            aluguel = aluguelMock.Object;

            mockRepoAluguel = new();
            mock_Cupom_Repo = new();
            mock_Relatorio = new();
            mock_Servico_Repo = new();
            mock_Relatorio_Repo = new();

            sut = new AluguelAppServices(mockRepoAluguel.Object, mock_Relatorio.Object, mock_Relatorio_Repo.Object, mock_Servico_Repo.Object, mock_Cupom_Repo.Object);
        }


        [TestMethod]
        public void Deve_inserir_Aluguel()
        {
            sut.Inserir(aluguel).Resultado.Should().Be(EnumResultado.Sucesso);
            mockRepoAluguel.Verify(x => x.Inserir(aluguel));
        }

        [TestMethod]
        public void Nao_Deve_inserir_Aluguel()
        {
            aluguelMock.Setup(x => x.Validar()).Returns("vasco");
            aluguel = aluguelMock.Object;

            sut.Inserir(aluguel).Resultado.Should().Be(EnumResultado.Falha);
            mockRepoAluguel.VerifyNoOtherCalls();
        }

        [TestMethod]
        public void Deve_remover_aluguel()
        {
            sut.Excluir(aluguel.Id);
            mockRepoAluguel.Verify(x => x.Excluir(aluguel.Id, null));
        }

        [TestMethod]
        public void Deve_editar_aluguel()
        {
            sut.Editar(aluguel.Id, aluguel);
            mockRepoAluguel.Verify(x => x.Editar(aluguel.Id, aluguel));
        }
    }
}
