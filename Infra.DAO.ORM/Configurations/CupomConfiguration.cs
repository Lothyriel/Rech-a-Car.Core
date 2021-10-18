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

            builder.HasOne(p => p.Parceiro);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.ValorFixo).IsRequired();

            builder.Property(p => p.ValorPercentual).IsRequired();

            builder.Property(p => p.DataValidade).IsRequired();

            builder.Property(p => p.ValorMinimo).IsRequired();

            builder.Property(p => p.Usos).IsRequired();
        }
    }
}