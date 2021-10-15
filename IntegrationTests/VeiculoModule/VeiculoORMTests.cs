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

namespace IntegrationTests.VeiculoModule
{
    [TestClass]
    public class VeiculoORMTests
    {
        Veiculo veiculo1;
        ILifetimeScope lsp;
        rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserir_Veiculo()
        {
            

            var imagem = Properties.Resources.focus_gay;
            var categoria = new Categoria("Economico", 100, 10, 400, 800, TipoCNH.B);
            veiculo1 = new Veiculo("Ka", "Ford", 2001, "ABC1024", 50000, 4, 4, "ASDFGHJKLQWERTYUI", 0, 50, imagem, false, categoria, TipoCombustivel.Gasolina);
            new CategoriaORM(ctx).Inserir(categoria);
            new VeiculoORM(ctx).Inserir(veiculo1);
        }

        [TestMethod]
        public void Deve_inserir_veiculo()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            veiculo1.Id.Should().NotBe(0);
        }

        [TestMethod]
        public void Deve_editar_marca_veiculo()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            string marcaOriginal = veiculo1.Marca;
            veiculo1.Marca = "Marca diferente";
            new VeiculoORM(ctx).Editar(veiculo1.Id, veiculo1);
            new VeiculoORM(ctx).GetById(veiculo1.Id).Marca.Should().NotBe(marcaOriginal);
        }

        [TestMethod]
        public void Deve_editar_ano_veiculo()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            int anoOriginal = veiculo1.Ano;
            veiculo1.Ano = 2017;
            new VeiculoORM(ctx).Editar(veiculo1.Id, veiculo1);
            new VeiculoORM(ctx).GetById(veiculo1.Id).Ano.Should().NotBe(anoOriginal);
        }

        [TestMethod]
        public void Deve_remover_veiculo()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            new VeiculoORM(ctx).Excluir(veiculo1.Id);
            new VeiculoORM(ctx).Existe(veiculo1.Id).Should().BeFalse();
        }

        [TestMethod]
        public void Deve_retornar_todos_os_veiculos()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<rech_a_carDbContext>();

            new VeiculoORM(ctx).Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBVeiculo"));
            lsp.Dispose();
        }
    }
}
