using AluguelPDF;
using Aplicacao.AluguelModule;
using Aplicacao.ClienteModule;
using Aplicacao.CupomModule;
using Aplicacao.FuncionarioModule;
using Aplicacao.ServicosModule;
using Aplicacao.VeiculoModule;
using Dominio.AluguelModule;
using Infra.DAO.AluguelModule;
using Infra.DAO.CupomModule;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.ParceiroModule;
using Infra.DAO.PessoaModule;
using Infra.DAO.SQL.AluguelModule;
using Infra.DAO.SQL.PessoaModule;
using Infra.DAO.VeiculoModule;
using Infra.NLogger;
using System;

namespace WindowsApp
{
    public class ConfigServices
    {
        public static ConfigServices Services;

        private IRelatorioAluguel RelatorioAluguel;
        public ConfigServices(ConfigRepositories configRepos, ConfigRelatorio configRelatorio)
        {
            Services = this;

            NLogger.Logger.Aqui().Debug($"Configurando Relatório Aluguel configurado como {configRelatorio}");

            RelatorioAluguel = GetRelatorio(configRelatorio);

            NLogger.Logger.Aqui().Debug($"Relatório Aluguel configurado como {configRelatorio}");

            ConfigurarServicos(configRepos);
        }

        private void ConfigurarServicos(ConfigRepositories configRepos)
        {
            NLogger.Logger.Aqui().Debug($"Configurando Repositórios configurados como {configRepos}");

            switch (configRepos)
            {
                case ConfigRepositories.SQL: GerarRepositoriosSQL(); break;
                case ConfigRepositories.ORM: GerarRepositoriosORM(); break;
                default: throw new NotSupportedException();
            }

            NLogger.Logger.Aqui().Debug($"Repositórios configurados como {configRepos}");
        }

        private IRelatorioAluguel GetRelatorio(ConfigRelatorio configRelatorio)
        {
            return configRelatorio switch
            {
                ConfigRelatorio.PDF => new PDFAluguel(),
                ConfigRelatorio.TXT => throw new NotImplementedException(),
                ConfigRelatorio.CSV => throw new NotImplementedException(),
                _ => throw new NotSupportedException(),
            };
        }

        public CategoriaAppServices CategoriaServices { get; private set; }
        public VeiculoAppServices VeiculoServices { get; private set; }
        public AluguelAppServices AluguelServices { get; private set; }
        public FuncionarioAppServices FuncionarioServices { get; private set; }
        public MotoristaAppServices MotoristaServices { get; private set; }
        public ClientePJAppServices ClientePJServices { get; private set; }
        public ServicosAppServices ServicosServices { get; private set; }
        public ClientePFAppServices ClientePFServices { get; private set; }
        public AluguelFechadoAppServices AluguelFechadoServices { get; private set; }
        public ParceiroAppServices ParceiroServices { get; private set; }
        public CupomAppServices CupomServices { get; private set; }
        public ClienteAppServices ClienteServices { get; private set; }

        private void GerarRepositoriosSQL()
        {
            var categoriaRepo = new CategoriaDAO();
            var veiculoRepo = new VeiculoDAO();

            var funcionarioRepo = new FuncionarioDAO();
            var parceiro = new ParceiroDAO();
            var motoristaRepo = new MotoristaDAO();

            var cliente = new ClienteJoinDAO();
            var pjRepo = new ClientePJDAO();
            var pfRepo = new ClientePFDAO();

            var aluguelFechadoRepo = new AluguelFechadoDAO();

            var aluguelRepo = new AluguelDAO();
            var servicoRepo = new ServicoDAO();
            var cupomRepo = new CupomDAO();
            var relatorioRepo = new RelatorioDAO();
            var cnhRepo = new CnhDAO();
            var senhaRepo = new SenhaDAO();

            Services.CupomServices = new CupomAppServices(cupomRepo);
            Services.ParceiroServices = new ParceiroAppServices(parceiro);
            Services.ServicosServices = new ServicosAppServices(servicoRepo);
            Services.ClienteServices = new ClienteAppServices(cliente);
            Services.ClientePJServices = new ClientePJAppServices(pjRepo);
            Services.ClientePFServices = new ClientePFAppServices(pfRepo, cnhRepo);
            Services.MotoristaServices = new MotoristaAppServices(motoristaRepo);
            Services.CategoriaServices = new CategoriaAppServices(categoriaRepo);
            Services.FuncionarioServices = new FuncionarioAppServices(funcionarioRepo, senhaRepo);
            Services.VeiculoServices = new VeiculoAppServices(veiculoRepo, categoriaRepo);
            Services.AluguelFechadoServices = new AluguelFechadoAppServices(aluguelFechadoRepo, servicoRepo, veiculoRepo);
            Services.AluguelServices = new AluguelAppServices(aluguelRepo, RelatorioAluguel, relatorioRepo, servicoRepo, cupomRepo);
        }
        private void GerarRepositoriosORM()
        {
            var categoriaRepo = new CategoriaORM();
            var veiculoRepo = new VeiculoORM();

            var funcionarioRepo = new FuncionarioORM();
            var parceiro = new ParceiroORM();
            var motoristaRepo = new MotoristaORM();

            var cliente = new ClienteJoinORM();
            var pjRepo = new ClientePJORM();
            var pfRepo = new ClientePFORM();


            var aluguelFechadoRepo = new AluguelFechadoORM();
            var aluguelRepo = new AluguelORM();
            var servicoRepo = new ServicosORM();
            var cupomRepo = new CupomORM();
            var relatorioRepo = new RelatorioORM();
            var cnhRepo = new CnhORM();
            var senhaRepo = new SenhaORM();

            Services.CupomServices = new CupomAppServices(cupomRepo);
            Services.ParceiroServices = new ParceiroAppServices(null);
            Services.ServicosServices = new ServicosAppServices(servicoRepo);
            Services.ClienteServices = new ClienteAppServices(cliente);
            Services.ClientePJServices = new ClientePJAppServices(pjRepo);
            Services.ClientePFServices = new ClientePFAppServices(pfRepo, cnhRepo);
            Services.MotoristaServices = new MotoristaAppServices(null);
            Services.CategoriaServices = new CategoriaAppServices(null);
            Services.FuncionarioServices = new FuncionarioAppServices(funcionarioRepo, senhaRepo);
            Services.VeiculoServices = new VeiculoAppServices(veiculoRepo, null);
            Services.AluguelFechadoServices = new AluguelFechadoAppServices(null, servicoRepo, veiculoRepo);
            Services.AluguelServices = new AluguelAppServices(aluguelRepo, RelatorioAluguel, relatorioRepo, servicoRepo, cupomRepo);
        }

    }
    public enum ConfigRepositories { SQL, ORM }
    public enum ConfigRelatorio { PDF, TXT, CSV }
}
