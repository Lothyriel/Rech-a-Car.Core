using Dominio.PessoaModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DAO.ORM.Configurations
{
    public class TipoPessoaConfiguration : IEntityTypeConfiguration<TipoPessoa>
    {
        public void Configure(EntityTypeBuilder<TipoPessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Documento).HasColumnType("VARCHAR(20)").IsRequired();
        }
    }
}
