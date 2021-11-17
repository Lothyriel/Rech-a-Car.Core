using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TBCliente");

            builder.HasBaseType<Pessoa>();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)").IsRequired();
        }
    }
}
