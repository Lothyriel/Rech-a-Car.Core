using Dominio.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class EnvioEmailConfiguration : IEntityTypeConfiguration<EnvioEmail>
    {
        public void Configure(EntityTypeBuilder<EnvioEmail> builder)
        {
            builder.ToTable("TBEmail");

            builder.HasKey(p => p.Id);

            //builder.Property(p => p.Id_Aluguel).HasColumnType("INT").IsRequired();

            builder.Property(p => p.DataEnvio).HasColumnType("DATE").IsRequired();

            builder.Property(p => p.StreamAttachment).HasColumnType("VARBINARY(MAX)").IsRequired();
        }
    }
}
