using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace Infra.DAO.ORM
{
    public class rech_a_carDbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Cupom> Cupons { get; set; }
        public DbSet<ClientePF> ClientesPF { get; set; }
        public DbSet<ClientePJ> ClientesPJ { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<EnvioEmail> EnvioEmails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConfigureLog())
                .UseSqlServer(@"Data Source=(LocalDB)\\MSSqlLocalDB;Initial Catalog=DBRech-a-Car;Integrated Security=True;Pooling=False");
        }

        private ILoggerFactory ConfigureLog()
        {
            return LoggerFactory.Create(builder =>
            {
                builder.AddFilter((category, logLevel) => category == DbLoggerCategory.Database.Command.Name && logLevel == LogLevel.Information);
                builder.AddNLog();
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(rech_a_carDbContext).Assembly);

            //foreach (var entity in modelBuilder.Model.GetEntityTypes())
            //{
            //    var properties = entity.GetProperties().Where(p => p.ClrType == typeof(decimal));

            //    foreach (var property in properties)
            //    {
            //        if (string.IsNullOrEmpty(property.GetColumnType())
            //            && !property.GetMaxLength().HasValue)
            //        {
            //            property.SetColumnType("decimal(18,2)");
            //        }
            //    }
            //}
        }
    }
}