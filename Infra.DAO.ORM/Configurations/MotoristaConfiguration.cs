using Dominio.PessoaModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class MotortistaConfiguration : IEntityTypeConfiguration<Motorista>
    {
        public void Configure(EntityTypeBuilder<Motorista> builder)
        {
            builder.ToTable("TBMotorista");

            builder.HasOne(p => p.DadosCondutor);

            //builder.HasOne(p => p.Empresa).WithMany().OnDelete(DeleteBehavior.Cascade);
        }
    }
}