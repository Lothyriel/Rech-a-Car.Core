using Dominio.ServicoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class ServicoConfiguration : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("TBServico");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Aluguel).WithMany().OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Taxa).IsRequired();
        }
    }
}