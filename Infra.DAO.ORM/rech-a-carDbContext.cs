using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Infra.DAO.ORM
{
    public class rech_a_carDbContext : DbContext
    {
        private static ILoggerFactory loggerFactoryConsole = LoggerFactory.Create(x => x.AddConsole());

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<ClientePF> ClientesPF { get; set; }
        public DbSet<ClientePJ> ClientesPJ { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(loggerFactoryConsole)
                .UseSqlServer(@"Data Source=(LocalDB)\\MSSqlLocalDB;Initial Catalog=DBRech-a-Car;Integrated Security=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(rech_a_carDbContext).Assembly);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(decimal));

                foreach (var property in properties)
                {
                    if (string.IsNullOrEmpty(property.GetColumnType())
                        && !property.GetMaxLength().HasValue)
                    {
                        property.SetColumnType("decimal(18,2)");
                    }
                }
            }
        }
    }
}