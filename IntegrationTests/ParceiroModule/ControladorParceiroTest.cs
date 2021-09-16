using Dominio.ParceiroModule;
using FluentAssertions;
using Infra.DAO.ParceiroModule;
using Infra.DAO.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Shared;

namespace Tests.ParceiroModule
{
    [TestClass]
    public class ParceiroDAOTest
    {
        ParceiroDAO ParceiroDAO = new ParceiroDAO();
        Parceiro parceiro;

        public ParceiroDAOTest()
        {
            LimparTestes();
        }

        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBCupons"));
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
        public void Deve_Visualizar_todos_as_categorias()
        {
            ParceiroDAO.Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_excluir_Parceiro()
        {
            ParceiroDAO.Excluir(parceiro.Id);
            ParceiroDAO.Registros.Count.Should().Be(0);
        }
    }
}
