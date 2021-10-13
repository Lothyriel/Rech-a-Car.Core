using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.PessoaModule;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.ClientePJModule
{
    [TestClass]
    public class ClientePJORM_Test
    {
        ClientePJORM ClientePJORM = new();
        MotoristaORM MotoristaORM = new();
        ClientePJ cliente;
        Motorista motorista;

        [TestInitialize]
        public void Inserir_clientePJ()
        {
            cliente = new ClientePJ("nome", "99999999999", "endereco", "99999999999999", "email@teste.com");
            ClientePJORM.Inserir(cliente);
            motorista = new Motorista("nomeMotorista", "99999999999", "endereco", "99999999999999", new CNH("59778304921", TipoCNH.A), cliente);
            MotoristaORM.Inserir(motorista);
            cliente = ClientePJORM.GetById(cliente.Id);
        }
        [TestMethod]
        public void Deve_inserir_cliente()
        {
            cliente.Id.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_inserir_motorista()
        {
            cliente.Motoristas.Count.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_remover_motorista()
        {
            MotoristaORM.Excluir(cliente.Motoristas[0].Id);
            cliente = ClientePJORM.GetById(cliente.Id);
            cliente.Motoristas.Count.Should().Be(0);
        }
        [TestMethod]
        public void Deve_editar_motorista()
        {
            var motoristaEmpresa = cliente.Motoristas[0];

            string nomeAntigo = motoristaEmpresa.Nome;
            motoristaEmpresa.Nome = "NOME EDITADO";

            MotoristaORM.Editar(motoristaEmpresa.Id, motoristaEmpresa);
            cliente = ClientePJORM.GetById(cliente.Id);
            nomeAntigo.Should().NotBe(motoristaEmpresa.Nome);
        }
        [TestMethod]
        public void Deve_editar_nome_cliente()
        {
            string nomeAnterior = cliente.Nome;

            cliente.Nome = "Nome editado";

            ClientePJORM.Editar(cliente.Id, cliente);

            ClientePJORM.GetById(cliente.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente.Telefone;

            cliente.Telefone = "000000000";

            ClientePJORM.Editar(cliente.Id, cliente);

            ClientePJORM.GetById(cliente.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente.Endereco;

            cliente.Endereco = "Endereco editado";

            ClientePJORM.Editar(cliente.Id, cliente);

            ClientePJORM.GetById(cliente.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente.Documento;

            cliente.Documento = "00000000000000";

            ClientePJORM.Editar(cliente.Id, cliente);

            ClientePJORM.GetById(cliente.Id).Documento.Should().NotBe(documentoAnterior);
        }
        [TestMethod]
        public void Deve_retornar_todos_os_clientesPJ()
        {
            ClientePJORM.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePJ"));
        }
    }
}
