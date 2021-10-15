using Autofac;
using DependencyInjector;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.CategoriaModule
{
    [TestClass]
    public class CategoriaORMTests
    {
        Categoria categoria;
        ILifetimeScope lsp;
        rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserir_categoria()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();
            categoria = new Categoria("nome", 1, 1, 1, 1, TipoCNH.A);
            new CategoriaORM(ctx).Inserir(categoria);


        }
        [TestMethod]
        public void Deve_inserir_categoria()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();
            categoria.Id.Should().NotBe(0);

        }
        [TestMethod]
        public void Deve_editar_nome_categoria()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            var nomeAnterior = categoria.Nome;
            categoria.Nome = "Nome editado";
            new CategoriaORM(ctx).Editar(categoria.Id, categoria);
            new CategoriaORM(ctx).GetById(categoria.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_diaria_categoria()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            var diariaAnterior = categoria.PrecoDiaria;
            categoria.PrecoDiaria = 3;
            new CategoriaORM(ctx).Editar(categoria.Id, categoria);
            new CategoriaORM(ctx).GetById(categoria.Id).PrecoDiaria.Should().NotBe(diariaAnterior);
        }
        [TestMethod]
        public void Deve_editar_precokm_categoria()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            var precoKmAnterior = categoria.PrecoKm;
            categoria.PrecoKm = 10;
            new CategoriaORM(ctx).Editar(categoria.Id, categoria);
            new CategoriaORM(ctx).GetById(categoria.Id).PrecoKm.Should().NotBe(precoKmAnterior);
        }
        [TestMethod]
        public void Deve_editar_franquia_categoria()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            var franquiaAnterior = categoria.QuilometragemFranquia;
            categoria.QuilometragemFranquia = 3;
            new CategoriaORM(ctx).Editar(categoria.Id, categoria);
            new CategoriaORM(ctx).GetById(categoria.Id).QuilometragemFranquia.Should().NotBe(franquiaAnterior);
        }

        [TestMethod]
        public void Deve_editar_precoLivre_categoria()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            var precoLivreAnterior = categoria.PrecoLivre;
            categoria.PrecoLivre = 5;
            new CategoriaORM(ctx).Editar(categoria.Id, categoria);
            new CategoriaORM(ctx).GetById(categoria.Id).PrecoLivre.Should().NotBe(precoLivreAnterior);
        }

        [TestMethod]
        public void Deve_retornar_todos_as_categorias()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            new CategoriaORM(ctx).Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBCategoria"));
            lsp.Dispose();
        }
    }
}
