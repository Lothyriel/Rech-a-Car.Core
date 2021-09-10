using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Shared;

namespace Tests.Tests.ClientePJ_Module
{
    [TestClass]
    public class ControladorClientePJ_Test
    {
        ControladorClientePJ controladorClientePJ = new ControladorClientePJ();
        ControladorMotorista controladorMotorista = new ControladorMotorista();
        ClientePJ cliente;
        MotoristaEmpresa motorista;


        [TestInitialize]
        public void Inserir_clientePJ()
        {
            cliente = new ClientePJ("nome", "99999999999", "endereco", "99999999999999", "email@teste.com");
            controladorClientePJ.Inserir(cliente);
            motorista = new MotoristaEmpresa("nomeMotorista", "99999999999", "endereco", "99999999999999", new CNH("59778304921", TipoCNH.A), cliente);
            controladorMotorista.Inserir(motorista);
            cliente = controladorClientePJ.GetById(cliente.Id);
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
            controladorMotorista.Excluir(cliente.Motoristas[0].Id);
            cliente = controladorClientePJ.GetById(cliente.Id);
            cliente.Motoristas.Count.Should().Be(0);
        }
        [TestMethod]
        public void Deve_editar_motorista()
        {
            var motoristaEmpresa = cliente.Motoristas[0];

            string nomeAntigo = motoristaEmpresa.Nome;
            motoristaEmpresa.Nome = "NOME EDITADO";

            controladorMotorista.Editar(motoristaEmpresa.Id, motoristaEmpresa);
            cliente = controladorClientePJ.GetById(cliente.Id);
            nomeAntigo.Should().NotBe(motoristaEmpresa.Nome);
        }
        [TestMethod]
        public void Deve_editar_nome_cliente()
        {
            string nomeAnterior = cliente.Nome;

            cliente.Nome = "Nome editado";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente.Telefone;

            cliente.Telefone = "000000000";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente.Endereco;

            cliente.Endereco = "Endereco editado";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente.Documento;

            cliente.Documento = "00000000000000";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Documento.Should().NotBe(documentoAnterior);
        }
        [TestMethod]
        public void Deve_retornar_todos_os_clientesPJ()
        {
            controladorClientePJ.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePJ"));
            Db.Delete(TestExtensions.ResetId("TBMotorista"));
        }
    }
}
