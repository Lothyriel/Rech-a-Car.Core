using Dominio.PessoaModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("TBPessoa");

            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasAnnotation("SqlServer:Identity", "1, 1");

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Telefone).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.Documento).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.ETipoPessoa);

            builder.Ignore(p => p.TipoPessoa);
        }
    }
}
