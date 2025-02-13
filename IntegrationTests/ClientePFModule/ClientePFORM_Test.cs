﻿using Autofac;
using DependencyInjector;
using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule.Condutor;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class ClientePFORM_Test
    {
        ClientePF cliente1;
        DadosCondutor dadosCondutor;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;
        
        [TestInitialize]
        public void Inserir_clientePF()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            dadosCondutor = new DadosCondutor(new CNH("1212120", TipoCNH.A));
            cliente1 = new ClientePF("nome", "999999999", "endereco", "99999999999", dadosCondutor, new DateTime(2001, 04, 27), "email@teste.com");
            new DadosCondutorORM(ctx).Inserir(dadosCondutor);
            new ClientePFORM(ctx).Inserir(cliente1);

        }
        [TestMethod]
        public void Deve_inserir_cliente()
        {
            cliente1.Id.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_editar_nome_cliente()
        {
            string nomeAnterior = cliente1.Nome;

            cliente1.Nome = "Nome editado";

            new ClientePFORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePFORM(ctx).GetById(cliente1.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente1.Telefone;

            cliente1.Telefone = "000000000";

            new ClientePFORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePFORM(ctx).GetById(cliente1.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente1.Endereco;

            cliente1.Endereco = "Endereco editado";

            new ClientePFORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePFORM(ctx).GetById(cliente1.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente1.Documento;

            cliente1.Documento = "00000000000";

            new ClientePFORM(ctx).Editar(cliente1.Id, cliente1);

            new ClientePFORM(ctx).GetById(cliente1.Id).Documento.Should().NotBe(documentoAnterior);
        }
        [TestMethod]
        public void Deve_retornar_todos_os_clientesPF()
        {
            new ClientePFORM(ctx).Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            ctx.DeleteAll<ClientePF>();
            ctx.SaveChanges();
            lsp.Dispose();
        }
    }
}
