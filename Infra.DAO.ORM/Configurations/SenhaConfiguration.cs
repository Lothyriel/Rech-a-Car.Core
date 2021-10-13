using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entities.PessoaModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.DAO.ORM.Configurations
{
    class SenhaConfiguration : IEntityTypeConfiguration<Senha>
    {
        public void Configure(EntityTypeBuilder<Senha> builder)
        {
            builder.ToTable("TBSenha");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Salt).HasColumnType("VARCHAR(MAX)").IsRequired();

            builder.Property(p => p.Hash).HasColumnType("VARCHAR(MAX)").IsRequired();
        }
    }
}