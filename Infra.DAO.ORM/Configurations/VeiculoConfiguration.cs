using Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("TBVeiculo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Modelo).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.Marca).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.Placa).HasColumnType("CHAR(8)").IsRequired();

            builder.Property(p => p.Chassi).HasColumnType("CHAR(17)").IsRequired();

            builder.Property(p => p.Capacidade).HasColumnType("INT").IsRequired();

            builder.Property(p => p.CapacidadeTanque).HasColumnType("INT").IsRequired();

            builder.Property(p => p.Portas).HasColumnType("INT").IsRequired();

            builder.Property(p => p.Porta_malas).HasColumnType("INT").IsRequired();

            builder.Property(p => p.Ano).HasColumnType("INT").IsRequired();

            builder.Property(p => p.Automatico).HasColumnType("BIT").IsRequired();

            builder.Property(p => p.Quilometragem).HasColumnType("INT").IsRequired();

            builder.Property(p => p.Foto).IsRequired();

            builder.Property(p => p.TipoDeCombustivel).IsRequired();
        }
    }
}