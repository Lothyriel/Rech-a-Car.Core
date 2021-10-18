using Autofac;
using DependencyInjector;
using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule.Condutor;
using FluentAssertions;
using Infra.DAO.ORM;
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
        ClientePJ cliente1;
        Motorista motorista1;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserir_clientePJ()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            cliente1 = new ClientePJ("nome", "99999999999", "endereco", "99999999999999", "email@teste.com");
            motorista1 = new Motorista("nomeMotorista", "99999999999", "endereco", "99999999999999", new DadosCondutor(new CNH("59778304921", TipoCNH.A)), cliente1);
            new ClientePJORM(ctx).Inserir(cliente1);
            new MotoristaORM(ctx).Inserir(motorista1);
            cliente1 = new ClientePJORM(ctx).GetById(cliente1.Id);
        }
        [TestMethod]
        public void Deve_inserir_cliente()
        {
            cliente1.Id.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_inserir_motorista()
        {
            cliente1.Motoristas.Count.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_remover_motorista()
        {
            new MotoristaORM(ctx).Excluir(cliente1.Motoristas[0].Id);
            cliente1 = new ClientePJORM(ctx).GetById(cliente1.Id);
            cliente1.Motoristas.Count.Should().Be(0);
        }
        [TestMethod]
        public void Deve_editar_motorista()
        {
            var motoristaEmpresa = cliente1.Motoristas[0];

            string nomeAntigo = motoristaEmpresa.Nome;
            motoristaEmpresa.Nome = "NOME EDITADO";

            new MotoristaORM(ctx).Editar(motoristaEmpresa.Id, motoristaEmpresa);
            cliente1 = new ClientePJORM(ctx).GetById(cliente1.Id);
            nomeAntigo.Should().NotBe(motoristaEmpresa.Nome);
        }
        [TestMethod]
        public void Deve_editar_nome_cliente()
        {
            string nomeAnterior = cliente1.Nome;

            cliente1.Nome = "Nome editado";

            new ClientePJORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePJORM(ctx).GetById(cliente1.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente1.Telefone;

            cliente1.Telefone = "000000000";

            new ClientePJORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePJORM(ctx).GetById(cliente1.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente1.Endereco;

            cliente1.Endereco = "Endereco editado";

            new ClientePJORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePJORM(ctx).GetById(cliente1.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente1.Documento;

            cliente1.Documento = "00000000000000";

            new ClientePJORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePJORM(ctx).GetById(cliente1.Id).Documento.Should().NotBe(documentoAnterior);
        }
        [TestMethod]
        public void Deve_retornar_todos_os_clientesPJ()
        {
            new ClientePJORM(ctx).Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePJ"));
            lsp.Dispose();
        }
    }
}
