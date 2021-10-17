using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule;
using Dominio.PessoaModule.Condutor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class CondutorConfiguration : IEntityTypeConfiguration<DadosCondutor>
    {
        public void Configure(EntityTypeBuilder<DadosCondutor> builder)
        {
            builder.ToTable("TBDadosCondutor");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Cnh).WithOne().HasForeignKey<CNH>(p => p.Id);

            builder.HasMany(p => p.Multas).WithOne();
        }
    }
}
