using Dominio.CupomModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    class CupomConfiguration : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("TBCupom");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.ValorFixo).HasColumnType("FLOAT").IsRequired();

            builder.Property(p => p.ValorPercentual).HasColumnType("INT").IsRequired();

            builder.Property(p => p.DataValidade).HasColumnType("DATE");

            builder.HasOne(p => p.Parceiro).WithMany();

            builder.Property(p => p.ValorMinimo).HasColumnType("FLOAT").IsRequired();

            builder.Property(p => p.Usos).HasColumnType("INT").IsRequired();
        }
    }
}