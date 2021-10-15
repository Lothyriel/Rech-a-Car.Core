using AluguelPDF;
using Aplicacao.AluguelModule;
using Dominio.AluguelModule;
using Dominio.Entities.PessoaModule.ClienteModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.Shared;
using IntegrationTests.Properties;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Infra.ORM.AluguelModule
{
    [TestClass]
    public class PDFAluguelTests
    {
        Aluguel aluguel;
        static AluguelORM ao = new();
        static PDFAluguel pa = new();
        static RelatorioORM ro = new();
        static ServicoORM so = new();
        static CupomORM co = new();
        static CnhORM cn = new();
        static ClientePFORM cf = new();

        AluguelAppServices AluguelAppServices = new();

        [TestInitialize]
        public void InicializarDados()
        {
            var categoria = new Categoria("Joaninha", 100, 5, 300, 500, TipoCNH.B);
            var imagem = Resources.ford_ka_gay;
            var veiculo = new Veiculo("Ka", "Ford", 1997, "ABC1234", 50000, 4, 2, "LDSAPLDPLADAS", 0, 50, imagem, false, categoria, TipoCombustivel.Gasolina);
            var cnh = new CNH("01648986", TipoCNH.B);
            var cliente = new ClientePF("João Xavier", "49998300761", "Rua Jose Linhares", "01384972900", cnh, new DateTime(2001, 04, 27), "fastjonh@gmail.com");
            var funcionario = new Funcionario("Alexandre Rech", "99999999", "Rua da Ndd", "99999999", Cargo.SysAdmin, imagem, "admin", "admin123");

            var servicos = new List<Servico>() { new Servico("Servico 1", 100, aluguel), new Servico("Servico 2", 200, aluguel), new Servico("Servico 3", 300, aluguel) };

            cn.Inserir(cliente.Cnh);
            cf.Inserir(cliente);

            new CategoriaORM().Inserir(categoria);
            new VeiculoORM().Inserir(veiculo);

            new FuncionarioORM().Inserir(funcionario);

            aluguel = new Aluguel() { Veiculo = veiculo, Funcionario = funcionario, Condutor = cliente, Cliente = new Cliente(cliente), Servicos = servicos, DataAluguel = DateTime.Today.AddDays(3), DataDevolucao = DateTime.Today.AddDays(7) };
            ao.Inserir(aluguel);
        }
        [TestMethod]
        public void DeveCriarPdf()
        {
            ro.SalvarRelatorio(pa.GerarRelatorio(aluguel));
            ro.GetProxEnvio().Should().NotBeNull();
        }
        [TestMethod]
        public void DeveEnviarPdf()
        {
            ro.SalvarRelatorio(pa.GerarRelatorio(aluguel));
            AluguelAppServices.TentaEnviarRelatorioEmail();

            ro.GetProxEnvio().Should().BeNull();
        }
        [TestCleanup]
        public void LimparArquivo()
        {
            Db.Delete(TestExtensions.ResetId("TBEmail"));
        }
    }
}