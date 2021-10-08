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

            builder.Property(p => p.Salt).HasColumnType("BINARY(16)").IsRequired();

            builder.Property(p => p.Hash).HasColumnType("STRING").IsRequired();
        }
    }
}