using Dominio.ParceiroModule;
using FluentAssertions;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.CupomModule
{
    [TestClass]
    public class ParceiroORMTest
    {
        ParceiroORM ParceiroORM = new();
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
            ParceiroORM.Inserir(parceiro);
        }

        [TestMethod]
        public void Deve_inserir_Parceiro()
        {
            ParceiroORM.Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_editar_Parceiro()
        {
            var parceiroAnterior = parceiro.nome;

            parceiro.nome = "Nome editado";

            ParceiroORM.Editar(parceiro.Id, parceiro);

            ParceiroORM.GetById(parceiro.Id).nome.Should().NotBe(parceiroAnterior);
        }

        [TestMethod]
        public void Deve_excluir_Parceiro()
        {
            ParceiroORM.Excluir(parceiro.Id);
            ParceiroORM.Registros.Count.Should().Be(0);
        }
    }
}
