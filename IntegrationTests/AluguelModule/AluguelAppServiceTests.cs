using Aplicacao.AluguelModule;
using Aplicacao.ClienteModule;
using Aplicacao.FuncionarioModule;
using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.ParceiroModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.AluguelModule
{   
    [TestClass]
    public class AluguelAppServiceTests
    {
        Mock<Aluguel> aluguelMock;
        Aluguel aluguel;

        Mock<IAluguelRepository> mockRepoAluguel;
        Mock<IRepository<Funcionario>> mock_Funcionario_Repo;
        Mock<IRepository<Servico>> mock_Servico_Repo;
        Mock<IRepository<Parceiro>> mock_Parceiro_Repo;
        Mock<IRepository<Cupom>> mock_Cupom_Repo;
        //Mock<IRepository<RelatorioAluguel>> mock_Relatorio_Repo;

        AluguelAppServices alu;

        [TestInitialize]
        public void InicializarClasse()
        {
            aluguelMock = new();
            aluguelMock.Setup(x => x.Validar()).Returns("");

            aluguel = aluguelMock.Object;

            mockRepoAluguel = new();
            mock_Funcionario_Repo = new();
            mock_Servico_Repo = new();
            mock_Cupom_Repo = new();
           


            //alu = new AluguelAppServices(mockRepoAluguel.Object, mock_Funcionario_Repo.Object, mock_Servico_Repo.Object,mock_Cupom_Repo.Object, mock_Relatorio_Repo.Object);
        }
    }
}
