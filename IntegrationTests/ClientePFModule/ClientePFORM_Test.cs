using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
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

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class ClientePFORM_Test
    {
        ClientePFORM ClientePFORM = new();
        CnhORM CnhORM = new();
        ClientePF cliente;
        CNH cnh;


        [TestInitialize]
        public void Inserir_clientePF()
        {
            cnh = new CNH("1212120", TipoCNH.A);
            CnhORM.Inserir(cnh);
            cliente = new ClientePF("nome", "999999999", "endereco", "99999999999", cnh, new DateTime(2001, 04, 27), "email@teste.com");
            ClientePFORM.Inserir(cliente);

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

            ClientePFORM.Editar(cliente.Id, cliente);

            ClientePFORM.GetById(cliente.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente.Telefone;

            cliente.Telefone = "000000000";

            ClientePFORM.Editar(cliente.Id, cliente);

            ClientePFORM.GetById(cliente.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente.Endereco;

            cliente.Endereco = "Endereco editado";

            ClientePFORM.Editar(cliente.Id, cliente);

            ClientePFORM.GetById(cliente.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente.Documento;

            cliente.Documento = "00000000000";

            ClientePFORM.Editar(cliente.Id, cliente);

            ClientePFORM.GetById(cliente.Id).Documento.Should().NotBe(documentoAnterior);
        }
        [TestMethod]
        public void Deve_retornar_todos_os_clientesPF()
        {
            ClientePFORM.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePF"));
        }
    }
}
