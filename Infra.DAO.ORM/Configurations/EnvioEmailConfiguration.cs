using Dominio.AluguelModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class EnvioEmailConfiguration : IEntityTypeConfiguration<RelatorioAluguel>
    {
        public void Configure(EntityTypeBuilder<RelatorioAluguel> builder)
        {
            builder.ToTable("TBEmail");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Aluguel).WithOne().HasForeignKey<RelatorioAluguel>(p=>p.Id);

            builder.Property(p => p.DataEnvio).HasColumnType("DATE");

            builder.Property(p => p.StreamAttachment).HasColumnType("VARBINARY(MAX)").IsRequired();
        }
    }
}
