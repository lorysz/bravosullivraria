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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public List<Emprestimo> GetAllLivrosEmprestadosByIdCliente(int idCliente)
        {
            return _repository.GetAllLivrosEmprestadosByIdCliente(idCliente);
        }

        public Cliente GetById(int idCliente)
        {
            return _repository.GetById(idCliente);
        }
    }
}
