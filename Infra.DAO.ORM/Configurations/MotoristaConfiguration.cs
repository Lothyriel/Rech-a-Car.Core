using Dominio.Entities.PessoaModule.Condutor;
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

            builder.HasBaseType<Pessoa>();

            builder.HasOne(p => p.DadosCondutor).WithOne().OnDelete(DeleteBehavior.Cascade).HasForeignKey<Motorista>(p=>p.Id);

            builder.HasOne(p => p.ClientePJ).WithMany(p=>p.Motoristas).OnDelete(DeleteBehavior.Cascade);
        }
    }
}