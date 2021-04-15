using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;
        private readonly IClienteService _clienteService;

        public LivroService(ILivroRepository repository, IClienteService clienteService)
        {
            _repository = repository;
            _clienteService = clienteService;

        }

        public List<Livro> GetAll()
        {
            return _repository.GetAll();
        }

        public void ReservarLivro(int idLivro)
        {
            var livro = _repository.GetLivroById(idLivro);

            if (livro != null) {
                var cliente = _clienteService.GetById(1);
                livro.ClienteReserva = cliente;
                _repository.ReservarLivro(livro);
            }
        }
    }
}
