using Dominio.PessoaModule;
using Infra.Extensions.Methods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Drawing;

namespace Infra.DAO.ORM.Configurations
{
    class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TBFuncionario");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Telefone).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Documento).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.Cargo);

            builder.Property(p => p.Usuario).HasColumnType("VARCHAR(30)").IsRequired();

            builder.Property(p => p.Senha).HasColumnType("VARCHAR(40)").IsRequired();

            builder.Property(p => p.Foto);
        }
    }
}
