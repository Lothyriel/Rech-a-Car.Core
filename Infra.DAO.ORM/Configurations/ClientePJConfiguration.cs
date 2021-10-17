using Dominio.PessoaModule.ClienteModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    class ClientePJConfiguration : IEntityTypeConfiguration<ClientePJ>
    {
        public void Configure(EntityTypeBuilder<ClientePJ> builder)
        {
            builder.ToTable("TBClientePJ");

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Telefone).HasColumnType("CHAR(11)").IsRequired();

            builder.HasOne(p => p.TipoPessoa);

            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(80)").IsRequired();

            builder.HasMany(p => p.Motoristas).WithOne();
        }
    }
}