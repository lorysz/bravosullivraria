using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<Livro, LivroEmprestadoDTO>();
            CreateMap<Emprestimo, LivroEmprestadoDTO>()
                .IncludeMembers(cfg => cfg.Livro)
                .ForMember(cfg => cfg.MultaJuros, x => x.MapFrom(z => z.ValidarMulta((DateTime)z.DataDevolucao)));
            CreateMap<Livro, LivroDTO>()
                .ForMember(cfg => cfg.Status, x => x.MapFrom(z => z.Emprestimos.Where(x => x.DataDevolucao == null).Count() > 0 ? "emprestado" : "disponível"));
        }

 
    }
}
