using AluguelPDF;
using Aplicacao.AluguelModule;
using Dominio.AluguelModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Infra.DAO.CupomModule;
using Infra.DAO.PessoaModule;
using Infra.DAO.Shared;
using Infra.DAO.SQL.AluguelModule;
using Infra.DAO.VeiculoModule;
using IntegrationTests.Properties;
using IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Infra.DAO.AluguelModule
{
    [TestClass]
    public class PDFAluguelTests
    {
        Aluguel aluguel;
        static AluguelDAO ad = new();
        static PDFAluguel pa = new();
        static RelatorioDAO rd = new();
        static ServicoDAO sd = new();
        static CupomDAO cd = new();
        AluguelAppServices AluguelAppServices = new(ad, pa, rd, sd, cd);

        [TestInitialize]
        public void InicializarDados()
        {
            var categoria = new Categoria("Joaninha", 100, 5, 300, 500, TipoCNH.B);
            var imagem = Resources.ford_ka_gay;
            var veiculo = new Veiculo("Ka", "Ford", 1997, "ABC1234", 50000, 4, 2, "LDSAPLDPLADAS", 0, 50, imagem, false, categoria, TipoCombustivel.Gasolina);
            var cnh = new CNH("01648986", TipoCNH.B);
            var cliente = new ClientePF("João Xavier", "49998300761", "Rua Jose Linhares", "01384972900", cnh, new DateTime(2001, 04, 27), "fastjonh@gmail.com");
            var funcionario = new Funcionario("Alexandre Rech", "99999999", "Rua da Ndd", "99999999", Cargo.SysAdmin, imagem, "admin", "admin123");

            var servicos = new List<Servico>() { new Servico("Servico 1", 100), new Servico("Servico 2", 200), new Servico("Servico 3", 300) };
            aluguel = new Aluguel() { Veiculo = veiculo, Funcionario = funcionario, Condutor = cliente, Cliente = cliente, Servicos = servicos, DataAluguel = DateTime.Today.AddDays(3), DataDevolucao = DateTime.Today.AddDays(7) };

            new CategoriaDAO().Inserir(aluguel.Veiculo.Categoria);
            new VeiculoDAO().Inserir(aluguel.Veiculo);

            new ClientePFDAO().Inserir((ClientePF)aluguel.Cliente);
            new FuncionarioDAO().Inserir(aluguel.Funcionario);

            new AluguelDAO().Inserir(aluguel);
        }
        [TestMethod]
        public void DeveCriarPdf()
        {
            var ms = pa.GerarRelatorio(aluguel);
            rd.SalvarRelatorio(new RelatorioAluguel(aluguel, ms));
            rd.GetProxEnvio().Should().NotBeNull();
        }
        [TestMethod]
        public void DeveEnviarPdf()
        {
            var ms = new PDFAluguel().GerarRelatorio(aluguel);
            rd.SalvarRelatorio(new RelatorioAluguel(aluguel, ms));
            AluguelAppServices.TentaEnviarRelatorioEmail();

            rd.GetProxEnvio().Should().BeNull();
        }
        [TestCleanup]
        public void LimparArquivo()
        {
            Db.Delete(TestExtensions.ResetId("TBEmail"));
        }
    }
}