using Controladores.ServicoModule;
using Controladores.Shared;
using Dominio.ServicoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Shared;

namespace Tests.Tests.ServicoModule
{
    [TestClass]
    public class ControladorServicoTest
    {
        Servico servico = new Servico("nomeServico", 10);
        ControladorServico controlador = new ControladorServico();

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
