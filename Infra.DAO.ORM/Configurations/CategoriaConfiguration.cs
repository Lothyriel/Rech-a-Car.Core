using Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("TBCategoria");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.PrecoDiaria).HasColumnType("FLOAT").IsRequired();

            builder.Property(p => p.PrecoKm).HasColumnType("FLOAT").IsRequired();

            builder.Property(p => p.PrecoLivre).HasColumnType("FLOAT").IsRequired();

            builder.Property(p => p.QuilometragemFranquia).HasColumnType("INT").IsRequired();

            builder.Property(p => p.TipoDeCnh).HasColumnType("VARCHAR(80)").IsRequired();
        }
    }
}