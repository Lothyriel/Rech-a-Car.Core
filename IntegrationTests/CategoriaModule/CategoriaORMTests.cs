using Autofac;
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
        CategoriaORM CategoriaORM;
        Categoria categoria;

        [TestInitialize]
        public void Inserir_categoria()
        {
            using (var lsp = DependencyInjector.DependencyInjection.Container.BeginLifetimeScope())
            {
                var ctx = lsp.Resolve <rech_a_carDbContext>();
                categoria = new Categoria("nome", 1, 1, 1, 1, TipoCNH.A);
                new CategoriaORM(ctx).Inserir(categoria);
            }

        }
        [TestMethod]
        public void Deve_inserir_categoria()
        {
            categoria.Id.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_editar_nome_categoria()
        {
            var nomeAnterior = categoria.Nome;

            categoria.Nome = "Nome editado";

            CategoriaORM.Editar(categoria.Id, categoria);

            CategoriaORM.GetById(categoria.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_diaria_categoria()
        {
            var diariaAnterior = categoria.PrecoDiaria;

            categoria.PrecoDiaria = 3;

            CategoriaORM.Editar(categoria.Id, categoria);

            CategoriaORM.GetById(categoria.Id).PrecoDiaria.Should().NotBe(diariaAnterior);
        }
        [TestMethod]
        public void Deve_editar_precokm_categoria()
        {
            var precoKmAnterior = categoria.PrecoKm;

            categoria.PrecoKm = 10;

            CategoriaORM.Editar(categoria.Id, categoria);

            CategoriaORM.GetById(categoria.Id).PrecoKm.Should().NotBe(precoKmAnterior);
        }
        [TestMethod]
        public void Deve_editar_franquia_categoria()
        {
            var franquiaAnterior = categoria.QuilometragemFranquia;

            categoria.QuilometragemFranquia = 3;

            CategoriaORM.Editar(categoria.Id, categoria);

            CategoriaORM.GetById(categoria.Id).QuilometragemFranquia.Should().NotBe(franquiaAnterior);
        }

        [TestMethod]
        public void Deve_editar_precoLivre_categoria()
        {
            var precoLivreAnterior = categoria.PrecoLivre;

            categoria.PrecoLivre = 5;

            CategoriaORM.Editar(categoria.Id, categoria);

            CategoriaORM.GetById(categoria.Id).PrecoLivre.Should().NotBe(precoLivreAnterior);
        }

        [TestMethod]
        public void Deve_retornar_todos_as_categorias()
        {
            CategoriaORM.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBCategoria"));
        }
    }
}
