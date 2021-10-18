using AluguelPDF;
using Aplicacao.AluguelModule;
using Dominio.AluguelModule;
using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule.Condutor;
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
        static DadosCondutorDAO cn = new();
        static ClientePFDAO cf = new();

        AluguelAppServices AluguelAppServices = new();

        [TestInitialize]
        public void InicializarDados()
        {
            var categoria = new Categoria("Joaninha", 100, 5, 300, 500, TipoCNH.B);
            var imagem = Resources.ford_ka_gay;
            var veiculo = new Veiculo("Ka", "Ford", 1997, "ABC1234", 50000, 4, 2, "LDSAPLDPLADAS", 0, 50, imagem, false, categoria, TipoCombustivel.Gasolina);
            var dadosCondutor = new DadosCondutor(new CNH("01648986", TipoCNH.B));
            var cliente = new ClientePF("João Xavier", "49998300761", "Rua Jose Linhares", "01384972900", dadosCondutor, new DateTime(2001, 04, 27), "fastjonh@gmail.com");
            var funcionario = new Funcionario("Alexandre Rech", "99999999", "Rua da Ndd", "99999999", Cargo.SysAdmin, imagem, "admin", "admin123");

            var servicos = new List<Servico>() { new Servico("Servico 1", 100, aluguel), new Servico("Servico 2", 200, aluguel), new Servico("Servico 3", 300, aluguel) };

            cn.Inserir(cliente.DadosCondutor);
            cf.Inserir(cliente);

            new CategoriaDAO().Inserir(categoria);
            new VeiculoDAO().Inserir(veiculo);

            new FuncionarioDAO().Inserir(funcionario);

            aluguel = new Aluguel() { Veiculo = veiculo, Funcionario = funcionario, DadosCondutor = cliente.DadosCondutor, Cliente = cliente, Servicos = servicos, DataAluguel = DateTime.Today.AddDays(3), DataDevolucao = DateTime.Today.AddDays(7) };
            ad.Inserir(aluguel);
        }
        [TestMethod]
        public void DeveCriarPdf()
        {
            rd.SalvarRelatorio(pa.GerarRelatorio(aluguel));
            rd.GetProxEnvio().Should().NotBeNull();
        }
        [TestMethod]
        public void DeveEnviarPdf()
        {
            rd.SalvarRelatorio(pa.GerarRelatorio(aluguel));
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