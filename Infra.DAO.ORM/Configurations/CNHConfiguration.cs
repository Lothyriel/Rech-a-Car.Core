using Dominio.PessoaModule;
using Dominio.PessoaModule.Condutor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    class CNHConfiguration : IEntityTypeConfiguration<CNH>
    {
        public void Configure(EntityTypeBuilder<CNH> builder)
        {
            builder.ToTable("TBCnh");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.NumeroCnh).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.TipoCnh).IsRequired();
        }
    }
}
