using Aplicacao.AluguelModule;
using Dominio.AluguelModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using EmailAluguelPDF;
using FluentAssertions;
using Infra.DAO.AluguelModule;
using Infra.DAO.PessoaModule;
using Infra.DAO.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using Tests.Shared;

namespace Tests.EmailAluguelPDFModule
{
    [TestClass]
    public class CriaPDFTests
    {
        Aluguel aluguel;

        [TestInitialize]
        public void InicializarDados()
        {
            var categoria = new Categoria("Joaninha", 100, 5, 300, 500, TipoCNH.B);
            var imagem = Image.FromFile(@"..\..\..\Resources\ford_ka_gay.jpg");
            var veiculo = new Veiculo("Ka", "Ford", 1997, "ABC1234", 50000, 4, 2, "LDSAPLDPLADAS", 0, 50, imagem, false, categoria, TipoCombustivel.Gasolina);
            var cnh = new CNH("01648986", TipoCNH.B);
            var cliente = new ClientePF("João Xavier", "49998300761", "Rua Jose Linhares", "01384972900", cnh, new DateTime(2001, 04, 27), "arkhandyr@gmail.com");
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
            var ms = new PDFAluguel().GerarRelatorio(aluguel);
            new RelatorioDAO().SalvarRelatorio(new RelatorioAluguel(aluguel, ms));

            new RelatorioDAO().GetProxEnvio().Should().NotBeNull();
        }

        [TestMethod]
        public void DeveEnviarPdf()
        {
            var ms = new PDFAluguel().GerarRelatorio(aluguel);
            new RelatorioDAO().SalvarRelatorio(new RelatorioAluguel(aluguel, ms));
            new AluguelAppServices(new AluguelDAO()).TentaEnviarRelatorioEmail();

            new RelatorioDAO().GetProxEnvio().Should().BeNull();
        }

        [TestCleanup()]
        public void LimparArquivo()
        {
            TestExtensions.ResetId("TBEmail");
        }
    }
}