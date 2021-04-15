using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class LivroApplication : ILivroApplication
    {
        private readonly ILivroService _service;
        private readonly IMapper _map;

        public LivroApplication(ILivroService service, IMapper map)
        {
            _service = service;
            _map = map;
        }

        public List<LivroDTO> GetAll()
        {
            List<Livro> livros = _service.GetAll();
            return _map.Map<List<LivroDTO>>(livros);
        }

        public void ReservarLivro(int IdLivro)
        {
            _service.ReservarLivro(IdLivro);
        }
    }
}
