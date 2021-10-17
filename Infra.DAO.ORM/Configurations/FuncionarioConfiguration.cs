using Dominio.PessoaModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TBFuncionario");

            builder.Property(p => p.Cargo);

            builder.Property(p => p.Usuario).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.Foto);

            builder.Ignore(p => p.Senha);
        }
    }
}
