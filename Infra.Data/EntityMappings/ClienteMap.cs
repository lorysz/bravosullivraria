using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infra.Data.EntityMappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public virtual void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome");
            builder.Property(c => c.Cpf).HasColumnName("Cpf");
            builder.Property(c => c.Celular).HasColumnName("Celular");
            builder.Property(c => c.Email).HasColumnName("Email");
            builder.HasMany(c => c.LivrosReservados).WithOne(c => c.ClienteReserva).HasForeignKey(c => c.IdClienteReserva);
        }
    }
}
