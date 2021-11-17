using Dominio.ServicoModule;
using FluentAssertions;
using Infra.DAO.Shared;
using Infra.DAO.SQL.AluguelModule;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ServicoModule
{
    [TestClass]
    public class ServicoDAOTests
    {
        Servico servico = new("nomeServico", 10, null);
        ServicoDAO ServicoDAO = new();

        [TestInitialize]
        public void Inserindo_no_banco()
        {
            ServicoDAO.Inserir(servico);
        }
        [TestMethod]
        public void Deve_inserir_um_servico()
        {
            ServicoDAO.Registros.Count.Should().NotBe(0);
        }

        [TestMethod]
        public void Deve_editar_nome_servico()
        {
            string nomeAnterior = servico.Nome;

            servico.Nome = "novoNome";

            ServicoDAO.Editar(servico.Id, servico);

            ServicoDAO.GetById(servico.Id).Nome.Should().NotBe(nomeAnterior);

        }

        [TestMethod]
        public void Deve_remover_servico()
        {
            ServicoDAO.Excluir(servico.Id);
            ServicoDAO.Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBServico"));
        }
    }
}
