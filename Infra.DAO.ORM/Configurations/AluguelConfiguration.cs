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

            builder.HasOne(p => p.Funcionario);

            builder.HasOne(p => p.Veiculo);

            builder.HasOne(p => p.Condutor);

            builder.HasOne(p => p.Cupom);

            builder.HasMany(p => p.Servicos);

            builder.Property(p => p.Cliente).HasColumnType("VARCHAR(80)").IsRequired(); //columntype...

            builder.Property(p => p.DataAluguel).HasColumnType("DATE").IsRequired();

            builder.Property(p => p.DataDevolucao).HasColumnType("DATE").IsRequired();

            builder.Property(p => p.TipoPlano).HasColumnType("VARCHAR(20)").IsRequired();
        }
    }
}