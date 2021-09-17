using Dominio.ServicoModule;
using FluentAssertions;
using Infra.DAO.Shared;
using Infra.DAO.SQL.AluguelModule;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.IntegrationTests.ServicoModule
{
    [TestClass]
    public class ServicoDAOTests
    {
        Servico servico = new("nomeServico", 10);
        ServicoDAO controlador = new();

        [TestInitialize]
        public void Inserindo_no_banco()
        {
            controlador.Inserir(servico);

        }
        [TestMethod]
        public void Deve_inserir_um_servico()
        {
            controlador.Registros.Count.Should().NotBe(0);

        }

        [TestMethod]
        public void Deve_editar_nome_servico()
        {
            string nomeAnterior = servico.Nome;

            servico.Nome = "novoNome";

            controlador.Editar(servico.Id, servico);

            controlador.GetById(servico.Id).Nome.Should().NotBe(nomeAnterior);

        }

        [TestMethod]
        public void Deve_remover_servico()
        {
            controlador.Excluir(servico.Id);
            controlador.Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBServico"));
        }
    }
}
