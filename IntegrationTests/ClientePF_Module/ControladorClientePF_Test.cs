using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Shared;

namespace Tests.Tests.ClientePF_Module
{
    [TestClass]
    public class ControladorClientePF_Test
    {
        ControladorClientePF controladorClientePF = new ControladorClientePF();
        ClientePF cliente;

        [TestInitialize]
        public void Inserir_clientePF()
        {
            CNH cnh = new CNH("36510896881", TipoCNH.A);
            cliente = new ClientePF("nome", "999999999", "endereco", "99999999999", cnh, new DateTime(2001, 04, 27), "email@teste.com");
            controladorClientePF.Inserir(cliente);
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

            controladorClientePF.Editar(cliente.Id, cliente);

            controladorClientePF.GetById(cliente.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente.Telefone;

            cliente.Telefone = "000000000";

            controladorClientePF.Editar(cliente.Id, cliente);

            controladorClientePF.GetById(cliente.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente.Endereco;

            cliente.Endereco = "Endereco editado";

            controladorClientePF.Editar(cliente.Id, cliente);

            controladorClientePF.GetById(cliente.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente.Documento;

            cliente.Documento = "00000000000";

            controladorClientePF.Editar(cliente.Id, cliente);

            controladorClientePF.GetById(cliente.Id).Documento.Should().NotBe(documentoAnterior);
        }

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            CNH cnhAnterior = cliente.Cnh;

            cliente.Cnh = new CNH("36510896881", TipoCNH.C) { Id = cnhAnterior.Id };

            controladorClientePF.Editar(cliente.Id, cliente);

            controladorClientePF.GetById(cliente.Id).Cnh.TipoCnh.Should().NotBe(cnhAnterior.TipoCnh);
        }

        [TestMethod]
        public void Deve_retornar_todos_os_clientesPF()
        {
            controladorClientePF.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePF"));
        }
    }
}
