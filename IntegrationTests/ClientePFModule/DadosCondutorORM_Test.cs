using Autofac;
using DependencyInjector;
using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.Condutor;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.ClientePFModule
{
    [TestClass]
    public class DadosCondutorORM_Test
    {
        DadosCondutor dados;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;

        [TestInitialize]
        public void Inserir_Cnh()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();

            dados = new DadosCondutor(new CNH("1212120", TipoCNH.A));
            new DadosCondutorORM(ctx).Inserir(dados);
        }

        [TestMethod]
        public void Deve_editar_cnh_cliente()
        {
            var dadosAntigo = new DadosCondutor(new CNH("1212120", TipoCNH.A));
            var dadosNovo = new DadosCondutor(new CNH("1212120", TipoCNH.C));
            new DadosCondutorORM(ctx).Inserir(dadosAntigo);
            new DadosCondutorORM(ctx).Editar(dadosAntigo.Id, dadosNovo);

            new DadosCondutorORM(ctx).GetById(dadosAntigo.Id).Cnh.TipoCnh.Should().Be(dadosNovo.Cnh.TipoCnh);
        }

        [TestMethod]
        public void Deve_Inserir_cnh_cliente()
        {
            var cnhAnterior = new DadosCondutor(new CNH("1212120", TipoCNH.A));
            new DadosCondutorORM(ctx).Inserir(cnhAnterior);
        }

        [TestMethod]
        public void Deve_Excluir_cnh_cliente()
        {
            var dados = new DadosCondutor(new CNH("1212120", TipoCNH.A));
            new DadosCondutorORM(ctx).Excluir(dados.Id);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            ctx.DeleteAll<DadosCondutor>();
            ctx.SaveChanges();
            lsp.Dispose();
        }
    }
}
