using Dominio.PessoaModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class MotortistaConfiguration : IEntityTypeConfiguration<Motorista>
    {
        public void Configure(EntityTypeBuilder<Motorista> builder)
        {
            builder.ToTable("TBMotortista");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Telefone).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.Documento).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.Cnh).HasColumnType("CHAR(11)").IsRequired();

            builder.HasOne(p => p.Empresa);
        }
    }
}