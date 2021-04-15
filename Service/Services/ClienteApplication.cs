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
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteService _service;
        private readonly IMapper _map;

        public ClienteApplication(IClienteService service, IMapper map)
        {
            _service = service;
            _map = map;
        }

        public List<LivroEmprestadoDTO> GetAllLivrosEmprestadosByIdCliente(int idCliente)
        {
            List<Emprestimo> emprestimos = _service.GetAllLivrosEmprestadosByIdCliente(idCliente);
            return _map.Map<List<LivroEmprestadoDTO>>(emprestimos);
        }
    }
}
