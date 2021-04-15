using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.EntityMappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.Titulo).IsRequired().HasColumnName("Titulo");
            builder.Property(c => c.Genero).HasColumnName("Genero");
            builder.Property(c => c.Autor).HasColumnName("Autor");
            builder.Property(c => c.IdClienteReserva).HasColumnName("IdClienteReserva");
            builder.HasMany(c => c.Emprestimos).WithOne(c => c.Livro).HasForeignKey(c => c.IdLivro);
            builder.HasOne(c => c.ClienteReserva).WithMany(c => c.LivrosReservados).HasForeignKey(c => c.IdClienteReserva);
        }
    }
}
