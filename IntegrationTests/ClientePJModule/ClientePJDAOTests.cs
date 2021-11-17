using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule.Condutor;
using FluentAssertions;
using Infra.DAO.PessoaModule;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ClientePJ_Module
{
    [TestClass]
    public class ClientePJDAOTests
    {
        ClientePJDAO ClientePJDAO = new();
        MotoristaDAO MotoristaDAO = new();
        ClientePJ cliente;
        Motorista motorista;


        [TestInitialize]
        public void Inserir_clientePJ()
        {
            cliente = new ClientePJ("nome", "99999999999", "endereco", "99999999999999", "email@teste.com");
            ClientePJDAO.Inserir(cliente);
            motorista = new Motorista("nomeMotorista", "99999999999", "endereco", "99999999999999", new DadosCondutor(new CNH("59778304921", TipoCNH.A)), cliente);
            MotoristaDAO.Inserir(motorista);
            cliente = ClientePJDAO.GetById(cliente.Id);
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
            MotoristaDAO.Excluir(cliente.Motoristas[0].Id);
            cliente = ClientePJDAO.GetById(cliente.Id);
            cliente.Motoristas.Count.Should().Be(0);
        }
        [TestMethod]
        public void Deve_editar_motorista()
        {
            var motoristaEmpresa = cliente.Motoristas[0];

            string nomeAntigo = motoristaEmpresa.Nome;
            motoristaEmpresa.Nome = "NOME EDITADO";

            MotoristaDAO.Editar(motoristaEmpresa.Id, motoristaEmpresa);
            cliente = ClientePJDAO.GetById(cliente.Id);
            nomeAntigo.Should().NotBe(motoristaEmpresa.Nome);
        }
        [TestMethod]
        public void Deve_editar_nome_cliente()
        {
            string nomeAnterior = cliente.Nome;

            cliente.Nome = "Nome editado";

            ClientePJDAO.Editar(cliente.Id, cliente);

            ClientePJDAO.GetById(cliente.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente.Telefone;

            cliente.Telefone = "000000000";

            ClientePJDAO.Editar(cliente.Id, cliente);

            ClientePJDAO.GetById(cliente.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente.Endereco;

            cliente.Endereco = "Endereco editado";

            ClientePJDAO.Editar(cliente.Id, cliente);

            ClientePJDAO.GetById(cliente.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente.Documento;

            cliente.Documento = "00000000000000";

            ClientePJDAO.Editar(cliente.Id, cliente);

            ClientePJDAO.GetById(cliente.Id).Documento.Should().NotBe(documentoAnterior);
        }
        [TestMethod]
        public void Deve_retornar_todos_os_clientesPJ()
        {
            ClientePJDAO.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePJ"));
        }
    }
}
