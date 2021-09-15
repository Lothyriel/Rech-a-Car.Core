using Controladores.ParceiroModule;
using Controladores.Shared;
using Dominio.ParceiroModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Shared;

namespace Tests.ParceiroModule
{
    [TestClass]
    public class ControladorParceiroTest
    {
        ControladorParceiro controladorParceiro = new ControladorParceiro();
        Parceiro parceiro;

        public ControladorParceiroTest()
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
            controladorParceiro.Inserir(parceiro);
        }

        [TestMethod]
        public void Deve_inserir_Parceiro()
        {
            controladorParceiro.Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_editar_Parceiro()
        {
            var parceiroAnterior = parceiro.nome;

            parceiro.nome = "Nome editado";

            controladorParceiro.Editar(parceiro.Id, parceiro);

            controladorParceiro.GetById(parceiro.Id).nome.Should().NotBe(parceiroAnterior);
        }

        [TestMethod]
        public void Deve_Visualizar_todos_as_categorias()
        {
            controladorParceiro.Registros.Count.Should().Be(1);
        }

        [TestMethod]
        public void Deve_excluir_Parceiro()
        {
            controladorParceiro.Excluir(parceiro.Id);
            controladorParceiro.Registros.Count.Should().Be(0);
        }
    }
}
