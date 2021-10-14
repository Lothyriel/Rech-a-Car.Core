using AluguelPDF;
using Autofac;
using Autofac.Builder;
using ConfigurationManager;
using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Repositories;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using Infra.DAO.AluguelModule;
using Infra.DAO.CupomModule;
using Infra.DAO.ORM;
using Infra.DAO.ORM.Repositories;
using Infra.DAO.ParceiroModule;
using Infra.DAO.PessoaModule;
using Infra.DAO.SQL.AluguelModule;
using Infra.DAO.SQL.PessoaModule;
using Infra.DAO.VeiculoModule;
using Infra.NLogger;
using System;

namespace DependencyInjector
{
    public class DependencyInjector
    {
        public static IContainer Container;
        private static ContainerBuilder Builder;
        static DependencyInjector()
        {
            Builder = new ContainerBuilder();
            Builder.RegisterType<rech_a_carDbContext>().As<rech_a_carDbContext>().InstancePerLifetimeScope();

            var configRepositorios = (ConfigRepositories)AppConfigManager.AppConfig["RepositorySettings"].ToObject<int>();
            var configRelatorio = (ConfigRelatorio)AppConfigManager.AppConfig["RelatorioSettings"].ToObject<int>();

            ConfigurarRelatorio(configRelatorio);
            ConfigurarRepositorios(configRepositorios, configRelatorio);

            Container = Builder.Build();
        }
        private static void ConfigurarRepositorios(ConfigRepositories configRepos, ConfigRelatorio configRelatorio)
        {
            NLogger.Logger.Aqui().Debug($"Configurando Repositórios como {configRepos}");

            switch (configRepos)
            {
                case ConfigRepositories.SQL: GerarRepositoriosSQL(); break;
                case ConfigRepositories.ORM: GerarRepositoriosORM(); break;
                default: throw new NotSupportedException();
            }

            NLogger.Logger.Aqui().Debug($"Repositórios configurados como {configRepos}");
        }
        private static void ConfigurarRelatorio(ConfigRelatorio configRelatorio)
        {
            NLogger.Logger.Aqui().Debug($"Configurando Relatório como {configRelatorio}");

            switch (configRelatorio)
            {
                case ConfigRelatorio.PDF: Builder.RegisterType<IRelatorio>().As<PDFAluguel>().SingleInstance(); break;
                case ConfigRelatorio.TXT: throw new NotImplementedException();
                case ConfigRelatorio.CSV: throw new NotImplementedException();
                default: throw new NotImplementedException();
            }

            NLogger.Logger.Aqui().Debug($"Relatório configurado como {configRelatorio}");
        }
        private static void GerarRepositoriosSQL()
        {
            Builder.RegisterType<ICategoriaRepository>().As<CategoriaDAO>().SingleInstance();
            Builder.RegisterType<IVeiculoRepository>().As<VeiculoDAO>().SingleInstance();
            Builder.RegisterType<IFuncionarioRepository>().As<FuncionarioDAO>().SingleInstance();
            Builder.RegisterType<IParceiroRepository>().As<ParceiroDAO>().SingleInstance();
            Builder.RegisterType<IMotoristaRepository>().As<MotoristaDAO>().SingleInstance();
            Builder.RegisterType<IClienteRepository>().As<ClienteJoinDAO>().SingleInstance();
            Builder.RegisterType<IClientePJRepository>().As<ClientePJDAO>().SingleInstance();
            Builder.RegisterType<IClientePFRepository>().As<ClientePFDAO>().SingleInstance();
            Builder.RegisterType<IAluguelFechadoRepository>().As<AluguelFechadoDAO>().SingleInstance();
            Builder.RegisterType<IAluguelRepository>().As<AluguelDAO>().SingleInstance();
            Builder.RegisterType<IServicoRepository>().As<ServicoDAO>().SingleInstance();
            Builder.RegisterType<ICupomRepository>().As<CupomDAO>().SingleInstance();
            Builder.RegisterType<IRelatorioRepository>().As<RelatorioDAO>().SingleInstance();
            Builder.RegisterType<ICnhRepository>().As<CnhDAO>().SingleInstance();
            Builder.RegisterType<ISenhaRepository>().As<SenhaDAO>().SingleInstance();
        }
        private static void GerarRepositoriosORM()
        {
            Builder.RegisterType<ICategoriaRepository>().As<CategoriaORM>().SingleInstance();
            Builder.RegisterType<IVeiculoRepository>().As<VeiculoORM>().SingleInstance();
            Builder.RegisterType<IFuncionarioRepository>().As<FuncionarioORM>().SingleInstance();
            Builder.RegisterType<IParceiroRepository>().As<ParceiroORM>().SingleInstance();
            Builder.RegisterType<IMotoristaRepository>().As<MotoristaORM>().SingleInstance();
            Builder.RegisterType<IClienteRepository>().As<ClienteJoinORM>().SingleInstance();
            Builder.RegisterType<IClientePJRepository>().As<ClientePJORM>().SingleInstance();
            Builder.RegisterType<IClientePFRepository>().As<ClientePFORM>().SingleInstance();
            Builder.RegisterType<IAluguelFechadoRepository>().As<AluguelFechadoORM>().SingleInstance();
            Builder.RegisterType<IAluguelRepository>().As<AluguelORM>().SingleInstance();
            Builder.RegisterType<IServicoRepository>().As<ServicosORM>().SingleInstance();
            Builder.RegisterType<ICupomRepository>().As<CupomORM>().SingleInstance();
            Builder.RegisterType<IRelatorioRepository>().As<RelatorioORM>().SingleInstance();
            Builder.RegisterType<ICnhRepository>().As<CnhORM>().SingleInstance();
            Builder.RegisterType<ISenhaRepository>().As<SenhaORM>().SingleInstance();
        }
        private enum ConfigRepositories { SQL, ORM }
        private enum ConfigRelatorio { PDF, TXT, CSV }
    }
}