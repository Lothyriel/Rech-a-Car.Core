using Dominio.AluguelModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class AluguelConfiguration : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.ToTable("TBAluguel");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Funcionario).WithMany();

            builder.HasOne(p => p.Veiculo).WithMany();

            builder.HasOne(p => p.Condutor).WithMany();

            builder.HasOne(p => p.Cupom).WithMany();

            builder.HasMany(p => p.Servicos).WithOne();

            builder.HasOne(p => p.Cliente).WithMany();

            builder.Property(p => p.DataAluguel).HasColumnType("DATE").IsRequired();

            builder.Property(p => p.DataDevolucao).HasColumnType("DATE").IsRequired();

            builder.Property(p => p.TipoPlano).IsRequired();
        }
    }
}