using Dominio.Entities.PessoaModule.Condutor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    class DadosCondutorConfiguration : IEntityTypeConfiguration<DadosCondutor>
    {
        public void Configure(EntityTypeBuilder<DadosCondutor> builder)
        {
            builder.ToTable("TBDadosCondutor");

            builder.HasKey(p => p.Id);

            builder.OwnsOne(p => p.Cnh);

            builder.HasMany(p => p.Multas);
        }
    }
}
