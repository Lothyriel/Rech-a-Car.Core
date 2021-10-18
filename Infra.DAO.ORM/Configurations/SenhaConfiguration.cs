using Dominio.Entities.PessoaModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class SenhaConfiguration : IEntityTypeConfiguration<SenhaHashed>
    {
        public void Configure(EntityTypeBuilder<SenhaHashed> builder)
        {
            builder.ToTable("TBSenha");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Salt).HasColumnType("VARBINARY(MAX)").IsRequired();

            builder.Property(p => p.Hash).HasColumnType("VARCHAR(MAX)").IsRequired();
        }
    }
}