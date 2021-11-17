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

            builder.HasOne(p => p.Funcionario).WithMany().OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Veiculo).WithMany().OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.DadosCondutor).WithMany().OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Cupom).WithMany().OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Servicos).WithOne(p=>p.Aluguel).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Cliente).WithMany().OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.DataAluguel).IsRequired();

            builder.Property(p => p.DataDevolucao).IsRequired();

            builder.Property(p => p.TipoPlano).IsRequired();
        }
    }
}