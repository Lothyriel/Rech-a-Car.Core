using Dominio.AluguelModule;
using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule.Condutor;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using UnitTests.Properties;

namespace Tests.Tests.AlguelModule
{
    [TestClass]
    public class DominioAluguelTest
    {
        Aluguel aluguel;
        AluguelFechado aluguelFechado;
        Veiculo veiculo;
        DadosCondutor dadosCondutor;
        Motorista motoristaEmpresa;
        ClientePF clientepf;
        ClientePJ clientepj;
        Image imagemVeiculo = Resources.ford_ka_gay;
        Image imagemFuncionario = Resources.rech;
        Categoria categoria;
        List<Servico> servicos;
        Funcionario funcionario;

        [TestInitialize]
        public void InicializaAluguel()
        {
            categoria = new Categoria("nome", 2, 2, 2, 2, TipoCNH.A);
            dadosCondutor = new DadosCondutor(new CNH("numero", TipoCNH.A));
            motoristaEmpresa = new Motorista("nome", "123123123", "endereço", "d12398127", dadosCondutor, clientepj);
            veiculo = new Veiculo("modelo", "marca", 1, "ASD1234", 1, 1, 1, "123456789123", 2, 50, imagemVeiculo, true, categoria, TipoCombustivel.Diesel);
            clientepj = new ClientePJ("nome", "4999915522", "endereço", "0131038190371", "email@teste.com");
            dadosCondutor = new DadosCondutor(new CNH("numero", TipoCNH.A));
            motoristaEmpresa = new Motorista("nome", "123123123", "endereço", "d12398127", dadosCondutor, clientepj);
            aluguel = new Aluguel(veiculo, null, Plano.Diário, DateTime.Today.AddDays(10), clientepj, funcionario, DateTime.Today.AddDays(15), motoristaEmpresa.DadosCondutor);
            servicos = new List<Servico>() { new Servico("1", 1, aluguel), new Servico("2", 2, aluguel) };
            dadosCondutor = new DadosCondutor(new CNH("numero", TipoCNH.A));
            clientepj = new ClientePJ("nome", "4999915522", "endereço", "0131038190371", "email@teste.com");
            motoristaEmpresa = new Motorista("nome", "123123123", "endereço", "d12398127", dadosCondutor, clientepj);
            funcionario = new Funcionario("nome", "49999155922", "endereco", "01308174983", Cargo.SysAdmin, imagemFuncionario, "usuario");
            aluguel.Servicos = servicos;
        }

        [TestMethod]
        public void Deve_retornar_aluguel_clientePF_valido()
        {
            clientepf = new ClientePF("nome", "49999155922", "endereço", "013108478983", dadosCondutor, new DateTime(2001, 09, 10), "email@teste.com");
            aluguel.DadosCondutor = clientepf.DadosCondutor;
                
            aluguel.Validar().Should().Be(string.Empty);

        }
        [TestMethod]
        public void Deve_retornar_aluguel_clientePJ_valido()
        {
            aluguel.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_aluguel_invalido()
        {
            aluguel.DadosCondutor = null;

            aluguel.Validar().Should().NotBe(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_aluguel_pf_fechado_valido()
        {
            servicos = new List<Servico>() { new Servico("1", 1, aluguelFechado), new Servico("2", 2, aluguelFechado) };

            aluguelFechado = aluguel.Fechar(200, 0.5, servicos);

            aluguelFechado.Validar().Should().Be(string.Empty);
        }
    }
}
