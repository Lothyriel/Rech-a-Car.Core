using AluguelPDF;
using Autofac;
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
using Infra.DAO.VeiculoModule;
using Infra.NLogger;
using System;

namespace DependencyInjector
{
    public class DependencyInjection
    {
        public static IContainer Container;
        private static ContainerBuilder Builder = new ContainerBuilder();
        static DependencyInjection()
        {
            Builder.RegisterType<Rech_a_carDbContext>().InstancePerLifetimeScope();

            var configRepositorios = (ConfigRepositories)AppConfigManager.AppConfig["RepositorySettings"].ToObject<int>();
            var configRelatorio = (ConfigRelatorio)AppConfigManager.AppConfig["RelatorioSettings"].ToObject<int>();

            ConfigurarRelatorio(configRelatorio);
            ConfigurarRepositorios(configRepositorios);

            Container = Builder.Build();
        }
        private static void ConfigurarRepositorios(ConfigRepositories configRepos)
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
                case ConfigRelatorio.PDF: Builder.RegisterType<PDFAluguel>().As<IRelatorio>().SingleInstance(); break;
                case ConfigRelatorio.TXT: throw new NotImplementedException();
                case ConfigRelatorio.CSV: throw new NotImplementedException();
                default: throw new NotImplementedException();
            }

            NLogger.Logger.Aqui().Debug($"Relatório configurado como {configRelatorio}");
        }
        private static void GerarRepositoriosSQL()
        {
            Builder.RegisterType<CategoriaDAO>().As<ICategoriaRepository>().SingleInstance();
            Builder.RegisterType<VeiculoDAO>().As<IVeiculoRepository>().SingleInstance();
            Builder.RegisterType<FuncionarioDAO>().As<IFuncionarioRepository>().SingleInstance();
            Builder.RegisterType<ParceiroDAO>().As<IParceiroRepository>().SingleInstance();
            Builder.RegisterType<MotoristaDAO>().As<IMotoristaRepository>().SingleInstance();
            Builder.RegisterType<ClientePJDAO>().As<IClientePJRepository>().SingleInstance();
            Builder.RegisterType<ClientePFDAO>().As<IClientePFRepository>().SingleInstance();
            Builder.RegisterType<AluguelFechadoDAO>().As<IAluguelFechadoRepository>().SingleInstance();
            Builder.RegisterType<AluguelDAO>().As<IAluguelRepository>().SingleInstance();
            Builder.RegisterType<ServicoDAO>().As<IServicoRepository>().SingleInstance();
            Builder.RegisterType<CupomDAO>().As<ICupomRepository>().SingleInstance();
            Builder.RegisterType<RelatorioDAO>().As<IRelatorioRepository>().SingleInstance();
            Builder.RegisterType<SenhaDAO>().As<ISenhaRepository>().SingleInstance();
        }
        private static void GerarRepositoriosORM()
        {
            Builder.RegisterType<CategoriaORM>().As<ICategoriaRepository>().SingleInstance();
            Builder.RegisterType<VeiculoORM>().As<IVeiculoRepository>().SingleInstance();
            Builder.RegisterType<FuncionarioORM>().As<IFuncionarioRepository>().SingleInstance();
            Builder.RegisterType<ParceiroORM>().As<IParceiroRepository>().SingleInstance();
            Builder.RegisterType<MotoristaORM>().As<IMotoristaRepository>().SingleInstance();
            Builder.RegisterType<ClientePJORM>().As<IClientePJRepository>().SingleInstance();
            Builder.RegisterType<ClientePFORM>().As<IClientePFRepository>().SingleInstance();
            Builder.RegisterType<AluguelFechadoORM>().As<IAluguelFechadoRepository>().SingleInstance();
            Builder.RegisterType<AluguelORM>().As<IAluguelRepository>().SingleInstance();
            Builder.RegisterType<ServicoORM>().As<IServicoRepository>().SingleInstance();
            Builder.RegisterType<CupomORM>().As<ICupomRepository>().SingleInstance();
            Builder.RegisterType<RelatorioORM>().As<IRelatorioRepository>().SingleInstance();
            Builder.RegisterType<SenhaORM>().As<ISenhaRepository>().SingleInstance();
        }
        private enum ConfigRepositories { SQL, ORM }
        private enum ConfigRelatorio { PDF, TXT, CSV }
    }
}