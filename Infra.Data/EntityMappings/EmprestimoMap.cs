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
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("Emprestimo");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.IdCliente).IsRequired().HasColumnName("IdCliente");
            builder.Property(c => c.IdLivro).HasColumnName("IdLivro");
            builder.Property(c => c.DataEmprestimo).HasColumnName("DataEmprestimo");
            builder.Property(c => c.DataDevolucao).HasColumnName("DataDevolucao");
            builder.HasOne(c => c.Cliente).WithMany(c => c.LivrosEmprestados).HasForeignKey(c => c.IdCliente);
            builder.HasOne(c => c.Livro).WithMany(c => c.Emprestimos).HasForeignKey(c => c.IdLivro);

        }
    }
}
