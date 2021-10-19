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

            builder.HasBaseType<Cliente>();

            builder.HasMany(p => p.Motoristas).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}