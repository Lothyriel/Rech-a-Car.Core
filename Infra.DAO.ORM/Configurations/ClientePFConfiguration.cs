using Dominio.PessoaModule.ClienteModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Configurations
{
    public class ClientePFConfiguration : IEntityTypeConfiguration<ClientePF>
    {
        public void Configure(EntityTypeBuilder<ClientePF> builder)
        {
            builder.ToTable("TBClientePF");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Telefone).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.DataNascimento).HasColumnType("DATETIME").IsRequired();

            builder.Property(p => p.Cnh).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.Documento).HasColumnType("CHAR(11)").IsRequired();

            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(80)").IsRequired();
        }
    }
}
