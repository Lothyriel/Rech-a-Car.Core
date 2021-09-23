using Dominio.ParceiroModule;
using FluentAssertions;
using Infra.DAO.ParceiroModule;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ParceiroModule
{
    [TestClass]
    public class ParceiroDAOTests
    {
        ParceiroDAO ParceiroDAO = new();
        Parceiro parceiro;

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBParceiro"));
        }

        [TestInitialize]
        public void Inserindo()
        {
            parceiro = new Parceiro("Desconto do Deko");
            ParceiroDAO.Inserir(parceiro);
        }

        [TestMethod]
        public void Deve_inserir_Parceiro()
        {
            ParceiroDAO.Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_editar_Parceiro()
        {
            var parceiroAnterior = parceiro.nome;

            parceiro.nome = "Nome editado";

            ParceiroDAO.Editar(parceiro.Id, parceiro);

            ParceiroDAO.GetById(parceiro.Id).nome.Should().NotBe(parceiroAnterior);
        }

        [TestMethod]
        public void Deve_excluir_Parceiro()
        {
            ParceiroDAO.Excluir(parceiro.Id);
            ParceiroDAO.Registros.Count.Should().Be(0);
        }
    }
}
