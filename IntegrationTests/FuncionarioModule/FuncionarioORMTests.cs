using Dominio.PessoaModule;
using FluentAssertions;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.FuncionarioModule
{
    [TestClass]
    public class FuncionarioORMTests
    {
        FuncionarioORM ORM = new();
        Image imagem = Image.FromFile(@"..\..\..\Resources\user.png");
        Funcionario funcionario;

        [TestInitialize]
        public void Inserindo()
        {
            funcionario = new Funcionario("Nome", "49999155922", "Endereço", "13130847983", Cargo.Vendedor, imagem, "user_teste", "senha12345678");
            ORM.Inserir(funcionario);
        }
        [TestMethod]
        public void Deve_inserir_funcionario()
        {
            ORM.Registros.Count.Should().Be(1);
        }
        [TestMethod]
        public void Deve_editar_funcionario()
        {
            string nomeAntigo = funcionario.Nome;
            funcionario.Nome = "nomeEditado";
            ORM.Editar(funcionario.Id, funcionario);
            ORM.GetById(funcionario.Id).Nome.Should().NotBe(nomeAntigo);
        }
        [TestMethod]
        public void Deve_excluir_funcionario()
        {
            ORM.Excluir(funcionario.Id);
            ORM.Registros.Count.Should().Be(0);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBFuncionario"));
        }
    }
}