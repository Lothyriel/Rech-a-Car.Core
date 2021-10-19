using AluguelPDF;
using Autofac;
using DependencyInjector;
using Aplicacao.AluguelModule;
using Dominio.AluguelModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Properties;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Dominio.PessoaModule.Condutor;
using Dominio.Entities.PessoaModule.Condutor;

namespace Infra.ORM.AluguelModule
{
    [TestClass]
    public class PDFAluguelORMTests
    {
        Aluguel aluguel;
        ILifetimeScope lsp;
        Rech_a_carDbContext ctx;
        RelatorioORM relatorioORM;
        readonly AluguelAppServices AluguelAppServices = new();

        [TestInitialize]
        public void InicializarDados()
        {
            lsp = DependencyInjection.Container.BeginLifetimeScope();
            ctx = lsp.Resolve<Rech_a_carDbContext>();
            relatorioORM = new RelatorioORM(ctx);
            var categoria = new Categoria("Joaninha", 100, 5, 300, 500, TipoCNH.B);
            var imagem = Resources.ford_ka_gay;
            var veiculo = new Veiculo("Ka", "Ford", 1997, "ABC1234", 50000, 4, 2, "LDSAPLDPLADAS", 0, 50, imagem, false, categoria, TipoCombustivel.Gasolina);
            var dadosCondutor = new DadosCondutor(new CNH("01648986", TipoCNH.B));
            var cliente = new ClientePF("João Xavier", "49998300761", "Rua Jose Linhares", "01384972900", dadosCondutor, new DateTime(2001, 04, 27), "fastjonh@gmail.com");
            var funcionario = new Funcionario("Alexandre Rech", "99999999", "Rua da Ndd", "99999999", Cargo.SysAdmin, imagem, "admin", "admin123");

            var servicos = new List<Servico>() { new Servico("Servico 1", 100, aluguel), new Servico("Servico 2", 200, aluguel), new Servico("Servico 3", 300, aluguel) };

            new DadosCondutorORM(ctx).Inserir(cliente.DadosCondutor);
            new ClientePFORM(ctx).Inserir(cliente);

            new CategoriaORM(ctx).Inserir(categoria);
            new VeiculoORM(ctx).Inserir(veiculo);

            new FuncionarioORM(ctx).Inserir(funcionario);

            aluguel = new Aluguel() { Veiculo = veiculo, Funcionario = funcionario, DadosCondutor = cliente.DadosCondutor, Cliente = cliente, Servicos = servicos, DataAluguel = DateTime.Today.AddDays(3), DataDevolucao = DateTime.Today.AddDays(7) };
            new AluguelORM(ctx).Inserir(aluguel);
        }
        [TestMethod]
        public void DeveCriarPdf()
        {
            relatorioORM.SalvarRelatorio(new PDFAluguel().GerarRelatorio(aluguel));
            relatorioORM.GetProxEnvio().Should().NotBeNull();
        }
        [TestMethod]
        public void DeveEnviarPdf()
        {
            relatorioORM.SalvarRelatorio(new PDFAluguel().GerarRelatorio(aluguel));
            AluguelAppServices.TentaEnviarRelatorioEmail();

            relatorioORM.GetProxEnvio().Should().BeNull();
        }
        [TestCleanup]
        public void LimparArquivo()
        {
            lsp.Dispose();
            using (var lsp = DependencyInjection.Container.BeginLifetimeScope())
            {
                ctx = lsp.Resolve<Rech_a_carDbContext>();
                ctx.DeleteAll<RelatorioAluguel>();
                ctx.DeleteAll<Funcionario>();
                ctx.DeleteAll<Aluguel>();
            }
        }
    }
}