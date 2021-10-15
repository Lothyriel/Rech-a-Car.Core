using Dominio.ServicoModule;
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

namespace IntegrationTests.ServicoModule
{
    [TestClass]
    public class ServicoORMTests
    {
        Servico servico = new("nomeServico", 10, new AluguelDataBuilder().Padrao);
        ServicoORM ORM = new();

        [TestInitialize]
        public void Inserindo_no_banco()
        {
            ORM.Inserir(servico);

        }
        [TestMethod]
        public void Deve_inserir_um_servico()
        {
            ORM.Registros.Count.Should().NotBe(0);
        }

        [TestMethod]
        public void Deve_editar_nome_servico()
        {
            string nomeAnterior = servico.Nome;

            servico.Nome = "novoNome";

            ORM.Editar(servico.Id, servico);

            ORM.GetById(servico.Id).Nome.Should().NotBe(nomeAnterior);

        }

        [TestMethod]
        public void Deve_remover_servico()
        {
            ORM.Excluir(servico.Id);
            ORM.Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBServico"));
        }
    }
}