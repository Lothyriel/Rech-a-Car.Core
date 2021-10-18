using ConfigurationManager;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using Infra.Extensions.Methods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System.Drawing;
using System.IO;

namespace Infra.DAO.ORM
{
    public class Rech_a_carDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseLoggerFactory(ConfigureLog())
                .UseSqlServer(AppConfigManager.AppConfig["BancoDeDados"]["ConnectionString"].ToString());
        }

        private static ILoggerFactory ConfigureLog()
        {
            return LoggerFactory.Create(builder =>
            {
                builder.AddFilter((category, logLevel) => category == DbLoggerCategory.Database.Command.Name && logLevel == LogLevel.Information);
                builder.AddNLog();
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Rech_a_carDbContext).Assembly);
            var imageConverter = new ValueConverter<Image, byte[]>(
                p => p.ToByteArray(null),
                p => p.ToImage());

            var memoryStreamConverter = new ValueConverter<MemoryStream, byte[]>(
                p => p.ToArray(),
                p => p.ToMemoryStream());

            var tipoPessoaConverter = new ValueConverter<TipoPessoa, string>(
                p => p.Documento,
                p => p.Length == 11 ? new CPF(p) : new CNPJ(p));

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(Image))
                        property.SetValueConverter(imageConverter);

                    if (property.ClrType == typeof(MemoryStream))
                        property.SetValueConverter(memoryStreamConverter);

                    if (property.ClrType == typeof(TipoPessoa))
                        property.SetValueConverter(tipoPessoaConverter);
                }
            }
        }
    }
}
