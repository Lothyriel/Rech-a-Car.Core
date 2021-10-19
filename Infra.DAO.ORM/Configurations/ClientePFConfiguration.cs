using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.ClienteModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class ClientePFConfiguration : IEntityTypeConfiguration<ClientePF>
    {
        public void Configure(EntityTypeBuilder<ClientePF> builder)
        {
            builder.ToTable("TBClientePF");

            builder.Property(p => p.DataNascimento).IsRequired();

            builder.HasOne(p => p.DadosCondutor).WithOne().OnDelete(DeleteBehavior.Cascade).HasForeignKey<ClientePF>(p=>p.Id);
        }
    }
}
