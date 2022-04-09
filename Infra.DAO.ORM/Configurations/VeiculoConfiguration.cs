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

            builder.HasOne(p => p.Categoria).WithMany().OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.Modelo).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.Marca).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.Placa).HasColumnType("CHAR(7)").IsRequired();

            builder.Property(p => p.Chassi).HasColumnType("CHAR(17)").IsRequired();

            builder.Property(p => p.Capacidade).IsRequired();

            builder.Property(p => p.CapacidadeTanque).IsRequired();

            builder.Property(p => p.Portas).IsRequired();

            builder.Property(p => p.PortaMalas).IsRequired();

            builder.Property(p => p.Ano).IsRequired();

            builder.Property(p => p.Automatico).IsRequired();

            builder.Property(p => p.Quilometragem).IsRequired();

            builder.Property(p => p.Foto).IsRequired();

            builder.Property(p => p.TipoDeCombustivel).IsRequired();
        }
    }
}