using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Infra.DAO.PessoaModule;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IntegrationTests.ClientePF_Module
{
    [TestClass]
    public class ClientePFDAO_Tests
    {
        ClientePFDAO ClientePFDAO = new();
        CnhDAO CnhDAO = new();
        ClientePF cliente;
        CNH cnh;


        [TestInitialize]
        public void Inserir_clientePF()
        {
            cnh = new CNH("1212120", TipoCNH.A);
            CnhDAO.Inserir(cnh);
            cliente = new ClientePF("nome", "999999999", "endereco", "99999999999", cnh, new DateTime(2001, 04, 27), "email@teste.com");
            ClientePFDAO.Inserir(cliente);
            
        }
        [TestMethod]
        public void Deve_inserir_cliente()
        {
            cliente.Id.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_editar_nome_cliente()
        {
            string nomeAnterior = cliente.Nome;

            cliente.Nome = "Nome editado";

            ClientePFDAO.Editar(cliente.Id, cliente);

            ClientePFDAO.GetById(cliente.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente.Telefone;

            cliente.Telefone = "000000000";

            ClientePFDAO.Editar(cliente.Id, cliente);

            ClientePFDAO.GetById(cliente.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente.Endereco;

            cliente.Endereco = "Endereco editado";

            ClientePFDAO.Editar(cliente.Id, cliente);

            ClientePFDAO.GetById(cliente.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente.Documento;

            cliente.Documento = "00000000000";

            ClientePFDAO.Editar(cliente.Id, cliente);

            ClientePFDAO.GetById(cliente.Id).Documento.Should().NotBe(documentoAnterior);
        }

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            CNH cnhAnterior = cliente.Cnh;

            cliente.Cnh = new CNH("36510896881", TipoCNH.C) { Id = cnhAnterior.Id };

            ClientePFDAO.Editar(cliente.Id, cliente);

            ClientePFDAO.GetById(cliente.Id).Cnh.TipoCnh.Should().NotBe(cnhAnterior.TipoCnh);
        }

        [TestMethod]
        public void Deve_retornar_todos_os_clientesPF()
        {
            ClientePFDAO.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePF"));
        }
    }
}
